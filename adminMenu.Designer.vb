﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminMenu
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
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.panelChildForm = New System.Windows.Forms.Panel()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.panelAdminProf = New System.Windows.Forms.Panel()
        Me.logout = New System.Windows.Forms.Button()
        Me.adminUpdate = New System.Windows.Forms.Button()
        Me.adminProfile = New System.Windows.Forms.Button()
        Me.panelCustomerSupport = New System.Windows.Forms.Panel()
        Me.reviewMode = New System.Windows.Forms.Button()
        Me.faqManagement = New System.Windows.Forms.Button()
        Me.customerInquiries = New System.Windows.Forms.Button()
        Me.support = New System.Windows.Forms.Button()
        Me.panelPayment = New System.Windows.Forms.Panel()
        Me.generateReceipts = New System.Windows.Forms.Button()
        Me.paymentRecords = New System.Windows.Forms.Button()
        Me.payments = New System.Windows.Forms.Button()
        Me.panelInventory = New System.Windows.Forms.Panel()
        Me.alerts = New System.Windows.Forms.Button()
        Me.usageLogs = New System.Windows.Forms.Button()
        Me.addNewItems = New System.Windows.Forms.Button()
        Me.inventoryList = New System.Windows.Forms.Button()
        Me.inventory = New System.Windows.Forms.Button()
        Me.panelFinancial = New System.Windows.Forms.Panel()
        Me.salesrep = New System.Windows.Forms.Button()
        Me.expenseTrack = New System.Windows.Forms.Button()
        Me.finance = New System.Windows.Forms.Button()
        Me.panelStaff = New System.Windows.Forms.Panel()
        Me.staffpef = New System.Windows.Forms.Button()
        Me.addnewStaff = New System.Windows.Forms.Button()
        Me.stafflist = New System.Windows.Forms.Button()
        Me.staff = New System.Windows.Forms.Button()
        Me.panelService = New System.Windows.Forms.Panel()
        Me.editDeleteService = New System.Windows.Forms.Button()
        Me.addService = New System.Windows.Forms.Button()
        Me.servicelist = New System.Windows.Forms.Button()
        Me.services = New System.Windows.Forms.Button()
        Me.panelAppointment = New System.Windows.Forms.Panel()
        Me.manageCustomersBtn = New System.Windows.Forms.Button()
        Me.bookingActions = New System.Windows.Forms.Button()
        Me.viewAppointments = New System.Windows.Forms.Button()
        Me.appointmentManagement = New System.Windows.Forms.Button()
        Me.panelAdmin = New System.Windows.Forms.Panel()
        Me.quickstats = New System.Windows.Forms.Button()
        Me.dailyOverview = New System.Windows.Forms.Button()
        Me.adminDashboard = New System.Windows.Forms.Button()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.mainPanel.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        Me.panelAdminProf.SuspendLayout()
        Me.panelCustomerSupport.SuspendLayout()
        Me.panelPayment.SuspendLayout()
        Me.panelInventory.SuspendLayout()
        Me.panelFinancial.SuspendLayout()
        Me.panelStaff.SuspendLayout()
        Me.panelService.SuspendLayout()
        Me.panelAppointment.SuspendLayout()
        Me.panelAdmin.SuspendLayout()
        Me.SuspendLayout()
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
        Me.mainPanel.TabIndex = 1
        '
        'panelChildForm
        '
        Me.panelChildForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelChildForm.Location = New System.Drawing.Point(333, 0)
        Me.panelChildForm.Margin = New System.Windows.Forms.Padding(4)
        Me.panelChildForm.Name = "panelChildForm"
        Me.panelChildForm.Size = New System.Drawing.Size(931, 727)
        Me.panelChildForm.TabIndex = 2
        '
        'panelMenu
        '
        Me.panelMenu.AutoScroll = True
        Me.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.panelAdminProf)
        Me.panelMenu.Controls.Add(Me.adminProfile)
        Me.panelMenu.Controls.Add(Me.panelCustomerSupport)
        Me.panelMenu.Controls.Add(Me.support)
        Me.panelMenu.Controls.Add(Me.panelPayment)
        Me.panelMenu.Controls.Add(Me.payments)
        Me.panelMenu.Controls.Add(Me.panelInventory)
        Me.panelMenu.Controls.Add(Me.inventory)
        Me.panelMenu.Controls.Add(Me.panelFinancial)
        Me.panelMenu.Controls.Add(Me.finance)
        Me.panelMenu.Controls.Add(Me.panelStaff)
        Me.panelMenu.Controls.Add(Me.staff)
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
        'panelAdminProf
        '
        Me.panelAdminProf.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelAdminProf.Controls.Add(Me.logout)
        Me.panelAdminProf.Controls.Add(Me.adminUpdate)
        Me.panelAdminProf.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelAdminProf.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.panelAdminProf.Location = New System.Drawing.Point(0, 1817)
        Me.panelAdminProf.Margin = New System.Windows.Forms.Padding(4)
        Me.panelAdminProf.Name = "panelAdminProf"
        Me.panelAdminProf.Size = New System.Drawing.Size(316, 113)
        Me.panelAdminProf.TabIndex = 21
        '
        'logout
        '
        Me.logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.logout.FlatAppearance.BorderSize = 0
        Me.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.logout.Location = New System.Drawing.Point(0, 49)
        Me.logout.Margin = New System.Windows.Forms.Padding(4)
        Me.logout.Name = "logout"
        Me.logout.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.logout.Size = New System.Drawing.Size(316, 49)
        Me.logout.TabIndex = 3
        Me.logout.Text = "Logout"
        Me.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logout.UseVisualStyleBackColor = True
        '
        'adminUpdate
        '
        Me.adminUpdate.Dock = System.Windows.Forms.DockStyle.Top
        Me.adminUpdate.FlatAppearance.BorderSize = 0
        Me.adminUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.adminUpdate.Location = New System.Drawing.Point(0, 0)
        Me.adminUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.adminUpdate.Name = "adminUpdate"
        Me.adminUpdate.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.adminUpdate.Size = New System.Drawing.Size(316, 49)
        Me.adminUpdate.TabIndex = 2
        Me.adminUpdate.Text = "Admin Control"
        Me.adminUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.adminUpdate.UseVisualStyleBackColor = True
        '
        'adminProfile
        '
        Me.adminProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.adminProfile.FlatAppearance.BorderSize = 0
        Me.adminProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminProfile.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.adminProfile.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.adminProfile.Location = New System.Drawing.Point(0, 1762)
        Me.adminProfile.Margin = New System.Windows.Forms.Padding(4)
        Me.adminProfile.Name = "adminProfile"
        Me.adminProfile.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.adminProfile.Size = New System.Drawing.Size(316, 55)
        Me.adminProfile.TabIndex = 20
        Me.adminProfile.Text = "Profile and Settings"
        Me.adminProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.adminProfile.UseVisualStyleBackColor = True
        '
        'panelCustomerSupport
        '
        Me.panelCustomerSupport.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelCustomerSupport.Controls.Add(Me.reviewMode)
        Me.panelCustomerSupport.Controls.Add(Me.faqManagement)
        Me.panelCustomerSupport.Controls.Add(Me.customerInquiries)
        Me.panelCustomerSupport.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCustomerSupport.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.panelCustomerSupport.Location = New System.Drawing.Point(0, 1606)
        Me.panelCustomerSupport.Margin = New System.Windows.Forms.Padding(4)
        Me.panelCustomerSupport.Name = "panelCustomerSupport"
        Me.panelCustomerSupport.Size = New System.Drawing.Size(316, 156)
        Me.panelCustomerSupport.TabIndex = 19
        '
        'reviewMode
        '
        Me.reviewMode.Dock = System.Windows.Forms.DockStyle.Top
        Me.reviewMode.FlatAppearance.BorderSize = 0
        Me.reviewMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reviewMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.reviewMode.Location = New System.Drawing.Point(0, 98)
        Me.reviewMode.Margin = New System.Windows.Forms.Padding(4)
        Me.reviewMode.Name = "reviewMode"
        Me.reviewMode.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.reviewMode.Size = New System.Drawing.Size(316, 49)
        Me.reviewMode.TabIndex = 3
        Me.reviewMode.Text = "Moderate Reviews"
        Me.reviewMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reviewMode.UseVisualStyleBackColor = True
        '
        'faqManagement
        '
        Me.faqManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.faqManagement.FlatAppearance.BorderSize = 0
        Me.faqManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.faqManagement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.faqManagement.Location = New System.Drawing.Point(0, 49)
        Me.faqManagement.Margin = New System.Windows.Forms.Padding(4)
        Me.faqManagement.Name = "faqManagement"
        Me.faqManagement.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.faqManagement.Size = New System.Drawing.Size(316, 49)
        Me.faqManagement.TabIndex = 2
        Me.faqManagement.Text = "FAQ Management"
        Me.faqManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.faqManagement.UseVisualStyleBackColor = True
        '
        'customerInquiries
        '
        Me.customerInquiries.Dock = System.Windows.Forms.DockStyle.Top
        Me.customerInquiries.FlatAppearance.BorderSize = 0
        Me.customerInquiries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.customerInquiries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.customerInquiries.Location = New System.Drawing.Point(0, 0)
        Me.customerInquiries.Margin = New System.Windows.Forms.Padding(4)
        Me.customerInquiries.Name = "customerInquiries"
        Me.customerInquiries.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.customerInquiries.Size = New System.Drawing.Size(316, 49)
        Me.customerInquiries.TabIndex = 1
        Me.customerInquiries.Text = "Customer Inquiries"
        Me.customerInquiries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.customerInquiries.UseVisualStyleBackColor = True
        '
        'support
        '
        Me.support.Dock = System.Windows.Forms.DockStyle.Top
        Me.support.FlatAppearance.BorderSize = 0
        Me.support.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.support.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.support.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.support.Location = New System.Drawing.Point(0, 1551)
        Me.support.Margin = New System.Windows.Forms.Padding(4)
        Me.support.Name = "support"
        Me.support.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.support.Size = New System.Drawing.Size(316, 55)
        Me.support.TabIndex = 18
        Me.support.Text = "Support" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.support.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.support.UseVisualStyleBackColor = True
        '
        'panelPayment
        '
        Me.panelPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelPayment.Controls.Add(Me.generateReceipts)
        Me.panelPayment.Controls.Add(Me.paymentRecords)
        Me.panelPayment.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelPayment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.panelPayment.Location = New System.Drawing.Point(0, 1445)
        Me.panelPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.panelPayment.Name = "panelPayment"
        Me.panelPayment.Size = New System.Drawing.Size(316, 106)
        Me.panelPayment.TabIndex = 17
        '
        'generateReceipts
        '
        Me.generateReceipts.Dock = System.Windows.Forms.DockStyle.Top
        Me.generateReceipts.FlatAppearance.BorderSize = 0
        Me.generateReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generateReceipts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.generateReceipts.Location = New System.Drawing.Point(0, 49)
        Me.generateReceipts.Margin = New System.Windows.Forms.Padding(4)
        Me.generateReceipts.Name = "generateReceipts"
        Me.generateReceipts.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.generateReceipts.Size = New System.Drawing.Size(316, 49)
        Me.generateReceipts.TabIndex = 3
        Me.generateReceipts.Text = "Generate Receipts"
        Me.generateReceipts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.generateReceipts.UseVisualStyleBackColor = True
        '
        'paymentRecords
        '
        Me.paymentRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.paymentRecords.FlatAppearance.BorderSize = 0
        Me.paymentRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.paymentRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.paymentRecords.Location = New System.Drawing.Point(0, 0)
        Me.paymentRecords.Margin = New System.Windows.Forms.Padding(4)
        Me.paymentRecords.Name = "paymentRecords"
        Me.paymentRecords.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.paymentRecords.Size = New System.Drawing.Size(316, 49)
        Me.paymentRecords.TabIndex = 1
        Me.paymentRecords.Text = "Payment Records"
        Me.paymentRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.paymentRecords.UseVisualStyleBackColor = True
        '
        'payments
        '
        Me.payments.Dock = System.Windows.Forms.DockStyle.Top
        Me.payments.FlatAppearance.BorderSize = 0
        Me.payments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.payments.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.payments.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.payments.Location = New System.Drawing.Point(0, 1390)
        Me.payments.Margin = New System.Windows.Forms.Padding(4)
        Me.payments.Name = "payments"
        Me.payments.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.payments.Size = New System.Drawing.Size(316, 55)
        Me.payments.TabIndex = 16
        Me.payments.Text = "Payments"
        Me.payments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.payments.UseVisualStyleBackColor = True
        '
        'panelInventory
        '
        Me.panelInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelInventory.Controls.Add(Me.alerts)
        Me.panelInventory.Controls.Add(Me.usageLogs)
        Me.panelInventory.Controls.Add(Me.addNewItems)
        Me.panelInventory.Controls.Add(Me.inventoryList)
        Me.panelInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelInventory.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.panelInventory.Location = New System.Drawing.Point(0, 1179)
        Me.panelInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.panelInventory.Name = "panelInventory"
        Me.panelInventory.Size = New System.Drawing.Size(316, 211)
        Me.panelInventory.TabIndex = 15
        '
        'alerts
        '
        Me.alerts.Dock = System.Windows.Forms.DockStyle.Top
        Me.alerts.FlatAppearance.BorderSize = 0
        Me.alerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.alerts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.alerts.Location = New System.Drawing.Point(0, 147)
        Me.alerts.Margin = New System.Windows.Forms.Padding(4)
        Me.alerts.Name = "alerts"
        Me.alerts.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.alerts.Size = New System.Drawing.Size(316, 49)
        Me.alerts.TabIndex = 5
        Me.alerts.Text = "Alerts"
        Me.alerts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.alerts.UseVisualStyleBackColor = True
        '
        'usageLogs
        '
        Me.usageLogs.Dock = System.Windows.Forms.DockStyle.Top
        Me.usageLogs.FlatAppearance.BorderSize = 0
        Me.usageLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usageLogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.usageLogs.Location = New System.Drawing.Point(0, 98)
        Me.usageLogs.Margin = New System.Windows.Forms.Padding(4)
        Me.usageLogs.Name = "usageLogs"
        Me.usageLogs.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.usageLogs.Size = New System.Drawing.Size(316, 49)
        Me.usageLogs.TabIndex = 4
        Me.usageLogs.Text = "Usage Logs"
        Me.usageLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.usageLogs.UseVisualStyleBackColor = True
        '
        'addNewItems
        '
        Me.addNewItems.Dock = System.Windows.Forms.DockStyle.Top
        Me.addNewItems.FlatAppearance.BorderSize = 0
        Me.addNewItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addNewItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.addNewItems.Location = New System.Drawing.Point(0, 49)
        Me.addNewItems.Margin = New System.Windows.Forms.Padding(4)
        Me.addNewItems.Name = "addNewItems"
        Me.addNewItems.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.addNewItems.Size = New System.Drawing.Size(316, 49)
        Me.addNewItems.TabIndex = 2
        Me.addNewItems.Text = "Add and Update Stock"
        Me.addNewItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addNewItems.UseVisualStyleBackColor = True
        '
        'inventoryList
        '
        Me.inventoryList.Dock = System.Windows.Forms.DockStyle.Top
        Me.inventoryList.FlatAppearance.BorderSize = 0
        Me.inventoryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inventoryList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.inventoryList.Location = New System.Drawing.Point(0, 0)
        Me.inventoryList.Margin = New System.Windows.Forms.Padding(4)
        Me.inventoryList.Name = "inventoryList"
        Me.inventoryList.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.inventoryList.Size = New System.Drawing.Size(316, 49)
        Me.inventoryList.TabIndex = 1
        Me.inventoryList.Text = "Inventory List"
        Me.inventoryList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.inventoryList.UseVisualStyleBackColor = True
        '
        'inventory
        '
        Me.inventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.inventory.FlatAppearance.BorderSize = 0
        Me.inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inventory.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.inventory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.inventory.Location = New System.Drawing.Point(0, 1124)
        Me.inventory.Margin = New System.Windows.Forms.Padding(4)
        Me.inventory.Name = "inventory"
        Me.inventory.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.inventory.Size = New System.Drawing.Size(316, 55)
        Me.inventory.TabIndex = 14
        Me.inventory.Text = "Inventory"
        Me.inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.inventory.UseVisualStyleBackColor = True
        '
        'panelFinancial
        '
        Me.panelFinancial.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelFinancial.Controls.Add(Me.salesrep)
        Me.panelFinancial.Controls.Add(Me.expenseTrack)
        Me.panelFinancial.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFinancial.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.panelFinancial.Location = New System.Drawing.Point(0, 1016)
        Me.panelFinancial.Margin = New System.Windows.Forms.Padding(4)
        Me.panelFinancial.Name = "panelFinancial"
        Me.panelFinancial.Size = New System.Drawing.Size(316, 108)
        Me.panelFinancial.TabIndex = 9
        '
        'salesrep
        '
        Me.salesrep.Dock = System.Windows.Forms.DockStyle.Top
        Me.salesrep.FlatAppearance.BorderSize = 0
        Me.salesrep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.salesrep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.salesrep.Location = New System.Drawing.Point(0, 49)
        Me.salesrep.Margin = New System.Windows.Forms.Padding(4)
        Me.salesrep.Name = "salesrep"
        Me.salesrep.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.salesrep.Size = New System.Drawing.Size(316, 49)
        Me.salesrep.TabIndex = 2
        Me.salesrep.Text = "Sales Report"
        Me.salesrep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salesrep.UseVisualStyleBackColor = True
        '
        'expenseTrack
        '
        Me.expenseTrack.Dock = System.Windows.Forms.DockStyle.Top
        Me.expenseTrack.FlatAppearance.BorderSize = 0
        Me.expenseTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.expenseTrack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.expenseTrack.Location = New System.Drawing.Point(0, 0)
        Me.expenseTrack.Margin = New System.Windows.Forms.Padding(4)
        Me.expenseTrack.Name = "expenseTrack"
        Me.expenseTrack.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.expenseTrack.Size = New System.Drawing.Size(316, 49)
        Me.expenseTrack.TabIndex = 1
        Me.expenseTrack.Text = "Expense Tracking"
        Me.expenseTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.expenseTrack.UseVisualStyleBackColor = True
        '
        'finance
        '
        Me.finance.Dock = System.Windows.Forms.DockStyle.Top
        Me.finance.FlatAppearance.BorderSize = 0
        Me.finance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.finance.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.finance.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.finance.Location = New System.Drawing.Point(0, 961)
        Me.finance.Margin = New System.Windows.Forms.Padding(4)
        Me.finance.Name = "finance"
        Me.finance.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.finance.Size = New System.Drawing.Size(316, 55)
        Me.finance.TabIndex = 8
        Me.finance.Text = "Finance"
        Me.finance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.finance.UseVisualStyleBackColor = True
        '
        'panelStaff
        '
        Me.panelStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelStaff.Controls.Add(Me.staffpef)
        Me.panelStaff.Controls.Add(Me.addnewStaff)
        Me.panelStaff.Controls.Add(Me.stafflist)
        Me.panelStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelStaff.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.panelStaff.Location = New System.Drawing.Point(0, 802)
        Me.panelStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.panelStaff.Name = "panelStaff"
        Me.panelStaff.Size = New System.Drawing.Size(316, 159)
        Me.panelStaff.TabIndex = 7
        '
        'staffpef
        '
        Me.staffpef.Dock = System.Windows.Forms.DockStyle.Top
        Me.staffpef.FlatAppearance.BorderSize = 0
        Me.staffpef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.staffpef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.staffpef.Location = New System.Drawing.Point(0, 98)
        Me.staffpef.Margin = New System.Windows.Forms.Padding(4)
        Me.staffpef.Name = "staffpef"
        Me.staffpef.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.staffpef.Size = New System.Drawing.Size(316, 49)
        Me.staffpef.TabIndex = 4
        Me.staffpef.Text = "Staff Performance"
        Me.staffpef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.staffpef.UseVisualStyleBackColor = True
        '
        'addnewStaff
        '
        Me.addnewStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.addnewStaff.FlatAppearance.BorderSize = 0
        Me.addnewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addnewStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.addnewStaff.Location = New System.Drawing.Point(0, 49)
        Me.addnewStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.addnewStaff.Name = "addnewStaff"
        Me.addnewStaff.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.addnewStaff.Size = New System.Drawing.Size(316, 49)
        Me.addnewStaff.TabIndex = 2
        Me.addnewStaff.Text = "Edit Staff"
        Me.addnewStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addnewStaff.UseVisualStyleBackColor = True
        '
        'stafflist
        '
        Me.stafflist.Dock = System.Windows.Forms.DockStyle.Top
        Me.stafflist.FlatAppearance.BorderSize = 0
        Me.stafflist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stafflist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.stafflist.Location = New System.Drawing.Point(0, 0)
        Me.stafflist.Margin = New System.Windows.Forms.Padding(4)
        Me.stafflist.Name = "stafflist"
        Me.stafflist.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.stafflist.Size = New System.Drawing.Size(316, 49)
        Me.stafflist.TabIndex = 1
        Me.stafflist.Text = "Staff List"
        Me.stafflist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stafflist.UseVisualStyleBackColor = True
        '
        'staff
        '
        Me.staff.Dock = System.Windows.Forms.DockStyle.Top
        Me.staff.FlatAppearance.BorderSize = 0
        Me.staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.staff.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.staff.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.staff.Location = New System.Drawing.Point(0, 747)
        Me.staff.Margin = New System.Windows.Forms.Padding(4)
        Me.staff.Name = "staff"
        Me.staff.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.staff.Size = New System.Drawing.Size(316, 55)
        Me.staff.TabIndex = 6
        Me.staff.Text = "Staff"
        Me.staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.staff.UseVisualStyleBackColor = True
        '
        'panelService
        '
        Me.panelService.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelService.Controls.Add(Me.editDeleteService)
        Me.panelService.Controls.Add(Me.addService)
        Me.panelService.Controls.Add(Me.servicelist)
        Me.panelService.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelService.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.panelService.Location = New System.Drawing.Point(0, 593)
        Me.panelService.Margin = New System.Windows.Forms.Padding(4)
        Me.panelService.Name = "panelService"
        Me.panelService.Size = New System.Drawing.Size(316, 154)
        Me.panelService.TabIndex = 5
        '
        'editDeleteService
        '
        Me.editDeleteService.Dock = System.Windows.Forms.DockStyle.Top
        Me.editDeleteService.FlatAppearance.BorderSize = 0
        Me.editDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editDeleteService.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.editDeleteService.Location = New System.Drawing.Point(0, 98)
        Me.editDeleteService.Margin = New System.Windows.Forms.Padding(4)
        Me.editDeleteService.Name = "editDeleteService"
        Me.editDeleteService.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.editDeleteService.Size = New System.Drawing.Size(316, 49)
        Me.editDeleteService.TabIndex = 3
        Me.editDeleteService.Text = "Edit/Delete Service"
        Me.editDeleteService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.editDeleteService.UseVisualStyleBackColor = True
        '
        'addService
        '
        Me.addService.Dock = System.Windows.Forms.DockStyle.Top
        Me.addService.FlatAppearance.BorderSize = 0
        Me.addService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addService.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.addService.Location = New System.Drawing.Point(0, 49)
        Me.addService.Margin = New System.Windows.Forms.Padding(4)
        Me.addService.Name = "addService"
        Me.addService.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.addService.Size = New System.Drawing.Size(316, 49)
        Me.addService.TabIndex = 2
        Me.addService.Text = "Add New Service"
        Me.addService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addService.UseVisualStyleBackColor = True
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
        Me.servicelist.Size = New System.Drawing.Size(316, 49)
        Me.servicelist.TabIndex = 1
        Me.servicelist.Text = "Service List"
        Me.servicelist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.servicelist.UseVisualStyleBackColor = True
        '
        'services
        '
        Me.services.Dock = System.Windows.Forms.DockStyle.Top
        Me.services.FlatAppearance.BorderSize = 0
        Me.services.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.services.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.services.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.services.Location = New System.Drawing.Point(0, 538)
        Me.services.Margin = New System.Windows.Forms.Padding(4)
        Me.services.Name = "services"
        Me.services.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.services.Size = New System.Drawing.Size(316, 55)
        Me.services.TabIndex = 4
        Me.services.Text = "Services"
        Me.services.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.services.UseVisualStyleBackColor = True
        '
        'panelAppointment
        '
        Me.panelAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelAppointment.Controls.Add(Me.manageCustomersBtn)
        Me.panelAppointment.Controls.Add(Me.bookingActions)
        Me.panelAppointment.Controls.Add(Me.viewAppointments)
        Me.panelAppointment.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelAppointment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.panelAppointment.Location = New System.Drawing.Point(0, 379)
        Me.panelAppointment.Margin = New System.Windows.Forms.Padding(4)
        Me.panelAppointment.Name = "panelAppointment"
        Me.panelAppointment.Size = New System.Drawing.Size(316, 159)
        Me.panelAppointment.TabIndex = 2
        '
        'manageCustomersBtn
        '
        Me.manageCustomersBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.manageCustomersBtn.FlatAppearance.BorderSize = 0
        Me.manageCustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageCustomersBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.manageCustomersBtn.Location = New System.Drawing.Point(0, 98)
        Me.manageCustomersBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.manageCustomersBtn.Name = "manageCustomersBtn"
        Me.manageCustomersBtn.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.manageCustomersBtn.Size = New System.Drawing.Size(316, 49)
        Me.manageCustomersBtn.TabIndex = 3
        Me.manageCustomersBtn.Text = "Manage Customers"
        Me.manageCustomersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.manageCustomersBtn.UseVisualStyleBackColor = True
        '
        'bookingActions
        '
        Me.bookingActions.Dock = System.Windows.Forms.DockStyle.Top
        Me.bookingActions.FlatAppearance.BorderSize = 0
        Me.bookingActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bookingActions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bookingActions.Location = New System.Drawing.Point(0, 49)
        Me.bookingActions.Margin = New System.Windows.Forms.Padding(4)
        Me.bookingActions.Name = "bookingActions"
        Me.bookingActions.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.bookingActions.Size = New System.Drawing.Size(316, 49)
        Me.bookingActions.TabIndex = 2
        Me.bookingActions.Text = "Manage Bookings"
        Me.bookingActions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bookingActions.UseVisualStyleBackColor = True
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
        Me.viewAppointments.Size = New System.Drawing.Size(316, 49)
        Me.viewAppointments.TabIndex = 1
        Me.viewAppointments.Text = "View All Bookings"
        Me.viewAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.viewAppointments.UseVisualStyleBackColor = True
        '
        'appointmentManagement
        '
        Me.appointmentManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.appointmentManagement.FlatAppearance.BorderSize = 0
        Me.appointmentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.appointmentManagement.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.appointmentManagement.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.appointmentManagement.Location = New System.Drawing.Point(0, 324)
        Me.appointmentManagement.Margin = New System.Windows.Forms.Padding(4)
        Me.appointmentManagement.Name = "appointmentManagement"
        Me.appointmentManagement.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.appointmentManagement.Size = New System.Drawing.Size(316, 55)
        Me.appointmentManagement.TabIndex = 3
        Me.appointmentManagement.Text = "Appointments"
        Me.appointmentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.appointmentManagement.UseVisualStyleBackColor = True
        '
        'panelAdmin
        '
        Me.panelAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelAdmin.Controls.Add(Me.quickstats)
        Me.panelAdmin.Controls.Add(Me.dailyOverview)
        Me.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelAdmin.Location = New System.Drawing.Point(0, 219)
        Me.panelAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.panelAdmin.Name = "panelAdmin"
        Me.panelAdmin.Size = New System.Drawing.Size(316, 105)
        Me.panelAdmin.TabIndex = 1
        '
        'quickstats
        '
        Me.quickstats.Dock = System.Windows.Forms.DockStyle.Top
        Me.quickstats.FlatAppearance.BorderSize = 0
        Me.quickstats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quickstats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.quickstats.Location = New System.Drawing.Point(0, 49)
        Me.quickstats.Margin = New System.Windows.Forms.Padding(4)
        Me.quickstats.Name = "quickstats"
        Me.quickstats.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.quickstats.Size = New System.Drawing.Size(316, 49)
        Me.quickstats.TabIndex = 2
        Me.quickstats.Text = "Quick Stats"
        Me.quickstats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.quickstats.UseVisualStyleBackColor = True
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
        Me.dailyOverview.Size = New System.Drawing.Size(316, 49)
        Me.dailyOverview.TabIndex = 1
        Me.dailyOverview.Text = "Daily Overview"
        Me.dailyOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dailyOverview.UseVisualStyleBackColor = True
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
        Me.adminDashboard.Size = New System.Drawing.Size(316, 55)
        Me.adminDashboard.TabIndex = 1
        Me.adminDashboard.Text = "Dashboard"
        Me.adminDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.adminDashboard.UseVisualStyleBackColor = True
        '
        'panelLogo
        '
        Me.panelLogo.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.logo_shafaye
        Me.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(316, 164)
        Me.panelLogo.TabIndex = 1
        '
        'adminMenu
        '
        Me.AcceptButton = Me.adminProfile
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 727)
        Me.Controls.Add(Me.mainPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1280, 766)
        Me.Name = "adminMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminMenu"
        Me.mainPanel.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        Me.panelAdminProf.ResumeLayout(False)
        Me.panelCustomerSupport.ResumeLayout(False)
        Me.panelPayment.ResumeLayout(False)
        Me.panelInventory.ResumeLayout(False)
        Me.panelFinancial.ResumeLayout(False)
        Me.panelStaff.ResumeLayout(False)
        Me.panelService.ResumeLayout(False)
        Me.panelAppointment.ResumeLayout(False)
        Me.panelAdmin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As Panel
    Friend WithEvents panelMenu As Panel
    Friend WithEvents services As Button
    Friend WithEvents panelAppointment As Panel
    Friend WithEvents bookingActions As Button
    Friend WithEvents viewAppointments As Button
    Friend WithEvents appointmentManagement As Button
    Friend WithEvents panelAdmin As Panel
    Friend WithEvents quickstats As Button
    Friend WithEvents dailyOverview As Button
    Friend WithEvents adminDashboard As Button
    Friend WithEvents panelLogo As Panel
    Friend WithEvents panelStaff As Panel
    Friend WithEvents staffpef As Button
    Friend WithEvents addnewStaff As Button
    Friend WithEvents stafflist As Button
    Friend WithEvents staff As Button
    Friend WithEvents panelService As Panel
    Friend WithEvents editDeleteService As Button
    Friend WithEvents addService As Button
    Friend WithEvents servicelist As Button
    Friend WithEvents panelAdminProf As Panel
    Friend WithEvents adminProfile As Button
    Friend WithEvents panelCustomerSupport As Panel
    Friend WithEvents reviewMode As Button
    Friend WithEvents faqManagement As Button
    Friend WithEvents customerInquiries As Button
    Friend WithEvents support As Button
    Friend WithEvents panelPayment As Panel
    Friend WithEvents generateReceipts As Button
    Friend WithEvents paymentRecords As Button
    Friend WithEvents payments As Button
    Friend WithEvents panelInventory As Panel
    Friend WithEvents usageLogs As Button
    Friend WithEvents addNewItems As Button
    Friend WithEvents inventoryList As Button
    Friend WithEvents inventory As Button
    Friend WithEvents panelFinancial As Panel
    Friend WithEvents salesrep As Button
    Friend WithEvents expenseTrack As Button
    Friend WithEvents finance As Button
    Friend WithEvents logout As Button
    Friend WithEvents adminUpdate As Button
    Friend WithEvents panelChildForm As Panel
    Friend WithEvents manageCustomersBtn As Button
    Friend WithEvents alerts As Button
End Class
