<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userMenu
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
        Me.logouttxt = New System.Windows.Forms.Label()
        Me.custsupptxt = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.transachistxt = New System.Windows.Forms.Label()
        Me.profiletxt = New System.Windows.Forms.Label()
        Me.reviewtxt = New System.Windows.Forms.Label()
        Me.bookappointmenttxt = New System.Windows.Forms.Label()
        Me.servicestxt = New System.Windows.Forms.Label()
        Me.hometxt = New System.Windows.Forms.Label()
        Me.panelChildForm = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.logouttxt)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 40)
        Me.Panel1.TabIndex = 0
        '
        'logouttxt
        '
        Me.logouttxt.AutoSize = True
        Me.logouttxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logouttxt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logouttxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.logouttxt.Location = New System.Drawing.Point(1188, 9)
        Me.logouttxt.Name = "logouttxt"
        Me.logouttxt.Size = New System.Drawing.Size(71, 20)
        Me.logouttxt.TabIndex = 8
        Me.logouttxt.Text = "LOG OUT"
        Me.logouttxt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'custsupptxt
        '
        Me.custsupptxt.AutoSize = True
        Me.custsupptxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.custsupptxt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custsupptxt.ForeColor = System.Drawing.Color.White
        Me.custsupptxt.Location = New System.Drawing.Point(1104, 27)
        Me.custsupptxt.Name = "custsupptxt"
        Me.custsupptxt.Size = New System.Drawing.Size(155, 20)
        Me.custsupptxt.TabIndex = 1
        Me.custsupptxt.Text = "CUSTOMER SUPPORT"
        Me.custsupptxt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel2.Controls.Add(Me.custsupptxt)
        Me.Panel2.Controls.Add(Me.transachistxt)
        Me.Panel2.Controls.Add(Me.profiletxt)
        Me.Panel2.Controls.Add(Me.reviewtxt)
        Me.Panel2.Controls.Add(Me.bookappointmenttxt)
        Me.Panel2.Controls.Add(Me.servicestxt)
        Me.Panel2.Controls.Add(Me.hometxt)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1280, 71)
        Me.Panel2.TabIndex = 1
        '
        'transachistxt
        '
        Me.transachistxt.AutoSize = True
        Me.transachistxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transachistxt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transachistxt.ForeColor = System.Drawing.Color.White
        Me.transachistxt.Location = New System.Drawing.Point(786, 27)
        Me.transachistxt.Name = "transachistxt"
        Me.transachistxt.Size = New System.Drawing.Size(173, 20)
        Me.transachistxt.TabIndex = 7
        Me.transachistxt.Text = "TRANSACTION HISTORY"
        Me.transachistxt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'profiletxt
        '
        Me.profiletxt.AutoSize = True
        Me.profiletxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profiletxt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profiletxt.ForeColor = System.Drawing.Color.White
        Me.profiletxt.Location = New System.Drawing.Point(999, 27)
        Me.profiletxt.Name = "profiletxt"
        Me.profiletxt.Size = New System.Drawing.Size(65, 20)
        Me.profiletxt.TabIndex = 6
        Me.profiletxt.Text = "PROFILE"
        Me.profiletxt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'reviewtxt
        '
        Me.reviewtxt.AutoSize = True
        Me.reviewtxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reviewtxt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reviewtxt.ForeColor = System.Drawing.Color.White
        Me.reviewtxt.Location = New System.Drawing.Point(676, 27)
        Me.reviewtxt.Name = "reviewtxt"
        Me.reviewtxt.Size = New System.Drawing.Size(70, 20)
        Me.reviewtxt.TabIndex = 5
        Me.reviewtxt.Text = "REVIEWS"
        '
        'bookappointmenttxt
        '
        Me.bookappointmenttxt.AutoSize = True
        Me.bookappointmenttxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bookappointmenttxt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookappointmenttxt.ForeColor = System.Drawing.Color.White
        Me.bookappointmenttxt.Location = New System.Drawing.Point(478, 27)
        Me.bookappointmenttxt.Name = "bookappointmenttxt"
        Me.bookappointmenttxt.Size = New System.Drawing.Size(158, 20)
        Me.bookappointmenttxt.TabIndex = 4
        Me.bookappointmenttxt.Text = "BOOK APPOINTMENT"
        '
        'servicestxt
        '
        Me.servicestxt.AutoSize = True
        Me.servicestxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.servicestxt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicestxt.ForeColor = System.Drawing.Color.White
        Me.servicestxt.Location = New System.Drawing.Point(365, 27)
        Me.servicestxt.Name = "servicestxt"
        Me.servicestxt.Size = New System.Drawing.Size(73, 20)
        Me.servicestxt.TabIndex = 3
        Me.servicestxt.Text = "SERVICES"
        '
        'hometxt
        '
        Me.hometxt.AutoSize = True
        Me.hometxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hometxt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hometxt.ForeColor = System.Drawing.Color.White
        Me.hometxt.Location = New System.Drawing.Point(272, 27)
        Me.hometxt.Name = "hometxt"
        Me.hometxt.Size = New System.Drawing.Size(53, 20)
        Me.hometxt.TabIndex = 2
        Me.hometxt.Text = "HOME"
        '
        'panelChildForm
        '
        Me.panelChildForm.BackColor = System.Drawing.Color.Transparent
        Me.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelChildForm.Location = New System.Drawing.Point(0, 111)
        Me.panelChildForm.Margin = New System.Windows.Forms.Padding(0)
        Me.panelChildForm.Name = "panelChildForm"
        Me.panelChildForm.Size = New System.Drawing.Size(1280, 638)
        Me.panelChildForm.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.logo_shafaye
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 71)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'userMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 749)
        Me.Controls.Add(Me.panelChildForm)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "userMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents custsupptxt As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents servicestxt As Label
    Friend WithEvents hometxt As Label
    Friend WithEvents bookappointmenttxt As Label
    Friend WithEvents profiletxt As Label
    Friend WithEvents reviewtxt As Label
    Friend WithEvents panelChildForm As Panel
    Friend WithEvents logouttxt As Label
    Friend WithEvents transachistxt As Label
End Class
