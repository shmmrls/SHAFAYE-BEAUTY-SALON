<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageCustomers
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
        Me.pnlTotalClientsCard = New System.Windows.Forms.Panel()
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlDailyOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTotalClientsCard
        '
        Me.pnlTotalClientsCard.AutoScroll = True
        Me.pnlTotalClientsCard.Location = New System.Drawing.Point(52, 122)
        Me.pnlTotalClientsCard.Name = "pnlTotalClientsCard"
        Me.pnlTotalClientsCard.Size = New System.Drawing.Size(592, 400)
        Me.pnlTotalClientsCard.TabIndex = 25
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 99)
        Me.pnlDailyOverview.TabIndex = 24
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(168, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(537, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "MANAGE CUSTOMERS"
        '
        'manageCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.pnlTotalClientsCard)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "managecustomers"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTotalClientsCard As Panel
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents lblTitle As Label
End Class
