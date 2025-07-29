

Public Class adminMenu
    'FOR ROLE-BASED ACCESS CONTROL 
    'Admin/Staff will have special access to manage the system based on their roles.

    Sub customizeDesign()
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


    End Sub



    Private Sub adminDashboard_Click(sender As Object, e As EventArgs) Handles adminDashboard.Click
        showSubmenu(panelAdmin)
    End Sub

    Private Sub dailyOverview_Click(sender As Object, e As EventArgs) Handles dailyOverview.Click
        OpenChildForm(New dailyoverview())
        hideSubmenu()
    End Sub

    Private Sub quickstats_Click(sender As Object, e As EventArgs) Handles quickstats.Click
        OpenChildForm(New quickStats())
        hideSubmenu()
    End Sub







    Private Sub appointmentManagement_Click(sender As Object, e As EventArgs) Handles appointmentManagement.Click
        showSubmenu(panelAppointment)
    End Sub
    Private Sub viewAppointments_Click(sender As Object, e As EventArgs) Handles viewAppointments.Click
        OpenChildForm(New viewallbookings())
        hideSubmenu()
    End Sub
    Private Sub bookingActions_Click(sender As Object, e As EventArgs) Handles bookingActions.Click
        OpenChildForm(New bookingactions())
        hideSubmenu()
    End Sub

    Private Sub manageCustomersBtn_Click(sender As Object, e As EventArgs) Handles manageCustomersBtn.Click
        OpenChildForm(New manageCustomers())
        hideSubmenu()
    End Sub

    Private Sub walkInbookingbtn_Click(sender As Object, e As EventArgs) Handles walkInbookingbtn.Click
        OpenChildForm(New WalkInBookingForm())
        hideSubmenu()
    End Sub



    Private Sub services_Click(sender As Object, e As EventArgs) Handles services.Click
        showSubmenu(panelService)
    End Sub

    Private Sub servicelist_Click(sender As Object, e As EventArgs) Handles servicelist.Click
        hideSubmenu()
        OpenChildForm(New servicelist())
    End Sub

    Private Sub addService_Click(sender As Object, e As EventArgs) Handles addService.Click
        hideSubmenu()
        OpenChildForm(New addservices())
    End Sub

    Private Sub editDeleteService_Click(sender As Object, e As EventArgs) Handles editDeleteService.Click
        hideSubmenu()
        OpenChildForm(New editDeleteService())
    End Sub

    Private Sub enableDisableService_Click(sender As Object, e As EventArgs)
        hideSubmenu()
    End Sub






    Private Sub staff_Click(sender As Object, e As EventArgs) Handles staff.Click
        showSubmenu(panelStaff)
    End Sub

    Private Sub staffList_Click(sender As Object, e As EventArgs) Handles stafflist.Click
        OpenChildForm(New stafflist())
        hideSubmenu()
    End Sub

    Private Sub editStaff_Click(sender As Object, e As EventArgs) Handles addnewStaff.Click
        OpenChildForm(New editstaff())
        hideSubmenu()
    End Sub

    Private Sub staffpef_Click(sender As Object, e As EventArgs) Handles staffpef.Click
        OpenChildForm(New staffperformance())
        hideSubmenu()
    End Sub







    Private Sub finance_Click(sender As Object, e As EventArgs) Handles finance.Click
        showSubmenu(panelFinancial)
    End Sub

    Private Sub expenseTrack_Click(sender As Object, e As EventArgs) Handles expenseTrack.Click
        hideSubmenu()
        OpenChildForm(New expenseTracking())
    End Sub

    Private Sub salesrep_Click(sender As Object, e As EventArgs) Handles salesrep.Click
        hideSubmenu()
        OpenChildForm(New salesReport())
    End Sub






    Private Sub inventory_Click(sender As Object, e As EventArgs) Handles inventory.Click
        showSubmenu(panelInventory)
    End Sub

    Private Sub inventoryList_Click(sender As Object, e As EventArgs) Handles inventoryList.Click
        hideSubmenu()
        OpenChildForm(New inventoryList())
    End Sub

    Private Sub addNewItems_Click(sender As Object, e As EventArgs) Handles addNewItems.Click
        hideSubmenu()
        OpenChildForm(New addNewItems())
    End Sub


    Private Sub usageLogs_Click(sender As Object, e As EventArgs) Handles usageLogs.Click
        hideSubmenu()
        OpenChildForm(New usageLogs())
    End Sub

    Private Sub alerts_Click(sender As Object, e As EventArgs) Handles alerts.Click
        hideSubmenu()
        OpenChildForm(New alerts())
    End Sub




    Private Sub payments_Click(sender As Object, e As EventArgs) Handles payments.Click
        showSubmenu(panelPayment)
    End Sub

    Private Sub paymentRecords_Click(sender As Object, e As EventArgs) Handles paymentRecords.Click
        hideSubmenu()
        OpenChildForm(New paymentRecords())
    End Sub

    Private Sub generateReceipts_Click(sender As Object, e As EventArgs) Handles generateReceipts.Click
        hideSubmenu()
        OpenChildForm(New genReceipts())
    End Sub





    Private Sub support_Click(sender As Object, e As EventArgs) Handles support.Click
        showSubmenu(panelCustomerSupport)
    End Sub

    Private Sub customerInquiries_Click(sender As Object, e As EventArgs) Handles customerInquiries.Click
        hideSubmenu()
        OpenChildForm(New customerInquiries())
    End Sub

    Private Sub faqManagement_Click(sender As Object, e As EventArgs) Handles faqManagement.Click
        hideSubmenu()
        OpenChildForm(New faqManagement())
    End Sub

    Private Sub reviewMode_Click(sender As Object, e As EventArgs) Handles reviewMode.Click
        hideSubmenu()
        OpenChildForm(New moderateReviews())
    End Sub





    Private Sub adminProfile_Click(sender As Object, e As EventArgs) Handles adminProfile.Click
        showSubmenu(panelAdminProf)
    End Sub

    Private Sub updateAdminProfile_Click(sender As Object, e As EventArgs)
        hideSubmenu()
    End Sub

    Private Sub adminUpdate_Click(sender As Object, e As EventArgs) Handles adminUpdate.Click
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