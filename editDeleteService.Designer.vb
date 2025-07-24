<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editDeleteService
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
        Me.flowServices = New System.Windows.Forms.FlowLayoutPanel()
        Me.fororganization = New System.Windows.Forms.Panel()
        Me.chkAvailableOnly = New System.Windows.Forms.CheckBox()
        Me.cmbSortBy = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbCategoryFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelforedit = New System.Windows.Forms.Panel()
        Me.categorycbobox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pricetxt = New System.Windows.Forms.TextBox()
        Me.RoundedTextBox10 = New SHAFAYE_BEAUTY_SALON.RoundedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nmetxt = New System.Windows.Forms.TextBox()
        Me.RoundedTextBox11 = New SHAFAYE_BEAUTY_SALON.RoundedTextBox()
        Me.notAvailableRadbtn = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.availableRadBtn = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.descriptiontxt = New System.Windows.Forms.TextBox()
        Me.RoundedTextBox5 = New SHAFAYE_BEAUTY_SALON.RoundedTextBox()
        Me.backtoaddtxt = New System.Windows.Forms.Label()
        Me.saveditbtn = New System.Windows.Forms.PictureBox()
        Me.canceleditbtn = New System.Windows.Forms.PictureBox()
        Me.editservicebtn = New System.Windows.Forms.PictureBox()
        Me.removeservicebtn = New System.Windows.Forms.PictureBox()
        Me.fororganization.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelforedit.SuspendLayout()
        CType(Me.saveditbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.canceleditbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editservicebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.removeservicebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flowServices
        '
        Me.flowServices.AutoScroll = True
        Me.flowServices.BackColor = System.Drawing.Color.Transparent
        Me.flowServices.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowServices.Location = New System.Drawing.Point(32, 165)
        Me.flowServices.Name = "flowServices"
        Me.flowServices.Size = New System.Drawing.Size(625, 297)
        Me.flowServices.TabIndex = 12
        Me.flowServices.WrapContents = False
        '
        'fororganization
        '
        Me.fororganization.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.fororganization.Controls.Add(Me.chkAvailableOnly)
        Me.fororganization.Controls.Add(Me.cmbSortBy)
        Me.fororganization.Controls.Add(Me.btnSearch)
        Me.fororganization.Controls.Add(Me.txtSearch)
        Me.fororganization.Controls.Add(Me.cmbCategoryFilter)
        Me.fororganization.Dock = System.Windows.Forms.DockStyle.Top
        Me.fororganization.Location = New System.Drawing.Point(0, 83)
        Me.fororganization.Name = "fororganization"
        Me.fororganization.Size = New System.Drawing.Size(684, 67)
        Me.fororganization.TabIndex = 13
        '
        'chkAvailableOnly
        '
        Me.chkAvailableOnly.AutoSize = True
        Me.chkAvailableOnly.ForeColor = System.Drawing.Color.White
        Me.chkAvailableOnly.Location = New System.Drawing.Point(12, 26)
        Me.chkAvailableOnly.Name = "chkAvailableOnly"
        Me.chkAvailableOnly.Size = New System.Drawing.Size(123, 17)
        Me.chkAvailableOnly.TabIndex = 10
        Me.chkAvailableOnly.Text = "Show Available Only"
        Me.chkAvailableOnly.UseVisualStyleBackColor = True
        '
        'cmbSortBy
        '
        Me.cmbSortBy.FormattingEnabled = True
        Me.cmbSortBy.Location = New System.Drawing.Point(268, 22)
        Me.cmbSortBy.Name = "cmbSortBy"
        Me.cmbSortBy.Size = New System.Drawing.Size(121, 21)
        Me.cmbSortBy.TabIndex = 9
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(597, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(411, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(180, 20)
        Me.txtSearch.TabIndex = 7
        '
        'cmbCategoryFilter
        '
        Me.cmbCategoryFilter.FormattingEnabled = True
        Me.cmbCategoryFilter.Location = New System.Drawing.Point(141, 22)
        Me.cmbCategoryFilter.Name = "cmbCategoryFilter"
        Me.cmbCategoryFilter.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategoryFilter.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(220, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 65)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "EDIT SERVICES"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 83)
        Me.Panel1.TabIndex = 14
        '
        'panelforedit
        '
        Me.panelforedit.Controls.Add(Me.categorycbobox)
        Me.panelforedit.Controls.Add(Me.Label3)
        Me.panelforedit.Controls.Add(Me.Label2)
        Me.panelforedit.Controls.Add(Me.pricetxt)
        Me.panelforedit.Controls.Add(Me.RoundedTextBox10)
        Me.panelforedit.Controls.Add(Me.Label10)
        Me.panelforedit.Controls.Add(Me.nmetxt)
        Me.panelforedit.Controls.Add(Me.RoundedTextBox11)
        Me.panelforedit.Controls.Add(Me.notAvailableRadbtn)
        Me.panelforedit.Controls.Add(Me.Label4)
        Me.panelforedit.Controls.Add(Me.availableRadBtn)
        Me.panelforedit.Controls.Add(Me.Label8)
        Me.panelforedit.Controls.Add(Me.descriptiontxt)
        Me.panelforedit.Controls.Add(Me.RoundedTextBox5)
        Me.panelforedit.Controls.Add(Me.saveditbtn)
        Me.panelforedit.Controls.Add(Me.canceleditbtn)
        Me.panelforedit.Controls.Add(Me.backtoaddtxt)
        Me.panelforedit.Location = New System.Drawing.Point(12, 165)
        Me.panelforedit.Name = "panelforedit"
        Me.panelforedit.Size = New System.Drawing.Size(660, 384)
        Me.panelforedit.TabIndex = 94
        Me.panelforedit.Visible = False
        '
        'categorycbobox
        '
        Me.categorycbobox.FormattingEnabled = True
        Me.categorycbobox.Location = New System.Drawing.Point(348, 56)
        Me.categorycbobox.Name = "categorycbobox"
        Me.categorycbobox.Size = New System.Drawing.Size(184, 21)
        Me.categorycbobox.TabIndex = 144
        Me.categorycbobox.Text = "-- SELECT A CATEGORY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(344, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 23)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "CATEGORY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(142, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 23)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "PRICE"
        '
        'pricetxt
        '
        Me.pricetxt.BackColor = System.Drawing.Color.White
        Me.pricetxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pricetxt.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricetxt.Location = New System.Drawing.Point(159, 142)
        Me.pricetxt.Name = "pricetxt"
        Me.pricetxt.Size = New System.Drawing.Size(362, 20)
        Me.pricetxt.TabIndex = 139
        '
        'RoundedTextBox10
        '
        Me.RoundedTextBox10.BorderColor = System.Drawing.Color.DarkGray
        Me.RoundedTextBox10.BorderRadius = 25
        Me.RoundedTextBox10.BorderSize = 2
        Me.RoundedTextBox10.Location = New System.Drawing.Point(146, 130)
        Me.RoundedTextBox10.Name = "RoundedTextBox10"
        Me.RoundedTextBox10.Padding = New System.Windows.Forms.Padding(5)
        Me.RoundedTextBox10.Size = New System.Drawing.Size(386, 38)
        Me.RoundedTextBox10.TabIndex = 140
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(142, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 23)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "NAME"
        '
        'nmetxt
        '
        Me.nmetxt.BackColor = System.Drawing.Color.White
        Me.nmetxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nmetxt.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmetxt.Location = New System.Drawing.Point(159, 59)
        Me.nmetxt.Name = "nmetxt"
        Me.nmetxt.Size = New System.Drawing.Size(159, 20)
        Me.nmetxt.TabIndex = 136
        '
        'RoundedTextBox11
        '
        Me.RoundedTextBox11.BorderColor = System.Drawing.Color.DarkGray
        Me.RoundedTextBox11.BorderRadius = 25
        Me.RoundedTextBox11.BorderSize = 2
        Me.RoundedTextBox11.Location = New System.Drawing.Point(146, 47)
        Me.RoundedTextBox11.Name = "RoundedTextBox11"
        Me.RoundedTextBox11.Padding = New System.Windows.Forms.Padding(5)
        Me.RoundedTextBox11.Size = New System.Drawing.Size(183, 38)
        Me.RoundedTextBox11.TabIndex = 138
        '
        'notAvailableRadbtn
        '
        Me.notAvailableRadbtn.AutoSize = True
        Me.notAvailableRadbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notAvailableRadbtn.Location = New System.Drawing.Point(399, 266)
        Me.notAvailableRadbtn.Name = "notAvailableRadbtn"
        Me.notAvailableRadbtn.Size = New System.Drawing.Size(104, 21)
        Me.notAvailableRadbtn.TabIndex = 135
        Me.notAvailableRadbtn.TabStop = True
        Me.notAvailableRadbtn.Text = "Not Available"
        Me.notAvailableRadbtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(171, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 23)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "IS AVAILABLE?"
        '
        'availableRadBtn
        '
        Me.availableRadBtn.AutoSize = True
        Me.availableRadBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.availableRadBtn.Location = New System.Drawing.Point(310, 266)
        Me.availableRadBtn.Name = "availableRadBtn"
        Me.availableRadBtn.Size = New System.Drawing.Size(78, 21)
        Me.availableRadBtn.TabIndex = 133
        Me.availableRadBtn.TabStop = True
        Me.availableRadBtn.Text = "Available"
        Me.availableRadBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(142, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 23)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "DESCRIPTION"
        '
        'descriptiontxt
        '
        Me.descriptiontxt.BackColor = System.Drawing.Color.White
        Me.descriptiontxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.descriptiontxt.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptiontxt.Location = New System.Drawing.Point(155, 220)
        Me.descriptiontxt.Name = "descriptiontxt"
        Me.descriptiontxt.Size = New System.Drawing.Size(366, 20)
        Me.descriptiontxt.TabIndex = 130
        '
        'RoundedTextBox5
        '
        Me.RoundedTextBox5.BorderColor = System.Drawing.Color.DarkGray
        Me.RoundedTextBox5.BorderRadius = 25
        Me.RoundedTextBox5.BorderSize = 2
        Me.RoundedTextBox5.Location = New System.Drawing.Point(145, 210)
        Me.RoundedTextBox5.Name = "RoundedTextBox5"
        Me.RoundedTextBox5.Padding = New System.Windows.Forms.Padding(5)
        Me.RoundedTextBox5.Size = New System.Drawing.Size(386, 38)
        Me.RoundedTextBox5.TabIndex = 132
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
        Me.backtoaddtxt.Location = New System.Drawing.Point(259, 358)
        Me.backtoaddtxt.Name = "backtoaddtxt"
        Me.backtoaddtxt.Size = New System.Drawing.Size(171, 23)
        Me.backtoaddtxt.TabIndex = 127
        Me.backtoaddtxt.Text = "ADD SERVICES? CLICK HERE." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'saveditbtn
        '
        Me.saveditbtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveditbtn.BackColor = System.Drawing.Color.Transparent
        Me.saveditbtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.saveEdit
        Me.saveditbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.saveditbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveditbtn.Location = New System.Drawing.Point(362, 315)
        Me.saveditbtn.Name = "saveditbtn"
        Me.saveditbtn.Size = New System.Drawing.Size(205, 40)
        Me.saveditbtn.TabIndex = 129
        Me.saveditbtn.TabStop = False
        '
        'canceleditbtn
        '
        Me.canceleditbtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.canceleditbtn.BackColor = System.Drawing.Color.Transparent
        Me.canceleditbtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.cancelEdit
        Me.canceleditbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.canceleditbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.canceleditbtn.Location = New System.Drawing.Point(75, 315)
        Me.canceleditbtn.Name = "canceleditbtn"
        Me.canceleditbtn.Size = New System.Drawing.Size(205, 40)
        Me.canceleditbtn.TabIndex = 128
        Me.canceleditbtn.TabStop = False
        '
        'editservicebtn
        '
        Me.editservicebtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editservicebtn.BackColor = System.Drawing.Color.Transparent
        Me.editservicebtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.editservice
        Me.editservicebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.editservicebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editservicebtn.Location = New System.Drawing.Point(374, 480)
        Me.editservicebtn.Name = "editservicebtn"
        Me.editservicebtn.Size = New System.Drawing.Size(205, 40)
        Me.editservicebtn.TabIndex = 93
        Me.editservicebtn.TabStop = False
        '
        'removeservicebtn
        '
        Me.removeservicebtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeservicebtn.BackColor = System.Drawing.Color.Transparent
        Me.removeservicebtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.removeservice
        Me.removeservicebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.removeservicebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.removeservicebtn.Location = New System.Drawing.Point(87, 480)
        Me.removeservicebtn.Name = "removeservicebtn"
        Me.removeservicebtn.Size = New System.Drawing.Size(205, 40)
        Me.removeservicebtn.TabIndex = 92
        Me.removeservicebtn.TabStop = False
        '
        'editDeleteService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.panelforedit)
        Me.Controls.Add(Me.editservicebtn)
        Me.Controls.Add(Me.removeservicebtn)
        Me.Controls.Add(Me.flowServices)
        Me.Controls.Add(Me.fororganization)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editDeleteService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editDeleteService"
        Me.fororganization.ResumeLayout(False)
        Me.fororganization.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelforedit.ResumeLayout(False)
        Me.panelforedit.PerformLayout()
        CType(Me.saveditbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.canceleditbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editservicebtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.removeservicebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flowServices As FlowLayoutPanel
    Friend WithEvents fororganization As Panel
    Friend WithEvents chkAvailableOnly As CheckBox
    Friend WithEvents cmbSortBy As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbCategoryFilter As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents removeservicebtn As PictureBox
    Friend WithEvents editservicebtn As PictureBox
    Friend WithEvents panelforedit As Panel
    Friend WithEvents saveditbtn As PictureBox
    Friend WithEvents canceleditbtn As PictureBox
    Friend WithEvents backtoaddtxt As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pricetxt As TextBox
    Friend WithEvents RoundedTextBox10 As RoundedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents nmetxt As TextBox
    Friend WithEvents RoundedTextBox11 As RoundedTextBox
    Friend WithEvents notAvailableRadbtn As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents availableRadBtn As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents descriptiontxt As TextBox
    Friend WithEvents RoundedTextBox5 As RoundedTextBox
    Friend WithEvents categorycbobox As ComboBox
    Friend WithEvents Label3 As Label
End Class
