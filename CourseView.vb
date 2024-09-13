Public Class CourseView
    Dim strFind As String
    Private Sub btnSubscribe_Click(sender As Object, e As EventArgs) Handles btnSubscribe.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
    End Sub

    Private Sub mnuProfile_Click(sender As Object, e As EventArgs) Handles mnuProfile.Click
        StudentSubscription.Close()
        Form10.Close()
        Procedure.CloseForm(Form8, Me)
    End Sub

    Private Sub mnuSubscription_Click(sender As Object, e As EventArgs) Handles mnuSubscription.Click
        StudentSubscription.Close()
        StudentSubscription.Close()
        Form10.Close()
        Procedure.CloseForm(StudentHomePage, Me)
        Form10.Close()
        Procedure.CloseForm(StudentSubscription, Me)
    End Sub

    Private Sub mnuSearch_Click(sender As Object, e As EventArgs) Handles mnuSearch.Click
        StudentSubscription.Close()
        Form10.dgvCourse.Visible = False
        Procedure.CloseForm(Form10, Me)
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        StudentSubscription.Close()
        Form10.Close()
        Procedure.Logout(Me)
    End Sub

    Private Sub CourseView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Subscription_record' table. You can move, or remove it, as needed.
        Me.Subscription_recordTableAdapter.Fill(Me.OmcEduBudDataSet.Subscription_record)
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Course_Desciption' table. You can move, or remove it, as needed.
        Me.Course_DesciptionTableAdapter.Fill(Me.OmcEduBudDataSet.Course_Desciption)


        If Form1.previousform Is StudentSubscription Then
            strFind = StudentSubscription.CourseName
            lblLink.Visible = True
            LinkLabel1.Visible = True
            btnSubscribe.Visible = False

            lblCourseName.Text = StudentSubscription.dgvCourse.CurrentRow.Cells(1).Value.ToString
            lblTutoName.Text = StudentSubscription.dgvCourse.CurrentRow.Cells(5).Value.ToString
            lblDesc.Text = StudentSubscription.dgvCourse.CurrentRow.Cells(3).Value.ToString
            LinkLabel1.Text = StudentSubscription.dgvCourse.CurrentRow.Cells(2).Value.ToString
            lblPrice.Text = StudentSubscription.dgvCourse.CurrentRow.Cells(6).Value.ToString

        ElseIf Form1.previousform Is Form10 Then
            strFind = Form10.CourseName
            Subscription_recordBindingSource.Filter = "(Convert([Student Name], 'System.String') = '" & Form1.student(0) & "')"
            Dim find_record = From Subscription_Record In OmcEduBudDataSet.Subscription_record
                              Where Subscription_Record.Course_Name = strFind
                              Select Subscription_Record

            dgvRecord.DataSource = find_record.AsDataView

            If dgvRecord.Rows.Count > 1 Then
                lblLink.Visible = True
                LinkLabel1.Visible = True
                btnSubscribe.Visible = False
            Else
                lblLink.Visible = False
                LinkLabel1.Visible = False
                btnSubscribe.Visible = True
            End If
            lblCourseName.Text = Form10.dgvCourse.CurrentRow.Cells(1).Value.ToString
            lblTutoName.Text = Form10.dgvCourse.CurrentRow.Cells(5).Value.ToString
            lblDesc.Text = Form10.dgvCourse.CurrentRow.Cells(3).Value.ToString
            LinkLabel1.Text = Form10.dgvCourse.CurrentRow.Cells(2).Value.ToString
            lblPrice.Text = Form10.dgvCourse.CurrentRow.Cells(6).Value.ToString
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(LinkLabel1.Text)
    End Sub
End Class