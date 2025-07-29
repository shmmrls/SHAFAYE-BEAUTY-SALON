<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WalkInBookingForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSelectedServices = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.cboClient = New System.Windows.Forms.ComboBox()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.clbServices = New System.Windows.Forms.CheckedListBox()
        Me.lstSelectedServices = New System.Windows.Forms.ListBox()
        Me.btnNewClient = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblClientInfo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 83)
        Me.Panel1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(174, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 54)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ADD WALK-IN BOOKINGS"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.DimGray
        Me.lblDate.Location = New System.Drawing.Point(102, 167)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(41, 17)
        Me.lblDate.TabIndex = 122
        Me.lblDate.Text = "Date:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(103, 485)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(106, 20)
        Me.lblTotal.TabIndex = 123
        Me.lblTotal.Text = "Total: ₱0.00"
        '
        'lblSelectedServices
        '
        Me.lblSelectedServices.AutoSize = True
        Me.lblSelectedServices.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedServices.ForeColor = System.Drawing.Color.DimGray
        Me.lblSelectedServices.Location = New System.Drawing.Point(102, 385)
        Me.lblSelectedServices.Name = "lblSelectedServices"
        Me.lblSelectedServices.Size = New System.Drawing.Size(117, 17)
        Me.lblSelectedServices.TabIndex = 124
        Me.lblSelectedServices.Text = "Selected Services:"
        '
        'lblServices
        '
        Me.lblServices.AutoSize = True
        Me.lblServices.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServices.ForeColor = System.Drawing.Color.DimGray
        Me.lblServices.Location = New System.Drawing.Point(102, 273)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(102, 17)
        Me.lblServices.TabIndex = 125
        Me.lblServices.Text = "Select Services:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.DimGray
        Me.lblTime.Location = New System.Drawing.Point(102, 220)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(43, 17)
        Me.lblTime.TabIndex = 126
        Me.lblTime.Text = "Time:"
        '
        'cboClient
        '
        Me.cboClient.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClient.FormattingEnabled = True
        Me.cboClient.Location = New System.Drawing.Point(266, 127)
        Me.cboClient.Name = "cboClient"
        Me.cboClient.Size = New System.Drawing.Size(333, 25)
        Me.cboClient.TabIndex = 127
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.ForeColor = System.Drawing.Color.DimGray
        Me.lblClient.Location = New System.Drawing.Point(102, 125)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(48, 17)
        Me.lblClient.TabIndex = 128
        Me.lblClient.Text = "Client:"
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(266, 167)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(333, 25)
        Me.dtpDate.TabIndex = 129
        '
        'dtpTime
        '
        Me.dtpTime.CustomFormat = "hh:mm tt"
        Me.dtpTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.Location = New System.Drawing.Point(266, 220)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(333, 25)
        Me.dtpTime.TabIndex = 130
        '
        'clbServices
        '
        Me.clbServices.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbServices.FormattingEnabled = True
        Me.clbServices.Location = New System.Drawing.Point(266, 273)
        Me.clbServices.Name = "clbServices"
        Me.clbServices.Size = New System.Drawing.Size(333, 94)
        Me.clbServices.TabIndex = 131
        '
        'lstSelectedServices
        '
        Me.lstSelectedServices.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelectedServices.FormattingEnabled = True
        Me.lstSelectedServices.ItemHeight = 17
        Me.lstSelectedServices.Location = New System.Drawing.Point(266, 385)
        Me.lstSelectedServices.Name = "lstSelectedServices"
        Me.lstSelectedServices.Size = New System.Drawing.Size(333, 89)
        Me.lstSelectedServices.TabIndex = 132
        '
        'btnNewClient
        '
        Me.btnNewClient.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewClient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnNewClient.Location = New System.Drawing.Point(107, 521)
        Me.btnNewClient.Name = "btnNewClient"
        Me.btnNewClient.Size = New System.Drawing.Size(154, 28)
        Me.btnNewClient.TabIndex = 133
        Me.btnNewClient.Text = "NEW CLIENT"
        Me.btnNewClient.UseVisualStyleBackColor = True
        '
        'btnBook
        '
        Me.btnBook.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnBook.Location = New System.Drawing.Point(276, 521)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(154, 28)
        Me.btnBook.TabIndex = 134
        Me.btnBook.Text = "BOOK NOW"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(445, 521)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(154, 28)
        Me.btnCancel.TabIndex = 135
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblClientInfo
        '
        Me.lblClientInfo.AutoSize = True
        Me.lblClientInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblClientInfo.Location = New System.Drawing.Point(190, 98)
        Me.lblClientInfo.Name = "lblClientInfo"
        Me.lblClientInfo.Size = New System.Drawing.Size(457, 17)
        Me.lblClientInfo.TabIndex = 136
        Me.lblClientInfo.Text = "Note: Only registered clients in the system can book walk-in appointments."
        '
        'WalkInBookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.lblClientInfo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.btnNewClient)
        Me.Controls.Add(Me.lstSelectedServices)
        Me.Controls.Add(Me.clbServices)
        Me.Controls.Add(Me.dtpTime)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.cboClient)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblServices)
        Me.Controls.Add(Me.lblSelectedServices)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WalkInBookingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WalkInBookingForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSelectedServices As Label
    Friend WithEvents lblServices As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents cboClient As ComboBox
    Friend WithEvents lblClient As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents clbServices As CheckedListBox
    Friend WithEvents lstSelectedServices As ListBox
    Friend WithEvents btnNewClient As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblClientInfo As Label
End Class
