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
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dtpBookingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.flpBookings = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblBookingsTitle = New System.Windows.Forms.Label()
        Me.fororganization.SuspendLayout()
        Me.pnlDailyOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'fororganization
        '
        Me.fororganization.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.fororganization.Controls.Add(Me.lblBookingsTitle)
        Me.fororganization.Controls.Add(Me.lblRevenue)
        Me.fororganization.Controls.Add(Me.btnSearch)
        Me.fororganization.Controls.Add(Me.dtpBookingDate)
        Me.fororganization.Controls.Add(Me.Label3)
        Me.fororganization.Controls.Add(Me.Label2)
        Me.fororganization.Dock = System.Windows.Forms.DockStyle.Top
        Me.fororganization.Location = New System.Drawing.Point(0, 83)
        Me.fororganization.Name = "fororganization"
        Me.fororganization.Size = New System.Drawing.Size(684, 82)
        Me.fororganization.TabIndex = 16
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.ForeColor = System.Drawing.Color.White
        Me.lblRevenue.Location = New System.Drawing.Point(46, 36)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(69, 17)
        Me.lblRevenue.TabIndex = 16
        Me.lblRevenue.Text = "REVENUE:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(348, 6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(127, 37)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dtpBookingDate
        '
        Me.dtpBookingDate.Location = New System.Drawing.Point(145, 15)
        Me.dtpBookingDate.Name = "dtpBookingDate"
        Me.dtpBookingDate.Size = New System.Drawing.Size(187, 20)
        Me.dtpBookingDate.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "SELECT DATE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(142, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 12
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(159, 9)
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
        'flpBookings
        '
        Me.flpBookings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpBookings.Location = New System.Drawing.Point(23, 192)
        Me.flpBookings.Name = "flpBookings"
        Me.flpBookings.Size = New System.Drawing.Size(635, 338)
        Me.flpBookings.TabIndex = 18
        '
        'lblBookingsTitle
        '
        Me.lblBookingsTitle.AutoSize = True
        Me.lblBookingsTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingsTitle.ForeColor = System.Drawing.Color.White
        Me.lblBookingsTitle.Location = New System.Drawing.Point(47, 56)
        Me.lblBookingsTitle.Name = "lblBookingsTitle"
        Me.lblBookingsTitle.Size = New System.Drawing.Size(74, 17)
        Me.lblBookingsTitle.TabIndex = 17
        Me.lblBookingsTitle.Text = "BOOKINGS"
        '
        'dailyoverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.flpBookings)
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

    End Sub
    Friend WithEvents fororganization As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents lblRevenue As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents flpBookings As FlowLayoutPanel
    Friend WithEvents lblBookingsTitle As Label
End Class
