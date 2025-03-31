Imports Microsoft.Data.SqlClient

Public Class SignupForm
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim street As String = txtStreet.Text
        Dim city As String = txtCity.Text
        Dim state As String = txtState.Text
        Dim postal As String = txtPostal.Text
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text
        Dim role As String = cmbRole.SelectedItem?.ToString()

        ' Check if any field is empty
        If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(email) OrElse
           String.IsNullOrWhiteSpace(phone) OrElse String.IsNullOrWhiteSpace(street) OrElse
           String.IsNullOrWhiteSpace(city) OrElse String.IsNullOrWhiteSpace(state) OrElse
           String.IsNullOrWhiteSpace(postal) OrElse String.IsNullOrWhiteSpace(password) OrElse
           String.IsNullOrWhiteSpace(confirmPassword) OrElse String.IsNullOrWhiteSpace(role) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Check if passwords match
        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match. Please re-enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtConfirmPassword.Clear()
            txtPassword.Focus()
            Exit Sub
        End If

        ' Select the appropriate table based on role
        Dim tableName As String = ""
        Dim idColumn As String = ""
        Dim nameColumn As String = ""

        Select Case role
            Case "Farmer"
                tableName = "Farmers"
                idColumn = "FarmerID"
                nameColumn = "FarmerName"
            Case "Consumer"
                tableName = "Consumers"
                idColumn = "ConsumerID"
                nameColumn = "ConsumerName"
            Case "Admin"
                tableName = "Admins"
                idColumn = "AdminID"
                nameColumn = "AdminName"
            Case Else
                MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        ' SQL Insert Query
        Dim query As String = $"INSERT INTO {tableName} ({nameColumn}, Email, Password, Street, City, State, PostalCode) " &
                              "VALUES (@Name, @Email, @Password, @Street, @City, @State, @PostalCode)"

        ' Parameters for SQL Query
        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@Name", name),
            New SqlParameter("@Email", email),
            New SqlParameter("@Password", password), ' Hash password in real implementation
            New SqlParameter("@Street", street),
            New SqlParameter("@City", city),
            New SqlParameter("@State", state),
            New SqlParameter("@PostalCode", postal)
        }

        ' Execute the query
        Dim db As New DBHelper()
        db.ExecuteNonQuery(query, params)

        MessageBox.Show("Signup Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Clear all fields
        ClearFields()

        ' Redirect to login form
        Me.Hide()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub

    ' Method to clear all text fields after successful signup
    Private Sub ClearFields()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtStreet.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtPostal.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        cmbRole.SelectedIndex = -1  ' Reset the combo box
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class
