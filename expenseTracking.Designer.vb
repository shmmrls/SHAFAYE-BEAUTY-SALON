<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class expenseTracking
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFilterDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.pnlHistory = New System.Windows.Forms.Panel()
        Me.pnlDailyOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(107, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(485, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "EXPENSE TRACKING"
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 83)
        Me.pnlDailyOverview.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "DATE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "DESCRIPTION:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(319, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 21)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "CATEGORY:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(319, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "AMOUNT:"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(95, 99)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(189, 20)
        Me.dtpDate.TabIndex = 36
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(145, 137)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(148, 20)
        Me.txtDescription.TabIndex = 37
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(420, 98)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(172, 21)
        Me.cmbCategory.TabIndex = 38
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(420, 137)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(198, 20)
        Me.txtAmount.TabIndex = 39
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(25, 179)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(161, 33)
        Me.btnAdd.TabIndex = 40
        Me.btnAdd.Text = "ADD EXPENSE"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 21)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Filter by Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(355, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 21)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Filter by:"
        '
        'dtpFilterDate
        '
        Me.dtpFilterDate.Location = New System.Drawing.Point(148, 231)
        Me.dtpFilterDate.Name = "dtpFilterDate"
        Me.dtpFilterDate.Size = New System.Drawing.Size(189, 20)
        Me.dtpFilterDate.TabIndex = 43
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Location = New System.Drawing.Point(437, 230)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(172, 21)
        Me.cmbFilter.TabIndex = 44
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(30, 271)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(161, 33)
        Me.btnSearch.TabIndex = 45
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(338, 271)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(161, 33)
        Me.btnReport.TabIndex = 46
        Me.btnReport.Text = "GENERATE REPORT"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'pnlHistory
        '
        Me.pnlHistory.Location = New System.Drawing.Point(30, 325)
        Me.pnlHistory.Name = "pnlHistory"
        Me.pnlHistory.Size = New System.Drawing.Size(618, 224)
        Me.pnlHistory.TabIndex = 47
        '
        'expenseTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.pnlHistory)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.dtpFilterDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "expenseTracking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "expenseTracking"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFilterDate As DateTimePicker
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents pnlHistory As Panel
End Class
