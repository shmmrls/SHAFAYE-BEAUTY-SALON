<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class moderateReviews
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
        Me.flpReviews = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbSortByRating = New System.Windows.Forms.ComboBox()
        Me.cmbSortByDate = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlDailyOverview.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 83)
        Me.pnlDailyOverview.TabIndex = 43
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(114, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(610, 72)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "REVIEW MODERATION"
        '
        'flpReviews
        '
        Me.flpReviews.AutoScroll = True
        Me.flpReviews.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpReviews.Location = New System.Drawing.Point(62, 197)
        Me.flpReviews.Name = "flpReviews"
        Me.flpReviews.Size = New System.Drawing.Size(586, 331)
        Me.flpReviews.TabIndex = 48
        Me.flpReviews.WrapContents = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmbSortByRating)
        Me.Panel1.Controls.Add(Me.cmbSortByDate)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 100)
        Me.Panel1.TabIndex = 51
        '
        'cmbSortByRating
        '
        Me.cmbSortByRating.FormattingEnabled = True
        Me.cmbSortByRating.Location = New System.Drawing.Point(356, 65)
        Me.cmbSortByRating.Name = "cmbSortByRating"
        Me.cmbSortByRating.Size = New System.Drawing.Size(189, 21)
        Me.cmbSortByRating.TabIndex = 55
        '
        'cmbSortByDate
        '
        Me.cmbSortByDate.FormattingEnabled = True
        Me.cmbSortByDate.Location = New System.Drawing.Point(143, 65)
        Me.cmbSortByDate.Name = "cmbSortByDate"
        Me.cmbSortByDate.Size = New System.Drawing.Size(189, 21)
        Me.cmbSortByDate.TabIndex = 54
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(436, 14)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(109, 30)
        Me.btnSearch.TabIndex = 53
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(238, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(192, 20)
        Me.txtSearch.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(139, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 21)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "KEYWORD:"
        '
        'moderateReviews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.flpReviews)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "moderateReviews"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "moderateReviews"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents flpReviews As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbSortByRating As ComboBox
    Friend WithEvents cmbSortByDate As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
End Class
