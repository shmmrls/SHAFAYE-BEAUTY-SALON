Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms

'FOR CUSTOMER SUPPORT
'Allow admin/staff to view, sort, and delete customer reviews of services and staff.
Public Class moderateReviews
    Private conn As New MySqlConnection("server=localhost;userid=root;password=;database=final_shafaye_salon")

    Private Sub moderateReviews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSortByRating.Items.AddRange(New String() {"Highest", "Lowest"})
        cmbSortByDate.Items.AddRange(New String() {"Newest", "Oldest"})
        cmbSortByRating.SelectedIndex = 0
        cmbSortByDate.SelectedIndex = 0
        LoadReviews()

        flpReviews.AutoScroll = True
        flpReviews.WrapContents = False
        flpReviews.FlowDirection = FlowDirection.TopDown
    End Sub

    Private Sub LoadReviews(Optional ByVal keyword As String = "", Optional ByVal sortByRating As String = "", Optional ByVal sortByDate As String = "")
        Try
            flpReviews.Controls.Clear()
            conn.Open()

            Dim query As String = "SELECT r.review_id, r.appointment_id, r.staff_id, r.service_rating, r.staff_rating, r.comment, " &
                                  "ur.first_name AS customer_first_name, ur.last_name AS customer_last_name, " &
                                  "us.first_name AS staff_first_name, us.last_name AS staff_last_name, " &
                                  "a.appointment_date, a.created_at " &
                                  "FROM reviews r " &
                                  "INNER JOIN appointments a ON r.appointment_id = a.appointment_id " &
                                  "INNER JOIN user_register ur ON a.user_id = ur.user_id " &
                                  "INNER JOIN staff s ON r.staff_id = s.staff_id " &
                                  "INNER JOIN user_register us ON s.user_id = us.user_id " &
                                  "WHERE (ur.first_name LIKE @keyword OR ur.last_name LIKE @keyword " &
                                  "OR us.first_name LIKE @keyword OR us.last_name LIKE @keyword " &
                                  "OR r.comment LIKE @keyword) "

            If sortByRating = "Highest" Then
                query &= "ORDER BY r.service_rating DESC, r.staff_rating DESC, a.created_at DESC"
            ElseIf sortByRating = "Lowest" Then
                query &= "ORDER BY r.service_rating ASC, r.staff_rating ASC, a.created_at DESC"
            ElseIf sortByDate = "Newest" Then
                query &= "ORDER BY a.created_at DESC"
            ElseIf sortByDate = "Oldest" Then
                query &= "ORDER BY a.created_at ASC"
            Else
                query &= "ORDER BY a.created_at DESC"
            End If

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If Not reader.HasRows Then
                        Dim noReviewsLabel As New Label()
                        noReviewsLabel.Text = "No reviews found matching your criteria."
                        noReviewsLabel.ForeColor = Color.Gray
                        noReviewsLabel.Font = New Font("Segoe UI", 12, FontStyle.Italic)
                        noReviewsLabel.AutoSize = True
                        noReviewsLabel.Location = New Point(20, 20)
                        flpReviews.Controls.Add(noReviewsLabel)
                    Else
                        While reader.Read()
                            Dim reviewPanel As New Panel()
                            reviewPanel.Size = New Size(flpReviews.Width - 20, 120)
                            reviewPanel.BorderStyle = BorderStyle.FixedSingle
                            reviewPanel.BackColor = Color.White
                            reviewPanel.Margin = New Padding(5)

                            Dim lblCustomerInfo As New Label()
                            lblCustomerInfo.AutoSize = False
                            lblCustomerInfo.Size = New Size(reviewPanel.Width - 180, 25)
                            lblCustomerInfo.Location = New Point(10, 10)
                            lblCustomerInfo.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                            lblCustomerInfo.ForeColor = Color.DarkBlue
                            lblCustomerInfo.Text = $"Customer: {reader("customer_first_name")} {reader("customer_last_name")}"

                            Dim lblStaffInfo As New Label()
                            lblStaffInfo.AutoSize = False
                            lblStaffInfo.Size = New Size(reviewPanel.Width - 180, 20)
                            lblStaffInfo.Location = New Point(10, 35)
                            lblStaffInfo.Font = New Font("Segoe UI", 9)
                            lblStaffInfo.ForeColor = Color.DarkGreen
                            lblStaffInfo.Text = $"Staff: {reader("staff_first_name")} {reader("staff_last_name")}"

                            Dim lblRatings As New Label()
                            lblRatings.AutoSize = False
                            lblRatings.Size = New Size(reviewPanel.Width - 180, 20)
                            lblRatings.Location = New Point(10, 55)
                            lblRatings.Font = New Font("Segoe UI", 9)
                            lblRatings.ForeColor = Color.DarkOrange
                            Dim serviceRating As String = If(IsDBNull(reader("service_rating")), "N/A", reader("service_rating").ToString())
                            Dim staffRating As String = If(IsDBNull(reader("staff_rating")), "N/A", reader("staff_rating").ToString())
                            lblRatings.Text = $"Service Rating: {serviceRating}/5 | Staff Rating: {staffRating}/5"

                            Dim lblComment As New Label()
                            lblComment.AutoSize = True
                            lblComment.Size = New Size(reviewPanel.Width - 180, 30)
                            lblComment.Location = New Point(10, 75)
                            lblComment.Font = New Font("Segoe UI", 8)
                            lblComment.ForeColor = Color.Black
                            Dim comment As String = If(IsDBNull(reader("comment")), "No comment provided", reader("comment").ToString())
                            lblComment.Text = $"Comment: {If(comment.Length > 80, comment.Substring(0, 80) & "...", comment)}"

                            Dim lblDate As New Label()
                            lblDate.AutoSize = True
                            lblDate.Size = New Size(reviewPanel.Width - 180, 40)
                            lblDate.Location = New Point(lblComment.Left, lblComment.Bottom + 2)
                            lblDate.Font = New Font("Segoe UI", 7, FontStyle.Italic)
                            lblDate.ForeColor = Color.Gray
                            lblDate.Text = $"Date: {Convert.ToDateTime(reader("created_at")).ToString("MMM dd, yyyy hh:mm tt")}"

                            Dim btnDelete As New Button()
                            btnDelete.Text = "Delete"
                            btnDelete.BackColor = Color.FromArgb(77, 0, 18)
                            btnDelete.ForeColor = Color.White
                            btnDelete.Size = New Size(70, 30)
                            btnDelete.Location = New Point(reviewPanel.Width - 125, 45)
                            btnDelete.Tag = reader("review_id")
                            btnDelete.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                            AddHandler btnDelete.Click, AddressOf DeleteReview



                            reviewPanel.Controls.Add(lblCustomerInfo)
                            reviewPanel.Controls.Add(lblStaffInfo)
                            reviewPanel.Controls.Add(lblRatings)
                            reviewPanel.Controls.Add(lblComment)
                            reviewPanel.Controls.Add(lblDate)
                            reviewPanel.Controls.Add(btnDelete)

                            flpReviews.Controls.Add(reviewPanel)
                        End While
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading reviews: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub DeleteReview(sender As Object, e As EventArgs)
        Dim reviewID As Integer = CInt(DirectCast(sender, Button).Tag)
        If MessageBox.Show("Are you sure you want to delete this review? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                conn.Open()
                Dim query As String = "DELETE FROM reviews WHERE review_id = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", reviewID)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Review deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Review not found or already deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting review: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                LoadReviews(txtSearch.Text, cmbSortByRating.Text, cmbSortByDate.Text)
            End Try
        End If
    End Sub



    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        LoadReviews(txtSearch.Text, cmbSortByRating.Text, cmbSortByDate.Text)
    End Sub

    Private Sub cmbSortByRating_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadReviews(txtSearch.Text, cmbSortByRating.Text, cmbSortByDate.Text)
    End Sub

    Private Sub cmbSortByDate_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadReviews(txtSearch.Text, cmbSortByRating.Text, cmbSortByDate.Text)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        LoadReviews(txtSearch.Text, cmbSortByRating.Text, cmbSortByDate.Text)
    End Sub

End Class
