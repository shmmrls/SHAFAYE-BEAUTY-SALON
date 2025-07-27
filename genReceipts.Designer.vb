<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class genReceipts
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlReceipt = New System.Windows.Forms.Panel()
        Me.amountLbl = New System.Windows.Forms.Label()
        Me.serviceLbl = New System.Windows.Forms.Label()
        Me.customerLbl = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cmbBookingIdCompleted = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlDailyOverview.SuspendLayout()
        Me.pnlReceipt.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.ForeColor = System.Drawing.Color.White
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 62)
        Me.pnlDailyOverview.TabIndex = 52
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(81, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(516, 45)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "GENERATE AND PRINT RECEIPTS"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(194, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 21)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Select Booking ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlReceipt
        '
        Me.pnlReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlReceipt.Controls.Add(Me.Panel1)
        Me.pnlReceipt.Controls.Add(Me.amountLbl)
        Me.pnlReceipt.Controls.Add(Me.serviceLbl)
        Me.pnlReceipt.Controls.Add(Me.customerLbl)
        Me.pnlReceipt.Location = New System.Drawing.Point(48, 158)
        Me.pnlReceipt.Name = "pnlReceipt"
        Me.pnlReceipt.Size = New System.Drawing.Size(579, 304)
        Me.pnlReceipt.TabIndex = 57
        '
        'amountLbl
        '
        Me.amountLbl.AutoSize = True
        Me.amountLbl.BackColor = System.Drawing.Color.Transparent
        Me.amountLbl.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.amountLbl.Location = New System.Drawing.Point(35, 232)
        Me.amountLbl.Name = "amountLbl"
        Me.amountLbl.Size = New System.Drawing.Size(100, 30)
        Me.amountLbl.TabIndex = 61
        Me.amountLbl.Text = "Amount:"
        Me.amountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'serviceLbl
        '
        Me.serviceLbl.AutoSize = True
        Me.serviceLbl.BackColor = System.Drawing.Color.Transparent
        Me.serviceLbl.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serviceLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.serviceLbl.Location = New System.Drawing.Point(35, 123)
        Me.serviceLbl.Name = "serviceLbl"
        Me.serviceLbl.Size = New System.Drawing.Size(89, 30)
        Me.serviceLbl.TabIndex = 60
        Me.serviceLbl.Text = "Service:"
        Me.serviceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'customerLbl
        '
        Me.customerLbl.AutoSize = True
        Me.customerLbl.BackColor = System.Drawing.Color.Transparent
        Me.customerLbl.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.customerLbl.Location = New System.Drawing.Point(35, 65)
        Me.customerLbl.Name = "customerLbl"
        Me.customerLbl.Size = New System.Drawing.Size(114, 30)
        Me.customerLbl.TabIndex = 59
        Me.customerLbl.Text = "Customer:"
        Me.customerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(204, 486)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(258, 40)
        Me.btnPrint.TabIndex = 58
        Me.btnPrint.Text = "PRINT RECEIPT FOR ADMIN COPY"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cmbBookingIdCompleted
        '
        Me.cmbBookingIdCompleted.FormattingEnabled = True
        Me.cmbBookingIdCompleted.Location = New System.Drawing.Point(355, 109)
        Me.cmbBookingIdCompleted.Name = "cmbBookingIdCompleted"
        Me.cmbBookingIdCompleted.Size = New System.Drawing.Size(126, 21)
        Me.cmbBookingIdCompleted.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(40, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 10)
        Me.Panel1.TabIndex = 62
        '
        'genReceipts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.cmbBookingIdCompleted)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.pnlReceipt)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "genReceipts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "genReceipts"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.pnlReceipt.ResumeLayout(False)
        Me.pnlReceipt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlReceipt As Panel
    Friend WithEvents amountLbl As Label
    Friend WithEvents serviceLbl As Label
    Friend WithEvents customerLbl As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents cmbBookingIdCompleted As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
