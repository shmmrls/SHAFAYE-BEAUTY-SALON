<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventoryList
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
        Me.flpInventoryList = New System.Windows.Forms.FlowLayoutPanel()
        Me.fororganization = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblBookingsTitle = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlDailyOverview = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.fororganization.SuspendLayout()
        Me.pnlDailyOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpInventoryList
        '
        Me.flpInventoryList.Location = New System.Drawing.Point(23, 194)
        Me.flpInventoryList.Name = "flpInventoryList"
        Me.flpInventoryList.Size = New System.Drawing.Size(641, 338)
        Me.flpInventoryList.TabIndex = 28
        '
        'fororganization
        '
        Me.fororganization.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.fororganization.Controls.Add(Me.btnSearch)
        Me.fororganization.Controls.Add(Me.txtSearch)
        Me.fororganization.Controls.Add(Me.lblBookingsTitle)
        Me.fororganization.Controls.Add(Me.lblRevenue)
        Me.fororganization.Controls.Add(Me.Label2)
        Me.fororganization.Dock = System.Windows.Forms.DockStyle.Top
        Me.fororganization.Location = New System.Drawing.Point(0, 83)
        Me.fororganization.Name = "fororganization"
        Me.fororganization.Size = New System.Drawing.Size(684, 82)
        Me.fororganization.TabIndex = 26
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(429, 26)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(101, 30)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(183, 33)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(216, 20)
        Me.txtSearch.TabIndex = 18
        '
        'lblBookingsTitle
        '
        Me.lblBookingsTitle.AutoSize = True
        Me.lblBookingsTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingsTitle.ForeColor = System.Drawing.Color.White
        Me.lblBookingsTitle.Location = New System.Drawing.Point(373, 33)
        Me.lblBookingsTitle.Name = "lblBookingsTitle"
        Me.lblBookingsTitle.Size = New System.Drawing.Size(0, 30)
        Me.lblBookingsTitle.TabIndex = 17
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.ForeColor = System.Drawing.Color.White
        Me.lblRevenue.Location = New System.Drawing.Point(47, 39)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(0, 30)
        Me.lblRevenue.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(142, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 12
        '
        'pnlDailyOverview
        '
        Me.pnlDailyOverview.Controls.Add(Me.lblTitle)
        Me.pnlDailyOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDailyOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlDailyOverview.Name = "pnlDailyOverview"
        Me.pnlDailyOverview.Size = New System.Drawing.Size(684, 83)
        Me.pnlDailyOverview.TabIndex = 27
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(80, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(584, 47)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "INVENTORY LIST W/ USAGE LOGS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'inventoryList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.flpInventoryList)
        Me.Controls.Add(Me.fororganization)
        Me.Controls.Add(Me.pnlDailyOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inventoryList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inventoryList"
        Me.fororganization.ResumeLayout(False)
        Me.fororganization.PerformLayout()
        Me.pnlDailyOverview.ResumeLayout(False)
        Me.pnlDailyOverview.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpInventoryList As FlowLayoutPanel
    Friend WithEvents fororganization As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblBookingsTitle As Label
    Friend WithEvents lblRevenue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlDailyOverview As Panel
    Friend WithEvents lblTitle As Label
End Class
