<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUsersForm
    Inherits System.Windows.Forms.Form

    WithEvents dgvUsers As DataGridView
    WithEvents btnDeleteUser As Button

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminUsersForm))
        dgvUsers = New DataGridView()
        btnDeleteUser = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnBack = New Button()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvUsers
        ' 
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Location = New Point(12, 92)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.Size = New Size(1058, 300)
        dgvUsers.TabIndex = 0
        ' 
        ' btnDeleteUser
        ' 
        btnDeleteUser.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnDeleteUser.ForeColor = Color.White
        btnDeleteUser.Location = New Point(441, 431)
        btnDeleteUser.Name = "btnDeleteUser"
        btnDeleteUser.Size = New Size(171, 65)
        btnDeleteUser.TabIndex = 6
        btnDeleteUser.Text = "Delete User"
        btnDeleteUser.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(427, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 41)
        Label1.TabIndex = 7
        Label1.Text = "Manage Users"
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
        btnBack.Location = New Point(976, 20)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 31)
        btnBack.TabIndex = 13
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' AdminUsersForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1082, 521)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnDeleteUser)
        Controls.Add(dgvUsers)
        Name = "AdminUsersForm"
        Text = "AdminUsersForm"
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
