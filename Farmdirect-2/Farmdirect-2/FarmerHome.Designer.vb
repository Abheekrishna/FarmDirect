<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FarmerHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FarmerHome))
        Label1 = New Label()
        btnManageProducts = New Button()
        btnViewOrders = New Button()
        btnLogout = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(356, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(262, 41)
        Label1.TabIndex = 0
        Label1.Text = "Farmer Dashboard"
        ' 
        ' btnManageProducts
        ' 
        btnManageProducts.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnManageProducts.ForeColor = Color.White
        btnManageProducts.Location = New Point(204, 217)
        btnManageProducts.Name = "btnManageProducts"
        btnManageProducts.Size = New Size(161, 46)
        btnManageProducts.TabIndex = 1
        btnManageProducts.Text = "Manage Products"
        btnManageProducts.UseVisualStyleBackColor = False
        ' 
        ' btnViewOrders
        ' 
        btnViewOrders.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnViewOrders.ForeColor = Color.White
        btnViewOrders.Location = New Point(396, 217)
        btnViewOrders.Name = "btnViewOrders"
        btnViewOrders.Size = New Size(161, 46)
        btnViewOrders.TabIndex = 2
        btnViewOrders.Text = "View Orders"
        btnViewOrders.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(586, 217)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(161, 46)
        btnLogout.TabIndex = 3
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
        ' FarmerHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1045, 450)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogout)
        Controls.Add(btnViewOrders)
        Controls.Add(btnManageProducts)
        Controls.Add(Label1)
        Name = "FarmerHome"
        Text = "FarmerHome"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnManageProducts As Button
    Friend WithEvents btnViewOrders As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
