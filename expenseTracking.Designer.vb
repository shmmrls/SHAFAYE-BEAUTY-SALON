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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnReportMonth = New System.Windows.Forms.Button()
        Me.expenseTypetxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReportAnnual = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.amtTxtNewExpense = New System.Windows.Forms.TextBox()
        Me.descriptionExistingExpense = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbExistingExpense = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pnlDailyOverview.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(143, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(485, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "EXPENSE TRACKING"
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.ForeColor = System.Drawing.Color.White
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 83)
        Me.pnlDailyOverview.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(62, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "DESCRIPTION:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(387, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "AMOUNT:"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Location = New System.Drawing.Point(66, 187)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(259, 59)
        Me.txtDescription.TabIndex = 37
        '
        'txtAmount
        '
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Location = New System.Drawing.Point(488, 135)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(160, 20)
        Me.txtAmount.TabIndex = 39
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(389, 200)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(259, 33)
        Me.btnAdd.TabIndex = 40
        Me.btnAdd.Text = "ADD EXPENSE"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnReportMonth
        '
        Me.btnReportMonth.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnReportMonth.Location = New System.Drawing.Point(64, 21)
        Me.btnReportMonth.Name = "btnReportMonth"
        Me.btnReportMonth.Size = New System.Drawing.Size(261, 33)
        Me.btnReportMonth.TabIndex = 46
        Me.btnReportMonth.Text = "GENERATE MONTHLY EXPENSE REPORT"
        Me.btnReportMonth.UseVisualStyleBackColor = True
        '
        'expenseTypetxt
        '
        Me.expenseTypetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.expenseTypetxt.Location = New System.Drawing.Point(191, 133)
        Me.expenseTypetxt.Name = "expenseTypetxt"
        Me.expenseTypetxt.Size = New System.Drawing.Size(132, 20)
        Me.expenseTypetxt.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(60, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 21)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "EXPENSE TYPE:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnReportAnnual)
        Me.Panel1.Controls.Add(Me.btnReportMonth)
        Me.Panel1.Location = New System.Drawing.Point(0, 263)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 73)
        Me.Panel1.TabIndex = 50
        '
        'btnReportAnnual
        '
        Me.btnReportAnnual.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportAnnual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnReportAnnual.Location = New System.Drawing.Point(387, 21)
        Me.btnReportAnnual.Name = "btnReportAnnual"
        Me.btnReportAnnual.Size = New System.Drawing.Size(261, 33)
        Me.btnReportAnnual.TabIndex = 47
        Me.btnReportAnnual.Text = "GENERATE ANNUAL EXPENSE REPORT"
        Me.btnReportAnnual.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(60, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 21)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "EXPENSE TYPE:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(389, 453)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(259, 33)
        Me.btnUpdate.TabIndex = 57
        Me.btnUpdate.Text = "UPDATE EXPENSE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'amtTxtNewExpense
        '
        Me.amtTxtNewExpense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.amtTxtNewExpense.Location = New System.Drawing.Point(488, 415)
        Me.amtTxtNewExpense.Name = "amtTxtNewExpense"
        Me.amtTxtNewExpense.Size = New System.Drawing.Size(160, 20)
        Me.amtTxtNewExpense.TabIndex = 56
        '
        'descriptionExistingExpense
        '
        Me.descriptionExistingExpense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descriptionExistingExpense.Location = New System.Drawing.Point(66, 467)
        Me.descriptionExistingExpense.Multiline = True
        Me.descriptionExistingExpense.Name = "descriptionExistingExpense"
        Me.descriptionExistingExpense.Size = New System.Drawing.Size(259, 59)
        Me.descriptionExistingExpense.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(387, 412)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 21)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "AMOUNT:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(62, 443)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 21)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "DESCRIPTION:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(244, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(229, 21)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "UPDATE EXISTING EXPENSES"
        '
        'cmbExistingExpense
        '
        Me.cmbExistingExpense.FormattingEnabled = True
        Me.cmbExistingExpense.Location = New System.Drawing.Point(191, 411)
        Me.cmbExistingExpense.Name = "cmbExistingExpense"
        Me.cmbExistingExpense.Size = New System.Drawing.Size(134, 21)
        Me.cmbExistingExpense.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(278, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 21)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "ADD NEW EXPENSE"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(387, 493)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(259, 33)
        Me.btnDelete.TabIndex = 63
        Me.btnDelete.Text = "DELETE EXPENSE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'expenseTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbExistingExpense)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.amtTxtNewExpense)
        Me.Controls.Add(Me.descriptionExistingExpense)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.expenseTypetxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "expenseTracking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "expenseTracking"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnReportMonth As Button
    Friend WithEvents expenseTypetxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents amtTxtNewExpense As TextBox
    Friend WithEvents descriptionExistingExpense As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnReportAnnual As Button
    Friend WithEvents cmbExistingExpense As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
End Class
