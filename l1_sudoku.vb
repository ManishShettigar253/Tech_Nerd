Public Class l1_sudoku
 

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Val(TextBox1.Text) = 1 And Val(TextBox2.Text) = 5 And Val(TextBox3.Text) = 3 And Val(TextBox4.Text) = 7 And Val(TextBox47.Text) = 6 Then
            If Val(TextBox5.Text) = 5 And Val(TextBox6.Text) = 4 And Val(TextBox7.Text) = 3 And Val(TextBox8.Text) = 6 And Val(TextBox9.Text) = 2 Then
                If Val(TextBox46.Text) = 7 And Val(TextBox10.Text) = 8 And Val(TextBox11.Text) = 9 And Val(TextBox13.Text) = 3 And Val(TextBox14.Text) = 5 Then
                    If Val(TextBox15.Text) = 4 And Val(TextBox16.Text) = 2 And Val(TextBox17.Text) = 7 And Val(TextBox18.Text) = 9 And Val(TextBox19.Text) = 8 Then
                        If Val(TextBox24.Text) = 6 And Val(TextBox23.Text) = 5 And Val(TextBox22.Text) = 1 And Val(TextBox21.Text) = 9 And Val(TextBox25.Text) = 4 And Val(TextBox20.Text) = 2 Then
                            If Val(TextBox29.Text) = 9 And Val(TextBox28.Text) = 2 And Val(TextBox27.Text) = 4 And Val(TextBox30.Text) = 5 And Val(TextBox26.Text) = 6 Then
                                If Val(TextBox43.Text) = 3 And Val(TextBox44.Text) = 2 And Val(TextBox42.Text) = 1 And Val(TextBox31.Text) = 5 And Val(TextBox45.Text) = 9 And Val(TextBox41.Text) = 7 Then
                                    If Val(TextBox39.Text) = 4 And Val(TextBox37.Text) = 9 And Val(TextBox36.Text) = 8 And Val(TextBox38.Text) = 7 And Val(TextBox40.Text) = 2 Then
                                        If Val(TextBox33.Text) = 8 And Val(TextBox34.Text) = 1 And Val(TextBox35.Text) = 3 And Val(TextBox32.Text) = 6 Then


                                            MsgBox("Hurray!!! You won!!!!", MsgBoxStyle.Information, "Tech Nerd")
                                            Button3.Enabled = True
                                            Sudoku.Button2.Enabled = True
                                            GoTo down
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Dim x As String = MsgBox("You lost!!! Would you like to view solution?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Tech Nerd")
        If x = MsgBoxResult.Yes Then
            l1_Sudoku_sln.Show()
        End If
down:
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub l1_Sudoku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        roundbutton(Button1)
        roundbutton(Button2)
        roundbutton(Button3)
    End Sub

    'Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
    '    If (Asc(e.KeyChar)) <> 8 Then
    '        If (Asc(e.KeyChar)) < 48 Or (Asc(e.KeyChar)) > 57 Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub


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