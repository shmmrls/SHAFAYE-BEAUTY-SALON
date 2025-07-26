Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class adminControl
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=final_shafaye_salon")

    Private Sub adminControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAdmins()
    End Sub

    Private Sub LoadAdmins()
        If conn.State = ConnectionState.Open Then conn.Close()
        Dim query As String = "SELECT user_id, first_name, last_name, username FROM user_register WHERE role = 'Admin'"

        Try
            conn.Open()
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvAdmin.DataSource = table

            With dgvAdmin
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
                .DefaultCellStyle.SelectionBackColor = Color.LightGray
                .DefaultCellStyle.SelectionForeColor = Color.Black

                .Columns("user_id").HeaderText = "User ID"
                .Columns("first_name").HeaderText = "First Name"
                .Columns("last_name").HeaderText = "Last Name"
                .Columns("username").HeaderText = "Username"

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading admins: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub saveEditbtn_Click(sender As Object, e As EventArgs) Handles saveEditbtn.Click
        If dgvAdmin.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an admin to edit.")
            Return
        End If

        Dim selectedId = Convert.ToInt32(dgvAdmin.SelectedRows(0).Cells("user_id").Value)
        Dim query As String = "UPDATE user_register SET first_name = @fn, last_name = @ln, username = @un WHERE user_id = @id"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fn", fntxtedit.Text.Trim())
                cmd.Parameters.AddWithValue("@ln", lntxtedit.Text.Trim())
                cmd.Parameters.AddWithValue("@un", untxt.Text.Trim())
                cmd.Parameters.AddWithValue("@id", selectedId)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Admin details updated successfully!")
            LoadAdmins()
        Catch ex As Exception
            MessageBox.Show("Error updating admin: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function IsStrongPassword(password As String) As Boolean
        Dim hasUpper As Boolean = password.Any(AddressOf Char.IsUpper)
        Dim hasLower As Boolean = password.Any(AddressOf Char.IsLower)
        Dim hasDigit As Boolean = password.Any(AddressOf Char.IsDigit)
        Dim hasSymbol As Boolean = password.Any(Function(c) Not Char.IsLetterOrDigit(c))
        Return password.Length >= 8 AndAlso hasUpper AndAlso hasLower AndAlso hasDigit AndAlso hasSymbol
    End Function

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(password)
            Dim hash = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub btnConfirmAdminPass_Click(sender As Object, e As EventArgs) Handles btnConfirmAdminPass.Click
        Dim newPass = adminNewPassTxt.Text.Trim()
        If Not IsStrongPassword(newPass) Then
            MessageBox.Show("Password must have at least 1 upper, 1 lower, 1 number, 1 symbol, and be at least 8 characters long.")
            Return
        End If

        Dim hashedPass = HashPassword(newPass)
        Dim query As String = "UPDATE user_register SET password = @pass WHERE role = 'Admin'"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@pass", hashedPass)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("All admin passwords updated. Please log in again.")
            Application.Restart()
        Catch ex As Exception
            MessageBox.Show("Error updating admin passwords: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnConfirmStaffPass_Click(sender As Object, e As EventArgs) Handles btnConfirmStaffPass.Click
        Dim newPass = newPassStafftxt.Text.Trim()
        If Not IsStrongPassword(newPass) Then
            MessageBox.Show("Password must have at least 1 upper, 1 lower, 1 number, 1 symbol, and be at least 8 characters long.")
            Return
        End If

        Dim hashedPass = HashPassword(newPass)
        Dim query As String = "UPDATE user_register SET password = @pass WHERE role = 'Staff'"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@pass", hashedPass)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("All staff passwords updated successfully!")
        Catch ex As Exception
            MessageBox.Show("Error updating staff passwords: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dgvAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdmin.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAdmin.Rows(e.RowIndex)
            fntxtedit.Text = row.Cells("first_name").Value.ToString()
            lntxtedit.Text = row.Cells("last_name").Value.ToString()
            untxt.Text = row.Cells("username").Value.ToString()
        End If
    End Sub

    Private Sub btnDeleteAdmin_Click(sender As Object, e As EventArgs) Handles btnDeleteAdmin.Click
        If dgvAdmin.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an admin to delete.")
            Return
        End If

        Dim selectedId = Convert.ToInt32(dgvAdmin.SelectedRows(0).Cells("user_id").Value)
        Dim confirm = MessageBox.Show("Are you sure you want to delete this admin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Exit Sub

        Dim query As String = "DELETE FROM user_register WHERE user_id = @id AND role = 'Admin'"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", selectedId)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Admin deleted successfully!")
            LoadAdmins()
        Catch ex As Exception
            MessageBox.Show("Error deleting admin: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
