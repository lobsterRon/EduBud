Public Class Form8
    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Procedure.CloseForm(StudentHomePage, Me)
    End Sub

    Private Sub mnuSubscription_Click(sender As Object, e As EventArgs) Handles mnuSubscription.Click
        Procedure.CloseForm(StudentSubscription, Me)
    End Sub

    Private Sub mnuSearch_Click(sender As Object, e As EventArgs) Handles mnuSearch.Click
        Procedure.CloseForm(Form10, Me)
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Procedure.Logout(Me)
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Student_Profile' table. You can move, or remove it, as needed.
        Me.Student_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Student_Profile)

        lblStuName.Text = Form1.student(0)
        lblStuEmail.Text = Form1.student(1)
        lblStuIc.Text = Form1.student(3)
        lblStuNum.Text = Form1.student(4)
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Procedure.AboutboxOpened(Me)
    End Sub
End Class