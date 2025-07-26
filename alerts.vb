Imports System.Data.SqlClient

Public Class alerts

    Dim connectionString As String = "server=localhost;user=root;password=;database=final_shafaye_salon"

    Private Sub frmAlerts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLowInventory()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadLowInventory(txtSearch.Text.Trim())
    End Sub

    Private Sub LoadLowInventory(Optional searchFilter As String = "")
        flwAlerts.Controls.Clear()

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "
                SELECT item_name, quantity, reorder_point 
                FROM inventory 
                WHERE quantity <= reorder_point"

            If searchFilter <> "" Then
                query &= " AND item_name LIKE @filter"
            End If

            Using cmd As New MySqlCommand(query, conn)
                If searchFilter <> "" Then
                    cmd.Parameters.AddWithValue("@filter", "%" & searchFilter & "%")
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim name As String = reader("item_name").ToString()
                        Dim qty As Integer = Convert.ToInt32(reader("quantity"))
                        Dim reorderPoint As Integer = Convert.ToInt32(reader("reorder_point"))

                        Dim alertText As String
                        If qty = 0 Then
                            alertText = $" !! {name} – Out of stock"
                        Else
                            alertText = $" !! {name} – Only {qty} left"
                        End If

                        ' Create the alert panel
                        Dim alertPanel As New Panel With {
                            .Height = 40,
                            .Width = flwAlerts.Width - 30,
                            .BackColor = Color.FromArgb(255, 230, 230),
                            .Padding = New Padding(10),
                            .Margin = New Padding(5)
                        }

                        Dim lbl As New Label With {
                            .Text = alertText,
                            .ForeColor = Color.DarkRed,
                            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                            .AutoSize = True
                        }

                        alertPanel.Controls.Add(lbl)
                        flwAlerts.Controls.Add(alertPanel)
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class
