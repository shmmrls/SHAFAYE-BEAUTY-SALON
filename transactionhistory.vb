Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data

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
        conn = New MySqlConnection("server=localhost;userid=root;password=;database=final_shafaye_salon")
    End Sub

    Private Sub transactionhistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAppointments()
        AddHandler cmbStatus.SelectedIndexChanged, AddressOf FilterAppointments
        AddHandler cmborderby.SelectedIndexChanged, AddressOf FilterAppointments
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
                                .Width = panel.Width - 20,
                                .Height = 90,
                                .Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Regular),
                                .Text = $"Date: {appDate}" & vbCrLf &
                                        $"Time: {appTime}" & vbCrLf &
                                        $"Services: {serviceName}" & vbCrLf &
                                        $"Staff: {staffName}" & vbCrLf &
                                        $"Status: {status}" & vbCrLf &
                                        $"Amount: ₱{totalAmount:N2}"
                            }

                            panel.Controls.Add(lblDetails)

                            ' Print Receipt Button
                            Dim btnPrint As New Button()
                            btnPrint.Text = "Print Receipt"
                            btnPrint.Size = New Size(110, 30)
                            btnPrint.Location = New Point(10, lblDetails.Bottom + 10)
                            btnPrint.BackColor = Color.SteelBlue
                            btnPrint.ForeColor = Color.White
                            btnPrint.FlatStyle = FlatStyle.Flat
                            AddHandler btnPrint.Click, Sub()
                                                           GenerateCrystalReceipt(appointmentID)
                                                       End Sub
                            panel.Controls.Add(btnPrint)

                            ' Cancel Appointment Button (only if status is Pending)
                            If status = "Pending" Then
                                Dim btnCancel As New Button()
                                btnCancel.Text = "Cancel Appointment"
                                btnCancel.Size = New Size(130, 30)
                                btnCancel.Location = New Point(btnPrint.Right + 10, lblDetails.Bottom + 10)
                                btnCancel.BackColor = Color.IndianRed
                                btnCancel.ForeColor = Color.White
                                btnCancel.FlatStyle = FlatStyle.Flat
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

    Private Sub GenerateCrystalReceipt(appointmentID As Integer)
        Try
            ' Create a DataSet for the Crystal Report
            Dim ds As New DataSet()
            Dim dt As New DataTable("ReceiptData")

            ' Define the structure for our receipt data
            dt.Columns.Add("AppointmentID", GetType(Integer))
            dt.Columns.Add("CustomerName", GetType(String))
            dt.Columns.Add("Phone", GetType(String))
            dt.Columns.Add("Email", GetType(String))
            dt.Columns.Add("AppointmentDate", GetType(String))
            dt.Columns.Add("AppointmentTime", GetType(String))
            dt.Columns.Add("Status", GetType(String))
            dt.Columns.Add("ServiceName", GetType(String))
            dt.Columns.Add("ServicePrice", GetType(Decimal))
            dt.Columns.Add("StaffName", GetType(String))
            dt.Columns.Add("TotalAmount", GetType(Decimal))
            dt.Columns.Add("ReceiptDate", GetType(String))
            dt.Columns.Add("SalonName", GetType(String))
            dt.Columns.Add("SalonAddress", GetType(String))
            dt.Columns.Add("SalonPhone", GetType(String))

            ' Get appointment details from database
            conn.Open()
            Dim query As String = "SELECT a.appointment_id, a.appointment_date, a.appointment_time, a.status, " &
                                 "CONCAT(u.first_name, ' ', u.last_name) as customer_name, " &
                                 "up.phone, up.email, " &
                                 "s.name as service_name, s.price, " &
                                 "CONCAT(ur_staff.first_name, ' ', ur_staff.last_name) as staff_name " &
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
                    Dim customerName As String = ""
                    Dim phone As String = ""
                    Dim email As String = ""
                    Dim appDate As String = ""
                    Dim appTime As String = ""
                    Dim status As String = ""

                    While reader.Read()
                        ' Get basic info (same for all services)
                        If String.IsNullOrEmpty(customerName) Then
                            customerName = If(IsDBNull(reader("customer_name")), "N/A", reader("customer_name").ToString())
                            phone = If(IsDBNull(reader("phone")), "N/A", reader("phone").ToString())
                            email = If(IsDBNull(reader("email")), "N/A", reader("email").ToString())
                            appDate = Convert.ToDateTime(reader("appointment_date")).ToString("MMMM dd, yyyy")
                            appTime = reader("appointment_time").ToString()
                            status = reader("status").ToString()
                        End If

                        ' Add service details
                        Dim serviceName As String = If(IsDBNull(reader("service_name")), "N/A", reader("service_name").ToString())
                        Dim servicePrice As Decimal = If(IsDBNull(reader("price")), 0, Convert.ToDecimal(reader("price")))
                        Dim staffName As String = If(IsDBNull(reader("staff_name")), "Not assigned", reader("staff_name").ToString())

                        totalAmount += servicePrice

                        ' Add row to DataTable
                        Dim row As DataRow = dt.NewRow()
                        row("AppointmentID") = appointmentID
                        row("CustomerName") = customerName
                        row("Phone") = phone
                        row("Email") = email
                        row("AppointmentDate") = appDate
                        row("AppointmentTime") = appTime
                        row("Status") = status
                        row("ServiceName") = serviceName
                        row("ServicePrice") = servicePrice
                        row("StaffName") = staffName
                        row("TotalAmount") = totalAmount
                        row("ReceiptDate") = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt")
                        row("SalonName") = "SHAFAYE SALON"
                        row("SalonAddress") = "Your Salon Address Here"
                        row("SalonPhone") = "Your Salon Phone Number"

                        dt.Rows.Add(row)
                    End While
                End Using
            End Using

            ds.Tables.Add(dt)

            ' Create and configure Crystal Report
            Dim rpt As New ReportDocument()

            ' Load your Crystal Report file (.rpt)
            ' Make sure to create this Crystal Report file first
            rpt.Load(Application.StartupPath & "\Reports\SalonReceipt.rpt")

            ' Set the data source
            rpt.SetDataSource(ds)

            ' Show the report in a Crystal Report Viewer form
            Dim frmReportViewer As New Form()
            frmReportViewer.Text = "Salon Receipt - Appointment #" & appointmentID
            frmReportViewer.WindowState = FormWindowState.Maximized

            Dim crystalReportViewer As New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            crystalReportViewer.Dock = DockStyle.Fill
            crystalReportViewer.ReportSource = rpt

            frmReportViewer.Controls.Add(crystalReportViewer)
            frmReportViewer.ShowDialog()

            ' Clean up
            rpt.Close()
            rpt.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error generating Crystal Report receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

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
        Dim statusFilter As String = cmbStatus.Text
        Dim orderBy As String = If(cmborderby.Text = "Oldest to Newest", "ASC", "DESC")
        LoadAppointments(statusFilter, orderBy)
    End Sub
End Class