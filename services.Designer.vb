<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class services
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
        Me.flowServices = New System.Windows.Forms.FlowLayoutPanel()
        Me.fororganization = New System.Windows.Forms.Panel()
        Me.chkAvailableOnly = New System.Windows.Forms.CheckBox()
        Me.cmbSortBy = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbCategoryFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fororganization.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowServices
        '
        Me.flowServices.AutoScroll = True
        Me.flowServices.BackColor = System.Drawing.Color.Transparent
        Me.flowServices.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowServices.Location = New System.Drawing.Point(128, 170)
        Me.flowServices.Name = "flowServices"
        Me.flowServices.Size = New System.Drawing.Size(752, 321)
        Me.flowServices.TabIndex = 0
        Me.flowServices.WrapContents = False
        '
        'fororganization
        '
        Me.fororganization.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.fororganization.Controls.Add(Me.chkAvailableOnly)
        Me.fororganization.Controls.Add(Me.cmbSortBy)
        Me.fororganization.Controls.Add(Me.btnSearch)
        Me.fororganization.Controls.Add(Me.txtSearch)
        Me.fororganization.Controls.Add(Me.cmbCategoryFilter)
        Me.fororganization.Dock = System.Windows.Forms.DockStyle.Top
        Me.fororganization.Location = New System.Drawing.Point(0, 83)
        Me.fororganization.Name = "fororganization"
        Me.fororganization.Size = New System.Drawing.Size(1023, 67)
        Me.fororganization.TabIndex = 6
        '
        'chkAvailableOnly
        '
        Me.chkAvailableOnly.AutoSize = True
        Me.chkAvailableOnly.ForeColor = System.Drawing.Color.White
        Me.chkAvailableOnly.Location = New System.Drawing.Point(124, 26)
        Me.chkAvailableOnly.Name = "chkAvailableOnly"
        Me.chkAvailableOnly.Size = New System.Drawing.Size(123, 17)
        Me.chkAvailableOnly.TabIndex = 10
        Me.chkAvailableOnly.Text = "Show Available Only"
        Me.chkAvailableOnly.UseVisualStyleBackColor = True
        '
        'cmbSortBy
        '
        Me.cmbSortBy.FormattingEnabled = True
        Me.cmbSortBy.Location = New System.Drawing.Point(437, 22)
        Me.cmbSortBy.Name = "cmbSortBy"
        Me.cmbSortBy.Size = New System.Drawing.Size(121, 21)
        Me.cmbSortBy.TabIndex = 9
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(773, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(587, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(180, 20)
        Me.txtSearch.TabIndex = 7
        '
        'cmbCategoryFilter
        '
        Me.cmbCategoryFilter.FormattingEnabled = True
        Me.cmbCategoryFilter.Location = New System.Drawing.Point(298, 22)
        Me.cmbCategoryFilter.Name = "cmbCategoryFilter"
        Me.cmbCategoryFilter.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategoryFilter.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(373, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 47)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "OUR SERVICES"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1023, 83)
        Me.Panel1.TabIndex = 8
        '
        'services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1023, 520)
        Me.Controls.Add(Me.flowServices)
        Me.Controls.Add(Me.fororganization)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "services"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "services"
        Me.fororganization.ResumeLayout(False)
        Me.fororganization.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flowServices As FlowLayoutPanel
    Friend WithEvents fororganization As Panel
    Friend WithEvents chkAvailableOnly As CheckBox
    Friend WithEvents cmbSortBy As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbCategoryFilter As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
