Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class PaymentCart
    Private DeliveryDate As DateTime = DateTime.Now.AddDays(7) ' Set delivery date 1 week ahead

    ' Constructor
    Private CurrentProductID As Integer
    Private Quantity As Integer
    Private SelectedProductID As Integer


    ' Constructor
    Public Sub New(productID As Integer, qty As Integer)
        InitializeComponent()
        SelectedProductID = productID
        Quantity = qty
    End Sub


    Private Sub PaymentCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCartDetails()
        LoadConsumerDetails()

        ' Set default payment method
        cmbPaymentMethod.Items.Add("Cash on Delivery")
        cmbPaymentMethod.Items.Add("Credit Card")
        cmbPaymentMethod.SelectedIndex = 0 ' Default to COD

        ' Hide credit card details initially
        pnlCreditCardDetails.Visible = False
    End Sub

    Private Sub cmbPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentMethod.SelectedIndexChanged
        pnlCreditCardDetails.Visible = (cmbPaymentMethod.SelectedItem.ToString() = "Credit Card")
    End Sub

    Private Sub LoadConsumerDetails()
        Dim query As String = "SELECT ConsumerName, (Street + ', ' + City + ', ' + State) AS Address FROM Consumers WHERE ConsumerID = @ConsumerID"

        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@ConsumerID", LoggedInConsumerID)
        }

        Dim db As New DBHelper()
        Using reader As SqlDataReader = db.ExecuteReader(query, params)
            If reader.Read() Then
                txtConsumerName.Text = reader("ConsumerName").ToString()
                txtAddress.Text = reader("Address").ToString()
            End If
        End Using
    End Sub

    Private Sub LoadCartDetails()
        dgvPaymentCart.Columns.Clear()
        dgvPaymentCart.Columns.Add("ProductID", "Product ID")
        dgvPaymentCart.Columns.Add("ProductName", "Product Name")
        dgvPaymentCart.Columns.Add("Quantity", "Quantity")
        dgvPaymentCart.Columns.Add("TotalPrice", "Total Price")
        dgvPaymentCart.Rows.Clear()

        Dim query As String = "SELECT c.ProductID, p.ProductName, c.Quantity, p.Price 
                               FROM Cart c 
                               JOIN Products p ON c.ProductID = p.ProductID 
                               WHERE c.ConsumerID = @ConsumerID"

        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@ConsumerID", LoggedInConsumerID)
        }

        Dim db As New DBHelper()
        Using reader As SqlDataReader = db.ExecuteReader(query, params)
            While reader.Read()
                Dim productID As Integer = Convert.ToInt32(reader("ProductID"))
                Dim productName As String = reader("ProductName").ToString()
                Dim quantity As Integer = Convert.ToInt32(reader("Quantity"))
                Dim price As Decimal = Convert.ToDecimal(reader("Price"))
                Dim totalPrice As Decimal = quantity * price

                dgvPaymentCart.Rows.Add(productID, productName, quantity, totalPrice)
            End While
        End Using

        CalculateTotalPrice()
    End Sub

    Private Sub CalculateTotalPrice()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvPaymentCart.Rows
            total += Convert.ToDecimal(row.Cells("TotalPrice").Value)
        Next
        lblTotalPrice.Text = "Total: ₹" & total.ToString("0.00")
    End Sub

    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        If cmbPaymentMethod.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim selectedPaymentMethod As String = cmbPaymentMethod.SelectedItem.ToString()

        ' If Credit Card is selected, validate card details
        If selectedPaymentMethod = "Credit Card" Then
            If Not ValidateCreditCard() Then Exit Sub
        End If

        Dim db As New DBHelper()

        ' Fetch cart details
        Dim query As String = "SELECT c.ProductID, c.Quantity, p.Price 
                           FROM Cart c 
                           JOIN Products p ON c.ProductID = p.ProductID 
                           WHERE c.ConsumerID = @ConsumerID"

        Dim params As New List(Of SqlParameter) From {
        New SqlParameter("@ConsumerID", LoggedInConsumerID)
    }

        Dim cartItems As New List(Of Tuple(Of Integer, Integer, Decimal))

        Using reader As SqlDataReader = db.ExecuteReader(query, params)
            While reader.Read()
                Dim productID As Integer = Convert.ToInt32(reader("ProductID"))
                Dim quantity As Integer = Convert.ToInt32(reader("Quantity"))
                Dim price As Decimal = Convert.ToDecimal(reader("Price"))
                cartItems.Add(Tuple.Create(productID, quantity, price))
            End While
        End Using

        If cartItems.Count = 0 Then
            MessageBox.Show("Your cart is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Insert orders for each product in the cart
        For Each item In cartItems
            Dim productID As Integer = item.Item1
            Dim quantity As Integer = item.Item2
            Dim totalPrice As Decimal = item.Item3 * quantity

            Dim farmerQuery As String = "SELECT FarmerID FROM Products WHERE ProductID = @ProductID"
            Dim farmerParams As New List(Of SqlParameter) From {
            New SqlParameter("@ProductID", productID)
        }

            Dim farmerID As Integer = 0
            Using reader As SqlDataReader = db.ExecuteReader(farmerQuery, farmerParams)
                If reader.Read() AndAlso Not IsDBNull(reader("FarmerID")) Then
                    farmerID = Convert.ToInt32(reader("FarmerID"))
                End If
            End Using

            Dim orderQuery As String = "INSERT INTO Orders (ConsumerID, ProductID, Quantity, TotalPrice, OrderDate, DeliveryDate, Status, PaymentMethod, FarmerID) 
                        VALUES (@ConsumerID, @ProductID, @Quantity, @TotalPrice, @OrderDate, @DeliveryDate, @Status, @PaymentMethod, @FarmerID)"

            Dim orderParams As New List(Of SqlParameter) From {
            New SqlParameter("@ConsumerID", LoggedInConsumerID),
            New SqlParameter("@ProductID", productID),
            New SqlParameter("@Quantity", quantity),
            New SqlParameter("@TotalPrice", totalPrice),
            New SqlParameter("@OrderDate", DateTime.Now),
            New SqlParameter("@DeliveryDate", DateTime.Now.AddDays(7)),
            New SqlParameter("@Status", "Pending"),
            New SqlParameter("@PaymentMethod", selectedPaymentMethod),
            New SqlParameter("@FarmerID", farmerID)
        }

            db.ExecuteNonQuery(orderQuery, orderParams)
        Next

        ' Clear cart after order placement
        Dim clearCartQuery As String = "DELETE FROM Cart WHERE ConsumerID = @ConsumerID"
        db.ExecuteNonQuery(clearCartQuery, params)

        MessageBox.Show("Order Placed Successfully! Estimated Delivery: " & DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ConsumerHome.Show()
        Me.Close()
    End Sub

    ' Validate Credit Card Details
    Private Function ValidateCreditCard() As Boolean
        If txtCardNumber.Text.Trim().Length <> 16 OrElse Not IsNumeric(txtCardNumber.Text) Then
            MessageBox.Show("Card number must be 16 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCardNumber.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCardHolder.Text) Then
            MessageBox.Show("Card holder name cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCardHolder.Focus()
            Return False
        End If


        Dim expiryPattern As String = "^(0[1-9]|1[0-2])\/\d{2}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtExpiry.Text.Trim(), expiryPattern) Then
            MessageBox.Show("Expiry date must be in MM/YY format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtExpiry.Focus()
            Return False
        End If


        Dim parts() As String = txtExpiry.Text.Split("/")
        Dim expiryMonth As Integer = Convert.ToInt32(parts(0))
        Dim expiryYear As Integer = Convert.ToInt32(parts(1)) + 2000
        Dim expiryDate As New DateTime(expiryYear, expiryMonth, 1)

        If expiryDate < DateTime.Now Then
            MessageBox.Show("Card has expired.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtExpiry.Focus()
            Return False
        End If


        If txtCVV.Text.Trim().Length <> 3 OrElse Not IsNumeric(txtCVV.Text) Then
            MessageBox.Show("CVV must be 3 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCVV.Focus()
            Return False
        End If

        Return True
    End Function


    Private Sub btnCancelPayment_Click(sender As Object, e As EventArgs) Handles btnCancelPayment.Click
        ConsumerProductForm.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Hide() ' Hide current form
        If Application.OpenForms.Count > 1 Then
            Application.OpenForms(Application.OpenForms.Count - 2).Show() ' Show the previous form
        End If
    End Sub
End Class
