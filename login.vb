Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class login
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=shafaye_salon;User=root;Password=;")
    Public sql As String
    Public dbcomm As MySqlCommand

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


    Private Sub usernametxt_KeyDown(sender As Object, e As KeyEventArgs) Handles usernametxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            passtxt.Focus()
        End If
    End Sub

    Private Sub passtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles passtxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            signinbtn_Click(Nothing, Nothing)
        End If
    End Sub


    Private Sub signinbtn_Click(sender As Object, e As EventArgs) Handles signinbtn.Click
        Dim username As String = usernametxt.Text.Trim().ToLower()
        Dim password As String = passtxt.Text.Trim()

        If username = "" Or password = "" Then
            MsgBox("Please fill out all required fields.")
            Exit Sub
        End If

        Try
            conn.Open()

            Dim sql As String = "SELECT COUNT(*) FROM user_register WHERE username = @username AND password = @password"
            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.Parameters.AddWithValue("@username", username)
            dbcomm.Parameters.AddWithValue("@password", HashPassword(password))


            Dim matchCount As Integer = CInt(dbcomm.ExecuteScalar())

            If matchCount > 0 Then
                MsgBox("Login successful!", MsgBoxStyle.Information, "Welcome")
                usernametxt.Clear()
                passtxt.Clear()
                Me.Hide()
                adminMenu.Show()
            Else
                MessageBox.Show("Entered Hash: " & HashPassword(password))
                MsgBox("Username or password does not match. Please try again.", MsgBoxStyle.Critical, "Login Failed")
            End If

        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("Unexpected error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub signinbtn_MouseEnter(sender As Object, e As EventArgs) Handles signinbtn.MouseEnter
        signinbtn.BackgroundImage = My.Resources.signinbutton1_0
        signinbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub signinbtn_MouseLeave(sender As Object, e As EventArgs) Handles signinbtn.MouseLeave
        signinbtn.BackgroundImage = My.Resources.signinbutton
        signinbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub signuppage_Click(sender As Object, e As EventArgs) Handles signuppage.Click
        signup.Show()
        Me.Hide()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Dim fadeTimer As New Timer With {.Interval = 10}
        AddHandler fadeTimer.Tick, Sub()
                                       Me.Opacity += 0.05
                                       If Me.Opacity >= 1 Then fadeTimer.Stop()
                                   End Sub
        fadeTimer.Start()
    End Sub

    Dim isPasswordVisible As Boolean = False

    Private Sub showpassword_Click(sender As Object, e As EventArgs) Handles showpassword.Click
        If isPasswordVisible Then
            passtxt.PasswordChar = "✻"c
            showpassword.Text = "Show Password"
            isPasswordVisible = False
        Else
            passtxt.PasswordChar = ControlChars.NullChar
            showpassword.Text = "Hide Password"
            isPasswordVisible = True
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        usernametxt.Clear()
        passtxt.Clear()
    End Sub
End Class