Imports System.Data
Imports MySql.Data.MySqlClient

Public Class inventoryList
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=root;Pwd=;"

    Private Sub inventoryList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventoryByServices()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Real-time search as user types
        If txtSearch.Text.Trim().Length >= 1 Then
            SearchInventory(txtSearch.Text.Trim())
        Else
            LoadInventoryByServices() ' Show all when search is empty
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Official search button functionality
        If txtSearch.Text.Trim().Length > 0 Then
            SearchInventory(txtSearch.Text.Trim())
        Else
            LoadInventoryByServices()
        End If
    End Sub

    Private Sub LoadInventoryByServices()
        Try
            flpInventoryList.Controls.Clear()
            flpInventoryList.AutoScroll = True
            flpInventoryList.FlowDirection = FlowDirection.TopDown
            flpInventoryList.WrapContents = False

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' First, get all services that have inventory items assigned
                Dim servicesQuery As String = "
                    SELECT DISTINCT 
                        s.service_id,
                        s.name as service_name,
                        s.description,
                        s.price,
                        sc.name as category_name
                    FROM services s
                    INNER JOIN service_categories sc ON s.category_id = sc.category_id
                    INNER JOIN inventory_usage iu ON s.service_id = iu.service_id
                    INNER JOIN inventory i ON iu.item_id = i.item_id
                    WHERE s.is_available = 1
                    ORDER BY sc.name, s.name"

                Using servicesCommand As New MySqlCommand(servicesQuery, connection)
                    Using servicesReader As MySqlDataReader = servicesCommand.ExecuteReader()
                        Dim servicesData As New List(Of Object)

                        While servicesReader.Read()
                            servicesData.Add(New With {
                                .ServiceId = servicesReader("service_id").ToString(),
                                .ServiceName = servicesReader("service_name").ToString(),
                                .Description = If(IsDBNull(servicesReader("description")), "", servicesReader("description").ToString()),
                                .Price = Convert.ToDecimal(servicesReader("price")),
                                .CategoryName = servicesReader("category_name").ToString()
                            })
                        End While

                        servicesReader.Close()

                        If servicesData.Count = 0 Then
                            ' Show message if no inventory items found
                            Dim noInventoryLabel As New Label()
                            noInventoryLabel.Text = "No inventory items found in the system." & vbNewLine & vbNewLine & "Items need to be added to the inventory table and linked to services through inventory_usage table."
                            noInventoryLabel.ForeColor = Color.Gray
                            noInventoryLabel.Font = New Font("Segoe UI", 11, FontStyle.Italic)
                            noInventoryLabel.AutoSize = True
                            noInventoryLabel.Margin = New Padding(20)
                            flpInventoryList.Controls.Add(noInventoryLabel)
                            Return
                        End If

                        ' For each service, create a service header and list its inventory items
                        For Each serviceData In servicesData
                            ' Create service header panel
                            Dim servicePanel As Panel = CreateServiceHeaderPanel(serviceData)
                            flpInventoryList.Controls.Add(servicePanel)

                            ' Get inventory items for this service
                            Dim inventoryQuery As String = "
                                SELECT 
                                    i.item_id,
                                    i.item_name,
                                    i.quantity,
                                    i.unit,
                                    i.reorder_level,
                                    iu.quantity_used
                                FROM inventory i
                                INNER JOIN inventory_usage iu ON i.item_id = iu.item_id
                                WHERE iu.service_id = @serviceId
                                ORDER BY i.item_name"

                            Using inventoryCommand As New MySqlCommand(inventoryQuery, connection)
                                inventoryCommand.Parameters.AddWithValue("@serviceId", serviceData.ServiceId)

                                Using inventoryReader As MySqlDataReader = inventoryCommand.ExecuteReader()
                                    While inventoryReader.Read()
                                        Dim itemPanel As Panel = CreateInventoryItemPanel(
                                            inventoryReader("item_id").ToString(),
                                            inventoryReader("item_name").ToString(),
                                            Convert.ToInt32(inventoryReader("quantity")),
                                            If(IsDBNull(inventoryReader("unit")), "pcs", inventoryReader("unit").ToString()),
                                            If(IsDBNull(inventoryReader("reorder_level")), 0, Convert.ToInt32(inventoryReader("reorder_level"))),
                                            Convert.ToInt32(inventoryReader("quantity_used"))
                                        )
                                        flpInventoryList.Controls.Add(itemPanel)
                                    End While
                                    inventoryReader.Close()
                                End Using
                            End Using

                            ' Add spacing between services
                            Dim spacer As New Panel()
                            spacer.Size = New Size(flpInventoryList.Width - 50, 10)
                            spacer.BackColor = Color.Transparent
                            flpInventoryList.Controls.Add(spacer)
                        Next
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error loading inventory data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchInventory(searchTerm As String)
        Try
            flpInventoryList.Controls.Clear()
            flpInventoryList.AutoScroll = True
            flpInventoryList.FlowDirection = FlowDirection.TopDown
            flpInventoryList.WrapContents = False

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Search query for items and services
                Dim searchQuery As String = "
                    SELECT DISTINCT 
                        s.service_id,
                        s.name as service_name,
                        s.description,
                        s.price,
                        sc.name as category_name,
                        i.item_id,
                        i.item_name,
                        i.quantity,
                        i.unit,
                        i.reorder_level,
                        iu.quantity_used
                    FROM services s
                    INNER JOIN service_categories sc ON s.category_id = sc.category_id
                    INNER JOIN inventory_usage iu ON s.service_id = iu.service_id
                    INNER JOIN inventory i ON iu.item_id = i.item_id
                    WHERE s.is_available = 1 
                    AND (i.item_name LIKE @searchTerm 
                         OR s.name LIKE @searchTerm 
                         OR sc.name LIKE @searchTerm
                         OR i.unit LIKE @searchTerm)
                    ORDER BY s.name, i.item_name"

                Using command As New MySqlCommand(searchQuery, connection)
                    command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%")

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim currentServiceId As String = ""
                        Dim foundResults As Boolean = False

                        While reader.Read()
                            foundResults = True
                            Dim serviceId As String = reader("service_id").ToString()

                            ' Create service header if this is a new service
                            If serviceId <> currentServiceId Then
                                currentServiceId = serviceId

                                Dim serviceData = New With {
                                    .ServiceId = serviceId,
                                    .ServiceName = reader("service_name").ToString(),
                                    .Description = If(IsDBNull(reader("description")), "", reader("description").ToString()),
                                    .Price = Convert.ToDecimal(reader("price")),
                                    .CategoryName = reader("category_name").ToString()
                                }

                                Dim servicePanel As Panel = CreateServiceHeaderPanel(serviceData)
                                flpInventoryList.Controls.Add(servicePanel)
                            End If

                            ' Create inventory item panel
                            Dim itemPanel As Panel = CreateInventoryItemPanel(
                                reader("item_id").ToString(),
                                reader("item_name").ToString(),
                                Convert.ToInt32(reader("quantity")),
                                If(IsDBNull(reader("unit")), "pcs", reader("unit").ToString()),
                                If(IsDBNull(reader("reorder_level")), 0, Convert.ToInt32(reader("reorder_level"))),
                                Convert.ToInt32(reader("quantity_used"))
                            )
                            flpInventoryList.Controls.Add(itemPanel)
                        End While

                        If Not foundResults Then
                            Dim noResultsLabel As New Label()
                            noResultsLabel.Text = $"No inventory items found matching '{searchTerm}'"
                            noResultsLabel.ForeColor = Color.Gray
                            noResultsLabel.Font = New Font("Segoe UI", 11, FontStyle.Italic)
                            noResultsLabel.AutoSize = True
                            noResultsLabel.Margin = New Padding(20)
                            flpInventoryList.Controls.Add(noResultsLabel)
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error searching inventory: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CreateServiceHeaderPanel(serviceData As Object) As Panel
        Dim panel As New Panel()
        panel.Size = New Size(flpInventoryList.Width - 50, 80)
        panel.BorderStyle = BorderStyle.None
        panel.BackColor = Color.FromArgb(77, 0, 18) ' Blue header
        panel.Margin = New Padding(5, 10, 5, 5)

        ' Service Name
        Dim lblServiceName As New Label()
        lblServiceName.Text = serviceData.ServiceName.ToUpper()
        lblServiceName.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblServiceName.ForeColor = Color.White
        lblServiceName.Location = New Point(15, 10)
        lblServiceName.Size = New Size(400, 25)
        panel.Controls.Add(lblServiceName)

        ' Service Category
        Dim lblCategory As New Label()
        lblCategory.Text = $"Category: {serviceData.CategoryName}"
        lblCategory.Font = New Font("Segoe UI", 9)
        lblCategory.ForeColor = Color.White
        lblCategory.Location = New Point(15, 35)
        lblCategory.AutoSize = True
        panel.Controls.Add(lblCategory)

        ' Service Price
        Dim lblPrice As New Label()
        lblPrice.Text = $"₱{serviceData.Price:N2}"
        lblPrice.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblPrice.ForeColor = Color.White
        lblPrice.Location = New Point(panel.Width - 120, 10)
        lblPrice.AutoSize = True
        panel.Controls.Add(lblPrice)

        ' Service Description
        If Not String.IsNullOrEmpty(serviceData.Description) Then
            Dim lblDescription As New Label()
            lblDescription.Text = serviceData.Description
            lblDescription.Font = New Font("Segoe UI", 8, FontStyle.Italic)
            lblDescription.ForeColor = Color.LightGray
            lblDescription.Location = New Point(15, 55)
            lblDescription.Size = New Size(panel.Width - 30, 20)
            panel.Controls.Add(lblDescription)
        End If

        Return panel
    End Function

    Private Function CreateInventoryItemPanel(itemId As String, itemName As String, quantity As Integer, unit As String, reorderLevel As Integer, quantityUsed As Integer) As Panel
        Dim panel As New Panel()
        panel.Size = New Size(flpInventoryList.Width - 80, 60)
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.BackColor = Color.White
        panel.Margin = New Padding(25, 2, 5, 2)

        ' Stock status color
        Dim stockColor As Color = Color.Green
        Dim stockStatus As String = "In Stock"

        If quantity <= 0 Then
            stockColor = Color.Red
            stockStatus = "Out of Stock"
            panel.BackColor = Color.FromArgb(255, 245, 245) ' Light red background
        ElseIf reorderLevel > 0 AndAlso quantity <= reorderLevel Then
            stockColor = Color.Orange
            stockStatus = "Low Stock"
            panel.BackColor = Color.FromArgb(255, 248, 220) ' Light yellow background
        End If

        ' Item Name
        Dim lblItemName As New Label()
        lblItemName.Text = itemName
        lblItemName.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblItemName.ForeColor = Color.FromArgb(77, 0, 18)
        lblItemName.Location = New Point(10, 8)
        lblItemName.Size = New Size(200, 20)
        panel.Controls.Add(lblItemName)

        ' Item ID
        Dim lblItemId As New Label()
        lblItemId.Text = $"ID: {itemId}"
        lblItemId.Font = New Font("Segoe UI", 8, FontStyle.Italic)
        lblItemId.ForeColor = Color.Gray
        lblItemId.Location = New Point(10, 28)
        lblItemId.AutoSize = True
        panel.Controls.Add(lblItemId)

        ' Quantity
        Dim lblQuantity As New Label()
        lblQuantity.Text = $"Stock: {quantity} {unit}"
        lblQuantity.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblQuantity.ForeColor = stockColor
        lblQuantity.Location = New Point(220, 8)
        lblQuantity.AutoSize = True
        panel.Controls.Add(lblQuantity)

        ' Stock Status
        Dim lblStockStatus As New Label()
        lblStockStatus.Text = stockStatus
        lblStockStatus.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        lblStockStatus.ForeColor = stockColor
        lblStockStatus.Location = New Point(220, 28)
        lblStockStatus.AutoSize = True
        panel.Controls.Add(lblStockStatus)

        ' Quantity Used per Service
        Dim lblQuantityUsed As New Label()
        lblQuantityUsed.Text = $"Used per service: {quantityUsed} {unit}"
        lblQuantityUsed.Font = New Font("Segoe UI", 8)
        lblQuantityUsed.ForeColor = Color.DarkGreen
        lblQuantityUsed.Location = New Point(350, 8)
        lblQuantityUsed.AutoSize = True
        panel.Controls.Add(lblQuantityUsed)

        ' Reorder Level
        If reorderLevel > 0 Then
            Dim lblReorderLevel As New Label()
            lblReorderLevel.Text = $"Reorder at: {reorderLevel} {unit}"
            lblReorderLevel.Font = New Font("Segoe UI", 8)
            lblReorderLevel.ForeColor = Color.Purple
            lblReorderLevel.Location = New Point(350, 28)
            lblReorderLevel.AutoSize = True
            panel.Controls.Add(lblReorderLevel)
        End If

        ' Available Services (calculated)
        If quantityUsed > 0 Then
            Dim availableServices As Integer = Math.Floor(quantity / quantityUsed)
            Dim lblAvailableServices As New Label()
            lblAvailableServices.Text = $"Services possible: {availableServices}"
            lblAvailableServices.Font = New Font("Segoe UI", 8, FontStyle.Bold)
            lblAvailableServices.ForeColor = If(availableServices > 10, Color.Green, If(availableServices > 5, Color.Orange, Color.Red))
            lblAvailableServices.Location = New Point(580, 8)
            lblAvailableServices.AutoSize = True
            panel.Controls.Add(lblAvailableServices)
        End If

        ' Add hover effect
        AddHandler panel.MouseEnter, Sub(sender, e)
                                         If panel.BackColor = Color.White Then
                                             panel.BackColor = Color.FromArgb(248, 249, 250)
                                         End If
                                     End Sub
        AddHandler panel.MouseLeave, Sub(sender, e)
                                         If panel.BackColor = Color.FromArgb(248, 249, 250) Then
                                             panel.BackColor = Color.White
                                         End If
                                     End Sub

        Return panel
    End Function


End Class