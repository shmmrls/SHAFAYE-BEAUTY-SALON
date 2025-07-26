<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymentRecords
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpFilters = New System.Windows.Forms.GroupBox()
        Me.grpTransactions = New System.Windows.Forms.GroupBox()
        Me.cboFilter = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlDailyOverview.SuspendLayout()
        Me.grpFilters.SuspendLayout()
        Me.grpTransactions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "STATUS:"
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 83)
        Me.pnlDailyOverview.TabIndex = 49
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(107, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(479, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "PAYMENT RECORDS"
        '
        'grpFilters
        '
        Me.grpFilters.Controls.Add(Me.btnSearch)
        Me.grpFilters.Controls.Add(Me.cboFilter)
        Me.grpFilters.Controls.Add(Me.Label1)
        Me.grpFilters.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpFilters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.grpFilters.Location = New System.Drawing.Point(12, 89)
        Me.grpFilters.Name = "grpFilters"
        Me.grpFilters.Size = New System.Drawing.Size(643, 223)
        Me.grpFilters.TabIndex = 52
        Me.grpFilters.TabStop = False
        Me.grpFilters.Text = "FILTER TRANSACTIONS"
        '
        'grpTransactions
        '
        Me.grpTransactions.Controls.Add(Me.FlowLayoutPanel1)
        Me.grpTransactions.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpTransactions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.grpTransactions.Location = New System.Drawing.Point(12, 327)
        Me.grpTransactions.Name = "grpTransactions"
        Me.grpTransactions.Size = New System.Drawing.Size(643, 210)
        Me.grpTransactions.TabIndex = 53
        Me.grpTransactions.TabStop = False
        Me.grpTransactions.Text = "TRANSACTION LIST"
        '
        'cboFilter
        '
        Me.cboFilter.FormattingEnabled = True
        Me.cboFilter.Location = New System.Drawing.Point(95, 40)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(139, 29)
        Me.cboFilter.TabIndex = 49
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(462, 168)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(164, 39)
        Me.btnSearch.TabIndex = 50
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(22, 28)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(592, 167)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'paymentRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.grpTransactions)
        Me.Controls.Add(Me.grpFilters)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "paymentRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "paymentRecords"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.grpFilters.ResumeLayout(False)
        Me.grpFilters.PerformLayout()
        Me.grpTransactions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpFilters As GroupBox
    Friend WithEvents cboFilter As ComboBox
    Friend WithEvents grpTransactions As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
