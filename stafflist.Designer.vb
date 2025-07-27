<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stafflist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deleteStaffbtn = New System.Windows.Forms.PictureBox()
        Me.addStaffbtn = New System.Windows.Forms.PictureBox()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.deleteStaffbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addStaffbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStaff
        '
        Me.dgvStaff.BackgroundColor = System.Drawing.Color.White
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStaff.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStaff.GridColor = System.Drawing.Color.LightGray
        Me.dgvStaff.Location = New System.Drawing.Point(74, 137)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStaff.ShowEditingIcon = False
        Me.dgvStaff.Size = New System.Drawing.Size(556, 340)
        Me.dgvStaff.TabIndex = 127
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 10)
        Me.Panel2.TabIndex = 129
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 96)
        Me.Panel1.TabIndex = 128
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(217, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 47)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "STAFF OVERVIEW"
        '
        'deleteStaffbtn
        '
        Me.deleteStaffbtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deleteStaffbtn.BackColor = System.Drawing.Color.Transparent
        Me.deleteStaffbtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.removeStaff
        Me.deleteStaffbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.deleteStaffbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteStaffbtn.Location = New System.Drawing.Point(145, 497)
        Me.deleteStaffbtn.Name = "deleteStaffbtn"
        Me.deleteStaffbtn.Size = New System.Drawing.Size(184, 32)
        Me.deleteStaffbtn.TabIndex = 131
        Me.deleteStaffbtn.TabStop = False
        '
        'addStaffbtn
        '
        Me.addStaffbtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addStaffbtn.BackColor = System.Drawing.Color.Transparent
        Me.addStaffbtn.BackgroundImage = Global.SHAFAYE_BEAUTY_SALON.My.Resources.Resources.addadminstaff
        Me.addStaffbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.addStaffbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addStaffbtn.Location = New System.Drawing.Point(351, 497)
        Me.addStaffbtn.Name = "addStaffbtn"
        Me.addStaffbtn.Size = New System.Drawing.Size(180, 32)
        Me.addStaffbtn.TabIndex = 130
        Me.addStaffbtn.TabStop = False
        '
        'stafflist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.deleteStaffbtn)
        Me.Controls.Add(Me.addStaffbtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvStaff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stafflist"
        Me.Text = "stafflist"
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.deleteStaffbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addStaffbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents deleteStaffbtn As PictureBox
    Friend WithEvents addStaffbtn As PictureBox
End Class
