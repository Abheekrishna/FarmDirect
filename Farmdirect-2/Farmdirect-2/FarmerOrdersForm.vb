Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class FarmerOrdersForm
    Private Sub FarmerOrdersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFarmerOrders()
    End Sub

    Private Sub LoadFarmerOrders()
        Dim query As String = "SELECT o.OrderID, o.ProductID, p.ProductName, o.Quantity, o.Status, p.FarmerID 
                               FROM Orders o 
                               INNER JOIN Products p ON o.ProductID = p.ProductID 
                               WHERE p.FarmerID = @FarmerID"


        Dim db As New DBHelper()
        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@FarmerID", LoggedInFarmerID)
        }


        Dim dt As DataTable = db.ExecuteQuery(query, params)




        If dt.Rows.Count = 0 Then
            MessageBox.Show("No orders found for FarmerID: " & LoggedInFarmerID)
        Else
            dgvFarmerOrders.DataSource = dt
        End If
    End Sub


    Private Sub btnAcceptOrder_Click(sender As Object, e As EventArgs) Handles btnAcceptOrder.Click
        If dgvFarmerOrders.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an order to accept.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim orderID As Integer = Convert.ToInt32(dgvFarmerOrders.SelectedRows(0).Cells("OrderID").Value)
        Dim query As String = "UPDATE Orders SET Status = 'Accepted' WHERE OrderID = @OrderID"

        Dim db As New DBHelper()
        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@OrderID", orderID)
        }

        Dim result As Integer = db.ExecuteNonQuery(query, params)

        If result > 0 Then
            MessageBox.Show("Order accepted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadFarmerOrders()
        Else
            MessageBox.Show("Failed to update order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnRejectOrder_Click(sender As Object, e As EventArgs) Handles btnRejectOrder.Click
        If dgvFarmerOrders.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an order to reject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim orderID As Integer = Convert.ToInt32(dgvFarmerOrders.SelectedRows(0).Cells("OrderID").Value)
        Dim query As String = "UPDATE Orders SET Status = 'Rejected' WHERE OrderID = @OrderID"

        Dim db As New DBHelper()
        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@OrderID", orderID)
        }

        Dim result As Integer = db.ExecuteNonQuery(query, params)

        If result > 0 Then
            MessageBox.Show("Order rejected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadFarmerOrders()
        Else
            MessageBox.Show("Failed to update order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadFarmerOrders()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FarmerHome.Show()
        Me.Hide()
    End Sub
End Class
