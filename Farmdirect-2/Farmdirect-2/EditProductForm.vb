Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Drawing


Public Class EditProductForm
    Public SelectedProductID As Integer
    Private selectedImagePath As String = ""

    Public Sub New(productID As Integer, productName As String, productDescription As String, price As String, quantity As String)
        InitializeComponent()
        SelectedProductID = productID

        txtProductName.Text = productName
        txtProductDescription.Text = productDescription
        txtPrice.Text = price
        txtQuantity.Text = quantity
    End Sub


    Private Sub LoadProductDetails()
        Dim query As String = "SELECT ProductName, Description, Price, Quantity, Image FROM Products WHERE ProductID = @ProductID"

        Dim db As New DBHelper()
        Dim params As New List(Of SqlParameter) From {
        New SqlParameter("@ProductID", SelectedProductID)
    }

        Dim dt As DataTable = db.ExecuteQuery(query, params)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)


            txtProductName.Text = row("ProductName").ToString()
            txtProductDescription.Text = row("Description").ToString()
            txtPrice.Text = row("Price").ToString()
            txtQuantity.Text = row("Quantity").ToString()


            If Not IsDBNull(row("Image")) Then
                Dim imageData As Byte() = DirectCast(row("Image"), Byte())
                If imageData.Length > 0 Then
                    Using ms As New MemoryStream(imageData)
                        picProductImage.Image = Image.FromStream(ms)
                    End Using
                End If
            Else

                picProductImage.Image = Nothing
            End If
        Else
            MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.png;*.jpeg"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            selectedImagePath = openFileDialog.FileName
            picProductImage.Image = Image.FromFile(selectedImagePath)
        End If
    End Sub






    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click

        If SelectedProductID = 0 Then
            MessageBox.Show("No product selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmDelete = DialogResult.No Then Exit Sub


        Dim query As String = "DELETE FROM Products WHERE ProductID = @ProductID"


        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@ProductID", SelectedProductID)
        }


        Dim db As New DBHelper()
        db.ExecuteNonQuery(query, params)


        MessageBox.Show("Product Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub


    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        Dim newProductName As String = txtProductName.Text.Trim()
        Dim newDescription As String = txtProductDescription.Text.Trim()
        Dim newPrice As Decimal = Convert.ToDecimal(txtPrice.Text)
        Dim newQuantity As Integer = Convert.ToInt32(txtQuantity.Text)



        ' Update query
        Dim query As String = "UPDATE Products SET ProductName = @ProductName, Description = @Description, Price = @Price, Quantity = @Quantity
                           WHERE ProductID = @ProductID"

        Dim db As New DBHelper()
        Dim params As New List(Of SqlParameter) From {
        New SqlParameter("@ProductName", newProductName),
        New SqlParameter("@Description", newDescription),
        New SqlParameter("@Price", newPrice),
        New SqlParameter("@Quantity", newQuantity),
        New SqlParameter("@ProductID", SelectedProductID)
    }

        Dim result As Integer = db.ExecuteNonQuery(query, params)

        If result > 0 Then
            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK ' Set OK result before closing
            Me.Close()
        Else
            MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RefreshProducts()
        ' Reload the product list
    End Sub

    Private Sub EditProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductDetails()

        Dim query As String = "SELECT ProductName, Description, Price, Quantity FROM Products WHERE ProductID = @ProductID"

        Dim db As New DBHelper()
        Dim params As New List(Of SqlParameter) From {
            New SqlParameter("@ProductID", SelectedProductID)
        }

        Dim dt As DataTable = db.ExecuteQuery(query, params)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)

            ' Load text fields
            txtProductName.Text = row("ProductName").ToString()
            txtProductDescription.Text = row("Description").ToString()
            txtPrice.Text = row("Price").ToString()
            txtQuantity.Text = row("Quantity").ToString()

            ' Load image if not NULL

        Else
            MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FarmerProductForm.Show()
        Me.Hide()
    End Sub
End Class
