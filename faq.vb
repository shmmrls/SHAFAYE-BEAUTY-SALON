Imports MySql.Data.MySqlClient

Public Class faq
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=final_shafaye_salon")

    Private Sub faq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFAQsFromDatabase()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadFAQsFromDatabase(txtSearch.Text)
    End Sub

    Private Sub LoadFAQsFromDatabase(Optional ByVal searchTerm As String = "")
        flowFAQ.Controls.Clear()

        Try
            conn.Open()
            Dim query As String = "
            SELECT question, IFNULL(answer,'') AS answer
            FROM faq
            WHERE is_visible = 1
              AND (question LIKE @search OR answer LIKE @search)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim question As String = reader("question").ToString()
                Dim answer As String = reader("answer").ToString()

                Dim panel As New Panel With {
                    .BackColor = Color.WhiteSmoke,
                    .Padding = New Padding(15),
                    .Margin = New Padding(10),
                    .Width = flowFAQ.Width - 35,
                    .Height = 80,
                    .BorderStyle = BorderStyle.FixedSingle,
                    .Tag = False ' Collapsed by default
                }

                Dim lblQ As New Label With {
                .Text = "Q: " & question,
                .Font = New Font("Segoe UI Semibold", 10, FontStyle.Bold),
                .ForeColor = Color.Black,
                .AutoSize = False,
                .Dock = DockStyle.Top,
                .Height = 25,
                .Cursor = Cursors.Hand
            }


                Dim lblA As New Label With {
                    .Text = "A: " & answer,
                    .Font = New Font("Segoe UI", 10),
                    .ForeColor = Color.DimGray,
                    .Dock = DockStyle.Top,
                    .Visible = False,
                    .MaximumSize = New Size(panel.Width - 30, 0),
                    .AutoSize = True
                }

                AddHandler lblQ.MouseEnter, Sub()
                                                lblQ.ForeColor = Color.RoyalBlue ' Change color when hovered
                                            End Sub

                AddHandler lblQ.MouseLeave, Sub()
                                                lblQ.ForeColor = Color.Black ' Return to default
                                            End Sub

                AddHandler lblQ.Click, Sub()
                                           lblA.Visible = Not lblA.Visible
                                           panel.Tag = lblA.Visible
                                           panel.Height = If(lblA.Visible, lblQ.Height + lblA.Height + 20, 80)
                                       End Sub

                panel.Controls.Add(lblA)
                panel.Controls.Add(lblQ)
                flowFAQ.Controls.Add(panel)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to load FAQs: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
