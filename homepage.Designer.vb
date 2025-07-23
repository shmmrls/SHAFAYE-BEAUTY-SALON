<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homepage))
        Me.signinbtn = New System.Windows.Forms.PictureBox()
        Me.signupbtn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.faq = New System.Windows.Forms.Label()
        Me.review = New System.Windows.Forms.Label()
        Me.bookappointment = New System.Windows.Forms.Label()
        Me.services = New System.Windows.Forms.Label()
        Me.home = New System.Windows.Forms.Label()
        Me.panelChildForm = New System.Windows.Forms.Panel()
        CType(Me.signinbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signupbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'signinbtn
        '
        Me.signinbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signinbtn.BackColor = System.Drawing.Color.Transparent
        Me.signinbtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.hompgsignin
        Me.signinbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.signinbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signinbtn.Location = New System.Drawing.Point(426, 452)
        Me.signinbtn.Name = "signinbtn"
        Me.signinbtn.Size = New System.Drawing.Size(186, 40)
        Me.signinbtn.TabIndex = 14
        Me.signinbtn.TabStop = False
        '
        'signupbtn
        '
        Me.signupbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signupbtn.BackColor = System.Drawing.Color.Transparent
        Me.signupbtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.hompgsignup
        Me.signupbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.signupbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signupbtn.Location = New System.Drawing.Point(668, 452)
        Me.signupbtn.Name = "signupbtn"
        Me.signupbtn.Size = New System.Drawing.Size(186, 40)
        Me.signupbtn.TabIndex = 15
        Me.signupbtn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(511, 527)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ARE YOU AN ADMIN/STAFF? LOGIN HERE INSTEAD."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel2.Controls.Add(Me.faq)
        Me.Panel2.Controls.Add(Me.review)
        Me.Panel2.Controls.Add(Me.bookappointment)
        Me.Panel2.Controls.Add(Me.services)
        Me.Panel2.Controls.Add(Me.home)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1280, 72)
        Me.Panel2.TabIndex = 17
        '
        'faq
        '
        Me.faq.AutoSize = True
        Me.faq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.faq.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.faq.ForeColor = System.Drawing.Color.White
        Me.faq.Location = New System.Drawing.Point(913, 25)
        Me.faq.Name = "faq"
        Me.faq.Size = New System.Drawing.Size(37, 20)
        Me.faq.TabIndex = 6
        Me.faq.Text = "FAQ"
        '
        'review
        '
        Me.review.AutoSize = True
        Me.review.Cursor = System.Windows.Forms.Cursors.Hand
        Me.review.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.review.ForeColor = System.Drawing.Color.White
        Me.review.Location = New System.Drawing.Point(793, 25)
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
        Me.bookappointment.Location = New System.Drawing.Point(585, 25)
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
        Me.services.Location = New System.Drawing.Point(462, 25)
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
        Me.home.Location = New System.Drawing.Point(359, 25)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(53, 20)
        Me.home.TabIndex = 2
        Me.home.Text = "HOME"
        '
        'panelChildForm
        '
        Me.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelChildForm.Location = New System.Drawing.Point(0, 72)
        Me.panelChildForm.Margin = New System.Windows.Forms.Padding(4)
        Me.panelChildForm.Name = "panelChildForm"
        Me.panelChildForm.Size = New System.Drawing.Size(1280, 677)
        Me.panelChildForm.TabIndex = 18
        '
        'homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 749)
        Me.Controls.Add(Me.panelChildForm)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.signupbtn)
        Me.Controls.Add(Me.signinbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "homepage"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.signinbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signupbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents signinbtn As PictureBox
    Friend WithEvents signupbtn As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents faq As Label
    Friend WithEvents review As Label
    Friend WithEvents bookappointment As Label
    Friend WithEvents services As Label
    Friend WithEvents home As Label
    Friend WithEvents panelChildForm As Panel
End Class
