Public Class l3_ClearVision
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Val(TextBox1.Text) = 6 And Val(TextBox2.Text) = 18 Then
            MsgBox("Hurray!!! Its a right guess", MsgBoxStyle.Information, "Tech Nerd")
            Button3.Enabled = True
            ClearVision.Button2.Enabled = True
            ClearVision.Button3.Enabled = True
            ClearVision.Button4.Enabled = True
            ClearVision.Button7.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        l4_ClearVision.Show()
    End Sub

    Private Sub l3_ClearVision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        roundbutton(Button1)
        roundbutton(Button2)
        roundbutton(Button3)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
        If (Asc(e.KeyChar)) <> 8 Then
            If (Asc(e.KeyChar)) < 48 Or (Asc(e.KeyChar)) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    'function to make soft edge of a button
    'copied from SOURCE CODE PH yt channel
    Private Sub roundbutton(ByVal b As Button)
        b.FlatStyle = FlatStyle.Flat
        b.FlatAppearance.BorderColor = Color.LemonChiffon
        b.FlatAppearance.BorderSize = 0

        Dim r As New Drawing2D.GraphicsPath
        r.StartFigure()

        r.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        r.AddLine(10, 0, b.Width - 20, 0)

        r.AddArc(New Rectangle(b.Width - 20, 0, 20, 20), -90, 90)
        r.AddLine(b.Width, 20, b.Width, b.Height - 10)

        r.AddArc(New Rectangle(b.Width - 25, b.Height - 25, 25, 25), 0, 90)

        r.AddLine(b.Width - 10, b.Width, 20, b.Height)
        r.AddArc(New Rectangle(0, b.Height - 20, 20, 20), 90, 90)

        b.Region = New Region(r)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
 
   
End Class