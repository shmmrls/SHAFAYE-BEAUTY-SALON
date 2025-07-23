Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp
Imports System.Security.Cryptography
Imports System.Text

Public Class editstaff
    Dim conn As New MySqlConnection("server=localhost;user=root;password=;database=final_shafaye_salon;")

    Private Sub addStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Add("admin")
        cmbRole.Items.Add("staff")
        cmbRole.SelectedIndex = 0
        UpdateStaffFieldsVisibility()
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

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        UpdateStaffFieldsVisibility()
    End Sub

    Private Sub UpdateStaffFieldsVisibility()
        Dim isStaff As Boolean = (cmbRole.SelectedItem.ToString() = "staff")
        txtposition.Visible = isStaff
        txtsalary.Visible = isStaff
        lblposition.Visible = isStaff
        lblsalary.Visible = isStaff
        rbActive.Visible = isStaff
        rbInactive.Visible = isStaff
        lblstatus.Visible = isStaff
        RoundedTextBox1.Visible = isStaff
        RoundedTextBox3.Visible = isStaff
    End Sub

    Private Sub addstaffadmin_Click(sender As Object, e As EventArgs) Handles addstaffadmin.Click
        If fntext.Text = "" Or lntext.Text = "" Or untxt.Text = "" Then
            MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If cmbRole.SelectedItem Is Nothing Then
            MsgBox("Please select a role.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim role As String = cmbRole.SelectedItem.ToString()
        Dim defaultPassword As String = If(role = "admin", "shaFayeAdmin2010!", "
!")
        Dim status As String = If(rbActive.Checked, "Active", "Inactive")

        Try
            conn.Open()

            Dim hashedPassword = HashPassword(defaultPassword)
            Dim cmdRegister As New MySqlCommand("INSERT INTO user_register (first_name, last_name, username, password, role) VALUES (@fname, @lname, @uname, @pass, @role); SELECT LAST_INSERT_ID();", conn)
            cmdRegister.Parameters.AddWithValue("@fname", fntext.Text)
            cmdRegister.Parameters.AddWithValue("@lname", lntext.Text)
            cmdRegister.Parameters.AddWithValue("@uname", untxt.Text)
            cmdRegister.Parameters.AddWithValue("@pass", hashedPassword)
            cmdRegister.Parameters.AddWithValue("@role", role)

            Dim newUserID As Integer = Convert.ToInt32(cmdRegister.ExecuteScalar())

            If role = "staff" Then
                If txtposition.Text = "" Or txtsalary.Text = "" Then
                    MsgBox("Please complete position and salary fields for staff.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                Dim cmdStaff As New MySqlCommand("INSERT INTO staff (user_id, position, salary, status) VALUES (@uid, @position, @salary, @status)", conn)
                cmdStaff.Parameters.AddWithValue("@uid", newUserID)
                cmdStaff.Parameters.AddWithValue("@position", txtposition.Text)
                cmdStaff.Parameters.AddWithValue("@salary", Convert.ToDecimal(txtsalary.Text))
                cmdStaff.Parameters.AddWithValue("@status", status)
                cmdStaff.ExecuteNonQuery()
            End If

            MsgBox("User added successfully!", MsgBoxStyle.Information)
            ClearAddFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
        LoadStaffTable()
    End Sub

    Private Sub addstaffadmin_MouseEnter(sender As Object, e As EventArgs) Handles addstaffadmin.MouseEnter
        addstaffadmin.BackgroundImage = My.Resources.addadminstaff2
        addstaffadmin.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub addstaffadmin_MouseLeave(sender As Object, e As EventArgs) Handles addstaffadmin.MouseLeave
        addstaffadmin.BackgroundImage = My.Resources.addadminstaff
        addstaffadmin.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub editstaffinfo_Click(sender As Object, e As EventArgs) Handles editstaffinfo.Click
        Panel3.Visible = True
    End Sub

    Private Sub ClearAddFields()
        fntext.Clear()
        lntext.Clear()
        untxt.Clear()
        txtposition.Clear()
        txtsalary.Clear()
        rbActive.Checked = False
        rbInactive.Checked = False
        cmbRole.SelectedIndex = 0
    End Sub


    Private Sub saveEditbtn_Click(sender As Object, e As EventArgs) Handles saveEditbtn.Click
        If saveEditbtn.Tag Is Nothing Then
            MessageBox.Show("No staff selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim staffID As Integer = Convert.ToInt32(saveEditbtn.Tag)
        Dim firstName As String = fntxtedit.Text.Trim()
        Dim lastName As String = lntxtedit.Text.Trim()
        Dim position As String = txtPositionEdit.Text.Trim()
        Dim salary As Decimal
        Dim status As String = If(activeEditrdb.Checked, "Active", "Inactive")

        If Not Decimal.TryParse(txtSalaryedit.Text, salary) Then
            MessageBox.Show("Invalid salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        conn.Open()

        ' Update user_register table
        Dim updateUser As New MySqlCommand("UPDATE user_register u JOIN staff s ON u.user_id = s.user_id SET u.first_name = @fname, u.last_name = @lname WHERE s.staff_id = @staff_id", conn)
        updateUser.Parameters.AddWithValue("@fname", firstName)
        updateUser.Parameters.AddWithValue("@lname", lastName)
        updateUser.Parameters.AddWithValue("@staff_id", staffID)
        updateUser.ExecuteNonQuery()

        ' Update staff table
        Dim updateStaff As New MySqlCommand("UPDATE staff SET position = @position, salary = @salary, status = @status WHERE staff_id = @staff_id", conn)
        updateStaff.Parameters.AddWithValue("@position", position)
        updateStaff.Parameters.AddWithValue("@salary", salary)
        updateStaff.Parameters.AddWithValue("@status", status)
        updateStaff.Parameters.AddWithValue("@staff_id", staffID)
        updateStaff.ExecuteNonQuery()

        conn.Close()

        MessageBox.Show("Staff information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadStaffTable()
    End Sub

    Private Sub dgvStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvStaff.Rows(e.RowIndex)
            saveEditbtn.Tag = row.Cells("staff_id").Value

            fntxtedit.Text = row.Cells("first_name").Value.ToString()
            lntxtedit.Text = row.Cells("last_name").Value.ToString()
            txtPositionEdit.Text = row.Cells("position").Value.ToString()
            txtSalaryedit.Text = row.Cells("salary").Value.ToString()

            Dim status As String = row.Cells("status").Value.ToString()
            If status = "Active" Then
                activeEditrdb.Checked = True
            Else
                inactiveEditrdb.Checked = True
            End If

            Panel3.Visible = True
        End If
    End Sub

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

    Private Sub backtoaddtxt_Click(sender As Object, e As EventArgs) Handles backtoaddtxt.Click
        Panel3.Visible = False
    End Sub

    Private Sub cancelEditbtn_Click(sender As Object, e As EventArgs) Handles cancelEditbtn.Click
        fntxtedit.Clear()
        lntxtedit.Clear()
        txtPositionEdit.Clear()
        txtSalaryedit.Clear()
        activeEditrdb.Checked = False
        inactiveEditrdb.Checked = False
        Panel3.Visible = False
    End Sub
End Class
