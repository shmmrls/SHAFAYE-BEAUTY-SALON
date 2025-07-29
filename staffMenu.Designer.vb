<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staffMenu
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
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.adminDashboard = New System.Windows.Forms.Button()
        Me.panelAdmin = New System.Windows.Forms.Panel()
        Me.dailyOverview = New System.Windows.Forms.Button()
        Me.appointmentManagement = New System.Windows.Forms.Button()
        Me.panelAppointment = New System.Windows.Forms.Panel()
        Me.viewAppointments = New System.Windows.Forms.Button()
        Me.services = New System.Windows.Forms.Button()
        Me.panelService = New System.Windows.Forms.Panel()
        Me.servicelist = New System.Windows.Forms.Button()
        Me.adminProfile = New System.Windows.Forms.Button()
        Me.panelAdminProf = New System.Windows.Forms.Panel()
        Me.logout = New System.Windows.Forms.Button()
        Me.panelChildForm = New System.Windows.Forms.Panel()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.panelMenu.SuspendLayout()
        Me.panelAdmin.SuspendLayout()
        Me.panelAppointment.SuspendLayout()
        Me.panelService.SuspendLayout()
        Me.panelAdminProf.SuspendLayout()
        Me.mainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.AutoScroll = True
        Me.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.panelAdminProf)
        Me.panelMenu.Controls.Add(Me.adminProfile)
        Me.panelMenu.Controls.Add(Me.panelService)
        Me.panelMenu.Controls.Add(Me.services)
        Me.panelMenu.Controls.Add(Me.panelAppointment)
        Me.panelMenu.Controls.Add(Me.appointmentManagement)
        Me.panelMenu.Controls.Add(Me.panelAdmin)
        Me.panelMenu.Controls.Add(Me.adminDashboard)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(333, 727)
        Me.panelMenu.TabIndex = 1
        '
        'panelLogo
        '
        Me.panelLogo.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.logo_shafaye
        Me.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(333, 164)
        Me.panelLogo.TabIndex = 1
        '
        'adminDashboard
        '
        Me.adminDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.adminDashboard.FlatAppearance.BorderSize = 0
        Me.adminDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminDashboard.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminDashboard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.adminDashboard.Location = New System.Drawing.Point(0, 164)
        Me.adminDashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.adminDashboard.Name = "adminDashboard"
        Me.adminDashboard.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.adminDashboard.Size = New System.Drawing.Size(333, 55)
        Me.adminDashboard.TabIndex = 1
        Me.adminDashboard.Text = "Dashboard"
        Me.adminDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.adminDashboard.UseVisualStyleBackColor = True
        '
        'panelAdmin
        '
        Me.panelAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelAdmin.Controls.Add(Me.dailyOverview)
        Me.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelAdmin.Location = New System.Drawing.Point(0, 219)
        Me.panelAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.panelAdmin.Name = "panelAdmin"
        Me.panelAdmin.Size = New System.Drawing.Size(333, 52)
        Me.panelAdmin.TabIndex = 1
        '
        'dailyOverview
        '
        Me.dailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.dailyOverview.FlatAppearance.BorderSize = 0
        Me.dailyOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dailyOverview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.dailyOverview.Margin = New System.Windows.Forms.Padding(4)
        Me.dailyOverview.Name = "dailyOverview"
        Me.dailyOverview.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.dailyOverview.Size = New System.Drawing.Size(333, 49)
        Me.dailyOverview.TabIndex = 1
        Me.dailyOverview.Text = "Daily Overview"
        Me.dailyOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dailyOverview.UseVisualStyleBackColor = True
        '
        'appointmentManagement
        '
        Me.appointmentManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.appointmentManagement.FlatAppearance.BorderSize = 0
        Me.appointmentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.appointmentManagement.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.appointmentManagement.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.appointmentManagement.Location = New System.Drawing.Point(0, 271)
        Me.appointmentManagement.Margin = New System.Windows.Forms.Padding(4)
        Me.appointmentManagement.Name = "appointmentManagement"
        Me.appointmentManagement.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.appointmentManagement.Size = New System.Drawing.Size(333, 55)
        Me.appointmentManagement.TabIndex = 3
        Me.appointmentManagement.Text = "Appointments"
        Me.appointmentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.appointmentManagement.UseVisualStyleBackColor = True
        '
        'panelAppointment
        '
        Me.panelAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelAppointment.Controls.Add(Me.viewAppointments)
        Me.panelAppointment.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelAppointment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.panelAppointment.Location = New System.Drawing.Point(0, 326)
        Me.panelAppointment.Margin = New System.Windows.Forms.Padding(4)
        Me.panelAppointment.Name = "panelAppointment"
        Me.panelAppointment.Size = New System.Drawing.Size(333, 50)
        Me.panelAppointment.TabIndex = 2
        '
        'viewAppointments
        '
        Me.viewAppointments.Dock = System.Windows.Forms.DockStyle.Top
        Me.viewAppointments.FlatAppearance.BorderSize = 0
        Me.viewAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewAppointments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.viewAppointments.Location = New System.Drawing.Point(0, 0)
        Me.viewAppointments.Margin = New System.Windows.Forms.Padding(4)
        Me.viewAppointments.Name = "viewAppointments"
        Me.viewAppointments.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.viewAppointments.Size = New System.Drawing.Size(333, 49)
        Me.viewAppointments.TabIndex = 1
        Me.viewAppointments.Text = "View All Bookings"
        Me.viewAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.viewAppointments.UseVisualStyleBackColor = True
        '
        'services
        '
        Me.services.Dock = System.Windows.Forms.DockStyle.Top
        Me.services.FlatAppearance.BorderSize = 0
        Me.services.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.services.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.services.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.services.Location = New System.Drawing.Point(0, 376)
        Me.services.Margin = New System.Windows.Forms.Padding(4)
        Me.services.Name = "services"
        Me.services.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.services.Size = New System.Drawing.Size(333, 55)
        Me.services.TabIndex = 4
        Me.services.Text = "Services"
        Me.services.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.services.UseVisualStyleBackColor = True
        '
        'panelService
        '
        Me.panelService.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelService.Controls.Add(Me.servicelist)
        Me.panelService.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelService.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.panelService.Location = New System.Drawing.Point(0, 431)
        Me.panelService.Margin = New System.Windows.Forms.Padding(4)
        Me.panelService.Name = "panelService"
        Me.panelService.Size = New System.Drawing.Size(333, 50)
        Me.panelService.TabIndex = 5
        '
        'servicelist
        '
        Me.servicelist.Dock = System.Windows.Forms.DockStyle.Top
        Me.servicelist.FlatAppearance.BorderSize = 0
        Me.servicelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.servicelist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.servicelist.Location = New System.Drawing.Point(0, 0)
        Me.servicelist.Margin = New System.Windows.Forms.Padding(4)
        Me.servicelist.Name = "servicelist"
        Me.servicelist.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.servicelist.Size = New System.Drawing.Size(333, 49)
        Me.servicelist.TabIndex = 1
        Me.servicelist.Text = "Service List"
        Me.servicelist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.servicelist.UseVisualStyleBackColor = True
        '
        'adminProfile
        '
        Me.adminProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.adminProfile.FlatAppearance.BorderSize = 0
        Me.adminProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminProfile.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.adminProfile.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.adminProfile.Location = New System.Drawing.Point(0, 481)
        Me.adminProfile.Margin = New System.Windows.Forms.Padding(4)
        Me.adminProfile.Name = "adminProfile"
        Me.adminProfile.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.adminProfile.Size = New System.Drawing.Size(333, 55)
        Me.adminProfile.TabIndex = 20
        Me.adminProfile.Text = "Profile and Settings"
        Me.adminProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.adminProfile.UseVisualStyleBackColor = True
        '
        'panelAdminProf
        '
        Me.panelAdminProf.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelAdminProf.Controls.Add(Me.logout)
        Me.panelAdminProf.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelAdminProf.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.panelAdminProf.Location = New System.Drawing.Point(0, 536)
        Me.panelAdminProf.Margin = New System.Windows.Forms.Padding(4)
        Me.panelAdminProf.Name = "panelAdminProf"
        Me.panelAdminProf.Size = New System.Drawing.Size(333, 51)
        Me.panelAdminProf.TabIndex = 21
        '
        'logout
        '
        Me.logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.logout.FlatAppearance.BorderSize = 0
        Me.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.logout.Location = New System.Drawing.Point(0, 0)
        Me.logout.Margin = New System.Windows.Forms.Padding(4)
        Me.logout.Name = "logout"
        Me.logout.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.logout.Size = New System.Drawing.Size(333, 49)
        Me.logout.TabIndex = 3
        Me.logout.Text = "Logout"
        Me.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logout.UseVisualStyleBackColor = True
        '
        'panelChildForm
        '
        Me.panelChildForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelChildForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelChildForm.Location = New System.Drawing.Point(333, 0)
        Me.panelChildForm.Margin = New System.Windows.Forms.Padding(4)
        Me.panelChildForm.Name = "panelChildForm"
        Me.panelChildForm.Size = New System.Drawing.Size(931, 727)
        Me.panelChildForm.TabIndex = 2
        '
        'mainPanel
        '
        Me.mainPanel.AutoScroll = True
        Me.mainPanel.BackColor = System.Drawing.Color.White
        Me.mainPanel.Controls.Add(Me.panelChildForm)
        Me.mainPanel.Controls.Add(Me.panelMenu)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1264, 727)
        Me.mainPanel.TabIndex = 2
        '
        'staffMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 727)
        Me.Controls.Add(Me.mainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "staffMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelMenu.ResumeLayout(False)
        Me.panelAdmin.ResumeLayout(False)
        Me.panelAppointment.ResumeLayout(False)
        Me.panelService.ResumeLayout(False)
        Me.panelAdminProf.ResumeLayout(False)
        Me.mainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelAdminProf As Panel
    Friend WithEvents logout As Button
    Friend WithEvents adminProfile As Button
    Friend WithEvents panelService As Panel
    Friend WithEvents servicelist As Button
    Friend WithEvents services As Button
    Friend WithEvents panelAppointment As Panel
    Friend WithEvents viewAppointments As Button
    Friend WithEvents appointmentManagement As Button
    Friend WithEvents panelAdmin As Panel
    Friend WithEvents dailyOverview As Button
    Friend WithEvents adminDashboard As Button
    Friend WithEvents panelLogo As Panel
    Friend WithEvents panelChildForm As Panel
    Friend WithEvents mainPanel As Panel
End Class
