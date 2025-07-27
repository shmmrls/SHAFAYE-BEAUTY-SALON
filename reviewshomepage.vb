Imports MySql.Data.MySqlClient

'for feedback and reviews
Public Class reviewshomepage
    Dim conn As New MySqlConnection("server=localhost;user=root;password=;database=final_shafaye_salon;")

    Private Sub reviewshomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServiceFilter()
        LoadSortOptions()
        LoadReviews()
    End Sub

    Private Sub LoadSortOptions()
        cmbSortOrder.Items.Clear()
        cmbSortOrder.Items.Add("Low to High")
        cmbSortOrder.Items.Add("High to Low")
        cmbSortOrder.SelectedIndex = 0
        AddHandler cmbSortOrder.SelectedIndexChanged, AddressOf SortOrFilterChanged
    End Sub

    Private Sub LoadServiceFilter()
        cmbFilterService.Items.Clear()
        cmbFilterService.Items.Add("All Services")

        Dim query As String = "SELECT DISTINCT s.name FROM services s JOIN appointment_services aps ON s.service_id = aps.service_id"

        Dim cmd As New MySqlCommand(query, conn)
        conn.Open()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            cmbFilterService.Items.Add(reader("name").ToString())
        End While

        reader.Close()
        conn.Close()

        cmbFilterService.SelectedIndex = 0
        AddHandler cmbFilterService.SelectedIndexChanged, AddressOf SortOrFilterChanged
    End Sub

    Private Sub SortOrFilterChanged(sender As Object, e As EventArgs)
        LoadReviews()
    End Sub

    Private Sub LoadReviews()
        flowReviews.Controls.Clear()

        Dim selectedService As String = cmbFilterService.SelectedItem.ToString()
        Dim selectedSort As String = cmbSortOrder.SelectedItem.ToString()

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
        "

        If selectedService <> "All Services" Then
            query &= " WHERE s.name = @serviceName"
        End If

        If selectedSort = "High to Low" Then
            query &= " ORDER BY r.service_rating DESC"
        Else
            query &= " ORDER BY r.service_rating ASC"
        End If

        Dim cmd As New MySqlCommand(query, conn)

        If selectedService <> "All Services" Then
            cmd.Parameters.AddWithValue("@serviceName", selectedService)
        End If

        conn.Open()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim card As New ReviewCard()
            card.SetReviewData(
                reader("service_name").ToString(),
                reader("staff_name").ToString(),
                Convert.ToInt32(reader("service_rating")),
                Convert.ToInt32(reader("staff_rating")),
                reader("comment").ToString()
            )
            flowReviews.Controls.Add(card)
        End While

        reader.Close()
        conn.Close()
    End Sub
End Class
