Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class CheckoutForm
    Private CurrentProductID As Integer
    Private Quantity As Integer
    Private selectedProductID As Integer
    Private ConsumerID As Integer
    Private isDirectBuy As Boolean = False
    Dim db As New DBHelper()

    ' Constructor for Direct Buy
    Public Sub New(consumerID As Integer, cartItems As List(Of Tuple(Of Integer, Integer)))
        InitializeComponent()
        Me.ConsumerID = LoggedInConsumerID
    End Sub


    ' Default Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub CheckoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCart.Rows.Clear()
        dgvCart.Columns.Clear()

        For Each item In Cart
            dgvCart.Rows.Add(item.ProductID, item.ProductName, item.Price, item.Quantity, item.Price * item.Quantity)
        Next

        Dim removeColumn As New DataGridViewButtonColumn()
        removeColumn.Name = "Remove"
        removeColumn.HeaderText = "Action"
        removeColumn.Text = "Remove"
        removeColumn.UseColumnTextForButtonValue = True
        dgvCart.Columns.Add(removeColumn)

        ' Load Items
        If isDirectBuy Then
            LoadSingleProduct()
        Else
            LoadCartItems()
        End If

        For Each column As DataGridViewColumn In dgvCart.Columns
            If column.Name <> "Quantity" Then
                column.ReadOnly = True
            End If
        Next


        ' Calculate Total
        CalculateTotalAmount()
    End Sub

    ' Load Single Product for Direct Buy
    Private Sub LoadSingleProduct()
        Dim query As String = $"SELECT ProductID, ProductName, 1 AS Quantity, Price, (1 * Price) AS TotalPrice FROM Products WHERE ProductID = {selectedProductID}"
        Dim dt As DataTable = db.ExecuteQuery(query)
        dgvCart.DataSource = dt
    End Sub

    ' Load Cart Items
    Private Sub LoadCartItems()
        Dim query As String = $"SELECT C.CartID, C.ProductID, P.ProductName, C.Quantity, P.Price, (C.Quantity * P.Price) AS TotalPrice 
                           FROM Cart C 
                           JOIN Products P ON C.ProductID = P.ProductID 
                           WHERE C.ConsumerID = {LoggedInConsumerID}"

        Dim dt As DataTable = db.ExecuteQuery(query)
        dgvCart.DataSource = dt
    End Sub


    ' Update Total Amount
    Private Sub CalculateTotalAmount()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvCart.Rows
            total += Convert.ToDecimal(row.Cells("TotalPrice").Value)
        Next
        lblTotalAmount.Text = "Total Amount: ₹" & total.ToString("F2")
    End Sub




    ' Handle Remove Button Click
    Private Sub dgvCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellContentClick
        If e.ColumnIndex = dgvCart.Columns("Remove").Index Then
            If e.RowIndex < 0 OrElse e.RowIndex >= dgvCart.Rows.Count Then Exit Sub

            Dim productID As Integer
            If Integer.TryParse(dgvCart.Rows(e.RowIndex).Cells("ProductID").Value.ToString(), productID) Then
                Dim query As String = "DELETE FROM Cart WHERE ProductID = @ProductID AND ConsumerID = @ConsumerID"
                Dim params As New List(Of SqlParameter) From {
                New SqlParameter("@ProductID", productID),
                New SqlParameter("@ConsumerID", LoggedInConsumerID)
            }
                db.ExecuteNonQuery(query, params)

                dgvCart.Rows.RemoveAt(e.RowIndex)
                CalculateTotalAmount()
                MessageBox.Show("Product removed from cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Invalid Product ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub




    Private Sub dgvCart_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellValueChanged
        ' Ensure the user is modifying the Quantity column
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvCart.Columns("Quantity").Index Then
            Dim row As DataGridViewRow = dgvCart.Rows(e.RowIndex)
            Dim productID As Integer = Convert.ToInt32(row.Cells("ProductID").Value)
            Dim newQuantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)

            ' Update the database
            Dim query As String = "UPDATE Cart SET Quantity = @Quantity WHERE ProductID = @ProductID AND ConsumerID = @ConsumerID"
            Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@Quantity", newQuantity),
            New SqlParameter("@ProductID", productID),
            New SqlParameter("@ConsumerID", LoggedInConsumerID)
        }
            db.ExecuteNonQuery(query, params)

            ' Update total price for this row
            Dim price As Decimal = Convert.ToDecimal(row.Cells("Price").Value)
            row.Cells("TotalPrice").Value = newQuantity * price

            ' Recalculate total amount
            CalculateTotalAmount()
        End If
    End Sub



    ' Handle Place Order Button Click
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Dim cartItems As New List(Of Tuple(Of Integer, Integer))

        ' Collect Cart Items
        For Each row As DataGridViewRow In dgvCart.Rows
            If Not row.IsNewRow Then
                Dim productID As Integer = Convert.ToInt32(row.Cells("ProductID").Value)
                Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                cartItems.Add(New Tuple(Of Integer, Integer)(productID, quantity))
            End If
        Next

        ' Open Payment Form with ConsumerID
        Dim paymentForm As New PaymentCart(LoggedInConsumerID, cartItems.Count)
        paymentForm.Show()
        Me.Hide()
    End Sub


    ' Back Button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ConsumerHome.Show()
        Me.Hide()
    End Sub
End Class
