<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addNewItems
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
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.numUpDownQuantityUsed = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numUpDownReorderLvl = New System.Windows.Forms.NumericUpDown()
        Me.numUpDownQuantity = New System.Windows.Forms.NumericUpDown()
        Me.cmbService = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.numUpDownAddStock = New System.Windows.Forms.NumericUpDown()
        Me.btnUpdateStock = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCurrentStock = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxItemSelect = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdatedInventory = New System.Windows.Forms.Button()
        Me.pnlDailyOverview.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.numUpDownQuantityUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpDownReorderLvl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpDownQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.numUpDownAddStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.ForeColor = System.Drawing.Color.White
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 62)
        Me.pnlDailyOverview.TabIndex = 30
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(132, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(605, 45)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "ADD NEW ITEM/UPDATE STOCK LEVEL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.numUpDownQuantityUsed)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.numUpDownReorderLvl)
        Me.Panel1.Controls.Add(Me.numUpDownQuantity)
        Me.Panel1.Controls.Add(Me.cmbService)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtUnit)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.btnAddItem)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(22, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 225)
        Me.Panel1.TabIndex = 31
        '
        'numUpDownQuantityUsed
        '
        Me.numUpDownQuantityUsed.Location = New System.Drawing.Point(467, 123)
        Me.numUpDownQuantityUsed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUpDownQuantityUsed.Name = "numUpDownQuantityUsed"
        Me.numUpDownQuantityUsed.Size = New System.Drawing.Size(120, 20)
        Me.numUpDownQuantityUsed.TabIndex = 41
        Me.numUpDownQuantityUsed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(304, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 17)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "USED PER BOOKING:"
        '
        'numUpDownReorderLvl
        '
        Me.numUpDownReorderLvl.Location = New System.Drawing.Point(467, 90)
        Me.numUpDownReorderLvl.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUpDownReorderLvl.Name = "numUpDownReorderLvl"
        Me.numUpDownReorderLvl.Size = New System.Drawing.Size(120, 20)
        Me.numUpDownReorderLvl.TabIndex = 39
        Me.numUpDownReorderLvl.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numUpDownQuantity
        '
        Me.numUpDownQuantity.Location = New System.Drawing.Point(152, 123)
        Me.numUpDownQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUpDownQuantity.Name = "numUpDownQuantity"
        Me.numUpDownQuantity.Size = New System.Drawing.Size(120, 20)
        Me.numUpDownQuantity.TabIndex = 37
        Me.numUpDownQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbService
        '
        Me.cmbService.FormattingEnabled = True
        Me.cmbService.Location = New System.Drawing.Point(152, 86)
        Me.cmbService.Name = "cmbService"
        Me.cmbService.Size = New System.Drawing.Size(121, 21)
        Me.cmbService.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(304, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 17)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "REORDER LEVEL:"
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(467, 54)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(121, 20)
        Me.txtUnit.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(304, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "UNIT:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(152, 51)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 33
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(253, 168)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(118, 38)
        Me.btnAddItem.TabIndex = 19
        Me.btnAddItem.Text = "ADD ITEM"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(35, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "QUANTITY:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(35, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "FOR SERVICE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(35, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "NAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(226, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 30)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "ADD NEW SUPPLY ITEM"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.numUpDownAddStock)
        Me.Panel2.Controls.Add(Me.btnUpdateStock)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblCurrentStock)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cbxItemSelect)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(22, 328)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 170)
        Me.Panel2.TabIndex = 32
        '
        'numUpDownAddStock
        '
        Me.numUpDownAddStock.Location = New System.Drawing.Point(467, 62)
        Me.numUpDownAddStock.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUpDownAddStock.Name = "numUpDownAddStock"
        Me.numUpDownAddStock.Size = New System.Drawing.Size(123, 20)
        Me.numUpDownAddStock.TabIndex = 40
        Me.numUpDownAddStock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnUpdateStock
        '
        Me.btnUpdateStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnUpdateStock.ForeColor = System.Drawing.Color.White
        Me.btnUpdateStock.Location = New System.Drawing.Point(253, 121)
        Me.btnUpdateStock.Name = "btnUpdateStock"
        Me.btnUpdateStock.Size = New System.Drawing.Size(118, 38)
        Me.btnUpdateStock.TabIndex = 23
        Me.btnUpdateStock.Text = "UPDATE"
        Me.btnUpdateStock.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(353, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "ADD STOCK:"
        '
        'lblCurrentStock
        '
        Me.lblCurrentStock.AutoSize = True
        Me.lblCurrentStock.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentStock.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblCurrentStock.Location = New System.Drawing.Point(32, 98)
        Me.lblCurrentStock.Name = "lblCurrentStock"
        Me.lblCurrentStock.Size = New System.Drawing.Size(115, 17)
        Me.lblCurrentStock.TabIndex = 21
        Me.lblCurrentStock.Text = "CURRENT STOCK:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(32, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "SELECT ITEM:"
        '
        'cbxItemSelect
        '
        Me.cbxItemSelect.FormattingEnabled = True
        Me.cbxItemSelect.Location = New System.Drawing.Point(149, 65)
        Me.cbxItemSelect.Name = "cbxItemSelect"
        Me.cbxItemSelect.Size = New System.Drawing.Size(123, 21)
        Me.cbxItemSelect.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(223, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 30)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "UPDATE EXISTING ITEM"
        '
        'btnUpdatedInventory
        '
        Me.btnUpdatedInventory.BackColor = System.Drawing.Color.White
        Me.btnUpdatedInventory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnUpdatedInventory.Location = New System.Drawing.Point(242, 511)
        Me.btnUpdatedInventory.Name = "btnUpdatedInventory"
        Me.btnUpdatedInventory.Size = New System.Drawing.Size(177, 38)
        Me.btnUpdatedInventory.TabIndex = 41
        Me.btnUpdatedInventory.Text = "VIEW UPDATED INVENTORY"
        Me.btnUpdatedInventory.UseVisualStyleBackColor = False
        '
        'addNewItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.btnUpdatedInventory)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addNewItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addNewItems"
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numUpDownQuantityUsed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpDownReorderLvl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpDownQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.numUpDownAddStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUpdateStock As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCurrentStock As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxItemSelect As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbService As ComboBox
    Friend WithEvents numUpDownReorderLvl As NumericUpDown
    Friend WithEvents numUpDownQuantity As NumericUpDown
    Friend WithEvents numUpDownAddStock As NumericUpDown
    Friend WithEvents btnUpdatedInventory As Button
    Friend WithEvents numUpDownQuantityUsed As NumericUpDown
    Friend WithEvents Label8 As Label
End Class
