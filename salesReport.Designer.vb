<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class salesReport
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
        Me.lblBookingsTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.grpFilters = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.cmbCategServ = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.listViewSummaryofreport = New System.Windows.Forms.ListView()
        Me.grpProfit = New System.Windows.Forms.GroupBox()
        Me.panelNetProfit = New System.Windows.Forms.Panel()
        Me.pnlDailyOverview.SuspendLayout()
        Me.grpFilters.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.grpProfit.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBookingsTitle
        '
        Me.lblBookingsTitle.AutoSize = True
        Me.lblBookingsTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblBookingsTitle.Location = New System.Drawing.Point(40, 35)
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
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(208, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(360, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "SALES REPORT"
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 83)
        Me.pnlDailyOverview.TabIndex = 22
        '
        'grpFilters
        '
        Me.grpFilters.Controls.Add(Me.DateTimePickerTo)
        Me.grpFilters.Controls.Add(Me.DateTimePickerFrom)
        Me.grpFilters.Controls.Add(Me.btnGenerate)
        Me.grpFilters.Controls.Add(Me.cmbCategServ)
        Me.grpFilters.Controls.Add(Me.Label2)
        Me.grpFilters.Controls.Add(Me.Label1)
        Me.grpFilters.Controls.Add(Me.lblBookingsTitle)
        Me.grpFilters.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFilters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.grpFilters.Location = New System.Drawing.Point(12, 108)
        Me.grpFilters.Name = "grpFilters"
        Me.grpFilters.Size = New System.Drawing.Size(660, 126)
        Me.grpFilters.TabIndex = 25
        Me.grpFilters.TabStop = False
        Me.grpFilters.Text = "Report Filters"
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTo.Location = New System.Drawing.Point(105, 69)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(215, 25)
        Me.DateTimePickerTo.TabIndex = 27
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(105, 38)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(215, 25)
        Me.DateTimePickerFrom.TabIndex = 26
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnGenerate.Location = New System.Drawing.Point(350, 68)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(236, 28)
        Me.btnGenerate.TabIndex = 25
        Me.btnGenerate.Text = "GENERATE  SALES REPORT"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'cmbCategServ
        '
        Me.cmbCategServ.FormattingEnabled = True
        Me.cmbCategServ.Location = New System.Drawing.Point(409, 38)
        Me.cmbCategServ.Name = "cmbCategServ"
        Me.cmbCategServ.Size = New System.Drawing.Size(177, 25)
        Me.cmbCategServ.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(346, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "TYPE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(40, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 21)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "TO:"
        '
        'grpResults
        '
        Me.grpResults.Controls.Add(Me.listViewSummaryofreport)
        Me.grpResults.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.grpResults.Location = New System.Drawing.Point(12, 255)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(645, 135)
        Me.grpResults.TabIndex = 26
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Summary of Report Results"
        '
        'listViewSummaryofreport
        '
        Me.listViewSummaryofreport.HideSelection = False
        Me.listViewSummaryofreport.Location = New System.Drawing.Point(44, 19)
        Me.listViewSummaryofreport.Name = "listViewSummaryofreport"
        Me.listViewSummaryofreport.Size = New System.Drawing.Size(542, 110)
        Me.listViewSummaryofreport.TabIndex = 0
        Me.listViewSummaryofreport.UseCompatibleStateImageBehavior = False
        '
        'grpProfit
        '
        Me.grpProfit.Controls.Add(Me.panelNetProfit)
        Me.grpProfit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProfit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.grpProfit.Location = New System.Drawing.Point(12, 407)
        Me.grpProfit.Name = "grpProfit"
        Me.grpProfit.Size = New System.Drawing.Size(645, 127)
        Me.grpProfit.TabIndex = 26
        Me.grpProfit.TabStop = False
        Me.grpProfit.Text = "Gross Profit"
        '
        'panelNetProfit
        '
        Me.panelNetProfit.Location = New System.Drawing.Point(140, 21)
        Me.panelNetProfit.Name = "panelNetProfit"
        Me.panelNetProfit.Size = New System.Drawing.Size(360, 100)
        Me.panelNetProfit.TabIndex = 0
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
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "salesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "salesReport"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.grpFilters.ResumeLayout(False)
        Me.grpFilters.PerformLayout()
        Me.grpResults.ResumeLayout(False)
        Me.grpProfit.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBookingsTitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents grpFilters As GroupBox
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents grpProfit As GroupBox
    Friend WithEvents DateTimePickerTo As DateTimePicker
    Friend WithEvents DateTimePickerFrom As DateTimePicker
    Friend WithEvents btnGenerate As Button
    Friend WithEvents cmbCategServ As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents listViewSummaryofreport As ListView
    Friend WithEvents panelNetProfit As Panel
End Class
