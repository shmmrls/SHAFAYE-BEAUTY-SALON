Imports System.Data
Imports MySql.Data.MySqlClient

Public Class manageCustomers
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=root;Pwd=;"

    Private Sub manageCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllCustomers()
    End Sub

    Private Sub LoadAllCustomers()
        Try
            pnlTotalClientsCard.Controls.Clear()
            pnlTotalClientsCard.AutoScroll = True

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Query to get all clients with their transaction count
                Dim query As String = "
                    SELECT 
                        ur.user_id,
                        ur.first_name,
                        ur.last_name,
                        ur.username,
                        up.email,
                        up.phone,
                        up.date_of_birth,
                        COUNT(a.appointment_id) as total_transactions,
                        COALESCE(SUM(CASE WHEN a.status = 'Completed' THEN 1 ELSE 0 END), 0) as completed_transactions,
                        COALESCE(SUM(CASE WHEN a.status = 'Pending' THEN 1 ELSE 0 END), 0) as pending_transactions,
                        COALESCE(SUM(CASE WHEN a.status = 'Cancelled' THEN 1 ELSE 0 END), 0) as cancelled_transactions
                    FROM user_register ur
                    LEFT JOIN user_profiles up ON ur.user_id = up.user_id
                    LEFT JOIN appointments a ON ur.user_id = a.user_id
                    WHERE ur.role = 'user'
                    GROUP BY ur.user_id, ur.first_name, ur.last_name, ur.username, up.email, up.phone, up.date_of_birth
                    ORDER BY ur.first_name, ur.last_name"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim yPosition As Integer = 10

                        While reader.Read()
                            Dim customerCard As Panel = CreateCustomerCard(
                                reader("user_id").ToString(),
                                reader("first_name").ToString(),
                                reader("last_name").ToString(),
                                reader("username").ToString(),
                                If(IsDBNull(reader("email")), "N/A", reader("email").ToString()),
                                If(IsDBNull(reader("phone")), "N/A", reader("phone").ToString()),
                                If(IsDBNull(reader("date_of_birth")), Nothing, Convert.ToDateTime(reader("date_of_birth"))),
                                Convert.ToInt32(reader("total_transactions")),
                                Convert.ToInt32(reader("completed_transactions")),
                                Convert.ToInt32(reader("pending_transactions")),
                                Convert.ToInt32(reader("cancelled_transactions"))
                            )

                            customerCard.Location = New Point(10, yPosition)
                            pnlTotalClientsCard.Controls.Add(customerCard)
                            yPosition += customerCard.Height + 15
                        End While
                    End Using
                End Using

                ' Show message if no customers found
                If pnlTotalClientsCard.Controls.Count = 0 Then
                    Dim noCustomersLabel As New Label()
                    noCustomersLabel.Text = "No customers found in the system"
                    noCustomersLabel.ForeColor = Color.Gray
                    noCustomersLabel.Font = New Font("Segoe UI", 12, FontStyle.Italic)
                    noCustomersLabel.AutoSize = True
                    noCustomersLabel.Location = New Point(20, 20)
                    pnlTotalClientsCard.Controls.Add(noCustomersLabel)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error loading customer data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CreateCustomerCard(userId As String, firstName As String, lastName As String, username As String, email As String, phone As String, dateOfBirth As DateTime?, totalTransactions As Integer, completedTransactions As Integer, pendingTransactions As Integer, cancelledTransactions As Integer) As Panel
        Dim card As New Panel()
        card.Size = New Size(550, 180)
        card.BorderStyle = BorderStyle.FixedSingle
        card.BackColor = Color.White
        card.Margin = New Padding(5)

        ' Customer Name (Top Left)
        Dim lblName As New Label()
        lblName.Text = $"{firstName} {lastName}"
        lblName.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblName.ForeColor = Color.DarkBlue
        lblName.Location = New Point(15, 10)
        lblName.Size = New Size(300, 25)
        card.Controls.Add(lblName)

        ' Username (Below Name)
        Dim lblUsername As New Label()
        lblUsername.Text = $"@{username}"
        lblUsername.Font = New Font("Segoe UI", 9, FontStyle.Italic)
        lblUsername.ForeColor = Color.Gray
        lblUsername.Location = New Point(15, 35)
        lblUsername.AutoSize = True
        card.Controls.Add(lblUsername)

        ' Customer ID (Top Right, before delete button)
        Dim lblUserId As New Label()
        lblUserId.Text = $"ID: {userId}"
        lblUserId.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblUserId.ForeColor = Color.DarkGreen
        lblUserId.Location = New Point(380, 10)
        lblUserId.AutoSize = True
        card.Controls.Add(lblUserId)

        ' Email (Left Column)
        Dim lblEmail As New Label()
        lblEmail.Text = $"📧 {email}"
        lblEmail.Font = New Font("Segoe UI", 9)
        lblEmail.Location = New Point(15, 60)
        lblEmail.Size = New Size(280, 20)
        card.Controls.Add(lblEmail)

        ' Phone (Left Column)
        Dim lblPhone As New Label()
        lblPhone.Text = $"📱 {phone}"
        lblPhone.Font = New Font("Segoe UI", 9)
        lblPhone.Location = New Point(15, 80)
        lblPhone.Size = New Size(200, 20)
        card.Controls.Add(lblPhone)

        ' Date of Birth (Left Column)
        Dim lblDOB As New Label()
        Dim dobText As String = If(dateOfBirth.HasValue, dateOfBirth.Value.ToString("MMM dd, yyyy"), "N/A")
        lblDOB.Text = $"🎂 {dobText}"
        lblDOB.Font = New Font("Segoe UI", 9)
        lblDOB.Location = New Point(15, 100)
        lblDOB.Size = New Size(200, 20)
        card.Controls.Add(lblDOB)

        ' Transaction Summary (Right Column - Top)
        Dim lblTotalTransactions As New Label()
        lblTotalTransactions.Text = $"Total Appointments: {totalTransactions}"
        lblTotalTransactions.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblTotalTransactions.ForeColor = Color.Blue
        lblTotalTransactions.Location = New Point(300, 60)
        lblTotalTransactions.Size = New Size(180, 20)
        card.Controls.Add(lblTotalTransactions)

        ' Completed Transactions
        Dim lblCompleted As New Label()
        lblCompleted.Text = $"✅ Completed: {completedTransactions}"
        lblCompleted.Font = New Font("Segoe UI", 8)
        lblCompleted.ForeColor = Color.Green
        lblCompleted.Location = New Point(300, 80)
        lblCompleted.Size = New Size(120, 18)
        card.Controls.Add(lblCompleted)

        ' Pending Transactions
        Dim lblPending As New Label()
        lblPending.Text = $"⏳ Pending: {pendingTransactions}"
        lblPending.Font = New Font("Segoe UI", 8)
        lblPending.ForeColor = Color.Orange
        lblPending.Location = New Point(300, 98)
        lblPending.Size = New Size(120, 18)
        card.Controls.Add(lblPending)

        ' Cancelled Transactions
        Dim lblCancelled As New Label()
        lblCancelled.Text = $"❌ Cancelled: {cancelledTransactions}"
        lblCancelled.Font = New Font("Segoe UI", 8)
        lblCancelled.ForeColor = Color.Red
        lblCancelled.Location = New Point(300, 116)
        lblCancelled.Size = New Size(120, 18)
        card.Controls.Add(lblCancelled)

        ' Customer Status (Bottom Left)
        Dim lblStatus As New Label()
        lblStatus.Text = "ACTIVE CUSTOMER"
        lblStatus.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblStatus.ForeColor = Color.Green
        lblStatus.Location = New Point(15, 150)
        lblStatus.AutoSize = True
        card.Controls.Add(lblStatus)

        ' Delete Button (Right Middle)
        Dim btnDelete As New Button()
        btnDelete.Text = "DELETE"
        btnDelete.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.BackColor = Color.FromArgb(77, 0, 18)
        btnDelete.Size = New Size(80, 35)
        btnDelete.Location = New Point(450, 85) ' Right middle position
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.Cursor = Cursors.Hand

        ' Add click event for delete button
        AddHandler btnDelete.Click, Sub(sender, e) DeleteCustomer(userId, $"{firstName} {lastName}")

        card.Controls.Add(btnDelete)

        ' Add hover effect for the card
        AddHandler card.MouseEnter, Sub(sender, e) card.BackColor = Color.FromArgb(248, 249, 250)
        AddHandler card.MouseLeave, Sub(sender, e) card.BackColor = Color.White

        Return card
    End Function

    Private Sub DeleteCustomer(userId As String, customerName As String)
        Try
            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show(
                $"Are you sure you want to delete customer '{customerName}' and ALL their records from the system?" & vbNewLine & vbNewLine &
                "This action will permanently remove:" & vbNewLine &
                "• Customer profile and account" & vbNewLine &
                "• All appointments and bookings" & vbNewLine &
                "• All reviews and ratings" & vbNewLine &
                "• All contact messages" & vbNewLine &
                "• All payment records" & vbNewLine & vbNewLine &
                "This action cannot be undone!",
                "Confirm Customer Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2)

            If result = DialogResult.Yes Then
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Start transaction for data integrity
                    Using transaction As MySqlTransaction = connection.BeginTransaction()
                        Try
                            ' Delete in proper order to respect foreign key constraints

                            ' 1. Delete reviews (references appointments and staff)
                            Dim deleteReviews As String = "DELETE FROM reviews WHERE appointment_id IN (SELECT appointment_id FROM appointments WHERE user_id = @userId)"
                            Using cmd As New MySqlCommand(deleteReviews, connection, transaction)
                                cmd.Parameters.AddWithValue("@userId", userId)
                                cmd.ExecuteNonQuery()
                            End Using

                            ' 2. Delete payments (references appointments)
                            Dim deletePayments As String = "DELETE FROM payments WHERE appointment_id IN (SELECT appointment_id FROM appointments WHERE user_id = @userId)"
                            Using cmd As New MySqlCommand(deletePayments, connection, transaction)
                                cmd.Parameters.AddWithValue("@userId", userId)
                                cmd.ExecuteNonQuery()
                            End Using

                            ' 3. Delete appointment_services (references appointments)
                            Dim deleteAppointmentServices As String = "DELETE FROM appointment_services WHERE appointment_id IN (SELECT appointment_id FROM appointments WHERE user_id = @userId)"
                            Using cmd As New MySqlCommand(deleteAppointmentServices, connection, transaction)
                                cmd.Parameters.AddWithValue("@userId", userId)
                                cmd.ExecuteNonQuery()
                            End Using

                            ' 4. Delete appointments
                            Dim deleteAppointments As String = "DELETE FROM appointments WHERE user_id = @userId"
                            Using cmd As New MySqlCommand(deleteAppointments, connection, transaction)
                                cmd.Parameters.AddWithValue("@userId", userId)
                                cmd.ExecuteNonQuery()
                            End Using

                            ' 5. Delete contact messages
                            Dim deleteMessages As String = "DELETE FROM contact_messages WHERE user_id = @userId"
                            Using cmd As New MySqlCommand(deleteMessages, connection, transaction)
                                cmd.Parameters.AddWithValue("@userId", userId)
                                cmd.ExecuteNonQuery()
                            End Using

                            ' 6. Delete user profile
                            Dim deleteProfile As String = "DELETE FROM user_profiles WHERE user_id = @userId"
                            Using cmd As New MySqlCommand(deleteProfile, connection, transaction)
                                cmd.Parameters.AddWithValue("@userId", userId)
                                cmd.ExecuteNonQuery()
                            End Using

                            ' 7. Finally, delete user account
                            Dim deleteUser As String = "DELETE FROM user_register WHERE user_id = @userId"
                            Using cmd As New MySqlCommand(deleteUser, connection, transaction)
                                cmd.Parameters.AddWithValue("@userId", userId)
                                cmd.ExecuteNonQuery()
                            End Using

                            ' Commit transaction
                            transaction.Commit()

                            MessageBox.Show($"Customer '{customerName}' and all their records have been successfully deleted from the system.", "Customer Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh the customer list
                            LoadAllCustomers()

                        Catch ex As Exception
                            ' Rollback transaction on error
                            transaction.Rollback()
                            MessageBox.Show($"Error deleting customer: {ex.Message}", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End Using
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show($"Error processing customer deletion: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class