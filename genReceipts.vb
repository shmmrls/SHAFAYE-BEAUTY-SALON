Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Drawing

Public Class genReceipts
    Private connectionString As String = "server=localhost;userid=root;password=;database=final_shafaye_salon;"

    Private Sub genReceipts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCompletedBookings()
    End Sub

    ' Load completed bookings into combobox
    Private Sub LoadCompletedBookings()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query = "SELECT a.appointment_id, CONCAT(u.first_name, ' ', u.last_name) as customer_name, a.appointment_date " &
                           "FROM appointments a " &
                           "JOIN user_register u ON a.user_id = u.user_id " &
                           "WHERE a.status = 'Completed' " &
                           "ORDER BY a.appointment_date DESC"

                Using command As New MySqlCommand(query, connection)
                    Using reader = command.ExecuteReader()
                        cmbBookingIdCompleted.Items.Clear()
                        cmbBookingIdCompleted.DisplayMember = "Display"
                        cmbBookingIdCompleted.ValueMember = "AppointmentId"

                        Dim bookingList As New List(Of Object)
                        While reader.Read()
                            bookingList.Add(New With {
                                .AppointmentId = reader("appointment_id"),
                                .Display = $"#{reader("appointment_id")} - {reader("customer_name")} ({Convert.ToDateTime(reader("appointment_date")):MMM dd, yyyy})"
                            })
                        End While

                        cmbBookingIdCompleted.DataSource = bookingList
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading completed bookings: " & ex.Message)
        End Try
    End Sub

    ' Handle selection change in booking combobox
    Private Sub cmbBookingIdCompleted_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBookingIdCompleted.SelectedIndexChanged
        If cmbBookingIdCompleted.SelectedValue IsNot Nothing Then
            LoadBookingDetails(Convert.ToInt32(cmbBookingIdCompleted.SelectedValue))
        End If
    End Sub

    ' Load booking details and populate labels
    Private Sub LoadBookingDetails(appointmentId As Integer)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Get customer name
                Dim customerQuery = "SELECT CONCAT(u.first_name, ' ', u.last_name) as customer_name " &
                                   "FROM appointments a " &
                                   "JOIN user_register u ON a.user_id = u.user_id " &
                                   "WHERE a.appointment_id = @appointmentId"

                Using customerCommand As New MySqlCommand(customerQuery, connection)
                    customerCommand.Parameters.AddWithValue("@appointmentId", appointmentId)
                    Dim customerResult = customerCommand.ExecuteScalar()
                    customerLbl.Text = If(customerResult IsNot Nothing, "Customer Name: " & customerResult.ToString(), "N/A")
                End Using

                ' Get services and calculate total
                Dim servicesQuery = "SELECT s.name, s.price " &
                                   "FROM appointment_services aps " &
                                   "JOIN services s ON aps.service_id = s.service_id " &
                                   "WHERE aps.appointment_id = @appointmentId"

                Dim servicesList As New List(Of String)
                Dim totalAmount As Decimal = 0

                Using servicesCommand As New MySqlCommand(servicesQuery, connection)
                    servicesCommand.Parameters.AddWithValue("@appointmentId", appointmentId)
                    Using reader = servicesCommand.ExecuteReader()
                        While reader.Read()
                            servicesList.Add(reader("name").ToString())
                            totalAmount += Convert.ToDecimal(reader("price"))
                        End While
                    End Using
                End Using

                serviceLbl.Text = "Services Availed: " & String.Join(", ", servicesList)
                amountLbl.Text = "Total Amount Paid: " & $"₱{totalAmount:N2}"

            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading booking details: " & ex.Message)
        End Try
    End Sub

    ' Generate admin copy receipt
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If cmbBookingIdCompleted.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a completed booking first.")
            Return
        End If

        GenerateAdminReceipt(Convert.ToInt32(cmbBookingIdCompleted.SelectedValue))
    End Sub

    Private Sub GenerateAdminReceipt(appointmentID As Integer)
        Try
            ' Get appointment data
            Dim appointmentData = GetAppointmentData(appointmentID)
            If appointmentData Is Nothing Then
                MessageBox.Show("No appointment data found.")
                Return
            End If

            ' Create PDF file path with folder creation
            Dim folderName As String = "Admin Copy - Receipts"
            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim folderPath As String = Path.Combine(desktopPath, folderName)

            ' Create folder if it doesn't exist
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            Dim fileName As String = $"AdminCopy_Receipt_{appointmentID}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' Create PDF document
            Dim document As New Document(PageSize.A4, 40, 40, 40, 40)
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(filePath, FileMode.Create))

            document.Open()

            ' Define fonts
            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD)
            Dim headerFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD)
            Dim normalFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11)
            Dim boldFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.BOLD)
            Dim adminFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, BaseColor.RED)

            ' Admin Copy Header
            Dim adminCopyTitle As New Paragraph("ADMINISTRATOR COPY", adminFont)
            adminCopyTitle.Alignment = Element.ALIGN_CENTER
            adminCopyTitle.SpacingAfter = 10
            document.Add(adminCopyTitle)

            ' Header - Salon Name
            Dim salonTitle As New Paragraph("SHAFAYE BEAUTY SALON", titleFont)
            salonTitle.Alignment = Element.ALIGN_CENTER
            salonTitle.SpacingAfter = 5
            document.Add(salonTitle)

            Dim tagline As New Paragraph("Professional Beauty Services - Internal Records", normalFont)
            tagline.Alignment = Element.ALIGN_CENTER
            tagline.SpacingAfter = 5
            document.Add(tagline)

            Dim contact As New Paragraph("Km. 14 East Service Road, Western Bicutan, Taguig City, Metro Manila" & vbLf & "Phone: 09697858317 | Email: shafayesalon@gmail.com", normalFont)
            contact.Alignment = Element.ALIGN_CENTER
            contact.SpacingAfter = 15
            document.Add(contact)

            ' Add decorative line
            Dim line As New Paragraph("═══════════════════════════════════════════════════════════════════")
            line.Alignment = Element.ALIGN_CENTER
            line.SpacingAfter = 15
            document.Add(line)

            ' Receipt title
            Dim receiptTitle As New Paragraph("APPOINTMENT RECEIPT - ADMIN RECORD", headerFont)
            receiptTitle.Alignment = Element.ALIGN_CENTER
            receiptTitle.SpacingAfter = 15
            document.Add(receiptTitle)

            ' Admin info section
            Dim adminInfo As New Paragraph($"Generated by Admin on: {DateTime.Now:MMMM dd, yyyy hh:mm tt}" & vbLf & $"Receipt ID: ADM-{appointmentID:D6}", boldFont)
            adminInfo.Alignment = Element.ALIGN_CENTER
            adminInfo.SpacingAfter = 20
            document.Add(adminInfo)

            ' Create main info table
            Dim infoTable As New PdfPTable(2)
            infoTable.WidthPercentage = 100
            infoTable.SetWidths({1, 1})
            infoTable.SpacingAfter = 20

            ' Left column - Customer Information
            Dim leftCell As New PdfPCell()
            leftCell.Border = iTextSharp.text.Rectangle.BOX
            leftCell.Padding = 15
            leftCell.AddElement(New Paragraph("CUSTOMER INFORMATION", headerFont))
            leftCell.AddElement(New Paragraph($"Name: {appointmentData("CustomerName")}", normalFont))
            leftCell.AddElement(New Paragraph($"Phone: {appointmentData("Phone")}", normalFont))
            leftCell.AddElement(New Paragraph($"Email: {appointmentData("Email")}", normalFont))
            infoTable.AddCell(leftCell)

            ' Right column - Appointment Details
            Dim rightCell As New PdfPCell()
            rightCell.Border = iTextSharp.text.Rectangle.BOX
            rightCell.Padding = 15
            rightCell.AddElement(New Paragraph("APPOINTMENT DETAILS", headerFont))
            rightCell.AddElement(New Paragraph($"Date: {appointmentData("AppointmentDate")}", normalFont))
            rightCell.AddElement(New Paragraph($"Time: {appointmentData("AppointmentTime")}", normalFont))
            rightCell.AddElement(New Paragraph($"Status: {appointmentData("Status")}", normalFont))
            infoTable.AddCell(rightCell)

            document.Add(infoTable)

            ' Services Section Header
            Dim servicesHeader As New Paragraph("SERVICES BREAKDOWN", headerFont)
            servicesHeader.SpacingAfter = 10
            servicesHeader.Alignment = Element.ALIGN_CENTER
            document.Add(servicesHeader)

            ' Create services table
            Dim table As New PdfPTable(4)
            table.WidthPercentage = 100
            table.SetWidths({1.0F, 3.0F, 2.0F, 1.5F})

            Dim headers() As String = {"#", "SERVICE", "STAFF ASSIGNED", "AMOUNT"}
            Dim whiteBoldFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.BOLD, BaseColor.WHITE)
            For Each headerText In headers
                Dim headerCell As New PdfPCell(New Phrase(headerText, whiteBoldFont))
                headerCell.HorizontalAlignment = Element.ALIGN_CENTER
                headerCell.Padding = 10
                headerCell.BackgroundColor = BaseColor.DARK_GRAY
                table.AddCell(headerCell)
            Next

            ' Add service rows
            Dim services As List(Of Dictionary(Of String, Object)) = appointmentData("Services")
            Dim itemNumber As Integer = 1
            For Each service In services
                ' Item number
                Dim numberCell As New PdfPCell(New Phrase(itemNumber.ToString(), normalFont))
                numberCell.Padding = 8
                numberCell.HorizontalAlignment = Element.ALIGN_CENTER
                table.AddCell(numberCell)

                ' Service name
                Dim serviceNameCell As New PdfPCell(New Phrase(service("ServiceName").ToString(), normalFont))
                serviceNameCell.Padding = 8
                serviceNameCell.HorizontalAlignment = Element.ALIGN_LEFT
                table.AddCell(serviceNameCell)

                ' Staff name
                Dim staffNameCell As New PdfPCell(New Phrase(service("StaffName").ToString(), normalFont))
                staffNameCell.Padding = 8
                staffNameCell.HorizontalAlignment = Element.ALIGN_LEFT
                table.AddCell(staffNameCell)

                ' Price
                Dim servicePriceCell As New PdfPCell(New Phrase($"₱{Convert.ToDecimal(service("Price")):N2}", normalFont))
                servicePriceCell.Padding = 8
                servicePriceCell.HorizontalAlignment = Element.ALIGN_RIGHT
                table.AddCell(servicePriceCell)

                itemNumber += 1
            Next

            document.Add(table)

            ' Total section with border
            Dim totalTable As New PdfPTable(4)
            totalTable.WidthPercentage = 100
            totalTable.SetWidths({1.0F, 3.0F, 2.0F, 1.5F})
            totalTable.SpacingBefore = 5

            ' Empty cells for alignment
            For i As Integer = 1 To 3
                Dim emptyCell As New PdfPCell(New Phrase("", normalFont))
                emptyCell.Border = 0
                totalTable.AddCell(emptyCell)
            Next

            ' Total amount cell
            Dim totalCell As New PdfPCell(New Phrase($"TOTAL: ₱{Convert.ToDecimal(appointmentData("TotalAmount")):N2}", headerFont))
            totalCell.Padding = 10
            totalCell.HorizontalAlignment = Element.ALIGN_RIGHT
            totalCell.BackgroundColor = BaseColor.LIGHT_GRAY
            totalCell.Border = iTextSharp.text.Rectangle.BOX
            totalTable.AddCell(totalCell)

            document.Add(totalTable)

            ' Admin notes section
            Dim notesHeader As New Paragraph("ADMINISTRATIVE NOTES", headerFont)
            notesHeader.SpacingBefore = 20
            notesHeader.SpacingAfter = 10
            document.Add(notesHeader)

            Dim adminNotes As New Paragraph($"• Receipt generated for administrative records" & vbLf &
                                          $"• Payment status: Completed" & vbLf &
                                          $"• Service completion verified" & vbLf &
                                          $"• Generated by: System Administrator" & vbLf &
                                          $"• Print timestamp: {DateTime.Now:yyyy-MM-dd HH:mm:ss}", normalFont)
            adminNotes.SpacingAfter = 20
            document.Add(adminNotes)

            ' Footer
            Dim footerLine As New Paragraph("═══════════════════════════════════════════════════════════════════")
            footerLine.Alignment = Element.ALIGN_CENTER
            footerLine.SpacingAfter = 10
            document.Add(footerLine)

            Dim adminFooter As New Paragraph("SHAFAYE BEAUTY SALON - INTERNAL DOCUMENT", headerFont)
            adminFooter.Alignment = Element.ALIGN_CENTER
            adminFooter.SpacingAfter = 5
            document.Add(adminFooter)

            Dim confidential As New Paragraph("This document is for administrative purposes only", normalFont)
            confidential.Alignment = Element.ALIGN_CENTER
            document.Add(confidential)

            document.Close()

            MessageBox.Show($"Admin copy receipt generated successfully!" & vbCrLf & "Saved as: " & fileName & vbCrLf & vbCrLf & "The PDF has been saved to: " & folderPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open the PDF file
            If MessageBox.Show("Would you like to open the receipt?", "Open Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Process.Start(filePath)
            End If

        Catch ex As Exception
            MessageBox.Show("Error generating admin receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Get appointment data from database
    Private Function GetAppointmentData(appointmentID As Integer) As Dictionary(Of String, Object)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Get basic appointment and customer info
                Dim query = "SELECT a.appointment_date, a.appointment_time, a.status, " &
                           "CONCAT(u.first_name, ' ', u.last_name) as customer_name, " &
                           "up.phone, up.email " &
                           "FROM appointments a " &
                           "JOIN user_register u ON a.user_id = u.user_id " &
                           "LEFT JOIN user_profiles up ON u.user_id = up.user_id " &
                           "WHERE a.appointment_id = @appointmentId"

                Dim appointmentData As New Dictionary(Of String, Object)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@appointmentId", appointmentID)
                    Using reader = command.ExecuteReader()
                        If reader.Read() Then
                            appointmentData("AppointmentDate") = Convert.ToDateTime(reader("appointment_date")).ToString("MMMM dd, yyyy")
                            appointmentData("AppointmentTime") = reader("appointment_time").ToString()
                            appointmentData("Status") = reader("status").ToString()
                            appointmentData("CustomerName") = reader("customer_name").ToString()
                            appointmentData("Phone") = If(reader("phone") IsNot DBNull.Value, reader("phone").ToString(), "N/A")
                            appointmentData("Email") = If(reader("email") IsNot DBNull.Value, reader("email").ToString(), "N/A")
                        Else
                            Return Nothing
                        End If
                    End Using
                End Using

                ' Get services with staff info
                Dim servicesQuery = "SELECT s.name as service_name, s.price, " &
                                   "CONCAT(staff_user.first_name, ' ', staff_user.last_name) as staff_name " &
                                   "FROM appointment_services aps " &
                                   "JOIN services s ON aps.service_id = s.service_id " &
                                   "LEFT JOIN staff st ON aps.staff_id = st.staff_id " &
                                   "LEFT JOIN user_register staff_user ON st.user_id = staff_user.user_id " &
                                   "WHERE aps.appointment_id = @appointmentId"

                Dim servicesList As New List(Of Dictionary(Of String, Object))
                Dim totalAmount As Decimal = 0

                Using servicesCommand As New MySqlCommand(servicesQuery, connection)
                    servicesCommand.Parameters.AddWithValue("@appointmentId", appointmentID)
                    Using reader = servicesCommand.ExecuteReader()
                        While reader.Read()
                            Dim serviceInfo As New Dictionary(Of String, Object)
                            serviceInfo("ServiceName") = reader("service_name").ToString()
                            serviceInfo("Price") = Convert.ToDecimal(reader("price"))
                            serviceInfo("StaffName") = If(reader("staff_name") IsNot DBNull.Value, reader("staff_name").ToString(), "N/A")
                            servicesList.Add(serviceInfo)
                            totalAmount += Convert.ToDecimal(reader("price"))
                        End While
                    End Using
                End Using

                appointmentData("Services") = servicesList
                appointmentData("TotalAmount") = totalAmount

                Return appointmentData
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving appointment data: " & ex.Message)
            Return Nothing
        End Try
    End Function
End Class