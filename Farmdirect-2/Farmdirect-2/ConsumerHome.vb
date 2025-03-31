Public Class ConsumerHome
    Private Sub btnBrowseProducts_Click(sender As Object, e As EventArgs) Handles btnBrowseProducts.Click
        Dim productForm As New ConsumerProductForm()
        productForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewCart_Click(sender As Object, e As EventArgs) Handles btnViewCart.Click
        Dim cartForm As New CheckoutForm()
        cartForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewOrders_Click(sender As Object, e As EventArgs) Handles btnViewOrders.Click
        Dim ordersForm As New ConsumerOrdersForm()
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
