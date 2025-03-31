<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminOrdersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminOrdersForm))
        btnRefresh = New Button()
        dgvOrders = New DataGridView()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnBack = New Button()
        CType(dgvOrders, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(393, 469)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(218, 49)
        btnRefresh.TabIndex = 8
        btnRefresh.Text = "Refresh Orders"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' dgvOrders
        ' 
        dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrders.Location = New Point(29, 103)
        dgvOrders.Name = "dgvOrders"
        dgvOrders.RowHeadersWidth = 51
        dgvOrders.Size = New Size(1009, 311)
        dgvOrders.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(417, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 41)
        Label1.TabIndex = 6
        Label1.Text = "View Orders"
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
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(20), CByte(157), CByte(128))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(958, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 31)
        btnBack.TabIndex = 13
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' AdminOrdersForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1064, 583)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        Controls.Add(btnRefresh)
        Controls.Add(dgvOrders)
        Controls.Add(Label1)
        Name = "AdminOrdersForm"
        Text = "AdminOrdersForm"
        CType(dgvOrders, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
