<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesReport
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
        Me.fororganization = New System.Windows.Forms.Panel()
        Me.todaysRevenueLbl = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.lblBookingsTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.grpFilters = New System.Windows.Forms.GroupBox()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.grpProfit = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lvwReport = New System.Windows.Forms.ListView()
        Me.txtNetProfit = New System.Windows.Forms.TextBox()
        Me.fororganization.SuspendLayout()
        Me.pnlDailyOverview.SuspendLayout()
        Me.grpFilters.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.grpProfit.SuspendLayout()
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
        Me.fororganization.Size = New System.Drawing.Size(684, 26)
        Me.fororganization.TabIndex = 20
        '
        'todaysRevenueLbl
        '
        Me.todaysRevenueLbl.AutoSize = True
        Me.todaysRevenueLbl.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todaysRevenueLbl.ForeColor = System.Drawing.Color.White
        Me.todaysRevenueLbl.Location = New System.Drawing.Point(538, -9)
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
        Me.lblRevenue.Location = New System.Drawing.Point(59, -9)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(128, 32)
        Me.lblRevenue.TabIndex = 16
        Me.lblRevenue.Text = "REVENUE:"
        '
        'lblBookingsTitle
        '
        Me.lblBookingsTitle.AutoSize = True
        Me.lblBookingsTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblBookingsTitle.Location = New System.Drawing.Point(6, 16)
        Me.lblBookingsTitle.Name = "lblBookingsTitle"
        Me.lblBookingsTitle.Size = New System.Drawing.Size(59, 21)
        Me.lblBookingsTitle.TabIndex = 21
        Me.lblBookingsTitle.Text = "FROM:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(151, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(360, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "SALES REPORT"
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 83)
        Me.pnlDailyOverview.TabIndex = 22
        '
        'grpFilters
        '
        Me.grpFilters.Controls.Add(Me.DateTimePicker2)
        Me.grpFilters.Controls.Add(Me.DateTimePicker1)
        Me.grpFilters.Controls.Add(Me.btnGenerate)
        Me.grpFilters.Controls.Add(Me.ComboBox1)
        Me.grpFilters.Controls.Add(Me.Label2)
        Me.grpFilters.Controls.Add(Me.Label1)
        Me.grpFilters.Controls.Add(Me.lblBookingsTitle)
        Me.grpFilters.Location = New System.Drawing.Point(12, 115)
        Me.grpFilters.Name = "grpFilters"
        Me.grpFilters.Size = New System.Drawing.Size(660, 126)
        Me.grpFilters.TabIndex = 25
        Me.grpFilters.TabStop = False
        Me.grpFilters.Text = "Report Filters"
        '
        'grpResults
        '
        Me.grpResults.Controls.Add(Me.lvwReport)
        Me.grpResults.Location = New System.Drawing.Point(12, 258)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(645, 135)
        Me.grpResults.TabIndex = 26
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Report Results"
        '
        'grpProfit
        '
        Me.grpProfit.Controls.Add(Me.txtNetProfit)
        Me.grpProfit.Location = New System.Drawing.Point(12, 411)
        Me.grpProfit.Name = "grpProfit"
        Me.grpProfit.Size = New System.Drawing.Size(645, 127)
        Me.grpProfit.TabIndex = 26
        Me.grpProfit.TabStop = False
        Me.grpProfit.Text = "Net Profit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 21)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "TO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "TYPE:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(69, 85)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(148, 21)
        Me.ComboBox1.TabIndex = 24
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(482, 82)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(149, 29)
        Me.btnGenerate.TabIndex = 25
        Me.btnGenerate.Text = "GENERATE REPORT"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(71, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker1.TabIndex = 26
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(71, 50)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker2.TabIndex = 27
        '
        'lvwReport
        '
        Me.lvwReport.HideSelection = False
        Me.lvwReport.Location = New System.Drawing.Point(10, 19)
        Me.lvwReport.Name = "lvwReport"
        Me.lvwReport.Size = New System.Drawing.Size(621, 110)
        Me.lvwReport.TabIndex = 0
        Me.lvwReport.UseCompatibleStateImageBehavior = False
        '
        'txtNetProfit
        '
        Me.txtNetProfit.Location = New System.Drawing.Point(370, 55)
        Me.txtNetProfit.Name = "txtNetProfit"
        Me.txtNetProfit.ReadOnly = True
        Me.txtNetProfit.Size = New System.Drawing.Size(199, 20)
        Me.txtNetProfit.TabIndex = 0
        '
        'salesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.grpProfit)
        Me.Controls.Add(Me.grpFilters)
        Me.Controls.Add(Me.fororganization)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "salesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "salesReport"
        Me.fororganization.ResumeLayout(False)
        Me.fororganization.PerformLayout()
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.grpFilters.ResumeLayout(False)
        Me.grpFilters.PerformLayout()
        Me.grpResults.ResumeLayout(False)
        Me.grpProfit.ResumeLayout(False)
        Me.grpProfit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fororganization As Panel
    Friend WithEvents todaysRevenueLbl As Label
    Friend WithEvents lblRevenue As Label
    Friend WithEvents lblBookingsTitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents grpFilters As GroupBox
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents grpProfit As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnGenerate As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lvwReport As ListView
    Friend WithEvents txtNetProfit As TextBox
End Class
