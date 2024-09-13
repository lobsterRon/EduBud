
Public Class Form2
    Private Sub btnStuCreate_Click(sender As Object, e As EventArgs) Handles btnStuCreate.Click
        Dim dataSame As Boolean = False
        Dim strFind As String

        If txtCreateSN.Text = "" Then
            MsgBox("Please enter your name", 0 + MsgBoxStyle.Exclamation, "Invalid Name")
            txtCreateSN.Clear()
            Exit Sub

        ElseIf mskIC.Text = "" Or mskIC.Text.Length < 14 Then
            MsgBox("Please enter your Malaysia IC number", 0 + MsgBoxStyle.Exclamation, "Invalid IC Number")
            mskIC.Clear()
            Exit Sub

        ElseIf mskPhone.Text = "" Or mskPhone.Text.Length < 11 Then
            MsgBox("Please enter a Malaysia mobile telephone number", 0 + MsgBoxStyle.Exclamation, "Invalid Telephone Number")
            mskPhone.Clear()
            Exit Sub

        ElseIf txtCreateSE.Text = "" Then
            MsgBox("Please enter your email", 0 + MsgBoxStyle.Exclamation, "Invalid Email")
            txtCreateSE.Clear()
            Exit Sub

        ElseIf txtCreateSU.Text = "" Then
            MsgBox("Please enter your username", 0 + MsgBoxStyle.Exclamation, "Invalid Username")
            txtCreateSU.Clear()
            Exit Sub

        ElseIf txtCreateSP.Text = "" Then
            MsgBox("Please enter your password", 0 + MsgBoxStyle.Exclamation, "Invalid Password")
            txtCreateSP.Clear()
            txtCreateConfirm.Clear()
            Exit Sub
        End If

        If txtCreateSP.Text <> txtCreateConfirm.Text Then
            MsgBox("Your password and confirm password is not same, please enter both again", 0 + MsgBoxStyle.Exclamation, "Password Error")
            txtCreateSP.Clear()
            txtCreateConfirm.Clear()
            txtCreateSP.Focus()
            Exit Sub
        Else
            strFind = mskIC.Text
            'For IC Number
            Dim find_record = From Student_Profile In OmcEduBudDataSet.Student_Profile
                              Where Student_Profile.IC_Number = strFind
                              Select Student_Profile

            dgvStudent.DataSource = find_record.AsDataView
            Call SameData("IC Number", dataSame)

            'For Phone Number
            strFind = mskPhone.Text

            find_record = From Student_Profile In OmcEduBudDataSet.Student_Profile
                          Where Student_Profile.Phone_Number = strFind
                          Select Student_Profile

            dgvStudent.DataSource = find_record.AsDataView

            Call SameData("Telephone Number", dataSame)

            'For Email
            strFind = txtCreateSE.Text

            find_record = From Student_Profile In OmcEduBudDataSet.Student_Profile
                          Where Student_Profile.Email = strFind
                          Select Student_Profile

            dgvStudent.DataSource = find_record.AsDataView

            Call SameData("Email", dataSame)

            'For Username
            strFind = txtCreateSU.Text

            find_record = From Student_Profile In OmcEduBudDataSet.Student_Profile
                          Where Student_Profile.Username = strFind
                          Select Student_Profile

            dgvStudent.DataSource = find_record.AsDataView

            Call SameData("Username", dataSame)

            'For Password
            strFind = txtCreateSP.Text

            find_record = From Student_Profile In OmcEduBudDataSet.Student_Profile
                          Where Student_Profile.Password = strFind
                          Select Student_Profile

            dgvStudent.DataSource = find_record.AsDataView

            Call SameData("Password", dataSame)


            If dataSame = False Then
                Me.Validate()
                Me.StudentProfileBindingSource.EndEdit()
                Me.Student_ProfileTableAdapter.Update(Me.OmcEduBudDataSet.Student_Profile.GetChanges)

                MsgBox("Account created! Please reopen Edu Bud and login using your username and password", 0 + MsgBoxStyle.Information, "Account Created")


                dgvStudent.DataSource = StudentProfileBindingSource
                Me.Student_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Student_Profile)

                Form1.dgvStudent.DataSource = StudentProfileBindingSource
                Form1.Student_ProfileTableAdapter.Fill(Form1.OmcEduBudDataSet.Student_Profile)
                Me.Close()
                Form1.Close()
            End If
        End If
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Student_Profile' table. You can move, or remove it, as needed.
        Me.Student_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Student_Profile)
        Me.StudentProfileBindingSource.AddNew()

    End Sub

    Sub SameData(ByVal dataName As String, ByRef variable As Boolean)
        If dgvStudent.Rows.Count > 1 Then
            MsgBox("Please use another " & dataName, 0 + MsgBoxStyle.Exclamation, dataName & " Registered")
            variable = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Procedure.CloseForm(Form1, Me)
    End Sub
End Class