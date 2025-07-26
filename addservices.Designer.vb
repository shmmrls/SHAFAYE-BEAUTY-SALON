<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addservices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelforedit = New System.Windows.Forms.Panel()
        Me.btnUploadImage = New System.Windows.Forms.Button()
        Me.PictureBoxImage = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtImageName = New System.Windows.Forms.TextBox()
        Me.categoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtServiceName = New System.Windows.Forms.TextBox()
        Me.rbNotAvailable = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbAvailable = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.panelforedit.SuspendLayout()
        CType(Me.PictureBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 83)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(220, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 65)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ADD SERVICES"
        '
        'panelforedit
        '
        Me.panelforedit.Controls.Add(Me.btnUploadImage)
        Me.panelforedit.Controls.Add(Me.PictureBoxImage)
        Me.panelforedit.Controls.Add(Me.Label6)
        Me.panelforedit.Controls.Add(Me.Label5)
        Me.panelforedit.Controls.Add(Me.txtImageName)
        Me.panelforedit.Controls.Add(Me.categoryComboBox)
        Me.panelforedit.Controls.Add(Me.Label3)
        Me.panelforedit.Controls.Add(Me.Label2)
        Me.panelforedit.Controls.Add(Me.txtPrice)
        Me.panelforedit.Controls.Add(Me.Label10)
        Me.panelforedit.Controls.Add(Me.txtServiceName)
        Me.panelforedit.Controls.Add(Me.rbNotAvailable)
        Me.panelforedit.Controls.Add(Me.Label4)
        Me.panelforedit.Controls.Add(Me.rbAvailable)
        Me.panelforedit.Controls.Add(Me.Label8)
        Me.panelforedit.Controls.Add(Me.txtDescription)
        Me.panelforedit.Controls.Add(Me.btnSave)
        Me.panelforedit.Location = New System.Drawing.Point(12, 89)
        Me.panelforedit.Name = "panelforedit"
        Me.panelforedit.Size = New System.Drawing.Size(660, 460)
        Me.panelforedit.TabIndex = 95
        '
        'btnUploadImage
        '
        Me.btnUploadImage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadImage.ForeColor = System.Drawing.Color.Black
        Me.btnUploadImage.Location = New System.Drawing.Point(348, 227)
        Me.btnUploadImage.Name = "btnUploadImage"
        Me.btnUploadImage.Size = New System.Drawing.Size(183, 23)
        Me.btnUploadImage.TabIndex = 152
        Me.btnUploadImage.Text = "UPLOAD IMAGE"
        Me.btnUploadImage.UseVisualStyleBackColor = True
        '
        'PictureBoxImage
        '
        Me.PictureBoxImage.Location = New System.Drawing.Point(348, 130)
        Me.PictureBoxImage.Name = "PictureBoxImage"
        Me.PictureBoxImage.Size = New System.Drawing.Size(183, 79)
        Me.PictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImage.TabIndex = 151
        Me.PictureBoxImage.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(344, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 23)
        Me.Label6.TabIndex = 150
        Me.Label6.Text = "IMAGE UPLOAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(142, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 23)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "IMAGE NAME"
        '
        'txtImageName
        '
        Me.txtImageName.BackColor = System.Drawing.Color.White
        Me.txtImageName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImageName.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageName.Location = New System.Drawing.Point(146, 224)
        Me.txtImageName.Name = "txtImageName"
        Me.txtImageName.Size = New System.Drawing.Size(172, 27)
        Me.txtImageName.TabIndex = 145
        '
        'categoryComboBox
        '
        Me.categoryComboBox.FormattingEnabled = True
        Me.categoryComboBox.Location = New System.Drawing.Point(348, 56)
        Me.categoryComboBox.Name = "categoryComboBox"
        Me.categoryComboBox.Size = New System.Drawing.Size(184, 21)
        Me.categoryComboBox.TabIndex = 144
        Me.categoryComboBox.Text = "-- SELECT A CATEGORY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(344, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 23)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "CATEGORY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(142, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 23)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "PRICE"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.White
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(146, 142)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(172, 27)
        Me.txtPrice.TabIndex = 139
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(142, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 23)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "NAME"
        '
        'txtServiceName
        '
        Me.txtServiceName.BackColor = System.Drawing.Color.White
        Me.txtServiceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServiceName.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceName.Location = New System.Drawing.Point(146, 59)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.Size = New System.Drawing.Size(172, 27)
        Me.txtServiceName.TabIndex = 136
        '
        'rbNotAvailable
        '
        Me.rbNotAvailable.AutoSize = True
        Me.rbNotAvailable.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNotAvailable.Location = New System.Drawing.Point(399, 344)
        Me.rbNotAvailable.Name = "rbNotAvailable"
        Me.rbNotAvailable.Size = New System.Drawing.Size(104, 21)
        Me.rbNotAvailable.TabIndex = 135
        Me.rbNotAvailable.TabStop = True
        Me.rbNotAvailable.Text = "Not Available"
        Me.rbNotAvailable.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(171, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 23)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "IS AVAILABLE?"
        '
        'rbAvailable
        '
        Me.rbAvailable.AutoSize = True
        Me.rbAvailable.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAvailable.Location = New System.Drawing.Point(310, 344)
        Me.rbAvailable.Name = "rbAvailable"
        Me.rbAvailable.Size = New System.Drawing.Size(78, 21)
        Me.rbAvailable.TabIndex = 133
        Me.rbAvailable.TabStop = True
        Me.rbAvailable.Text = "Available"
        Me.rbAvailable.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(142, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 23)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "DESCRIPTION"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(146, 297)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(375, 27)
        Me.txtDescription.TabIndex = 130
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.saveEdit
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Location = New System.Drawing.Point(237, 405)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(205, 40)
        Me.btnSave.TabIndex = 129
        Me.btnSave.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'addservices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.panelforedit)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addservices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminServices"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelforedit.ResumeLayout(False)
        Me.panelforedit.PerformLayout()
        CType(Me.PictureBoxImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelforedit As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtImageName As TextBox
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents categoryComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents RoundedTextBox10 As RoundedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtServiceName As TextBox
    Friend WithEvents RoundedTextBox11 As RoundedTextBox
    Friend WithEvents rbNotAvailable As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rbAvailable As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents RoundedTextBox5 As RoundedTextBox
    Friend WithEvents btnSave As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents PictureBoxImage As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
End Class
