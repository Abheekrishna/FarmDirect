<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsumerHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsumerHome))
        btnLogout = New Button()
        btnViewOrders = New Button()
        btnViewCart = New Button()
        btnBrowseProducts = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(711, 223)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(161, 46)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnViewOrders
        ' 
        btnViewOrders.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnViewOrders.ForeColor = Color.White
        btnViewOrders.Location = New Point(527, 223)
        btnViewOrders.Name = "btnViewOrders"
        btnViewOrders.Size = New Size(161, 46)
        btnViewOrders.TabIndex = 3
        btnViewOrders.Text = "View Orders"
        btnViewOrders.UseVisualStyleBackColor = False
        ' 
        ' btnViewCart
        ' 
        btnViewCart.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnViewCart.ForeColor = Color.White
        btnViewCart.Location = New Point(337, 223)
        btnViewCart.Name = "btnViewCart"
        btnViewCart.Size = New Size(161, 46)
        btnViewCart.TabIndex = 2
        btnViewCart.Text = "View Cart"
        btnViewCart.UseVisualStyleBackColor = False
        ' 
        ' btnBrowseProducts
        ' 
        btnBrowseProducts.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnBrowseProducts.ForeColor = Color.White
        btnBrowseProducts.Location = New Point(145, 223)
        btnBrowseProducts.Name = "btnBrowseProducts"
        btnBrowseProducts.Size = New Size(161, 46)
        btnBrowseProducts.TabIndex = 1
        btnBrowseProducts.Text = "Browse Products"
        btnBrowseProducts.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(365, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(307, 41)
        Label1.TabIndex = 6
        Label1.Text = "Consumer Dashboard"
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
        ' ConsumerHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1078, 504)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogout)
        Controls.Add(btnViewOrders)
        Controls.Add(btnViewCart)
        Controls.Add(btnBrowseProducts)
        Controls.Add(Label1)
        Name = "ConsumerHome"
        Text = "ConsumerHome"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents btnViewOrders As Button
    Friend WithEvents btnViewCart As Button
    Friend WithEvents btnBrowseProducts As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
