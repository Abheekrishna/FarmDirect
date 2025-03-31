<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignupForm))
        Label1 = New Label()
        Label2 = New Label()
        txtName = New TextBox()
        Label3 = New Label()
        txtEmail = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txtPhone = New TextBox()
        txtStreet = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        txtCity = New TextBox()
        txtState = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        txtPostal = New TextBox()
        txtPassword = New TextBox()
        Label10 = New Label()
        cmbRole = New ComboBox()
        btnSignup = New Button()
        Label11 = New Label()
        Label12 = New Label()
        PictureBox1 = New PictureBox()
        Label13 = New Label()
        txtConfirmPassword = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(236, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F)
        Label2.Location = New Point(428, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 41)
        Label2.TabIndex = 0
        Label2.Text = "Sign Up"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(305, 125)
        txtName.Name = "txtName"
        txtName.Size = New Size(154, 27)
        txtName.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(505, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 0
        Label3.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(574, 128)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(154, 27)
        txtEmail.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(236, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 0
        Label4.Text = "Phone"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(505, 189)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 20)
        Label5.TabIndex = 0
        Label5.Text = "Street"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(305, 183)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(154, 27)
        txtPhone.TabIndex = 3
        ' 
        ' txtStreet
        ' 
        txtStreet.Location = New Point(574, 186)
        txtStreet.Name = "txtStreet"
        txtStreet.Size = New Size(154, 27)
        txtStreet.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(236, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 20)
        Label6.TabIndex = 0
        Label6.Text = "City"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(505, 241)
        Label7.Name = "Label7"
        Label7.RightToLeft = RightToLeft.Yes
        Label7.Size = New Size(43, 20)
        Label7.TabIndex = 0
        Label7.Text = "State"
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(305, 235)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(154, 27)
        txtCity.TabIndex = 5
        ' 
        ' txtState
        ' 
        txtState.Location = New Point(574, 238)
        txtState.Name = "txtState"
        txtState.Size = New Size(154, 27)
        txtState.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(236, 291)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 20)
        Label8.TabIndex = 0
        Label8.Text = "Postal"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(505, 294)
        Label9.Name = "Label9"
        Label9.RightToLeft = RightToLeft.Yes
        Label9.Size = New Size(70, 20)
        Label9.TabIndex = 0
        Label9.Text = "Password"
        ' 
        ' txtPostal
        ' 
        txtPostal.Location = New Point(305, 288)
        txtPostal.Name = "txtPostal"
        txtPostal.Size = New Size(154, 27)
        txtPostal.TabIndex = 7
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(574, 291)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "•"c
        txtPassword.Size = New Size(154, 27)
        txtPassword.TabIndex = 8
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(236, 345)
        Label10.Name = "Label10"
        Label10.Size = New Size(49, 20)
        Label10.TabIndex = 0
        Label10.Text = "Select"
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Farmer", "Consumer"})
        cmbRole.Location = New Point(305, 345)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(154, 28)
        cmbRole.TabIndex = 9
        ' 
        ' btnSignup
        ' 
        btnSignup.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnSignup.ForeColor = Color.White
        btnSignup.Location = New Point(383, 402)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(192, 43)
        btnSignup.TabIndex = 10
        btnSignup.Text = "Sign up"
        btnSignup.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = SystemColors.Highlight
        Label11.Location = New Point(511, 468)
        Label11.Name = "Label11"
        Label11.Size = New Size(46, 20)
        Label11.TabIndex = 11
        Label11.Text = "Login"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(366, 468)
        Label12.Name = "Label12"
        Label12.Size = New Size(149, 20)
        Label12.TabIndex = 13
        Label12.Text = "If you have a account"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 47)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(498, 333)
        Label13.Name = "Label13"
        Label13.RightToLeft = RightToLeft.Yes
        Label13.Size = New Size(70, 40)
        Label13.TabIndex = 0
        Label13.Text = "Confirm" & vbCrLf & "Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(574, 346)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "•"c
        txtConfirmPassword.Size = New Size(154, 27)
        txtConfirmPassword.TabIndex = 8
        ' 
        ' SignupForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1022, 520)
        Controls.Add(PictureBox1)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(btnSignup)
        Controls.Add(cmbRole)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtState)
        Controls.Add(txtStreet)
        Controls.Add(txtEmail)
        Controls.Add(Label13)
        Controls.Add(txtPostal)
        Controls.Add(Label9)
        Controls.Add(txtCity)
        Controls.Add(Label7)
        Controls.Add(txtPhone)
        Controls.Add(Label5)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(txtName)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "SignupForm"
        Text = "SignupForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPostal As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnSignup As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtConfirmPassword As TextBox
End Class
