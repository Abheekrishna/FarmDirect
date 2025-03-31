Public Class AdminHome
    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        Dim usersForm As New AdminUsersForm()
        usersForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageProducts_Click(sender As Object, e As EventArgs) Handles btnManageProducts.Click
        Dim productsForm As New AdminProductsForm()
        productsForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewOrders_Click(sender As Object, e As EventArgs) Handles btnViewOrders.Click
        Dim ordersForm As New AdminOrdersForm()
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
