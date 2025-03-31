<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsumerOrdersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsumerOrdersForm))
        dgvOrders = New DataGridView()
        btnRefresh = New Button()
        PictureBox1 = New PictureBox()
        btnBack = New Button()
        CType(dgvOrders, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvOrders
        ' 
        dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrders.Location = New Point(39, 84)
        dgvOrders.Name = "dgvOrders"
        dgvOrders.RowHeadersWidth = 51
        dgvOrders.Size = New Size(1037, 311)
        dgvOrders.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(435, 458)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(186, 50)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(23, 12)
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
        btnBack.Location = New Point(982, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 31)
        btnBack.TabIndex = 13
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' ConsumerOrdersForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1088, 562)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        Controls.Add(btnRefresh)
        Controls.Add(dgvOrders)
        Name = "ConsumerOrdersForm"
        Text = "ConsumerOrdersForm"
        CType(dgvOrders, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
