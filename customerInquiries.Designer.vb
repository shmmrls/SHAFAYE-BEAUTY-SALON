<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerInquiries
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlTotalClientsCard = New System.Windows.Forms.Panel()
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.btnRespond = New System.Windows.Forms.Button()
        Me.btnViewFAQ = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMessageDetails = New System.Windows.Forms.TextBox()
        Me.pnlDailyOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(89, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(536, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "CUSTOMER INQUIRIES"
        '
        'pnlTotalClientsCard
        '
        Me.pnlTotalClientsCard.AutoScroll = True
        Me.pnlTotalClientsCard.Location = New System.Drawing.Point(17, 106)
        Me.pnlTotalClientsCard.Name = "pnlTotalClientsCard"
        Me.pnlTotalClientsCard.Size = New System.Drawing.Size(639, 297)
        Me.pnlTotalClientsCard.TabIndex = 27
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 83)
        Me.pnlDailyOverview.TabIndex = 26
        '
        'btnRespond
        '
        Me.btnRespond.Location = New System.Drawing.Point(143, 492)
        Me.btnRespond.Name = "btnRespond"
        Me.btnRespond.Size = New System.Drawing.Size(134, 57)
        Me.btnRespond.TabIndex = 28
        Me.btnRespond.Text = "RESPOND"
        Me.btnRespond.UseVisualStyleBackColor = True
        '
        'btnViewFAQ
        '
        Me.btnViewFAQ.Location = New System.Drawing.Point(369, 492)
        Me.btnViewFAQ.Name = "btnViewFAQ"
        Me.btnViewFAQ.Size = New System.Drawing.Size(134, 57)
        Me.btnViewFAQ.TabIndex = 29
        Me.btnViewFAQ.Text = "VIEW FAQ"
        Me.btnViewFAQ.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(34, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SELECTED MESSAGES:"
        '
        'txtMessageDetails
        '
        Me.txtMessageDetails.Location = New System.Drawing.Point(39, 439)
        Me.txtMessageDetails.Multiline = True
        Me.txtMessageDetails.Name = "txtMessageDetails"
        Me.txtMessageDetails.Size = New System.Drawing.Size(346, 34)
        Me.txtMessageDetails.TabIndex = 30
        '
        'customerInquiries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.txtMessageDetails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewFAQ)
        Me.Controls.Add(Me.btnRespond)
        Me.Controls.Add(Me.pnlTotalClientsCard)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customerInquiries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "customerInquiries"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlTotalClientsCard As Panel
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents btnRespond As Button
    Friend WithEvents btnViewFAQ As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMessageDetails As TextBox
End Class
