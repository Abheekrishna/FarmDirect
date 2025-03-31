<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtConsumerName = New Label()
        txtAddress = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtProductName = New Label()
        txtQuantity = New Label()
        Label10 = New Label()
        txtTotalPrice = New Label()
        Label8 = New Label()
        lblPaymentMethod = New Label()
        cmbPaymentMethod = New ComboBox()
        pnlCreditCardDetails = New Panel()
        txtCVV = New TextBox()
        txtExpiry = New TextBox()
        txtCardHolder = New TextBox()
        lblCVV = New Label()
        txtCardNumber = New TextBox()
        lblExpiry = New Label()
        lblCardNumber = New Label()
        lblCardHolder = New Label()
        btnPayNow = New Button()
        btnCancelPayment = New Button()
        PictureBox1 = New PictureBox()
        pnlCreditCardDetails.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(403, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 41)
        Label1.TabIndex = 0
        Label1.Text = "Payment"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(52, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 28)
        Label2.TabIndex = 0
        Label2.Text = "Consumer Details"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(52, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 23)
        Label3.TabIndex = 0
        Label3.Text = "Name: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(52, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 23)
        Label4.TabIndex = 0
        Label4.Text = "Address:"
        ' 
        ' txtConsumerName
        ' 
        txtConsumerName.AutoSize = True
        txtConsumerName.Font = New Font("Segoe UI", 10F)
        txtConsumerName.Location = New Point(129, 167)
        txtConsumerName.Name = "txtConsumerName"
        txtConsumerName.Size = New Size(61, 23)
        txtConsumerName.TabIndex = 0
        txtConsumerName.Text = "Name "
        ' 
        ' txtAddress
        ' 
        txtAddress.AutoSize = True
        txtAddress.Font = New Font("Segoe UI", 10F)
        txtAddress.Location = New Point(129, 208)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(70, 23)
        txtAddress.TabIndex = 0
        txtAddress.Text = "Address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(43, 302)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 28)
        Label5.TabIndex = 0
        Label5.Text = "Product Details"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(43, 358)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 23)
        Label6.TabIndex = 0
        Label6.Text = "Product Name:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.Location = New Point(43, 399)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 23)
        Label7.TabIndex = 0
        Label7.Text = "Quantity:"
        ' 
        ' txtProductName
        ' 
        txtProductName.AutoSize = True
        txtProductName.Font = New Font("Segoe UI", 10F)
        txtProductName.Location = New Point(184, 358)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(121, 23)
        txtProductName.TabIndex = 0
        txtProductName.Text = "Product Name"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.AutoSize = True
        txtQuantity.Font = New Font("Segoe UI", 10F)
        txtQuantity.Location = New Point(184, 399)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(81, 23)
        txtQuantity.TabIndex = 0
        txtQuantity.Text = "Quantity "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F)
        Label10.Location = New Point(43, 442)
        Label10.Name = "Label10"
        Label10.Size = New Size(92, 23)
        Label10.TabIndex = 0
        Label10.Text = "Total Price:"
        ' 
        ' txtTotalPrice
        ' 
        txtTotalPrice.AutoSize = True
        txtTotalPrice.Font = New Font("Segoe UI", 10F)
        txtTotalPrice.Location = New Point(184, 442)
        txtTotalPrice.Name = "txtTotalPrice"
        txtTotalPrice.Size = New Size(88, 23)
        txtTotalPrice.TabIndex = 0
        txtTotalPrice.Text = "Total Price"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(513, 111)
        Label8.Name = "Label8"
        Label8.Size = New Size(151, 28)
        Label8.TabIndex = 0
        Label8.Text = "Payment Details"
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Segoe UI", 10F)
        lblPaymentMethod.Location = New Point(513, 167)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(145, 23)
        lblPaymentMethod.TabIndex = 0
        lblPaymentMethod.Text = "Payment Method:"
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Location = New Point(664, 162)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(151, 28)
        cmbPaymentMethod.TabIndex = 0
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
        pnlCreditCardDetails.Location = New Point(517, 207)
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
        ' btnPayNow
        ' 
        btnPayNow.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnPayNow.ForeColor = Color.White
        btnPayNow.Location = New Point(527, 478)
        btnPayNow.Name = "btnPayNow"
        btnPayNow.Size = New Size(118, 46)
        btnPayNow.TabIndex = 2
        btnPayNow.Text = vbTab & "Pay Now"
        btnPayNow.UseVisualStyleBackColor = False
        ' 
        ' btnCancelPayment
        ' 
        btnCancelPayment.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnCancelPayment.ForeColor = Color.White
        btnCancelPayment.Location = New Point(664, 478)
        btnCancelPayment.Name = "btnCancelPayment"
        btnCancelPayment.Size = New Size(151, 46)
        btnCancelPayment.TabIndex = 3
        btnCancelPayment.Text = "Cancel Payment"
        btnCancelPayment.UseVisualStyleBackColor = False
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
        ' PaymentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1073, 560)
        Controls.Add(PictureBox1)
        Controls.Add(btnCancelPayment)
        Controls.Add(btnPayNow)
        Controls.Add(pnlCreditCardDetails)
        Controls.Add(cmbPaymentMethod)
        Controls.Add(txtTotalPrice)
        Controls.Add(txtQuantity)
        Controls.Add(txtProductName)
        Controls.Add(Label10)
        Controls.Add(txtAddress)
        Controls.Add(Label7)
        Controls.Add(txtConsumerName)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(lblPaymentMethod)
        Controls.Add(Label3)
        Controls.Add(Label8)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "PaymentForm"
        Text = "PaymentForm"
        pnlCreditCardDetails.ResumeLayout(False)
        pnlCreditCardDetails.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConsumerName As Label
    Friend WithEvents txtAddress As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProductName As Label
    Friend WithEvents txtQuantity As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalPrice As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents pnlCreditCardDetails As Panel
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents txtExpiry As TextBox
    Friend WithEvents txtCardHolder As TextBox
    Friend WithEvents lblCVV As Label
    Friend WithEvents lblExpiry As Label
    Friend WithEvents lblCardHolder As Label
    Friend WithEvents btnPayNow As Button
    Friend WithEvents btnCancelPayment As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
