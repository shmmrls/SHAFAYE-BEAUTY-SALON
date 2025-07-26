<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quickStats
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
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.pnlTotalClientsCard = New System.Windows.Forms.Panel()
        Me.pnlRevenueCard = New System.Windows.Forms.Panel()
        Me.lblClientsTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblMonthlyRevenue = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.pnlDailyOverview.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(178, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(326, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "QUICK STATS"
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 83)
        Me.pnlDailyOverview.TabIndex = 20
        '
        'pnlTotalClientsCard
        '
        Me.pnlTotalClientsCard.AutoScroll = True
        Me.pnlTotalClientsCard.Location = New System.Drawing.Point(54, 132)
        Me.pnlTotalClientsCard.Name = "pnlTotalClientsCard"
        Me.pnlTotalClientsCard.Size = New System.Drawing.Size(592, 154)
        Me.pnlTotalClientsCard.TabIndex = 21
        '
        'pnlRevenueCard
        '
        Me.pnlRevenueCard.AutoScroll = True
        Me.pnlRevenueCard.Location = New System.Drawing.Point(54, 329)
        Me.pnlRevenueCard.Name = "pnlRevenueCard"
        Me.pnlRevenueCard.Size = New System.Drawing.Size(592, 154)
        Me.pnlRevenueCard.TabIndex = 22
        '
        'lblClientsTitle
        '
        Me.lblClientsTitle.AutoSize = True
        Me.lblClientsTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientsTitle.ForeColor = System.Drawing.Color.White
        Me.lblClientsTitle.Location = New System.Drawing.Point(4, 4)
        Me.lblClientsTitle.Name = "lblClientsTitle"
        Me.lblClientsTitle.Size = New System.Drawing.Size(171, 30)
        Me.lblClientsTitle.TabIndex = 14
        Me.lblClientsTitle.Text = "TOTAL CLIENTS:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblClientsTitle)
        Me.Panel1.Location = New System.Drawing.Point(54, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 38)
        Me.Panel1.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblMonthlyRevenue)
        Me.Panel2.Location = New System.Drawing.Point(54, 292)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(592, 38)
        Me.Panel2.TabIndex = 24
        '
        'lblMonthlyRevenue
        '
        Me.lblMonthlyRevenue.AutoSize = True
        Me.lblMonthlyRevenue.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyRevenue.ForeColor = System.Drawing.Color.White
        Me.lblMonthlyRevenue.Location = New System.Drawing.Point(4, 4)
        Me.lblMonthlyRevenue.Name = "lblMonthlyRevenue"
        Me.lblMonthlyRevenue.Size = New System.Drawing.Size(222, 30)
        Me.lblMonthlyRevenue.TabIndex = 14
        Me.lblMonthlyRevenue.Text = "MONTHLY REVENUE:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(260, 498)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(150, 23)
        Me.btnRefresh.TabIndex = 25
        Me.btnRefresh.Text = "Refresh Data"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'quickStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlRevenueCard)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlTotalClientsCard)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "quickStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "quickStats"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents pnlTotalClientsCard As Panel
    Friend WithEvents pnlRevenueCard As Panel
    Friend WithEvents lblClientsTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblMonthlyRevenue As Label
    Friend WithEvents btnRefresh As Button
End Class
