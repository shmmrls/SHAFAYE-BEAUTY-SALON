<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerSupport
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lntext = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.fntext = New System.Windows.Forms.TextBox()
        Me.subjectText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.messagetxtbox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(371, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 47)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CUSTOMER SUPPORT"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1023, 83)
        Me.Panel1.TabIndex = 11
        '
        'SendButton
        '
        Me.SendButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SendButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendButton.ForeColor = System.Drawing.Color.White
        Me.SendButton.Location = New System.Drawing.Point(417, 427)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(154, 29)
        Me.SendButton.TabIndex = 122
        Me.SendButton.Text = "SUBMIT QUESTION"
        Me.SendButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(508, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "LAST NAME"
        '
        'lntext
        '
        Me.lntext.BackColor = System.Drawing.Color.White
        Me.lntext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lntext.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lntext.Location = New System.Drawing.Point(512, 175)
        Me.lntext.Name = "lntext"
        Me.lntext.Size = New System.Drawing.Size(172, 27)
        Me.lntext.TabIndex = 112
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.Color.DimGray
        Me.lblemail.Location = New System.Drawing.Point(305, 217)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(62, 23)
        Me.lblemail.TabIndex = 108
        Me.lblemail.Text = "SUBJECT"
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.ForeColor = System.Drawing.Color.DimGray
        Me.lblfullname.Location = New System.Drawing.Point(305, 137)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(77, 23)
        Me.lblfullname.TabIndex = 107
        Me.lblfullname.Text = "FIRST NAME"
        '
        'fntext
        '
        Me.fntext.BackColor = System.Drawing.Color.White
        Me.fntext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fntext.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fntext.Location = New System.Drawing.Point(309, 175)
        Me.fntext.Name = "fntext"
        Me.fntext.Size = New System.Drawing.Size(172, 27)
        Me.fntext.TabIndex = 104
        '
        'subjectText
        '
        Me.subjectText.BackColor = System.Drawing.Color.White
        Me.subjectText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.subjectText.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectText.Location = New System.Drawing.Point(307, 255)
        Me.subjectText.Name = "subjectText"
        Me.subjectText.Size = New System.Drawing.Size(375, 27)
        Me.subjectText.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(309, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 23)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "MESSAGE"
        '
        'messagetxtbox
        '
        Me.messagetxtbox.BackColor = System.Drawing.Color.White
        Me.messagetxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.messagetxtbox.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messagetxtbox.Location = New System.Drawing.Point(311, 328)
        Me.messagetxtbox.Multiline = True
        Me.messagetxtbox.Name = "messagetxtbox"
        Me.messagetxtbox.Size = New System.Drawing.Size(375, 77)
        Me.messagetxtbox.TabIndex = 123
        '
        'CustomerSupport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1023, 520)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.messagetxtbox)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lntext)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblfullname)
        Me.Controls.Add(Me.fntext)
        Me.Controls.Add(Me.subjectText)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomerSupport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "customersupport"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SendButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lntext As TextBox
    Friend WithEvents RoundedTextBox7 As RoundedTextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents lblfullname As Label
    Friend WithEvents fntext As TextBox
    Friend WithEvents subjectText As TextBox
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents RoundedTextBox6 As RoundedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents messagetxtbox As TextBox
    Friend WithEvents RoundedTextBox2 As RoundedTextBox
End Class
