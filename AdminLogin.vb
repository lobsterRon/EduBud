Imports System.Runtime.CompilerServices

Public Class AdminLogin
    Dim passwordImage As Boolean = 0
    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.OmcEduBudDataSet.Admin)

        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please enter your username and password properly", 0 + MsgBoxStyle.Exclamation, "Invalid Username and Password")
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
            Exit Sub
        Else
            AdminBindingSource.Filter = "(Convert(Username, 'System.String') = '" & txtUsername.Text & "')"

            If AdminBindingSource.Count <> 0 Then
                AdminBindingSource.Filter = "(Convert(Password, 'System.String') = '" & txtPassword.Text & "')"
                If AdminBindingSource.Count <> 0 Then
                    AdminTableAdapter.Fill(OmcEduBudDataSet.Admin)

                    MsgBox("Login Successful", 0 + MsgBoxStyle.Information, "Welcome!")
                    Procedure.HideForm(AdminList, Me)
                Else
                    MsgBox("Wrong username or password", 0 + MsgBoxStyle.Exclamation, "Wrong credentials")
                    dgvAdmin.DataSource = OmcEduBudDataSet.Admin
                    AdminTableAdapter.Fill(OmcEduBudDataSet.Admin)
                    txtUsername.Clear()
                    txtPassword.Clear()
                    txtUsername.Focus()
                End If
            Else
                MsgBox("Please register an account first.", 0 + MsgBoxStyle.Exclamation, "No Account Found")
                AdminTableAdapter.Fill(OmcEduBudDataSet.Admin)
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim MsgR As MsgBoxResult = MsgBox("Are you sure you want to close Edu Bud?", MsgBoxStyle.YesNo, "Leaving So Soon?")

        If MsgR = MsgBoxResult.Yes Then
            MsgBox("Thank you for using Edu Bud!", 0 + MsgBoxStyle.Information, "Exit Edu Bud")
            Me.Close()
            Form1.Close()
        End If
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        If passwordImage = 0 Then
            btnPassword.BackgroundImage = My.Resources.invisible
            txtPassword.PasswordChar = ""
            passwordImage = 1
        Else
            btnPassword.BackgroundImage = My.Resources.view
            txtPassword.PasswordChar = "•"
            passwordImage = 0
        End If
    End Sub
End Class