<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class signup
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
        Me.signupbtn = New System.Windows.Forms.PictureBox()
        Me.signinpage = New System.Windows.Forms.PictureBox()
        Me.lastnametxt = New System.Windows.Forms.TextBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.confirmpasstx = New System.Windows.Forms.TextBox()
        Me.clear = New System.Windows.Forms.Label()
        Me.showpassword = New System.Windows.Forms.Label()
        Me.passwordPopupPanel = New System.Windows.Forms.Panel()
        Me.passwordPopupLabel = New System.Windows.Forms.Label()
        Me.firstnametxt = New System.Windows.Forms.TextBox()
        CType(Me.signupbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signinpage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.passwordPopupPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'signupbtn
        '
        Me.signupbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signupbtn.BackColor = System.Drawing.Color.Transparent
        Me.signupbtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.signupbutton
        Me.signupbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.signupbtn.Location = New System.Drawing.Point(553, 525)
        Me.signupbtn.Name = "signupbtn"
        Me.signupbtn.Size = New System.Drawing.Size(186, 40)
        Me.signupbtn.TabIndex = 2
        Me.signupbtn.TabStop = False
        '
        'signinpage
        '
        Me.signinpage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signinpage.BackColor = System.Drawing.Color.Transparent
        Me.signinpage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signinpage.Location = New System.Drawing.Point(645, 35)
        Me.signinpage.Name = "signinpage"
        Me.signinpage.Size = New System.Drawing.Size(238, 52)
        Me.signinpage.TabIndex = 3
        Me.signinpage.TabStop = False
        '
        'lastnametxt
        '
        Me.lastnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lastnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastnametxt.Location = New System.Drawing.Point(454, 216)
        Me.lastnametxt.Name = "lastnametxt"
        Me.lastnametxt.Size = New System.Drawing.Size(421, 15)
        Me.lastnametxt.TabIndex = 4
        '
        'usernametxt
        '
        Me.usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usernametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(454, 302)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(421, 15)
        Me.usernametxt.TabIndex = 5
        '
        'passtxt
        '
        Me.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtxt.Location = New System.Drawing.Point(454, 391)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(10043)
        Me.passtxt.Size = New System.Drawing.Size(421, 15)
        Me.passtxt.TabIndex = 6
        Me.passtxt.UseSystemPasswordChar = True
        '
        'confirmpasstx
        '
        Me.confirmpasstx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confirmpasstx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmpasstx.Location = New System.Drawing.Point(454, 478)
        Me.confirmpasstx.Name = "confirmpasstx"
        Me.confirmpasstx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(10043)
        Me.confirmpasstx.Size = New System.Drawing.Size(421, 15)
        Me.confirmpasstx.TabIndex = 7
        Me.confirmpasstx.UseSystemPasswordChar = True
        '
        'clear
        '
        Me.clear.AutoSize = True
        Me.clear.BackColor = System.Drawing.Color.Transparent
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.White
        Me.clear.Location = New System.Drawing.Point(334, 565)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(42, 13)
        Me.clear.TabIndex = 8
        Me.clear.Text = "CLEAR"
        '
        'showpassword
        '
        Me.showpassword.AutoSize = True
        Me.showpassword.BackColor = System.Drawing.Color.Transparent
        Me.showpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpassword.ForeColor = System.Drawing.Color.White
        Me.showpassword.Location = New System.Drawing.Point(834, 565)
        Me.showpassword.Name = "showpassword"
        Me.showpassword.Size = New System.Drawing.Size(107, 13)
        Me.showpassword.TabIndex = 9
        Me.showpassword.Text = "SHOW PASSWORD"
        '
        'passwordPopupPanel
        '
        Me.passwordPopupPanel.BackColor = System.Drawing.Color.LightGray
        Me.passwordPopupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwordPopupPanel.Controls.Add(Me.passwordPopupLabel)
        Me.passwordPopupPanel.Location = New System.Drawing.Point(638, 419)
        Me.passwordPopupPanel.Name = "passwordPopupPanel"
        Me.passwordPopupPanel.Size = New System.Drawing.Size(250, 100)
        Me.passwordPopupPanel.TabIndex = 10
        Me.passwordPopupPanel.Visible = False
        '
        'passwordPopupLabel
        '
        Me.passwordPopupLabel.AutoSize = True
        Me.passwordPopupLabel.BackColor = System.Drawing.Color.Transparent
        Me.passwordPopupLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.passwordPopupLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordPopupLabel.ForeColor = System.Drawing.Color.Black
        Me.passwordPopupLabel.Location = New System.Drawing.Point(0, 0)
        Me.passwordPopupLabel.Name = "passwordPopupLabel"
        Me.passwordPopupLabel.Size = New System.Drawing.Size(32, 12)
        Me.passwordPopupLabel.TabIndex = 11
        Me.passwordPopupLabel.Text = "Label1"
        '
        'firstnametxt
        '
        Me.firstnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.firstnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstnametxt.Location = New System.Drawing.Point(454, 130)
        Me.firstnametxt.Name = "firstnametxt"
        Me.firstnametxt.Size = New System.Drawing.Size(421, 15)
        Me.firstnametxt.TabIndex = 11
        '
        'signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.sign_u_final
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(948, 593)
        Me.Controls.Add(Me.firstnametxt)
        Me.Controls.Add(Me.passwordPopupPanel)
        Me.Controls.Add(Me.showpassword)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.confirmpasstx)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.lastnametxt)
        Me.Controls.Add(Me.signinpage)
        Me.Controls.Add(Me.signupbtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "signup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.signupbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signinpage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.passwordPopupPanel.ResumeLayout(False)
        Me.passwordPopupPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents signupbtn As PictureBox
    Friend WithEvents signinpage As PictureBox
    Friend WithEvents lastnametxt As TextBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents passtxt As TextBox
    Friend WithEvents confirmpasstx As TextBox
    Friend WithEvents clear As Label
    Friend WithEvents showpassword As Label
    Friend WithEvents passwordPopupPanel As Panel
    Friend WithEvents passwordPopupLabel As Label
    Friend WithEvents firstnametxt As TextBox
End Class
