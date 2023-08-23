Public Class Quiz

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        Me.Hide()
        ip_quiz.Show()

    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        Me.Hide()
        op_quiz.Show()
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        Me.Hide()
        sd_quiz.Show()
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Me.Hide()
        sw_quiz.Show()
    End Sub
 
    Private Sub Quiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        roundbutton(Button1)


        ToolTip1.SetToolTip(PictureBox10, "Take a Quiz")
        ToolTip2.SetToolTip(PictureBox9, "Take a Quiz")
        ToolTip3.SetToolTip(PictureBox18, "Take a Quiz")
        ToolTip4.SetToolTip(PictureBox17, "Take a Quiz")
        ToolTip5.SetToolTip(PictureBox16, "Take a Quiz")
        ToolTip6.SetToolTip(PictureBox15, "Take a Quiz")
        ToolTip7.SetToolTip(PictureBox14, "Take a Quiz")
        ToolTip8.SetToolTip(PictureBox13, "Take a Quiz")
        ToolTip9.SetToolTip(PictureBox12, "Take a Quiz")
        ToolTip10.SetToolTip(PictureBox11, "Take a Quiz")


        ToolTip11.SetToolTip(PictureBox1, "Take a Quiz")
        ToolTip12.SetToolTip(PictureBox2, "Take a Quiz")
        ToolTip13.SetToolTip(PictureBox4, "Take a Quiz")
        ToolTip14.SetToolTip(PictureBox3, "Take a Quiz")
        ToolTip15.SetToolTip(PictureBox6, "Take a Quiz")
        ToolTip16.SetToolTip(PictureBox5, "Take a Quiz")
        ToolTip17.SetToolTip(PictureBox8, "Take a Quiz")
        ToolTip18.SetToolTip(PictureBox7, "Take a Quiz")

        'roundpic(PictureBox1)
        'roundpic(PictureBox2)
        'roundpic(PictureBox3)
        'roundpic(PictureBox4)
        'roundpic(PictureBox5)
        'roundpic(PictureBox6)
        'roundpic(PictureBox7)
        'roundpic(PictureBox8)
        'roundpic(PictureBox9)
        'roundpic(PictureBox10)
        'roundpic(PictureBox11)
        'roundpic(PictureBox12)
        'roundpic(PictureBox13)
        'roundpic(PictureBox14)
        'roundpic(PictureBox15)
        'roundpic(PictureBox16)
        'roundpic(PictureBox17)
        'roundpic(PictureBox18)
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

    Private Sub roundpic(ByVal b As PictureBox) 'from SOURCE CODE PH yt channel

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

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Me.Hide()
        word_quiz.Show()
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Me.Hide()
        Excel_quiz.Show()
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Me.Hide()
        PowerP_quiz.Show()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Me.Hide()
        Access_quiz.Show()
    End Sub

     
 
    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Me.Hide()
        windows_quiz.Show()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Me.Hide()
        linux_quiz.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        c_quiz.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        cpp_quiz.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Me.Hide()
        java_quiz.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Hide()
        py_quiz.Show()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Hide()
        html_quiz.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Me.Hide()
        css_quiz.Show()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Me.Hide()
        sql_quiz.Show()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Me.Hide()
        vbnet_quiz.Show()
    End Sub
 
End Class

