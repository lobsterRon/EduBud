Public Class StudentSubscription
    Public CourseName As String
    Private Sub StudentSubscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Course_Desciption' table. You can move, or remove it, as needed.
        Me.Course_DesciptionTableAdapter.Fill(Me.OmcEduBudDataSet.Course_Desciption)
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Subscription_record' table. You can move, or remove it, as needed.
        Me.Subscription_recordTableAdapter.Fill(Me.OmcEduBudDataSet.Subscription_record)

        Subscription_recordBindingSource.Filter = "(Convert([Student Name], 'System.String') = '" & Form1.student(0) & "')"
    End Sub

    Private Sub Subscription_recordBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Subscription_recordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OmcEduBudDataSet)

    End Sub

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Procedure.CloseForm(StudentHomePage, Me)
    End Sub

    Private Sub mnuProfile_Click(sender As Object, e As EventArgs) Handles mnuProfile.Click
        Procedure.CloseForm(Form8, Me)
    End Sub

    Private Sub mnuSearch_Click(sender As Object, e As EventArgs) Handles mnuSearch.Click
        Procedure.CloseForm(Form10, Me)
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Procedure.Logout(Me)
    End Sub

    Private Sub btnViewCourse_Click(sender As Object, e As EventArgs) Handles btnViewCourse.Click
        Form1.previousform = Me
        CourseName = dgvRecord.CurrentRow.Cells(2).Value.ToString
        Dim find_record = From Course_Description In OmcEduBudDataSet.Course_Desciption
                          Where Course_Description.Course_Name = CourseName
                          Select Course_Description

        dgvCourse.DataSource = find_record.AsDataView
        dgvCourse.Visible = True
        Procedure.HideForm(CourseView, Me)
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Procedure.AboutboxOpened(Me)
    End Sub

    Private Sub dgvRecord_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecord.CellClick
        If dgvRecord.CurrentCell.Value.ToString = Nothing Then
            btnViewCourse.Enabled = False
        End If
    End Sub
End Class