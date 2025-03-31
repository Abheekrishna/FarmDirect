Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class DBHelper
    ' Define Connection String
    Private ReadOnly connectionString As String = "Server=ABHEE\MSSQLSERVER01;Database=FarmDirectDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;"

    ' Execute Scalar Query
    Public Function ExecuteScalar(query As String, params As List(Of SqlParameter)) As Object
        Dim result As Object = Nothing
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                If params IsNot Nothing Then cmd.Parameters.AddRange(params.ToArray())
                conn.Open()
                result = cmd.ExecuteScalar()
            End Using
        End Using
        Return result
    End Function

    ' Execute Query and Return DataTable
    Public Function ExecuteQuery(query As String, Optional params As List(Of SqlParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                If params IsNot Nothing Then
                    ' ✅ Create a fresh copy of parameters to avoid reusing the same objects
                    For Each param As SqlParameter In params
                        cmd.Parameters.Add(New SqlParameter(param.ParameterName, param.Value))
                    Next
                End If
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function


    ' Execute Non-Query (Insert, Update, Delete)
    Public Function ExecuteNonQuery(query As String, params As List(Of SqlParameter)) As Integer
        Dim rowsAffected As Integer = 0
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                If params IsNot Nothing Then
                    ' Clone parameters before adding to avoid reuse issues
                    For Each param As SqlParameter In params
                        cmd.Parameters.Add(New SqlParameter(param.ParameterName, param.Value))
                    Next
                End If

                conn.Open()
                rowsAffected = cmd.ExecuteNonQuery()
            End Using
        End Using
        Return rowsAffected
    End Function


    ' Execute Reader
    Public Function ExecuteReader(query As String, params As List(Of SqlParameter)) As SqlDataReader
        Dim conn As New SqlConnection(connectionString) ' ✅ FIXED Connection String Consistency
        Dim cmd As New SqlCommand(query, conn)
        If params IsNot Nothing Then cmd.Parameters.AddRange(params.ToArray())
        conn.Open()
        Return cmd.ExecuteReader(CommandBehavior.CloseConnection)
    End Function

    ' Save Product Image to Database
    Public Sub SaveProductImage(productID As Integer, imagePath As String)
        Try
            Dim imageData As Byte() = File.ReadAllBytes(imagePath)
            Dim query As String = "UPDATE Products SET Image = @Image WHERE ProductID = @ProductID"

            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductID", productID)
                    cmd.Parameters.AddWithValue("@Image", imageData)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Image Saved Successfully!")
        Catch ex As Exception
            MessageBox.Show("Error Saving Image: " & ex.Message)
        End Try
    End Sub

    ' Load Product Image from Database
    Public Function LoadProductImage(productID As Integer) As Image
        Try
            Dim query As String = "SELECT Image FROM Products WHERE ProductID = @ProductID"
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductID", productID)
                    conn.Open()
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        Dim imageData As Byte() = DirectCast(result, Byte())
                        Using ms As New MemoryStream(imageData)
                            Return Image.FromStream(ms)
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Loading Image: " & ex.Message)
        End Try
        ' ✅ Return Placeholder Image if NULL
        Return Nothing ' Ensure you have a placeholder image in resources
    End Function
End Class
