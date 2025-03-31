Imports Microsoft.Data.SqlClient

Public Class AdminUsersForm

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvUsers.SelectedRows(0)
            Dim userID As Integer = Convert.ToInt32(selectedRow.Cells("UserID").Value)
            Dim role As String = selectedRow.Cells("Role").Value.ToString()

            Dim tableName As String = If(role = "Farmer", "Farmers", "Consumers")

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim query As String = $"DELETE FROM {tableName} WHERE {tableName}ID = @UserID"
                Dim params As New List(Of SqlParameter) From {New SqlParameter("@UserID", userID)}

                Dim db As New DBHelper()
                db.ExecuteNonQuery(query, params)

                LoadUsers()
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub LoadUsers()
        Dim query As String = "SELECT FarmerID AS UserID, FarmerName AS Username, Email, 'Farmer' AS Role FROM Farmers 
                           UNION 
                           SELECT ConsumerID AS UserID, ConsumerName AS Username, Email, 'Consumer' AS Role FROM Consumers"

        Dim db As New DBHelper()
        Dim dt As DataTable = db.ExecuteQuery(query)
        dgvUsers.DataSource = dt
    End Sub


    Private Sub AdminUsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminHome.Show()
        Me.Hide()
    End Sub
End Class
