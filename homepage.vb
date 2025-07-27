Public Class homepage

    'FOR PUBLIC HOMEPAGE ACCESS
    'Non-logged-in users can view general features Like services, reviews, And FAQs,
    'And are prompted to log in Or sign up to book appointments.
    Private currentForm As Form = Nothing

    Private Sub OpenChildForm(childForm As Form)
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If

        currentForm = childForm
        With childForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .StartPosition = FormStartPosition.Manual
            .Bounds = panelChildForm.ClientRectangle
        End With

        panelChildForm.Controls.Clear()
        panelChildForm.Controls.Add(childForm)
        panelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub


    Private Sub signinbtn_Click(sender As Object, e As EventArgs) Handles signinbtn.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub signupbtn_Click(sender As Object, e As EventArgs) Handles signupbtn.Click
        signup.Show()
        Me.Hide()
    End Sub

    Private Sub homesigninbtn_MouseEnter(sender As Object, e As EventArgs) Handles signinbtn.MouseEnter
        signinbtn.BackgroundImage = My.Resources.hompgsignin2_0
        signinbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub homesigninbtn_MouseLeave(sender As Object, e As EventArgs) Handles signinbtn.MouseLeave
        signinbtn.BackgroundImage = My.Resources.hompgsignin
        signinbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub homesignupbtn_MouseEnter(sender As Object, e As EventArgs) Handles signupbtn.MouseEnter
        signupbtn.BackgroundImage = My.Resources.hompgsignup2_0
        signupbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub homesignupbtn_MouseLeave(sender As Object, e As EventArgs) Handles signupbtn.MouseLeave
        signupbtn.BackgroundImage = My.Resources.hompgsignup
        signupbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Public Sub adminbtntxt_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub adminbtntxt_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.FromArgb(77, 0, 18)
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        adminstafflogin.Show()
        Me.Hide()
    End Sub

    Private Sub homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Dim fadeTimer As New Timer With {.Interval = 10}
        AddHandler fadeTimer.Tick, Sub()
                                       Me.Opacity += 0.05
                                       If Me.Opacity >= 1 Then fadeTimer.Stop()
                                   End Sub
        fadeTimer.Start()
        panelChildForm.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Show()
        panelChildForm.Visible = False
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        Me.Show()
        panelChildForm.Visible = False
    End Sub

    Private Sub services_Click(sender As Object, e As EventArgs) Handles services.Click
        panelChildForm.Visible = True
        OpenChildForm(New servicesforhomepage())
    End Sub

    Private Sub bookappointment_Click(sender As Object, e As EventArgs) Handles bookappointment.Click
        MsgBox("Please log in or sign up to book an appointment.", MsgBoxStyle.Exclamation, "Login Required")
        Me.Show()
    End Sub

    Private Sub review_Click(sender As Object, e As EventArgs) Handles review.Click
        panelChildForm.Visible = True
        OpenChildForm(New reviewshomepage())
    End Sub

    Private Sub faq_Click(sender As Object, e As EventArgs) Handles faq.Click
        panelChildForm.Visible = True
        OpenChildForm(New faq())
    End Sub

    Public Sub home_MouseEnter(sender As Object, e As EventArgs) Handles home.MouseEnter
        home.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub home_MouseLeave(sender As Object, e As EventArgs) Handles home.MouseLeave
        home.ForeColor = Color.White
    End Sub

    Public Sub services_MouseEnter(sender As Object, e As EventArgs) Handles services.MouseEnter
        services.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub services_MouseLeave(sender As Object, e As EventArgs) Handles services.MouseLeave
        services.ForeColor = Color.White
    End Sub

    Public Sub bookappointment_MouseEnter(sender As Object, e As EventArgs) Handles bookappointment.MouseEnter
        bookappointment.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub bookappointment_MouseLeave(sender As Object, e As EventArgs) Handles bookappointment.MouseLeave
        bookappointment.ForeColor = Color.White
    End Sub

    Public Sub review_MouseEnter(sender As Object, e As EventArgs) Handles review.MouseEnter
        review.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub review_MouseLeave(sender As Object, e As EventArgs) Handles review.MouseLeave
        review.ForeColor = Color.White

    End Sub

    Public Sub faq_MouseEnter(sender As Object, e As EventArgs) Handles faq.MouseEnter
        faq.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub faq_MouseLeave(sender As Object, e As EventArgs) Handles faq.MouseLeave
        faq.ForeColor = Color.White
    End Sub

End Class