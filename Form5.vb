Public Class Form5
    Private Sub btnUploadM_Click(sender As Object, e As EventArgs) Handles btnUploadM.Click
        If txtCourse.Text = "" Then
            MsgBox("Please enter the course name", 0 + MsgBoxStyle.Exclamation, "You haven't enter course name!")
            txtCourse.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            MsgBox("Please enter the description", 0 + MsgBoxStyle.Exclamation, "You haven't enter description!")
            txtDescription.Focus()
            Exit Sub
        ElseIf txtLink.Text = "" Then
            MsgBox("Please enter the course material link", 0 + MsgBoxStyle.Exclamation, "You haven't enter course material link!")
            txtLink.Focus()
            Exit Sub
        ElseIf IsNumeric(txtPrice.Text) = False Then
            MsgBox("Please enter the course price in RM", 0 + MsgBoxStyle.Exclamation, "You haven't enter the price!")
            Exit Sub
        Else
            Try
                MsgBox("We will try to open the course material link to check if its valid. You may close the webpage if its open.", 0 + MsgBoxStyle.Information, "Validating Link")
                Process.Start(txtLink.Text)
            Catch ex As Exception
                MsgBox("Please enter a valid link", 0 + MsgBoxStyle.Exclamation, "Failed to Open Link")
                txtLink.Clear()
                txtLink.Focus()
                Exit Sub
            End Try

            Me.Validate()
            Me.CourseDesciptionBindingSource.EndEdit()
            Me.Course_DesciptionTableAdapter.Update(Me.OmcEduBudDataSet.Course_Desciption.GetChanges)
            MsgBox("Your material have been saved. Please check your course status in Your Course", 0 + MsgBoxStyle.Information, "Material Uploaded")
            Procedure.CloseForm(TutoHomePage, Me)
        End If
    End Sub
    Private Sub btnBack_Click_1(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Hide()
    End Sub
    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Procedure.CloseForm(TutoHomePage, Me)
    End Sub

    Private Sub mnuProfile_Click(sender As Object, e As EventArgs) Handles mnuProfile.Click
        Procedure.CloseForm(Form4, Me)
    End Sub

    Private Sub mneUploadedMaterial_Click(sender As Object, e As EventArgs) Handles mneUploadedMaterial.Click
        Procedure.CloseForm(Form9, Me)
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Procedure.Logout(Me)
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Procedure.AboutboxOpened(Me)
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Course_Desciption' table. You can move, or remove it, as needed.
        Me.Course_DesciptionTableAdapter.Fill(Me.OmcEduBudDataSet.Course_Desciption)
        Me.CourseDesciptionBindingSource.AddNew()
        lblTutoName.Text = Form1.tutor(0)
        lblStatus.Text = "Pending"
    End Sub
End Class