Public Class FarmerHome
    Private Sub btnManageProducts_Click(sender As Object, e As EventArgs) Handles btnManageProducts.Click
        Dim productForm As New FarmerProductForm()
        productForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewOrders_Click(sender As Object, e As EventArgs) Handles btnViewOrders.Click
        Dim ordersForm As New FarmerOrdersForm()
        ordersForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MessageBox.Show("Logged Out Successfully!")
        Me.Hide()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub
End Class
