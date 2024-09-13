Public Class Form1
    Dim passwordImage As Boolean = 0
    Public previousform As Form
    Public student(4), tutor(5) As String
    'student (0) = Name
    'student (1) = Email
    'student (2) = Username
    'student (3) = IC Number
    'student (4) = Phone Number

    'tutor(0) = Name
    'tutor(1) = Profesion
    'tutor(2) = Email
    'tutor(3) = Username
    'tutor(4) = IC Number
    'tutor(5) = Phone Number

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please enter your username and password properly", 0 + MsgBoxStyle.Exclamation, "Error!")

        Else
            If rbtStudent.Checked = True Then
                StudentProfileBindingSource.Filter = "(Convert(Username, 'System.String') = '" & txtUsername.Text & "')"

                If StudentProfileBindingSource.Count <> 0 Then
                    StudentProfileBindingSource.Filter = "(Convert(Password, 'System.String') = '" & txtPassword.Text & "')"

                    If StudentProfileBindingSource.Count <> 0 Then
                        Student_ProfileTableAdapter.Fill(OmcEduBudDataSet.Student_Profile)
                        'dgvStudent.DataSource = StudentProfileBindingSource

                        MsgBox("Login Successful", 0 + MsgBoxStyle.Information, "Welcome!")

                        student(0) = dgvStudent.CurrentRow.Cells(1).Value.ToString
                        student(1) = dgvStudent.CurrentRow.Cells(2).Value.ToString
                        student(2) = dgvStudent.CurrentRow.Cells(3).Value.ToString
                        student(3) = dgvStudent.CurrentRow.Cells(5).Value.ToString
                        student(4) = dgvStudent.CurrentRow.Cells(6).Value.ToString
                        Procedure.HideForm(StudentHomePage, Me)
                    Else
                        MsgBox("Wrong username or password", 0 + MsgBoxStyle.Exclamation, "Wrong credentials")
                        Student_ProfileTableAdapter.Fill(OmcEduBudDataSet.Student_Profile)
                        txtUsername.Clear()
                        txtUsername.Focus()
                        txtPassword.Clear()
                    End If

                Else
                    MsgBox("Please register an account first.", 0 + MsgBoxStyle.Exclamation, "No Account Found")
                    Student_ProfileTableAdapter.Fill(OmcEduBudDataSet.Student_Profile)
                    txtUsername.Clear()
                    txtUsername.Focus()
                    txtPassword.Clear()
                End If

            ElseIf rbtTutor.Checked = True Then
                Tutor_ProfileBindingSource.Filter = "(Convert(Username, 'System.String') = '" & txtUsername.Text & "')"
                If Tutor_ProfileBindingSource.Count <> 0 Then
                    Tutor_ProfileBindingSource.Filter = "(Convert(Password, 'System.String') = '" & txtPassword.Text & "')"

                    If Tutor_ProfileBindingSource.Count <> 0 Then
                        Tutor_ProfileTableAdapter.Fill(OmcEduBudDataSet.Tutor_Profile)
                        'dgvTutor.DataSource = Tutor_ProfileBindingSource

                        MsgBox("Login Successful", 0 + MsgBoxStyle.Information, "Welcome!")

                        tutor(0) = dgvTutor.CurrentRow.Cells(1).Value.ToString
                        tutor(1) = dgvTutor.CurrentRow.Cells(2).Value.ToString
                        tutor(2) = dgvTutor.CurrentRow.Cells(3).Value.ToString
                        tutor(3) = dgvTutor.CurrentRow.Cells(5).Value.ToString
                        tutor(4) = dgvTutor.CurrentRow.Cells(6).Value.ToString
                        tutor(5) = dgvTutor.CurrentRow.Cells(7).Value.ToString

                        Procedure.HideForm(TutoHomePage, Me)
                    Else
                        MsgBox("Wrong username or password", 0 + MsgBoxStyle.Exclamation, "Wrong credentials")
                        Tutor_ProfileTableAdapter.Fill(OmcEduBudDataSet.Tutor_Profile)
                        txtUsername.Clear()
                        txtUsername.Focus()
                        txtPassword.Clear()
                    End If
                Else
                    MsgBox("Please register an account first.", 0 + MsgBoxStyle.Exclamation, "No Account Found")
                    Tutor_ProfileTableAdapter.Fill(OmcEduBudDataSet.Tutor_Profile)
                    txtUsername.Clear()
                    txtUsername.Focus()
                    txtPassword.Clear()
                End If
            End If
        End If
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If rbtStudent.Checked = True Then
            Form2.Show()
            Me.Hide()
        ElseIf rbtTutor.Checked = True Then
            Form3.Show()
            Me.Hide()
        End If

    End Sub
    Private Sub rbtStudent_CheckedChanged(sender As Object, e As EventArgs) Handles rbtStudent.CheckedChanged
        btnSign.Enabled = True
        btnRegister.Enabled = True
    End Sub
    Private Sub rbtTutor_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTutor.CheckedChanged
        btnSign.Enabled = True
        btnRegister.Enabled = True
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim MsgR As MsgBoxResult = MsgBox("Are you sure you want to close Edu Bud?", MsgBoxStyle.YesNo, "Leaving So Soon?")

        If MsgR = MsgBoxResult.Yes Then
            MsgBox("Thank you for using Edu Bud!", 0 + MsgBoxStyle.Information, "Exit Edu Bud")
            Me.Close()
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Tutor_Profile' table. You can move, or remove it, as needed.
        Me.Tutor_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Tutor_Profile)
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Tutor_Profile' table. You can move, or remove it, as needed.
        Me.Tutor_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Tutor_Profile)
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Tutor_Profile' table. You can move, or remove it, as needed.
        Me.Tutor_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Tutor_Profile)
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Tutor_Profile' table. You can move, or remove it, as needed.
        Me.Tutor_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Tutor_Profile)
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Student_Profile' table. You can move, or remove it, as needed.
        Me.Student_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Student_Profile)
        dgvStudent.DataSource = StudentProfileBindingSource

        rbtStudent.Checked = False
        rbtTutor.Checked = False
    End Sub
End Class
