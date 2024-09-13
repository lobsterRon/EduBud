Public Class AdminList
    Private Sub AdminList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Course_Desciption' table. You can move, or remove it, as needed.
        Me.Course_DesciptionTableAdapter.Fill(Me.OmcEduBudDataSet.Course_Desciption)
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Course_Desciption' table. You can move, or remove it, as needed.
        Me.Course_DesciptionTableAdapter.Fill(Me.OmcEduBudDataSet.Course_Desciption)
        AdminView.Close()

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Procedure.HideForm(AdminView, Me)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim MsgR As MsgBoxResult = MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo, "Logout")

        If MsgR = MsgBoxResult.Yes Then
            AdminLogin.Show()
            Me.Close()
        End If
        AdminLogin.txtUsername.Clear()
        AdminLogin.txtPassword.Clear()
    End Sub
End Class