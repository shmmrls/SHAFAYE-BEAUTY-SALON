<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ServiceNameLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(31, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 148)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ServiceNameLabel
        '
        Me.ServiceNameLabel.AutoSize = True
        Me.ServiceNameLabel.Location = New System.Drawing.Point(28, 182)
        Me.ServiceNameLabel.Name = "ServiceNameLabel"
        Me.ServiceNameLabel.Size = New System.Drawing.Size(45, 13)
        Me.ServiceNameLabel.TabIndex = 1
        Me.ServiceNameLabel.Text = "Rebond"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(28, 212)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(31, 13)
        Me.PriceLabel.TabIndex = 2
        Me.PriceLabel.Text = "1000"
        '
        'ServiceCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.ServiceNameLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ServiceCard"
        Me.Size = New System.Drawing.Size(200, 250)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ServiceNameLabel As Label
    Friend WithEvents PriceLabel As Label
End Class
