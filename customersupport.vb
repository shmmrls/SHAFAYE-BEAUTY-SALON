Imports MySql.Data.MySqlClient

Public Class CustomerSupport
    Private userID As Integer
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=final_shafaye_salon")

    Public Sub New(ByVal userID As Integer)
        InitializeComponent()
        Me.userID = userID
    End Sub

    Private Sub CustomerSupport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserDetails()
    End Sub

    Private Sub LoadUserDetails()
        Try
            conn.Open()
            Dim query As String = "SELECT first_name, last_name FROM user_register WHERE user_id = @userID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@userID", userID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                fntext.Text = reader("first_name").ToString()
                lntext.Text = reader("last_name").ToString()


                fntext.ReadOnly = True
                lntext.ReadOnly = True


                fntext.BackColor = Color.White
                lntext.BackColor = Color.White
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        If String.IsNullOrWhiteSpace(subjectText.Text) OrElse String.IsNullOrWhiteSpace(messagetxtbox.Text) Then
            MessageBox.Show("Please fill in both subject and message.")
            Return
        End If

        Try
            conn.Open()

            ' Insert into contact_messages table
            Dim query As String = "
            INSERT INTO contact_messages (user_id, subject, message) 
            VALUES (@userID, @subject, @message)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@userID", userID)
            cmd.Parameters.AddWithValue("@subject", subjectText.Text.Trim())
            cmd.Parameters.AddWithValue("@message", messagetxtbox.Text.Trim())
            cmd.ExecuteNonQuery()

            ' Insert into faq table with question = message, answer = NULL, is_invisible = 0
            Dim faqQuery As String = "
            INSERT INTO faq (question, answer, is_invisible) 
            VALUES (@question, NULL, 0)"
            Dim faqCmd As New MySqlCommand(faqQuery, conn)
            faqCmd.Parameters.AddWithValue("@question", messagetxtbox.Text.Trim())
            faqCmd.ExecuteNonQuery()

            MessageBox.Show("Message sent successfully.")
            subjectText.Clear()
            messagetxtbox.Clear()

        Catch ex As Exception
            MessageBox.Show("Failed to send message: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class