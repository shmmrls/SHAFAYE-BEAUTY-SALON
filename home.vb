Public Class home
    Private Sub booknow_MouseEnter(sender As Object, e As EventArgs) Handles booknow.MouseEnter
        booknow.BackgroundImage = My.Resources.booknow2
        booknow.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub booknow_MouseLeave(sender As Object, e As EventArgs) Handles booknow.MouseLeave
        booknow.BackgroundImage = My.Resources.book_now
        booknow.BackgroundImageLayout = ImageLayout.Zoom
    End Sub
End Class