<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reviews
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fororganization = New System.Windows.Forms.Panel()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.cmbSortOrder = New System.Windows.Forms.ComboBox()
        Me.lblService = New System.Windows.Forms.Label()
        Me.cmbFilterService = New System.Windows.Forms.ComboBox()
        Me.flowReviews = New System.Windows.Forms.FlowLayoutPanel()
        Me.viewReviewsbtn = New System.Windows.Forms.Button()
        Me.panelleavereview = New System.Windows.Forms.Panel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudStaffRating = New System.Windows.Forms.NumericUpDown()
        Me.lblStaffRating = New System.Windows.Forms.Label()
        Me.nudServiceRating = New System.Windows.Forms.NumericUpDown()
        Me.lblServiceRating = New System.Windows.Forms.Label()
        Me.cbAppointments = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RoundedTextBox1 = New SHAFAYE_BEAUTY_SALON.RoundedTextBox()
        Me.Panel1.SuspendLayout()
        Me.fororganization.SuspendLayout()
        Me.panelleavereview.SuspendLayout()
        CType(Me.nudStaffRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudServiceRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1023, 89)
        Me.Panel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(347, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 47)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "REVIEWS OVERVIEW"
        '
        'fororganization
        '
        Me.fororganization.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.fororganization.Controls.Add(Me.lblRating)
        Me.fororganization.Controls.Add(Me.cmbSortOrder)
        Me.fororganization.Controls.Add(Me.lblService)
        Me.fororganization.Controls.Add(Me.cmbFilterService)
        Me.fororganization.Dock = System.Windows.Forms.DockStyle.Top
        Me.fororganization.Location = New System.Drawing.Point(0, 89)
        Me.fororganization.Name = "fororganization"
        Me.fororganization.Size = New System.Drawing.Size(1023, 110)
        Me.fororganization.TabIndex = 16
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRating.ForeColor = System.Drawing.Color.White
        Me.lblRating.Location = New System.Drawing.Point(321, 60)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(94, 17)
        Me.lblRating.TabIndex = 17
        Me.lblRating.Text = "Sort by Rating:"
        Me.lblRating.Visible = False
        '
        'cmbSortOrder
        '
        Me.cmbSortOrder.FormattingEnabled = True
        Me.cmbSortOrder.Location = New System.Drawing.Point(449, 56)
        Me.cmbSortOrder.Name = "cmbSortOrder"
        Me.cmbSortOrder.Size = New System.Drawing.Size(234, 21)
        Me.cmbSortOrder.TabIndex = 16
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblService.ForeColor = System.Drawing.Color.White
        Me.lblService.Location = New System.Drawing.Point(321, 33)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(102, 17)
        Me.lblService.TabIndex = 15
        Me.lblService.Text = "Filter by Service:"
        Me.lblService.Visible = False
        '
        'cmbFilterService
        '
        Me.cmbFilterService.FormattingEnabled = True
        Me.cmbFilterService.Location = New System.Drawing.Point(449, 29)
        Me.cmbFilterService.Name = "cmbFilterService"
        Me.cmbFilterService.Size = New System.Drawing.Size(234, 21)
        Me.cmbFilterService.TabIndex = 6
        '
        'flowReviews
        '
        Me.flowReviews.AutoScroll = True
        Me.flowReviews.BackColor = System.Drawing.Color.Transparent
        Me.flowReviews.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowReviews.Location = New System.Drawing.Point(158, 228)
        Me.flowReviews.Name = "flowReviews"
        Me.flowReviews.Size = New System.Drawing.Size(650, 211)
        Me.flowReviews.TabIndex = 15
        Me.flowReviews.Visible = False
        Me.flowReviews.WrapContents = False
        '
        'viewReviewsbtn
        '
        Me.viewReviewsbtn.Location = New System.Drawing.Point(378, 479)
        Me.viewReviewsbtn.Name = "viewReviewsbtn"
        Me.viewReviewsbtn.Size = New System.Drawing.Size(207, 23)
        Me.viewReviewsbtn.TabIndex = 18
        Me.viewReviewsbtn.Text = "VIEW REVIEWS"
        Me.viewReviewsbtn.UseVisualStyleBackColor = True
        '
        'panelleavereview
        '
        Me.panelleavereview.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.panelleavereview.Controls.Add(Me.Label2)
        Me.panelleavereview.Controls.Add(Me.btnSubmit)
        Me.panelleavereview.Controls.Add(Me.txtComment)
        Me.panelleavereview.Controls.Add(Me.RoundedTextBox1)
        Me.panelleavereview.Controls.Add(Me.Label3)
        Me.panelleavereview.Controls.Add(Me.nudStaffRating)
        Me.panelleavereview.Controls.Add(Me.lblStaffRating)
        Me.panelleavereview.Controls.Add(Me.nudServiceRating)
        Me.panelleavereview.Controls.Add(Me.lblServiceRating)
        Me.panelleavereview.Controls.Add(Me.cbAppointments)
        Me.panelleavereview.Location = New System.Drawing.Point(86, 225)
        Me.panelleavereview.Name = "panelleavereview"
        Me.panelleavereview.Size = New System.Drawing.Size(809, 243)
        Me.panelleavereview.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(341, 191)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(449, 23)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtComment
        '
        Me.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtComment.Location = New System.Drawing.Point(347, 72)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(437, 86)
        Me.txtComment.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(338, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Comment:"
        '
        'nudStaffRating
        '
        Me.nudStaffRating.Location = New System.Drawing.Point(173, 133)
        Me.nudStaffRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudStaffRating.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStaffRating.Name = "nudStaffRating"
        Me.nudStaffRating.Size = New System.Drawing.Size(92, 20)
        Me.nudStaffRating.TabIndex = 21
        Me.nudStaffRating.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblStaffRating
        '
        Me.lblStaffRating.AutoSize = True
        Me.lblStaffRating.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffRating.ForeColor = System.Drawing.Color.White
        Me.lblStaffRating.Location = New System.Drawing.Point(28, 132)
        Me.lblStaffRating.Name = "lblStaffRating"
        Me.lblStaffRating.Size = New System.Drawing.Size(120, 17)
        Me.lblStaffRating.TabIndex = 20
        Me.lblStaffRating.Text = "Staff Rating (1–5):"
        '
        'nudServiceRating
        '
        Me.nudServiceRating.Location = New System.Drawing.Point(173, 96)
        Me.nudServiceRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudServiceRating.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudServiceRating.Name = "nudServiceRating"
        Me.nudServiceRating.Size = New System.Drawing.Size(92, 20)
        Me.nudServiceRating.TabIndex = 19
        Me.nudServiceRating.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblServiceRating
        '
        Me.lblServiceRating.AutoSize = True
        Me.lblServiceRating.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceRating.ForeColor = System.Drawing.Color.White
        Me.lblServiceRating.Location = New System.Drawing.Point(28, 95)
        Me.lblServiceRating.Name = "lblServiceRating"
        Me.lblServiceRating.Size = New System.Drawing.Size(133, 17)
        Me.lblServiceRating.TabIndex = 18
        Me.lblServiceRating.Text = "Service Rating (1-5):"
        '
        'cbAppointments
        '
        Me.cbAppointments.BackColor = System.Drawing.Color.White
        Me.cbAppointments.FormattingEnabled = True
        Me.cbAppointments.Location = New System.Drawing.Point(31, 59)
        Me.cbAppointments.Name = "cbAppointments"
        Me.cbAppointments.Size = New System.Drawing.Size(234, 21)
        Me.cbAppointments.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Select Completed Appointment:"
        '
        'RoundedTextBox1
        '
        Me.RoundedTextBox1.BackColor = System.Drawing.Color.White
        Me.RoundedTextBox1.BorderColor = System.Drawing.Color.DarkGray
        Me.RoundedTextBox1.BorderRadius = 25
        Me.RoundedTextBox1.BorderSize = 2
        Me.RoundedTextBox1.Location = New System.Drawing.Point(341, 59)
        Me.RoundedTextBox1.Name = "RoundedTextBox1"
        Me.RoundedTextBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.RoundedTextBox1.Size = New System.Drawing.Size(449, 107)
        Me.RoundedTextBox1.TabIndex = 23
        '
        'reviews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1023, 520)
        Me.Controls.Add(Me.viewReviewsbtn)
        Me.Controls.Add(Me.fororganization)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelleavereview)
        Me.Controls.Add(Me.flowReviews)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reviews"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reviews"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.fororganization.ResumeLayout(False)
        Me.fororganization.PerformLayout()
        Me.panelleavereview.ResumeLayout(False)
        Me.panelleavereview.PerformLayout()
        CType(Me.nudStaffRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudServiceRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents fororganization As Panel
    Friend WithEvents lblRating As Label
    Friend WithEvents cmbSortOrder As ComboBox
    Friend WithEvents lblService As Label
    Friend WithEvents cmbFilterService As ComboBox
    Friend WithEvents flowReviews As FlowLayoutPanel
    Friend WithEvents viewReviewsbtn As Button
    Friend WithEvents panelleavereview As Panel
    Friend WithEvents txtComment As TextBox
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nudStaffRating As NumericUpDown
    Friend WithEvents lblStaffRating As Label
    Friend WithEvents nudServiceRating As NumericUpDown
    Friend WithEvents lblServiceRating As Label
    Friend WithEvents cbAppointments As ComboBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label2 As Label
End Class
