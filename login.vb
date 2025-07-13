
Public Class login

    Private Sub signinbtn_Click(sender As Object, e As EventArgs) Handles signinbtn.Click

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


End Class