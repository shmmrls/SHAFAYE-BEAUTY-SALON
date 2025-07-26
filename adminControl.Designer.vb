<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminControl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.untxt = New System.Windows.Forms.TextBox()
        Me.dgvAdmin = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lntxtedit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fntxtedit = New System.Windows.Forms.TextBox()
        Me.saveEditbtn = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnConfirmStaffPass = New System.Windows.Forms.Button()
        Me.btnConfirmAdminPass = New System.Windows.Forms.Button()
        Me.adminNewPassTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.newPassStafftxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDeleteAdmin = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saveEditbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDeleteAdmin)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.untxt)
        Me.Panel3.Controls.Add(Me.dgvAdmin)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lntxtedit)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.fntxtedit)
        Me.Panel3.Controls.Add(Me.saveEditbtn)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(10, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(662, 469)
        Me.Panel3.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(137, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "USERNAME"
        '
        'untxt
        '
        Me.untxt.BackColor = System.Drawing.Color.White
        Me.untxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.untxt.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.untxt.Location = New System.Drawing.Point(140, 231)
        Me.untxt.Name = "untxt"
        Me.untxt.Size = New System.Drawing.Size(173, 27)
        Me.untxt.TabIndex = 128
        '
        'dgvAdmin
        '
        Me.dgvAdmin.BackgroundColor = System.Drawing.Color.White
        Me.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAdmin.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAdmin.GridColor = System.Drawing.Color.LightGray
        Me.dgvAdmin.Location = New System.Drawing.Point(137, 12)
        Me.dgvAdmin.Name = "dgvAdmin"
        Me.dgvAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdmin.ShowEditingIcon = False
        Me.dgvAdmin.Size = New System.Drawing.Size(384, 113)
        Me.dgvAdmin.TabIndex = 126
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(337, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "LAST NAME"
        '
        'lntxtedit
        '
        Me.lntxtedit.BackColor = System.Drawing.Color.White
        Me.lntxtedit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lntxtedit.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lntxtedit.Location = New System.Drawing.Point(340, 166)
        Me.lntxtedit.Name = "lntxtedit"
        Me.lntxtedit.Size = New System.Drawing.Size(180, 27)
        Me.lntxtedit.TabIndex = 122
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(134, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 23)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "FIRST NAME"
        '
        'fntxtedit
        '
        Me.fntxtedit.BackColor = System.Drawing.Color.White
        Me.fntxtedit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fntxtedit.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fntxtedit.Location = New System.Drawing.Point(137, 166)
        Me.fntxtedit.Name = "fntxtedit"
        Me.fntxtedit.Size = New System.Drawing.Size(173, 27)
        Me.fntxtedit.TabIndex = 119
        '
        'saveEditbtn
        '
        Me.saveEditbtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveEditbtn.BackColor = System.Drawing.Color.Transparent
        Me.saveEditbtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.saveEdit
        Me.saveEditbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.saveEditbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveEditbtn.Location = New System.Drawing.Point(340, 226)
        Me.saveEditbtn.Name = "saveEditbtn"
        Me.saveEditbtn.Size = New System.Drawing.Size(180, 32)
        Me.saveEditbtn.TabIndex = 116
        Me.saveEditbtn.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnConfirmStaffPass)
        Me.Panel4.Controls.Add(Me.btnConfirmAdminPass)
        Me.Panel4.Controls.Add(Me.adminNewPassTxt)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.newPassStafftxt)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(1, 298)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(659, 168)
        Me.Panel4.TabIndex = 127
        '
        'btnConfirmStaffPass
        '
        Me.btnConfirmStaffPass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmStaffPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnConfirmStaffPass.Location = New System.Drawing.Point(340, 131)
        Me.btnConfirmStaffPass.Name = "btnConfirmStaffPass"
        Me.btnConfirmStaffPass.Size = New System.Drawing.Size(180, 23)
        Me.btnConfirmStaffPass.TabIndex = 131
        Me.btnConfirmStaffPass.Text = "Confirm New Password"
        Me.btnConfirmStaffPass.UseVisualStyleBackColor = True
        '
        'btnConfirmAdminPass
        '
        Me.btnConfirmAdminPass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmAdminPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnConfirmAdminPass.Location = New System.Drawing.Point(339, 47)
        Me.btnConfirmAdminPass.Name = "btnConfirmAdminPass"
        Me.btnConfirmAdminPass.Size = New System.Drawing.Size(180, 23)
        Me.btnConfirmAdminPass.TabIndex = 130
        Me.btnConfirmAdminPass.Text = "Confirm New Password"
        Me.btnConfirmAdminPass.UseVisualStyleBackColor = True
        '
        'adminNewPassTxt
        '
        Me.adminNewPassTxt.BackColor = System.Drawing.Color.White
        Me.adminNewPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminNewPassTxt.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNewPassTxt.Location = New System.Drawing.Point(138, 47)
        Me.adminNewPassTxt.Name = "adminNewPassTxt"
        Me.adminNewPassTxt.Size = New System.Drawing.Size(174, 27)
        Me.adminNewPassTxt.TabIndex = 106
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(224, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 23)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "FORCE NEW PASSWORD FOR ADMINS"
        '
        'newPassStafftxt
        '
        Me.newPassStafftxt.BackColor = System.Drawing.Color.White
        Me.newPassStafftxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.newPassStafftxt.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPassStafftxt.Location = New System.Drawing.Point(138, 131)
        Me.newPassStafftxt.Name = "newPassStafftxt"
        Me.newPassStafftxt.Size = New System.Drawing.Size(174, 27)
        Me.newPassStafftxt.TabIndex = 109
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(227, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(219, 23)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "FORCE NEW PASSWORD FOR STAFFS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 10)
        Me.Panel2.TabIndex = 97
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 64)
        Me.Panel1.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(192, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 47)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ADMIN CONTROL"
        '
        'btnDeleteAdmin
        '
        Me.btnDeleteAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnDeleteAdmin.Location = New System.Drawing.Point(245, 269)
        Me.btnDeleteAdmin.Name = "btnDeleteAdmin"
        Me.btnDeleteAdmin.Size = New System.Drawing.Size(180, 23)
        Me.btnDeleteAdmin.TabIndex = 132
        Me.btnDeleteAdmin.Text = "Delete Admin"
        Me.btnDeleteAdmin.UseVisualStyleBackColor = True
        '
        'adminControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminControl"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saveEditbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvAdmin As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lntxtedit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents fntxtedit As TextBox
    Friend WithEvents saveEditbtn As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents adminNewPassTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents newPassStafftxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents untxt As TextBox
    Friend WithEvents btnConfirmAdminPass As Button
    Friend WithEvents btnConfirmStaffPass As Button
    Friend WithEvents btnDeleteAdmin As Button
End Class
