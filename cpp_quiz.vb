Public Class cpp_quiz

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim score As Integer = 0
        If a4.Checked Then
            score += 20
        End If
        If b3.Checked Then
            score += 20
        End If
        If c4.Checked Then
            score += 20
        End If
        If d2.Checked Then
            score += 20
        End If
        If e3.Checked Then
            score += 20
        End If

        MsgBox("Your Score is " + Str(score) + "%")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        Quiz.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        a1.Checked = False
        a2.Checked = False
        a3.Checked = False
        a4.Checked = False

        b1.Checked = False
        b2.Checked = False
        b3.Checked = False
        b4.Checked = False

        c1.Checked = False
        c2.Checked = False
        c3.Checked = False
        c4.Checked = False

        d1.Checked = False
        d2.Checked = False
        d3.Checked = False
        d4.Checked = False

        e1.Checked = False
        e2.Checked = False
        e3.Checked = False
        e4.Checked = False
    End Sub

    Private Sub cpp_quiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        roundbutton(Button1)
        roundbutton(Button2)
        roundbutton(Button3)
        roundbutton(Button4)

    End Sub
    Private Sub roundbutton(ByVal b As Button) 'from SOURCE CODE PH yt channel
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

End Class