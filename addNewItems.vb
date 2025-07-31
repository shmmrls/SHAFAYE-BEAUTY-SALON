Imports System.w
Imports MySql.Data.MySqlClient

'FOR INVENTORY MANAGEMENT
' Create inventory records and track internal-use supplies (e.g., wax, shampoo, facial cream) including stock levels
' and usage frequency.
Public Class addNewItems
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=salon_admin;Pwd=AdminSalon2025!;"

    Private Sub addNewItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServices()
        LoadInventoryItems()
        SetupForm()
    End Sub

    Private Sub SetupForm()
        numUpDownQuantity.Minimum = 0
        numUpDownQuantity.Maximum = 999999
        numUpDownQuantity.Value = 0

        numUpDownReorderLvl.Minimum = 0
        numUpDownReorderLvl.Maximum = 999999
        numUpDownReorderLvl.Value = 0

        numUpDownQuantityUsed.Minimum = 1
        numUpDownQuantityUsed.Maximum = 999999
        numUpDownQuantityUsed.Value = 1

        numUpDownAddStock.Minimum = 0
        numUpDownAddStock.Maximum = 999999
        numUpDownAddStock.Value = 0

        lblCurrentStock.Text = "Current Stock: 0"
    End Sub

    Private Sub LoadServices()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT service_id, name FROM services WHERE is_available = 1 ORDER BY name"
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim servicesTable As New DataTable()
                        servicesTable.Load(reader)

                        cmbService.DataSource = servicesTable
                        cmbService.DisplayMember = "name"
                        cmbService.ValueMember = "service_id"
                        cmbService.SelectedIndex = -1
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading services: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadInventoryItems()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT item_id, item_name, quantity FROM inventory ORDER BY item_name"
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim inventoryTable As New DataTable()
                        inventoryTable.Load(reader)

                        cbxItemSelect.DataSource = inventoryTable
                        cbxItemSelect.DisplayMember = "item_name"
                        cbxItemSelect.ValueMember = "item_id"
                        cbxItemSelect.SelectedIndex = -1
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading inventory items: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter an item name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtUnit.Text) Then
            MessageBox.Show("Please enter a unit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUnit.Focus()
            Return
        End If

        If cmbService.SelectedIndex = -1 Then
            MessageBox.Show("Please select a service.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbService.Focus()
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using transaction As MySqlTransaction = connection.BeginTransaction()
                    Try
                        Dim checkQuery As String = "SELECT COUNT(*) FROM inventory WHERE item_name = @itemName"
                        Using checkCommand As New MySqlCommand(checkQuery, connection, transaction)
                            checkCommand.Parameters.AddWithValue("@itemName", txtName.Text.Trim())
                            Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                            If count > 0 Then
                                MessageBox.Show("An item with this name already exists in inventory.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If
                        End Using

                        Dim insertInventoryQuery As String = "INSERT INTO inventory (item_name, quantity, unit, reorder_level) VALUES (@itemName, @quantity, @unit, @reorderLevel)"
                        Dim newItemId As Integer

                        Using insertCommand As New MySqlCommand(insertInventoryQuery, connection, transaction)
                            insertCommand.Parameters.AddWithValue("@itemName", txtName.Text.Trim())
                            insertCommand.Parameters.AddWithValue("@quantity", numUpDownQuantity.Value)
                            insertCommand.Parameters.AddWithValue("@unit", txtUnit.Text.Trim())
                            insertCommand.Parameters.AddWithValue("@reorderLevel", numUpDownReorderLvl.Value)
                            insertCommand.ExecuteNonQuery()

                            newItemId = Convert.ToInt32(insertCommand.LastInsertedId)
                        End Using

                        Dim insertUsageQuery As String = "INSERT INTO inventory_usage (service_id, item_id, quantity_used) VALUES (@serviceId, @itemId, @quantityUsed)"
                        Using usageCommand As New MySqlCommand(insertUsageQuery, connection, transaction)
                            usageCommand.Parameters.AddWithValue("@serviceId", cmbService.SelectedValue)
                            usageCommand.Parameters.AddWithValue("@itemId", newItemId)
                            usageCommand.Parameters.AddWithValue("@quantityUsed", numUpDownQuantityUsed.Value)
                            usageCommand.ExecuteNonQuery()
                        End Using

                        transaction.Commit()
                        MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ClearAddItemForm()
                        LoadInventoryItems()

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw ex
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding item: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        If cbxItemSelect.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbxItemSelect.Focus()
            Return
        End If

        If numUpDownAddStock.Value <= 0 Then
            MessageBox.Show("Please enter a valid quantity to add.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numUpDownAddStock.Focus()
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim getCurrentQuery As String = "SELECT quantity FROM inventory WHERE item_id = @itemId"
                Dim currentQuantity As Integer = 0

                Using getCurrentCommand As New MySqlCommand(getCurrentQuery, connection)
                    getCurrentCommand.Parameters.AddWithValue("@itemId", cbxItemSelect.SelectedValue)
                    Dim result = getCurrentCommand.ExecuteScalar()
                    If result IsNot Nothing Then
                        currentQuantity = Convert.ToInt32(result)
                    End If
                End Using

                Dim newQuantity As Integer = currentQuantity + numUpDownAddStock.Value
                Dim updateQuery As String = "UPDATE inventory SET quantity = @newQuantity WHERE item_id = @itemId"

                Using updateCommand As New MySqlCommand(updateQuery, connection)
                    updateCommand.Parameters.AddWithValue("@newQuantity", newQuantity)
                    updateCommand.Parameters.AddWithValue("@itemId", cbxItemSelect.SelectedValue)
                    updateCommand.ExecuteNonQuery()
                End Using

                MessageBox.Show($"Stock updated successfully! New quantity: {newQuantity}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadInventoryItems()
                numUpDownAddStock.Value = 0
                UpdateCurrentStockLabel()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating stock: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbxItemSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxItemSelect.SelectedIndexChanged
        UpdateCurrentStockLabel()
    End Sub

    Private Sub UpdateCurrentStockLabel()
        If cbxItemSelect.SelectedIndex <> -1 Then
            Try
                Dim selectedRow As DataRowView = DirectCast(cbxItemSelect.SelectedItem, DataRowView)
                Dim quantity As Integer = Convert.ToInt32(selectedRow("quantity"))
                lblCurrentStock.Text = $"Current Stock: {quantity}"
            Catch ex As Exception
                lblCurrentStock.Text = "Current Stock: 0"
            End Try
        Else
            lblCurrentStock.Text = "Current Stock: 0"
        End If
    End Sub

    Private Sub btnUpdatedInventory_Click(sender As Object, e As EventArgs) Handles btnUpdatedInventory.Click
        Try
            adminMenu.OpenChildForm(New inventoryList())
        Catch ex As Exception
            MessageBox.Show("Error opening inventory list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearAddItemForm()
        txtName.Clear()
        txtUnit.Clear()
        cmbService.SelectedIndex = -1
        numUpDownQuantity.Value = 0
        numUpDownReorderLvl.Value = 0
        numUpDownQuantityUsed.Value = 1
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not (Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar = " "c OrElse e.KeyChar = "-"c OrElse e.KeyChar = "/"c OrElse e.KeyChar = "("c OrElse e.KeyChar = ")"c OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnit.KeyPress
        If Not (Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar = " "c OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class