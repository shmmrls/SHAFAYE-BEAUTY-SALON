<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminstafflogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminstafflogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.showpassword = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Label()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.signinbtn = New System.Windows.Forms.PictureBox()
        CType(Me.signinbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(526, 565)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "NOT AN ADMIN? GO TO CLIENT LOGIN."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'showpassword
        '
        Me.showpassword.AutoSize = True
        Me.showpassword.BackColor = System.Drawing.Color.Transparent
        Me.showpassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showpassword.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpassword.ForeColor = System.Drawing.Color.White
        Me.showpassword.Location = New System.Drawing.Point(833, 565)
        Me.showpassword.Name = "showpassword"
        Me.showpassword.Size = New System.Drawing.Size(102, 19)
        Me.showpassword.TabIndex = 18
        Me.showpassword.Text = "SHOW PASSWORD"
        '
        'clear
        '
        Me.clear.AutoSize = True
        Me.clear.BackColor = System.Drawing.Color.Transparent
        Me.clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.White
        Me.clear.Location = New System.Drawing.Point(333, 565)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(40, 19)
        Me.clear.TabIndex = 17
        Me.clear.Text = "CLEAR"
        '
        'passtxt
        '
        Me.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passtxt.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtxt.Location = New System.Drawing.Point(440, 264)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(10043)
        Me.passtxt.Size = New System.Drawing.Size(421, 20)
        Me.passtxt.TabIndex = 16
        '
        'usernametxt
        '
        Me.usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usernametxt.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(440, 170)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(421, 20)
        Me.usernametxt.TabIndex = 15
        '
        'signinbtn
        '
        Me.signinbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signinbtn.BackColor = System.Drawing.Color.Transparent
        Me.signinbtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.signinbutton
        Me.signinbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.signinbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signinbtn.Location = New System.Drawing.Point(533, 356)
        Me.signinbtn.Name = "signinbtn"
        Me.signinbtn.Size = New System.Drawing.Size(186, 40)
        Me.signinbtn.TabIndex = 13
        Me.signinbtn.TabStop = False
        '
        'adminstafflogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(948, 593)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.showpassword)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.signinbtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "adminstafflogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminstafflogin"
        Me.TopMost = True
        CType(Me.signinbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents showpassword As Label
    Friend WithEvents clear As Label
    Friend WithEvents passtxt As TextBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents signinbtn As PictureBox
End Class
