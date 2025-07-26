Imports MySql.Data.MySqlClient

Public Class dailyoverview

    ' Set your DB connection
    Dim connectionString As String = "server=localhost;user=root;password=;database=final_shafaye_salon"

    ' 🔃 Load when form opens
    Private Sub dailyoverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpBookingDate.Value = Date.Today
        LoadRevenue(dtpBookingDate.Value)
        LoadBookings(dtpBookingDate.Value)
    End Sub

    ' 🔍 When user clicks "Search"
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim selectedDate As Date = dtpBookingDate.Value.Date
        LoadRevenue(selectedDate)
        LoadBookings(selectedDate)
    End Sub

    ' 💰 Load total revenue (as of selected date)
    Private Sub LoadRevenue(selectedDate As Date)
        Dim totalRevenue As Decimal = 0

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT IFNULL(SUM(amount), 0) FROM payments WHERE DATE(payment_date) <= @date"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@date", selectedDate)
                totalRevenue = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
        End Using

        lblRevenue.Text = "Total Revenue (as of " & selectedDate.ToString("MMMM dd, yyyy") & "): ₱" & totalRevenue.ToString("N2")
    End Sub

    ' 📅 Load all bookings for selected date
    Private Sub LoadBookings(selectedDate As Date)
        flpBookings.Controls.Clear()
        lblBookingsTitle.Text = "Bookings for " & selectedDate.ToString("MMMM dd, yyyy") & ":"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT time, client_name, service_name, status FROM bookings WHERE DATE(booking_date) = @date ORDER BY time ASC"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@date", selectedDate)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim time As String = reader("time").ToString()
                        Dim client As String = reader("client_name").ToString()
                        Dim service As String = reader("service_name").ToString()
                        Dim status As String = reader("status").ToString()

                        Dim card As Panel = CreateBookingCard(time, client, service, status)
                        flpBookings.Controls.Add(card)
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' 🧾 Create visual booking card (Panel)
    Private Function CreateBookingCard(time As String, client As String, service As String, status As String) As Panel
        Dim card As New Panel With {
            .Width = 280,
            .Height = 100,
            .BackColor = Color.White,
            .BorderStyle = BorderStyle.FixedSingle,
            .Margin = New Padding(10),
            .Padding = New Padding(10)
        }

        Dim lblTime As New Label With {
            .Text = "TIME: " & time,
            .Font = New Font("Segoe UI", 10),
            .AutoSize = True,
            .Location = New Point(10, 10)
        }

        Dim lblClient As New Label With {
            .Text = "CLIENT: " & client,
            .Font = New Font("Segoe UI", 10),
            .AutoSize = True,
            .Location = New Point(10, 30)
        }

        Dim lblService As New Label With {
            .Text = "SERVICE: " & service,
            .Font = New Font("Segoe UI", 10),
            .AutoSize = True,
            .Location = New Point(10, 50)
        }

        Dim lblStatus As New Label With {
            .Text = "STATUS: " & status,
            .Font = New Font("Segoe UI", 10),
            .AutoSize = True,
            .Location = New Point(10, 70)
        }

        card.Controls.Add(lblTime)
        card.Controls.Add(lblClient)
        card.Controls.Add(lblService)
        card.Controls.Add(lblStatus)

        Return card
    End Function

End Class
