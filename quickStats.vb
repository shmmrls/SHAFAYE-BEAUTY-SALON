Imports System.Data
Imports MySql.Data.MySqlClient

'calculates and displays monthly revenue
Public Class quickStats
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=salon_admin;Pwd=AdminSalon2025!;"

    Private Sub quickStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMonthlyClientData()
        LoadMonthlyRevenueData()
    End Sub

    Private Sub LoadMonthlyClientData()
        Try
            pnlTotalClientsCard.Controls.Clear()
            pnlTotalClientsCard.AutoScroll = True

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "
                    SELECT DISTINCT
                        ur.user_id,
                        ur.first_name,
                        ur.last_name,
                        up.email,
                        up.phone,
                        up.date_of_birth,
                        COUNT(a.appointment_id) as total_transactions
                    FROM user_register ur
                    LEFT JOIN user_profiles up ON ur.user_id = up.user_id
                    LEFT JOIN appointments a ON ur.user_id = a.user_id 
                        AND MONTH(a.appointment_date) = MONTH(CURDATE()) 
                        AND YEAR(a.appointment_date) = YEAR(CURDATE())
                    WHERE ur.role = 'user'
                        AND EXISTS (
                            SELECT 1 FROM appointments a2 
                            WHERE a2.user_id = ur.user_id 
                            AND MONTH(a2.appointment_date) = MONTH(CURDATE()) 
                            AND YEAR(a2.appointment_date) = YEAR(CURDATE())
                        )
                    GROUP BY ur.user_id, ur.first_name, ur.last_name, up.email, up.phone, up.date_of_birth
                    ORDER BY ur.first_name, ur.last_name"

                Dim clientCount As Integer = 0
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim yPosition As Integer = 10

                        While reader.Read()
                            clientCount += 1
                            Dim clientCard As Panel = CreateClientCard(
                                reader("user_id").ToString(),
                                reader("first_name").ToString(),
                                reader("last_name").ToString(),
                                If(IsDBNull(reader("email")), "N/A", reader("email").ToString()),
                                If(IsDBNull(reader("phone")), "N/A", reader("phone").ToString()),
                                If(IsDBNull(reader("date_of_birth")), Nothing, Convert.ToDateTime(reader("date_of_birth"))),
                                Convert.ToInt32(reader("total_transactions"))
                            )

                            clientCard.Location = New Point(10, yPosition)
                            pnlTotalClientsCard.Controls.Add(clientCard)
                            yPosition += clientCard.Height + 10
                        End While
                    End Using
                End Using

                lblClientsTitle.Text = $"Total Clients: {clientCount}"

                If clientCount = 0 Then
                    Dim noClientsLabel As New Label()
                    noClientsLabel.Text = "No clients found for this month"
                    noClientsLabel.ForeColor = Color.Gray
                    noClientsLabel.Font = New Font("Segoe UI", 12, FontStyle.Italic)
                    noClientsLabel.AutoSize = True
                    noClientsLabel.Location = New Point(20, 20)
                    pnlTotalClientsCard.Controls.Add(noClientsLabel)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error loading client data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblClientsTitle.Text = "Total Clients: 0"
        End Try
    End Sub

    Private Sub LoadMonthlyRevenueData()
        Try
            pnlRevenueCard.Controls.Clear()

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim revenueQuery As String = "
                    SELECT IFNULL(SUM(s.price), 0) as monthly_revenue
                    FROM appointments a
                    INNER JOIN appointment_services aps ON a.appointment_id = aps.appointment_id
                    INNER JOIN services s ON aps.service_id = s.service_id
                    WHERE MONTH(a.appointment_date) = MONTH(CURDATE()) 
                    AND YEAR(a.appointment_date) = YEAR(CURDATE())
                    AND a.status = 'Completed'"


                Dim monthlyRevenue As Decimal = 0
                Using command As New MySqlCommand(revenueQuery, connection)
                    Dim result = command.ExecuteScalar()
                    monthlyRevenue = If(result IsNot Nothing AndAlso Not IsDBNull(result), Convert.ToDecimal(result), 0)
                End Using

                lblMonthlyRevenue.Text = $"Monthly Revenue: ₱{monthlyRevenue:N2}"

                Dim revenueCard As Panel = CreateRevenueCard(monthlyRevenue, connection)
                pnlRevenueCard.Controls.Add(revenueCard)
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error loading revenue data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblMonthlyRevenue.Text = "Monthly Revenue: ₱0.00"
        End Try
    End Sub

    Private Function CreateClientCard(userId As String, firstName As String, lastName As String, email As String, phone As String, dateOfBirth As DateTime?, totalTransactions As Integer) As Panel
        Dim card As New Panel()
        card.Size = New Size(pnlTotalClientsCard.Width - 30, 140)
        card.BorderStyle = BorderStyle.FixedSingle
        card.BackColor = Color.White
        card.Margin = New Padding(5)

        Dim lblName As New Label()
        lblName.Text = $"{firstName} {lastName}"
        lblName.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        lblName.ForeColor = Color.FromArgb(77, 0, 18)
        lblName.Location = New Point(10, 8)
        lblName.Size = New Size(250, 25)
        card.Controls.Add(lblName)

        Dim lblTransactions As New Label()
        lblTransactions.Text = $"Transactions: {totalTransactions}"
        lblTransactions.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblTransactions.ForeColor = Color.FromArgb(255, 128, 128)
        lblTransactions.Location = New Point(pnlTotalClientsCard.Width - 150, 8)
        lblTransactions.AutoSize = True
        card.Controls.Add(lblTransactions)

        Dim lblEmail As New Label()
        lblEmail.Text = $"Email: {email}"
        lblEmail.Font = New Font("Segoe UI", 9)
        lblEmail.Location = New Point(10, 35)
        lblEmail.Size = New Size(330, 20)
        card.Controls.Add(lblEmail)

        Dim lblPhone As New Label()
        lblPhone.Text = $"Phone: {phone}"
        lblPhone.Font = New Font("Segoe UI", 9)
        lblPhone.Location = New Point(10, 55)
        lblPhone.Size = New Size(200, 20)
        card.Controls.Add(lblPhone)

        Dim lblDOB As New Label()
        Dim dobText As String = If(dateOfBirth.HasValue, dateOfBirth.Value.ToString("MMM dd, yyyy"), "N/A")
        lblDOB.Text = $"DOB: {dobText}"
        lblDOB.Font = New Font("Segoe UI", 9)
        lblDOB.Location = New Point(10, 75)
        lblDOB.Size = New Size(200, 20)
        card.Controls.Add(lblDOB)

        Dim lblUserId As New Label()
        lblUserId.Text = $"Client ID: {userId}"
        lblUserId.Font = New Font("Segoe UI", 8, FontStyle.Italic)
        lblUserId.ForeColor = Color.Gray
        lblUserId.Location = New Point(10, 95)
        lblUserId.AutoSize = True
        card.Controls.Add(lblUserId)

        Dim lblStatus As New Label()
        lblStatus.Text = "ACTIVE CLIENT"
        lblStatus.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblStatus.ForeColor = Color.Green
        lblStatus.Location = New Point(10, 115)
        lblStatus.AutoSize = True
        card.Controls.Add(lblStatus)

        Return card
    End Function

    Private Function CreateRevenueCard(monthlyRevenue As Decimal, connection As MySqlConnection) As Panel
        Dim card As New Panel()
        card.Size = New Size(pnlRevenueCard.Width - 30, 200)
        card.BorderStyle = BorderStyle.FixedSingle
        card.BackColor = Color.White
        card.Margin = New Padding(5)
        card.Location = New Point(10, 10)

        Dim lblTitle As New Label()
        lblTitle.Text = $"{DateTime.Now.ToString("MMMM yyyy")} Revenue Overview"
        lblTitle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(77, 0, 18)
        lblTitle.Location = New Point(15, 10)
        lblTitle.AutoSize = True
        card.Controls.Add(lblTitle)

        Dim lblTotal As New Label()
        lblTotal.Text = $"₱{monthlyRevenue:N2}"
        lblTotal.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(255, 128, 128)
        lblTotal.Location = New Point(15, 35)
        lblTotal.AutoSize = True
        card.Controls.Add(lblTotal)

        Try
            Dim completedQuery As String = "
                SELECT COUNT(DISTINCT a.appointment_id) as completed_count
                FROM appointments a
                WHERE MONTH(a.appointment_date) = MONTH(CURDATE()) 
                AND YEAR(a.appointment_date) = YEAR(CURDATE())
                AND a.status = 'Completed'"

            Using command As New MySqlCommand(completedQuery, connection)
                Dim completedCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                Dim lblCompleted As New Label()
                lblCompleted.Text = $"Completed Appointments: {completedCount}"
                lblCompleted.Font = New Font("Segoe UI", 10)
                lblCompleted.Location = New Point(15, 70)
                lblCompleted.AutoSize = True
                card.Controls.Add(lblCompleted)
            End Using

            If monthlyRevenue > 0 Then
                Dim avgQuery As String = "
                    SELECT COUNT(DISTINCT a.appointment_id) as total_appointments
                    FROM appointments a
                    WHERE MONTH(a.appointment_date) = MONTH(CURDATE()) 
                    AND YEAR(a.appointment_date) = YEAR(CURDATE())
                    AND a.status = 'Completed'"

                Using command As New MySqlCommand(avgQuery, connection)
                    Dim totalAppointments As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If totalAppointments > 0 Then
                        Dim avgRevenue As Decimal = monthlyRevenue / totalAppointments

                        Dim lblAverage As New Label()
                        lblAverage.Text = $"Average per Appointment: ₱{avgRevenue:N2}"
                        lblAverage.Font = New Font("Segoe UI", 10)
                        lblAverage.Location = New Point(15, 95)
                        lblAverage.AutoSize = True
                        card.Controls.Add(lblAverage)
                    End If
                End Using
            End If

        Catch ex As Exception
        End Try

        Dim lblUpdated As New Label()
        lblUpdated.Text = $"Last Updated: {DateTime.Now.ToString("MMM dd, yyyy HH:mm")}"
        lblUpdated.Font = New Font("Segoe UI", 8, FontStyle.Italic)
        lblUpdated.ForeColor = Color.Gray
        lblUpdated.Location = New Point(15, 170)
        lblUpdated.AutoSize = True
        card.Controls.Add(lblUpdated)

        Return card
    End Function

    Public Sub RefreshData()
        LoadMonthlyClientData()
        LoadMonthlyRevenueData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub
End Class