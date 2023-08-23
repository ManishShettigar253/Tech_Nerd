Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
         Learn.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Quiz.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AboutUs.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ContactUS.Show()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Game.Show()
    End Sub

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        ComboBox1.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        AboutUs.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ComboBox1.Visible = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        ComboBox1.Visible = True
    End Sub
     
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        roundbutton(Button1)
        roundbutton(Button2)
        roundbutton(Button3)
        roundbutton(Button4)
        roundbutton(Button5)
        roundpicture(PictureBox1)
        roundpicture(PictureBox2)
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
    'function to make soft edge of a pic
    Private Sub roundpicture(ByVal b As PictureBox) 'from SOURCE CODE PH yt channel

        Dim r As New Drawing2D.GraphicsPath
        r.StartFigure()

        r.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        r.AddLine(10, 0, b.Width - 20, 0)

        r.AddArc(New Rectangle(b.Width - 40, 0, 40, 40), -90, 90)
        r.AddLine(b.Width, 20, b.Width, b.Height - 10)

        r.AddArc(New Rectangle(b.Width - 45, b.Height - 45, 45, 45), 0, 90)

        r.AddLine(b.Width - 30, b.Width, 40, b.Height)
        r.AddArc(New Rectangle(0, b.Height - 40, 40, 40), 90, 90)

        b.Region = New Region(r)
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        ComboBox1.Visible = False
         
        If ComboBox1.SelectedIndex = 0 Then
            MyProfile.Show()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            LoginForm.Show()
        ElseIf ComboBox1.SelectedIndex = 2 Then

        ElseIf ComboBox1.SelectedIndex = 3 Then

        Else
            Dim res As String = MsgBox("Are you sure?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Tech Nerd")

 
            If res = MsgBoxResult.Yes Then
                End
            End If

        End If
        
 
    End Sub
 
End Class
