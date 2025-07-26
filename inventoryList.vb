Imports MySql.Data.MySqlClient

Public Class inventoryList

    ' 🔌 MySQL Connection String
    Dim conn As New MySqlConnection("server=localhost;user=root;password=;database=final_shafaye_salon")

    Private Sub InventoryListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory("") ' Load all supplies at form load
    End Sub

    ' 🔎 When Search Button is Clicked
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadInventory(txtSearch.Text.Trim())
    End Sub

    ' 📦 Load Inventory Items into FlowLayoutPanel
    Private Sub LoadInventory(searchTerm As String)
        flpInventoryList.Controls.Clear()

        Dim query As String = "SELECT * FROM supplies WHERE supply_name LIKE @search"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")

            Try
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim itemPanel As New Panel With {
                            .Width = 500,
                            .Height = 80,
                            .BackColor = Color.WhiteSmoke,
                            .Margin = New Padding(10),
                            .BorderStyle = BorderStyle.FixedSingle
                        }

                        ' Supply Name
                        Dim lblName As New Label With {
                            .Text = ">> " & reader("supply_name").ToString(),
                            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                            .Location = New Point(10, 10),
                            .AutoSize = True
                        }

                        ' Quantity
                        Dim lblStock As New Label With {
                            .Text = "Stock: " & reader("stock_quantity").ToString(),
                            .Font = New Font("Segoe UI", 10),
                            .Location = New Point(10, 40),
                            .ForeColor = Color.DarkGreen,
                            .AutoSize = True
                        }

                        ' Price
                        Dim lblPrice As New Label With {
                            .Text = "₱" & Format(CDec(reader("price")), "N2"),
                            .Font = New Font("Segoe UI", 10, FontStyle.Regular),
                            .Location = New Point(300, 40),
                            .ForeColor = Color.DarkSlateGray,
                            .AutoSize = True
                        }

                        ' Add controls to panel
                        itemPanel.Controls.Add(lblName)
                        itemPanel.Controls.Add(lblStock)
                        itemPanel.Controls.Add(lblPrice)

                        ' Add panel to FlowLayoutPanel
                        flpInventoryList.Controls.Add(itemPanel)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading inventory: " & ex.Message)
            Finally
                conn.Close()
            End Try
    End Sub

End Class
