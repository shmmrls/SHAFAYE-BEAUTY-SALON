Imports System.Drawing.Drawing2D

'for feedback and reviews
Public Class ReviewCard
    Public Property BorderRadius As Integer = 25



    Public Property BorderColor As Color = Color.DarkGray
    Public Property BorderSize As Integer = 2

    Private Sub RoundedTextBox_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90)
        path.AddArc(Me.Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90)
        path.AddArc(Me.Width - BorderRadius, Me.Height - BorderRadius, BorderRadius, BorderRadius, 0, 90)
        path.AddArc(0, Me.Height - BorderRadius, BorderRadius, BorderRadius, 90, 90)
        path.CloseAllFigures()

        Me.Region = New Region(path)

        Using pen As New Pen(BorderColor, BorderSize)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            e.Graphics.DrawPath(pen, path)
        End Using
    End Sub

    Private Sub RoundedTextBox_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Invalidate()
    End Sub



    Public Sub DisableAllTextboxes()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Panel Then
                For Each innerCtrl As Control In ctrl.Controls
                    If TypeOf innerCtrl Is TextBox Then
                        CType(innerCtrl, TextBox).ReadOnly = True
                    End If
                Next
            End If
        Next
    End Sub

    Public Sub SetReviewData(serviceName As String, staffName As String, serviceRating As Integer, staffRating As Integer, comment As String)
        lblService.Text = "Service: " & serviceName
        lblStaff.Text = "Staff: " & staffName
        lblComment.Text = """" & comment & """"

        lblServiceStars.Text = "Service Rating: " & GetStars(serviceRating)
        lblStaffStars.Text = "Staff Rating: " & GetStars(staffRating)
    End Sub

    Private Function GetStars(rating As Integer) As String
        Dim stars As String = New String("★", rating)
        stars &= New String("☆", 5 - rating)
        Return stars
    End Function
End Class
