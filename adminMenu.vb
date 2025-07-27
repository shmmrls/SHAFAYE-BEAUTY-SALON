Public Class adminMenu
    'FOR ROLE-BASED ACCESS CONTROL 
    'Admin/Staff will have special access to manage the system based on their roles.

    Sub customizeDesign()
        ' Only hide the submenus/panels, not the main menu items
        panelAdmin.Visible = False
        panelAdminProf.Visible = False
        panelAppointment.Visible = False
        panelCustomerSupport.Visible = False
        panelFinancial.Visible = False
        panelInventory.Visible = False
        panelPayment.Visible = False
        panelService.Visible = False
        panelStaff.Visible = False
    End Sub

    ' New method to configure access based on user role
    Sub configureRoleBasedAccess()
        If String.IsNullOrEmpty(LoggedInRole) Then
            ' Default to admin if no role is set to prevent everything being hidden
            LoggedInRole = "Admin"
        End If

        If LoggedInRole.ToLower() = "staff" Then
            ' Hide main menu buttons that staff cannot access
            If adminDashboard IsNot Nothing Then adminDashboard.Visible = False
            If appointmentManagement IsNot Nothing Then appointmentManagement.Visible = False
            If manageCustomersBtn IsNot Nothing Then manageCustomersBtn.Visible = False
            If services IsNot Nothing Then services.Visible = False
            If staff IsNot Nothing Then staff.Visible = False
            If finance IsNot Nothing Then finance.Visible = False
            If inventory IsNot Nothing Then inventory.Visible = False
            If payments IsNot Nothing Then payments.Visible = False
            If support IsNot Nothing Then support.Visible = False
            If adminProfile IsNot Nothing Then adminProfile.Visible = False

            ' Keep allowed items visible for staff
            If dailyOverview IsNot Nothing Then dailyOverview.Visible = True
            If quickstats IsNot Nothing Then quickstats.Visible = True
            If viewAppointments IsNot Nothing Then viewAppointments.Visible = True
            If stafflist IsNot Nothing Then stafflist.Visible = True
        End If
        ' For admin, don't change visibility - let all items remain visible by default
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
        If (panelCustomerSupport.Visible = True) Then
            panelCustomerSupport.Visible = False
        End If
        If (panelFinancial.Visible = True) Then
            panelFinancial.Visible = False
        End If
        If (panelInventory.Visible = True) Then
            panelInventory.Visible = False
        End If
        If (panelPayment.Visible = True) Then
            panelPayment.Visible = False
        End If
        If (panelService.Visible = True) Then
            panelService.Visible = False
        End If
        If (panelStaff.Visible = True) Then
            panelStaff.Visible = False
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
        configureRoleBasedAccess() ' Apply role-based access control
    End Sub

    ' Helper method to check if user has permission
    Private Function HasPermission(requiredRole As String) As Boolean
        If String.IsNullOrEmpty(LoggedInRole) Then
            ' Default to admin if no role is set
            LoggedInRole = "Admin"
        End If

        If LoggedInRole.ToLower() = "admin" Then
            Return True ' Admin has access to everything
        ElseIf LoggedInRole.ToLower() = "staff" Then
            ' Staff only has access to specific functions
            Select Case requiredRole.ToLower()
                Case "dailyoverview", "quickstats", "viewbooking", "stafflist"
                    Return True
                Case Else
                    Return False
            End Select
        End If
        Return False
    End Function

    Private Sub adminDashboard_Click(sender As Object, e As EventArgs) Handles adminDashboard.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        showSubmenu(panelAdmin)
    End Sub

    Private Sub dailyOverview_Click(sender As Object, e As EventArgs) Handles dailyOverview.Click
        If Not HasPermission("dailyoverview") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        OpenChildForm(New dailyoverview())
        hideSubmenu()
    End Sub

    Private Sub quickstats_Click(sender As Object, e As EventArgs) Handles quickstats.Click
        If Not HasPermission("quickstats") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        OpenChildForm(New quickStats())
        hideSubmenu()
    End Sub

    Private Sub reminders_Click(sender As Object, e As EventArgs)
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        OpenChildForm(New reminder())
        hideSubmenu()
    End Sub

    Private Sub appointmentManagement_Click(sender As Object, e As EventArgs) Handles appointmentManagement.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        showSubmenu(panelAppointment)
    End Sub

    Private Sub viewAppointments_Click(sender As Object, e As EventArgs) Handles viewAppointments.Click
        If Not HasPermission("viewbooking") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        OpenChildForm(New viewallbookings())
        hideSubmenu()
    End Sub

    Private Sub bookingActions_Click(sender As Object, e As EventArgs) Handles bookingActions.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        OpenChildForm(New bookingactions())
        hideSubmenu()
    End Sub

    Private Sub manageCustomersBtn_Click(sender As Object, e As EventArgs) Handles manageCustomersBtn.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        OpenChildForm(New manageCustomers())
        hideSubmenu()
    End Sub

    Private Sub services_Click(sender As Object, e As EventArgs) Handles services.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        showSubmenu(panelService)
    End Sub

    Private Sub servicelist_Click(sender As Object, e As EventArgs) Handles servicelist.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New servicelist())
    End Sub

    Private Sub addService_Click(sender As Object, e As EventArgs) Handles addService.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New addservices())
    End Sub

    Private Sub editDeleteService_Click(sender As Object, e As EventArgs) Handles editDeleteService.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New editDeleteService())
    End Sub

    Private Sub enableDisableService_Click(sender As Object, e As EventArgs)
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
    End Sub

    Private Sub staff_Click(sender As Object, e As EventArgs) Handles staff.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        showSubmenu(panelStaff)
    End Sub

    Private Sub staffList_Click(sender As Object, e As EventArgs) Handles stafflist.Click
        If Not HasPermission("stafflist") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        OpenChildForm(New stafflist())
        hideSubmenu()
    End Sub

    Private Sub editStaff_Click(sender As Object, e As EventArgs) Handles addnewStaff.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        OpenChildForm(New editstaff())
        hideSubmenu()
    End Sub

    Private Sub staffpef_Click(sender As Object, e As EventArgs) Handles staffpef.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        OpenChildForm(New staffperformance())
        hideSubmenu()
    End Sub

    Private Sub finance_Click(sender As Object, e As EventArgs) Handles finance.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        showSubmenu(panelFinancial)
    End Sub

    Private Sub expenseTrack_Click(sender As Object, e As EventArgs) Handles expenseTrack.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New expenseTracking())
    End Sub

    Private Sub salesrep_Click(sender As Object, e As EventArgs) Handles salesrep.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New salesReport())
    End Sub

    Private Sub inventory_Click(sender As Object, e As EventArgs) Handles inventory.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        showSubmenu(panelInventory)
    End Sub

    Private Sub inventoryList_Click(sender As Object, e As EventArgs) Handles inventoryList.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New inventoryList())
    End Sub

    Private Sub addNewItems_Click(sender As Object, e As EventArgs) Handles addNewItems.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New addNewItems())
    End Sub

    Private Sub usageLogs_Click(sender As Object, e As EventArgs) Handles usageLogs.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New usageLogs())
    End Sub

    Private Sub alerts_Click(sender As Object, e As EventArgs) Handles alerts.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New alerts())
    End Sub

    Private Sub payments_Click(sender As Object, e As EventArgs) Handles payments.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        showSubmenu(panelPayment)
    End Sub

    Private Sub paymentRecords_Click(sender As Object, e As EventArgs) Handles paymentRecords.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New paymentRecords())
    End Sub

    Private Sub generateReceipts_Click(sender As Object, e As EventArgs) Handles generateReceipts.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New genReceipts())
    End Sub

    Private Sub support_Click(sender As Object, e As EventArgs) Handles support.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        showSubmenu(panelCustomerSupport)
    End Sub

    Private Sub customerInquiries_Click(sender As Object, e As EventArgs) Handles customerInquiries.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New customerInquiries())
    End Sub

    Private Sub faqManagement_Click(sender As Object, e As EventArgs) Handles faqManagement.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New faqManagement())
    End Sub

    Private Sub reviewMode_Click(sender As Object, e As EventArgs) Handles reviewMode.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New moderateReviews())
    End Sub

    Private Sub adminProfile_Click(sender As Object, e As EventArgs) Handles adminProfile.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        showSubmenu(panelAdminProf)
    End Sub

    Private Sub updateAdminProfile_Click(sender As Object, e As EventArgs)
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
    End Sub

    Private Sub adminUpdate_Click(sender As Object, e As EventArgs) Handles adminUpdate.Click
        If Not HasPermission("admin") Then
            MessageBox.Show("Access Denied: You don't have permission to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        hideSubmenu()
        OpenChildForm(New adminControl())
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        hideSubmenu()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            homepage.Show()
            MsgBox("You have successfully logged out.", MsgBoxStyle.Information, "Logout Successful")
        End If
    End Sub

End Class