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
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpTransactions = New System.Windows.Forms.GroupBox()
        Me.panelPaymentLogs = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbServiceCateg = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.btnAnnually = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.pnlDailyOverview.SuspendLayout()
        Me.grpTransactions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
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
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(107, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(479, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "PAYMENT RECORDS"
        '
        'grpTransactions
        '
        Me.grpTransactions.Controls.Add(Me.btnRefresh)
        Me.grpTransactions.Controls.Add(Me.btnAnnually)
        Me.grpTransactions.Controls.Add(Me.btnMonthly)
        Me.grpTransactions.Controls.Add(Me.panelPaymentLogs)
        Me.grpTransactions.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpTransactions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.grpTransactions.Location = New System.Drawing.Point(29, 156)
        Me.grpTransactions.Name = "grpTransactions"
        Me.grpTransactions.Size = New System.Drawing.Size(643, 382)
        Me.grpTransactions.TabIndex = 53
        Me.grpTransactions.TabStop = False
        Me.grpTransactions.Text = "TRANSACTION LIST"
        '
        'panelPaymentLogs
        '
        Me.panelPaymentLogs.AutoScroll = True
        Me.panelPaymentLogs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panelPaymentLogs.Location = New System.Drawing.Point(22, 71)
        Me.panelPaymentLogs.Name = "panelPaymentLogs"
        Me.panelPaymentLogs.Size = New System.Drawing.Size(592, 295)
        Me.panelPaymentLogs.TabIndex = 0
        Me.panelPaymentLogs.WrapContents = False
        '
        'cmbServiceCateg
        '
        Me.cmbServiceCateg.FormattingEnabled = True
        Me.cmbServiceCateg.Location = New System.Drawing.Point(367, 109)
        Me.cmbServiceCateg.Name = "cmbServiceCateg"
        Me.cmbServiceCateg.Size = New System.Drawing.Size(126, 21)
        Me.cmbServiceCateg.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(155, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 21)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Select Service Category"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMonthly
        '
        Me.btnMonthly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMonthly.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonthly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnMonthly.Location = New System.Drawing.Point(22, 33)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(184, 25)
        Me.btnMonthly.TabIndex = 59
        Me.btnMonthly.Text = "SHOW MONTHLY"
        Me.btnMonthly.UseVisualStyleBackColor = True
        '
        'btnAnnually
        '
        Me.btnAnnually.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnually.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnually.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnAnnually.Location = New System.Drawing.Point(225, 33)
        Me.btnAnnually.Name = "btnAnnually"
        Me.btnAnnually.Size = New System.Drawing.Size(184, 25)
        Me.btnAnnually.TabIndex = 60
        Me.btnAnnually.Text = "SHOW ANNUALLY"
        Me.btnAnnually.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(430, 33)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(184, 25)
        Me.btnRefresh.TabIndex = 61
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'paymentRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.cmbServiceCateg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpTransactions)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "paymentRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "paymentRecords"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.grpTransactions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpTransactions As GroupBox
    Friend WithEvents panelPaymentLogs As FlowLayoutPanel
    Friend WithEvents cmbServiceCateg As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAnnually As Button
    Friend WithEvents btnMonthly As Button
End Class
