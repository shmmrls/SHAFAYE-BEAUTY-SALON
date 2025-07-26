<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editstaff
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lntext = New System.Windows.Forms.TextBox()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.fntext = New System.Windows.Forms.TextBox()
        Me.untxt = New System.Windows.Forms.TextBox()
        Me.lblposition = New System.Windows.Forms.Label()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.lblsalary = New System.Windows.Forms.Label()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        Me.rbActive = New System.Windows.Forms.RadioButton()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbInactive = New System.Windows.Forms.RadioButton()
        Me.addstaffadmin = New System.Windows.Forms.PictureBox()
        Me.editstaffinfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPositionEdit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSalaryedit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.activeEditrdb = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.saveEditbtn = New System.Windows.Forms.PictureBox()
        Me.inactiveEditrdb = New System.Windows.Forms.RadioButton()
        Me.backtoaddtxt = New System.Windows.Forms.Label()
        Me.fntxtedit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lntxtedit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cancelEditbtn = New System.Windows.Forms.PictureBox()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.addstaffadmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.saveEditbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancelEditbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(347, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "LAST NAME"
        '
        'lntext
        '
        Me.lntext.BackColor = System.Drawing.Color.White
        Me.lntext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lntext.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lntext.Location = New System.Drawing.Point(350, 119)
        Me.lntext.Name = "lntext"
        Me.lntext.Size = New System.Drawing.Size(173, 27)
        Me.lntext.TabIndex = 78
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.DimGray
        Me.lblusername.Location = New System.Drawing.Point(144, 153)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(72, 23)
        Me.lblusername.TabIndex = 71
        Me.lblusername.Text = "USERNAME"
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.ForeColor = System.Drawing.Color.DimGray
        Me.lblfullname.Location = New System.Drawing.Point(144, 81)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(77, 23)
        Me.lblfullname.TabIndex = 70
        Me.lblfullname.Text = "FIRST NAME"
        '
        'fntext
        '
        Me.fntext.BackColor = System.Drawing.Color.White
        Me.fntext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fntext.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fntext.Location = New System.Drawing.Point(147, 119)
        Me.fntext.Name = "fntext"
        Me.fntext.Size = New System.Drawing.Size(173, 27)
        Me.fntext.TabIndex = 66
        '
        'untxt
        '
        Me.untxt.BackColor = System.Drawing.Color.White
        Me.untxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.untxt.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.untxt.Location = New System.Drawing.Point(148, 190)
        Me.untxt.Name = "untxt"
        Me.untxt.Size = New System.Drawing.Size(375, 27)
        Me.untxt.TabIndex = 67
        '
        'lblposition
        '
        Me.lblposition.AutoSize = True
        Me.lblposition.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblposition.ForeColor = System.Drawing.Color.DimGray
        Me.lblposition.Location = New System.Drawing.Point(144, 290)
        Me.lblposition.Name = "lblposition"
        Me.lblposition.Size = New System.Drawing.Size(66, 23)
        Me.lblposition.TabIndex = 82
        Me.lblposition.Text = "POSITION"
        Me.lblposition.Visible = False
        '
        'txtposition
        '
        Me.txtposition.BackColor = System.Drawing.Color.White
        Me.txtposition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtposition.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposition.Location = New System.Drawing.Point(148, 327)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(375, 27)
        Me.txtposition.TabIndex = 81
        Me.txtposition.Visible = False
        '
        'lblsalary
        '
        Me.lblsalary.AutoSize = True
        Me.lblsalary.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalary.ForeColor = System.Drawing.Color.DimGray
        Me.lblsalary.Location = New System.Drawing.Point(144, 363)
        Me.lblsalary.Name = "lblsalary"
        Me.lblsalary.Size = New System.Drawing.Size(52, 23)
        Me.lblsalary.TabIndex = 85
        Me.lblsalary.Text = "SALARY"
        Me.lblsalary.Visible = False
        '
        'txtsalary
        '
        Me.txtsalary.BackColor = System.Drawing.Color.White
        Me.txtsalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsalary.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsalary.Location = New System.Drawing.Point(148, 400)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(375, 27)
        Me.txtsalary.TabIndex = 84
        Me.txtsalary.Visible = False
        '
        'rbActive
        '
        Me.rbActive.AutoSize = True
        Me.rbActive.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbActive.Location = New System.Drawing.Point(343, 438)
        Me.rbActive.Name = "rbActive"
        Me.rbActive.Size = New System.Drawing.Size(60, 21)
        Me.rbActive.TabIndex = 87
        Me.rbActive.TabStop = True
        Me.rbActive.Text = "Active"
        Me.rbActive.UseVisualStyleBackColor = True
        Me.rbActive.Visible = False
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.DimGray
        Me.lblstatus.Location = New System.Drawing.Point(190, 439)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(93, 23)
        Me.lblstatus.TabIndex = 89
        Me.lblstatus.Text = "STAFF STATUS:"
        Me.lblstatus.Visible = False
        '
        'cmbRole
        '
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(148, 253)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(375, 21)
        Me.cmbRole.TabIndex = 90
        Me.cmbRole.Text = "-- PLEASE SELECT A ROLE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(144, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 23)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "ROLE"
        '
        'rbInactive
        '
        Me.rbInactive.AutoSize = True
        Me.rbInactive.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbInactive.Location = New System.Drawing.Point(418, 438)
        Me.rbInactive.Name = "rbInactive"
        Me.rbInactive.Size = New System.Drawing.Size(69, 21)
        Me.rbInactive.TabIndex = 93
        Me.rbInactive.TabStop = True
        Me.rbInactive.Text = "Inactive"
        Me.rbInactive.UseVisualStyleBackColor = True
        Me.rbInactive.Visible = False
        '
        'addstaffadmin
        '
        Me.addstaffadmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addstaffadmin.BackColor = System.Drawing.Color.Transparent
        Me.addstaffadmin.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.addadminstaff
        Me.addstaffadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.addstaffadmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addstaffadmin.Location = New System.Drawing.Point(240, 475)
        Me.addstaffadmin.Name = "addstaffadmin"
        Me.addstaffadmin.Size = New System.Drawing.Size(205, 40)
        Me.addstaffadmin.TabIndex = 92
        Me.addstaffadmin.TabStop = False
        '
        'editstaffinfo
        '
        Me.editstaffinfo.AutoSize = True
        Me.editstaffinfo.BackColor = System.Drawing.Color.Transparent
        Me.editstaffinfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editstaffinfo.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editstaffinfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.editstaffinfo.Location = New System.Drawing.Point(278, 523)
        Me.editstaffinfo.Name = "editstaffinfo"
        Me.editstaffinfo.Size = New System.Drawing.Size(180, 23)
        Me.editstaffinfo.TabIndex = 96
        Me.editstaffinfo.Text = "EDIT STAFF INFO? CLICK HERE." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(192, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 47)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "MANAGE ADMIN/STAFF"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 64)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 10)
        Me.Panel2.TabIndex = 2
        '
        'txtPositionEdit
        '
        Me.txtPositionEdit.BackColor = System.Drawing.Color.White
        Me.txtPositionEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPositionEdit.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPositionEdit.Location = New System.Drawing.Point(138, 255)
        Me.txtPositionEdit.Name = "txtPositionEdit"
        Me.txtPositionEdit.Size = New System.Drawing.Size(375, 27)
        Me.txtPositionEdit.TabIndex = 106
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(134, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 23)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "POSITION"
        '
        'txtSalaryedit
        '
        Me.txtSalaryedit.BackColor = System.Drawing.Color.White
        Me.txtSalaryedit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalaryedit.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalaryedit.Location = New System.Drawing.Point(138, 334)
        Me.txtSalaryedit.Name = "txtSalaryedit"
        Me.txtSalaryedit.Size = New System.Drawing.Size(375, 27)
        Me.txtSalaryedit.TabIndex = 109
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(136, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 23)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "SALARY"
        '
        'activeEditrdb
        '
        Me.activeEditrdb.AutoSize = True
        Me.activeEditrdb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activeEditrdb.Location = New System.Drawing.Point(333, 371)
        Me.activeEditrdb.Name = "activeEditrdb"
        Me.activeEditrdb.Size = New System.Drawing.Size(60, 21)
        Me.activeEditrdb.TabIndex = 112
        Me.activeEditrdb.TabStop = True
        Me.activeEditrdb.Text = "Active"
        Me.activeEditrdb.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(180, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 23)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "STAFF STATUS:"
        '
        'saveEditbtn
        '
        Me.saveEditbtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveEditbtn.BackColor = System.Drawing.Color.Transparent
        Me.saveEditbtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.saveEdit
        Me.saveEditbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.saveEditbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveEditbtn.Location = New System.Drawing.Point(343, 403)
        Me.saveEditbtn.Name = "saveEditbtn"
        Me.saveEditbtn.Size = New System.Drawing.Size(180, 32)
        Me.saveEditbtn.TabIndex = 116
        Me.saveEditbtn.TabStop = False
        '
        'inactiveEditrdb
        '
        Me.inactiveEditrdb.AutoSize = True
        Me.inactiveEditrdb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inactiveEditrdb.Location = New System.Drawing.Point(408, 371)
        Me.inactiveEditrdb.Name = "inactiveEditrdb"
        Me.inactiveEditrdb.Size = New System.Drawing.Size(69, 21)
        Me.inactiveEditrdb.TabIndex = 117
        Me.inactiveEditrdb.TabStop = True
        Me.inactiveEditrdb.Text = "Inactive"
        Me.inactiveEditrdb.UseVisualStyleBackColor = True
        '
        'backtoaddtxt
        '
        Me.backtoaddtxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.backtoaddtxt.AutoSize = True
        Me.backtoaddtxt.BackColor = System.Drawing.Color.Transparent
        Me.backtoaddtxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backtoaddtxt.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backtoaddtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.backtoaddtxt.Location = New System.Drawing.Point(258, 446)
        Me.backtoaddtxt.Name = "backtoaddtxt"
        Me.backtoaddtxt.Size = New System.Drawing.Size(195, 23)
        Me.backtoaddtxt.TabIndex = 118
        Me.backtoaddtxt.Text = "ADD STAFF/ADMIN? CLICK HERE." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'fntxtedit
        '
        Me.fntxtedit.BackColor = System.Drawing.Color.White
        Me.fntxtedit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fntxtedit.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fntxtedit.Location = New System.Drawing.Point(137, 172)
        Me.fntxtedit.Name = "fntxtedit"
        Me.fntxtedit.Size = New System.Drawing.Size(173, 27)
        Me.fntxtedit.TabIndex = 119
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(134, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 23)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "FIRST NAME"
        '
        'lntxtedit
        '
        Me.lntxtedit.BackColor = System.Drawing.Color.White
        Me.lntxtedit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lntxtedit.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lntxtedit.Location = New System.Drawing.Point(340, 172)
        Me.lntxtedit.Name = "lntxtedit"
        Me.lntxtedit.Size = New System.Drawing.Size(173, 27)
        Me.lntxtedit.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(337, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "LAST NAME"
        '
        'cancelEditbtn
        '
        Me.cancelEditbtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelEditbtn.BackColor = System.Drawing.Color.Transparent
        Me.cancelEditbtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.cancelEdit
        Me.cancelEditbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cancelEditbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelEditbtn.Location = New System.Drawing.Point(137, 403)
        Me.cancelEditbtn.Name = "cancelEditbtn"
        Me.cancelEditbtn.Size = New System.Drawing.Size(184, 32)
        Me.cancelEditbtn.TabIndex = 125
        Me.cancelEditbtn.TabStop = False
        '
        'dgvStaff
        '
        Me.dgvStaff.BackgroundColor = System.Drawing.Color.White
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStaff.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStaff.GridColor = System.Drawing.Color.LightGray
        Me.dgvStaff.Location = New System.Drawing.Point(64, 12)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStaff.ShowEditingIcon = False
        Me.dgvStaff.Size = New System.Drawing.Size(556, 113)
        Me.dgvStaff.TabIndex = 126
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvStaff)
        Me.Panel3.Controls.Add(Me.cancelEditbtn)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lntxtedit)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.fntxtedit)
        Me.Panel3.Controls.Add(Me.backtoaddtxt)
        Me.Panel3.Controls.Add(Me.inactiveEditrdb)
        Me.Panel3.Controls.Add(Me.saveEditbtn)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.activeEditrdb)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtSalaryedit)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtPositionEdit)
        Me.Panel3.Location = New System.Drawing.Point(10, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(662, 469)
        Me.Panel3.TabIndex = 95
        Me.Panel3.Visible = False
        '
        'editstaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.editstaffinfo)
        Me.Controls.Add(Me.rbInactive)
        Me.Controls.Add(Me.addstaffadmin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.rbActive)
        Me.Controls.Add(Me.lblsalary)
        Me.Controls.Add(Me.txtsalary)
        Me.Controls.Add(Me.lblposition)
        Me.Controls.Add(Me.txtposition)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lntext)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.lblfullname)
        Me.Controls.Add(Me.fntext)
        Me.Controls.Add(Me.untxt)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editstaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editstaff"
        CType(Me.addstaffadmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.saveEditbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cancelEditbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents lntext As TextBox
    Friend WithEvents RoundedTextBox7 As RoundedTextBox
    Friend WithEvents lblusername As Label
    Friend WithEvents lblfullname As Label
    Friend WithEvents fntext As TextBox
    Friend WithEvents untxt As TextBox
    Friend WithEvents RoundedTextBox6 As RoundedTextBox
    Friend WithEvents RoundedTextBox2 As RoundedTextBox
    Friend WithEvents lblposition As Label
    Friend WithEvents txtposition As TextBox
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents lblsalary As Label
    Friend WithEvents txtsalary As TextBox
    Friend WithEvents RoundedTextBox3 As RoundedTextBox
    Friend WithEvents rbActive As RadioButton
    Friend WithEvents lblstatus As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents addstaffadmin As PictureBox
    Friend WithEvents rbInactive As RadioButton
    Friend WithEvents editstaffinfo As Label
    Friend WithEvents RoundedTextBox4 As RoundedTextBox
    Friend WithEvents RoundedTextBox5 As RoundedTextBox
    Friend WithEvents RoundedTextBox10 As RoundedTextBox
    Friend WithEvents RoundedTextBox11 As RoundedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPositionEdit As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSalaryedit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents activeEditrdb As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents saveEditbtn As PictureBox
    Friend WithEvents inactiveEditrdb As RadioButton
    Friend WithEvents backtoaddtxt As Label
    Friend WithEvents fntxtedit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lntxtedit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cancelEditbtn As PictureBox
    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents Panel3 As Panel
End Class
