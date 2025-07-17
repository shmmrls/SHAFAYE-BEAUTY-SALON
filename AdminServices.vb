Imports MySql.Data.MySqlClient

Public Class AdminServices

    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=shafaye_salon")

    Private Sub AddServiceCard(serviceName As String, price As String, imageName As String)
        Dim img As Image = CType(My.Resources.ResourceManager.GetObject(imageName), Image)

        ' Create a panel to hold the service "card"
        Dim panel As New Panel()
        panel.Width = 200
        panel.Height = 250
        panel.Margin = New Padding(10)
        panel.BackColor = Color.White

        ' Picture
        Dim pic As New PictureBox()
        pic.Image = img
        pic.SizeMode = PictureBoxSizeMode.Zoom
        pic.Dock = DockStyle.Top
        pic.Height = 140

        ' Label - Service Name
        Dim lblName As New Label()
        lblName.Text = serviceName
        lblName.Font = New Font("Poppins", 10, FontStyle.Bold)
        lblName.Dock = DockStyle.Top
        lblName.TextAlign = ContentAlignment.MiddleCenter

        ' Label - Price
        Dim lblPrice As New Label()
        lblPrice.Text = "₱" & Convert.ToDecimal(price).ToString("N2")
        lblPrice.Font = New Font("Poppins", 9)
        lblPrice.Dock = DockStyle.Top
        lblPrice.TextAlign = ContentAlignment.MiddleCenter

        ' Add to panel
        panel.Controls.Add(lblPrice)
        panel.Controls.Add(lblName)
        panel.Controls.Add(pic)

        ' Add panel to flow layout
        FlowLayoutPanel1.Controls.Add(panel)
    End Sub

    Sub LoadServices()
        FlowLayoutPanel1.Controls.Clear()

        Try
            conn.Open()
            Dim sql As String = "SELECT name, price, image_name FROM services"
            Dim cmd As New MySqlCommand(sql, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                AddServiceCard(
                reader("name").ToString(),
                reader("price").ToString(),
                reader("image_name").ToString()
            )
            End While

            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading services: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = nametxt.Text.Trim()
        Dim price As String = pricetxt.Text.Trim()
        Dim imageName As String = imgname.Text.Trim() ' This should match a valid resource image name

        If name = "" Or price = "" Or imageName = "" Then
            MessageBox.Show("Please complete all fields.")
            Return
        End If

        Try
            conn.Open()
            Dim sql As String = "INSERT INTO services (name, price, image_name) VALUES (@name, @price, @image)"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@price", price)
            cmd.Parameters.AddWithValue("@image", imageName)
            cmd.ExecuteNonQuery()
            conn.Close()

            ' Only add card to UI after successful DB insert
            AddServiceCard(name, price, imageName)

            ' Clear input fields
            nametxt.Clear()
            pricetxt.Clear()
            imgname.Clear()

            MessageBox.Show("Service added successfully!")
        Catch ex As Exception
            MessageBox.Show("Error saving to database: " & ex.Message)
            conn.Close()
        End Try
    End Sub
End Class
