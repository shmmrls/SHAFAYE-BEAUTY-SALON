Imports MySql.Data.MySqlClient

Public Class stafflist
    Dim conn As New MySqlConnection("server=localhost;user=root;password=;database=final_shafaye_salon;")
    Private Sub LoadStaffTable()
        Dim adapter As New MySqlDataAdapter("SELECT s.staff_id, s.user_id, u.first_name, u.last_name, s.position, s.salary, s.status FROM staff s JOIN user_register u ON s.user_id = u.user_id", conn)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        dgvStaff.DataSource = dt

        dgvStaff.Columns("staff_id").HeaderText = "Staff ID"
        dgvStaff.Columns("user_id").HeaderText = "User ID"
        dgvStaff.Columns("first_name").HeaderText = "First Name"
        dgvStaff.Columns("last_name").HeaderText = "Last Name"
        dgvStaff.Columns("position").HeaderText = "Position"
        dgvStaff.Columns("salary").HeaderText = "Salary"
        dgvStaff.Columns("status").HeaderText = "Status"
    End Sub

    Private Sub stafflist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffTable()

        With dgvStaff
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(77, 0, 18)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Segoe UI", 10)
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .RowTemplate.Height = 28
            .GridColor = Color.LightGray
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255)
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False

            '.RowHeadersVisible = False
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.SelectionBackColor = Color.LightGray
            .DefaultCellStyle.SelectionForeColor = Color.Black


        End With
    End Sub

    Private Sub addStaffbtn_Click(sender As Object, e As EventArgs) Handles addStaffbtn.Click
        adminMenu.OpenChildForm(New editstaff())
    End Sub

    Private Sub deleteStaffbtn_Click(sender As Object, e As EventArgs) Handles deleteStaffbtn.Click
        If dgvStaff.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a staff member to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = dgvStaff.SelectedRows(0)
        Dim staffID As Integer = Convert.ToInt32(selectedRow.Cells("staff_id").Value)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM staff WHERE staff_id = @staff_id", conn)
                cmd.Parameters.AddWithValue("@staff_id", staffID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Staff deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadStaffTable()
                Else
                    MessageBox.Show("Failed to delete staff. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If
    End Sub


    Private Sub addStaffbtn_MouseEnter(sender As Object, e As EventArgs) Handles addStaffbtn.MouseEnter
        addStaffbtn.BackgroundImage = My.Resources.addadminstaff2
        addStaffbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub addStaffbtn_MouseLeave(sender As Object, e As EventArgs) Handles addStaffbtn.MouseLeave
        addStaffbtn.BackgroundImage = My.Resources.addadminstaff
        addStaffbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub deleteStaffbtn_MouseEnter(sender As Object, e As EventArgs) Handles deleteStaffbtn.MouseEnter
        deleteStaffbtn.BackgroundImage = My.Resources.addadminstaff2
        deleteStaffbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub deleteStaffbtn_MouseLeave(sender As Object, e As EventArgs) Handles deleteStaffbtn.MouseLeave
        deleteStaffbtn.BackgroundImage = My.Resources.addadminstaff
        deleteStaffbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub
End Class