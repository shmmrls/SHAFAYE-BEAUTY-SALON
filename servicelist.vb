Imports MySql.Data.MySqlClient
Imports System.IO

'FOR SEARCH SERVICES
'Allow search access to services for clients by name or by category.
Public Class servicelist
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=final_shafaye_salon;User=root;Password=;")
    Public sql As String
    Public dbcomm As MySqlCommand

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSearch_Click(Me, New EventArgs())
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadServicesFiltered()
    End Sub


    Private Sub LoadServicesFiltered()
        flowServices.Controls.Clear()

        Try
            conn.Open()

            Dim query As String =
        "SELECT s.name AS service_name, s.description, s.price, s.is_available, sc.name AS category_name, s.image_name " &
        "FROM services s " &
        "JOIN service_categories sc ON s.category_id = sc.category_id " &
        "WHERE (@cat = 'All Categories' OR LOWER(sc.name) = LOWER(@cat)) " &
        "AND (s.name LIKE @search OR s.description LIKE @search) "

            If chkAvailableOnly.Checked Then
                query &= "AND s.is_available = TRUE "
            End If

            Select Case cmbSortBy.Text
                Case "Price - Low to High"
                    query &= "ORDER BY sc.name, s.price ASC"
                Case "Price - High to Low"
                    query &= "ORDER BY sc.name, s.price DESC"
                Case Else
                    query &= "ORDER BY sc.name, s.name"
            End Select

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@cat", cmbCategoryFilter.Text)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim currentCategory As String = ""

            While reader.Read()
                Dim categoryName = reader("category_name").ToString()
                Dim serviceName = reader("service_name").ToString()
                Dim description = reader("description").ToString()
                Dim price = "₱" & Convert.ToDecimal(reader("price")).ToString("N2")
                Dim isAvailable = Convert.ToBoolean(reader("is_available"))
                Dim imageName = reader("image_name").ToString()

                If categoryName <> currentCategory Then
                    currentCategory = categoryName

                    Dim categoryLabel As New Label With {
                    .Text = categoryName & " Services",
                    .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                    .ForeColor = Color.FromArgb(77, 0, 18),
                    .AutoSize = True,
                    .Margin = New Padding(10, 20, 10, 5)
                }
                    flowServices.Controls.Add(categoryLabel)
                End If

                Dim rowPanel As New Panel With {
                .Height = 60,
                .Width = flowServices.Width - 40,
                .BackColor = Color.Transparent,
                .Margin = New Padding(5),
                .Padding = New Padding(5)
            }

                Dim serviceImage As Image = Nothing
                Dim possibleExtensions = {".png", ".jpg", ".jpeg", ".bmp"}

                For Each ext In possibleExtensions
                    Dim imagePath As String = Path.Combine(Application.StartupPath, "Resources", imageName & ext)
                    If File.Exists(imagePath) Then
                        serviceImage = Image.FromFile(imagePath)
                        Exit For
                    End If
                Next

                If serviceImage Is Nothing Then
                    serviceImage = My.Resources.logo_shafaye '
                End If


                Dim picService As New PictureBox With {
                .Image = serviceImage,
                .SizeMode = PictureBoxSizeMode.Zoom,
                .Location = New Point(5, 10),
                .Size = New Size(40, 40)
            }
                rowPanel.Controls.Add(picService)

                Dim lblName As New Label With {
                .Text = serviceName,
                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                .AutoSize = True,
                .Location = New Point(60, 10)
            }
                rowPanel.Controls.Add(lblName)

                Dim lblPrice As New Label With {
                .Text = price,
                .Font = New Font("Segoe UI", 10),
                .ForeColor = Color.FromArgb(77, 0, 18),
                .AutoSize = True,
                .Location = New Point(60, 30)
            }
                rowPanel.Controls.Add(lblPrice)

                Dim lblAvail As New Label With {
                .Text = If(isAvailable, "Available", "Not Available"),
                .ForeColor = If(isAvailable, Color.ForestGreen, Color.DarkRed),
                .Font = New Font("Segoe UI", 9, FontStyle.Italic),
                .AutoSize = True
            }
                lblAvail.Left = rowPanel.Width - lblAvail.PreferredWidth - 20
                lblAvail.Top = (rowPanel.Height - lblAvail.Height) \ 2
                rowPanel.Controls.Add(lblAvail)

                flowServices.Controls.Add(rowPanel)
            End While

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading services: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadCategories()
        cmbCategoryFilter.Items.Clear()
        cmbCategoryFilter.Items.Add("All Categories")

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT name FROM service_categories", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbCategoryFilter.Items.Add(reader("name").ToString())
            End While
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        End Try
    End Sub

    Private Sub services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSortBy.Items.Clear()
        cmbSortBy.Items.Add("Price - Low to High")
        cmbSortBy.Items.Add("Price - High to Low")
        cmbSortBy.Items.Add("Default - Alphabetical")

        If cmbSortBy.Items.Count > 0 Then
            cmbSortBy.SelectedIndex = 0
        End If

        LoadCategories()
        cmbCategoryFilter.Text = "All Categories"

        LoadServicesFiltered()

    End Sub






    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadServicesFiltered()
    End Sub

    Private Sub cmbCategoryFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoryFilter.SelectedIndexChanged
        LoadServicesFiltered()
    End Sub

    Private Sub chkAvailableOnly_CheckedChanged(sender As Object, e As EventArgs) Handles chkAvailableOnly.CheckedChanged
        LoadServicesFiltered()
    End Sub

    Private Sub cmbSortBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSortBy.SelectedIndexChanged
        LoadServicesFiltered()
    End Sub

End Class