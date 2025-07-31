Imports MySql.Data.MySqlClient

' mp4 Any/Other CRUD functions  
' READ: Load and display all appointments  
' FILTER: Filter by status, date, staff, and time  
' SORT: Oldest to Recent / Recent to Oldest  

' APPOINTMENT DASHBOARD (Under “APPOINTMENT BOOKING” → For Admin)
' Admins can see all bookings (daily/weekly/monthly view), staff assigned per appointment,
' And manage status (Pending, Approved, Completed, Cancelled).
Public Class viewallbookings

    Private Sub LoadAppointments(Optional statusFilter As String = "All",
                             Optional dateFilter As String = "All",
                             Optional staffFilter As String = "All",
                             Optional timeFilter As String = "All",
                             Optional orderBy As String = "Oldest to Recent")

        flowAppointments.Controls.Clear()

        Dim baseQuery As String = "SELECT a.appointment_id, a.appointment_date, a.appointment_time, a.status, " &
                              "GROUP_CONCAT(DISTINCT s.name SEPARATOR ', ') AS service_names, " &
                              "CONCAT(u.first_name, ' ', u.last_name) AS client_name " &
                              "FROM appointments a " &
                              "JOIN appointment_services aps ON a.appointment_id = aps.appointment_id " &
                              "JOIN services s ON aps.service_id = s.service_id " &
                              "JOIN user_register u ON a.user_id = u.user_id "

        If statusFilter <> "All" Then baseQuery &= " AND a.status = @status"
        If dateFilter <> "All" Then baseQuery &= " AND a.appointment_date = @date"
        If staffFilter <> "All" Then
            baseQuery &= " AND EXISTS (SELECT 1 FROM appointment_services aps2 " &
                    "JOIN staff st ON aps2.staff_id = st.staff_id " &
                    "JOIN user_register u2 ON st.user_id = u2.user_id " &
                    "WHERE aps2.appointment_id = a.appointment_id " &
                    "AND CONCAT(u2.first_name, ' ', u2.last_name) = @staff)"
        End If
        If timeFilter <> "All" Then baseQuery &= " AND a.appointment_time = @time"

        baseQuery &= " GROUP BY a.appointment_id"

        If orderBy = "Recent to Oldest" Then
            baseQuery &= " ORDER BY a.appointment_date DESC, a.appointment_time DESC"
        Else
            baseQuery &= " ORDER BY a.appointment_date ASC, a.appointment_time ASC"
        End If

        Using conn As New MySqlConnection("Data Source=localhost;Database=final_shafaye_salon;User=salon_webapp;Password=WebApp2025!;")
            Using cmd As New MySqlCommand(baseQuery, conn)

                If statusFilter <> "All" Then
                    cmd.Parameters.AddWithValue("@status", statusFilter)
                End If

                If dateFilter <> "All" Then
                    Dim parsedDate As Date
                    If DateTime.TryParse(dateFilter, parsedDate) Then
                        cmd.Parameters.AddWithValue("@date", parsedDate.ToString("yyyy-MM-dd"))
                    End If
                End If

                If staffFilter <> "All" Then
                    cmd.Parameters.AddWithValue("@staff", staffFilter)
                End If

                If timeFilter <> "All" Then
                    cmd.Parameters.AddWithValue("@time", timeFilter)
                End If

                Try
                    conn.Open()

                    Console.WriteLine("Executing query: " & baseQuery)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim appointmentCount As Integer = 0

                        While reader.Read()
                            appointmentCount += 1
                            Console.WriteLine($"Processing appointment #{appointmentCount}: ID = {reader("appointment_id")}")

                            Dim card As New AppointmentCard()

                            Dim appointmentDate As String = ""
                            Dim appointmentTime As String = ""

                            If Not IsDBNull(reader("appointment_date")) Then
                                Dim dateValue As Date = Convert.ToDateTime(reader("appointment_date"))
                                appointmentDate = dateValue.ToString("yyyy-MM-dd")
                            End If

                            If Not IsDBNull(reader("appointment_time")) Then
                                appointmentTime = reader("appointment_time").ToString()
                            End If

                            Dim assignedStaff As String = GetAssignedStaff(Convert.ToInt32(reader("appointment_id")))

                            card.SetData(reader("service_names").ToString(),
                                   assignedStaff,
                                   appointmentDate & " " & appointmentTime,
                                   reader("status").ToString())

                            flowAppointments.Controls.Add(card)
                        End While

                        Console.WriteLine($"Total appointments loaded: {appointmentCount}")
                        If appointmentCount = 0 Then
                            MessageBox.Show("No appointments found matching the current filters.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading appointments: " & ex.Message & vbCrLf & "Query: " & baseQuery)
                Finally
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
            End Using
        End Using
    End Sub
    Private Function GetAssignedStaff(appointmentId As Integer) As String
        Dim staffNames As String = ""

        Using conn As New MySqlConnection("server=localhost;user=root;password=;database=final_shafaye_salon")
            Try
                conn.Open()
                Dim query As String = "SELECT DISTINCT CONCAT(u.first_name, ' ', u.last_name) AS staff_name " &
                                     "FROM appointment_services aps " &
                                     "JOIN staff st ON aps.staff_id = st.staff_id " &
                                     "JOIN user_register u ON st.user_id = u.user_id " &
                                     "WHERE aps.appointment_id = @appointmentId"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim staffList As New List(Of String)
                        While reader.Read()
                            staffList.Add(reader("staff_name").ToString())
                        End While
                        staffNames = String.Join(", ", staffList)
                    End Using
                End Using
            Catch ex As Exception
                staffNames = "Error loading staff"
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using

        Return staffNames
    End Function

    Private Sub viewallbookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAppointments()
        PopulateFilters()
    End Sub

    Private Sub PopulateFilters()
        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange(New String() {"All", "Pending", "Approved", "Completed", "Cancelled"})
        cmbStatus.SelectedIndex = 0

        cmborderby.Items.Clear()
        cmborderby.Items.AddRange(New String() {"Oldest to Recent", "Recent to Oldest"})
        cmborderby.SelectedIndex = 0

        Using conn As New MySqlConnection("server=localhost;user=root;password=;database=final_shafaye_salon")
            Try
                conn.Open()

                PopulateStaffFilter(conn)

                PopulateDateFilter(conn)

                PopulateTimeFilter(conn)

                cmbStaff.SelectedIndex = 0
                cmbDate.SelectedIndex = 0
                cmbTime.SelectedIndex = 0
                cmborderby.SelectedIndex = 0

            Catch ex As Exception
                MessageBox.Show("Error loading filters: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub

    Private Sub PopulateStaffFilter(conn As MySqlConnection)
        Try
            Dim staffQuery As String = "SELECT DISTINCT CONCAT(u.first_name, ' ', u.last_name) AS staff_name " &
                                      "FROM staff st " &
                                      "JOIN user_register u ON st.user_id = u.user_id " &
                                      "ORDER BY staff_name"

            Using staffCmd As New MySqlCommand(staffQuery, conn)
                cmbStaff.Items.Clear()
                cmbStaff.Items.Add("All")

                Using staffReader As MySqlDataReader = staffCmd.ExecuteReader()
                    While staffReader.Read()
                        If Not IsDBNull(staffReader("staff_name")) Then
                            cmbStaff.Items.Add(staffReader("staff_name").ToString())
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading staff filter: " & ex.Message)
        End Try
    End Sub

    Private Sub PopulateDateFilter(conn As MySqlConnection)
        Try
            Dim dateQuery As String = "SELECT DISTINCT appointment_date " &
                                     "FROM appointments " &
                                     "WHERE status != 'Cancelled' " &
                                     "ORDER BY appointment_date ASC"

            Using dateCmd As New MySqlCommand(dateQuery, conn)
                cmbDate.Items.Clear()
                cmbDate.Items.Add("All")

                Using dateReader As MySqlDataReader = dateCmd.ExecuteReader()
                    While dateReader.Read()
                        If Not IsDBNull(dateReader("appointment_date")) Then
                            Dim apptDate As Date = Convert.ToDateTime(dateReader("appointment_date"))
                            cmbDate.Items.Add(apptDate.ToString("yyyy-MM-dd"))
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading date filter: " & ex.Message)
        End Try
    End Sub

    Private Sub PopulateTimeFilter(conn As MySqlConnection)
        Try
            Dim timeQuery As String = "SELECT DISTINCT appointment_time " &
                                     "FROM appointments " &
                                     "WHERE status != 'Cancelled' " &
                                     "ORDER BY appointment_time ASC"

            Using timeCmd As New MySqlCommand(timeQuery, conn)
                cmbTime.Items.Clear()
                cmbTime.Items.Add("All")

                Using timeReader As MySqlDataReader = timeCmd.ExecuteReader()
                    While timeReader.Read()
                        If Not IsDBNull(timeReader("appointment_time")) Then
                            cmbTime.Items.Add(timeReader("appointment_time").ToString())
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading time filter: " & ex.Message)
        End Try
    End Sub

    Private Sub FiltersChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged,
                                                                            cmbDate.SelectedIndexChanged,
                                                                            cmbStaff.SelectedIndexChanged,
                                                                            cmbTime.SelectedIndexChanged,
                                                                            cmborderby.SelectedIndexChanged
        If cmbStatus.SelectedIndex >= 0 AndAlso cmbDate.SelectedIndex >= 0 AndAlso
           cmbStaff.SelectedIndex >= 0 AndAlso cmbTime.SelectedIndex >= 0 AndAlso
           cmborderby.SelectedIndex >= 0 Then
            LoadAppointments(cmbStatus.Text, cmbDate.Text, cmbStaff.Text, cmbTime.Text, cmborderby.Text)
        End If
    End Sub

End Class