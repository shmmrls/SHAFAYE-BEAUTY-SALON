Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class transactionhistory
    Private userID As Integer
    Private conn As MySqlConnection
    Private selectedPanel As Panel = Nothing

    Public Sub New(ByVal userID As Integer)
        InitializeComponent()
        Me.userID = userID
        InitializeConnection()
    End Sub

    Private Sub InitializeConnection()
        conn = New MySqlConnection("Server=localhost;Database=final_shafaye_salon;Uid=salon_customer;Pwd=CustomerSalon2025!;")
    End Sub

    Private Sub transactionhistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeFilterControls()
        LoadAppointments()
        AddHandler cmbStatus.SelectedIndexChanged, AddressOf FilterAppointments
        AddHandler cmborderby.SelectedIndexChanged, AddressOf FilterAppointments
    End Sub

    Private Sub InitializeFilterControls()

        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("All Status")
        cmbStatus.Items.Add("Pending")
        cmbStatus.Items.Add("Approved")
        cmbStatus.Items.Add("Completed")
        cmbStatus.Items.Add("Cancelled")
        cmbStatus.SelectedIndex = 0


        cmborderby.Items.Clear()
        cmborderby.Items.Add("Newest to Oldest")
        cmborderby.Items.Add("Oldest to Newest")
        cmborderby.SelectedIndex = 0
    End Sub

    Private Sub LoadAppointments(Optional statusFilter As String = "", Optional orderBy As String = "DESC")
        flowAppointments.Controls.Clear()

        Dim query As String = ""
        query &= "SELECT a.appointment_id, a.appointment_date, a.appointment_time, a.status, " &
                 "GROUP_CONCAT(s.name SEPARATOR ', ') AS services, " &
                 "GROUP_CONCAT(DISTINCT CONCAT(ur_staff.first_name, ' ', ur_staff.last_name) SEPARATOR ', ') AS staff_names, " &
                 "u.first_name, u.last_name, up.phone, up.email, " &
                 "SUM(s.price) as total_amount " &
                 "FROM appointments a " &
                 "LEFT JOIN appointment_services aps ON a.appointment_id = aps.appointment_id " &
                 "LEFT JOIN services s ON aps.service_id = s.service_id " &
                 "LEFT JOIN staff st ON aps.staff_id = st.staff_id " &
                 "LEFT JOIN user_register ur_staff ON st.user_id = ur_staff.user_id " &
                 "LEFT JOIN user_register u ON a.user_id = u.user_id " &
                 "LEFT JOIN user_profiles up ON a.user_id = up.user_id " &
                 "WHERE a.user_id = @userID"

        If Not String.IsNullOrEmpty(statusFilter) Then
            query &= " AND a.status = @status"
        End If

        query &= " GROUP BY a.appointment_id ORDER BY a.appointment_date " & orderBy

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userID", userID)
                If Not String.IsNullOrEmpty(statusFilter) Then
                    cmd.Parameters.AddWithValue("@status", statusFilter)
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim appointmentID = Convert.ToInt32(reader("appointment_id"))
                            Dim appDate = Convert.ToDateTime(reader("appointment_date")).ToString("MMMM dd, yyyy")
                            Dim appTime = reader("appointment_time").ToString()
                            Dim status = reader("status").ToString()
                            Dim serviceName = If(IsDBNull(reader("services")), "No services", reader("services").ToString())
                            Dim staffName = If(IsDBNull(reader("staff_names")), "Not assigned", reader("staff_names").ToString())
                            Dim firstName = reader("first_name").ToString()
                            Dim lastName = reader("last_name").ToString()
                            Dim totalAmount = If(IsDBNull(reader("total_amount")), 0, Convert.ToDecimal(reader("total_amount")))

                            Dim panel As New Panel With {
                                .Width = flowAppointments.Width - 25,
                                .Height = 160,
                                .BackColor = Color.WhiteSmoke,
                                .Padding = New Padding(10),
                                .Margin = New Padding(5)
                            }

                            Dim lblDetails As New Label With {
                                .AutoSize = False,
                                .Width = panel.Width - 150,
                                .Height = panel.Height - 20,
                                .Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Regular),
                                .Text = $"Date: {appDate}" & vbCrLf &
                                        $"Time: {appTime}" & vbCrLf &
                                        $"Services: {serviceName}" & vbCrLf &
                                        $"Staff: {staffName}" & vbCrLf &
                                        $"Status: {status}" & vbCrLf &
                                        $"Amount: ₱{totalAmount:N2}",
                                .Location = New Point(10, 10)
                            }

                            panel.Controls.Add(lblDetails)


                            If status = "Completed" OrElse status = "Approved" Then
                                Dim btnPrint As New Button()
                                btnPrint.Text = "Print Receipt"
                                btnPrint.Size = New Size(120, 35)
                                btnPrint.Location = New Point(panel.Width - 135, 20)
                                btnPrint.BackColor = Color.FromArgb(77, 0, 18)
                                btnPrint.ForeColor = Color.White
                                btnPrint.FlatStyle = FlatStyle.Flat
                                btnPrint.Cursor = Cursors.Hand
                                btnPrint.Font = New System.Drawing.Font("Segoe UI", 9, FontStyle.Bold)
                                AddHandler btnPrint.Click, Sub()
                                                               GeneratePDFReceipt(appointmentID)
                                                           End Sub
                                panel.Controls.Add(btnPrint)
                            End If


                            If status = "Pending" Then
                                Dim btnCancel As New Button()
                                btnCancel.Text = "Cancel"
                                btnCancel.Size = New Size(120, 35)
                                btnCancel.Location = New Point(panel.Width - 135, 20)
                                btnCancel.BackColor = Color.FromArgb(255, 128, 128)
                                btnCancel.ForeColor = Color.FromArgb(77, 0, 18)
                                btnCancel.FlatStyle = FlatStyle.Flat
                                btnCancel.Cursor = Cursors.Hand
                                btnCancel.Font = New System.Drawing.Font("Segoe UI", 9, FontStyle.Bold)

                                AddHandler btnCancel.Click, Sub()
                                                                Dim confirm = MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm", MessageBoxButtons.YesNo)
                                                                If confirm = DialogResult.Yes Then
                                                                    CancelAppointment(appointmentID)
                                                                End If
                                                            End Sub
                                panel.Controls.Add(btnCancel)
                            End If

                            flowAppointments.Controls.Add(panel)
                        End While
                    Else
                        Dim lbl As New Label With {
                            .Text = "No appointment records found.",
                            .ForeColor = Color.DarkGray,
                            .Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Italic),
                            .AutoSize = True
                        }
                        flowAppointments.Controls.Add(lbl)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading appointments: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub GeneratePDFReceipt(appointmentID As Integer)
        Try

            Dim appointmentData = GetAppointmentData(appointmentID)
            If appointmentData Is Nothing Then
                MessageBox.Show("No appointment data found.")
                Return
            End If


            Dim fileName As String = $"SalonReceipt_{appointmentID}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName)


            Dim document As New Document(PageSize.A4, 40, 40, 40, 40)
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(filePath, FileMode.Create))

            document.Open()


            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
            Dim headerFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD)
            Dim normalFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10)
            Dim boldFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)


            Dim salonTitle As New Paragraph("SHAFAYE SALON", titleFont)
            salonTitle.Alignment = Element.ALIGN_CENTER
            salonTitle.SpacingAfter = 5
            document.Add(salonTitle)

            Dim tagline As New Paragraph("Professional Beauty Services", normalFont)
            tagline.Alignment = Element.ALIGN_CENTER
            tagline.SpacingAfter = 5
            document.Add(tagline)

            Dim contact As New Paragraph("Km. 14 East Service Road, Western Bicutan, Taguig City, Metro Manila" & vbLf & "Phone: 09697858317 | Email: shafayesalon@gmail.com", normalFont)
            contact.Alignment = Element.ALIGN_CENTER
            contact.SpacingAfter = 20
            document.Add(contact)


            Dim line As New Paragraph("_________________________________________________________________")
            line.Alignment = Element.ALIGN_CENTER
            line.SpacingAfter = 20
            document.Add(line)


            Dim receiptTitle As New Paragraph("APPOINTMENT RECEIPT", headerFont)
            receiptTitle.Alignment = Element.ALIGN_CENTER
            receiptTitle.SpacingAfter = 15
            document.Add(receiptTitle)


            Dim receiptInfo As New Paragraph($"Receipt Date: {DateTime.Now:MMMM dd, yyyy hh:mm tt}                Receipt #: {appointmentID:D4}", normalFont)
            receiptInfo.Alignment = Element.ALIGN_CENTER
            receiptInfo.SpacingAfter = 20
            document.Add(receiptInfo)


            Dim customerHeader As New Paragraph("CUSTOMER INFORMATION", headerFont)
            customerHeader.SpacingAfter = 10
            document.Add(customerHeader)

            document.Add(New Paragraph($"Name: {appointmentData("CustomerName")}", normalFont))
            document.Add(New Paragraph($"Phone: {appointmentData("Phone")}", normalFont))
            document.Add(New Paragraph($"Email: {appointmentData("Email")}", normalFont))
            document.Add(New Paragraph(" ", normalFont))


            Dim appointmentHeader As New Paragraph("APPOINTMENT DETAILS", headerFont)
            appointmentHeader.SpacingAfter = 10
            document.Add(appointmentHeader)

            document.Add(New Paragraph($"Date: {appointmentData("AppointmentDate")}", normalFont))
            document.Add(New Paragraph($"Time: {appointmentData("AppointmentTime")}", normalFont))
            document.Add(New Paragraph($"Status: {appointmentData("Status")}", normalFont))
            document.Add(New Paragraph(" ", normalFont))


            Dim servicesHeader As New Paragraph("SERVICES AVAILED", headerFont)
            servicesHeader.SpacingAfter = 10
            document.Add(servicesHeader)


            Dim table As New PdfPTable(3)
            table.WidthPercentage = 100
            table.SetWidths({4, 3, 2})


            Dim serviceCell As New PdfPCell(New Phrase("SERVICE", boldFont))
            serviceCell.HorizontalAlignment = Element.ALIGN_LEFT
            serviceCell.Padding = 8
            serviceCell.BackgroundColor = BaseColor.LIGHT_GRAY
            table.AddCell(serviceCell)

            Dim staffCell As New PdfPCell(New Phrase("STAFF", boldFont))
            staffCell.HorizontalAlignment = Element.ALIGN_LEFT
            staffCell.Padding = 8
            staffCell.BackgroundColor = BaseColor.LIGHT_GRAY
            table.AddCell(staffCell)

            Dim priceCell As New PdfPCell(New Phrase("PRICE", boldFont))
            priceCell.HorizontalAlignment = Element.ALIGN_RIGHT
            priceCell.Padding = 8
            priceCell.BackgroundColor = BaseColor.LIGHT_GRAY
            table.AddCell(priceCell)


            Dim services As List(Of Dictionary(Of String, Object)) = appointmentData("Services")
            For Each service In services

                Dim serviceNameCell As New PdfPCell(New Phrase(service("ServiceName").ToString(), normalFont))
                serviceNameCell.Padding = 8
                serviceNameCell.HorizontalAlignment = Element.ALIGN_LEFT
                table.AddCell(serviceNameCell)


                Dim staffNameCell As New PdfPCell(New Phrase(service("StaffName").ToString(), normalFont))
                staffNameCell.Padding = 8
                staffNameCell.HorizontalAlignment = Element.ALIGN_LEFT
                table.AddCell(staffNameCell)


                Dim servicePriceCell As New PdfPCell(New Phrase($"₱{Convert.ToDecimal(service("Price")):N2}", normalFont))
                servicePriceCell.Padding = 8
                servicePriceCell.HorizontalAlignment = Element.ALIGN_RIGHT
                table.AddCell(servicePriceCell)
            Next

            document.Add(table)
            document.Add(New Paragraph(" ", normalFont)) ' Space

            Dim totalParagraph As New Paragraph($"TOTAL AMOUNT: ₱{Convert.ToDecimal(appointmentData("TotalAmount")):N2}", headerFont)
            totalParagraph.Alignment = Element.ALIGN_RIGHT
            totalParagraph.SpacingBefore = 10
            totalParagraph.SpacingAfter = 20
            document.Add(totalParagraph)


            Dim footerLine As New Paragraph("_________________________________________________________________")
            footerLine.Alignment = Element.ALIGN_CENTER
            footerLine.SpacingAfter = 10
            document.Add(footerLine)

            Dim thankYou As New Paragraph("Thank you for your patronage!", headerFont)
            thankYou.Alignment = Element.ALIGN_CENTER
            thankYou.SpacingAfter = 5
            document.Add(thankYou)

            Dim appreciation As New Paragraph("We appreciate choosing Shafaye Salon", normalFont)
            appreciation.Alignment = Element.ALIGN_CENTER
            appreciation.SpacingAfter = 10
            document.Add(appreciation)

            Dim footerContact As New Paragraph("For inquiries, please contact:" & vbLf & "Phone: 09697858317 | Email: shafayesalon@gmail.com", normalFont)
            footerContact.Alignment = Element.ALIGN_CENTER
            document.Add(footerContact)

            document.Close()

            MessageBox.Show($"Professional PDF receipt generated successfully!" & vbCrLf & "Saved as: " & fileName & vbCrLf & vbCrLf & "The PDF has been saved to your Desktop.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            If MessageBox.Show("Would you like to open the receipt?", "Open Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Process.Start(filePath)
            End If

        Catch ex As Exception
            MessageBox.Show("Error generating PDF receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetAppointmentData(appointmentID As Integer) As Dictionary(Of String, Object)
        Try
            conn.Open()
            Dim appointmentData As New Dictionary(Of String, Object)
            Dim services As New List(Of Dictionary(Of String, Object))

            Dim query As String = "SELECT a.appointment_id, a.appointment_date, a.appointment_time, a.status, " &
                                     "CONCAT(u.first_name, ' ', u.last_name) as customer_name, " &
                                     "IFNULL(up.phone, 'N/A') as phone, IFNULL(up.email, 'N/A') as email, " &
                                     "s.name as service_name, s.price, " &
                                     "IFNULL(CONCAT(ur_staff.first_name, ' ', ur_staff.last_name), 'Not assigned') as staff_name " &
                                     "FROM appointments a " &
                                     "LEFT JOIN user_register u ON a.user_id = u.user_id " &
                                     "LEFT JOIN user_profiles up ON a.user_id = up.user_id " &
                                     "LEFT JOIN appointment_services aps ON a.appointment_id = aps.appointment_id " &
                                     "LEFT JOIN services s ON aps.service_id = s.service_id " &
                                     "LEFT JOIN staff st ON aps.staff_id = st.staff_id " &
                                     "LEFT JOIN user_register ur_staff ON st.user_id = ur_staff.user_id " &
                                     "WHERE a.appointment_id = @appointmentID"


            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@appointmentID", appointmentID)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    Dim totalAmount As Decimal = 0

                    While reader.Read()

                        If appointmentData.Count = 0 Then
                            appointmentData("AppointmentID") = reader("appointment_id")
                            appointmentData("CustomerName") = reader("customer_name").ToString()
                            appointmentData("Phone") = reader("phone").ToString()
                            appointmentData("Email") = reader("email").ToString()
                            appointmentData("AppointmentDate") = Convert.ToDateTime(reader("appointment_date")).ToString("MMMM dd, yyyy")
                            appointmentData("AppointmentTime") = reader("appointment_time").ToString()
                            appointmentData("Status") = reader("status").ToString()
                        End If


                        If Not IsDBNull(reader("service_name")) Then
                            Dim serviceData As New Dictionary(Of String, Object)
                            serviceData("ServiceName") = reader("service_name").ToString()
                            serviceData("StaffName") = reader("staff_name").ToString()
                            serviceData("Price") = Convert.ToDecimal(reader("price"))
                            services.Add(serviceData)
                            totalAmount += Convert.ToDecimal(reader("price"))
                        End If
                    End While

                    appointmentData("Services") = services
                    appointmentData("TotalAmount") = totalAmount
                End Using
            End Using

            Return appointmentData

        Catch ex As Exception
            MessageBox.Show("Error retrieving appointment data: " & ex.Message)
            Return Nothing
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    Private Sub CancelAppointment(ByVal appointmentID As Integer)
        Try
            conn.Open()
            Dim query As String = "UPDATE appointments SET status = 'Cancelled' WHERE appointment_id = @id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", appointmentID)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Appointment cancelled successfully.")
            LoadAppointments()
        Catch ex As Exception
            MessageBox.Show("Error cancelling appointment: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub FilterAppointments(sender As Object, e As EventArgs)
        Dim statusFilter As String = ""
        Dim orderBy As String = "DESC"


        If cmbStatus.SelectedItem IsNot Nothing AndAlso cmbStatus.SelectedItem.ToString() <> "All Status" Then
            statusFilter = cmbStatus.SelectedItem.ToString()
        End If


        If cmborderby.SelectedItem IsNot Nothing Then
            orderBy = If(cmborderby.SelectedItem.ToString() = "Oldest to Newest", "ASC", "DESC")
        End If

        LoadAppointments(statusFilter, orderBy)
    End Sub
End Class