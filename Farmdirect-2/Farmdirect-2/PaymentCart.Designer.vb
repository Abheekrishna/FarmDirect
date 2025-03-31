<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentCart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentCart))
        btnCancelPayment = New Button()
        btnPayNow = New Button()
        pnlCreditCardDetails = New Panel()
        txtCVV = New TextBox()
        txtExpiry = New TextBox()
        txtCardHolder = New TextBox()
        lblCVV = New Label()
        txtCardNumber = New TextBox()
        lblExpiry = New Label()
        lblCardNumber = New Label()
        lblCardHolder = New Label()
        cmbPaymentMethod = New ComboBox()
        txtAddress = New Label()
        txtConsumerName = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblPaymentMethod = New Label()
        Label3 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dgvPaymentCart = New DataGridView()
        lblTotalPrice = New Label()
        PictureBox1 = New PictureBox()
        pnlCreditCardDetails.SuspendLayout()
        CType(dgvPaymentCart, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCancelPayment
        ' 
        btnCancelPayment.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnCancelPayment.ForeColor = Color.White
        btnCancelPayment.Location = New Point(749, 472)
        btnCancelPayment.Name = "btnCancelPayment"
        btnCancelPayment.Size = New Size(151, 46)
        btnCancelPayment.TabIndex = 3
        btnCancelPayment.Text = "Cancel Payment"
        btnCancelPayment.UseVisualStyleBackColor = False
        ' 
        ' btnPayNow
        ' 
        btnPayNow.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnPayNow.ForeColor = Color.White
        btnPayNow.Location = New Point(612, 472)
        btnPayNow.Name = "btnPayNow"
        btnPayNow.Size = New Size(118, 46)
        btnPayNow.TabIndex = 2
        btnPayNow.Text = vbTab & "Pay Now"
        btnPayNow.UseVisualStyleBackColor = False
        ' 
        ' pnlCreditCardDetails
        ' 
        pnlCreditCardDetails.Controls.Add(txtCVV)
        pnlCreditCardDetails.Controls.Add(txtExpiry)
        pnlCreditCardDetails.Controls.Add(txtCardHolder)
        pnlCreditCardDetails.Controls.Add(lblCVV)
        pnlCreditCardDetails.Controls.Add(txtCardNumber)
        pnlCreditCardDetails.Controls.Add(lblExpiry)
        pnlCreditCardDetails.Controls.Add(lblCardNumber)
        pnlCreditCardDetails.Controls.Add(lblCardHolder)
        pnlCreditCardDetails.Location = New Point(602, 201)
        pnlCreditCardDetails.Name = "pnlCreditCardDetails"
        pnlCreditCardDetails.Size = New Size(298, 231)
        pnlCreditCardDetails.TabIndex = 1
        ' 
        ' txtCVV
        ' 
        txtCVV.Location = New Point(110, 164)
        txtCVV.Name = "txtCVV"
        txtCVV.PasswordChar = "•"c
        txtCVV.Size = New Size(185, 27)
        txtCVV.TabIndex = 4
        ' 
        ' txtExpiry
        ' 
        txtExpiry.Location = New Point(110, 113)
        txtExpiry.Name = "txtExpiry"
        txtExpiry.Size = New Size(185, 27)
        txtExpiry.TabIndex = 3
        ' 
        ' txtCardHolder
        ' 
        txtCardHolder.Location = New Point(110, 67)
        txtCardHolder.Name = "txtCardHolder"
        txtCardHolder.Size = New Size(185, 27)
        txtCardHolder.TabIndex = 2
        ' 
        ' lblCVV
        ' 
        lblCVV.AutoSize = True
        lblCVV.Font = New Font("Segoe UI", 9F)
        lblCVV.Location = New Point(9, 164)
        lblCVV.Name = "lblCVV"
        lblCVV.Size = New Size(39, 20)
        lblCVV.TabIndex = 0
        lblCVV.Text = "CVV:"
        ' 
        ' txtCardNumber
        ' 
        txtCardNumber.Location = New Point(110, 16)
        txtCardNumber.Name = "txtCardNumber"
        txtCardNumber.Size = New Size(185, 27)
        txtCardNumber.TabIndex = 1
        ' 
        ' lblExpiry
        ' 
        lblExpiry.AutoSize = True
        lblExpiry.Font = New Font("Segoe UI", 9F)
        lblExpiry.Location = New Point(9, 113)
        lblExpiry.Name = "lblExpiry"
        lblExpiry.Size = New Size(88, 20)
        lblExpiry.TabIndex = 0
        lblExpiry.Text = "Expiry Date:"
        ' 
        ' lblCardNumber
        ' 
        lblCardNumber.AutoSize = True
        lblCardNumber.Font = New Font("Segoe UI", 9F)
        lblCardNumber.Location = New Point(3, 19)
        lblCardNumber.Name = "lblCardNumber"
        lblCardNumber.Size = New Size(101, 20)
        lblCardNumber.TabIndex = 0
        lblCardNumber.Text = "Card Number:" & vbLf
        ' 
        ' lblCardHolder
        ' 
        lblCardHolder.AutoSize = True
        lblCardHolder.Font = New Font("Segoe UI", 9F)
        lblCardHolder.Location = New Point(9, 67)
        lblCardHolder.Name = "lblCardHolder"
        lblCardHolder.Size = New Size(56, 20)
        lblCardHolder.TabIndex = 0
        lblCardHolder.Text = "Name: "
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Location = New Point(749, 156)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(151, 28)
        cmbPaymentMethod.TabIndex = 0
        ' 
        ' txtAddress
        ' 
        txtAddress.AutoSize = True
        txtAddress.Font = New Font("Segoe UI", 10F)
        txtAddress.Location = New Point(214, 202)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(70, 23)
        txtAddress.TabIndex = 0
        txtAddress.Text = "Address"
        ' 
        ' txtConsumerName
        ' 
        txtConsumerName.AutoSize = True
        txtConsumerName.Font = New Font("Segoe UI", 10F)
        txtConsumerName.Location = New Point(214, 161)
        txtConsumerName.Name = "txtConsumerName"
        txtConsumerName.Size = New Size(61, 23)
        txtConsumerName.TabIndex = 0
        txtConsumerName.Text = "Name "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(137, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 23)
        Label4.TabIndex = 0
        Label4.Text = "Address:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(128, 296)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 28)
        Label5.TabIndex = 0
        Label5.Text = "Product Details"
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Segoe UI", 10F)
        lblPaymentMethod.Location = New Point(598, 161)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(145, 23)
        lblPaymentMethod.TabIndex = 0
        lblPaymentMethod.Text = "Payment Method:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(137, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 23)
        Label3.TabIndex = 0
        Label3.Text = "Name: "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(598, 105)
        Label8.Name = "Label8"
        Label8.Size = New Size(151, 28)
        Label8.TabIndex = 0
        Label8.Text = "Payment Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(137, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 28)
        Label2.TabIndex = 0
        Label2.Text = "Consumer Details"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(488, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 41)
        Label1.TabIndex = 0
        Label1.Text = "Payment"
        ' 
        ' dgvPaymentCart
        ' 
        dgvPaymentCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPaymentCart.Location = New Point(128, 343)
        dgvPaymentCart.Name = "dgvPaymentCart"
        dgvPaymentCart.RowHeadersWidth = 51
        dgvPaymentCart.Size = New Size(365, 195)
        dgvPaymentCart.TabIndex = 0
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.AutoSize = True
        lblTotalPrice.Font = New Font("Segoe UI", 10F)
        lblTotalPrice.Location = New Point(137, 570)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(92, 23)
        lblTotalPrice.TabIndex = 0
        lblTotalPrice.Text = "Total Price:"
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
        ' PaymentCart
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1082, 665)
        Controls.Add(PictureBox1)
        Controls.Add(lblTotalPrice)
        Controls.Add(dgvPaymentCart)
        Controls.Add(btnCancelPayment)
        Controls.Add(btnPayNow)
        Controls.Add(pnlCreditCardDetails)
        Controls.Add(cmbPaymentMethod)
        Controls.Add(txtAddress)
        Controls.Add(txtConsumerName)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(lblPaymentMethod)
        Controls.Add(Label3)
        Controls.Add(Label8)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "PaymentCart"
        Text = "PaymentCart"
        pnlCreditCardDetails.ResumeLayout(False)
        pnlCreditCardDetails.PerformLayout()
        CType(dgvPaymentCart, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancelPayment As Button
    Friend WithEvents btnPayNow As Button
    Friend WithEvents pnlCreditCardDetails As Panel
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents txtExpiry As TextBox
    Friend WithEvents txtCardHolder As TextBox
    Friend WithEvents lblCVV As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents lblExpiry As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblCardHolder As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents txtAddress As Label
    Friend WithEvents txtConsumerName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPaymentCart As DataGridView
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
