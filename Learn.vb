Public Class Learn

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()

    End Sub 

    Private Sub Learn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        roundbutton(Button1)


        ToolTip1.SetToolTip(PictureBox10, "Learn This Concept")
        ToolTip2.SetToolTip(PictureBox9, "Learn This Concept")
        ToolTip3.SetToolTip(PictureBox18, "Learn This Concept")
        ToolTip4.SetToolTip(PictureBox17, "Learn This Concept")
        ToolTip5.SetToolTip(PictureBox16, "Learn This Concept")
        ToolTip6.SetToolTip(PictureBox15, "Learn This Concept")
        ToolTip7.SetToolTip(PictureBox14, "Learn This Concept")
        ToolTip8.SetToolTip(PictureBox13, "Learn This Concept")
        ToolTip9.SetToolTip(PictureBox12, "Learn This Concept")
        ToolTip10.SetToolTip(PictureBox11, "Learn This Concept")


        ToolTip11.SetToolTip(PictureBox1, "Learn This Concept")
        ToolTip12.SetToolTip(PictureBox2, "Learn This Concept")
        ToolTip13.SetToolTip(PictureBox4, "Learn This Concept")
        ToolTip14.SetToolTip(PictureBox3, "Learn This Concept")
        ToolTip15.SetToolTip(PictureBox6, "Learn This Concept")
        ToolTip16.SetToolTip(PictureBox5, "Learn This Concept")
        ToolTip17.SetToolTip(PictureBox8, "Learn This Concept")
        ToolTip18.SetToolTip(PictureBox7, "Learn This Concept")



        LinkLabel1.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpG0NNfU492sx5CiUnp1kPXG")
        LinkLabel2.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpGsim4cuJrh9w6-yfuC9XqI")

        LinkLabel3.Links.Add(6, 4, "https://www.youtube.com/watch?v=30lvvcbCrj8&t=121s")
        LinkLabel4.Links.Add(6, 4, "https://www.youtube.com/watch?v=Dd2IILYGCeo")
        LinkLabel5.Links.Add(6, 4, "https://www.youtube.com/watch?v=cTbtjfD8bnE&list=PLspGXahxbrNypsfGs-7bbsV9qluRVeYj9")
        LinkLabel6.Links.Add(6, 4, "https://www.youtube.com/watch?v=kDAr6l4Gu88")

        LinkLabel7.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpHyWP7u5HOrr4s2-bycPpO6")
        LinkLabel8.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpEpO6NjjWLbKSCb-wx3hMql")
        LinkLabel9.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpHGHk2EhDGUppPZANBH8qSq")
        LinkLabel10.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpF2YKX0q305LqZO4V4fNXy-")

        LinkLabel11.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpEK1RbpruFXrwgzcGUjZ4nV")
        LinkLabel12.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpGDG3--IKMLPoYrgfuhaz_t")
        LinkLabel13.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpFfTUVBl5KbeXly1sHKSc-Z")
        LinkLabel14.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpEPEtQRXTuvl195x5vXFMXR")
        LinkLabel15.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpFI-w62QiV62FOVHcXnynon")
        LinkLabel16.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpFKYRhzNA_vHMNDNrhINruK")
        LinkLabel17.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLWPirh4EWFpGKVoAXc4EjgaV4jbAyLrxe")
        LinkLabel18.Links.Add(6, 4, "https://www.youtube.com/playlist?list=PLS1QulWo1RIYLpgVN_CpXbkOQoYJTItzg")
         
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

      
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked, LinkLabel2.LinkClicked, LinkLabel3.LinkClicked, LinkLabel4.LinkClicked, LinkLabel5.LinkClicked, LinkLabel6.LinkClicked, LinkLabel7.LinkClicked, LinkLabel8.LinkClicked, LinkLabel9.LinkClicked, LinkLabel10.LinkClicked, LinkLabel11.LinkClicked, LinkLabel12.LinkClicked, LinkLabel13.LinkClicked, LinkLabel14.LinkClicked, LinkLabel15.LinkClicked, LinkLabel16.LinkClicked, LinkLabel17.LinkClicked, LinkLabel18.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

     
End Class