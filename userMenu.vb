Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Security.Cryptography
Imports System.Text


Public Class userMenu
    Public LoggedInUserID As Integer
    Private currentForm As Form = Nothing



    Public Sub OpenChildForm(childForm As Form)
        If currentForm IsNot Nothing Then
            currentForm.Hide()
        End If

        currentForm = childForm
        With childForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .StartPosition = FormStartPosition.Manual
        End With

        panelChildForm.Controls.Clear()
        panelChildForm.Controls.Add(childForm)
        panelChildForm.Padding = New Padding(0) ' Ensure no spacing
        panelChildForm.Margin = New Padding(0)
        panelChildForm.AutoScroll = False

        childForm.Show()
        childForm.BringToFront()
        Application.DoEvents()
    End Sub


    Private Sub userMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim homeForm As New home()
        homeForm.LoggedInUserID = LoggedInUserID
        OpenChildForm(homeForm)
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles hometxt.Click
        Dim homeForm As New home()
        homeForm.LoggedInUserID = LoggedInUserID
        OpenChildForm(homeForm)
    End Sub

    Private Sub services_Click(sender As Object, e As EventArgs) Handles servicestxt.Click
        OpenChildForm(New services())
    End Sub

    Private Sub bookappointment_Click(sender As Object, e As EventArgs) Handles bookappointmenttxt.Click
        Dim ba As New bookappointment(LoggedInUserID)
        OpenChildForm(ba)
    End Sub

    Private Sub review_Click(sender As Object, e As EventArgs) Handles reviewtxt.Click
        OpenChildForm(New reviews())
    End Sub

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profiletxt.Click
        ' switchpanel(New profile())
        OpenChildForm(New profile())
        'proff.Visible = True
    End Sub

    Private Sub custsupp_Click(sender As Object, e As EventArgs) Handles custsupptxt.Click
        OpenChildForm(New customersupport())
    End Sub

    Public Sub home_MouseEnter(sender As Object, e As EventArgs) Handles hometxt.MouseEnter
        hometxt.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub home_MouseLeave(sender As Object, e As EventArgs) Handles hometxt.MouseLeave
        hometxt.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Public Sub services_MouseEnter(sender As Object, e As EventArgs) Handles servicestxt.MouseEnter
        servicestxt.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub services_MouseLeave(sender As Object, e As EventArgs) Handles servicestxt.MouseLeave
        servicestxt.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Public Sub bookappointment_MouseEnter(sender As Object, e As EventArgs) Handles bookappointmenttxt.MouseEnter
        bookappointmenttxt.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub bookappointment_MouseLeave(sender As Object, e As EventArgs) Handles bookappointmenttxt.MouseLeave
        bookappointmenttxt.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Public Sub review_MouseEnter(sender As Object, e As EventArgs) Handles reviewtxt.MouseEnter
        reviewtxt.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub review_MouseLeave(sender As Object, e As EventArgs) Handles reviewtxt.MouseLeave
        reviewtxt.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Public Sub transachistxt_MouseEnter(sender As Object, e As EventArgs) Handles transachistxt.MouseEnter
        transachistxt.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub transachistxt_MouseLeave(sender As Object, e As EventArgs) Handles transachistxt.MouseLeave
        transachistxt.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Public Sub profile_MouseEnter(sender As Object, e As EventArgs) Handles profiletxt.MouseEnter
        profiletxt.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub profile_MouseLeave(sender As Object, e As EventArgs) Handles profiletxt.MouseLeave
        profiletxt.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Public Sub custsupp_MouseEnter(sender As Object, e As EventArgs) Handles custsupptxt.MouseEnter
        custsupptxt.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub custsupp_MouseLeave(sender As Object, e As EventArgs) Handles custsupptxt.MouseLeave
        custsupptxt.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logouttxt.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            homepage.Show()
        End If
    End Sub

    Public Sub logouttxt_MouseEnter(sender As Object, e As EventArgs) Handles logouttxt.MouseEnter
        logouttxt.ForeColor = Color.FromArgb(255, 128, 128)
    End Sub

    Public Sub logouttxt_MouseLeave(sender As Object, e As EventArgs) Handles logouttxt.MouseLeave
        logouttxt.ForeColor = Color.FromArgb(77, 0, 18)
    End Sub

End Class