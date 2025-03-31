Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class PaymentForm
    Private CurrentProductID As Integer
    Private Quantity As Integer
    Private TotalPrice As Decimal
    Private DeliveryDate As DateTime = DateTime.Now.AddDays(7)

    Public Sub New(productID As Integer, qty As Integer)
        InitializeComponent()
        CurrentProductID = productID
        Quantity = qty
    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadConsumerAndProductDetails()

        cmbPaymentMethod.Items.Add("Cash on Delivery")
        cmbPaymentMethod.Items.Add("Credit Card")
        cmbPaymentMethod.SelectedIndex = 0

        pnlCreditCardDetails.Visible = False
    End Sub

    Private Sub cmbPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentMethod.SelectedIndexChanged
        pnlCreditCardDetails.Visible = (cmbPaymentMethod.SelectedItem.ToString() = "Credit Card")
    End Sub

    Private Sub LoadConsumerAndProductDetails()
        Dim query As String = "SELECT u.ConsumerID, 
                                  (u.Street + ', ' + u.City + ', ' + u.State) AS Address, 
                                  p.ProductName, 
                                  p.Price
                           FROM Consumers u 
                           CROSS JOIN Products p 
                           WHERE u.ConsumerID = @ConsumerID AND p.ProductID = @ProductID"

        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@ConsumerID", LoggedInConsumerID),
            New SqlParameter("@ProductID", CurrentProductID)
        }

        Dim db As New DBHelper()
        Using reader As SqlDataReader = db.ExecuteReader(query, params)
            If reader.Read() Then
                txtConsumerName.Text = reader("Username").ToString()
                txtAddress.Text = reader("Address").ToString()
                txtProductName.Text = reader("ProductName").ToString()
                txtTotalPrice.Text = reader("Price").ToString()
                txtQuantity.Text = "1"
            End If
        End Using
    End Sub

    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        If cmbPaymentMethod.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim selectedPaymentMethod As String = cmbPaymentMethod.SelectedItem.ToString()

        ' Validate credit card details if payment method is "Credit Card"
        If selectedPaymentMethod = "Credit Card" Then
            If Not ValidateCreditCard() Then Exit Sub
        End If

        Dim db As New DBHelper()

        Dim SelectedProductID As Integer = CurrentProductID
        Dim SelectedQuantity As Integer = CInt(txtQuantity.Text)
        Dim ProductPrice As Decimal = GetProductPrice(SelectedProductID)
        Dim TotalAmount As Decimal = SelectedQuantity * ProductPrice

        Dim farmerQuery As String = "SELECT ISNULL(FarmerID, 0) AS FarmerID FROM Products WHERE ProductID = @ProductID"
        Dim farmerParams As New List(Of SqlParameter) From {
            New SqlParameter("@ProductID", SelectedProductID)
        }

        Dim farmerID As Integer = 0
        Using reader As SqlDataReader = db.ExecuteReader(farmerQuery, farmerParams)
            If reader.Read() Then
                farmerID = Convert.ToInt32(reader("FarmerID"))
            Else
                MessageBox.Show("No FarmerID found for ProductID: " & SelectedProductID)
                Exit Sub
            End If
        End Using

        Dim orderQuery As String = "INSERT INTO Orders (ConsumerID, ProductID, Quantity, TotalPrice, OrderDate, DeliveryDate, Status, PaymentMethod, FarmerID) 
                            VALUES (@ConsumerID, @ProductID, @Quantity, @TotalPrice, @OrderDate, @DeliveryDate, @Status, @PaymentMethod, @FarmerID)"

        Dim orderParams As New List(Of SqlParameter) From {
            New SqlParameter("@ConsumerID", LoggedInConsumerID),
            New SqlParameter("@ProductID", SelectedProductID),
            New SqlParameter("@Quantity", Quantity),
            New SqlParameter("@TotalPrice", TotalAmount),
            New SqlParameter("@OrderDate", DateTime.Now),
            New SqlParameter("@DeliveryDate", DeliveryDate),
            New SqlParameter("@Status", "Pending"),
            New SqlParameter("@PaymentMethod", selectedPaymentMethod),
            New SqlParameter("@FarmerID", farmerID)
        }

        Dim result As Integer = db.ExecuteNonQuery(orderQuery, orderParams)

        If result > 0 Then
            MessageBox.Show("Order Placed Successfully! Estimated Delivery: " & DeliveryDate.ToString("dd/MM/yyyy"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ConsumerHome.Show()
            Me.Close()
        Else
            MessageBox.Show("Failed to place order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function GetProductPrice(productID As Integer) As Decimal
        Dim price As Decimal = 0
        Dim query As String = "SELECT Price FROM Products WHERE ProductID = @ProductID"
        Dim db As New DBHelper()
        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@ProductID", productID)
        }

        Using reader As SqlDataReader = db.ExecuteReader(query, params)
            If reader.Read() Then
                price = Convert.ToDecimal(reader("Price"))
            End If
        End Using

        Return price
    End Function

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

        ' Validate expiry date format (MM/YY)
        Dim expiryPattern As String = "^(0[1-9]|1[0-2])\/\d{2}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtExpiry.Text.Trim(), expiryPattern) Then
            MessageBox.Show("Expiry date must be in MM/YY format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtExpiry.Focus()
            Return False
        End If

        ' Check if expiry date is valid (not in past)
        Dim parts() As String = txtExpiry.Text.Split("/")
        Dim expiryMonth As Integer = Convert.ToInt32(parts(0))
        Dim expiryYear As Integer = Convert.ToInt32(parts(1)) + 2000 ' Convert to full year format (24 → 2024)
        Dim expiryDate As New DateTime(expiryYear, expiryMonth, 1)

        If expiryDate < DateTime.Now Then
            MessageBox.Show("Card has expired.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtExpiry.Focus()
            Return False
        End If

        ' Validate CVV (must be 3 digits)
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
