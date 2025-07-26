Imports MySql.Data.MySqlClient
Public Class usageLogs

    Dim conn As New MySqlConnection("server=localhost;user=root;password=;database=final_shafaye_salon")

    Private Sub UsageLogsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServices()
    End Sub

    Private Sub LoadServices()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM services", conn)
            Dim reader = cmd.ExecuteReader()
            cbService.Items.Clear()
            While reader.Read()
                cbService.Items.Add(New With {
                    .Text = reader("service_name").ToString(),
                    .Value = reader("service_id")
                })
            End While
            cbService.DisplayMember = "Text"
            cbService.ValueMember = "Value"
        Catch ex As Exception
            MessageBox.Show("Error loading services: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cbService.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a service.")
            Return
        End If
        Dim selectedId = cbService.SelectedItem.Value
        LoadUsageLogs(selectedId)
    End Sub

    Private Sub LoadUsageLogs(serviceId As Integer)
        UsageLogPanel.Controls.Clear()
        lblNoData.Visible = False

        Try
            conn.Open()
            Dim query = "SELECT s.supply_name, u.quantity_used, u.usage_date 
                         FROM usage_logs u
                         JOIN supplies s ON u.supply_id = s.supply_id
                         WHERE u.service_id = @sid ORDER BY u.usage_date DESC"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@sid", serviceId)
            Dim reader = cmd.ExecuteReader()

            Dim y As Integer = 10
            Dim hasData = False

            While reader.Read()
                hasData = True
                Dim panel As New Panel With {
                    .Width = UsageLogPanel.Width - 30,
                    .Height = 40,
                    .Top = y,
                    .Left = 10,
                    .BackColor = Color.Gainsboro
                }

                panel.Controls.Add(New Label With {
                    .Text = reader("supply_name").ToString(),
                    .Left = 10, .Top = 10, .AutoSize = True
                })
                panel.Controls.Add(New Label With {
                    .Text = reader("quantity_used").ToString(),
                    .Left = 150, .Top = 10, .AutoSize = True
                })
                panel.Controls.Add(New Label With {
                    .Text = CDate(reader("usage_date")).ToString("yyyy-MM-dd"),
                    .Left = 300, .Top = 10, .AutoSize = True
                })

                UsageLogPanel.Controls.Add(panel)
                y += 50
            End While

            lblNoData.Visible = Not hasData

        Catch ex As Exception
            MessageBox.Show("Error loading logs: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class
