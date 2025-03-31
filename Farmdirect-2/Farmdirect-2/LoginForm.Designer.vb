<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Label1 = New Label()
        txtUsername = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        Label3 = New Label()
        btnLogin = New Button()
        Label4 = New Label()
        Label5 = New Label()
        chkShowPassword = New CheckBox()
        PictureBox1 = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(342, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 0
        Label1.Text = "Email"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(418, 145)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(197, 27)
        txtUsername.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(342, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 0
        Label2.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(418, 191)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "•"c
        txtPassword.Size = New Size(197, 27)
        txtPassword.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F)
        Label3.Location = New Point(444, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 41)
        Label3.TabIndex = 0
        Label3.Text = "Login"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(444, 293)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(144, 44)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(342, 358)
        Label4.Name = "Label4"
        Label4.Size = New Size(187, 20)
        Label4.TabIndex = 8
        Label4.Text = "If you don't have a account"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.Highlight
        Label5.Location = New Point(525, 358)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 20)
        Label5.TabIndex = 4
        Label5.Text = "Create one"
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(418, 235)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(170, 24)
        chkShowPassword.TabIndex = 5
        chkShowPassword.Text = "Show/Hide Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 47)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Location = New Point(3, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(0, 40)
        TableLayoutPanel1.TabIndex = 10
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1044, 547)
        Controls.Add(PictureBox1)
        Controls.Add(chkShowPassword)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(Label2)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(TableLayoutPanel1)
        Name = "LoginForm"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

End Class
