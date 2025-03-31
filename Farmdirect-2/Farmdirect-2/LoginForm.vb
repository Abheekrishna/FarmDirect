Imports Microsoft.Data.SqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Use UNION to check all tables in a single query
        Dim query As String = "
        SELECT FarmerID AS UserID, 'Farmer' AS Role FROM Farmers WHERE Email=@Email AND Password=@Password
        UNION ALL
        SELECT ConsumerID AS UserID, 'Consumer' AS Role FROM Consumers WHERE Email=@Email AND Password=@Password
        UNION ALL
        SELECT AdminID AS UserID, 'Admin' AS Role FROM Admins WHERE Email=@Email AND Password=@Password
        "

        Dim db As New DBHelper()
        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@Email", email),
            New SqlParameter("@Password", password)
        }

        Dim dt As DataTable = db.ExecuteQuery(query, params)

        If dt.Rows.Count > 0 Then
            LoggedInUserID = Convert.ToInt32(dt.Rows(0)("UserID"))
            LoggedInRole = dt.Rows(0)("Role").ToString()

            ' Assign LoggedInFarmerID and LoggedInConsumerID based on role
            If LoggedInRole = "Farmer" Then
                LoggedInFarmerID = LoggedInUserID
                LoggedInConsumerID = 0 ' Reset
            ElseIf LoggedInRole = "Consumer" Then
                LoggedInConsumerID = LoggedInUserID
                LoggedInFarmerID = 0 ' Reset
            Else
                LoggedInFarmerID = 0
                LoggedInConsumerID = 0
            End If

            MessageBox.Show("Login Successful! Welcome, " & LoggedInRole, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()

            Select Case LoggedInRole
                Case "Farmer"
                    Dim farmerHome As New FarmerHome()
                    farmerHome.Show()
                Case "Consumer"
                    Dim consumerHome As New ConsumerHome()
                    consumerHome.Show()
                Case "Admin"
                    Dim adminHome As New AdminHome()
                    adminHome.Show()
            End Select
        Else
            MessageBox.Show("Invalid Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.PasswordChar = If(chkShowPassword.Checked, "", "•")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        SignupForm.Show()
        Me.Hide()
    End Sub
End Class
