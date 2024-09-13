Public Class TutoHomePage
    Private Sub TutoHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Tutor_Profile' table. You can move, or remove it, as needed.
        Me.Tutor_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Tutor_Profile)

        Form1.previousform = Me

        lblName.Text = Form1.tutor(0)
    End Sub

    Private Sub mnuUploaded_Click(sender As Object, e As EventArgs) Handles mnuUploaded.Click
        Procedure.CloseForm(Form9, Me)
    End Sub

    Private Sub mnuProfile_Click(sender As Object, e As EventArgs) Handles mnuProfile.Click
        Procedure.CloseForm(Form4, Me)
    End Sub

    Private Sub mnuStuSubscripton_Click(sender As Object, e As EventArgs) Handles mnuUpload.Click
        Procedure.CloseForm(Form5, Me)
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Procedure.Logout(Me)
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Procedure.AboutboxOpened(Me)
    End Sub
End Class