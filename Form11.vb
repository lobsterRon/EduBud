Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form9.lblCourseName.Visible = True
        Form9.lblDesc.Visible = True
        Form9.lblPrice.Visible = True
        Form9.LinkLabel1.Visible = True
        Form9.lblStatus.Visible = True
        Form9.lblTutoName.Visible = True

        lblCourseName.Text = Form9.lblCourseName.Text
        lblTutoName.Text = Form9.lblTutoName.Text
        lblDesc.Text = Form9.lblDesc.Text
        LinkLabel1.Text = Form9.LinkLabel1.Text
        lblPrice.Text = Form9.lblPrice.Text
        lblStatus.Text = Form9.lblStatus.Text
    End Sub

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Form9.Close()
        Procedure.CloseForm(TutoHomePage, Me)
    End Sub

    Private Sub mnuProfile_Click(sender As Object, e As EventArgs) Handles mnuProfile.Click
        Form9.Close()
        Procedure.CloseForm(Form4, Me)
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Form9.Close()
        Procedure.Logout(Me)
    End Sub

    Private Sub mnuUpload_Click(sender As Object, e As EventArgs) Handles mnuUpload.Click
        Form9.Close()
        Procedure.CloseForm(Form5, Me)
    End Sub

    Private Sub mnuView_Click(sender As Object, e As EventArgs) Handles mnuView.Click
        Form9.Close()
        Procedure.CloseForm(Form9, Me)
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Form9.Close()
        Procedure.AboutboxOpened(Me)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(LinkLabel1.Text)
    End Sub
End Class