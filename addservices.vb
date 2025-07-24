Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ComboBoxItem
    Public Property Text As String
    Public Property Value As Integer

    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class
Public Class addservices

    Dim conn As New MySqlConnection("server=localhost;user=root;password=;database=final_shafaye_salon;")

    Private Sub addServiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Private Sub LoadCategories()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM service_categories", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            categoryComboBox.Items.Clear()
            While reader.Read()
                categoryComboBox.Items.Add(New ComboBoxItem With {
        .Text = reader("name").ToString(),
        .Value = Convert.ToInt32(reader("category_id"))
    })
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBoxImage.Image = Image.FromFile(OpenFileDialog1.FileName)
            Dim filenameOnly As String = Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
            txtImageName.Text = filenameOnly
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate all required fields
        If String.IsNullOrWhiteSpace(txtServiceName.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrice.Text) OrElse
           categoryComboBox.SelectedItem Is Nothing OrElse
           PictureBoxImage.Image Is Nothing OrElse
           String.IsNullOrWhiteSpace(txtImageName.Text) OrElse
           String.IsNullOrWhiteSpace(txtDescription.Text) OrElse
           (rbAvailable.Checked = False And rbNotAvailable.Checked = False) Then

            MessageBox.Show("Please fill out all fields and upload an image.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Save image to Resources folder with extension (e.g., .png)
        Dim imageNameOnly As String = txtImageName.Text.Trim()
        Dim imageFullPath As String = OpenFileDialog1.FileName
        Dim extension As String = Path.GetExtension(imageFullPath)
        Dim resourcesPath As String = Path.Combine(Application.StartupPath, "Resources")

        If Not Directory.Exists(resourcesPath) Then
            Directory.CreateDirectory(resourcesPath)
        End If

        Dim savedPath As String = Path.Combine(resourcesPath, imageNameOnly & extension)
        Try
            File.Copy(imageFullPath, savedPath, True)
        Catch ex As Exception
            MessageBox.Show("Failed to save image: " & ex.Message)
            Return
        End Try

        ' Get selected category_id
        Dim selectedCategory As ComboBoxItem = TryCast(categoryComboBox.SelectedItem, ComboBoxItem)
        If selectedCategory Is Nothing Then
            MessageBox.Show("Please select a category.")
            Return
        End If
        Dim category_id As Integer = selectedCategory.Value

        ' Insert service into database
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO services (name, description, price, category_id, is_available, image_name) VALUES (@name, @desc, @price, @cat, @avail, @img)", conn)
            cmd.Parameters.AddWithValue("@name", txtServiceName.Text.Trim())
            cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim())
            cmd.Parameters.AddWithValue("@price", Decimal.Parse(txtPrice.Text.Trim()))
            cmd.Parameters.AddWithValue("@cat", category_id)
            cmd.Parameters.AddWithValue("@avail", If(rbAvailable.Checked, 1, 0))
            cmd.Parameters.AddWithValue("@img", imageNameOnly) ' no extension
            cmd.ExecuteNonQuery()

            MessageBox.Show("Service successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Error saving to database: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ClearForm()
        txtServiceName.Clear()
        txtPrice.Clear()
        txtImageName.Clear()
        txtDescription.Clear()
        PictureBoxImage.Image = Nothing
        categoryComboBox.SelectedIndex = -1
        rbAvailable.Checked = False
        rbNotAvailable.Checked = False
    End Sub
End Class
