Imports System.Data
Imports MySql.Data.MySqlClient

Public Class staffperformance
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=salon_admin;Pwd=AdminSalon2025!;"

    Private Sub staffperformance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffPerformance()
    End Sub

    Private Sub LoadStaffPerformance()
        Try
            pnlStaffPerformance.Controls.Clear()
            pnlStaffPerformance.AutoScroll = True

            Using connection As New MySqlConnection(connectionString)
                connection.Open()


                Dim query As String = "
                    SELECT 
                        s.staff_id,
                        ur.first_name,
                        ur.last_name,
                        ur.username,
                        s.position,
                        s.salary,
                        s.status,
                        AVG(r.staff_rating) as avg_rating,
                        COUNT(r.review_id) as total_reviews,
                        COUNT(DISTINCT aps.appointment_id) as total_appointments,
                        GROUP_CONCAT(DISTINCT srv.name ORDER BY srv.name SEPARATOR ', ') as services_offered
                    FROM staff s
                    INNER JOIN user_register ur ON s.user_id = ur.user_id
                    LEFT JOIN reviews r ON s.staff_id = r.staff_id
                    LEFT JOIN appointment_services aps ON s.staff_id = aps.staff_id
                    LEFT JOIN services srv ON aps.service_id = srv.service_id
                    WHERE ur.role = 'staff' AND s.status = 'Active'
                    GROUP BY s.staff_id, ur.first_name, ur.last_name, ur.username, s.position, s.salary, s.status
                    ORDER BY ur.first_name, ur.last_name"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim xPosition As Integer = 10
                        Dim yPosition As Integer = 10
                        Dim cardsPerRow As Integer = 2 ' Adjust based on panel width
                        Dim cardCount As Integer = 0

                        While reader.Read()
                            Dim staffCard As Panel = CreateStaffCard(
                                reader("staff_id").ToString(),
                                reader("first_name").ToString(),
                                reader("last_name").ToString(),
                                reader("username").ToString(),
                                reader("position").ToString(),
                                If(IsDBNull(reader("salary")), 0, Convert.ToDecimal(reader("salary"))),
                                reader("status").ToString(),
                                If(IsDBNull(reader("avg_rating")), 0, Convert.ToDouble(reader("avg_rating"))),
                                Convert.ToInt32(reader("total_reviews")),
                                Convert.ToInt32(reader("total_appointments")),
                                If(IsDBNull(reader("services_offered")), "No services assigned", reader("services_offered").ToString())
                            )


                            staffCard.Location = New Point(xPosition, yPosition)
                            pnlStaffPerformance.Controls.Add(staffCard)

                            cardCount += 1
                            If cardCount Mod cardsPerRow = 0 Then

                                xPosition = 10
                                yPosition += staffCard.Height + 20
                            Else

                                xPosition += staffCard.Width + 46
                            End If
                        End While
                    End Using
                End Using


                If pnlStaffPerformance.Controls.Count = 0 Then
                    Dim noStaffLabel As New Label()
                    noStaffLabel.Text = "No active staff members found"
                    noStaffLabel.ForeColor = Color.Gray
                    noStaffLabel.Font = New Font("Segoe UI", 12, FontStyle.Italic)
                    noStaffLabel.AutoSize = True
                    noStaffLabel.Location = New Point(20, 20)
                    pnlStaffPerformance.Controls.Add(noStaffLabel)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error loading staff performance data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CreateStaffCard(staffId As String, firstName As String, lastName As String, username As String, position As String, salary As Decimal, status As String, avgRating As Double, totalReviews As Integer, totalAppointments As Integer, servicesOffered As String) As Panel
        Dim card As New Panel()
        card.Size = New Size(280, 350) ' Adjusted to fit 2 cards in 592px width panel
        card.BorderStyle = BorderStyle.FixedSingle
        card.BackColor = Color.White
        card.Margin = New Padding(5)


        Dim lblName As New Label()
        lblName.Text = $"{firstName} {lastName}"
        lblName.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        lblName.ForeColor = Color.FromArgb(77, 0, 18)
        lblName.Location = New Point(10, 8)
        lblName.Size = New Size(200, 25)
        card.Controls.Add(lblName)


        Dim lblStaffId As New Label()
        lblStaffId.Text = $"ID: {staffId}"
        lblStaffId.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblStaffId.ForeColor = Color.Gray
        lblStaffId.Location = New Point(220, 8)
        lblStaffId.AutoSize = True
        card.Controls.Add(lblStaffId)


        Dim lblUsername As New Label()
        lblUsername.Text = $"@{username}"
        lblUsername.Font = New Font("Segoe UI", 8, FontStyle.Italic)
        lblUsername.ForeColor = Color.Gray
        lblUsername.Location = New Point(10, 28)
        lblUsername.AutoSize = True
        card.Controls.Add(lblUsername)


        Dim lblPosition As New Label()
        lblPosition.Text = $"Position: {position}"
        lblPosition.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblPosition.ForeColor = Color.DarkGreen
        lblPosition.Location = New Point(10, 50)
        lblPosition.Size = New Size(250, 20)
        card.Controls.Add(lblPosition)


        Dim lblSalary As New Label()
        lblSalary.Text = $"Salary: ₱{salary:N2}"
        lblSalary.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblSalary.ForeColor = Color.FromArgb(255, 128, 128)
        lblSalary.Location = New Point(10, 75)
        lblSalary.AutoSize = True
        card.Controls.Add(lblSalary)


        Dim lblStatus As New Label()
        lblStatus.Text = status.ToUpper()
        lblStatus.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblStatus.ForeColor = If(status = "Active", Color.Green, Color.Red)
        lblStatus.Location = New Point(150, 75)
        lblStatus.AutoSize = True
        card.Controls.Add(lblStatus)


        Dim lblPerformanceHeader As New Label()
        lblPerformanceHeader.Text = "PERFORMANCE"
        lblPerformanceHeader.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblPerformanceHeader.ForeColor = Color.FromArgb(77, 0, 18)
        lblPerformanceHeader.Location = New Point(10, 100)
        lblPerformanceHeader.AutoSize = True
        card.Controls.Add(lblPerformanceHeader)


        Dim lblRating As New Label()
        Dim ratingText As String = If(totalReviews > 0, $"⭐ {avgRating:F1}/5.0", "⭐ No ratings yet")
        Dim ratingColor As Color = Color.Gray
        If totalReviews > 0 Then
            If avgRating >= 4.5 Then
                ratingColor = Color.Green
            ElseIf avgRating >= 3.0 Then
                ratingColor = Color.Orange
            Else
                ratingColor = Color.Red
            End If
        End If

        lblRating.Text = ratingText
        lblRating.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblRating.ForeColor = ratingColor
        lblRating.Location = New Point(10, 120)
        lblRating.AutoSize = True
        card.Controls.Add(lblRating)


        Dim lblReviews As New Label()
        lblReviews.Text = $"Reviews: {totalReviews}"
        lblReviews.Font = New Font("Segoe UI", 8)
        lblReviews.Location = New Point(10, 140)
        lblReviews.AutoSize = True
        card.Controls.Add(lblReviews)


        Dim lblAppointments As New Label()
        lblAppointments.Text = $"Appointments: {totalAppointments}"
        lblAppointments.Font = New Font("Segoe UI", 8)
        lblAppointments.Location = New Point(120, 140)
        lblAppointments.AutoSize = True
        card.Controls.Add(lblAppointments)


        Dim lblServicesHeader As New Label()
        lblServicesHeader.Text = "SERVICES OFFERED"
        lblServicesHeader.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblServicesHeader.ForeColor = Color.FromArgb(77, 0, 18)
        lblServicesHeader.Location = New Point(10, 165)
        lblServicesHeader.AutoSize = True
        card.Controls.Add(lblServicesHeader)


        Dim lblServices As New Label()
        lblServices.Text = servicesOffered
        lblServices.Font = New Font("Segoe UI", 8)
        lblServices.Location = New Point(10, 185)
        lblServices.Size = New Size(250, 80)
        lblServices.ForeColor = Color.DarkGreen
        card.Controls.Add(lblServices)


        Dim lblPerformanceIndicator As New Label()
        Dim performanceText As String = "Performance: "
        Dim performanceColor As Color = Color.Gray

        If totalReviews > 0 Then
            If avgRating >= 4.5 Then
                performanceText += "EXCELLENT ⭐⭐⭐⭐⭐"
                performanceColor = Color.Green
            ElseIf avgRating >= 4.0 Then
                performanceText += "VERY GOOD ⭐⭐⭐⭐"
                performanceColor = Color.LimeGreen
            ElseIf avgRating >= 3.0 Then
                performanceText += "GOOD ⭐⭐⭐"
                performanceColor = Color.Orange
            ElseIf avgRating >= 2.0 Then
                performanceText += "NEEDS IMPROVEMENT ⭐⭐"
                performanceColor = Color.Red
            Else
                performanceText += "POOR ⭐"
                performanceColor = Color.DarkRed
            End If
        Else
            performanceText += "NOT RATED YET"
            performanceColor = Color.Gray
        End If

        lblPerformanceIndicator.Text = performanceText
        lblPerformanceIndicator.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblPerformanceIndicator.ForeColor = performanceColor
        lblPerformanceIndicator.Location = New Point(10, 270)
        lblPerformanceIndicator.Size = New Size(250, 40)
        card.Controls.Add(lblPerformanceIndicator)


        card.Tag = New With {
            .StaffId = staffId,
            .FirstName = firstName,
            .LastName = lastName,
            .CurrentSalary = salary,
            .AvgRating = avgRating,
            .TotalReviews = totalReviews
        }


        AddHandler card.MouseEnter, Sub(sender, e) card.BackColor = Color.FromArgb(248, 249, 250)
        AddHandler card.MouseLeave, Sub(sender, e) card.BackColor = Color.White

        Return card
    End Function

    Private Sub btnUpdateSalary_Click(sender As Object, e As EventArgs) Handles btnUpdateSalary.Click
        Try
            ' Confirm salary update
            Dim result As DialogResult = MessageBox.Show(
                "⚠️ SALARY UPDATE CONFIRMATION ⚠️" & vbNewLine & vbNewLine &
                "This will update ALL staff salaries based on their performance:" & vbNewLine & vbNewLine &
                "📈 5-star average rating → +5% salary increase" & vbNewLine &
                "📊 No ratings yet → No change" & vbNewLine &
                "📉 Below 2-star average → -2% salary decrease" & vbNewLine & vbNewLine &
                "Are you sure you want to proceed with automatic salary adjustments?",
                "Confirm Salary Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2)

            If result = DialogResult.Yes Then
                UpdateAllStaffSalaries()
            End If

        Catch ex As Exception
            MessageBox.Show($"Error processing salary update: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateAllStaffSalaries()
        Try
            Dim updatedCount As Integer = 0
            Dim increasedCount As Integer = 0
            Dim decreasedCount As Integer = 0
            Dim unchangedCount As Integer = 0

            Using connection As New MySqlConnection(connectionString)
                connection.Open()


                Using transaction As MySqlTransaction = connection.BeginTransaction()
                    Try

                        Dim query As String = "
                            SELECT 
                                s.staff_id,
                                s.salary,
                                ur.first_name,
                                ur.last_name,
                                AVG(r.staff_rating) as avg_rating,
                                COUNT(r.review_id) as total_reviews
                            FROM staff s
                            INNER JOIN user_register ur ON s.user_id = ur.user_id
                            LEFT JOIN reviews r ON s.staff_id = r.staff_id
                            WHERE ur.role = 'staff' AND s.status = 'Active'
                            GROUP BY s.staff_id, s.salary, ur.first_name, ur.last_name"

                        Using command As New MySqlCommand(query, connection, transaction)
                            Using reader As MySqlDataReader = command.ExecuteReader()
                                Dim staffUpdates As New List(Of Object)

                                While reader.Read()
                                    Dim staffId As String = reader("staff_id").ToString()
                                    Dim currentSalary As Decimal = Convert.ToDecimal(reader("salary"))
                                    Dim avgRating As Double = If(IsDBNull(reader("avg_rating")), 0, Convert.ToDouble(reader("avg_rating")))
                                    Dim totalReviews As Integer = Convert.ToInt32(reader("total_reviews"))
                                    Dim firstName As String = reader("first_name").ToString()
                                    Dim lastName As String = reader("last_name").ToString()

                                    Dim newSalary As Decimal = currentSalary
                                    Dim changeType As String = "No Change"

                                    If totalReviews > 0 Then
                                        If avgRating = 5.0 Then
                                            ' 5-star rating: +5% increase
                                            newSalary = currentSalary * 1.05D
                                            changeType = "Increased"
                                        ElseIf avgRating < 2.0 Then
                                            ' Below 2-star rating: -2% decrease
                                            newSalary = currentSalary * 0.98D
                                            changeType = "Decreased"
                                        End If
                                    End If

                                    staffUpdates.Add(New With {
                                        .StaffId = staffId,
                                        .FirstName = firstName,
                                        .LastName = lastName,
                                        .OldSalary = currentSalary,
                                        .NewSalary = newSalary,
                                        .ChangeType = changeType,
                                        .Rating = avgRating,
                                        .Reviews = totalReviews
                                    })
                                End While

                                reader.Close()


                                For Each staff In staffUpdates
                                    If staff.ChangeType <> "No Change" Then
                                        Dim updateQuery As String = "UPDATE staff SET salary = @newSalary WHERE staff_id = @staffId"
                                        Using updateCommand As New MySqlCommand(updateQuery, connection, transaction)
                                            updateCommand.Parameters.AddWithValue("@newSalary", staff.NewSalary)
                                            updateCommand.Parameters.AddWithValue("@staffId", staff.StaffId)
                                            updateCommand.ExecuteNonQuery()
                                        End Using

                                        updatedCount += 1
                                        If staff.ChangeType = "Increased" Then
                                            increasedCount += 1
                                        Else
                                            decreasedCount += 1
                                        End If
                                    Else
                                        unchangedCount += 1
                                    End If
                                Next
                            End Using
                        End Using


                        transaction.Commit()


                        MessageBox.Show(
                            $"✅ Salary Update Completed Successfully!" & vbNewLine & vbNewLine &
                            $"📊 Summary:" & vbNewLine &
                            $"• Staff with salary increases: {increasedCount}" & vbNewLine &
                            $"• Staff with salary decreases: {decreasedCount}" & vbNewLine &
                            $"• Staff with no changes: {unchangedCount}" & vbNewLine &
                            $"• Total staff processed: {increasedCount + decreasedCount + unchangedCount}",
                            "Salary Update Complete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)


                        LoadStaffPerformance()

                    Catch ex As Exception

                        transaction.Rollback()
                        MessageBox.Show($"Error updating salaries: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error processing salary updates: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class