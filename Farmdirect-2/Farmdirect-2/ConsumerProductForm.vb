Imports System.IO

Public Class ConsumerProductForm
    Private Sub ConsumerProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub


    Private Sub LoadProducts()
        Dim query As String = "SELECT P.ProductID, P.ProductName, P.Description, P.Price, F.FarmerName, P.Image
                       FROM Products P 
                       INNER JOIN Farmers F ON P.FarmerID = F.FarmerID
                       WHERE P.Quantity > 0"

        Dim db As New DBHelper()
        Dim dt As DataTable = db.ExecuteQuery(query)

        flpProducts.Controls.Clear()

        For Each row As DataRow In dt.Rows
            Dim productID As Integer = Convert.ToInt32(row("ProductID"))
            Dim productPanel As New Panel With {
            .Size = New Size(200, 250),
            .BorderStyle = BorderStyle.FixedSingle,
            .Tag = productID
        }

            Dim pbImage As New PictureBox With {
            .Size = New Size(180, 120),
            .SizeMode = PictureBoxSizeMode.Zoom,
            .Location = New Point(10, 10),
            .Tag = productID
        }

            Dim imageData As Byte() = TryCast(row("Image"), Byte())
            If imageData IsNot Nothing Then
                Using ms As New MemoryStream(imageData)
                    pbImage.Image = Image.FromStream(ms)
                End Using
            End If

            Dim lblName As New Label With {
            .Text = row("ProductName").ToString(),
            .AutoSize = True,
            .Location = New Point(10, 140),
            .Font = New Font("Arial", 10, FontStyle.Bold)
        }

            Dim lblPrice As New Label With {
            .Text = "₹" & row("Price").ToString(),
            .AutoSize = True,
            .Location = New Point(10, 160),
            .Font = New Font("Arial", 10)
        }

            Dim lblFarmer As New Label With {
            .Text = "Farmer: " & row("FarmerName").ToString(),
            .AutoSize = True,
            .Location = New Point(10, 180),
            .Font = New Font("Arial", 9, FontStyle.Italic)
        }

            AddHandler productPanel.Click, AddressOf Product_Click
            AddHandler pbImage.Click, AddressOf Product_Click
            AddHandler lblName.Click, AddressOf Product_Click

            productPanel.Controls.Add(pbImage)
            productPanel.Controls.Add(lblName)
            productPanel.Controls.Add(lblPrice)
            productPanel.Controls.Add(lblFarmer)

            flpProducts.Controls.Add(productPanel)
        Next
    End Sub


    Private Sub Product_Click(sender As Object, e As EventArgs)
        Dim productID As Integer


        If TypeOf sender Is Button Then
            Dim btn As Button = CType(sender, Button)
            productID = Convert.ToInt32(btn.Tag)
        ElseIf TypeOf sender Is PictureBox Then
            Dim pic As PictureBox = CType(sender, PictureBox)
            productID = Convert.ToInt32(pic.Tag)
        Else

            Exit Sub
        End If


        Dim detailsForm As New ProductDetailsForm(productID)
        detailsForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ConsumerHome.Show()
        Me.Hide()
    End Sub
End Class
