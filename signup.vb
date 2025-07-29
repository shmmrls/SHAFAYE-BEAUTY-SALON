Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

'FOR USER REGISTRATION
'Allow users To register an account With validation, secure password storage, And profile creation.
Public Class signup

    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=final_shafaye_salon;User=salon_webapp;Password=WebApp2025!;")
    Public sql As String
    Public dbcomm As MySqlCommand



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

    Private Function IsPasswordStrong(pw As String) As Boolean
        Dim hasUpper As Boolean = pw.Any(AddressOf Char.IsUpper)
        Dim hasLower As Boolean = pw.Any(AddressOf Char.IsLower)
        Dim hasNumber As Boolean = pw.Any(AddressOf Char.IsDigit)
        Dim hasSymbol As Boolean = pw.Any(Function(c) Not Char.IsLetterOrDigit(c))
        Return pw.Length >= 8 AndAlso hasUpper AndAlso hasLower AndAlso hasNumber AndAlso hasSymbol
    End Function



    Private Sub firstnametxt_KeyDown(sender As Object, e As KeyEventArgs) Handles firstnametxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            lastnametxt.Focus()
        End If
    End Sub
    Private Sub lastnametxt_KeyDown(sender As Object, e As KeyEventArgs) Handles lastnametxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            usernametxt.Focus()
        End If
    End Sub

    Private Sub usernametxt_KeyDown(sender As Object, e As KeyEventArgs) Handles usernametxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            passtxt.Focus()
        End If
    End Sub

    Private Sub passtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles passtxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            confirmpasstx.Focus()
        End If
    End Sub

    Private Sub confirmpasstx_KeyDown(sender As Object, e As KeyEventArgs) Handles confirmpasstx.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            signupbtn_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub signupbtn_Click(sender As Object, e As EventArgs) Handles signupbtn.Click
        Dim firstName As String = firstnametxt.Text.Trim()
        Dim lastName As String = lastnametxt.Text.Trim()
        Dim username As String = usernametxt.Text.Trim()
        Dim password As String = passtxt.Text.Trim()
        Dim confirmpassword As String = confirmpasstx.Text.Trim()

        If firstName = "" Or lastName = "" Or username = "" Or password = "" Or confirmpassword = "" Then
            MsgBox("Please fill out all required fields.")
            Exit Sub
        End If

        If password <> confirmpassword Then
            MsgBox("Passwords do not match. Please try again.", MsgBoxStyle.Exclamation)
            passtxt.Clear()
            confirmpasstx.Clear()
            passtxt.Focus()
            Return
        End If

        If Not IsPasswordStrong(password) Then
            MsgBox("Password must be at least 8 characters long and include an uppercase letter, lowercase letter, number, and symbol.", MsgBoxStyle.Critical)
            Return
        End If

        Try
            conn.Open()

            Dim checkUser As String = $"SELECT COUNT(*) FROM user_register WHERE username = '{username}'"
            Dim cmdCheck As New MySqlCommand(checkUser, conn)
            Dim exists As Integer = CInt(cmdCheck.ExecuteScalar())

            If exists > 0 Then
                MsgBox("Username already exists.")
                conn.Close()
                Exit Sub
            End If

            Dim sql As String = "INSERT INTO user_register (first_name, last_name, username, password) VALUES (@firstName, @lastName, @username, @password)"
            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.Parameters.AddWithValue("@firstName", firstName)
            dbcomm.Parameters.AddWithValue("@lastName", lastName)
            dbcomm.Parameters.AddWithValue("@username", username)
            dbcomm.Parameters.AddWithValue("@password", HashPassword(password))
            dbcomm.ExecuteNonQuery()

            Dim lastId As Integer = CInt(dbcomm.LastInsertedId)

            Dim profileQuery As String = "INSERT INTO user_profiles (user_id, email, phone, date_of_birth) VALUES (@userId, NULL, NULL, NULL)"
            Using profileCmd As New MySqlCommand(profileQuery, conn)
                profileCmd.Parameters.AddWithValue("@userId", lastId)
                profileCmd.ExecuteNonQuery()
            End Using

            MsgBox("User successfully registered. Please proceed to log in.", MsgBoxStyle.Information, "Registration Complete")

            firstnametxt.Clear()
            lastnametxt.Clear()
            usernametxt.Clear()
            passtxt.Clear()
            confirmpasstx.Clear()

            Me.Hide()
            login.Show()

        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("Unexpected error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub signupbtn_MouseEnter(sender As Object, e As EventArgs) Handles signupbtn.MouseEnter
        signupbtn.BackgroundImage = My.Resources.signupbutton1_0
        signupbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub signupbtn_MouseLeave(sender As Object, e As EventArgs) Handles signupbtn.MouseLeave
        signupbtn.BackgroundImage = My.Resources.signupbutton
        signupbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub passtxt_Enter(sender As Object, e As EventArgs) Handles passtxt.Enter
        passwordPopupPanel.Visible = True
        UpdatePasswordPopup()
    End Sub

    Private Sub passtxt_Leave(sender As Object, e As EventArgs) Handles passtxt.Leave
        passwordPopupPanel.Visible = False
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

    Private Sub passtxt_TextChanged(sender As Object, e As EventArgs) Handles passtxt.TextChanged
        UpdatePasswordPopup()
    End Sub

    Private Sub UpdatePasswordPopup()
        Dim pw As String = passtxt.Text
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


    Private Sub signinpage_Click(sender As Object, e As EventArgs) Handles signinpage.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub signup_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        firstnametxt.Focus()
    End Sub

    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        firstnametxt.Focus()
        passwordPopupPanel.Left = passtxt.Left
        passwordPopupPanel.Top = passtxt.Bottom + 5
        passtxt.PasswordChar = "✻"c
        passtxt.UseSystemPasswordChar = False
        confirmpasstx.PasswordChar = "✻"c
        confirmpasstx.UseSystemPasswordChar = False
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        firstnametxt.Clear()
        lastnametxt.Clear()
        usernametxt.Clear()
        passtxt.Clear()
        confirmpasstx.Clear()
    End Sub

    Dim isPasswordVisible As Boolean = False
    Private Sub showpassword_Click(sender As Object, e As EventArgs) Handles showpassword.Click
        If isPasswordVisible Then
            passtxt.PasswordChar = "✻"c
            confirmpasstx.PasswordChar = "✻"c
            showpassword.Text = "SHOW PASSWORD"
            isPasswordVisible = False
        Else
            passtxt.PasswordChar = ControlChars.NullChar
            confirmpasstx.PasswordChar = ControlChars.NullChar
            showpassword.Text = "HIDE PASSWORD"
            isPasswordVisible = True
        End If
    End Sub

    Private Sub passwordPopupPanel_Paint(sender As Object, e As PaintEventArgs) Handles passwordPopupPanel.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        homepage.Show()
        Me.Hide()
    End Sub
End Class