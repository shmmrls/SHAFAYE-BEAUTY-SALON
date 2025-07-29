Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

'FOR ROLE-BASED ACCESS CONTROL
'Admin/ Staff will have special access to manage the system based on their roles.

Public Class adminstafflogin

    Dim conn As MySqlConnection = New MySqlConnection("Server=localhost;Database=final_shafaye_salon;Uid=salon_webapp;Pwd=WebApp2025!;")
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


    Private Sub usernametxt_KeyDown(sender As Object, e As KeyEventArgs) Handles usernametxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            passtxt.Focus()
        End If
    End Sub

    Private Sub passtxt_KeyDown(sender As Object, e As KeyEventArgs) Handles passtxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            signinbtn_click(Nothing, Nothing)
        End If
    End Sub

    Private Sub signinbtn_Click(sender As Object, e As EventArgs) Handles signinbtn.Click
        Dim username As String = usernametxt.Text.Trim()
        Dim password As String = passtxt.Text.Trim()

        If username = "" Or password = "" Then
            MsgBox("Please fill out all required fields.")
            Exit Sub
        End If

        Try
            conn.Open()

            Dim sql As String = "SELECT role FROM user_register WHERE username = @username AND password = @password"
            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.Parameters.AddWithValue("@username", username)
            dbcomm.Parameters.AddWithValue("@password", HashPassword(password))

            Dim reader As MySqlDataReader = dbcomm.ExecuteReader()

            If reader.Read() Then
                Dim role As String = reader("role").ToString()




                If role = "admin" Then
                    MsgBox("Login successful!", MsgBoxStyle.Information)
                    adminMenu.Show()
                ElseIf role = "staff" Then
                    MsgBox("Login successful!", MsgBoxStyle.Information)
                    Dim staffMenuForm As New staffMenu()
                    staffMenuForm.Show()
                Else
                    MsgBox("This page is for admin or staff only. Please use the client login page.", MsgBoxStyle.Exclamation, "Access Denied")
                    login.Show()
                    Me.Hide()
                End If

                Me.Hide()
            Else
                MsgBox("Username or password incorrect.")
            End If

            reader.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
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



    Private Sub adminstafflogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        homepage.Show()
        Me.Hide()
    End Sub
End Class