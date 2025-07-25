Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Drawing2D

Public Class bookingactions
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=final_shafaye_salon")

    Private Sub bookingactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flowBookings.AutoScroll = True
        flowBookings.WrapContents = False
        flowBookings.FlowDirection = FlowDirection.TopDown
        flowBookings.HorizontalScroll.Enabled = False
        flowBookings.HorizontalScroll.Visible = False

        LoadBookings()
    End Sub

    Private Sub LoadBookings()
        flowBookings.Controls.Clear()
        If conn.State = ConnectionState.Open Then conn.Close()

        Dim query As String = "
        SELECT 
            a.appointment_id, 
            u.first_name, 
            u.last_name, 
            a.appointment_date, 
            a.appointment_time, 
            a.status,
            GROUP_CONCAT(DISTINCT sr.name ORDER BY sr.name SEPARATOR ', ') AS service_names,
            SUM(sr.price) AS total_price,
            GROUP_CONCAT(DISTINCT CONCAT(s.first_name, ' ', s.last_name) SEPARATOR ', ') AS staff_names
        FROM appointments a
        JOIN user_register u ON a.user_id = u.user_id
        JOIN appointment_services aps ON a.appointment_id = aps.appointment_id
        JOIN services sr ON aps.service_id = sr.service_id
        LEFT JOIN staff st ON aps.staff_id = st.staff_id
        LEFT JOIN user_register s ON st.user_id = s.user_id
        GROUP BY a.appointment_id, a.appointment_date, a.appointment_time, a.status, u.first_name, u.last_name
        ORDER BY a.appointment_date ASC, a.appointment_time ASC
    "

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            For Each row As DataRow In table.Rows
                ' Main panel
                Dim rowPanel As New Panel With {
                    .BackColor = Color.FromArgb(245, 247, 250),
                    .Width = flowBookings.ClientSize.Width,
                    .Height = 140,
                    .Anchor = AnchorStyles.Left Or AnchorStyles.Right,
                    .Margin = New Padding(0),
                    .BorderStyle = BorderStyle.None,
                    .MinimumSize = New Size(flowBookings.ClientSize.Width, 140)
                }
                rowPanel.Padding = New Padding(0)
                rowPanel.Region = New Region(New Rectangle(0, 0, rowPanel.Width, rowPanel.Height))

                ' TableLayoutPanel for even distribution
                Dim tableLayout As New TableLayoutPanel With {
                .Dock = DockStyle.Fill,
                .ColumnCount = 2,
                .RowCount = 1,
                .BackColor = Color.Transparent
            }
                tableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65))
                tableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35))
                tableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100))

                ' Panel for padding the details
                Dim detailsPanel As New Panel With {
                .Dock = DockStyle.Fill,
                .Padding = New Padding(24, 10, 24, 10),
                .BackColor = Color.Transparent
            }

                Dim detailsBox As New RichTextBox With {
                .ReadOnly = True,
                .Enabled = False, ' Prevents caret/cursor and selection
                .BorderStyle = BorderStyle.None,
                .BackColor = Color.White,
                .Font = New Font("Segoe UI", 12, FontStyle.Regular),
                .ForeColor = Color.FromArgb(40, 40, 40),
                .Dock = DockStyle.Fill,
                .TabStop = False,
                .ScrollBars = RichTextBoxScrollBars.None
            }

                detailsBox.Text = $"{row("first_name")} {row("last_name")}" & vbCrLf &
                $"Date: {Convert.ToDateTime(row("appointment_date")).ToString("MMMM dd, yyyy")}" & vbCrLf &
                $"Time: {row("appointment_time")}" & vbCrLf &
                $"Services: {row("service_names")}" & vbCrLf &
                $"Staff: {If(IsDBNull(row("staff_names")), "Not Assigned", row("staff_names"))}"
                BoldField(detailsBox, "Date:")
                BoldField(detailsBox, "Time:")
                BoldField(detailsBox, "Services:")
                BoldField(detailsBox, "Staff:")

                detailsPanel.Controls.Add(detailsBox)

                ' Right panel for actions
                Dim rightPanel As New Panel With {
                .Dock = DockStyle.Fill,
                .BackColor = Color.Transparent
            }

                ' Price label
                Dim lblPrice As New Label With {
                .Text = "₱" & Convert.ToDecimal(row("total_price")).ToString("N2"),
                .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                .ForeColor = Color.FromArgb(0, 153, 51),
                .AutoSize = True,
                .Location = New Point(0, 10)
            }
                rightPanel.Controls.Add(lblPrice)

                ' Status ComboBox
                Dim statusBox As New ComboBox With {
                .DropDownStyle = ComboBoxStyle.DropDownList,
                .Font = New Font("Segoe UI", 10),
                .Width = 110,
                .Location = New Point(0, 45),
                .FlatStyle = FlatStyle.Flat
            }
                statusBox.Items.AddRange(New String() {"Pending", "Approved", "Completed", "Cancelled"})
                statusBox.SelectedItem = row("status").ToString()
                rightPanel.Controls.Add(statusBox)

                ' Update Button
                Dim btnUpdate As New Button With {
                .Text = "UPDATE",
                .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                .Size = New Size(85, 30),
                .Location = New Point(120, 10),
                .BackColor = Color.White,
                .ForeColor = Color.FromArgb(77, 0, 18),
                .FlatStyle = FlatStyle.Flat,
                .Tag = New With {
                    Key .AppointmentID = row("appointment_id"),
                    Key .ComboBox = statusBox,
                    Key .CurrentStatus = row("status").ToString()
                }
            }
                btnUpdate.FlatAppearance.BorderSize = 0
                btnUpdate.Region = New Region(New Rectangle(0, 0, btnUpdate.Width, btnUpdate.Height))
                AddHandler btnUpdate.Click, AddressOf UpdateStatus_Click
                rightPanel.Controls.Add(btnUpdate)

                ' Details Button
                Dim btnDetails As New Button With {
                .Text = "DETAILS",
                .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                .Size = New Size(85, 30),
                .Location = New Point(120, 50),
                .BackColor = Color.FromArgb(77, 0, 18),
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat,
                .Tag = row("appointment_id")
            }
                btnDetails.FlatAppearance.BorderSize = 0
                btnDetails.Region = New Region(New Rectangle(0, 0, btnDetails.Width, btnDetails.Height))
                AddHandler btnDetails.Click, AddressOf ViewDetails_Click
                rightPanel.Controls.Add(btnDetails)

                ' Add controls to TableLayoutPanel
                tableLayout.Controls.Add(detailsPanel, 0, 0)
                tableLayout.Controls.Add(rightPanel, 1, 0)

                rowPanel.Controls.Add(tableLayout)
                flowBookings.Controls.Add(rowPanel)
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading bookings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Private Sub BoldField(rtb As RichTextBox, fieldName As String)
        Dim start As Integer = 0
        While start < rtb.Text.Length
            Dim idx As Integer = rtb.Text.IndexOf(fieldName, start, StringComparison.Ordinal)
            If idx = -1 Then Exit While
            rtb.Select(idx, fieldName.Length)
            rtb.SelectionFont = New Font(rtb.Font, FontStyle.Bold)
            start = idx + fieldName.Length
        End While
        rtb.Select(0, 0)
    End Sub


    Private Sub UpdateStatus_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim info = btn.Tag
        Dim appointmentID As Integer = info.AppointmentID
        Dim comboBox As ComboBox = info.ComboBox
        Dim newStatus As String = comboBox.SelectedItem.ToString()
        Dim currentStatus As String = info.CurrentStatus

        Dim result As DialogResult = MessageBox.Show(
            $"Are you sure you want to change the status to '{newStatus}'?",
            "Confirm Status Change",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.No Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()

        Try
            conn.Open()

            ' Start transaction to ensure data consistency
            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            Try
                ' Update appointment status
                Dim updateQuery As String = "UPDATE appointments SET status = @status WHERE appointment_id = @id"
                Using cmd As New MySqlCommand(updateQuery, conn, transaction)
                    cmd.Parameters.AddWithValue("@status", newStatus)
                    cmd.Parameters.AddWithValue("@id", appointmentID)
                    cmd.ExecuteNonQuery()
                End Using

                ' Handle payment record based on status change
                Select Case newStatus
                    Case "Approved"
                        ' Check if payment record already exists
                        Dim checkPaymentQuery As String = "SELECT COUNT(*) FROM payments WHERE appointment_id = @id"
                        Using checkCmd As New MySqlCommand(checkPaymentQuery, conn, transaction)
                            checkCmd.Parameters.AddWithValue("@id", appointmentID)
                            Dim paymentExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                            ' Only insert if payment record doesn't exist
                            If paymentExists = 0 Then
                                Dim insertPaymentQuery As String = "INSERT INTO payments (appointment_id, payment_date, payment_type, payment_status) VALUES (@id, @date, @type, @status)"
                                Using insertCmd As New MySqlCommand(insertPaymentQuery, conn, transaction)
                                    insertCmd.Parameters.AddWithValue("@id", appointmentID)
                                    insertCmd.Parameters.AddWithValue("@date", DateTime.Today)
                                    insertCmd.Parameters.AddWithValue("@type", "Cash")
                                    insertCmd.Parameters.AddWithValue("@status", "Paid")
                                    insertCmd.ExecuteNonQuery()
                                End Using
                            End If
                        End Using

                    Case "Cancelled"

                        Dim deletePaymentQuery As String = "DELETE FROM payments WHERE appointment_id = @id"
                        Using deleteCmd As New MySqlCommand(deletePaymentQuery, conn, transaction)
                            deleteCmd.Parameters.AddWithValue("@id", appointmentID)
                            deleteCmd.ExecuteNonQuery()
                        End Using

                    Case "Pending", "Completed"

                        If newStatus = "Pending" Then
                            Dim deletePaymentQuery As String = "DELETE FROM payments WHERE appointment_id = @id"
                            Using deleteCmd As New MySqlCommand(deletePaymentQuery, conn, transaction)
                                deleteCmd.Parameters.AddWithValue("@id", appointmentID)
                                deleteCmd.ExecuteNonQuery()
                            End Using
                        End If
                End Select

                ' Commit transaction
                transaction.Commit()

                MessageBox.Show("Status updated successfully!" &
                               If(newStatus = "Approved", vbCrLf & "Payment record created.", "") &
                               If(newStatus = "Cancelled", vbCrLf & "Payment record removed.", ""),
                               "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadBookings()

            Catch ex As Exception
                ' Rollback transaction on error
                transaction.Rollback()
                Throw ex
            End Try

        Catch ex As Exception
            MessageBox.Show("Error updating status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub ViewDetails_Click(sender As Object, e As EventArgs)

        Dim btn As Button = DirectCast(sender, Button)
        Dim appointmentID As Integer = Convert.ToInt32(btn.Tag)
        ShowAppointmentDetails(appointmentID)
    End Sub

    Private Sub ShowAppointmentDetails(appointmentID As Integer)

        If conn.State = ConnectionState.Open Then conn.Close()

        Try
            conn.Open()

            Dim detailsQuery As String = "
                SELECT 
                    a.appointment_id,
                    CONCAT(u.first_name, ' ', u.last_name) AS client_name,
                    a.appointment_date,
                    a.appointment_time,
                    a.status,
                    a.created_at
                FROM appointments a
                JOIN user_register u ON a.user_id = u.user_id
                WHERE a.appointment_id = @id
            "
            Dim cmd As New MySqlCommand(detailsQuery, conn)
            cmd.Parameters.AddWithValue("@id", appointmentID)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim detailsText As String = ""

            If reader.Read() Then
                detailsText = $"Appointment Details:" & vbCrLf & vbCrLf &
                             $"ID: {reader("appointment_id")}" & vbCrLf &
                             $"Client: {reader("client_name")}" & vbCrLf &
                             $"Date: {CDate(reader("appointment_date")).ToLongDateString()}" & vbCrLf &
                             $"Time: {reader("appointment_time")}" & vbCrLf &
                             $"Status: {reader("status")}" & vbCrLf &
                             $"Booked: {CDate(reader("created_at")).ToString()}" & vbCrLf & vbCrLf
            End If
            reader.Close()

            Dim servicesQuery As String = "
                SELECT 
                    s.name AS service_name,
                    s.price,
                    CONCAT(u.first_name, ' ', u.last_name) AS staff_name
                FROM appointment_services aps
                JOIN services s ON aps.service_id = s.service_id
                LEFT JOIN staff st ON aps.staff_id = st.staff_id
                LEFT JOIN user_register u ON st.user_id = u.user_id
                WHERE aps.appointment_id = @id
            "
            cmd = New MySqlCommand(servicesQuery, conn)
            cmd.Parameters.AddWithValue("@id", appointmentID)
            reader = cmd.ExecuteReader()

            detailsText &= "Services:" & vbCrLf
            Dim totalPrice As Decimal = 0

            While reader.Read()
                Dim serviceName As String = reader("service_name").ToString()
                Dim price As Decimal = Convert.ToDecimal(reader("price"))
                Dim staffName As String = If(IsDBNull(reader("staff_name")), "Not Assigned", reader("staff_name").ToString())
                detailsText &= $"• {serviceName} - ₱{price:F2} (Staff: {staffName})" & vbCrLf
                totalPrice += price
            End While

            detailsText &= vbCrLf & $"Total Amount: ₱{totalPrice:F2}"

            MessageBox.Show(detailsText, "Appointment Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error loading appointment details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
End Class