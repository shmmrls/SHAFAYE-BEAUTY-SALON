<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bookappointment
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lntext = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.fntext = New System.Windows.Forms.TextBox()
        Me.appointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.emailtext = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbtimeslot = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.cmbServices = New System.Windows.Forms.ComboBox()
        Me.btnaddbook = New System.Windows.Forms.Button()
        Me.lstselected = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.removeservicebtn = New System.Windows.Forms.Button()
        Me.submitBooking = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.clear = New System.Windows.Forms.Label()
        CType(Me.submitBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(271, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "LAST NAME"
        '
        'lntext
        '
        Me.lntext.BackColor = System.Drawing.Color.White
        Me.lntext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lntext.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lntext.Location = New System.Drawing.Point(275, 134)
        Me.lntext.Name = "lntext"
        Me.lntext.Size = New System.Drawing.Size(183, 27)
        Me.lntext.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(517, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 23)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "APPOINTMENT DATE"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.Color.DimGray
        Me.lblemail.Location = New System.Drawing.Point(68, 176)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(43, 23)
        Me.lblemail.TabIndex = 77
        Me.lblemail.Text = "EMAIL"
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.ForeColor = System.Drawing.Color.DimGray
        Me.lblfullname.Location = New System.Drawing.Point(68, 96)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(77, 23)
        Me.lblfullname.TabIndex = 74
        Me.lblfullname.Text = "FIRST NAME"
        '
        'fntext
        '
        Me.fntext.BackColor = System.Drawing.Color.White
        Me.fntext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fntext.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fntext.Location = New System.Drawing.Point(72, 134)
        Me.fntext.Name = "fntext"
        Me.fntext.Size = New System.Drawing.Size(172, 27)
        Me.fntext.TabIndex = 68
        '
        'appointmentDate
        '
        Me.appointmentDate.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.appointmentDate.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.appointmentDate.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.appointmentDate.CustomFormat = "MM/dd/yyyy"
        Me.appointmentDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.appointmentDate.Location = New System.Drawing.Point(521, 129)
        Me.appointmentDate.MaxDate = New Date(2030, 7, 23, 0, 0, 0, 0)
        Me.appointmentDate.MinDate = New Date(1753, 1, 2, 0, 0, 0, 0)
        Me.appointmentDate.Name = "appointmentDate"
        Me.appointmentDate.Size = New System.Drawing.Size(386, 25)
        Me.appointmentDate.TabIndex = 72
        Me.appointmentDate.Value = New Date(2025, 7, 20, 0, 0, 0, 0)
        '
        'emailtext
        '
        Me.emailtext.BackColor = System.Drawing.Color.White
        Me.emailtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailtext.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailtext.Location = New System.Drawing.Point(75, 214)
        Me.emailtext.Name = "emailtext"
        Me.emailtext.Size = New System.Drawing.Size(383, 27)
        Me.emailtext.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(517, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 23)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "APPOINTMENT TIME"
        '
        'cmbtimeslot
        '
        Me.cmbtimeslot.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtimeslot.FormattingEnabled = True
        Me.cmbtimeslot.Location = New System.Drawing.Point(521, 213)
        Me.cmbtimeslot.Name = "cmbtimeslot"
        Me.cmbtimeslot.Size = New System.Drawing.Size(386, 31)
        Me.cmbtimeslot.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(68, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 23)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "SELECT SERVICE/S TO BOOK: (UP TO 3 SERVICES PER BOOKING):"
        '
        'cmbCategory
        '
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(72, 301)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(386, 25)
        Me.cmbCategory.TabIndex = 93
        Me.cmbCategory.Text = "-- SELECT SERVICE CATEGORY"
        '
        'cmbServices
        '
        Me.cmbServices.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbServices.FormattingEnabled = True
        Me.cmbServices.Location = New System.Drawing.Point(521, 301)
        Me.cmbServices.Name = "cmbServices"
        Me.cmbServices.Size = New System.Drawing.Size(386, 25)
        Me.cmbServices.TabIndex = 94
        Me.cmbServices.Text = "-- SELECT SPECIFIC SERVICE"
        '
        'btnaddbook
        '
        Me.btnaddbook.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddbook.Location = New System.Drawing.Point(753, 266)
        Me.btnaddbook.Name = "btnaddbook"
        Me.btnaddbook.Size = New System.Drawing.Size(154, 29)
        Me.btnaddbook.TabIndex = 95
        Me.btnaddbook.Text = "ADD TO BOOKING"
        Me.btnaddbook.UseVisualStyleBackColor = True
        '
        'lstselected
        '
        Me.lstselected.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstselected.FormattingEnabled = True
        Me.lstselected.ItemHeight = 17
        Me.lstselected.Location = New System.Drawing.Point(72, 380)
        Me.lstselected.Name = "lstselected"
        Me.lstselected.Size = New System.Drawing.Size(386, 72)
        Me.lstselected.TabIndex = 96
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(71, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 23)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "SERVICE/S SELECTED TO BOOK:"
        '
        'removeservicebtn
        '
        Me.removeservicebtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeservicebtn.Location = New System.Drawing.Point(72, 458)
        Me.removeservicebtn.Name = "removeservicebtn"
        Me.removeservicebtn.Size = New System.Drawing.Size(386, 29)
        Me.removeservicebtn.TabIndex = 103
        Me.removeservicebtn.Text = "REMOVE SERVICE FROM THE LIST"
        Me.removeservicebtn.UseVisualStyleBackColor = True
        '
        'submitBooking
        '
        Me.submitBooking.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.submitBooking.BackColor = System.Drawing.Color.Transparent
        Me.submitBooking.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.confirmbooking
        Me.submitBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.submitBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submitBooking.Location = New System.Drawing.Point(611, 385)
        Me.submitBooking.Name = "submitBooking"
        Me.submitBooking.Size = New System.Drawing.Size(254, 39)
        Me.submitBooking.TabIndex = 91
        Me.submitBooking.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(329, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 54)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "BOOK APPOINTMENT"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1023, 75)
        Me.Panel1.TabIndex = 66
        '
        'clear
        '
        Me.clear.AutoSize = True
        Me.clear.BackColor = System.Drawing.Color.Transparent
        Me.clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear.Font = New System.Drawing.Font("Poppins Light", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.clear.Location = New System.Drawing.Point(699, 437)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(40, 19)
        Me.clear.TabIndex = 92
        Me.clear.Text = "CLEAR"
        '
        'bookappointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1023, 520)
        Me.Controls.Add(Me.removeservicebtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstselected)
        Me.Controls.Add(Me.btnaddbook)
        Me.Controls.Add(Me.cmbServices)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.submitBooking)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbtimeslot)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lntext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblfullname)
        Me.Controls.Add(Me.fntext)
        Me.Controls.Add(Me.appointmentDate)
        Me.Controls.Add(Me.emailtext)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bookappointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        CType(Me.submitBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents lntext As TextBox
    Friend WithEvents RoundedTextBox7 As RoundedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblfullname As Label
    Friend WithEvents fntext As TextBox
    Friend WithEvents appointmentDate As DateTimePicker
    Friend WithEvents emailtext As TextBox
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents RoundedTextBox6 As RoundedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbtimeslot As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents submitBooking As PictureBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents cmbServices As ComboBox
    Friend WithEvents btnaddbook As Button
    Friend WithEvents lstselected As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents removeservicebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents clear As Label
End Class
