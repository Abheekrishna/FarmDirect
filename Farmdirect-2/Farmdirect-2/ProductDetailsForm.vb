Imports Microsoft.Data.SqlClient
Imports System.IO

Public Class ProductDetailsForm
    Private ProductID As Integer
    Public CurrentProductID As Integer





    Public Sub New(selectedProductID As Integer)
        InitializeComponent()
        Me.ProductID = selectedProductID
    End Sub

    Private Sub ProductDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductDetails(ProductID)
        lvFeedback.OwnerDraw = True

        lvFeedback.Columns.Clear()
        lvFeedback.Columns.Add("User", 100)
        lvFeedback.Columns.Add("Rating", 150)
        lvFeedback.Columns.Add("Feedback", 250)
        lvFeedback.Columns.Add("Date", 100)
        LoadFeedback()
        CheckIfUserCanGiveFeedback()
    End Sub


    Public Sub LoadProductDetails(ProductID As Integer)

        CurrentProductID = ProductID
        Dim query As String = "SELECT ProductName, Description, Price, Quantity, Image, FarmerName FROM Products WHERE ProductID = @ProductID"

        Dim db As New DBHelper()
        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@ProductID", ProductID)
        }
        Dim dt As DataTable = db.ExecuteQuery(query, params)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            lblProductName.Text = row("ProductName").ToString()
            lblDescription.Text = row("Description").ToString()
            txtQuantity.Text = row("Quantity").ToString()
            lblFarmer.Text = row("FarmerName").ToString()
            lblPrice.Text = "₹" & row("Price").ToString()


            Dim imageData As Byte() = TryCast(row("Image"), Byte())
            If imageData IsNot Nothing Then
                Using ms As New MemoryStream(imageData)
                    picProduct.Image = Image.FromStream(ms)
                End Using
            End If
        End If
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click

        If CurrentProductID = 0 Or LoggedInConsumerID = 0 Then
            MessageBox.Show("Invalid product or user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim db As New DBHelper()


        Dim checkQuery As String = "SELECT Quantity FROM Cart WHERE ConsumerID = @ConsumerID AND ProductID = @ProductID"
        Dim checkParams As New List(Of SqlParameter) From {
            New SqlParameter("@ConsumerID", LoggedInConsumerID),
            New SqlParameter("@ProductID", CurrentProductID)
        }

        Dim existingQuantity As Object = db.ExecuteScalar(checkQuery, checkParams)

        Dim newQuantity As Integer = 1

        If existingQuantity IsNot Nothing AndAlso Not DBNull.Value.Equals(existingQuantity) Then

            newQuantity = Convert.ToInt32(existingQuantity) + 1
            Dim updateQuery As String = "UPDATE Cart SET Quantity = @Quantity WHERE ConsumerID = @ConsumerID AND ProductID = @ProductID"
            Dim updateParams As New List(Of SqlParameter) From {
                New SqlParameter("@ConsumerID", LoggedInConsumerID),
                New SqlParameter("@ProductID", CurrentProductID),
                New SqlParameter("@Quantity", newQuantity)
            }
            db.ExecuteNonQuery(updateQuery, updateParams)
        Else

            Dim insertQuery As String = "INSERT INTO Cart (ConsumerID, ProductID, Quantity, AddedDate) VALUES (@ConsumerID, @ProductID, @Quantity, GETDATE())"
            Dim insertParams As New List(Of SqlParameter) From {
                New SqlParameter("@ConsumerID", LoggedInConsumerID),
                New SqlParameter("@ProductID", CurrentProductID),
                New SqlParameter("@Quantity", newQuantity)
            }
            db.ExecuteNonQuery(insertQuery, insertParams)
        End If


        Dim toolTip As New ToolTip()
        toolTip.Show($"Added to cart (Qty: {newQuantity})", btnAddToCart, 1000)
    End Sub

    Private Sub lvFeedback_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles lvFeedback.DrawSubItem
        If e.ColumnIndex = 1 Then ' Rating column (stars)
            Dim starText As String = e.SubItem.Text
            Dim starFont As New Font("Arial", 12, FontStyle.Bold)
            Dim brush As New SolidBrush(Color.Goldenrod) ' Yellow color for stars

            e.Graphics.DrawString(starText, starFont, brush, e.Bounds.X, e.Bounds.Y)
        Else
            ' Default drawing for other columns
            e.DrawDefault = True
        End If
    End Sub

    Private Sub lvFeedback_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lvFeedback.DrawColumnHeader
        e.DrawDefault = True ' This ensures the default column header is drawn
    End Sub


    Private Sub LoadFeedback()
        lvFeedback.Items.Clear()

        Dim query As String = "SELECT c.ConsumerID, f.Rating, f.Comments, f.CreatedAt 
                       FROM Feedback f 
                       INNER JOIN Consumers c ON f.ConsumerID = c.ConsumerID 
                       WHERE f.ProductID = @ProductID 
                       ORDER BY f.CreatedAt DESC"

        Dim db As New DBHelper()
        Dim params As New List(Of SqlParameter) From {
        New SqlParameter("@ProductID", CurrentProductID)
    }

        Using reader As SqlDataReader = db.ExecuteReader(query, params)
            While reader.Read()
                Dim username As String = reader("ConsumerID").ToString()
                Dim rating As Integer = Convert.ToInt32(reader("Rating"))
                Dim comments As String = reader("Comments").ToString()
                Dim dateStr As String = Convert.ToDateTime(reader("CreatedAt")).ToString("dd/MM/yyyy")

                ' Convert rating number to stars
                Dim stars As String = New String("★"c, rating) & New String("☆"c, 5 - rating)

                ' Create ListViewItem
                Dim item As New ListViewItem(username)
                item.SubItems.Add(stars)  ' Display stars instead of number
                item.SubItems.Add(comments)
                item.SubItems.Add(dateStr)

                lvFeedback.Items.Add(item)
            End While
        End Using
    End Sub



    Private Sub CheckIfUserCanGiveFeedback()
        Dim db As New DBHelper()

        ' Check if the logged-in user is a consumer
        Dim consumerQuery As String = "SELECT COUNT(*) FROM Consumers WHERE ConsumerID = @ConsumerID"
        Dim consumerParams As New List(Of SqlParameter) From {
        New SqlParameter("@ConsumerID", LoggedInConsumerID)
    }
        Dim isConsumer As Integer = Convert.ToInt32(db.ExecuteScalar(consumerQuery, consumerParams))

        ' If the user is not a consumer, hide the feedback section
        If isConsumer = 0 Then
            HideFeedbackSection()
            Exit Sub
        End If

        ' Check if the product belongs to the logged-in user (i.e., if they are a farmer)
        Dim farmerCheckQuery As String = "SELECT COUNT(*) FROM Products WHERE ProductID = @ProductID AND FarmerID = @FarmerID"
        Dim farmerParams As New List(Of SqlParameter) From {
        New SqlParameter("@ProductID", CurrentProductID),
        New SqlParameter("@FarmerID", LoggedInFarmerID)
    }
        Dim isFarmerProduct As Integer = Convert.ToInt32(db.ExecuteScalar(farmerCheckQuery, farmerParams))

        ' Prevent farmers from reviewing their own products
        If isFarmerProduct > 0 Then
            HideFeedbackSection()
            Exit Sub
        End If

        ' Check if consumer has purchased the product
        Dim query As String = "SELECT COUNT(*) FROM Orders 
                           WHERE ConsumerID = @ConsumerID AND ProductID = @ProductID AND Status <> 'Cancelled'"
        Dim params As New List(Of SqlParameter) From {
        New SqlParameter("@ConsumerID", LoggedInConsumerID),
        New SqlParameter("@ProductID", CurrentProductID)
    }
        Dim purchaseCount As Integer = Convert.ToInt32(db.ExecuteScalar(query, params))

        If purchaseCount > 0 Then
            ' Show feedback section
            Label2.Visible = True
            Label3.Visible = True
            txtComment.Visible = True
            numRating.Visible = True
            btnSubmitFeedback.Visible = True

            txtComment.Enabled = True
            numRating.Enabled = True
            btnSubmitFeedback.Enabled = True
        Else
            HideFeedbackSection()
        End If
    End Sub

    Private Sub HideFeedbackSection()
        Label2.Visible = False
        Label3.Visible = False
        txtComment.Visible = False
        numRating.Visible = False
        btnSubmitFeedback.Visible = False
    End Sub




    Private Sub btnSubmitFeedback_Click(sender As Object, e As EventArgs) Handles btnSubmitFeedback.Click
        If String.IsNullOrWhiteSpace(txtComment.Text) OrElse numRating.Value = 0 Then
            MessageBox.Show("Please enter feedback and select a rating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim db As New DBHelper()

        ' Check if the logged-in user is a consumer
        Dim consumerQuery As String = "SELECT COUNT(*) FROM Consumers WHERE ConsumerID = @ConsumerID"
        Dim consumerParams As New List(Of SqlParameter) From {
        New SqlParameter("@ConsumerID", LoggedInConsumerID)
    }
        Dim isConsumer As Integer = Convert.ToInt32(db.ExecuteScalar(consumerQuery, consumerParams))

        ' Prevent non-consumers from submitting feedback
        If isConsumer = 0 Then
            MessageBox.Show("Only consumers can submit feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check if the user has already given feedback
        Dim checkQuery As String = "SELECT COUNT(*) FROM Feedback WHERE ProductID = @ProductID AND ConsumerID = @ConsumerID"
        Dim checkParams As New List(Of SqlParameter) From {
        New SqlParameter("@ProductID", CurrentProductID),
        New SqlParameter("@ConsumerID", LoggedInConsumerID)
    }
        Dim feedbackCount As Integer = Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams))

        If feedbackCount > 0 Then
            MessageBox.Show("You have already submitted feedback for this product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Insert new feedback
        Dim query As String = "INSERT INTO Feedback (ProductID, ConsumerID, Rating, Comments, CreatedAt) 
                           VALUES (@ProductID, @ConsumerID, @Rating, @Comments, @CreatedAt)"
        Dim params As New List(Of SqlParameter) From {
        New SqlParameter("@ProductID", CurrentProductID),
        New SqlParameter("@ConsumerID", LoggedInConsumerID),
        New SqlParameter("@Rating", numRating.Value),
        New SqlParameter("@Comments", txtComment.Text),
        New SqlParameter("@CreatedAt", DateTime.Now)
    }

        Dim result As Integer = db.ExecuteNonQuery(query, params)

        If result > 0 Then
            MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtComment.Clear()
            numRating.Value = 1
            LoadFeedback() ' Refresh feedback list
        Else
            MessageBox.Show("Failed to submit feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub btnBuyNow_Click(sender As Object, e As EventArgs) Handles btnBuyNow.Click

        Dim quantity As Integer = 1
        If CurrentProductID = 0 Or LoggedInConsumerID = 0 Then
            MessageBox.Show("Invalid product or user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim paymentForm As New PaymentForm(CurrentProductID, quantity)
        paymentForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ConsumerProductForm.Show()
        Me.Hide()
    End Sub
End Class
