<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.signinbtn = New System.Windows.Forms.PictureBox()
        Me.signuppage = New System.Windows.Forms.PictureBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.showpassword = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.signinbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signuppage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'signinbtn
        '
        Me.signinbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signinbtn.BackColor = System.Drawing.Color.Transparent
        Me.signinbtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.signinbutton
        Me.signinbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.signinbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signinbtn.Location = New System.Drawing.Point(534, 451)
        Me.signinbtn.Name = "signinbtn"
        Me.signinbtn.Size = New System.Drawing.Size(186, 40)
        Me.signinbtn.TabIndex = 1
        Me.signinbtn.TabStop = False
        '
        'signuppage
        '
        Me.signuppage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signuppage.BackColor = System.Drawing.Color.Transparent
        Me.signuppage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signuppage.Location = New System.Drawing.Point(374, 33)
        Me.signuppage.Name = "signuppage"
        Me.signuppage.Size = New System.Drawing.Size(271, 52)
        Me.signuppage.TabIndex = 2
        Me.signuppage.TabStop = False
        '
        'usernametxt
        '
        Me.usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usernametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(441, 270)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(421, 15)
        Me.usernametxt.TabIndex = 3
        '
        'passtxt
        '
        Me.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtxt.Location = New System.Drawing.Point(441, 364)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(10043)
        Me.passtxt.Size = New System.Drawing.Size(421, 15)
        Me.passtxt.TabIndex = 4
        '
        'showpassword
        '
        Me.showpassword.AutoSize = True
        Me.showpassword.BackColor = System.Drawing.Color.Transparent
        Me.showpassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpassword.ForeColor = System.Drawing.Color.White
        Me.showpassword.Location = New System.Drawing.Point(834, 565)
        Me.showpassword.Name = "showpassword"
        Me.showpassword.Size = New System.Drawing.Size(107, 13)
        Me.showpassword.TabIndex = 11
        Me.showpassword.Text = "SHOW PASSWORD"
        Me.showpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clear
        '
        Me.clear.AutoSize = True
        Me.clear.BackColor = System.Drawing.Color.Transparent
        Me.clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.White
        Me.clear.Location = New System.Drawing.Point(334, 565)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(42, 13)
        Me.clear.TabIndex = 10
        Me.clear.Text = "CLEAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(502, 565)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ARE YOU AN ADMIN/STAFF? LOGIN HERE INSTEAD."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.backbutton
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.sign_in_final
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(948, 593)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.showpassword)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.signuppage)
        Me.Controls.Add(Me.signinbtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.signinbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signuppage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents signinbtn As PictureBox
    Friend WithEvents signuppage As PictureBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents passtxt As TextBox
    Friend WithEvents showpassword As Label
    Friend WithEvents clear As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
