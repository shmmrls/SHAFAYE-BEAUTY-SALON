Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Security.Cryptography
Imports System.Text


Public Class userMenu

    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=final_shafaye_salon;User=root;Password=;")
    Public sql As String
    Public sql1 As String
    Public sql2 As String
    Public dbcomm As MySqlCommand



    Private someForm As Form = Nothing
    Private Sub OpenChildForm(childForm As Form)
        If someForm IsNot Nothing Then
            someForm.Close()
        End If

        someForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelChildForm.Controls.Add(childForm)
        panelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    'password hashing
    Private Function HashPassword(password As String) As String
        Dim sha As SHA256 = SHA256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha.ComputeHash(bytes)
        Dim sb As New StringBuilder()
        For Each b As Byte In hash
            sb.Append(b.ToString("x2"))
        Next
        Return sb.ToString()
    End Function

    'password condition
    Private Function IsPasswordStrong(pw As String) As Boolean
        Dim hasUpper As Boolean = pw.Any(AddressOf Char.IsUpper)
        Dim hasLower As Boolean = pw.Any(AddressOf Char.IsLower)
        Dim hasNumber As Boolean = pw.Any(AddressOf Char.IsDigit)
        Dim hasSymbol As Boolean = pw.Any(Function(c) Not Char.IsLetterOrDigit(c))
        Return pw.Length >= 8 AndAlso hasUpper AndAlso hasLower AndAlso hasNumber AndAlso hasSymbol
    End Function
    Private Sub proff_VisibleChanged(sender As Object, e As EventArgs) Handles proff.VisibleChanged
        If proff.Visible = True Then
            LoadUserProfile()
        End If
    End Sub
    Private Sub fntext_KeyDown(sender As Object, e As KeyEventArgs) Handles fntext.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            untxt.Focus()
        End If
    End Sub

    Private Sub untext_KeyDown(sender As Object, e As KeyEventArgs) Handles untxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            emailtext.Focus()
        End If
    End Sub

    Private Sub emailtext_KeyDown(sender As Object, e As KeyEventArgs) Handles emailtext.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            phonetext.Focus()
        End If
    End Sub

    Private Sub phonetext_KeyDown(sender As Object, e As KeyEventArgs) Handles phonetext.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            DateOfBirth.Focus()
        End If
    End Sub

    Private Sub DateOfBirth_KeyDown(sender As Object, e As KeyEventArgs) Handles DateOfBirth.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            updateprofile_Click(Nothing, Nothing)
        End If
    End Sub


    Private Sub passtext_KeyDown(sender As Object, e As KeyEventArgs) Handles passtext.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            confirmpasstext.Focus()
        End If
    End Sub

    Private Sub confirmpasstext_KeyDown(sender As Object, e As KeyEventArgs) Handles confirmpasstext.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            updatepass_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub UpdatePasswordPopup()
        Dim pw As String = passtext.Text
        Dim hasUpper = pw.Any(AddressOf Char.IsUpper)
        Dim hasLower = pw.Any(AddressOf Char.IsLower)
        Dim hasDigit = pw.Any(AddressOf Char.IsDigit)
        Dim hasSymbol = pw.Any(Function(c) Not Char.IsLetterOrDigit(c))
        Dim isLongEnough = pw.Length >= 8

        passwordPopupLabel.Text =
        "Password must contain:" & vbCrLf &
        If(isLongEnough, "✔ ", "✘ ") & "At least 8 characters" & vbCrLf &
        If(hasUpper, "✔ ", "✘ ") & "Uppercase letter" & vbCrLf &
        If(hasLower, "✔ ", "✘ ") & "Lowercase letter" & vbCrLf &
        If(hasDigit, "✔ ", "✘ ") & "Number" & vbCrLf &
        If(hasSymbol, "✔ ", "✘ ") & "Symbol"
    End Sub

    Private Sub passtext_TextChanged(sender As Object, e As EventArgs) Handles passtext.TextChanged
        If passwordPopupPanel.Visible Then
            UpdatePasswordPopup()
        End If
    End Sub

    Private Sub updatepass_Click(sender As Object, e As EventArgs) Handles updatepass.Click
        Dim newPassword As String = passtext.Text.Trim()
        Dim confirmPassword As String = confirmpasstext.Text.Trim()
        Dim userId As Integer = 0

        If newPassword = "" Or confirmPassword = "" Then
            MsgBox("Please enter both password fields.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If newPassword <> confirmPassword Then
            MsgBox("Passwords do not match.", MsgBoxStyle.Exclamation)
            passtext.Clear()
            confirmpasstext.Clear()
            passtext.Focus()
            Exit Sub
        End If

        If Not IsPasswordStrong(newPassword) Then
            MsgBox("Password must be at least 8 characters long and include an uppercase letter, lowercase letter, number, and symbol.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Try
            conn.Open()


            Using cmd As New MySqlCommand("SELECT user_id FROM user_register WHERE username = @LoggedInUsername", conn)
                cmd.Parameters.AddWithValue("@LoggedInUsername", LoggedInUsername)
                Dim result = cmd.ExecuteScalar()
                If result Is Nothing Then
                    MsgBox("User not found.")
                    Exit Sub
                End If
                userId = Convert.ToInt32(result)
            End Using


            Dim oldHashedPassword As String = ""
            Dim getPassSql As String = "SELECT password FROM user_register WHERE user_id = @userId"
            Using checkCmd As New MySqlCommand(getPassSql, conn)
                checkCmd.Parameters.AddWithValue("@userId", userId)
                Dim result = checkCmd.ExecuteScalar()
                If result IsNot Nothing Then
                    oldHashedPassword = result.ToString()
                End If
            End Using


            Dim newHashedPassword As String = HashPassword(newPassword)

            If oldHashedPassword = newHashedPassword Then
                MsgBox("New password must be different from the old password.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            Dim updateSql As String = "UPDATE user_register SET password = @password WHERE user_id = @userId"
            Using updateCmd As New MySqlCommand(updateSql, conn)
                updateCmd.Parameters.AddWithValue("@password", newHashedPassword)
                updateCmd.Parameters.AddWithValue("@userId", userId)
                Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Password updated successfully.", MsgBoxStyle.Information)
                Else
                    MsgBox("No matching user found. Password not updated.", MsgBoxStyle.Critical)
                End If
            End Using

            passtext.Clear()
            confirmpasstext.Clear()

        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub passtxt_Enter(sender As Object, e As EventArgs) Handles passtext.Enter
        passwordPopupPanel.Visible = True
        UpdatePasswordPopup()
    End Sub

    Private Sub passtxt_Leave(sender As Object, e As EventArgs) Handles passtext.Leave
        passwordPopupPanel.Visible = False
    End Sub


    Private Sub LoadUserProfile()

        Try
            conn.Open()
            Dim query As String = "SELECT ur.full_name, ur.username, up.email, up.phone, up.date_of_birth " &
                              "FROM user_register ur " &
                              "JOIN user_profiles up ON ur.user_id = up.user_id " &
                              "WHERE ur.username = @username"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", LoggedInUsername)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        fntext.Text = reader("full_name").ToString()
                        untxt.Text = reader("username").ToString()
                        If Not IsDBNull(reader("email")) Then emailtext.Text = reader("email").ToString()
                        If Not IsDBNull(reader("phone")) Then phonetext.Text = reader("phone").ToString()
                        If Not IsDBNull(reader("date_of_birth")) Then DateOfBirth.Value = CDate(reader("date_of_birth"))
                    Else
                        MsgBox("No profile data found.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error loading profile: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub updateprofile_Click(sender As Object, e As EventArgs) Handles updateprofile.Click

        Dim fullName As String = fntext.Text.Trim()
        Dim username As String = untxt.Text.Trim()
        Dim email As String = emailtext.Text.Trim()
        Dim phone As String = phonetext.Text.Trim()
        Dim dob As DateTime = DateOfBirth.Value
        Dim userId As Integer = 0


        Try
            conn.Open()


            Using cmd As New MySqlCommand("SELECT user_id FROM user_register WHERE username = @LoggedInUsername", conn)
                cmd.Parameters.AddWithValue("@LoggedInUsername", LoggedInUsername)
                Dim result = cmd.ExecuteScalar()
                If result Is Nothing Then
                    MsgBox("User not found.")
                    Return
                End If
                userId = Convert.ToInt32(result)
            End Using


            Using cmd1 As New MySqlCommand("UPDATE user_register SET full_name = @FullName, username = @Username WHERE user_id = @UserId", conn)
                cmd1.Parameters.AddWithValue("@FullName", fullName)
                cmd1.Parameters.AddWithValue("@Username", username)
                cmd1.Parameters.AddWithValue("@UserId", userId)
                cmd1.ExecuteNonQuery()
            End Using

            ' Update user_profiles
            Using cmd2 As New MySqlCommand("UPDATE user_profiles SET email = @Email, phone = @Phone, date_of_birth = @DOB WHERE user_id = @UserId", conn)
                cmd2.Parameters.AddWithValue("@Email", email)
                cmd2.Parameters.AddWithValue("@Phone", phone)
                cmd2.Parameters.AddWithValue("@DOB", dob)
                cmd2.Parameters.AddWithValue("@UserId", userId)
                cmd2.ExecuteNonQuery()
            End Using

            ' Update session value (if username was changed)
            LoggedInUsername = username

            MsgBox("Profile updated successfully.")
            proff.Visible = False

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub userMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ""
        proff.Visible = False
        LoadUserProfile()
        'untxt.Text = LoggedInUsername
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        OpenChildForm(New home())
    End Sub

    Private Sub services_Click(sender As Object, e As EventArgs) Handles services.Click
        OpenChildForm(New services())
    End Sub

    Private Sub bookappointment_Click(sender As Object, e As EventArgs) Handles bookappointment.Click
        OpenChildForm(New bookappointment())
    End Sub

    Private Sub review_Click(sender As Object, e As EventArgs) Handles review.Click
        OpenChildForm(New reviews())
    End Sub

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click
        proff.Visible = True
    End Sub

    Private Sub custsupp_Click(sender As Object, e As EventArgs) Handles custsupp.Click
        OpenChildForm(New customersupport())
    End Sub

    Public Sub showpassword_MouseEnter(sender As Object, e As EventArgs) Handles showpassword.MouseEnter
        showpassword.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub showpassword_MouseLeave(sender As Object, e As EventArgs) Handles showpassword.MouseLeave
        showpassword.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Public Sub clear_MouseEnter(sender As Object, e As EventArgs) Handles clear.MouseEnter
        clear.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub clear_MouseLeave(sender As Object, e As EventArgs) Handles clear.MouseLeave
        clear.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub


    Dim isPasswordVisible As Boolean = False

    Private Sub showpassword_Click(sender As Object, e As EventArgs) Handles showpassword.Click
        If isPasswordVisible Then
            passtext.PasswordChar = "✻"c
            confirmpasstext.PasswordChar = "✻"c
            showpassword.Text = "SHOW PASSWORD"
            isPasswordVisible = False
        Else
            passtext.PasswordChar = ControlChars.NullChar
            confirmpasstext.PasswordChar = ControlChars.NullChar
            showpassword.Text = "HIDE PASSWORD"
            isPasswordVisible = True
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        passtext.Clear()
        confirmpasstext.Clear()
    End Sub

End Class