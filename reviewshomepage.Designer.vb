<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reviewshomepage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flowReviews = New System.Windows.Forms.FlowLayoutPanel()
        Me.fororganization = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSortOrder = New System.Windows.Forms.ComboBox()
        Me.lblService = New System.Windows.Forms.Label()
        Me.cmbFilterService = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.fororganization.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 89)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(453, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 47)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "REVIEWS OVERVIEW"
        '
        'flowReviews
        '
        Me.flowReviews.AutoScroll = True
        Me.flowReviews.BackColor = System.Drawing.Color.Transparent
        Me.flowReviews.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowReviews.Location = New System.Drawing.Point(394, 205)
        Me.flowReviews.Name = "flowReviews"
        Me.flowReviews.Size = New System.Drawing.Size(539, 460)
        Me.flowReviews.TabIndex = 12
        Me.flowReviews.WrapContents = False
        '
        'fororganization
        '
        Me.fororganization.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.fororganization.Controls.Add(Me.Label2)
        Me.fororganization.Controls.Add(Me.cmbSortOrder)
        Me.fororganization.Controls.Add(Me.lblService)
        Me.fororganization.Controls.Add(Me.cmbFilterService)
        Me.fororganization.Dock = System.Windows.Forms.DockStyle.Top
        Me.fororganization.Location = New System.Drawing.Point(0, 89)
        Me.fororganization.Name = "fororganization"
        Me.fororganization.Size = New System.Drawing.Size(1280, 110)
        Me.fororganization.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(449, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Sort by Rating:"
        '
        'cmbSortOrder
        '
        Me.cmbSortOrder.FormattingEnabled = True
        Me.cmbSortOrder.Location = New System.Drawing.Point(577, 59)
        Me.cmbSortOrder.Name = "cmbSortOrder"
        Me.cmbSortOrder.Size = New System.Drawing.Size(234, 21)
        Me.cmbSortOrder.TabIndex = 16
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblService.ForeColor = System.Drawing.Color.White
        Me.lblService.Location = New System.Drawing.Point(449, 36)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(102, 17)
        Me.lblService.TabIndex = 15
        Me.lblService.Text = "Filter by Service:"
        '
        'cmbFilterService
        '
        Me.cmbFilterService.FormattingEnabled = True
        Me.cmbFilterService.Location = New System.Drawing.Point(577, 32)
        Me.cmbFilterService.Name = "cmbFilterService"
        Me.cmbFilterService.Size = New System.Drawing.Size(234, 21)
        Me.cmbFilterService.TabIndex = 6
        '
        'reviewshomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 677)
        Me.Controls.Add(Me.flowReviews)
        Me.Controls.Add(Me.fororganization)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reviewshomepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reviewshomepage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.fororganization.ResumeLayout(False)
        Me.fororganization.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents flowReviews As FlowLayoutPanel
    Friend WithEvents fororganization As Panel
    Friend WithEvents cmbFilterService As ComboBox
    Friend WithEvents lblService As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSortOrder As ComboBox
End Class
