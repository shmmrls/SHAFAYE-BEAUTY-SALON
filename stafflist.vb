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
End Class