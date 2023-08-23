Public Class ClearVision

    Private Sub ClearVision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        roundbutton(Button1)
        roundbutton(Button2)
        roundbutton(Button3)
        roundbutton(Button4) 
        roundbutton(Button7)
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        l1_ClearVision.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        l2_ClearVision.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        l3_ClearVision.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        l4_ClearVision.Show()
    End Sub
 
End Class