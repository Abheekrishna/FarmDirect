<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProductForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditProductForm))
        btnUpdateProduct = New Button()
        btnBrowseImage = New Button()
        picProductImage = New PictureBox()
        txtQuantity = New TextBox()
        txtPrice = New TextBox()
        txtProductDescription = New TextBox()
        txtProductName = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        btnDeleteProduct = New Button()
        PictureBox1 = New PictureBox()
        btnBack = New Button()
        CType(picProductImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnUpdateProduct
        ' 
        btnUpdateProduct.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnUpdateProduct.ForeColor = Color.White
        btnUpdateProduct.Location = New Point(377, 466)
        btnUpdateProduct.Name = "btnUpdateProduct"
        btnUpdateProduct.Size = New Size(136, 50)
        btnUpdateProduct.TabIndex = 6
        btnUpdateProduct.Text = "Update Product"
        btnUpdateProduct.UseVisualStyleBackColor = False
        ' 
        ' btnBrowseImage
        ' 
        btnBrowseImage.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnBrowseImage.ForeColor = Color.White
        btnBrowseImage.Location = New Point(512, 395)
        btnBrowseImage.Name = "btnBrowseImage"
        btnBrowseImage.Size = New Size(143, 40)
        btnBrowseImage.TabIndex = 5
        btnBrowseImage.Text = "Browse Image"
        btnBrowseImage.UseVisualStyleBackColor = False
        ' 
        ' picProductImage
        ' 
        picProductImage.Location = New Point(514, 263)
        picProductImage.Name = "picProductImage"
        picProductImage.Size = New Size(157, 115)
        picProductImage.SizeMode = PictureBoxSizeMode.Zoom
        picProductImage.TabIndex = 14
        picProductImage.TabStop = False
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(512, 214)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(159, 27)
        txtQuantity.TabIndex = 4
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(512, 168)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(159, 27)
        txtPrice.TabIndex = 3
        ' 
        ' txtProductDescription
        ' 
        txtProductDescription.Location = New Point(512, 123)
        txtProductDescription.Name = "txtProductDescription"
        txtProductDescription.Size = New Size(159, 27)
        txtProductDescription.TabIndex = 2
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(512, 77)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(159, 27)
        txtProductName.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(360, 269)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 20)
        Label6.TabIndex = 0
        Label6.Text = "Product Image"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(360, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 0
        Label5.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(360, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 20)
        Label4.TabIndex = 0
        Label4.Text = "Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(360, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 20)
        Label3.TabIndex = 0
        Label3.Text = "Product Description"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(360, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 0
        Label1.Text = "Product Name"
        ' 
        ' btnDeleteProduct
        ' 
        btnDeleteProduct.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnDeleteProduct.ForeColor = Color.White
        btnDeleteProduct.Location = New Point(535, 466)
        btnDeleteProduct.Name = "btnDeleteProduct"
        btnDeleteProduct.Size = New Size(136, 50)
        btnDeleteProduct.TabIndex = 7
        btnDeleteProduct.Text = "Delete Product"
        btnDeleteProduct.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 47)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(955, 28)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 31)
        btnBack.TabIndex = 16
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' EditProductForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1072, 588)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        Controls.Add(btnDeleteProduct)
        Controls.Add(btnUpdateProduct)
        Controls.Add(btnBrowseImage)
        Controls.Add(picProductImage)
        Controls.Add(txtQuantity)
        Controls.Add(txtPrice)
        Controls.Add(txtProductDescription)
        Controls.Add(txtProductName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "EditProductForm"
        Text = "EditProductForm"
        CType(picProductImage, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents btnBrowseImage As Button
    Friend WithEvents picProductImage As PictureBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtProductDescription As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
