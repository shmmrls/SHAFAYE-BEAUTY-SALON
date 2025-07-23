Imports MySql.Data.MySqlClient

Public Class bookappointment
    Private userID As Integer



    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=final_shafaye_salon")
    Private selectedServiceIDs As New List(Of Integer)



    Public Sub New(ByVal userID As Integer)
        InitializeComponent()
        Me.userID = userID
    End Sub

    Private Sub bookappointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserInfo()

        If Not CheckUserProfileExists(userID) Then
            MessageBox.Show("Please update your profile first.")
            userMenu.OpenChildForm(New profile())
            Me.Hide()
            Exit Sub
        End If

        appointmentDate.MinDate = Date.Today
        appointmentDate.MaxDate = Date.Today.AddMonths(3)
        appointmentDate.Value = Date.Today

        LoadCategories()
    End Sub

    Private Function CheckUserProfileExists(userID As Integer) As Boolean
        Dim exists As Boolean = False
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=final_shafaye_salon")

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM user_profiles WHERE user_id = @id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", userID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                exists = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking profile: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return exists
    End Function

    Private Sub LoadUserInfo()
        Try
            conn.Open()
            Dim query As String = "SELECT ur.first_name, ur.last_name, up.email " &
                              "FROM user_register ur " &
                              "JOIN user_profiles up ON ur.user_id = up.user_id " &
                              "WHERE ur.user_id = @id"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", userID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                fntext.Text = reader("first_name").ToString()
                lntext.Text = reader("last_name").ToString()
                emailtext.Text = reader("email").ToString()

                ' Make fields read-only
                fntext.ReadOnly = True
                lntext.ReadOnly = True
                emailtext.ReadOnly = True
            Else
                MsgBox("No user profile found. Please update your profile first.", MsgBoxStyle.Exclamation)
                profile.Show()
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Error loading user info: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles appointmentDate.ValueChanged
        cmbtimeslot.Items.Clear()
        Dim selectedDate As Date = appointmentDate.Value.Date
        Dim isWeekend As Boolean = (selectedDate.DayOfWeek = DayOfWeek.Saturday Or selectedDate.DayOfWeek = DayOfWeek.Sunday)
        Dim startHour As Integer = If(isWeekend, 9, 10)
        Dim endHour As Integer = If(isWeekend, 18, 19)

        For hour As Integer = startHour To endHour
            Dim slotTime As DateTime = selectedDate.AddHours(hour)
            If selectedDate = Date.Today AndAlso slotTime <= DateTime.Now Then Continue For
            cmbtimeslot.Items.Add(slotTime.ToString("hh:00 tt").ToUpper())
        Next

        If cmbtimeslot.Items.Count > 0 Then
            cmbtimeslot.SelectedIndex = 0
        Else
            cmbtimeslot.Items.Add("No available time slots")
            cmbtimeslot.SelectedIndex = 0
        End If
    End Sub

    Private Sub LoadCategories()
        cmbCategory.Items.Clear()
        Dim query As String = "SELECT category_id, name FROM service_categories"
        Dim cmd As New MySqlCommand(query, conn)
        conn.Open()
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            cmbCategory.Items.Add(New With {
                Key .Text = reader("name").ToString(),
                Key .Value = reader("category_id")
            })
        End While
        conn.Close()
        cmbCategory.DisplayMember = "Text"
        cmbCategory.ValueMember = "Value"
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        cmbServices.Items.Clear()
        Dim selectedCategory = cmbCategory.SelectedItem
        Dim query As String = "SELECT service_id, name, price FROM services WHERE category_id = @catId AND is_available = TRUE"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@catId", selectedCategory.Value)
        conn.Open()
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            cmbServices.Items.Add(New With {
                Key .Text = reader("name").ToString() & " - ₱" & reader("price").ToString(),
                Key .Value = reader("service_id")
            })
        End While
        conn.Close()
        cmbServices.DisplayMember = "Text"
        cmbServices.ValueMember = "Value"
    End Sub

    Private Sub btnaddbook_Click(sender As Object, e As EventArgs) Handles btnaddbook.Click
        If cmbServices.SelectedItem Is Nothing Then
            MsgBox("Please select a service.")
            Exit Sub
        End If
        If lstselected.Items.Count >= 3 Then
            MsgBox("You can only select up to 3 services.")
            Exit Sub
        End If

        Dim selected = cmbServices.SelectedItem
        Dim name = selected.Text
        Dim id = selected.Value

        If selectedServiceIDs.Contains(id) Then
            MsgBox("Service already added.")
            Exit Sub
        End If

        selectedServiceIDs.Add(id)
        lstselected.Items.Add(name)
    End Sub

    Private Sub removeservicebtn_Click(sender As Object, e As EventArgs) Handles removeservicebtn.Click
        If lstselected.SelectedIndex >= 0 Then
            selectedServiceIDs.RemoveAt(lstselected.SelectedIndex)
            lstselected.Items.RemoveAt(lstselected.SelectedIndex)
        Else
            MsgBox("Please select a service to remove.")
        End If
    End Sub

    Private Sub submitBooking_Click(sender As Object, e As EventArgs) Handles submitBooking.Click
        If selectedServiceIDs.Count = 0 Then
            MsgBox("Select at least one service.")
            Exit Sub
        End If

        Dim selectedDate As Date = appointmentDate.Value.Date
        Dim selectedTime As String = cmbtimeslot.SelectedItem.ToString()

        ' Check for duplicate appointment
        Dim duplicateQuery As String = "SELECT COUNT(*) FROM appointments WHERE user_id = @uid AND appointment_date = @date AND appointment_time = @time"
        Dim cmdCheck As New MySqlCommand(duplicateQuery, conn)
        cmdCheck.Parameters.AddWithValue("@uid", LoggedInUserID)
        cmdCheck.Parameters.AddWithValue("@date", selectedDate)
        cmdCheck.Parameters.AddWithValue("@time", selectedTime)
        conn.Open()
        Dim existing As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
        conn.Close()
        If existing > 0 Then
            MsgBox("You already have an appointment at this time.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim staffId As Integer = -1
        Dim staffName As String = ""
        GetAvailableStaff(selectedDate, staffId, staffName)

        If staffId = -1 Then
            MsgBox("No available staff for that date.")
            Exit Sub
        End If

        conn.Open()
        Dim cmdApp As New MySqlCommand("INSERT INTO appointments (user_id, appointment_date, appointment_time) VALUES (@user, @date, @time)", conn)
        cmdApp.Parameters.AddWithValue("@user", LoggedInUserID)
        cmdApp.Parameters.AddWithValue("@date", selectedDate)
        cmdApp.Parameters.AddWithValue("@time", selectedTime)
        cmdApp.ExecuteNonQuery()

        Dim appId As Integer = cmdApp.LastInsertedId

        For Each svcId In selectedServiceIDs
            Dim cmdSvc As New MySqlCommand("INSERT INTO appointment_services (appointment_id, service_id, staff_id) VALUES (@aid, @sid, @staff)", conn)
            cmdSvc.Parameters.AddWithValue("@aid", appId)
            cmdSvc.Parameters.AddWithValue("@sid", svcId)
            cmdSvc.Parameters.AddWithValue("@staff", staffId)
            cmdSvc.ExecuteNonQuery()
        Next

        conn.Close()
        lblstaff.Text = "Assigned Staff: " & staffName
        MsgBox("Appointment booked successfully!", MsgBoxStyle.Information)
        selectedServiceIDs.Clear()
        lstselected.Items.Clear()
    End Sub

    Private Sub GetAvailableStaff(dateSelected As Date, ByRef staffId As Integer, ByRef staffName As String)
        staffId = -1
        staffName = ""

        Dim query As String = "SELECT s.staff_id, CONCAT(u.first_name, ' ', u.last_name) AS full_name, COUNT(a.id) AS total_clients " &
                              "FROM staff s " &
                              "JOIN user_register u ON u.user_id = s.user_id " &
                              "LEFT JOIN appointment_services a ON s.staff_id = a.staff_id " &
                              "LEFT JOIN appointments ap ON a.appointment_id = ap.appointment_id AND ap.appointment_date = @selectedDate " &
                              "GROUP BY s.staff_id " &
                              "HAVING total_clients < 10 " &
                              "ORDER BY total_clients ASC LIMIT 1"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@selectedDate", dateSelected)
        conn.Open()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            staffId = reader("staff_id")
            staffName = reader("full_name").ToString()
        End If
        conn.Close()
    End Sub

End Class
