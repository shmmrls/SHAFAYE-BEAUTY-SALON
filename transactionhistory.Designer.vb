<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactionhistory
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
        Me.fororganization = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmborderby = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.flowAppointments = New System.Windows.Forms.FlowLayoutPanel()
        Me.cancelAppointmentbtn = New System.Windows.Forms.Button()
        Me.fororganization.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fororganization
        '
        Me.fororganization.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.fororganization.Controls.Add(Me.Label6)
        Me.fororganization.Controls.Add(Me.cmborderby)
        Me.fororganization.Controls.Add(Me.Label2)
        Me.fororganization.Controls.Add(Me.cmbStatus)
        Me.fororganization.Dock = System.Windows.Forms.DockStyle.Top
        Me.fororganization.Location = New System.Drawing.Point(0, 83)
        Me.fororganization.Name = "fororganization"
        Me.fororganization.Size = New System.Drawing.Size(1023, 67)
        Me.fororganization.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(598, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "ORDER BY"
        '
        'cmborderby
        '
        Me.cmborderby.FormattingEnabled = True
        Me.cmborderby.Location = New System.Drawing.Point(601, 33)
        Me.cmborderby.Name = "cmborderby"
        Me.cmborderby.Size = New System.Drawing.Size(108, 21)
        Me.cmborderby.TabIndex = 23
        Me.cmborderby.Text = "ORDER BY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(286, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "FILTER BY STATUS"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(288, 33)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(128, 21)
        Me.cmbStatus.TabIndex = 20
        Me.cmbStatus.Text = "FILTER BY STATUS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(330, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 47)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "TRANSACTION HISTORY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'flowAppointments
        '
        Me.flowAppointments.AutoScroll = True
        Me.flowAppointments.BackColor = System.Drawing.Color.White
        Me.flowAppointments.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowAppointments.Location = New System.Drawing.Point(199, 172)
        Me.flowAppointments.Name = "flowAppointments"
        Me.flowAppointments.Size = New System.Drawing.Size(625, 261)
        Me.flowAppointments.TabIndex = 13
        Me.flowAppointments.WrapContents = False
        '
        'cancelAppointmentbtn
        '
        Me.cancelAppointmentbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelAppointmentbtn.Location = New System.Drawing.Point(438, 457)
        Me.cancelAppointmentbtn.Name = "cancelAppointmentbtn"
        Me.cancelAppointmentbtn.Size = New System.Drawing.Size(143, 23)
        Me.cancelAppointmentbtn.TabIndex = 14
        Me.cancelAppointmentbtn.Text = "Cancel Appointment"
        Me.cancelAppointmentbtn.UseVisualStyleBackColor = True
        '
        'transactionhistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1023, 520)
        Me.Controls.Add(Me.cancelAppointmentbtn)
        Me.Controls.Add(Me.flowAppointments)
        Me.Controls.Add(Me.fororganization)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "transactionhistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "transactionhistory"
        Me.fororganization.ResumeLayout(False)
        Me.fororganization.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fororganization As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents cmborderby As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents flowAppointments As FlowLayoutPanel
    Friend WithEvents cancelAppointmentbtn As Button
End Class
