Public Class adminMenu
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


    Private Sub adminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customizeDesign()
        hideSubmenu()
    End Sub


    ' ADMIN DASHBOARD
    Private Sub adminDashboard_Click(sender As Object, e As EventArgs) Handles adminDashboard.Click
        showSubmenu(panelAdmin)
    End Sub

    Private Sub dailyOverview_Click(sender As Object, e As EventArgs) Handles dailyOverview.Click
        hideSubmenu()
    End Sub

    Private Sub quickstats_Click(sender As Object, e As EventArgs) Handles quickstats.Click
        hideSubmenu()
    End Sub

    Private Sub adminAlerts_Click(sender As Object, e As EventArgs) Handles adminAlerts.Click
        hideSubmenu()
    End Sub





    ' APPOINTMENT MANAGEMENT
    Private Sub appointmentManagement_Click(sender As Object, e As EventArgs) Handles appointmentManagement.Click
        showSubmenu(panelAppointment)
    End Sub
    Private Sub viewAppointments_Click(sender As Object, e As EventArgs) Handles viewAppointments.Click
        hideSubmenu()
    End Sub
    Private Sub bookingActions_Click(sender As Object, e As EventArgs) Handles bookingActions.Click
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











    '


End Class