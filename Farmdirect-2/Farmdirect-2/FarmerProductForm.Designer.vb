<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FarmerProductForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FarmerProductForm))
        Label1 = New Label()
        Label2 = New Label()
        txtProductName = New TextBox()
        txtDescription = New Label()
        txtProductDescription = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        Label6 = New Label()
        picProductImage = New PictureBox()
        btnBrowseImage = New Button()
        btnAddProduct = New Button()
        dgvProducts = New DataGridView()
        btnRefresh = New Button()
        PictureBox1 = New PictureBox()
        btnBack = New Button()
        CType(picProductImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 0
        Label1.Text = "Product Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(389, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 35)
        Label2.TabIndex = 0
        Label2.Text = "Manage Products"
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(187, 116)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(159, 27)
        txtProductName.TabIndex = 1
        ' 
        ' txtDescription
        ' 
        txtDescription.AutoSize = True
        txtDescription.Location = New Point(35, 165)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(140, 20)
        txtDescription.TabIndex = 0
        txtDescription.Text = "Product Description"
        ' 
        ' txtProductDescription
        ' 
        txtProductDescription.Location = New Point(187, 162)
        txtProductDescription.Name = "txtProductDescription"
        txtProductDescription.Size = New Size(159, 27)
        txtProductDescription.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 20)
        Label4.TabIndex = 0
        Label4.Text = "Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 0
        Label5.Text = "Quantity"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(187, 207)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(159, 27)
        txtPrice.TabIndex = 1
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(187, 253)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(159, 27)
        txtQuantity.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(35, 308)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 20)
        Label6.TabIndex = 0
        Label6.Text = "Product Image"
        ' 
        ' picProductImage
        ' 
        picProductImage.Location = New Point(189, 302)
        picProductImage.Name = "picProductImage"
        picProductImage.Size = New Size(157, 115)
        picProductImage.SizeMode = PictureBoxSizeMode.Zoom
        picProductImage.TabIndex = 2
        picProductImage.TabStop = False
        ' 
        ' btnBrowseImage
        ' 
        btnBrowseImage.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnBrowseImage.ForeColor = Color.White
        btnBrowseImage.Location = New Point(187, 434)
        btnBrowseImage.Name = "btnBrowseImage"
        btnBrowseImage.Size = New Size(143, 43)
        btnBrowseImage.TabIndex = 3
        btnBrowseImage.Text = "Browse Image"
        btnBrowseImage.UseVisualStyleBackColor = False
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnAddProduct.ForeColor = Color.White
        btnAddProduct.Location = New Point(52, 505)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(143, 43)
        btnAddProduct.TabIndex = 4
        btnAddProduct.Text = "Add Product"
        btnAddProduct.UseVisualStyleBackColor = False
        ' 
        ' dgvProducts
        ' 
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(389, 113)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.RowHeadersWidth = 51
        dgvProducts.Size = New Size(685, 435)
        dgvProducts.TabIndex = 5
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(389, 584)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(143, 43)
        btnRefresh.TabIndex = 4
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 47)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(956, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 31)
        btnBack.TabIndex = 11
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' FarmerProductForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1074, 656)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        Controls.Add(dgvProducts)
        Controls.Add(btnRefresh)
        Controls.Add(btnAddProduct)
        Controls.Add(btnBrowseImage)
        Controls.Add(picProductImage)
        Controls.Add(txtQuantity)
        Controls.Add(txtPrice)
        Controls.Add(txtProductDescription)
        Controls.Add(txtProductName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(txtDescription)
        Controls.Add(Label1)
        Name = "FarmerProductForm"
        Text = "FarmerProductForm"
        CType(picProductImage, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtDescription As Label
    Friend WithEvents txtProductDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents picProductImage As PictureBox
    Friend WithEvents btnBrowseImage As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
