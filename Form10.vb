Public Class Form10
    Dim pageNum As Integer = 1
    Dim current As Integer = 1
    Dim finalItem As Integer = 0
    Public CourseName As String

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Procedure.CloseForm(StudentHomePage, Me)
    End Sub

    Private Sub mnuProfile_Click(sender As Object, e As EventArgs) Handles mnuProfile.Click
        Procedure.CloseForm(Form8, Me)
    End Sub

    Private Sub mnuSubscription_Click(sender As Object, e As EventArgs) Handles mnuSubscription.Click
        Procedure.CloseForm(StudentSubscription, Me)
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Procedure.Logout(Me)
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Course_Desciption' table. You can move, or remove it, as needed.
        Me.Course_DesciptionTableAdapter.Fill(Me.OmcEduBudDataSet.Course_Desciption)
        CourseDesciptionBindingSource.Filter = "(Convert(Status, 'System.String') = '" & "Approved" & " ')"
        CourseDesciptionBindingSource1.Filter = "(Convert(Status, 'System.String') = '" & "Approved" & " ')"
        CourseDesciptionBindingSource2.Filter = "(Convert(Status, 'System.String') = '" & "Approved" & " ')"

        lblPageNo.Text = CStr(current)

        CourseDesciptionBindingSource.MoveNext()
        CourseDesciptionBindingSource1.MoveNext()
        CourseDesciptionBindingSource1.MoveNext()

        pageNum = CInt((CourseDesciptionBindingSource.Count) \ 3)

        If (CourseDesciptionBindingSource.Count) Mod 3 <> 0 Then
            pageNum += 1
            If 0.3 < (CourseDesciptionBindingSource.Count) Mod 3 < 0.6 Then
                finalItem = 1
            ElseIf (CourseDesciptionBindingSource.Count) Mod 3 > 0.6 Then
                finalItem = 2
            End If
        End If

            If current = pageNum Then
            btnNext.Visible = False
        End If

        If current = 1 Then
            btnBack.Visible = False
        End If
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Procedure.AboutboxOpened(Me)
    End Sub

    Private Sub Course_DesciptionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Course_DesciptionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OmcEduBudDataSet)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click


        current += 1
        lblPageNo.Text = CStr(current)

        If current = pageNum Then
            btnNext.Visible = False
            Call Forward(Course_DesciptionBindingSource)
            If finalItem = 1 Then
                pnlSAP.Visible = False
                pnlContent.Visible = False
            ElseIf finalItem = 2 Then
                pnlContent.Visible = False
                Call Forward(CourseDesciptionBindingSource)
            Else
                Call Forward(CourseDesciptionBindingSource1)
            End If
        End If

        btnBack.Visible = True
    End Sub

    Sub Forward(ByVal source As BindingSource)
        source.MoveNext()
        source.MoveNext()
        source.MoveNext()
    End Sub

    Sub Backward(ByVal source As BindingSource)
        source.MovePrevious()
        source.MovePrevious()
        source.MovePrevious()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        current -= 1
        lblPageNo.Text = CStr(current)

        If current = 1 Then
            btnBack.Visible = False
        End If

        Call Backward(Course_DesciptionBindingSource)
        If finalItem = 1 Then
            pnlSAP.Visible = False
            pnlContent.Visible = False
        ElseIf finalItem = 2 Then
            pnlContent.Visible = False
            Call Backward(CourseDesciptionBindingSource)
        Else
            Call Backward(CourseDesciptionBindingSource1)
        End If

        pnlSAP.Visible = True
        pnlContent.Visible = True
        btnNext.Visible = True
    End Sub


    Private Sub pnlVP_DoubleClick(sender As Object, e As EventArgs) Handles pnlVP.DoubleClick
        Form1.previousform = Me
        CourseName = lbllTitle1.Text
        Dim find_course = From Course_Description In OmcEduBudDataSet.Course_Desciption
                          Where Course_Description.Course_Name = CourseName
                          Select Course_Description

        dgvCourse.DataSource = find_course.AsDataView
        dgvCourse.Visible = True
        Procedure.HideForm(CourseView, Me)
    End Sub

    Private Sub pnlSAP_DoubleClick(sender As Object, e As EventArgs) Handles pnlSAP.DoubleClick
        Form1.previousform = Me
        CourseName = lblTitle2.Text
        Dim find_course = From Course_Description In OmcEduBudDataSet.Course_Desciption
                          Where Course_Description.Course_Name = CourseName
                          Select Course_Description

        dgvCourse.DataSource = find_course.AsDataView
        dgvCourse.Visible = True
        Procedure.HideForm(CourseView, Me)
    End Sub

    Private Sub pnlContent_DoubleClick(sender As Object, e As EventArgs) Handles pnlContent.DoubleClick
        Form1.previousform = Me
        CourseName = lblTitle3.Text
        Dim find_course = From Course_Description In OmcEduBudDataSet.Course_Desciption
                          Where Course_Description.Course_Name = CourseName
                          Select Course_Description

        dgvCourse.DataSource = find_course.AsDataView
        dgvCourse.Visible = True

        Procedure.HideForm(CourseView, Me)
    End Sub
End Class