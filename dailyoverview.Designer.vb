<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dailyoverview
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
        Me.fororganization = New System.Windows.Forms.Panel()
        Me.todaysRevenueLbl = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.lblBookingsTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.flowBookings = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.fororganization.SuspendLayout()
        Me.pnlDailyOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'fororganization
        '
        Me.fororganization.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.fororganization.Controls.Add(Me.todaysRevenueLbl)
        Me.fororganization.Controls.Add(Me.lblRevenue)
        Me.fororganization.Dock = System.Windows.Forms.DockStyle.Top
        Me.fororganization.Location = New System.Drawing.Point(0, 83)
        Me.fororganization.Name = "fororganization"
        Me.fororganization.Size = New System.Drawing.Size(684, 63)
        Me.fororganization.TabIndex = 16
        '
        'todaysRevenueLbl
        '
        Me.todaysRevenueLbl.AutoSize = True
        Me.todaysRevenueLbl.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todaysRevenueLbl.ForeColor = System.Drawing.Color.White
        Me.todaysRevenueLbl.Location = New System.Drawing.Point(534, 16)
        Me.todaysRevenueLbl.Name = "todaysRevenueLbl"
        Me.todaysRevenueLbl.Size = New System.Drawing.Size(105, 32)
        Me.todaysRevenueLbl.TabIndex = 18
        Me.todaysRevenueLbl.Text = "000,000"
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.ForeColor = System.Drawing.Color.White
        Me.lblRevenue.Location = New System.Drawing.Point(55, 16)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(128, 32)
        Me.lblRevenue.TabIndex = 16
        Me.lblRevenue.Text = "REVENUE:"
        '
        'lblBookingsTitle
        '
        Me.lblBookingsTitle.AutoSize = True
        Me.lblBookingsTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblBookingsTitle.Location = New System.Drawing.Point(251, 165)
        Me.lblBookingsTitle.Name = "lblBookingsTitle"
        Me.lblBookingsTitle.Size = New System.Drawing.Size(194, 25)
        Me.lblBookingsTitle.TabIndex = 17
        Me.lblBookingsTitle.Text = "TODAY'S BOOKINGS"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(176, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(422, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "DAILY OVERVIEW"
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 83)
        Me.pnlDailyOverview.TabIndex = 17
        '
        'flowBookings
        '
        Me.flowBookings.AutoScroll = True
        Me.flowBookings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowBookings.Location = New System.Drawing.Point(61, 214)
        Me.flowBookings.Name = "flowBookings"
        Me.flowBookings.Size = New System.Drawing.Size(578, 259)
        Me.flowBookings.TabIndex = 18
        Me.flowBookings.WrapContents = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(273, 494)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(150, 23)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.Text = "Refresh Data"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dailyoverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.flowBookings)
        Me.Controls.Add(Me.lblBookingsTitle)
        Me.Controls.Add(Me.fororganization)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dailyoverview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dailyoverview"
        Me.fororganization.ResumeLayout(False)
        Me.fororganization.PerformLayout()
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fororganization As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents lblRevenue As Label
    Friend WithEvents flowBookings As FlowLayoutPanel
    Friend WithEvents lblBookingsTitle As Label
    Friend WithEvents todaysRevenueLbl As Label
    Friend WithEvents btnRefresh As Button
End Class
