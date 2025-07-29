Imports MySql.Data.MySqlClient

'FOR CUSTOMER INQUIRY FORM & FAQ SUGGESTION SYSTEM – Allows logged-in users to send their questions or concerns
'(saved to a message table), and automatically logs each inquiry as a suggested FAQ entry for future staff review.
Public Class CustomerSupport
    Private userID As Integer
    Dim conn As New MySqlConnection("Server=localhost;Database=final_shafaye_salon;Uid=salon_customer;Pwd=CustomerSalon2025!;")

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

            Dim query As String = "
            INSERT INTO contact_messages (user_id, subject, message) 
            VALUES (@userID, @subject, @message)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@userID", userID)
            cmd.Parameters.AddWithValue("@subject", subjectText.Text.Trim())
            cmd.Parameters.AddWithValue("@message", messagetxtbox.Text.Trim())
            cmd.ExecuteNonQuery()

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