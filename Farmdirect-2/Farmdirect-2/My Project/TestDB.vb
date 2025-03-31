Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class TestDB
    Private Sub TestDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conn As New SqlConnection("Server=ABHEE\MSSQLSERVER01;Database=FarmDirectDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;")

            conn.Open()
            MessageBox.Show("Connection successful!")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
