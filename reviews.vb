Imports MySql.Data.MySqlClient

'for FEEDBACK AND REVIEWS
Public Class reviews
    Private userID As Integer
    Private conn As MySqlConnection = New MySqlConnection("Server=localhost;Database=final_shafaye_salon;Uid=salon_customer;Pwd=CustomerSalon2025!;")

    Public Sub New(userID As Integer)
        InitializeComponent()
        Me.userID = userID
        LoadAppointments()
        LoadServiceFilter()
        LoadSortOptions()
    End Sub

    Private Sub LoadServiceFilter()
        cmbFilterService.Items.Clear()
        cmbFilterService.Items.Add("All Services")
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT DISTINCT s.name FROM services s INNER JOIN appointment_services aps ON s.service_id = aps.service_id", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbFilterService.Items.Add(reader("name").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading services: " & ex.Message)
        Finally
            conn.Close()
        End Try
        cmbFilterService.SelectedIndex = 0
        AddHandler cmbFilterService.SelectedIndexChanged, AddressOf SortOrFilterChanged
    End Sub

    Private Sub LoadSortOptions()
        cmbSortOrder.Items.Clear()
        cmbSortOrder.Items.Add("Low to High")
        cmbSortOrder.Items.Add("High to Low")
        cmbSortOrder.SelectedIndex = 0
        AddHandler cmbSortOrder.SelectedIndexChanged, AddressOf SortOrFilterChanged
    End Sub

    Private Sub SortOrFilterChanged(sender As Object, e As EventArgs)
        If flowReviews.Visible Then
            LoadReviews()
        End If
    End Sub

    Private Sub LoadAppointments()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("
    SELECT a.appointment_id, s.name AS service_name, a.appointment_date, aps.staff_id,
           CONCAT(ur_staff.first_name, ' ', ur_staff.last_name) AS staff_name
    FROM appointments a
    INNER JOIN appointment_services aps ON a.appointment_id = aps.appointment_id
    INNER JOIN services s ON aps.service_id = s.service_id
    LEFT JOIN staff st ON aps.staff_id = st.staff_id
    LEFT JOIN user_register ur_staff ON st.user_id = ur_staff.user_id
    WHERE a.user_id = @userID
      AND a.status = 'Completed'
      AND NOT EXISTS (
          SELECT 1 FROM reviews r
          WHERE r.appointment_id = a.appointment_id AND r.staff_id = aps.staff_id
      )
    ORDER BY a.appointment_date DESC
", conn)

            cmd.Parameters.AddWithValue("@userID", userID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            cbAppointments.Items.Clear()
            While reader.Read()
                Dim displayText = $"#{reader("appointment_id")} - {reader("service_name")} with {If(IsDBNull(reader("staff_name")), "No Staff", reader("staff_name"))} on {CDate(reader("appointment_date")).ToShortDateString()}"
                cbAppointments.Items.Add(New AppointmentReviewItem With {
                    .Text = displayText,
                    .AppointmentID = reader("appointment_id"),
                    .ServiceName = reader("service_name"),
                    .StaffID = If(IsDBNull(reader("staff_id")), Nothing, reader("staff_id")),
                    .StaffName = If(IsDBNull(reader("staff_name")), "No Staff", reader("staff_name"))
                })
            End While
            cbAppointments.DisplayMember = "Text"
        Catch ex As Exception
            MessageBox.Show("Error loading appointments: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cbAppointments.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an appointment.")
            Return
        End If

        Dim selectedItem = DirectCast(cbAppointments.SelectedItem, AppointmentReviewItem)
        Dim appointmentID = selectedItem.AppointmentID
        Dim staffID = selectedItem.StaffID
        Dim serviceRating = CInt(nudServiceRating.Value)
        Dim staffRating = CInt(nudStaffRating.Value)
        Dim comment = txtComment.Text.Trim()

        If staffID Is Nothing Then
            MessageBox.Show("No staff assigned for this appointment. Cannot submit review.")
            Return
        End If

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("
                INSERT INTO reviews (appointment_id, staff_id, service_rating, staff_rating, comment) 
                VALUES (@aid, @sid, @sr, @str, @comment)", conn)
            cmd.Parameters.AddWithValue("@aid", appointmentID)
            cmd.Parameters.AddWithValue("@sid", staffID)
            cmd.Parameters.AddWithValue("@sr", serviceRating)
            cmd.Parameters.AddWithValue("@str", staffRating)
            cmd.Parameters.AddWithValue("@comment", comment)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Review submitted successfully!")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error submitting review: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub reviews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFilterService.Visible = False
        cmbSortOrder.Visible = False
        flowReviews.Visible = False
        viewReviewsbtn.Text = "View Reviews"
    End Sub

    Private Sub btnViewReviews_Click(sender As Object, e As EventArgs) Handles viewReviewsbtn.Click
        Dim currentlyVisible As Boolean = flowReviews.Visible
        cmbFilterService.Visible = Not currentlyVisible
        cmbSortOrder.Visible = Not currentlyVisible
        flowReviews.Visible = Not currentlyVisible

        If Not currentlyVisible Then
            viewReviewsbtn.Text = "Hide Reviews"
            LoadReviews()
            panelleavereview.Visible = False
            lblService.Visible = True
            lblRating.Visible = True
        Else
            viewReviewsbtn.Text = "View Reviews"
            panelleavereview.Visible = True
            lblService.Visible = False
            lblRating.Visible = False
        End If
    End Sub
    Private Sub LoadReviews()
        flowReviews.Controls.Clear()

        Dim selectedService As String = If(cmbFilterService.SelectedItem, "All Services")
        Dim selectedSort As String = If(cmbSortOrder.SelectedItem, "Low to High")

        Dim query As String = "
            SELECT r.review_id, s.name AS service_name,
                   CONCAT(u.first_name, ' ', u.last_name) AS staff_name,
                   r.service_rating, r.staff_rating, r.comment
            FROM reviews r
            JOIN appointments a ON r.appointment_id = a.appointment_id
            JOIN appointment_services aps ON aps.appointment_id = a.appointment_id AND aps.staff_id = r.staff_id
            JOIN services s ON aps.service_id = s.service_id
            JOIN staff st ON r.staff_id = st.staff_id
            JOIN user_register u ON st.user_id = u.user_id
            WHERE a.user_id = @uid
        "

        If selectedService <> "All Services" Then
            query &= " AND s.name = @serviceName"
        End If

        If selectedSort = "High to Low" Then
            query &= " ORDER BY r.service_rating DESC"
        Else
            query &= " ORDER BY r.service_rating ASC"
        End If

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@uid", userID)
        If selectedService <> "All Services" Then
            cmd.Parameters.AddWithValue("@serviceName", selectedService)
        End If

        conn.Open()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim reviewPanel As New Panel With {
        .Width = flowReviews.Width - 30,
        .Height = 200,
        .BackColor = Color.White,
        .BorderStyle = BorderStyle.FixedSingle,
        .Padding = New Padding(10),
        .Margin = New Padding(10)
    }

            Dim lblService As New Label With {
        .Text = $"Service: {reader("service_name")}",
        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
        .AutoSize = True,
        .Location = New Point(10, 10)
    }

            Dim lblStaff As New Label With {
        .Text = $"Staff: {reader("staff_name")}",
        .Font = New Font("Segoe UI", 9),
        .AutoSize = True,
        .Location = New Point(10, lblService.Bottom + 5)
    }

            Dim starsService As String = New String("⭐"c, CInt(reader("service_rating")))
            Dim starsStaff As String = New String("⭐"c, CInt(reader("staff_rating")))

            Dim lblServiceRating As New Label With {
        .Text = $"Service Rating: {starsService}",
        .ForeColor = Color.Goldenrod,
        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
        .AutoSize = True,
        .Location = New Point(10, lblStaff.Bottom + 5)
    }

            Dim lblStaffRating As New Label With {
        .Text = $"Staff Rating: {starsStaff}",
        .ForeColor = Color.Goldenrod,
        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
        .AutoSize = True,
        .Location = New Point(10, lblServiceRating.Bottom + 5)
    }

            Dim fullComment As String = reader("comment").ToString()
            Dim isLong As Boolean = fullComment.Length > 100
            Dim displayComment As String = If(isLong, fullComment.Substring(0, 100) & "...", fullComment)

            Dim lblComment As New Label With {
        .Text = $"Comment: {displayComment}",
        .Font = New Font("Segoe UI", 9),
        .AutoSize = False,
        .Size = New Size(reviewPanel.Width - 30, 50),
        .Location = New Point(10, lblStaffRating.Bottom + 5),
        .Tag = fullComment
    }

            Dim linkToggle As New LinkLabel With {
        .Text = If(isLong, "Show More", ""),
        .Font = New Font("Segoe UI", 8, FontStyle.Underline),
        .Location = New Point(10, lblComment.Bottom + 3),
        .AutoSize = True
    }

            AddHandler linkToggle.Click, Sub(sender2, e2)
                                             If linkToggle.Text = "Show More" Then
                                                 lblComment.Text = "Comment: " & lblComment.Tag.ToString()
                                                 linkToggle.Text = "Show Less"
                                             Else
                                                 lblComment.Text = "Comment: " & lblComment.Tag.ToString().Substring(0, 100) & "..."
                                                 linkToggle.Text = "Show More"
                                             End If
                                         End Sub

            reviewPanel.Controls.Add(lblService)
            reviewPanel.Controls.Add(lblStaff)
            reviewPanel.Controls.Add(lblServiceRating)
            reviewPanel.Controls.Add(lblStaffRating)
            reviewPanel.Controls.Add(lblComment)
            reviewPanel.Controls.Add(linkToggle)

            flowReviews.Controls.Add(reviewPanel)
        End While


        reader.Close()
        conn.Close()
    End Sub

    Private Class AppointmentReviewItem
        Public Property Text As String
        Public Property AppointmentID As Integer
        Public Property ServiceName As String
        Public Property StaffID As Integer?
        Public Property StaffName As String
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class
End Class
