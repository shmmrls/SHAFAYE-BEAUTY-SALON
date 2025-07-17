<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminServices
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.pricetxt = New System.Windows.Forms.TextBox()
        Me.imgname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 137)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(765, 200)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(411, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nametxt
        '
        Me.nametxt.Location = New System.Drawing.Point(67, 24)
        Me.nametxt.Name = "nametxt"
        Me.nametxt.Size = New System.Drawing.Size(220, 20)
        Me.nametxt.TabIndex = 2
        '
        'pricetxt
        '
        Me.pricetxt.Location = New System.Drawing.Point(67, 50)
        Me.pricetxt.Name = "pricetxt"
        Me.pricetxt.Size = New System.Drawing.Size(220, 20)
        Me.pricetxt.TabIndex = 3
        '
        'imgname
        '
        Me.imgname.Location = New System.Drawing.Point(67, 76)
        Me.imgname.Name = "imgname"
        Me.imgname.Size = New System.Drawing.Size(220, 20)
        Me.imgname.TabIndex = 4
        '
        'AdminServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.imgname)
        Me.Controls.Add(Me.pricetxt)
        Me.Controls.Add(Me.nametxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "AdminServices"
        Me.Text = "AdminServices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents nametxt As TextBox
    Friend WithEvents pricetxt As TextBox
    Friend WithEvents imgname As TextBox
End Class
