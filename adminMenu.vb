

Public Class adminMenu

    ' FOR SHOWING AND HIDING MENUS
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
    Private Sub OpenChildForm(childForm As Form)
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
        dailyOverview.PerformClick()
        customizeDesign()
        hideSubmenu()


    End Sub


    ' ADMIN DASHBOARD
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

    Private Sub reminders_Click(sender As Object, e As EventArgs) Handles reminders.Click
        OpenChildForm(New reminder())
        hideSubmenu()
    End Sub





    ' APPOINTMENT MANAGEMENT
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




    ' SERVICES
    Private Sub services_Click(sender As Object, e As EventArgs) Handles services.Click
        showSubmenu(panelService)
    End Sub

    Private Sub servicelist_Click(sender As Object, e As EventArgs) Handles servicelist.Click
        hideSubmenu()
    End Sub

    Private Sub addService_Click(sender As Object, e As EventArgs) Handles addService.Click
        hideSubmenu()
        OpenChildForm(New AdminServices())
    End Sub

    Private Sub editDeleteService_Click(sender As Object, e As EventArgs) Handles editDeleteService.Click
        hideSubmenu()
    End Sub

    Private Sub enableDisableService_Click(sender As Object, e As EventArgs) Handles enableDisableService.Click
        hideSubmenu()
    End Sub





    ' STAFF
    Private Sub staff_Click(sender As Object, e As EventArgs) Handles staff.Click
        showSubmenu(panelStaff)
    End Sub

    Private Sub staffList_Click(sender As Object, e As EventArgs) Handles stafflist.Click
        hideSubmenu()
    End Sub

    Private Sub addnewStaff_Click(sender As Object, e As EventArgs) Handles addnewStaff.Click
        hideSubmenu()
    End Sub

    Private Sub editstaffinfo_Click(sender As Object, e As EventArgs) Handles editstaffinfo.Click
        hideSubmenu()
    End Sub

    Private Sub staffpef_Click(sender As Object, e As EventArgs) Handles staffpef.Click
        hideSubmenu()
    End Sub






    ' FINANCE

    Private Sub finance_Click(sender As Object, e As EventArgs) Handles finance.Click
        showSubmenu(panelFinancial)
    End Sub

    Private Sub expenseTrack_Click(sender As Object, e As EventArgs) Handles expenseTrack.Click
        hideSubmenu()
    End Sub

    Private Sub salesrep_Click(sender As Object, e As EventArgs) Handles salesrep.Click
        hideSubmenu()
    End Sub





    ' INVENTORY
    Private Sub inventory_Click(sender As Object, e As EventArgs) Handles inventory.Click
        showSubmenu(panelInventory)
    End Sub

    Private Sub inventoryList_Click(sender As Object, e As EventArgs) Handles inventoryList.Click
        hideSubmenu()
    End Sub

    Private Sub addNewItems_Click(sender As Object, e As EventArgs) Handles addNewItems.Click
        hideSubmenu()
    End Sub

    Private Sub updateStockLevels_Click(sender As Object, e As EventArgs) Handles updateStockLevels.Click
        hideSubmenu()
    End Sub

    Private Sub usageLogs_Click(sender As Object, e As EventArgs) Handles usageLogs.Click
        hideSubmenu()
    End Sub

    Private Sub lowStockAlerts_Click(sender As Object, e As EventArgs) Handles lowStockAlerts.Click
        hideSubmenu()
    End Sub



    'PAYMENTS
    Private Sub payments_Click(sender As Object, e As EventArgs) Handles payments.Click
        showSubmenu(panelPayment)
    End Sub

    Private Sub paymentRecords_Click(sender As Object, e As EventArgs) Handles paymentRecords.Click
        hideSubmenu()
    End Sub

    Private Sub updatePaymentStats_Click(sender As Object, e As EventArgs) Handles updatePaymentStats.Click
        hideSubmenu()
    End Sub

    Private Sub generateReceipts_Click(sender As Object, e As EventArgs) Handles generateReceipts.Click
        hideSubmenu()
    End Sub

    Private Sub transactionHistory_Click(sender As Object, e As EventArgs) Handles transactionHistory.Click
        hideSubmenu()
    End Sub






    'SUPPORT
    Private Sub support_Click(sender As Object, e As EventArgs) Handles support.Click
        showSubmenu(panelCustomerSupport)
    End Sub

    Private Sub customerInquiries_Click(sender As Object, e As EventArgs) Handles customerInquiries.Click
        hideSubmenu()
    End Sub

    Private Sub faqManagement_Click(sender As Object, e As EventArgs) Handles faqManagement.Click
        hideSubmenu()
    End Sub

    Private Sub reviewMode_Click(sender As Object, e As EventArgs) Handles reviewMode.Click
        hideSubmenu()
    End Sub





    'PROFILE AND SETTINGS
    Private Sub adminProfile_Click(sender As Object, e As EventArgs) Handles adminProfile.Click
        showSubmenu(panelAdminProf)
    End Sub

    Private Sub updateAdminProfile_Click(sender As Object, e As EventArgs)
        hideSubmenu()
    End Sub

    Private Sub systemSettings_Click(sender As Object, e As EventArgs) Handles systemSettings.Click
        hideSubmenu()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        hideSubmenu()
    End Sub
End Class