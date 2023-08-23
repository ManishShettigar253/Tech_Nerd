<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClearVision
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
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(36, 36)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 24)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "BACK"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Master_in_CS.My.Resources.Resources.Tech_Nerd_Modes
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(347, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 81)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Level 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Master_in_CS.My.Resources.Resources.Tech_Nerd_Modes
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(510, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 81)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Level 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Master_in_CS.My.Resources.Resources.Tech_Nerd_Modes
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(674, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 81)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Level 3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.Master_in_CS.My.Resources.Resources.Tech_Nerd_Modes
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Enabled = False
        Me.Button7.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(837, 280)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(123, 81)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "Level 4"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ClearVision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Master_in_CS.My.Resources.Resources.Tech_Nerd_Modes
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1306, 612)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Name = "ClearVision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClearVision"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
