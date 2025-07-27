Imports System.IO
Imports MySql.Data.MySqlClient

'FOR SERVCE LISTING
'Admin can create, add, update, and delete products.

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

        Dim selectedCategory As ComboBoxItem = TryCast(categoryComboBox.SelectedItem, ComboBoxItem)
        If selectedCategory Is Nothing Then
            MessageBox.Show("Please select a category.")
            Return
        End If
        Dim category_id As Integer = selectedCategory.Value

        Try
            conn.Open()
            Dim insertServiceCmd As New MySqlCommand("INSERT INTO services (name, description, price, category_id, is_available, image_name) VALUES (@name, @desc, @price, @cat, @avail, @img)", conn)
            insertServiceCmd.Parameters.AddWithValue("@name", txtServiceName.Text.Trim())
            insertServiceCmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim())
            insertServiceCmd.Parameters.AddWithValue("@price", Decimal.Parse(txtPrice.Text.Trim()))
            insertServiceCmd.Parameters.AddWithValue("@cat", category_id)
            insertServiceCmd.Parameters.AddWithValue("@avail", If(rbAvailable.Checked, 1, 0))
            insertServiceCmd.Parameters.AddWithValue("@img", imageNameOnly)
            insertServiceCmd.ExecuteNonQuery()

            Dim serviceId As Integer = CInt(New MySqlCommand("SELECT LAST_INSERT_ID()", conn).ExecuteScalar())

            Dim roleToAssign As New List(Of String)
            Dim serviceNameLower As String = txtServiceName.Text.ToLower()

            Select Case category_id
                Case 1
                    roleToAssign.Add("Massage Therapist")
                Case 2
                    roleToAssign.Add("Nail Technician")
                Case 3
                    roleToAssign.Add("Facial Specialist")
                Case 4
                    roleToAssign.Add("Waxing Specialist")
                Case 5
                    roleToAssign.Add("Threading Specialist")
                Case 6
                    If serviceNameLower.Contains("color") Then
                        roleToAssign.Add("Hair Colorist")
                    ElseIf serviceNameLower.Contains("rebond") Then
                        roleToAssign.Add("Rebond Specialist")
                    ElseIf serviceNameLower.Contains("treatment") OrElse serviceNameLower.Contains("keratin") OrElse serviceNameLower.Contains("hot oil") Then
                        roleToAssign.Add("Hair Treatment Specialist")
                    ElseIf serviceNameLower.Contains("men") Then
                        roleToAssign.Add("Barber")
                    Else
                        roleToAssign.Add("Hair Stylist")
                    End If
                Case 7
                    roleToAssign.Add("All-Around Spa Therapist")
            End Select

            For Each role As String In roleToAssign
                Dim roleCmd As New MySqlCommand("INSERT INTO service_staff_roles (service_id, role_name) VALUES (@service_id, @role_name)", conn)
                roleCmd.Parameters.AddWithValue("@service_id", serviceId)
                roleCmd.Parameters.AddWithValue("@role_name", role)
                roleCmd.ExecuteNonQuery()
            Next

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

Public Class ComboBoxItem
    Public Property Text As String
    Public Property Value As Integer

    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class

