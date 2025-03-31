Imports System.Data.SqlClient

Public Class ConsumerOrdersForm
    Dim db As New DBHelper()

    Private Sub ConsumerOrdersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrders()
        LoadProducts()
    End Sub


    Private Sub LoadOrders()
        Dim query As String = $"SELECT O.OrderID, P.ProductName, O.Quantity, O.TotalPrice, O.OrderDate, 
                                      O.DeliveryDate, O.Status
                               FROM Orders O
                               JOIN Products P ON O.ProductID = P.ProductID
                               WHERE O.ConsumerID = {LoggedInConsumerID}"

        Dim dt As DataTable = db.ExecuteQuery(query)
        dgvOrders.DataSource = dt
    End Sub


    Private Sub LoadProducts()
        Dim query As String = "SELECT ProductID, ProductName, Price, Quantity FROM Products"
        Dim dt As DataTable = db.ExecuteQuery(query)


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ConsumerHome.Show()
        Me.Hide()
    End Sub
End Class
