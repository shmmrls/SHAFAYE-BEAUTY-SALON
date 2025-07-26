Imports MySql.Data.MySqlClient
Public Class quickStats

    Private Sub frmQuickStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuickStats()
    End Sub

    Private Sub LoadQuickStats()
        Dim connStr As String = "server=localhost;user=root;password=;database=final_shafaye_salon"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                ' ▶ TOTAL CLIENTS
                Dim clientQuery As String = "SELECT COUNT(*) FROM clients"
                Using cmdClients As New MySqlCommand(clientQuery, conn)
                    Dim totalClients As Integer = Convert.ToInt32(cmdClients.ExecuteScalar())
                    lblTotalClientsValue.Text = totalClients.ToString()
                End Using

                ' ▶ MONTHLY REVENUE
                Dim startOfMonth As Date = New Date(Date.Today.Year, Date.Today.Month, 1)
                Dim endOfMonth As Date = startOfMonth.AddMonths(1).AddDays(-1)
                Dim revenueQuery As String = "SELECT IFNULL(SUM(total_amount), 0) FROM appointments WHERE appointment_date BETWEEN @start AND @end"

                Using cmdRevenue As New MySqlCommand(revenueQuery, conn)
                    cmdRevenue.Parameters.AddWithValue("@start", startOfMonth)
                    cmdRevenue.Parameters.AddWithValue("@end", endOfMonth)

                    Dim monthlyRevenue As Decimal = Convert.ToDecimal(cmdRevenue.ExecuteScalar())
                    lblMonthlyRevenueValue.Text = "₱" & monthlyRevenue.ToString("N2")
                End Using

            Catch ex As Exception
                MessageBox.Show("Failed to load quick stats: " & ex.Message)
            End Try
        End Using
    End Sub


End Class
