Imports MySql.Data.MySqlClient
Imports System.Drawing

'FOR FINANCIAL MANAGEMENT
'Allow admin/staff to view, filter, and generate summarized views of payment records based on date and
'service category
'Added DELETE functionality for admins to remove incorrect or duplicate payment records
Public Class paymentRecords
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=salon_admin;Pwd=AdminSalon2025!;"

    Private Sub genReceipts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServiceCategories()
        LoadAllPaymentLogs()
    End Sub

    Private Sub LoadServiceCategories()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query = "SELECT category_id, name FROM service_categories ORDER BY name"

                Using command As New MySqlCommand(query, connection)
                    Using reader = command.ExecuteReader()
                        cmbServiceCateg.Items.Clear()
                        cmbServiceCateg.Items.Add(New With {.Value = 0, .Text = "All Categories"})

                        While reader.Read()
                            cmbServiceCateg.Items.Add(New With {
                                .Value = reader("category_id"),
                                .Text = reader("name").ToString()
                            })
                        End While
                    End Using
                End Using
            End Using

            cmbServiceCateg.DisplayMember = "Text"
            cmbServiceCateg.ValueMember = "Value"
            cmbServiceCateg.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error loading service categories: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadAllPaymentLogs()
        LoadPaymentLogs("", "")
    End Sub

    Private Sub LoadPaymentLogs(dateFilter As String, categoryFilter As String)
        Try
            panelPaymentLogs.Controls.Clear()
            panelPaymentLogs.AutoScroll = True

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim baseQuery = "SELECT p.payment_id, p.appointment_id, p.payment_date, p.payment_type, p.payment_status, " &
                "CONCAT(u.first_name, ' ', u.last_name) AS customer_name, " &
                "GROUP_CONCAT(DISTINCT s.name SEPARATOR ', ') AS services, " &
                "GROUP_CONCAT(DISTINCT sc.name SEPARATOR ', ') AS categories, " &
                "SUM(s.price) AS total_amount " &
                "FROM payments p " &
                "JOIN appointments a ON p.appointment_id = a.appointment_id " &
                "JOIN user_register u ON a.user_id = u.user_id " &
                "JOIN appointment_services aps ON a.appointment_id = aps.appointment_id " &
                "JOIN services s ON aps.service_id = s.service_id " &
                "JOIN service_categories sc ON s.category_id = sc.category_id " &
                "WHERE 1=1 "

                If Not String.IsNullOrEmpty(dateFilter) Then
                    baseQuery += dateFilter
                End If

                If Not String.IsNullOrEmpty(categoryFilter) Then
                    baseQuery += categoryFilter
                End If

                baseQuery += " GROUP BY p.payment_id ORDER BY p.payment_date DESC, p.payment_id DESC"

                Using command As New MySqlCommand(baseQuery, connection)
                    If Not String.IsNullOrEmpty(categoryFilter) AndAlso cmbServiceCateg.SelectedValue IsNot Nothing Then
                        Dim selectedCategoryId = Convert.ToInt32(cmbServiceCateg.SelectedValue)
                        If selectedCategoryId > 0 Then
                            command.Parameters.AddWithValue("@categoryId", selectedCategoryId)
                        End If
                    End If

                    Using reader = command.ExecuteReader()
                        Dim yPosition As Integer = 10
                        Dim recordCount As Integer = 0

                        While reader.Read()
                            CreatePaymentLogCard(reader, yPosition)
                            yPosition += 200 ' Increased height to accommodate delete button
                            recordCount += 1
                        End While

                        If recordCount = 0 Then
                            Dim noDataLabel As New Label()
                            noDataLabel.Text = "No payment logs found for the selected criteria."
                            noDataLabel.Font = New Font("Arial", 12, FontStyle.Italic)
                            noDataLabel.ForeColor = Color.FromArgb(255, 128, 128)
                            noDataLabel.Location = New Point(20, 20)
                            noDataLabel.Size = New Size(400, 30)
                            panelPaymentLogs.Controls.Add(noDataLabel)
                        Else
                            Me.Text = $"Payment Logs - {recordCount} records found"
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading payment logs: " & ex.Message)
        End Try
    End Sub

    Private Sub CreatePaymentLogCard(reader As MySqlDataReader, yPosition As Integer)
        Dim cardPanel As New Panel()
        cardPanel.Location = New Point(10, yPosition)
        cardPanel.Size = New Size(panelPaymentLogs.Width - 30, 200) ' Increased height
        cardPanel.BorderStyle = BorderStyle.FixedSingle
        cardPanel.BackColor = Color.White


        cardPanel.Tag = reader("payment_id")

        Dim headerLabel As New Label()
        headerLabel.Text = $"Receipt #{reader("payment_id")} - {Convert.ToDateTime(reader("payment_date")):MMM dd, yyyy}"
        headerLabel.Font = New Font("Arial", 12, FontStyle.Bold)
        headerLabel.ForeColor = Color.FromArgb(77, 0, 18)
        headerLabel.Location = New Point(10, 10)
        headerLabel.Size = New Size(400, 25)
        cardPanel.Controls.Add(headerLabel)

        Dim statusLabel As New Label()
        statusLabel.Text = reader("payment_status").ToString()
        statusLabel.Font = New Font("Arial", 9, FontStyle.Bold)
        statusLabel.Location = New Point(cardPanel.Width - 100, 10)
        statusLabel.Size = New Size(80, 20)
        statusLabel.TextAlign = ContentAlignment.MiddleCenter
        If reader("payment_status").ToString() = "Paid" Then
            statusLabel.BackColor = Color.LightGreen
            statusLabel.ForeColor = Color.DarkGreen
        Else
            statusLabel.BackColor = Color.LightCoral
            statusLabel.ForeColor = Color.DarkRed
        End If
        cardPanel.Controls.Add(statusLabel)

        Dim customerLabel As New Label()
        customerLabel.Text = $"Customer: {reader("customer_name")}"
        customerLabel.Font = New Font("Arial", 10, FontStyle.Regular)
        customerLabel.ForeColor = Color.Black
        customerLabel.Location = New Point(10, 40)
        customerLabel.Size = New Size(300, 20)
        cardPanel.Controls.Add(customerLabel)

        Dim paymentTypeLabel As New Label()
        paymentTypeLabel.Text = $"Payment Type: {reader("payment_type")}"
        paymentTypeLabel.Font = New Font("Arial", 10, FontStyle.Regular)
        paymentTypeLabel.ForeColor = Color.Black
        paymentTypeLabel.Location = New Point(10, 90)
        paymentTypeLabel.Size = New Size(150, 20)
        cardPanel.Controls.Add(paymentTypeLabel)

        Dim servicesLabel As New Label()
        servicesLabel.Text = $"Services: {reader("services")}"
        servicesLabel.Font = New Font("Arial", 10, FontStyle.Regular)
        servicesLabel.ForeColor = Color.Black
        servicesLabel.Location = New Point(10, 65)
        servicesLabel.Size = New Size(cardPanel.Width - 20, 40)
        servicesLabel.AutoEllipsis = True
        cardPanel.Controls.Add(servicesLabel)

        Dim categoriesLabel As New Label()
        categoriesLabel.Text = $"Categories: {reader("categories")}"
        categoriesLabel.Font = New Font("Arial", 10, FontStyle.Italic)
        categoriesLabel.ForeColor = Color.FromArgb(255, 128, 128)
        categoriesLabel.Location = New Point(10, 120)
        categoriesLabel.Size = New Size(300, 20)
        cardPanel.Controls.Add(categoriesLabel)

        Dim totalAmount As Decimal = If(IsDBNull(reader("total_amount")) OrElse reader("total_amount").ToString() = "", 0D, Convert.ToDecimal(reader("total_amount")))

        Dim amountLabel As New Label()
        amountLabel.Text = $"Total: ₱{totalAmount:N2}"
        amountLabel.Font = New Font("Arial", 12, FontStyle.Bold)
        amountLabel.ForeColor = Color.FromArgb(77, 0, 18)
        amountLabel.Location = New Point(cardPanel.Width - 190, 110)
        amountLabel.Size = New Size(170, 25)
        amountLabel.TextAlign = ContentAlignment.MiddleRight
        amountLabel.AutoSize = False
        amountLabel.BorderStyle = BorderStyle.None
        cardPanel.Controls.Add(amountLabel)

        Dim appointmentLabel As New Label()
        appointmentLabel.Text = $"Appointment ID: {reader("appointment_id")}"
        appointmentLabel.Font = New Font("Arial", 8, FontStyle.Regular)
        appointmentLabel.ForeColor = Color.FromArgb(255, 128, 128)
        appointmentLabel.Location = New Point(10, 150)
        appointmentLabel.Size = New Size(150, 15)
        cardPanel.Controls.Add(appointmentLabel)


        Dim deleteButton As New Button()
        deleteButton.Text = "Delete"
        deleteButton.Font = New Font("Arial", 9, FontStyle.Bold)
        deleteButton.BackColor = Color.FromArgb(220, 53, 69)
        deleteButton.ForeColor = Color.White
        deleteButton.FlatStyle = FlatStyle.Popup
        deleteButton.FlatAppearance.BorderSize = 0
        deleteButton.Location = New Point(cardPanel.Width - 80, 140)
        deleteButton.Size = New Size(60, 20)
        deleteButton.Cursor = Cursors.Hand
        deleteButton.Tag = reader("payment_id")
        AddHandler deleteButton.Click, AddressOf DeleteButton_Click
        cardPanel.Controls.Add(deleteButton)

        panelPaymentLogs.Controls.Add(cardPanel)
    End Sub


    Private Sub DeleteButton_Click(sender As Object, e As EventArgs)
        Dim deleteButton As Button = DirectCast(sender, Button)
        Dim paymentId As Integer = Convert.ToInt32(deleteButton.Tag)


        Dim result As DialogResult = MessageBox.Show(
            $"Are you sure you want to delete payment record #{paymentId}?" & vbNewLine & vbNewLine &
            "This action cannot be undone and will permanently remove this payment record from the system.",
            "Confirm Delete Payment Record",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2
        )

        If result = DialogResult.Yes Then
            DeletePaymentRecord(paymentId)
        End If
    End Sub


    Private Sub DeletePaymentRecord(paymentId As Integer)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()


                Using transaction = connection.BeginTransaction()
                    Try

                        Dim deleteQuery = "DELETE FROM payments WHERE payment_id = @paymentId"
                        Using command As New MySqlCommand(deleteQuery, connection, transaction)
                            command.Parameters.AddWithValue("@paymentId", paymentId)
                            Dim rowsAffected = command.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                transaction.Commit()
                                MessageBox.Show($"Payment record #{paymentId} has been successfully deleted.",
                                              "Delete Successful",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Information)

                                ' Refresh the payment logs display
                                LoadAllPaymentLogs()
                            Else
                                transaction.Rollback()
                                MessageBox.Show("Payment record not found or could not be deleted.",
                                              "Delete Failed",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error)
                            End If
                        End Using
                    Catch ex As Exception
                        transaction.Rollback()
                        Throw ex
                    End Try
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error deleting payment record: {ex.Message}",
                          "Delete Error",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        Dim currentMonth = DateTime.Now.Month
        Dim currentYear = DateTime.Now.Year
        Dim dateFilter = $" AND MONTH(p.payment_date) = {currentMonth} AND YEAR(p.payment_date) = {currentYear} "

        Dim categoryFilter = ""
        If cmbServiceCateg.SelectedValue IsNot Nothing Then
            Dim selectedCategoryId = Convert.ToInt32(cmbServiceCateg.SelectedValue)
            If selectedCategoryId > 0 Then
                categoryFilter = " AND sc.category_id = " & selectedCategoryId
            End If
        End If

        LoadPaymentLogs(dateFilter, categoryFilter)
    End Sub

    Private Sub btnAnnually_Click(sender As Object, e As EventArgs) Handles btnAnnually.Click
        Dim currentYear = DateTime.Now.Year
        Dim dateFilter = $" AND YEAR(p.payment_date) = {currentYear} "

        Dim categoryFilter = ""
        If cmbServiceCateg.SelectedValue IsNot Nothing Then
            Dim selectedCategoryId = Convert.ToInt32(cmbServiceCateg.SelectedValue)
            If selectedCategoryId > 0 Then
                categoryFilter = " AND sc.category_id = " & selectedCategoryId
            End If
        End If

        LoadPaymentLogs(dateFilter, categoryFilter)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cmbServiceCateg.SelectedIndex = 0
        LoadAllPaymentLogs()
        Me.Text = "Payment Logs - All Records"
    End Sub

    Private Sub cmbServiceCateg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServiceCateg.SelectedIndexChanged

        Try
            If cmbServiceCateg.SelectedItem IsNot Nothing Then
                Dim selectedItem = cmbServiceCateg.SelectedItem
                Dim selectedCategoryId As Integer = 0


                If TypeOf selectedItem Is Object AndAlso selectedItem.GetType().GetProperty("Value") IsNot Nothing Then
                    selectedCategoryId = Convert.ToInt32(selectedItem.Value)
                End If


                Dim categoryFilter = ""
                If selectedCategoryId > 0 Then
                    categoryFilter = " AND sc.category_id = " & selectedCategoryId
                End If

                LoadPaymentLogs("", categoryFilter)
            End If
        Catch ex As Exception
            MessageBox.Show("Error in category selection: " & ex.Message)
        End Try
    End Sub

    Private Sub panelPaymentLogs_Resize(sender As Object, e As EventArgs) Handles panelPaymentLogs.Resize
        For Each control As Control In panelPaymentLogs.Controls
            If TypeOf control Is Panel Then
                control.Width = panelPaymentLogs.Width - 30

                For Each childControl As Control In control.Controls
                    If TypeOf childControl Is Button AndAlso childControl.Text = "Delete" Then
                        childControl.Location = New Point(control.Width - 80, 160)
                    End If
                Next
            End If
        Next
    End Sub

End Class