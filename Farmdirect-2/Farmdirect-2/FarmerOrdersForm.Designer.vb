<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FarmerOrdersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FarmerOrdersForm))
        dgvFarmerOrders = New DataGridView()
        btnAcceptOrder = New Button()
        btnRejectOrder = New Button()
        btnRefresh = New Button()
        PictureBox1 = New PictureBox()
        btnBack = New Button()
        CType(dgvFarmerOrders, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvFarmerOrders
        ' 
        dgvFarmerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFarmerOrders.Location = New Point(32, 56)
        dgvFarmerOrders.Name = "dgvFarmerOrders"
        dgvFarmerOrders.RowHeadersWidth = 51
        dgvFarmerOrders.Size = New Size(1027, 278)
        dgvFarmerOrders.TabIndex = 0
        ' 
        ' btnAcceptOrder
        ' 
        btnAcceptOrder.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnAcceptOrder.ForeColor = Color.White
        btnAcceptOrder.Location = New Point(259, 397)
        btnAcceptOrder.Name = "btnAcceptOrder"
        btnAcceptOrder.Size = New Size(155, 51)
        btnAcceptOrder.TabIndex = 1
        btnAcceptOrder.Text = "Accept Order"
        btnAcceptOrder.UseVisualStyleBackColor = False
        ' 
        ' btnRejectOrder
        ' 
        btnRejectOrder.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnRejectOrder.ForeColor = Color.White
        btnRejectOrder.Location = New Point(447, 397)
        btnRejectOrder.Name = "btnRejectOrder"
        btnRejectOrder.Size = New Size(155, 51)
        btnRejectOrder.TabIndex = 2
        btnRejectOrder.Text = "Reject Order"
        btnRejectOrder.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(651, 397)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(155, 51)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 3)
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
        btnBack.Location = New Point(965, 3)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 31)
        btnBack.TabIndex = 12
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' FarmerOrdersForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1083, 523)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        Controls.Add(btnRefresh)
        Controls.Add(btnRejectOrder)
        Controls.Add(btnAcceptOrder)
        Controls.Add(dgvFarmerOrders)
        Name = "FarmerOrdersForm"
        Text = "FarmerOrdersForm"
        CType(dgvFarmerOrders, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvFarmerOrders As DataGridView
    Friend WithEvents btnAcceptOrder As Button
    Friend WithEvents btnRejectOrder As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
