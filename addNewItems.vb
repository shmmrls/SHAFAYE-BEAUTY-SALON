Imports MySql.Data.MySqlClient
Public Class addNewItems
    Dim conn As New MySqlConnection("server=localhost;user=root;password=;database=final_shafaye_salon")

    Private Sub StockManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemsToComboBox()
        LoadStockSummary()
    End Sub

    ' 🟢 ADD NEW ITEM
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If txtName.Text = "" Or txtCategory.Text = "" Or txtQuantity.Text = "" Or txtFreq.Text = "" Then
            MessageBox.Show("Please complete all fields.")
            Exit Sub
        End If

        Dim cmd As New MySqlCommand("INSERT INTO supplies (item_name, category, quantity) VALUES (@name, @cat, @qty)", conn)
        cmd.Parameters.AddWithValue("@name", txtName.Text)
        cmd.Parameters.AddWithValue("@cat", txtCategory.Text)
        cmd.Parameters.AddWithValue("@qty", Val(txtQuantity.Text))

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Item added successfully!")
        ClearInputs()
        LoadItemsToComboBox()
        LoadStockSummary()
    End Sub

    ' 🔄 UPDATE STOCK
    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        If cbxItemSelect.Text = "" Or txtAddStock.Text = "" Then
            MessageBox.Show("Please select item and input stock to add.")
            Exit Sub
        End If

        Dim cmd As New MySqlCommand("UPDATE supplies SET quantity = quantity + @addQty WHERE item_name = @name", conn)
        cmd.Parameters.AddWithValue("@addQty", Val(txtAddStock.Text))
        cmd.Parameters.AddWithValue("@name", cbxItemSelect.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Stock updated!")
        txtAddStock.Clear()
        LoadStockSummary()
        ShowCurrentStock()
    End Sub

    ' 🔃 COMBOBOX LIST
    Private Sub LoadItemsToComboBox()
        cbxItemSelect.Items.Clear()

        Dim cmd As New MySqlCommand("SELECT item_name FROM supplies", conn)
        conn.Open()
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            cbxItemSelect.Items.Add(reader("item_name").ToString())
        End While
        conn.Close()
    End Sub

    ' 📊 SHOW CURRENT QTY ON SELECTION
    Private Sub cbxItemSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxItemSelect.SelectedIndexChanged
        ShowCurrentStock()
    End Sub

    Private Sub ShowCurrentStock()
        Dim cmd As New MySqlCommand("SELECT quantity FROM supplies WHERE item_name = @name", conn)
        cmd.Parameters.AddWithValue("@name", cbxItemSelect.Text)

        conn.Open()
        Dim qty = cmd.ExecuteScalar()
        conn.Close()

        lblCurrentQty.Text = "Current Stock: " & qty.ToString()
    End Sub

    ' 📋 LOAD LISTVIEW SUMMARY
    Private Sub LoadStockSummary()
        lvStockSummary.Items.Clear()
        Dim cmd As New MySqlCommand("SELECT item_name, category, quantity, usage_frequency FROM supplies", conn)
        conn.Open()
        Dim reader = cmd.ExecuteReader()

        While reader.Read()
            Dim item As New ListViewItem(reader("item_name").ToString())
            item.SubItems.Add(reader("category").ToString())
            item.SubItems.Add(reader("quantity").ToString())
            item.SubItems.Add(reader("usage_frequency").ToString())
            lvStockSummary.Items.Add(item)
        End While

        conn.Close()
    End Sub

    ' 🔄 RESET INPUT
    Private Sub ClearInputs()
        txtName.Clear()
        txtCategory.Clear()
        txtQuantity.Clear()
        txtFreq.Clear()
    End Sub
End Class
