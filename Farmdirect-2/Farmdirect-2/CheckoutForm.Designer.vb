<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckoutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckoutForm))
        dgvCart = New DataGridView()
        lblTotalAmount = New Label()
        btnPlaceOrder = New Button()
        btnCancel = New Button()
        PictureBox1 = New PictureBox()
        btnBack = New Button()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvCart
        ' 
        dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCart.Location = New Point(12, 74)
        dgvCart.Name = "dgvCart"
        dgvCart.RowHeadersWidth = 51
        dgvCart.Size = New Size(1003, 313)
        dgvCart.TabIndex = 0
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAmount.Location = New Point(73, 432)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(231, 31)
        lblTotalAmount.TabIndex = 1
        lblTotalAmount.Text = "Total Amount: ₹0.00"
        ' 
        ' btnPlaceOrder
        ' 
        btnPlaceOrder.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnPlaceOrder.ForeColor = Color.White
        btnPlaceOrder.Location = New Point(73, 486)
        btnPlaceOrder.Name = "btnPlaceOrder"
        btnPlaceOrder.Size = New Size(127, 42)
        btnPlaceOrder.TabIndex = 2
        btnPlaceOrder.Text = "Place Order"
        btnPlaceOrder.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(222, 486)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(127, 42)
        btnCancel.TabIndex = 2
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, -2)
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
        btnBack.Location = New Point(921, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 31)
        btnBack.TabIndex = 13
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' CheckoutForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1044, 563)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        Controls.Add(btnCancel)
        Controls.Add(btnPlaceOrder)
        Controls.Add(lblTotalAmount)
        Controls.Add(dgvCart)
        Name = "CheckoutForm"
        Text = "CheckoutForm"
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
