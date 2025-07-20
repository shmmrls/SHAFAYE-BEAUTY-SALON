<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userMenu
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
        Me.custsupp = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.profile = New System.Windows.Forms.Label()
        Me.review = New System.Windows.Forms.Label()
        Me.bookappointment = New System.Windows.Forms.Label()
        Me.services = New System.Windows.Forms.Label()
        Me.home = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelChildForm = New System.Windows.Forms.Panel()
        Me.proff = New System.Windows.Forms.Panel()
        Me.passwordPopupPanel = New System.Windows.Forms.Panel()
        Me.passwordPopupLabel = New System.Windows.Forms.Label()
        Me.showpassword = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Label()
        Me.DateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.confirmpasstext = New System.Windows.Forms.TextBox()
        Me.passtext = New System.Windows.Forms.TextBox()
        Me.phonetext = New System.Windows.Forms.TextBox()
        Me.emailtext = New System.Windows.Forms.TextBox()
        Me.untxt = New System.Windows.Forms.TextBox()
        Me.fntext = New System.Windows.Forms.TextBox()
        Me.updateprofile = New System.Windows.Forms.PictureBox()
        Me.updatepass = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelChildForm.SuspendLayout()
        Me.proff.SuspendLayout()
        Me.passwordPopupPanel.SuspendLayout()
        CType(Me.updateprofile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updatepass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 40)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1095, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "TRANSACTION HISTORY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'custsupp
        '
        Me.custsupp.AutoSize = True
        Me.custsupp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.custsupp.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custsupp.ForeColor = System.Drawing.Color.White
        Me.custsupp.Location = New System.Drawing.Point(1102, 27)
        Me.custsupp.Name = "custsupp"
        Me.custsupp.Size = New System.Drawing.Size(155, 20)
        Me.custsupp.TabIndex = 1
        Me.custsupp.Text = "CUSTOMER SUPPORT"
        Me.custsupp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel2.Controls.Add(Me.custsupp)
        Me.Panel2.Controls.Add(Me.profile)
        Me.Panel2.Controls.Add(Me.review)
        Me.Panel2.Controls.Add(Me.bookappointment)
        Me.Panel2.Controls.Add(Me.services)
        Me.Panel2.Controls.Add(Me.home)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1280, 71)
        Me.Panel2.TabIndex = 1
        '
        'profile
        '
        Me.profile.AutoSize = True
        Me.profile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profile.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile.ForeColor = System.Drawing.Color.White
        Me.profile.Location = New System.Drawing.Point(1005, 27)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(65, 20)
        Me.profile.TabIndex = 6
        Me.profile.Text = "PROFILE"
        Me.profile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'review
        '
        Me.review.AutoSize = True
        Me.review.Cursor = System.Windows.Forms.Cursors.Hand
        Me.review.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.review.ForeColor = System.Drawing.Color.White
        Me.review.Location = New System.Drawing.Point(895, 27)
        Me.review.Name = "review"
        Me.review.Size = New System.Drawing.Size(70, 20)
        Me.review.TabIndex = 5
        Me.review.Text = "REVIEWS"
        '
        'bookappointment
        '
        Me.bookappointment.AutoSize = True
        Me.bookappointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bookappointment.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookappointment.ForeColor = System.Drawing.Color.White
        Me.bookappointment.Location = New System.Drawing.Point(687, 27)
        Me.bookappointment.Name = "bookappointment"
        Me.bookappointment.Size = New System.Drawing.Size(158, 20)
        Me.bookappointment.TabIndex = 4
        Me.bookappointment.Text = "BOOK APPOINTMENT"
        '
        'services
        '
        Me.services.AutoSize = True
        Me.services.Cursor = System.Windows.Forms.Cursors.Hand
        Me.services.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.services.ForeColor = System.Drawing.Color.White
        Me.services.Location = New System.Drawing.Point(564, 27)
        Me.services.Name = "services"
        Me.services.Size = New System.Drawing.Size(73, 20)
        Me.services.TabIndex = 3
        Me.services.Text = "SERVICES"
        '
        'home
        '
        Me.home.AutoSize = True
        Me.home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.home.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home.ForeColor = System.Drawing.Color.White
        Me.home.Location = New System.Drawing.Point(461, 27)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(53, 20)
        Me.home.TabIndex = 2
        Me.home.Text = "HOME"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.logo_shafaye
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 71)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelChildForm
        '
        Me.panelChildForm.Controls.Add(Me.proff)
        Me.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelChildForm.Location = New System.Drawing.Point(0, 111)
        Me.panelChildForm.Margin = New System.Windows.Forms.Padding(4)
        Me.panelChildForm.Name = "panelChildForm"
        Me.panelChildForm.Size = New System.Drawing.Size(1280, 638)
        Me.panelChildForm.TabIndex = 3
        '
        'proff
        '
        Me.proff.BackColor = System.Drawing.Color.Black
        Me.proff.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.profile
        Me.proff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.proff.Controls.Add(Me.passwordPopupPanel)
        Me.proff.Controls.Add(Me.showpassword)
        Me.proff.Controls.Add(Me.clear)
        Me.proff.Controls.Add(Me.DateOfBirth)
        Me.proff.Controls.Add(Me.confirmpasstext)
        Me.proff.Controls.Add(Me.passtext)
        Me.proff.Controls.Add(Me.phonetext)
        Me.proff.Controls.Add(Me.emailtext)
        Me.proff.Controls.Add(Me.untxt)
        Me.proff.Controls.Add(Me.fntext)
        Me.proff.Controls.Add(Me.updateprofile)
        Me.proff.Controls.Add(Me.updatepass)
        Me.proff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.proff.Location = New System.Drawing.Point(0, 0)
        Me.proff.Margin = New System.Windows.Forms.Padding(4)
        Me.proff.Name = "proff"
        Me.proff.Size = New System.Drawing.Size(1280, 638)
        Me.proff.TabIndex = 5
        Me.proff.Visible = False
        '
        'passwordPopupPanel
        '
        Me.passwordPopupPanel.BackColor = System.Drawing.Color.LightGray
        Me.passwordPopupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwordPopupPanel.Controls.Add(Me.passwordPopupLabel)
        Me.passwordPopupPanel.Location = New System.Drawing.Point(191, 410)
        Me.passwordPopupPanel.Name = "passwordPopupPanel"
        Me.passwordPopupPanel.Size = New System.Drawing.Size(361, 102)
        Me.passwordPopupPanel.TabIndex = 14
        Me.passwordPopupPanel.Visible = False
        '
        'passwordPopupLabel
        '
        Me.passwordPopupLabel.AutoSize = True
        Me.passwordPopupLabel.BackColor = System.Drawing.Color.Transparent
        Me.passwordPopupLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.passwordPopupLabel.Font = New System.Drawing.Font("Poppins Light", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordPopupLabel.ForeColor = System.Drawing.Color.Black
        Me.passwordPopupLabel.Location = New System.Drawing.Point(0, 0)
        Me.passwordPopupLabel.Name = "passwordPopupLabel"
        Me.passwordPopupLabel.Size = New System.Drawing.Size(33, 16)
        Me.passwordPopupLabel.TabIndex = 11
        Me.passwordPopupLabel.Text = "Label1"
        '
        'showpassword
        '
        Me.showpassword.AutoSize = True
        Me.showpassword.BackColor = System.Drawing.Color.Transparent
        Me.showpassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showpassword.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpassword.ForeColor = System.Drawing.Color.White
        Me.showpassword.Location = New System.Drawing.Point(1155, 600)
        Me.showpassword.Name = "showpassword"
        Me.showpassword.Size = New System.Drawing.Size(102, 19)
        Me.showpassword.TabIndex = 13
        Me.showpassword.Text = "SHOW PASSWORD"
        '
        'clear
        '
        Me.clear.AutoSize = True
        Me.clear.BackColor = System.Drawing.Color.Transparent
        Me.clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.White
        Me.clear.Location = New System.Drawing.Point(22, 600)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(40, 19)
        Me.clear.TabIndex = 12
        Me.clear.Text = "CLEAR"
        '
        'DateOfBirth
        '
        Me.DateOfBirth.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.DateOfBirth.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.DateOfBirth.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.DateOfBirth.CustomFormat = "MM/dd/yyyy"
        Me.DateOfBirth.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirth.Location = New System.Drawing.Point(52, 362)
        Me.DateOfBirth.MaxDate = New Date(2025, 7, 20, 0, 0, 0, 0)
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.Size = New System.Drawing.Size(500, 25)
        Me.DateOfBirth.TabIndex = 11
        Me.DateOfBirth.Value = New Date(2025, 7, 20, 0, 0, 0, 0)
        '
        'confirmpasstext
        '
        Me.confirmpasstext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confirmpasstext.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmpasstext.Location = New System.Drawing.Point(744, 518)
        Me.confirmpasstext.Name = "confirmpasstext"
        Me.confirmpasstext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(10043)
        Me.confirmpasstext.Size = New System.Drawing.Size(421, 20)
        Me.confirmpasstext.TabIndex = 10
        '
        'passtext
        '
        Me.passtext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passtext.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtext.Location = New System.Drawing.Point(72, 518)
        Me.passtext.Name = "passtext"
        Me.passtext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(10043)
        Me.passtext.Size = New System.Drawing.Size(463, 20)
        Me.passtext.TabIndex = 9
        '
        'phonetext
        '
        Me.phonetext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.phonetext.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonetext.Location = New System.Drawing.Point(744, 270)
        Me.phonetext.Name = "phonetext"
        Me.phonetext.Size = New System.Drawing.Size(421, 20)
        Me.phonetext.TabIndex = 8
        '
        'emailtext
        '
        Me.emailtext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.emailtext.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailtext.Location = New System.Drawing.Point(72, 270)
        Me.emailtext.Name = "emailtext"
        Me.emailtext.Size = New System.Drawing.Size(463, 20)
        Me.emailtext.TabIndex = 7
        '
        'untxt
        '
        Me.untxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.untxt.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.untxt.Location = New System.Drawing.Point(744, 168)
        Me.untxt.Name = "untxt"
        Me.untxt.Size = New System.Drawing.Size(421, 20)
        Me.untxt.TabIndex = 6
        '
        'fntext
        '
        Me.fntext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fntext.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fntext.Location = New System.Drawing.Point(72, 168)
        Me.fntext.Name = "fntext"
        Me.fntext.Size = New System.Drawing.Size(463, 20)
        Me.fntext.TabIndex = 5
        '
        'updateprofile
        '
        Me.updateprofile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updateprofile.BackColor = System.Drawing.Color.Transparent
        Me.updateprofile.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.updproff
        Me.updateprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.updateprofile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateprofile.Location = New System.Drawing.Point(846, 362)
        Me.updateprofile.Name = "updateprofile"
        Me.updateprofile.Size = New System.Drawing.Size(265, 45)
        Me.updateprofile.TabIndex = 3
        Me.updateprofile.TabStop = False
        '
        'updatepass
        '
        Me.updatepass.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updatepass.BackColor = System.Drawing.Color.Transparent
        Me.updatepass.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.updpass
        Me.updatepass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.updatepass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updatepass.Location = New System.Drawing.Point(518, 576)
        Me.updatepass.Name = "updatepass"
        Me.updatepass.Size = New System.Drawing.Size(244, 43)
        Me.updatepass.TabIndex = 2
        Me.updatepass.TabStop = False
        '
        'userMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 749)
        Me.Controls.Add(Me.panelChildForm)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "userMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelChildForm.ResumeLayout(False)
        Me.proff.ResumeLayout(False)
        Me.proff.PerformLayout()
        Me.passwordPopupPanel.ResumeLayout(False)
        Me.passwordPopupPanel.PerformLayout()
        CType(Me.updateprofile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updatepass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents custsupp As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents services As Label
    Friend WithEvents home As Label
    Friend WithEvents bookappointment As Label
    Friend WithEvents profile As Label
    Friend WithEvents review As Label
    Friend WithEvents panelChildForm As Panel
    Friend WithEvents proff As Panel
    Friend WithEvents updatepass As PictureBox
    Friend WithEvents updateprofile As PictureBox
    Friend WithEvents untxt As TextBox
    Friend WithEvents fntext As TextBox
    Friend WithEvents confirmpasstext As TextBox
    Friend WithEvents passtext As TextBox
    Friend WithEvents phonetext As TextBox
    Friend WithEvents emailtext As TextBox
    Friend WithEvents DateOfBirth As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents showpassword As Label
    Friend WithEvents clear As Label
    Friend WithEvents passwordPopupPanel As Panel
    Friend WithEvents passwordPopupLabel As Label
End Class
