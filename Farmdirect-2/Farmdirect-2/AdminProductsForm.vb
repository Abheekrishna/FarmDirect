Imports Microsoft.Data.SqlClient

Public Class AdminProductsForm
    Dim db As New DBHelper()

    Private Sub AdminProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Dim query As String = "SELECT ProductID, ProductName, Description, Price, Quantity FROM Products"
        Dim dt As DataTable = db.ExecuteQuery(query)
        dgvProducts.DataSource = dt
    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim productID As Integer = Convert.ToInt32(dgvProducts.SelectedRows(0).Cells("ProductID").Value)


            Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = DialogResult.No Then Exit Sub

            Dim query As String = "DELETE FROM Products WHERE ProductID = @ProductID"
            Dim params As New List(Of SqlParameter) From {
                New SqlParameter("@ProductID", productID)
            }


            Dim db As New DBHelper()
            db.ExecuteNonQuery(query, params)


            LoadProducts()
            MessageBox.Show("Product deleted successfully.")
        Else
            MessageBox.Show("Select a product to delete.")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminHome.Show()
        Me.Hide()
    End Sub
End Class
