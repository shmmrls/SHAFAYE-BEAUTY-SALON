Public Class home

    ' mp4 Any/Other CRUD functions
    '  READ/NAVIGATE: Opens booking form with passed UserID.

    'APPOINTMENT BOOKING
    'Clients can select services, choose preferred date/time, and will be assigned to a staff
    'that will handle their needs.
    Public Property LoggedInUserID As Integer
    Private Sub booknow_MouseEnter(sender As Object, e As EventArgs) Handles booknow.MouseEnter
        booknow.BackgroundImage = My.Resources.booknow2
        booknow.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub booknow_MouseLeave(sender As Object, e As EventArgs) Handles booknow.MouseLeave
        booknow.BackgroundImage = My.Resources.book_now
        booknow.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub booknow_Click(sender As Object, e As EventArgs) Handles booknow.Click
        userMenu.OpenChildForm(New bookappointment(LoggedInUserID))
    End Sub
End Class