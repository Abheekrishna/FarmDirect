Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class FarmerProductForm
    Private selectedImagePath As String = ""




    Private Sub FarmerProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    ' Load products for the logged-in farmer
    Private Sub LoadProducts()
        Dim query As String = "SELECT * FROM Products WHERE FarmerID = @FarmerID"
        Dim params As New List(Of SqlParameter) From {
        New SqlParameter("@FarmerID", LoggedInFarmerID)
    }

        Dim db As New DBHelper()
        Dim dt As DataTable = db.ExecuteQuery(query, params)

        dgvProducts.DataSource = Nothing
        dgvProducts.DataSource = dt
    End Sub



    ' Browse Image
    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            selectedImagePath = openFileDialog.FileName ' Store selected image path
            picProductImage.Image = Image.FromFile(selectedImagePath) ' Display image in PictureBox
        End If
    End Sub


    ' Add Product
    ' Add Product
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        ' Ensure required fields are filled
        If txtProductName.Text = "" Or txtDescription.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Or selectedImagePath = "" Then
            MessageBox.Show("Please fill in all fields and select an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Convert image to byte array
        Dim imageData As Byte() = File.ReadAllBytes(selectedImagePath)

        ' Fetch farmer name from Farmers table
        Dim farmerNameQuery As String = "SELECT FarmerName FROM Farmers WHERE FarmerID = @UserID"
        Dim farmerName As String = ""

        Dim db As New DBHelper()
        Dim farmerParams As New List(Of SqlParameter) From {
        New SqlParameter("@UserID", LoggedInFarmerID)
    }

        Dim dt As DataTable = db.ExecuteQuery(farmerNameQuery, farmerParams)
        If dt.Rows.Count > 0 Then
            farmerName = dt.Rows(0)("FarmerName").ToString()
        Else
            MessageBox.Show("Error: Farmer name not found!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Query to insert product
        Dim query As String = "INSERT INTO Products (ProductName, Description, Price, Quantity, Image, FarmerID, FarmerName) 
                           VALUES (@ProductName, @Description, @Price, @Quantity, @Image, @FarmerID, @FarmerName)"

        ' Define parameters
        Dim params As New List(Of SqlParameter) From {
        New SqlParameter("@ProductName", txtProductName.Text),
        New SqlParameter("@Description", txtProductDescription.Text), ' FIXED TextBox Reference
        New SqlParameter("@Price", Convert.ToDecimal(txtPrice.Text)),
        New SqlParameter("@Quantity", Convert.ToInt32(txtQuantity.Text)),
        New SqlParameter("@Image", imageData),
        New SqlParameter("@FarmerID", LoggedInFarmerID),
        New SqlParameter("@FarmerName", farmerName)
    }

        ' Execute query
        db.ExecuteNonQuery(query, params)

        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Refresh Product List
        LoadProducts()
    End Sub


    Private Sub dgvProducts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvProducts.Rows(e.RowIndex)
            Dim productID As Integer = Convert.ToInt32(selectedRow.Cells("ProductID").Value)
            Dim productName As String = selectedRow.Cells("ProductName").Value.ToString()
            Dim productDescription As String = selectedRow.Cells("Description").Value.ToString()
            Dim price As String = selectedRow.Cells("Price").Value.ToString()
            Dim quantity As String = selectedRow.Cells("Quantity").Value.ToString()


            Dim editForm As New EditProductForm(productID, productName, productDescription, price, quantity)
            editForm.SelectedProductID = productID
            editForm.ShowDialog()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FarmerHome.Show()
        Me.Hide()

    End Sub
End Class
