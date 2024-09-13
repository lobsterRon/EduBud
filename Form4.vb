Public Class Form4

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Procedure.CloseForm(TutoHomePage, Me)
    End Sub
    Private Sub UploadCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadCourseToolStripMenuItem.Click
        Procedure.CloseForm(Form5, Me)
    End Sub

    Private Sub ViewUploadedCoursesToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Procedure.CloseForm(Form11, Me)
    End Sub

    Private Sub ViewCourseStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCourseStatusToolStripMenuItem.Click
        Procedure.CloseForm(Form5, Me)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Procedure.Logout(Me)
    End Sub
    Private Sub Form4_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Tutor_Profile' table. You can move, or remove it, as needed.
        Me.Tutor_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Tutor_Profile)

        lblNameTuto.Text = Form1.tutor(0)
        lblProfessionTuto.Text = Form1.tutor(1)
        lblEmailTuto.Text = Form1.tutor(2)
        lblICTuto.Text = Form1.tutor(4)
        lblPhoneTuto.Text = Form1.tutor(5)
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Procedure.AboutboxOpened(Me)
    End Sub
End Class