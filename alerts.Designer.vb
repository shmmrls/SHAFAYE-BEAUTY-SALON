<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alerts
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
        Me.flwAlerts = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnUpdatedInventory = New System.Windows.Forms.Button()
        Me.pnlDailyOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(668, 83)
        Me.pnlDailyOverview.TabIndex = 24
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(220, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(265, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "ALERTS⚠"
        '
        'flwAlerts
        '
        Me.flwAlerts.Location = New System.Drawing.Point(32, 105)
        Me.flwAlerts.Name = "flwAlerts"
        Me.flwAlerts.Size = New System.Drawing.Size(612, 356)
        Me.flwAlerts.TabIndex = 25
        '
        'btnUpdatedInventory
        '
        Me.btnUpdatedInventory.BackColor = System.Drawing.Color.White
        Me.btnUpdatedInventory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnUpdatedInventory.Location = New System.Drawing.Point(249, 472)
        Me.btnUpdatedInventory.Name = "btnUpdatedInventory"
        Me.btnUpdatedInventory.Size = New System.Drawing.Size(177, 38)
        Me.btnUpdatedInventory.TabIndex = 42
        Me.btnUpdatedInventory.Text = "MANAGE INVENTORY"
        Me.btnUpdatedInventory.UseVisualStyleBackColor = False
        '
        'alerts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(668, 522)
        Me.Controls.Add(Me.btnUpdatedInventory)
        Me.Controls.Add(Me.flwAlerts)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "alerts"
        Me.Text = "alerts"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents flwAlerts As FlowLayoutPanel
    Friend WithEvents btnUpdatedInventory As Button
End Class
