Public Class AdminOrdersForm
    Dim db As New DBHelper()

    Private Sub AdminOrdersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrders()
    End Sub

    Private Sub LoadOrders()
        Dim query As String = "SELECT OrderID, ConsumerID, ProductID, Quantity, TotalPrice, OrderDate FROM Orders"
        Dim dt As DataTable = db.ExecuteQuery(query)
        dgvOrders.DataSource = dt
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadOrders()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminHome.Show()
        Me.Hide()
    End Sub
End Class
