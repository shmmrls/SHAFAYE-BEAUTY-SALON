Imports System.Data
Imports MySql.Data.MySqlClient

Public Class alerts
    ' Database connection string
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=root;Pwd=;"

    Private Sub alerts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLowStockAlerts()
    End Sub

    Private Sub LoadLowStockAlerts()
        Try
            flwAlerts.Controls.Clear()

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Query to get low stock items with usage statistics
                Dim query As String = "
                    SELECT 
                        i.item_id,
                        i.item_name,
                        i.quantity,
                        i.unit,
                        i.reorder_level,
                        COALESCE(usage_stats.total_used, 0) as total_used,
                        COALESCE(usage_stats.usage_count, 0) as usage_count,
                        COALESCE(usage_stats.services_using, '') as services_using
                    FROM inventory i
                    LEFT JOIN (
                        SELECT 
                            iu.item_id,
                            SUM(iu.quantity_used * appointment_count.completed_count) as total_used,
                            COUNT(DISTINCT iu.service_id) as usage_count,
                            GROUP_CONCAT(DISTINCT s.name SEPARATOR ', ') as services_using
                        FROM inventory_usage iu
                        INNER JOIN services s ON iu.service_id = s.service_id
                        LEFT JOIN (
                            SELECT 
                                service_id,
                                COUNT(*) as completed_count
                            FROM appointment_services asv
                            INNER JOIN appointments a ON asv.appointment_id = a.appointment_id
                            WHERE a.status IN ('Approved', 'Completed')
                            GROUP BY service_id
                        ) appointment_count ON iu.service_id = appointment_count.service_id
                        GROUP BY iu.item_id
                    ) usage_stats ON i.item_id = usage_stats.item_id
                    WHERE i.quantity <= i.reorder_level
                    ORDER BY (i.quantity - i.reorder_level) ASC, i.item_name"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim alertCount As Integer = 0

                        While reader.Read()
                            alertCount += 1
                            CreateAlertCard(reader)
                        End While

                        If alertCount = 0 Then
                            CreateNoAlertsCard()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading alerts: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CreateAlertCard(reader As MySqlDataReader)
        ' Create main panel for the alert card
        Dim alertPanel As New Panel()
        alertPanel.Size = New Size(flwAlerts.Width - 30, 180)
        alertPanel.BorderStyle = BorderStyle.FixedSingle
        alertPanel.Margin = New Padding(10)

        ' Determine alert level based on stock status
        Dim quantity As Integer = Convert.ToInt32(reader("quantity"))
        Dim reorderLevel As Integer = Convert.ToInt32(reader("reorder_level"))
        Dim stockDifference As Integer = quantity - reorderLevel

        If quantity = 0 Then
            alertPanel.BackColor = Color.FromArgb(248, 215, 218) ' Red - Out of stock
        ElseIf stockDifference < 0 Then
            alertPanel.BackColor = Color.FromArgb(255, 243, 205) ' Orange - Critical low
        Else
            alertPanel.BackColor = Color.FromArgb(255, 248, 209) ' Yellow - Low stock
        End If

        ' Alert level indicator
        Dim alertLevelLabel As New Label()
        alertLevelLabel.Location = New Point(10, 5)
        alertLevelLabel.Size = New Size(100, 25)
        alertLevelLabel.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
        alertLevelLabel.ForeColor = Color.White

        If quantity = 0 Then
            alertLevelLabel.Text = "OUT OF STOCK"
            alertLevelLabel.BackColor = Color.FromArgb(220, 53, 69)
        ElseIf stockDifference < 0 Then
            alertLevelLabel.Text = "CRITICAL"
            alertLevelLabel.BackColor = Color.FromArgb(255, 193, 7)
        Else
            alertLevelLabel.Text = "LOW STOCK"
            alertLevelLabel.BackColor = Color.FromArgb(255, 193, 7)
        End If

        alertLevelLabel.TextAlign = ContentAlignment.MiddleCenter
        alertPanel.Controls.Add(alertLevelLabel)

        ' Item name label
        Dim itemNameLabel As New Label()
        itemNameLabel.Location = New Point(120, 5)
        itemNameLabel.Size = New Size(320, 25)
        itemNameLabel.Text = reader("item_name").ToString()
        itemNameLabel.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        itemNameLabel.ForeColor = Color.FromArgb(77, 0, 18)
        alertPanel.Controls.Add(itemNameLabel)

        ' Current stock info
        Dim stockLabel As New Label()
        stockLabel.Location = New Point(10, 35)
        stockLabel.Size = New Size(200, 20)
        stockLabel.Text = $"Current Stock: {quantity} {reader("unit")}"
        stockLabel.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        alertPanel.Controls.Add(stockLabel)

        ' Reorder level info
        Dim reorderLabel As New Label()
        reorderLabel.Location = New Point(220, 35)
        reorderLabel.Size = New Size(200, 20)
        reorderLabel.Text = $"Reorder Level: {reorderLevel} {reader("unit")}"
        reorderLabel.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        alertPanel.Controls.Add(reorderLabel)

        ' Usage statistics
        Dim totalUsed As Integer = If(reader("total_used") Is DBNull.Value, 0, Convert.ToInt32(reader("total_used")))
        Dim usageCount As Integer = If(reader("usage_count") Is DBNull.Value, 0, Convert.ToInt32(reader("usage_count")))

        Dim usageLabel As New Label()
        usageLabel.Location = New Point(10, 60)
        usageLabel.Size = New Size(400, 20)
        usageLabel.Text = $"Total Used in Completed Appointments: {totalUsed} {reader("unit")}"
        usageLabel.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
        usageLabel.ForeColor = Color.DarkRed
        alertPanel.Controls.Add(usageLabel)

        Dim serviceCountLabel As New Label()
        serviceCountLabel.Location = New Point(10, 80)
        serviceCountLabel.Size = New Size(400, 20)
        serviceCountLabel.Text = $"Used in {usageCount} different service(s)"
        serviceCountLabel.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
        alertPanel.Controls.Add(serviceCountLabel)

        ' Services using this item
        Dim servicesUsing As String = If(reader("services_using") Is DBNull.Value, "No services", reader("services_using").ToString())
        If servicesUsing.Length > 60 Then
            servicesUsing = servicesUsing.Substring(0, 57) & "..."
        End If

        Dim servicesLabel As New Label()
        servicesLabel.Location = New Point(10, 100)
        servicesLabel.Size = New Size(430, 40)
        servicesLabel.Text = $"Services: {servicesUsing}"
        servicesLabel.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Italic)
        servicesLabel.ForeColor = Color.DarkGreen
        alertPanel.Controls.Add(servicesLabel)

        ' Action needed label
        Dim actionLabel As New Label()
        actionLabel.Location = New Point(10, 145)
        actionLabel.Size = New Size(430, 25)
        actionLabel.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
        actionLabel.ForeColor = Color.DarkRed

        If quantity = 0 Then
            actionLabel.Text = "⚠️ URGENT: Restock immediately - Service disruption possible"
        ElseIf stockDifference < 0 Then
            actionLabel.Text = $"⚠️ CRITICAL: {Math.Abs(stockDifference)} {reader("unit")} below reorder level"
        Else
            actionLabel.Text = "⚠️ ACTION: Consider restocking soon"
        End If

        alertPanel.Controls.Add(actionLabel)

        ' Add the card to the flow layout panel
        flwAlerts.Controls.Add(alertPanel)
    End Sub

    Private Sub CreateNoAlertsCard()
        Dim noAlertPanel As New Panel()
        noAlertPanel.Size = New Size(flwAlerts.Width - 30, 100)
        noAlertPanel.BorderStyle = BorderStyle.FixedSingle
        noAlertPanel.BackColor = Color.FromArgb(212, 237, 218) ' Green background
        noAlertPanel.Margin = New Padding(10)

        Dim successLabel As New Label()
        successLabel.Location = New Point(10, 10)
        successLabel.Size = New Size(100, 30)
        successLabel.Text = "ALL GOOD"
        successLabel.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
        successLabel.BackColor = Color.FromArgb(40, 167, 69)
        successLabel.ForeColor = Color.White
        successLabel.TextAlign = ContentAlignment.MiddleCenter
        noAlertPanel.Controls.Add(successLabel)

        Dim messageLabel As New Label()
        messageLabel.Location = New Point(120, 10)
        messageLabel.Size = New Size(320, 30)
        messageLabel.Text = "No Low Stock Alerts"
        messageLabel.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        messageLabel.ForeColor = Color.DarkGreen
        messageLabel.TextAlign = ContentAlignment.MiddleLeft
        noAlertPanel.Controls.Add(messageLabel)

        Dim detailLabel As New Label()
        detailLabel.Location = New Point(10, 50)
        detailLabel.Size = New Size(flwAlerts.Width - 50, 40)
        detailLabel.Text = "✅ All inventory items are at or above their reorder levels. Your stock levels are healthy!"
        detailLabel.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        detailLabel.ForeColor = Color.DarkGreen
        noAlertPanel.Controls.Add(detailLabel)

        flwAlerts.Controls.Add(noAlertPanel)
    End Sub

    Private Sub btnUpdatedInventory_Click(sender As Object, e As EventArgs) Handles btnUpdatedInventory.Click
        adminMenu.OpenChildForm(New addNewItems())
    End Sub
End Class