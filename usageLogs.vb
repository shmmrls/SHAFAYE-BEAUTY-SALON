Imports System.Data
Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class usageLogs
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=root;Pwd=;"

    Private Sub usageLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsageLogs()
    End Sub

    Private Sub LoadUsageLogs()
        Try
            UsageLogPanel.Controls.Clear()

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "
                    SELECT 
                        i.item_name,
                        i.unit,
                        i.quantity as current_quantity,
                        i.reorder_level,
                        IFNULL(SUM(iu.quantity_used), 0) as total_used,
                        CASE 
                            WHEN i.quantity <= i.reorder_level THEN 'red'
                            WHEN i.quantity <= (i.reorder_level * 1.5) THEN 'yellow'
                            ELSE 'green'
                        END as status_color
                    FROM inventory i
                    LEFT JOIN inventory_usage iu ON i.item_id = iu.item_id
                    GROUP BY i.item_id, i.item_name, i.unit, i.quantity, i.reorder_level
                    ORDER BY i.item_name"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim yPosition As Integer = 10

                        While reader.Read()
                            Dim panel As New Panel()
                            panel.Size = New Size(UsageLogPanel.Width - 30, 80)
                            panel.Location = New Point(10, yPosition)
                            panel.BorderStyle = BorderStyle.FixedSingle
                            panel.BackColor = Color.White

                            ' Item Name Label
                            Dim lblItemName As New Label()
                            lblItemName.Text = reader("item_name").ToString()
                            lblItemName.Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)
                            lblItemName.Location = New Point(10, 5)
                            lblItemName.Size = New Size(300, 20)
                            panel.Controls.Add(lblItemName)

                            ' Usage Info
                            Dim totalUsed As String = If(IsDBNull(reader("total_used")), "0", reader("total_used").ToString())
                            Dim lblUsage As New Label()
                            If totalUsed = "0" Then
                                lblUsage.Text = "Total Used: Not yet used"
                                lblUsage.ForeColor = Color.Gray
                            Else
                                lblUsage.Text = "Total Used: " & totalUsed & " " & reader("unit").ToString()
                                lblUsage.ForeColor = Color.Black
                            End If
                            lblUsage.Location = New Point(10, 25)
                            lblUsage.Size = New Size(200, 20)
                            panel.Controls.Add(lblUsage)

                            ' Current Quantity
                            Dim lblQuantity As New Label()
                            lblQuantity.Text = "Current Stock: " & reader("current_quantity").ToString() & " " & reader("unit").ToString()
                            lblQuantity.Location = New Point(10, 45)
                            lblQuantity.Size = New Size(200, 20)

                            ' Set color based on stock level
                            Dim statusColor As String = reader("status_color").ToString()
                            Select Case statusColor
                                Case "red"
                                    lblQuantity.ForeColor = Color.Red
                                Case "yellow"
                                    lblQuantity.ForeColor = Color.Orange
                                Case Else
                                    lblQuantity.ForeColor = Color.Green
                            End Select

                            panel.Controls.Add(lblQuantity)

                            ' Reorder Level Info
                            Dim lblReorder As New Label()
                            lblReorder.Text = "Reorder Level: " & reader("reorder_level").ToString()
                            lblReorder.Location = New Point(350, 25)
                            lblReorder.Size = New Size(150, 20)
                            lblReorder.ForeColor = Color.Gray
                            panel.Controls.Add(lblReorder)

                            ' Status Indicator
                            Dim lblStatus As New Label()
                            Select Case statusColor
                                Case "red"
                                    lblStatus.Text = "⚠ REORDER NOW"
                                    lblStatus.ForeColor = Color.Red
                                Case "yellow"
                                    lblStatus.Text = "⚠ LOW STOCK"
                                    lblStatus.ForeColor = Color.Orange
                                Case Else
                                    lblStatus.Text = "✓ GOOD STOCK"
                                    lblStatus.ForeColor = Color.Green
                            End Select
                            lblStatus.Location = New Point(350, 45)
                            lblStatus.Size = New Size(150, 20)
                            lblStatus.Font = New System.Drawing.Font("Segoe UI", 8, FontStyle.Bold)
                            panel.Controls.Add(lblStatus)

                            UsageLogPanel.Controls.Add(panel)
                            yPosition += 90
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading usage logs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PDF Files|*.pdf"
            saveDialog.Title = "Save Usage Log Report"
            saveDialog.FileName = "UsageLog_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                ExportToPDF(saveDialog.FileName)
                MessageBox.Show("Report exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Process.Start(saveDialog.FileName)
            End If

        Catch ex As Exception
            MessageBox.Show("Error exporting report: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExportToPDF(fileName As String)
        Dim document As New Document(PageSize.A4, 25, 25, 25, 25)
        Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(fileName, FileMode.Create))

        document.Open()

        ' Title
        Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
        Dim title As New Paragraph("SHAFAYE SALON - INVENTORY USAGE LOG", titleFont)
        title.Alignment = Element.ALIGN_CENTER
        title.SpacingAfter = 10
        document.Add(title)

        ' Date
        Dim headerFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10)
        Dim dateInfo As New Paragraph("Generated on: " & DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt"), headerFont)
        dateInfo.SpacingAfter = 15
        document.Add(dateInfo)

        ' Table
        Dim table As New PdfPTable(5)
        table.WidthPercentage = 100
        table.SetWidths(New Single() {3, 1.5, 1.5, 1.5, 1.5})

        ' Table Headers
        Dim headerCellFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)
        Dim headers() As String = {"Item Name", "Total Used", "Current Stock", "Reorder Level", "Status"}

        For Each header As String In headers
            Dim cell As New PdfPCell(New Phrase(header, headerCellFont))
            cell.BackgroundColor = BaseColor.LIGHT_GRAY
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            cell.Padding = 8
            table.AddCell(cell)
        Next

        ' Table Data
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "
                SELECT 
                    i.item_name,
                    i.unit,
                    i.quantity as current_quantity,
                    i.reorder_level,
                    IFNULL(SUM(iu.quantity_used), 0) as total_used,
                    CASE 
                        WHEN i.quantity <= i.reorder_level THEN 'REORDER NOW'
                        WHEN i.quantity <= (i.reorder_level * 1.5) THEN 'LOW STOCK'
                        ELSE 'GOOD STOCK'
                    END as status_text
                FROM inventory i
                LEFT JOIN inventory_usage iu ON i.item_id = iu.item_id
                GROUP BY i.item_id, i.item_name, i.unit, i.quantity, i.reorder_level
                ORDER BY i.item_name"

            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    Dim cellFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9)

                    While reader.Read()
                        ' Item Name
                        table.AddCell(New PdfPCell(New Phrase(reader("item_name").ToString(), cellFont)) With {.Padding = 5})

                        ' Total Used
                        Dim totalUsed As String = If(IsDBNull(reader("total_used")), "0", reader("total_used").ToString())
                        Dim usageText As String = If(totalUsed = "0", "Not yet used", totalUsed & " " & reader("unit").ToString())
                        table.AddCell(New PdfPCell(New Phrase(usageText, cellFont)) With {.Padding = 5, .HorizontalAlignment = Element.ALIGN_CENTER})

                        ' Current Stock
                        table.AddCell(New PdfPCell(New Phrase(reader("current_quantity").ToString() & " " & reader("unit").ToString(), cellFont)) With {.Padding = 5, .HorizontalAlignment = Element.ALIGN_CENTER})

                        ' Reorder Level
                        table.AddCell(New PdfPCell(New Phrase(reader("reorder_level").ToString(), cellFont)) With {.Padding = 5, .HorizontalAlignment = Element.ALIGN_CENTER})

                        ' Status
                        Dim statusCell As New PdfPCell(New Phrase(reader("status_text").ToString(), cellFont))
                        statusCell.Padding = 5
                        statusCell.HorizontalAlignment = Element.ALIGN_CENTER

                        Select Case reader("status_text").ToString()
                            Case "REORDER NOW"
                                statusCell.BackgroundColor = New BaseColor(255, 200, 200)
                            Case "LOW STOCK"
                                statusCell.BackgroundColor = New BaseColor(255, 255, 200)
                            Case Else
                                statusCell.BackgroundColor = New BaseColor(200, 255, 200)
                        End Select

                        table.AddCell(statusCell)
                    End While
                End Using
            End Using
        End Using

        document.Add(table)

        ' Footer
        Dim footer As New Paragraph(vbNewLine & "Report generated by Shafaye Salon Management System", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.ITALIC))
        footer.Alignment = Element.ALIGN_CENTER
        document.Add(footer)

        document.Close()
    End Sub
End Class