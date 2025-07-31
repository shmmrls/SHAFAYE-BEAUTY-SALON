Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms

' mp4 Any/Other CRUD functions  
'READ: Loads all customer messages from `contact_messages`.  
'DELETE: Admin can delete a specific message by clicking "Delete" button.  

'FOR CUSTOMER SUPPORT → INQUIRY MANAGEMENT
'Admin can view, read, And delete customer messages submitted through the contact form.


Public Class customerInquiries
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=salon_admin;Pwd=AdminSalon2025!;"
    Private selectedMessageId As Integer = 0

    Private Sub customerInquiries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerInquiries()
    End Sub

    Private Sub LoadCustomerInquiries()
        Try
            Dim pnlMessagesContainer As Panel = Me.Controls("pnlMessagesContainer")
            pnlMessagesContainer.Controls.Clear()

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT message_id, subject, message, sent_at FROM contact_messages ORDER BY sent_at DESC"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim yPosition As Integer = 10

                        While reader.Read()
                            CreateMessageCard(pnlMessagesContainer, reader, yPosition)
                            yPosition += 120
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading customer inquiries: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CreateMessageCard(parentPanel As Panel, reader As MySqlDataReader, yPos As Integer)
        Dim cardPanel As New Panel()
        cardPanel.Size = New Size(pnlMessagesContainer.Width - 30, 100)
        cardPanel.Location = New Point(10, yPos)
        cardPanel.BorderStyle = BorderStyle.FixedSingle
        cardPanel.BackColor = Color.White
        cardPanel.Cursor = Cursors.Hand
        cardPanel.Tag = reader("message_id").ToString()

        AddHandler cardPanel.Click, AddressOf CardPanel_Click

        Dim lblCustomer As New Label()
        lblCustomer.Text = "Customer: Anonymous"
        lblCustomer.Font = New Font("Arial", 9, FontStyle.Bold)
        lblCustomer.Location = New Point(10, 8)
        lblCustomer.Size = New Size(200, 15)
        lblCustomer.ForeColor = Color.Black
        AddHandler lblCustomer.Click, AddressOf CardPanel_Click
        cardPanel.Controls.Add(lblCustomer)

        Dim lblSubject As New Label()
        lblSubject.Text = "Subject: " & reader("subject").ToString()
        lblSubject.Font = New Font("Arial", 9, FontStyle.Bold)
        lblSubject.Location = New Point(10, 25)
        lblSubject.Size = New Size(400, 15)
        lblSubject.ForeColor = Color.FromArgb(77, 0, 18)
        AddHandler lblSubject.Click, AddressOf CardPanel_Click
        cardPanel.Controls.Add(lblSubject)

        Dim messageText As String = reader("message").ToString()
        Dim messagePreview As String = If(messageText.Length > 80,
                                        messageText.Substring(0, 80) & "...",
                                        messageText)
        Dim lblMessage As New Label()
        lblMessage.Text = messagePreview
        lblMessage.Font = New Font("Arial", 8)
        lblMessage.Location = New Point(10, 42)
        lblMessage.Size = New Size(450, 30)
        lblMessage.ForeColor = Color.Black
        AddHandler lblMessage.Click, AddressOf CardPanel_Click
        cardPanel.Controls.Add(lblMessage)

        Dim lblDate As New Label()
        lblDate.Text = "Sent: " & Convert.ToDateTime(reader("sent_at")).ToString("MMM dd, yyyy hh:mm tt")
        lblDate.Font = New Font("Arial", 8)
        lblDate.Location = New Point(10, 75)
        lblDate.Size = New Size(200, 15)
        lblDate.ForeColor = Color.Black
        AddHandler lblDate.Click, AddressOf CardPanel_Click
        cardPanel.Controls.Add(lblDate)

        Dim btnDelete As New Button()
        btnDelete.Text = "Delete"
        btnDelete.Size = New Size(60, 25)
        btnDelete.Location = New Point(cardPanel.Width - btnDelete.Width - 30, 35)
        btnDelete.BackColor = Color.FromArgb(77, 0, 18)
        btnDelete.ForeColor = Color.White
        btnDelete.Font = New Font("Arial", 8, FontStyle.Bold)
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Tag = reader("message_id").ToString()
        AddHandler btnDelete.Click, AddressOf btnDelete_Click
        cardPanel.Controls.Add(btnDelete)

        parentPanel.Controls.Add(cardPanel)
    End Sub

    Private Sub CardPanel_Click(sender As Object, e As EventArgs)
        Try
            Dim clickedControl As Control = DirectCast(sender, Control)
            Dim messageId As String = ""

            If clickedControl.Tag IsNot Nothing Then
                messageId = clickedControl.Tag.ToString()
            ElseIf clickedControl.Parent IsNot Nothing AndAlso clickedControl.Parent.Tag IsNot Nothing Then
                messageId = clickedControl.Parent.Tag.ToString()
            End If

            If Not String.IsNullOrEmpty(messageId) Then
                ShowMessageDetails(messageId)
            End If

        Catch ex As Exception
            MessageBox.Show("Error selecting message: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowMessageDetails(messageId As String)
        Try
            selectedMessageId = Convert.ToInt32(messageId)

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT subject, message, sent_at FROM contact_messages WHERE message_id = @messageId"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@messageId", selectedMessageId)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim txtMessageDetails As TextBox = Me.Controls("txtMessageDetails")
                            Dim fullDetails As String = "Subject: " & reader("subject").ToString() & vbCrLf & vbCrLf &
                                                       "Message: " & vbCrLf & reader("message").ToString() & vbCrLf & vbCrLf &
                                                       "Sent: " & Convert.ToDateTime(reader("sent_at")).ToString("MMMM dd, yyyy hh:mm tt")
                            txtMessageDetails.Text = fullDetails
                        End If
                    End Using
                End Using
            End Using

            Dim pnlMessagesContainer As Panel = Me.Controls("pnlMessagesContainer")
            For Each ctrl As Control In pnlMessagesContainer.Controls
                If TypeOf ctrl Is Panel Then
                    If ctrl.Tag?.ToString() = messageId Then
                        ctrl.BackColor = Color.FromArgb(230, 230, 250)
                    Else
                        ctrl.BackColor = Color.White
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error displaying message details: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Try
            Dim button As Button = DirectCast(sender, Button)
            Dim messageId As Integer = Convert.ToInt32(button.Tag.ToString())

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this message?",
                                                       "Confirm Delete",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM contact_messages WHERE message_id = @messageId"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@messageId", messageId)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Message deleted successfully!", "Success",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadCustomerInquiries()

                            If selectedMessageId = messageId Then
                                Dim txtMessageDetails As TextBox = Me.Controls("txtMessageDetails")
                                txtMessageDetails.Clear()
                                selectedMessageId = 0
                            End If
                        Else
                            MessageBox.Show("Failed to delete message.", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting message: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class