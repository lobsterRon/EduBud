Public Class StudentHomePage
    Private Sub StudentHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Student_Profile' table. You can move, or remove it, as needed.
        Me.Student_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Student_Profile)
        Form1.previousform = Me

        lblName.Text = Form1.student(0)
    End Sub

    Private Sub mnuProfile_Click(sender As Object, e As EventArgs) Handles mnuProfile.Click
        Procedure.HideForm(Form8, Me)
    End Sub

    Private Sub mnuSubscription_Click(sender As Object, e As EventArgs) Handles mnuSubscription.Click
        Procedure.HideForm(StudentSubscription, Me)
    End Sub

    Private Sub mnuSearch_Click(sender As Object, e As EventArgs) Handles mnuSearch.Click
        Procedure.HideForm(Form10, Me)
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Procedure.Logout(Me)
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Procedure.AboutboxOpened(Me)
    End Sub
End Class