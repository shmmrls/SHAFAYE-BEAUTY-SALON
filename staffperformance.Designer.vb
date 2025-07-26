<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffperformance
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
        Me.pnlStaffPerformance = New System.Windows.Forms.Panel()
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.btnUpdateSalary = New System.Windows.Forms.Button()
        Me.pnlDailyOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(103, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(529, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "STAFF PERFORMANCE"
        '
        'pnlStaffPerformance
        '
        Me.pnlStaffPerformance.AutoScroll = True
        Me.pnlStaffPerformance.Location = New System.Drawing.Point(52, 108)
        Me.pnlStaffPerformance.Name = "pnlStaffPerformance"
        Me.pnlStaffPerformance.Size = New System.Drawing.Size(592, 363)
        Me.pnlStaffPerformance.TabIndex = 27
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
        'btnUpdateSalary
        '
        Me.btnUpdateSalary.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSalary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnUpdateSalary.Location = New System.Drawing.Point(269, 492)
        Me.btnUpdateSalary.Name = "btnUpdateSalary"
        Me.btnUpdateSalary.Size = New System.Drawing.Size(150, 32)
        Me.btnUpdateSalary.TabIndex = 28
        Me.btnUpdateSalary.Text = "Update Salary"
        Me.btnUpdateSalary.UseVisualStyleBackColor = True
        '
        'staffperformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.btnUpdateSalary)
        Me.Controls.Add(Me.pnlStaffPerformance)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staffperformance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staffperformance"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlStaffPerformance As Panel
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents btnUpdateSalary As Button
End Class
