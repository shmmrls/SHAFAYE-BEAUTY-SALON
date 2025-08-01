Public Class staffMenu
    Sub customizeDesign()
        panelAdmin.Visible = False
        panelAdminProf.Visible = False
        panelAppointment.Visible = False


    End Sub

    Sub hideSubmenu()
        If (panelAdmin.Visible = True) Then
            panelAdmin.Visible = False
        End If
        If (panelAdminProf.Visible = True) Then
            panelAdminProf.Visible = False
        End If
        If (panelAppointment.Visible = True) Then
            panelAppointment.Visible = False
        End If
        If (panelService.Visible = True) Then
            panelService.Visible = False
        End If
    End Sub


    Sub showSubmenu(ByVal submenu As Panel)
        If (submenu.Visible = False) Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub


    Private someForm As Form = Nothing
    Public Sub OpenChildForm(childForm As Form)
        If someForm IsNot Nothing Then
            someForm.Close()
        End If

        someForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelChildForm.Controls.Add(childForm)
        panelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub adminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ""
        dailyOverview.PerformClick()
        customizeDesign()
        hideSubmenu()
    End Sub

    Private Sub adminDashboard_Click(sender As Object, e As EventArgs) Handles adminDashboard.Click
        showSubmenu(panelAdmin)
    End Sub

    Private Sub dailyOverview_Click(sender As Object, e As EventArgs) Handles dailyOverview.Click
        OpenChildForm(New dailyoverview())
        hideSubmenu()
    End Sub

    Private Sub appointmentManagement_Click(sender As Object, e As EventArgs) Handles appointmentManagement.Click
        showSubmenu(panelAppointment)
    End Sub
    Private Sub viewAppointments_Click(sender As Object, e As EventArgs) Handles viewAppointments.Click
        OpenChildForm(New viewallbookings())
        hideSubmenu()
    End Sub

    Private Sub services_Click(sender As Object, e As EventArgs) Handles services.Click
        showSubmenu(panelService)
    End Sub

    Private Sub servicelist_Click(sender As Object, e As EventArgs) Handles servicelist.Click
        hideSubmenu()
        OpenChildForm(New servicelist())
    End Sub

    Private Sub adminProfile_Click(sender As Object, e As EventArgs) Handles adminProfile.Click
        showSubmenu(panelAdminProf)
    End Sub


    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        hideSubmenu()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            homepage.Show()

        End If
    End Sub



End Class