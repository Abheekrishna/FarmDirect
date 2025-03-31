<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminHome))
        btnViewOrders = New Button()
        btnManageProducts = New Button()
        btnManageUsers = New Button()
        Label1 = New Label()
        btnLogout = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnViewOrders
        ' 
        btnViewOrders.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnViewOrders.ForeColor = Color.White
        btnViewOrders.Location = New Point(540, 227)
        btnViewOrders.Name = "btnViewOrders"
        btnViewOrders.Size = New Size(161, 46)
        btnViewOrders.TabIndex = 3
        btnViewOrders.Text = "View Orders"
        btnViewOrders.UseVisualStyleBackColor = False
        ' 
        ' btnManageProducts
        ' 
        btnManageProducts.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnManageProducts.ForeColor = Color.White
        btnManageProducts.Location = New Point(350, 227)
        btnManageProducts.Name = "btnManageProducts"
        btnManageProducts.Size = New Size(161, 46)
        btnManageProducts.TabIndex = 2
        btnManageProducts.Text = "Manage Products"
        btnManageProducts.UseVisualStyleBackColor = False
        ' 
        ' btnManageUsers
        ' 
        btnManageUsers.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnManageUsers.ForeColor = Color.White
        btnManageUsers.Location = New Point(158, 227)
        btnManageUsers.Name = "btnManageUsers"
        btnManageUsers.Size = New Size(161, 46)
        btnManageUsers.TabIndex = 1
        btnManageUsers.Text = "Manage Users"
        btnManageUsers.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(378, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(266, 41)
        Label1.TabIndex = 0
        Label1.Text = "Admin  Dashboard"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(724, 227)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(161, 46)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
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
        ' AdminHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1068, 483)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogout)
        Controls.Add(btnViewOrders)
        Controls.Add(btnManageProducts)
        Controls.Add(btnManageUsers)
        Controls.Add(Label1)
        Name = "AdminHome"
        Text = "AdminHome"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewOrders As Button
    Friend WithEvents btnManageProducts As Button
    Friend WithEvents btnManageUsers As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
