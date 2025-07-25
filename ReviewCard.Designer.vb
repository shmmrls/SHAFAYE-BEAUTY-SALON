<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReviewCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.lblServiceStars = New System.Windows.Forms.Label()
        Me.lblStaffStars = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblService.Location = New System.Drawing.Point(27, 14)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(52, 17)
        Me.lblService.TabIndex = 0
        Me.lblService.Text = "Service:"
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaff.Location = New System.Drawing.Point(27, 46)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(37, 17)
        Me.lblStaff.TabIndex = 1
        Me.lblStaff.Text = "Staff:"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.Location = New System.Drawing.Point(27, 110)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(74, 17)
        Me.lblComment.TabIndex = 2
        Me.lblComment.Text = """Comment"""
        '
        'lblServiceStars
        '
        Me.lblServiceStars.AutoSize = True
        Me.lblServiceStars.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceStars.Location = New System.Drawing.Point(27, 78)
        Me.lblServiceStars.Name = "lblServiceStars"
        Me.lblServiceStars.Size = New System.Drawing.Size(93, 17)
        Me.lblServiceStars.TabIndex = 3
        Me.lblServiceStars.Text = "Service Rating:"
        '
        'lblStaffStars
        '
        Me.lblStaffStars.AutoSize = True
        Me.lblStaffStars.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffStars.Location = New System.Drawing.Point(285, 78)
        Me.lblStaffStars.Name = "lblStaffStars"
        Me.lblStaffStars.Size = New System.Drawing.Size(78, 17)
        Me.lblStaffStars.TabIndex = 4
        Me.lblStaffStars.Text = "Staff Rating:"
        '
        'ReviewCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblStaffStars)
        Me.Controls.Add(Me.lblServiceStars)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.lblStaff)
        Me.Controls.Add(Me.lblService)
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.Name = "ReviewCard"
        Me.Size = New System.Drawing.Size(498, 148)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblService As Label
    Friend WithEvents lblStaff As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents lblServiceStars As Label
    Friend WithEvents lblStaffStars As Label
End Class
