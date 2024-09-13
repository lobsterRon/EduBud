Public Class Form9
    Private Sub UploadCourseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Procedure.CloseForm(Form5, Me)
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Procedure.CloseForm(TutoHomePage, Me)
    End Sub
    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProfile.Click
        Procedure.CloseForm(Form4, Me)
    End Sub
    Private Sub mnuUpload_Click(sender As Object, e As EventArgs) Handles mnuUpload.Click
        Procedure.CloseForm(Form5, Me)
    End Sub
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Procedure.Logout(Me)
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Course_Desciption' table. You can move, or remove it, as needed.
        Me.Course_DesciptionTableAdapter.Fill(Me.OmcEduBudDataSet.Course_Desciption)
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Course_Desciption' table. You can move, or remove it, as needed.
        Me.Course_DesciptionTableAdapter.Fill(Me.OmcEduBudDataSet.Course_Desciption)

        Course_DesciptionBindingSource.Filter = "(Convert ([Tutor's Name], 'System.String') = '" & Form1.tutor(0) & "')"
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Procedure.AboutboxOpened(Me)
    End Sub

    Private Sub btnViewCourse_Click(sender As Object, e As EventArgs) Handles btnViewCourse.Click
        Procedure.HideForm(Form11, Me)
    End Sub

    Private Sub dgvCourse_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCourse.CellClick
        If dgvCourse.CurrentCell.Value.ToString = Nothing Then
            btnViewCourse.Enabled = False
        End If
    End Sub
End Class