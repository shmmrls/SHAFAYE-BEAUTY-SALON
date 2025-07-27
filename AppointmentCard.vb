Imports System.Drawing.Drawing2D

'FOR APPOINTMENT BOOKING → REVIEW APPOINTMENT (For Clients)
'Customers can view upcoming and past appointments.”
Public Class AppointmentCard
    Public Property BorderRadius As Integer = 20
    Public Property BorderColor As Color = Color.Silver
    Public Property BorderSize As Integer = 1

    Public Sub SetData(serviceName As String, staffName As String, appointmentTime As String, status As String)
        lblService.Text = serviceName
        lblStaff.Text = "Staff: " & staffName
        lblTime.Text = "Time: " & appointmentTime
        lblStatus.Text = "Status: " & status

        Select Case status.ToLower()
            Case "pending"
                lblStatus.BackColor = Color.Orange
            Case "confirmed"
                lblStatus.BackColor = Color.ForestGreen
            Case "completed"
                lblStatus.BackColor = Color.SteelBlue
            Case "cancelled"
                lblStatus.BackColor = Color.IndianRed
            Case Else
                lblStatus.BackColor = Color.Gray
        End Select
    End Sub

    Private Sub AppointmentCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.White
        Me.Padding = New Padding(15)
        Me.Margin = New Padding(10)
        Me.Font = New Font("Segoe UI", 10, FontStyle.Regular)

        lblService.Font = New Font("Segoe UI Semibold", 11)
        lblStaff.Font = New Font("Segoe UI", 10)
        lblTime.Font = New Font("Segoe UI", 10)
        lblStatus.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        lblStatus.ForeColor = Color.White
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        lblStatus.AutoSize = False
        lblStatus.Height = 30
        lblStatus.Dock = DockStyle.Bottom
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

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

    Private Sub AppointmentCard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Invalidate()
    End Sub
End Class
