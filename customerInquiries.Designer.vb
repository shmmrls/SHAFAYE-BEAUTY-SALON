<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customerInquiries
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMessagesContainer = New System.Windows.Forms.Panel()
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.pnlDailyOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(142, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(536, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "CUSTOMER INQUIRIES"
        '
        'pnlMessagesContainer
        '
        Me.pnlMessagesContainer.AutoScroll = True
        Me.pnlMessagesContainer.Location = New System.Drawing.Point(38, 123)
        Me.pnlMessagesContainer.Name = "pnlMessagesContainer"
        Me.pnlMessagesContainer.Size = New System.Drawing.Size(639, 416)
        Me.pnlMessagesContainer.TabIndex = 27
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 110)
        Me.pnlDailyOverview.TabIndex = 26
        '
        'customerInquiries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.pnlMessagesContainer)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customerInquiries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "customerInquiries"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlMessagesContainer As Panel
    Friend WithEvents pnlDailyOverview As Panel
End Class
