Imports MySql.Data.MySqlClient
Imports System.IO

'FOR SERVICE LISTING
'Description: Admin can create, add, update, And delete products.
Public Class editDeleteService
    Dim conn As New MySqlConnection("Server=localhost;Database=final_shafaye_salon;Uid=salon_admin;Pwd=AdminSalon2025!;")

    Private selectedServiceID As String = ""
    Private selectedRowPanel As Panel = Nothing

    Private Sub editDeleteService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSortBy.Items.AddRange(New String() {"Price - Low to High", "Price - High to Low", "Default - Alphabetical"})
        cmbSortBy.SelectedIndex = 0
        LoadCategories()
        cmbCategoryFilter.Text = "All Categories"
        LoadServicesFiltered()
    End Sub

    Private Sub LoadCategories()
        cmbCategoryFilter.Items.Clear()
        cmbCategoryFilter.Items.Add("All Categories")

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT name FROM service_categories", conn)
            Dim reader = cmd.ExecuteReader()
            While reader.Read()
                cmbCategoryFilter.Items.Add(reader("name").ToString())
            End While
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadServicesFiltered()
        flowServices.Controls.Clear()
        Try
            conn.Open()
            Dim query As String =
                "SELECT s.service_id, s.name AS service_name, s.description, s.price, s.is_available, sc.name AS category_name, s.image_name " &
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

            Dim reader = cmd.ExecuteReader()
            Dim currentCategory As String = ""

            While reader.Read()
                Dim serviceID = reader("service_id").ToString()
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
                    .Padding = New Padding(5),
                    .Tag = serviceID
                }

                Dim serviceImage As Image = Nothing
                Dim possibleExtensions = {".png", ".jpg", ".jpeg", ".bmp"}

                For Each ext In possibleExtensions
                    Dim imagePath As String = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\Resources", imageName & ext))
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

                AddHandler rowPanel.Click, Sub(sender2, e2)
                                               If selectedRowPanel IsNot Nothing Then
                                                   selectedRowPanel.BackColor = Color.Transparent
                                               End If
                                               selectedRowPanel = DirectCast(sender2, Panel)
                                               selectedRowPanel.BackColor = Color.LightGray
                                               selectedServiceID = selectedRowPanel.Tag.ToString()
                                           End Sub
            End While

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading services: " & ex.Message)
        End Try
    End Sub

    Private Sub removeservicebtn_Click(sender As Object, e As EventArgs) Handles removeservicebtn.Click
        If selectedServiceID = "" Then
            MessageBox.Show("Please select a service to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm = MessageBox.Show("Are you sure you want to delete this service?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Try
                conn.Open()
                Dim sql = "DELETE FROM services WHERE service_id = @id"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", selectedServiceID)
                cmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("Service deleted successfully.")
                LoadServicesFiltered()

                selectedServiceID = ""
                selectedRowPanel = Nothing

            Catch ex As Exception
                MessageBox.Show("Error deleting service: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub LoadCategoriesForCombo()
        Try
            categorycbobox.DataSource = Nothing
            Dim sql = "SELECT category_id, name FROM service_categories"
            Dim cmd As New MySqlCommand(sql, conn)
            conn.Open()
            Dim reader = cmd.ExecuteReader()

            Dim categoryTable As New DataTable()
            categoryTable.Load(reader)

            categorycbobox.DisplayMember = "name"
            categorycbobox.ValueMember = "category_id"
            categorycbobox.DataSource = categoryTable

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to load categories: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadServicesFiltered()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSearch_Click(Me, New EventArgs())
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadServicesFiltered()
    End Sub

    Private Sub cmbCategoryFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoryFilter.SelectedIndexChanged
        LoadServicesFiltered()
    End Sub

    Private Sub cmbSortBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSortBy.SelectedIndexChanged
        LoadServicesFiltered()
    End Sub

    Private Sub chkAvailableOnly_CheckedChanged(sender As Object, e As EventArgs) Handles chkAvailableOnly.CheckedChanged
        LoadServicesFiltered()
    End Sub


    Private Sub editservicebtn_Click(sender As Object, e As EventArgs) Handles editservicebtn.Click
        If selectedServiceID = "" Then
            MessageBox.Show("Please select a service to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        LoadCategoriesForCombo()
        panelforedit.Visible = True

        Try
            conn.Open()
            Dim sql = "SELECT name, description, price, is_available, category_id FROM services WHERE service_id = @id"

            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", selectedServiceID)

            Dim reader = cmd.ExecuteReader()
            If reader.Read() Then
                nmetxt.Text = reader("name").ToString()
                pricetxt.Text = Convert.ToDecimal(reader("price")).ToString("F2")
                descriptiontxt.Text = reader("description").ToString()


                categorycbobox.SelectedValue = Convert.ToInt32(reader("category_id"))


                If Convert.ToBoolean(reader("is_available")) Then
                    availableRadBtn.Checked = True
                Else
                    notAvailableRadbtn.Checked = True
                End If
            End If
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading service details: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateService_Click(sender As Object, e As EventArgs) Handles saveditbtn.Click
        If selectedServiceID = "" Then
            MessageBox.Show("No service selected.")
            Return
        End If

        Try
            conn.Open()
            Dim updateSQL = "UPDATE services SET name = @name, description = @desc, price = @price, is_available = @avail WHERE service_id = @id"
            Dim cmd As New MySqlCommand(updateSQL, conn)
            cmd.Parameters.AddWithValue("@name", nmetxt.Text.Trim())
            cmd.Parameters.AddWithValue("@desc", descriptiontxt.Text.Trim())
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(pricetxt.Text))
            cmd.Parameters.AddWithValue("@avail", availableRadBtn.Checked)
            cmd.Parameters.AddWithValue("@id", selectedServiceID)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Service updated successfully.")
            panelforedit.Visible = False
            LoadServicesFiltered()

        Catch ex As Exception
            MessageBox.Show("Error updating service: " & ex.Message)
        End Try
    End Sub

    Private Sub canceleditbtn_Click(sender As Object, e As EventArgs) Handles canceleditbtn.Click
        panelforedit.Visible = False
    End Sub

    Private Sub saveEditbtn_MouseEnter(sender As Object, e As EventArgs) Handles saveditbtn.MouseEnter
        saveditbtn.BackgroundImage = My.Resources.saveEdit2
        saveditbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub saveEditbtn_MouseLeave(sender As Object, e As EventArgs) Handles saveditbtn.MouseLeave
        saveditbtn.BackgroundImage = My.Resources.saveEdit
        saveditbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub cancelEditbtn_MouseEnter(sender As Object, e As EventArgs) Handles canceleditbtn.MouseEnter
        canceleditbtn.BackgroundImage = My.Resources.cancelEdit2
        canceleditbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub cancelEditbtn_MouseLeave(sender As Object, e As EventArgs) Handles canceleditbtn.MouseLeave
        canceleditbtn.BackgroundImage = My.Resources.cancelEdit
        canceleditbtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub editservicebtn_MouseEnter(sender As Object, e As EventArgs) Handles editservicebtn.MouseEnter
        editservicebtn.BackgroundImage = My.Resources.editservice2
        editservicebtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub editservicebtn_MouseLeave(sender As Object, e As EventArgs) Handles editservicebtn.MouseLeave
        editservicebtn.BackgroundImage = My.Resources.editservice
        editservicebtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub removeservicebtn_MouseEnter(sender As Object, e As EventArgs) Handles removeservicebtn.MouseEnter
        removeservicebtn.BackgroundImage = My.Resources.removeservice2
        removeservicebtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub removeservicebtn_MouseLeave(sender As Object, e As EventArgs) Handles removeservicebtn.MouseLeave
        removeservicebtn.BackgroundImage = My.Resources.removeservice
        removeservicebtn.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub backtoaddtxt_Click(sender As Object, e As EventArgs) Handles backtoaddtxt.Click
        adminMenu.OpenChildForm(New addservices())
    End Sub
End Class
