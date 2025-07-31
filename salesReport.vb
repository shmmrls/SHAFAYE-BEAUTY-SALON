Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Drawing

' mp5 Compute total income of the shop
' READ: Computes total revenue and service sales within a date range and category filter.
' Displays summary of completed appointments and total sales.
' Generates detailed PDF report including daily revenue breakdown.

'FOR SERVICES SALES TRACKING
'Records completed appointments with details of services provided, prices, and total payment.


Public Class salesReport
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=salon_admin;Pwd=AdminSalon2025!;"

    Private Sub salesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        UpdateSalesReport()

        AddHandler DateTimePickerFrom.ValueChanged, AddressOf DateRangeChanged
        AddHandler DateTimePickerTo.ValueChanged, AddressOf DateRangeChanged
    End Sub

    Private Sub DateRangeChanged(sender As Object, e As EventArgs)
        UpdateSalesReport()
    End Sub

    Private Sub cmbCategServ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategServ.SelectedIndexChanged
        UpdateSalesReport()
    End Sub

    Private Sub LoadCategories()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT name FROM service_categories ORDER BY name"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cmbCategServ.Items.Clear()
                        cmbCategServ.Items.Add("All")
                        While reader.Read()
                            cmbCategServ.Items.Add(reader("name").ToString())
                        End While
                    End Using
                End Using
            End Using
            cmbCategServ.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GeneratePDFReport()
    End Sub

    Private Sub UpdateSalesReport()
        LoadSalesSummary()
    End Sub

    Private Sub LoadSalesSummary()
        Try
            listViewSummaryofreport.Items.Clear()
            listViewSummaryofreport.View = View.Details
            listViewSummaryofreport.FullRowSelect = True
            listViewSummaryofreport.GridLines = True
            listViewSummaryofreport.HideSelection = False

            listViewSummaryofreport.Columns.Clear()
            listViewSummaryofreport.Columns.Add("Service Name")
            listViewSummaryofreport.Columns.Add("Category")
            listViewSummaryofreport.Columns.Add("Times Availed")
            listViewSummaryofreport.Columns.Add("Price")
            listViewSummaryofreport.Columns.Add("Total Revenue")

            Dim fromDate As Date = DateTimePickerFrom.Value.Date
            Dim toDate As Date = DateTimePickerTo.Value.Date
            Dim selectedCategory As String = cmbCategServ.SelectedItem.ToString()

            Dim totalRevenue As Decimal = 0
            Dim totalAppointments As Integer = 0

            Dim query As String = "
            SELECT 
                s.name AS service_name,
                sc.name AS category_name,
                s.price,
                COUNT(asv.service_id) AS times_availed,
                (COUNT(asv.service_id) * s.price) AS total_revenue
            FROM appointment_services AS asv
            INNER JOIN appointments a ON asv.appointment_id = a.appointment_id
            INNER JOIN services s ON asv.service_id = s.service_id
            INNER JOIN service_categories sc ON s.category_id = sc.category_id
            WHERE a.status = 'Completed'
              AND (a.appointment_date BETWEEN @fromDate AND @toDate)
              AND (@type = 'All' OR sc.name = @type)
            GROUP BY s.service_id, s.name, sc.name, s.price
            ORDER BY total_revenue DESC;"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fromDate", fromDate)
                    cmd.Parameters.AddWithValue("@toDate", toDate)
                    cmd.Parameters.AddWithValue("@type", selectedCategory)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim rowIndex As Integer = 0
                        While reader.Read()
                            Dim item As New ListViewItem(reader("service_name").ToString())
                            item.SubItems.Add(reader("category_name").ToString())
                            item.SubItems.Add(reader("times_availed").ToString())
                            item.SubItems.Add("₱" & Convert.ToDecimal(reader("price")).ToString("N2"))
                            item.SubItems.Add("₱" & Convert.ToDecimal(reader("total_revenue")).ToString("N2"))

                            If rowIndex Mod 2 = 0 Then
                                item.BackColor = Color.FromArgb(245, 245, 245)
                            End If
                            listViewSummaryofreport.Items.Add(item)

                            totalRevenue += Convert.ToDecimal(reader("total_revenue"))
                            totalAppointments += Convert.ToInt32(reader("times_availed"))
                            rowIndex += 1
                        End While
                    End Using
                End Using
            End Using

            UpdateNetProfitPanel(totalRevenue, totalAppointments)

            AutoFitListViewColumns()

        Catch ex As Exception
            MessageBox.Show("Error loading sales summary: " & ex.Message)
        End Try
    End Sub

    Private Sub AutoFitListViewColumns()
        Dim totalWidth As Integer = listViewSummaryofreport.ClientSize.Width
        If listViewSummaryofreport.Columns.Count > 0 Then
            listViewSummaryofreport.Columns(0).Width = CInt(totalWidth * 0.3)
            listViewSummaryofreport.Columns(1).Width = CInt(totalWidth * 0.2)
            listViewSummaryofreport.Columns(2).Width = CInt(totalWidth * 0.15)
            listViewSummaryofreport.Columns(3).Width = CInt(totalWidth * 0.15)
            listViewSummaryofreport.Columns(4).Width = CInt(totalWidth * 0.2)
        End If
    End Sub

    Private Sub salesReport_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AutoFitListViewColumns()
    End Sub

    Private Function GetDailyRevenueData(fromDate As Date, toDate As Date, category As String) As Dictionary(Of Date, Decimal)
        Dim dailyRevenue As New Dictionary(Of Date, Decimal)()

        Try
            Dim query As String = "
                SELECT DATE(a.appointment_date) AS day, SUM(s.price) AS day_revenue
                FROM appointment_services AS asv
                INNER JOIN appointments a ON asv.appointment_id = a.appointment_id
                INNER JOIN services s ON asv.service_id = s.service_id
                INNER JOIN service_categories sc ON s.category_id = sc.category_id
                WHERE a.status = 'Completed'
                  AND (a.appointment_date BETWEEN @fromDate AND @toDate)
                  AND (@type = 'All' OR sc.name = @type)
                GROUP BY DATE(a.appointment_date)
                ORDER BY day ASC;"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fromDate", fromDate)
                    cmd.Parameters.AddWithValue("@toDate", toDate)
                    cmd.Parameters.AddWithValue("@type", category)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim dayDate As Date = Convert.ToDateTime(reader("day"))
                            Dim revenue As Decimal = Convert.ToDecimal(reader("day_revenue"))
                            dailyRevenue(dayDate) = revenue
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading daily revenue: " & ex.Message)
        End Try

        Return dailyRevenue
    End Function

    Private Sub LoadDailySummary(lv As ListView, fromDate As Date, toDate As Date, category As String, ByRef totalRevenue As Decimal)
        Dim query As String = "
            SELECT DATE(a.appointment_date) AS day, SUM(s.price) AS day_revenue
            FROM appointment_services AS asv
            INNER JOIN appointments a ON asv.appointment_id = a.appointment_id
            INNER JOIN services s ON asv.service_id = s.service_id
            INNER JOIN service_categories sc ON s.category_id = sc.category_id
            WHERE a.status = 'Completed'
              AND (a.appointment_date BETWEEN @fromDate AND @toDate)
              AND (@type = 'All' OR sc.name = @type)
            GROUP BY DATE(a.appointment_date)
            ORDER BY day ASC;"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fromDate", fromDate)
                cmd.Parameters.AddWithValue("@toDate", toDate)
                cmd.Parameters.AddWithValue("@type", category)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ListViewItem(reader("day").ToString())
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                        item.SubItems.Add("₱" & Convert.ToDecimal(reader("day_revenue")).ToString("N2"))
                        lv.Items.Add(item)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub UpdateNetProfitPanel(totalRevenue As Decimal, totalAppointments As Integer)
        panelNetProfit.Controls.Clear()

        Dim lblRevenue As New Label()
        lblRevenue.Text = $"Total Revenue: ₱{totalRevenue:N2}"
        lblRevenue.Font = New System.Drawing.Font("Segoe UI", 14, FontStyle.Bold)
        lblRevenue.ForeColor = Color.DarkGreen
        lblRevenue.Location = New Point(10, 10)
        lblRevenue.AutoSize = True
        panelNetProfit.Controls.Add(lblRevenue)

        Dim lblAppointments As New Label()
        lblAppointments.Text = $"Completed Appointments: {totalAppointments}"
        lblAppointments.Font = New System.Drawing.Font("Segoe UI", 13)
        lblAppointments.Location = New Point(10, 35)
        lblAppointments.AutoSize = True
        panelNetProfit.Controls.Add(lblAppointments)

        Dim lblStatus As New Label()
        lblStatus.Text = If(totalRevenue >= 20000, "Salon Sales are GOOD!", "Needs Improvement")
        lblStatus.Font = New System.Drawing.Font("Segoe UI", 13, FontStyle.Italic)
        lblStatus.ForeColor = If(totalRevenue >= 20000, Color.Green, Color.Red)
        lblStatus.Location = New Point(10, 60)
        lblStatus.AutoSize = True
        panelNetProfit.Controls.Add(lblStatus)
    End Sub

    Private Sub AutoResizeListViewColumns()
        For i As Integer = 0 To listViewSummaryofreport.Columns.Count - 1
            listViewSummaryofreport.Columns(i).Width = -2
        Next
    End Sub

    Private Sub GeneratePDFReport()
        Try
            Dim fromDateStr As String = DateTimePickerFrom.Value.ToString("yyyyMMdd")
            Dim toDateStr As String = DateTimePickerTo.Value.ToString("yyyyMMdd")
            Dim fileName As String = $"SalesReport_{fromDateStr}_to_{toDateStr}.pdf"
            Dim savePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName)

            Dim totalRevenue As Decimal = 0
            Dim totalAppointments As Integer = 0
            For Each item As ListViewItem In listViewSummaryofreport.Items
                If item.SubItems.Count = 5 Then
                    totalAppointments += If(IsNumeric(item.SubItems(2).Text), Convert.ToInt32(item.SubItems(2).Text), 0)
                    Dim totalRevText As String = item.SubItems(4).Text.Replace("₱", "").Replace(",", "").Trim()
                    If IsNumeric(totalRevText) Then
                        totalRevenue += Convert.ToDecimal(totalRevText)
                    End If
                End If
            Next

            Dim selectedCategory As String = cmbCategServ.SelectedItem.ToString()
            Dim dailyRevenueData As Dictionary(Of Date, Decimal) = GetDailyRevenueData(DateTimePickerFrom.Value.Date, DateTimePickerTo.Value.Date, selectedCategory)

            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            Using fs As New FileStream(savePath, FileMode.Create, FileAccess.Write, FileShare.None)
                Dim writer = PdfWriter.GetInstance(doc, fs)
                doc.Open()

                Dim titleFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18)
                Dim subTitleFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12)
                doc.Add(New Paragraph("SHAFAYE SALON'S SALES REPORT", titleFont))
                doc.Add(New Paragraph($"Date Range: {DateTimePickerFrom.Value:MMMM dd, yyyy} - {DateTimePickerTo.Value:MMMM dd, yyyy}", subTitleFont))
                If selectedCategory <> "All" Then
                    doc.Add(New Paragraph($"Category Filter: {selectedCategory}", subTitleFont))
                End If
                doc.Add(New Paragraph(" "))

                Dim summaryTable As New PdfPTable(1)
                summaryTable.WidthPercentage = 100
                summaryTable.SpacingAfter = 15

                Dim summaryText As String =
                    $"Total Revenue: ₱{totalRevenue:N2}" & vbCrLf &
                    $"Completed Appointments: {totalAppointments}" & vbCrLf &
                    $"Status: {If(totalRevenue >= 20000, "Salon Sales are GOOD!", "Needs Improvement")}"

                Dim cell As New PdfPCell(New Phrase(summaryText, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
                cell.Border = iTextSharp.text.Rectangle.BOX
                cell.Padding = 8
                summaryTable.AddCell(cell)

                doc.Add(summaryTable)

                Dim pdfTable As New PdfPTable(5)
                pdfTable.WidthPercentage = 100
                pdfTable.SetWidths(New Single() {2.5F, 1.5F, 1.0F, 1.2F, 1.5F})

                pdfTable.AddCell(New PdfPCell(New Phrase("Service Name", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))))
                pdfTable.AddCell(New PdfPCell(New Phrase("Category", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))))
                pdfTable.AddCell(New PdfPCell(New Phrase("Times Availed", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))))
                pdfTable.AddCell(New PdfPCell(New Phrase("Price", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))))
                pdfTable.AddCell(New PdfPCell(New Phrase("Total Revenue", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))))

                For Each item As ListViewItem In listViewSummaryofreport.Items
                    If item.SubItems.Count = 5 Then
                        pdfTable.AddCell(New PdfPCell(New Phrase(item.SubItems(0).Text, FontFactory.GetFont(FontFactory.HELVETICA, 9))))
                        pdfTable.AddCell(New PdfPCell(New Phrase(item.SubItems(1).Text, FontFactory.GetFont(FontFactory.HELVETICA, 9))))
                        pdfTable.AddCell(New PdfPCell(New Phrase(item.SubItems(2).Text, FontFactory.GetFont(FontFactory.HELVETICA, 9))))
                        pdfTable.AddCell(New PdfPCell(New Phrase(item.SubItems(3).Text, FontFactory.GetFont(FontFactory.HELVETICA, 9))))
                        pdfTable.AddCell(New PdfPCell(New Phrase(item.SubItems(4).Text, FontFactory.GetFont(FontFactory.HELVETICA, 9))))
                    End If
                Next

                doc.Add(pdfTable)
                doc.Add(New Paragraph(" "))

                doc.Add(New Paragraph(" "))
                Dim dailyHeader As New Paragraph("Daily Revenue Summary", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13))
                doc.Add(dailyHeader)

                Dim dailyTable As New PdfPTable(2)
                dailyTable.WidthPercentage = 60
                dailyTable.SpacingBefore = 10
                dailyTable.SetWidths(New Single() {3.0F, 2.0F})

                dailyTable.AddCell(New PdfPCell(New Phrase("Date", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11))))
                dailyTable.AddCell(New PdfPCell(New Phrase("Revenue", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11))))

                Dim currentDate As Date = DateTimePickerFrom.Value.Date
                Dim endDate As Date = DateTimePickerTo.Value.Date
                While currentDate <= endDate
                    Dim revenue As Decimal = If(dailyRevenueData.ContainsKey(currentDate), dailyRevenueData(currentDate), 0D)
                    dailyTable.AddCell(New PdfPCell(New Phrase(currentDate.ToString("MMM dd, yyyy"))))
                    dailyTable.AddCell(New PdfPCell(New Phrase("₱" & revenue.ToString("N2"))))
                    currentDate = currentDate.AddDays(1)
                End While

                doc.Add(dailyTable)

                doc.Close()
            End Using

            MessageBox.Show($"PDF Sales Report generated on Desktop: {fileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Process.Start(savePath)

        Catch ex As Exception
            MessageBox.Show("Error generating PDF report: " & ex.Message)
        End Try
    End Sub

End Class