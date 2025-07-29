Imports MySql.Data.MySqlClient

Public Class WalkInBookingForm
    Dim conn As New MySqlConnection("Server=localhost;Database=final_shafaye_salon;Uid=salon_admin;Pwd=AdminSalon2025!;")
    Private selectedServices As New List(Of Integer)()
    Private servicePrices As New Dictionary(Of Integer, Decimal)()

    Private Sub WalkInBookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClients()
        LoadServices()

        ' Set default date and time to current
        dtpDate.Value = DateTime.Today
        dtpTime.Value = DateTime.Now

        ' Show info message
        lblClientInfo.Text = "Note: Only registered clients in the system can book walk-in appointments."
        lblClientInfo.ForeColor = Color.FromArgb(180, 0, 0)
    End Sub

    Private Sub LoadClients()
        cboClient.Items.Clear()

        If conn.State = ConnectionState.Open Then conn.Close()

        Try
            conn.Open()
            Dim query As String = "SELECT user_id, CONCAT(first_name, ' ', last_name) AS full_name FROM user_register WHERE role = 'user' ORDER BY first_name"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                cboClient.Items.Add(New With {
                    .Value = reader("user_id"),
                    .Text = reader("full_name").ToString()
                })
            End While

        Catch ex As Exception
            MessageBox.Show("Error loading clients: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        cboClient.DisplayMember = "Text"
        cboClient.ValueMember = "Value"
    End Sub

    Private Sub LoadServices()
        clbServices.Items.Clear()
        servicePrices.Clear()

        If conn.State = ConnectionState.Open Then conn.Close()

        Try
            conn.Open()
            Dim query As String = "SELECT s.service_id, s.name, s.price, c.name AS category_name FROM services s JOIN service_categories c ON s.category_id = c.category_id WHERE s.is_available = 1 ORDER BY c.name, s.name"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim serviceId As Integer = Convert.ToInt32(reader("service_id"))
                Dim serviceName As String = reader("name").ToString()
                Dim price As Decimal = Convert.ToDecimal(reader("price"))
                Dim categoryName As String = reader("category_name").ToString()

                servicePrices(serviceId) = price
                clbServices.Items.Add(New With {
                    .Value = serviceId,
                    .Text = $"{categoryName} - {serviceName} (₱{price:F2})"
                })
            End While

        Catch ex As Exception
            MessageBox.Show("Error loading services: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

        clbServices.DisplayMember = "Text"
        clbServices.ValueMember = "Value"
    End Sub

    Private Sub clbServices_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbServices.ItemCheck
        ' Use BeginInvoke to handle the event after the check state has changed
        Me.BeginInvoke(New Action(AddressOf UpdateSelectedServices))
    End Sub

    Private Sub UpdateSelectedServices()
        selectedServices.Clear()
        lstSelectedServices.Items.Clear()
        Dim totalPrice As Decimal = 0

        For i As Integer = 0 To clbServices.Items.Count - 1
            If clbServices.GetItemChecked(i) Then
                Dim serviceItem = clbServices.Items(i)
                Dim serviceId As Integer = serviceItem.Value
                selectedServices.Add(serviceId)
                lstSelectedServices.Items.Add(serviceItem.Text)
                totalPrice += servicePrices(serviceId)
            End If
        Next

        lblTotal.Text = $"Total: ₱{totalPrice:F2}"
    End Sub

    Private Sub btnNewClient_Click(sender As Object, e As EventArgs) Handles btnNewClient.Click
        ' You can implement a new client registration form here
        MessageBox.Show("Please register the new client first in the user management system.", "New Client Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' After registering, reload clients
        ' LoadClients()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ' Validation
        If cboClient.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a client.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If selectedServices.Count = 0 Then
            MessageBox.Show("Please select at least one service.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm booking
        Dim totalPrice As Decimal = selectedServices.Sum(Function(id) servicePrices(id))
        Dim clientName As String = cboClient.SelectedItem.Text
        Dim serviceCount As Integer = selectedServices.Count

        Dim confirmMessage As String = $"Confirm Walk-in Booking:{vbCrLf}{vbCrLf}" &
                                      $"Client: {clientName}{vbCrLf}" &
                                      $"Date: {dtpDate.Value.ToShortDateString()}{vbCrLf}" &
                                      $"Time: {dtpTime.Value.ToShortTimeString()}{vbCrLf}" &
                                      $"Services: {serviceCount} selected{vbCrLf}" &
                                      $"Total: ₱{totalPrice:F2}{vbCrLf}{vbCrLf}" &
                                      $"This will be marked as COMPLETED and payment recorded immediately."

        Dim result As DialogResult = MessageBox.Show(confirmMessage, "Confirm Walk-in Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            CreateWalkInBooking()
        End If
    End Sub

    Private Sub CreateWalkInBooking()
        If conn.State = ConnectionState.Open Then conn.Close()

        Try
            conn.Open()
            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            Try
                Dim clientId As Integer = cboClient.SelectedItem.Value
                Dim appointmentDate As Date = dtpDate.Value.Date
                Dim appointmentTime As String = dtpTime.Value.ToString("hh:mm tt")

                ' 1. Insert appointment (already completed)
                Dim insertAppointmentQuery As String = "INSERT INTO appointments (user_id, appointment_date, appointment_time, status, created_at, inventory_deducted) VALUES (@userId, @date, @time, 'Completed', @created, 1)"
                Dim appointmentId As Integer

                Using cmd As New MySqlCommand(insertAppointmentQuery, conn, transaction)
                    cmd.Parameters.AddWithValue("@userId", clientId)
                    cmd.Parameters.AddWithValue("@date", appointmentDate)
                    cmd.Parameters.AddWithValue("@time", appointmentTime)
                    cmd.Parameters.AddWithValue("@created", DateTime.Now)
                    cmd.ExecuteNonQuery()
                    appointmentId = Convert.ToInt32(cmd.LastInsertedId)
                End Using

                ' 2. Insert appointment services with auto-assigned staff
                For Each serviceId As Integer In selectedServices
                    Dim staffId As Integer = GetAvailableStaff(serviceId, appointmentDate, appointmentTime, transaction)

                    Dim insertServiceQuery As String = "INSERT INTO appointment_services (appointment_id, service_id, staff_id) VALUES (@appointmentId, @serviceId, @staffId)"
                    Using cmd As New MySqlCommand(insertServiceQuery, conn, transaction)
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId)
                        cmd.Parameters.AddWithValue("@serviceId", serviceId)
                        cmd.Parameters.AddWithValue("@staffId", staffId)
                        cmd.ExecuteNonQuery()
                    End Using
                Next

                ' 3. Create payment record
                Dim insertPaymentQuery As String = "INSERT INTO payments (appointment_id, payment_date, payment_type, payment_status) VALUES (@appointmentId, @date, 'Cash', 'Paid')"
                Using cmd As New MySqlCommand(insertPaymentQuery, conn, transaction)
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId)
                    cmd.Parameters.AddWithValue("@date", appointmentDate)
                    cmd.ExecuteNonQuery()
                End Using

                ' 4. Deduct inventory
                DeductInventory(selectedServices, transaction)

                transaction.Commit()

                MessageBox.Show($"Walk-in booking created successfully!{vbCrLf}Appointment ID: {appointmentId}{vbCrLf}Status: Completed{vbCrLf}Payment: Recorded",
                               "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.DialogResult = DialogResult.OK
                adminMenu.OpenChildForm(New viewallbookings())
                Me.Close()

            Catch ex As Exception
                transaction.Rollback()
                Throw ex
            End Try

        Catch ex As Exception
            MessageBox.Show("Error creating walk-in booking: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Function GetAvailableStaff(serviceId As Integer, appointmentDate As Date, appointmentTime As String, transaction As MySqlTransaction) As Integer
        ' Get staff roles for this service
        Dim roleQuery As String = "SELECT DISTINCT role_name FROM service_staff_roles WHERE service_id = @serviceId"
        Dim availableRoles As New List(Of String)

        Using cmd As New MySqlCommand(roleQuery, conn, transaction)
            cmd.Parameters.AddWithValue("@serviceId", serviceId)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    availableRoles.Add(reader("role_name").ToString())
                End While
            End Using
        End Using

        ' Find available staff for these roles
        For Each role As String In availableRoles
            Dim staffQuery As String = "
                SELECT s.staff_id 
                FROM staff s 
                JOIN user_register u ON s.user_id = u.user_id 
                WHERE s.position = @role AND s.status = 'Active'
                AND s.staff_id NOT IN (
                    SELECT DISTINCT aps.staff_id 
                    FROM appointment_services aps 
                    JOIN appointments a ON aps.appointment_id = a.appointment_id 
                    WHERE a.appointment_date = @date 
                    AND a.appointment_time = @time 
                    AND a.status IN ('Pending', 'Approved', 'Completed')
                    AND aps.staff_id IS NOT NULL
                )
                LIMIT 1"

            Using cmd As New MySqlCommand(staffQuery, conn, transaction)
                cmd.Parameters.AddWithValue("@role", role)
                cmd.Parameters.AddWithValue("@date", appointmentDate)
                cmd.Parameters.AddWithValue("@time", appointmentTime)

                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                End If
            End Using
        Next

        ' If no available staff found, get the first staff member for any of the roles
        Dim fallbackQuery As String = "SELECT s.staff_id FROM staff s WHERE s.position = @role AND s.status = 'Active' LIMIT 1"
        Using cmd As New MySqlCommand(fallbackQuery, conn, transaction)
            cmd.Parameters.AddWithValue("@role", availableRoles.FirstOrDefault())
            Dim result = cmd.ExecuteScalar()
            Return If(result IsNot Nothing, Convert.ToInt32(result), 1) ' Default to staff_id 1 if none found
        End Using
    End Function

    Private Sub DeductInventory(serviceIds As List(Of Integer), transaction As MySqlTransaction)
        For Each serviceId As Integer In serviceIds
            Dim usageQuery As String = "SELECT item_id, quantity_used FROM inventory_usage WHERE service_id = @serviceId"
            Using cmd As New MySqlCommand(usageQuery, conn, transaction)
                cmd.Parameters.AddWithValue("@serviceId", serviceId)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    Dim deductions As New List(Of Tuple(Of Integer, Integer))
                    While reader.Read()
                        deductions.Add(Tuple.Create(Convert.ToInt32(reader("item_id")), Convert.ToInt32(reader("quantity_used"))))
                    End While
                    reader.Close()

                    For Each deduction In deductions
                        Dim deductQuery As String = "UPDATE inventory SET quantity = quantity - @qtyUsed WHERE item_id = @itemId"
                        Using deductCmd As New MySqlCommand(deductQuery, conn, transaction)
                            deductCmd.Parameters.AddWithValue("@qtyUsed", deduction.Item2)
                            deductCmd.Parameters.AddWithValue("@itemId", deduction.Item1)
                            deductCmd.ExecuteNonQuery()
                        End Using
                    Next
                End Using
            End Using
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        adminMenu.OpenChildForm(New dailyoverview())
        Me.Close()
    End Sub
End Class