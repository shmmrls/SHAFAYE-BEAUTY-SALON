<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class faqManagement
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
        Me.rtbAnswer = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnToggleStatus = New System.Windows.Forms.Button()
        Me.flpFaqList = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbQuestions = New System.Windows.Forms.ComboBox()
        Me.pnlDailyOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.ForeColor = System.Drawing.Color.White
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 62)
        Me.pnlDailyOverview.TabIndex = 42
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(210, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(325, 45)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "FAQ MANAGEMENT"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtbAnswer
        '
        Me.rtbAnswer.Location = New System.Drawing.Point(139, 141)
        Me.rtbAnswer.Name = "rtbAnswer"
        Me.rtbAnswer.Size = New System.Drawing.Size(512, 108)
        Me.rtbAnswer.TabIndex = 44
        Me.rtbAnswer.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "QUESTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(42, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "ANSWER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(140, 277)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(137, 40)
        Me.btnAdd.TabIndex = 46
        Me.btnAdd.Text = "ADD/UPDATE"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(327, 277)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(137, 40)
        Me.btnDelete.TabIndex = 48
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnToggleStatus
        '
        Me.btnToggleStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnToggleStatus.Location = New System.Drawing.Point(514, 277)
        Me.btnToggleStatus.Name = "btnToggleStatus"
        Me.btnToggleStatus.Size = New System.Drawing.Size(137, 40)
        Me.btnToggleStatus.TabIndex = 49
        Me.btnToggleStatus.Text = "HIDE / UNHIDE"
        Me.btnToggleStatus.UseVisualStyleBackColor = True
        '
        'flpFaqList
        '
        Me.flpFaqList.AutoScroll = True
        Me.flpFaqList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpFaqList.Location = New System.Drawing.Point(46, 339)
        Me.flpFaqList.Name = "flpFaqList"
        Me.flpFaqList.Size = New System.Drawing.Size(628, 210)
        Me.flpFaqList.TabIndex = 50
        Me.flpFaqList.WrapContents = False
        '
        'cmbQuestions
        '
        Me.cmbQuestions.FormattingEnabled = True
        Me.cmbQuestions.Location = New System.Drawing.Point(139, 105)
        Me.cmbQuestions.Name = "cmbQuestions"
        Me.cmbQuestions.Size = New System.Drawing.Size(512, 21)
        Me.cmbQuestions.TabIndex = 51
        '
        'faqManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.cmbQuestions)
        Me.Controls.Add(Me.flpFaqList)
        Me.Controls.Add(Me.btnToggleStatus)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtbAnswer)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "faqManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "faqManagement"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents rtbAnswer As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnToggleStatus As Button
    Friend WithEvents flpFaqList As FlowLayoutPanel
    Friend WithEvents cmbQuestions As ComboBox
End Class
