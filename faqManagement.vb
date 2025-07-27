Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms

'Create section that shows and reads common questions about services, scheduling, and policies.

Public Class faqManagement
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=root;Pwd=;"
    Private selectedFaqId As Integer = 0

    Private Sub faqManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flpFaqList.AutoScroll = True
        flpFaqList.WrapContents = False
        flpFaqList.FlowDirection = FlowDirection.TopDown

        LoadQuestions()
        LoadFaqList()
    End Sub

    Private Sub LoadQuestions()
        Try
            cmbQuestions.Items.Clear()

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim faqQuery As String = "SELECT faq_id, question FROM faq ORDER BY faq_id DESC"
                Using command As New MySqlCommand(faqQuery, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim item As New QuestionItem()
                            item.Text = reader("question").ToString()
                            item.Id = Convert.ToInt32(reader("faq_id"))
                            item.Type = "FAQ"
                            cmbQuestions.Items.Add(item)
                        End While
                    End Using
                End Using

                Dim messageQuery As String = "SELECT message_id, subject, message FROM contact_messages ORDER BY sent_at DESC"
                Using messageCommand As New MySqlCommand(messageQuery, connection)
                    Using messageReader As MySqlDataReader = messageCommand.ExecuteReader()
                        While messageReader.Read()
                            Dim item As New QuestionItem()
                            item.Text = "[Customer Message] " & messageReader("subject").ToString() & ": " & messageReader("message").ToString()
                            item.Id = Convert.ToInt32(messageReader("message_id"))
                            item.Type = "MESSAGE"
                            item.OriginalMessage = messageReader("message").ToString()
                            cmbQuestions.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading questions: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbQuestions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuestions.SelectedIndexChanged
        Try
            If cmbQuestions.SelectedItem IsNot Nothing Then
                Dim selectedItem As QuestionItem = DirectCast(cmbQuestions.SelectedItem, QuestionItem)

                If selectedItem.Type = "FAQ" Then
                    selectedFaqId = selectedItem.Id
                    LoadFaqAnswer(selectedFaqId)
                ElseIf selectedItem.Type = "MESSAGE" Then
                    selectedFaqId = 0
                    rtbAnswer.Clear()
                    cmbQuestions.Text = selectedItem.OriginalMessage
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading selected item: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadFaqAnswer(faqId As Integer)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT answer FROM faq WHERE faq_id = @faqId"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@faqId", faqId)
                    Dim result As Object = command.ExecuteScalar()

                    rtbAnswer.Text = If(result IsNot Nothing, result.ToString(), "")
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading FAQ answer: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If String.IsNullOrWhiteSpace(cmbQuestions.Text) OrElse String.IsNullOrWhiteSpace(rtbAnswer.Text) Then
                MessageBox.Show("Please enter both question and answer.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim checkQuery As String = "SELECT faq_id FROM faq WHERE question = @question"
                Using checkCommand As New MySqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@question", cmbQuestions.Text.Trim())
                    Dim existingId As Object = checkCommand.ExecuteScalar()

                    If existingId IsNot Nothing Then
                        Dim updateQuery As String = "UPDATE faq SET answer = @answer WHERE faq_id = @faqId"
                        Using updateCommand As New MySqlCommand(updateQuery, connection)
                            updateCommand.Parameters.AddWithValue("@answer", rtbAnswer.Text.Trim())
                            updateCommand.Parameters.AddWithValue("@faqId", Convert.ToInt32(existingId))
                            updateCommand.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("FAQ updated successfully!", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Dim insertQuery As String = "INSERT INTO faq (question, answer, is_visible) VALUES (@question, @answer, 1)"
                        Using insertCommand As New MySqlCommand(insertQuery, connection)
                            insertCommand.Parameters.AddWithValue("@question", cmbQuestions.Text.Trim())
                            insertCommand.Parameters.AddWithValue("@answer", rtbAnswer.Text.Trim())
                            insertCommand.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("FAQ added successfully!", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

            LoadQuestions()
            LoadFaqList()

            cmbQuestions.Text = ""
            rtbAnswer.Clear()
            selectedFaqId = 0

        Catch ex As Exception
            MessageBox.Show("Error adding/updating FAQ: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If selectedFaqId = 0 Then
                MessageBox.Show("Please select an FAQ from the list to delete.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this FAQ?",
                                                       "Confirm Delete",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM faq WHERE faq_id = @faqId"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@faqId", selectedFaqId)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("FAQ deleted successfully!", "Success",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information)

                            LoadQuestions()
                            LoadFaqList()

                            cmbQuestions.Text = ""
                            rtbAnswer.Clear()
                            selectedFaqId = 0
                        Else
                            MessageBox.Show("Failed to delete FAQ.", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting FAQ: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        Try
            If String.IsNullOrWhiteSpace(cmbQuestions.Text) Then
                MessageBox.Show("Please select a question to toggle visibility.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim findQuery As String = "SELECT faq_id, is_visible FROM faq WHERE question = @question"
                Using findCommand As New MySqlCommand(findQuery, connection)
                    findCommand.Parameters.AddWithValue("@question", cmbQuestions.Text.Trim())
                    Using reader As MySqlDataReader = findCommand.ExecuteReader()
                        If reader.Read() Then
                            Dim faqId As Integer = Convert.ToInt32(reader("faq_id"))
                            Dim currentStatus As Boolean = Convert.ToBoolean(reader("is_visible"))
                            reader.Close()

                            Dim toggleQuery As String = "UPDATE faq SET is_visible = @newStatus WHERE faq_id = @faqId"
                            Using toggleCommand As New MySqlCommand(toggleQuery, connection)
                                toggleCommand.Parameters.AddWithValue("@newStatus", Not currentStatus)
                                toggleCommand.Parameters.AddWithValue("@faqId", faqId)
                                toggleCommand.ExecuteNonQuery()
                            End Using

                            Dim statusText As String = If(Not currentStatus, "visible", "hidden")
                            MessageBox.Show($"FAQ is now {statusText}!", "Success",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information)

                            LoadFaqList()
                        Else
                            MessageBox.Show("Please add this FAQ first before toggling visibility.", "FAQ Not Found",
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error toggling FAQ visibility: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadFaqList()
        Try
            flpFaqList.Controls.Clear()

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT faq_id, question, answer, IFNULL(is_visible, 1) as is_visible FROM faq ORDER BY faq_id DESC"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            CreateFaqCard(flpFaqList, reader)
                        End While
                    End Using
                End Using
            End Using

            flpFaqList.VerticalScroll.Value = flpFaqList.VerticalScroll.Maximum
            flpFaqList.PerformLayout()

        Catch ex As Exception
            MessageBox.Show("Error loading FAQ list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub CreateFaqCard(parentPanel As FlowLayoutPanel, reader As MySqlDataReader)
        Dim cardPanel As New Panel()
        cardPanel.Size = New Size(flpFaqList.Width - 30, 100)
        cardPanel.BorderStyle = BorderStyle.FixedSingle
        cardPanel.BackColor = Color.White
        cardPanel.Margin = New Padding(5)
        cardPanel.Tag = reader("faq_id").ToString()
        cardPanel.Cursor = Cursors.Hand
        cardPanel.AutoScroll = True
        AddHandler cardPanel.Click, AddressOf FaqCard_Click

        Dim isVisible As Boolean = Convert.ToBoolean(reader("is_visible"))
        If Not isVisible Then
            cardPanel.BackColor = Color.FromArgb(255, 240, 240)
        End If

        Dim lblQuestion As New Label()
        lblQuestion.Text = "Q: " & reader("question").ToString()
        lblQuestion.Font = New Font("Arial", 10, FontStyle.Bold)
        lblQuestion.Location = New Point(10, 10)
        lblQuestion.Size = New Size(600, 20)
        lblQuestion.ForeColor = Color.FromArgb(77, 0, 18)
        AddHandler lblQuestion.Click, AddressOf FaqCard_Click
        cardPanel.Controls.Add(lblQuestion)

        Dim answerText As String = reader("answer").ToString()
        Dim lblAnswer As New Label()

        If String.IsNullOrWhiteSpace(answerText) Then
            lblAnswer.Text = "A: Please answer this customer inquiry"
            lblAnswer.Font = New Font("Arial", 9, FontStyle.Italic)
            lblAnswer.ForeColor = Color.Red
        Else
            lblAnswer.Text = "A: " & answerText
            lblAnswer.Font = New Font("Arial", 9)
            lblAnswer.ForeColor = Color.Black
        End If

        lblAnswer.Location = New Point(10, 35)
        lblAnswer.Size = New Size(600, 30)
        AddHandler lblAnswer.Click, AddressOf FaqCard_Click
        cardPanel.Controls.Add(lblAnswer)

        Dim lblStatus As New Label()
        lblStatus.Text = If(isVisible, "Visible on Homepage", "Hidden from Homepage")
        lblStatus.Font = New Font("Arial", 8, FontStyle.Bold)
        lblStatus.Location = New Point(10, 70)
        lblStatus.Size = New Size(200, 15)
        lblStatus.ForeColor = If(isVisible, Color.Green, Color.Red)
        AddHandler lblStatus.Click, AddressOf FaqCard_Click
        cardPanel.Controls.Add(lblStatus)

        parentPanel.Controls.Add(cardPanel)
    End Sub

    Private Sub FaqCard_Click(sender As Object, e As EventArgs)
        Try
            Dim clickedControl As Control = DirectCast(sender, Control)
            Dim faqId As String = ""

            If clickedControl.Tag IsNot Nothing Then
                faqId = clickedControl.Tag.ToString()
            ElseIf clickedControl.Parent IsNot Nothing AndAlso clickedControl.Parent.Tag IsNot Nothing Then
                faqId = clickedControl.Parent.Tag.ToString()
            End If

            If Not String.IsNullOrEmpty(faqId) Then
                selectedFaqId = Convert.ToInt32(faqId)

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "SELECT question, answer FROM faq WHERE faq_id = @faqId"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@faqId", selectedFaqId)
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            If reader.Read() Then
                                cmbQuestions.Text = reader("question").ToString()
                                rtbAnswer.Text = If(reader("answer") IsNot DBNull.Value, reader("answer").ToString(), "")
                            End If
                        End Using
                    End Using
                End Using

                For Each ctrl As Control In flpFaqList.Controls
                    If TypeOf ctrl Is Panel Then
                        If ctrl.Tag?.ToString() = faqId Then
                            ctrl.BackColor = Color.FromArgb(200, 220, 255)
                        Else
                            Using connection As New MySqlConnection(connectionString)
                                connection.Open()
                                Dim visQuery As String = "SELECT IFNULL(is_visible, 1) as is_visible FROM faq WHERE faq_id = @id"
                                Using visCommand As New MySqlCommand(visQuery, connection)
                                    visCommand.Parameters.AddWithValue("@id", Convert.ToInt32(ctrl.Tag.ToString()))
                                    Dim isVisible As Boolean = Convert.ToBoolean(visCommand.ExecuteScalar())
                                    ctrl.BackColor = If(isVisible, Color.White, Color.FromArgb(255, 240, 240))
                                End Using
                            End Using
                        End If
                    End If
                Next
            End If

        Catch ex As Exception
            MessageBox.Show("Error selecting FAQ: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Class QuestionItem
        Public Property Text As String
        Public Property Id As Integer
        Public Property Type As String
        Public Property OriginalMessage As String

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class
End Class