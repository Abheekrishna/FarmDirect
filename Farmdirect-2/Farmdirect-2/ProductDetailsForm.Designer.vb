<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductDetailsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductDetailsForm))
        picProduct = New PictureBox()
        lblProductName = New Label()
        lblDescription = New Label()
        lblPrice = New Label()
        btnAddToCart = New Button()
        btnBuyNow = New Button()
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        btnSubmitFeedback = New Button()
        txtComment = New RichTextBox()
        numRating = New NumericUpDown()
        lvFeedback = New ListView()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtQuantity = New Label()
        lblFarmer = New Label()
        PictureBox1 = New PictureBox()
        btnBack = New Button()
        CType(picProduct, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(numRating, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picProduct
        ' 
        picProduct.Location = New Point(304, 12)
        picProduct.Name = "picProduct"
        picProduct.Size = New Size(291, 213)
        picProduct.SizeMode = PictureBoxSizeMode.Zoom
        picProduct.TabIndex = 0
        picProduct.TabStop = False
        ' 
        ' lblProductName
        ' 
        lblProductName.AutoSize = True
        lblProductName.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProductName.Location = New Point(300, 258)
        lblProductName.Name = "lblProductName"
        lblProductName.Size = New Size(108, 20)
        lblProductName.TabIndex = 1
        lblProductName.Text = "Product Name"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(304, 295)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(85, 20)
        lblDescription.TabIndex = 2
        lblDescription.Text = "Description"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrice.Location = New Point(203, 433)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(47, 23)
        lblPrice.TabIndex = 2
        lblPrice.Text = "Price"
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnAddToCart.ForeColor = Color.White
        btnAddToCart.Location = New Point(201, 471)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.Size = New Size(122, 39)
        btnAddToCart.TabIndex = 3
        btnAddToCart.Text = "Add to Cart"
        btnAddToCart.UseVisualStyleBackColor = False
        ' 
        ' btnBuyNow
        ' 
        btnBuyNow.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnBuyNow.ForeColor = Color.White
        btnBuyNow.Location = New Point(348, 471)
        btnBuyNow.Name = "btnBuyNow"
        btnBuyNow.Size = New Size(122, 39)
        btnBuyNow.TabIndex = 3
        btnBuyNow.Text = "Buy Now"
        btnBuyNow.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(txtQuantity)
        Panel1.Controls.Add(lblPrice)
        Panel1.Controls.Add(lblFarmer)
        Panel1.Controls.Add(btnBuyNow)
        Panel1.Controls.Add(btnAddToCart)
        Panel1.Location = New Point(154, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(756, 1021)
        Panel1.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(210, 357)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 20)
        Label5.TabIndex = 6
        Label5.Text = "Quantity:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(210, 402)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 6
        Label4.Text = "Farmer:"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnSubmitFeedback)
        Panel2.Controls.Add(txtComment)
        Panel2.Controls.Add(numRating)
        Panel2.Controls.Add(lvFeedback)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(39, 552)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(691, 450)
        Panel2.TabIndex = 5
        ' 
        ' btnSubmitFeedback
        ' 
        btnSubmitFeedback.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnSubmitFeedback.ForeColor = Color.White
        btnSubmitFeedback.Location = New Point(164, 379)
        btnSubmitFeedback.Name = "btnSubmitFeedback"
        btnSubmitFeedback.Size = New Size(156, 48)
        btnSubmitFeedback.TabIndex = 8
        btnSubmitFeedback.Text = "Submit Feedback"
        btnSubmitFeedback.UseVisualStyleBackColor = False
        ' 
        ' txtComment
        ' 
        txtComment.Location = New Point(229, 228)
        txtComment.Name = "txtComment"
        txtComment.Size = New Size(248, 65)
        txtComment.TabIndex = 7
        txtComment.Text = ""
        ' 
        ' numRating
        ' 
        numRating.Location = New Point(229, 323)
        numRating.Name = "numRating"
        numRating.Size = New Size(150, 27)
        numRating.TabIndex = 6
        ' 
        ' lvFeedback
        ' 
        lvFeedback.ForeColor = Color.Black
        lvFeedback.FullRowSelect = True
        lvFeedback.GridLines = True
        lvFeedback.Location = New Point(0, 56)
        lvFeedback.Name = "lvFeedback"
        lvFeedback.Size = New Size(688, 149)
        lvFeedback.TabIndex = 5
        lvFeedback.UseCompatibleStateImageBehavior = False
        lvFeedback.View = View.Details
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(116, 318)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 28)
        Label3.TabIndex = 4
        Label3.Text = "Rating: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(116, 244)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 28)
        Label2.TabIndex = 4
        Label2.Text = "Feedback: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(249, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 35)
        Label1.TabIndex = 4
        Label1.Text = "Feedback"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.AutoSize = True
        txtQuantity.Location = New Point(282, 357)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(65, 20)
        txtQuantity.TabIndex = 2
        txtQuantity.Text = "Quantity"
        ' 
        ' lblFarmer
        ' 
        lblFarmer.AutoSize = True
        lblFarmer.Location = New Point(282, 402)
        lblFarmer.Name = "lblFarmer"
        lblFarmer.Size = New Size(98, 20)
        lblFarmer.TabIndex = 2
        lblFarmer.Text = "Farmer Name"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 2)
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
        btnBack.Location = New Point(960, 18)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 31)
        btnBack.TabIndex = 13
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' ProductDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1066, 1055)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        Controls.Add(lblDescription)
        Controls.Add(lblProductName)
        Controls.Add(picProduct)
        Controls.Add(Panel1)
        Name = "ProductDetailsForm"
        Text = "ProductDetailsForm"
        CType(picProduct, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(numRating, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProduct As PictureBox
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents btnBuyNow As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFarmer As Label
    Friend WithEvents txtQuantity As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSubmitFeedback As Button
    Friend WithEvents txtComment As RichTextBox
    Friend WithEvents numRating As NumericUpDown
    Friend WithEvents lvFeedback As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
