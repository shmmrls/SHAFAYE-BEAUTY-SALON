Imports System.Data
Imports MySql.Data.MySqlClient

'FOR DASHBOARD (DAILY OVERVIEW OF OPERATIONS)
'The system shall display the current day’s total revenue and list all pending appointments with their details.


Public Class dailyoverview
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=root;Pwd=;"

    Private Sub dailyoverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateRevenueLabel()
        UpdateTodaysRevenue()
        LoadTodaysPendingBookings()
    End Sub

    Private Sub UpdateRevenueLabel()

        lblRevenue.Text = $"Revenue as of {DateTime.Now.ToString("MMMM dd, yyyy")}"
    End Sub

    Private Sub UpdateTodaysRevenue()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "
                SELECT SUM(s.price) as total_revenue
                FROM appointments a
                INNER JOIN appointment_services aps ON a.appointment_id = aps.appointment_id
                INNER JOIN services s ON aps.service_id = s.service_id
                WHERE DATE(a.appointment_date) <= CURDATE()
                AND a.status = 'Completed'"

                Using command As New MySqlCommand(query, connection)
                    Dim result = command.ExecuteScalar()
                    Dim totalRevenue As Decimal

                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        totalRevenue = Convert.ToDecimal(result)
                    Else
                        totalRevenue = 0
                    End If

                    todaysRevenueLbl.Text = $"₱{totalRevenue:N2}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating revenue: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            todaysRevenueLbl.Text = "₱0.00"
        End Try
    End Sub



    Private Sub LoadTodaysPendingBookings()
        Try
            flowBookings.Controls.Clear()

            Using connection As New MySqlConnection(connectionString)
                connection.Open()


                Dim query As String = "
                    SELECT DISTINCT
                        a.appointment_id,
                        a.appointment_time,
                        CONCAT(ur.first_name, ' ', ur.last_name) as customer_name,
                        GROUP_CONCAT(s.name SEPARATOR ', ') as services,
                        SUM(s.price) as total_amount
                    FROM appointments a
                    INNER JOIN user_register ur ON a.user_id = ur.user_id
                    INNER JOIN appointment_services aps ON a.appointment_id = aps.appointment_id
                    INNER JOIN services s ON aps.service_id = s.service_id
                    WHERE DATE(a.appointment_date) = CURDATE() 
                    AND a.status = 'Pending'
                    GROUP BY a.appointment_id, a.appointment_time, ur.first_name, ur.last_name
                    ORDER BY a.appointment_time"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim bookingPanel As Panel = CreateBookingPanel(
                                reader("appointment_id").ToString(),
                                reader("appointment_time").ToString(),
                                reader("customer_name").ToString(),
                                reader("services").ToString(),
                                Convert.ToDecimal(reader("total_amount"))
                            )
                            flowBookings.Controls.Add(bookingPanel)
                        End While
                    End Using
                End Using
            End Using


            If flowBookings.Controls.Count = 0 Then
                Dim noBookingsLabel As New Label()
                noBookingsLabel.Text = "No pending bookings for today"
                noBookingsLabel.ForeColor = Color.Gray
                noBookingsLabel.Font = New Font("Segoe UI", 10, FontStyle.Italic)
                noBookingsLabel.AutoSize = True
                noBookingsLabel.Margin = New Padding(10)
                flowBookings.Controls.Add(noBookingsLabel)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error loading pending bookings: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CreateBookingPanel(appointmentId As String, appointmentTime As String, customerName As String, services As String, totalAmount As Decimal) As Panel
        Dim panel As New Panel()
        panel.Size = New Size(flowBookings.Width - 30, 120)
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.BackColor = Color.White
        panel.Margin = New Padding(5)


        Dim lblAppointmentId As New Label()
        lblAppointmentId.Text = $"Appointment #{appointmentId}"
        lblAppointmentId.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblAppointmentId.ForeColor = Color.FromArgb(77, 0, 18)
        lblAppointmentId.Location = New Point(10, 8)
        lblAppointmentId.AutoSize = True
        panel.Controls.Add(lblAppointmentId)


        Dim lblTime As New Label()
        lblTime.Text = $"Time: {appointmentTime}"
        lblTime.Font = New Font("Segoe UI", 9)
        lblTime.Location = New Point(10, 28)
        lblTime.AutoSize = True
        panel.Controls.Add(lblTime)


        Dim lblCustomer As New Label()
        lblCustomer.Text = $"Customer: {customerName}"
        lblCustomer.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblCustomer.Location = New Point(10, 48)
        lblCustomer.AutoSize = True
        panel.Controls.Add(lblCustomer)


        Dim lblServices As New Label()
        lblServices.Text = $"Services: {services}"
        lblServices.Font = New Font("Segoe UI", 8)
        lblServices.Location = New Point(10, 68)
        lblServices.Size = New Size(380, 20)
        lblServices.ForeColor = Color.DarkGreen
        panel.Controls.Add(lblServices)


        Dim lblAmount As New Label()
        lblAmount.Text = $"Total: ₱{totalAmount:N2}"
        lblAmount.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblAmount.ForeColor = Color.Red
        lblAmount.Location = New Point(10, 88)
        lblAmount.AutoSize = True
        panel.Controls.Add(lblAmount)


        Dim lblStatus As New Label()
        lblStatus.Text = "PENDING"
        lblStatus.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblStatus.ForeColor = Color.Orange
        lblStatus.Location = New Point(420, 8)
        lblStatus.AutoSize = True
        panel.Controls.Add(lblStatus)

        Return panel
    End Function


    Public Sub RefreshData()
        UpdateRevenueLabel()
        UpdateTodaysRevenue()
        LoadTodaysPendingBookings()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub
End Class