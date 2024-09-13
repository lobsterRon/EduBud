Public Class Form3
    Private Sub btnStuCreate_Click(sender As Object, e As EventArgs) Handles btnStuCreate.Click
        Dim dataSame As Boolean = False
        Dim strFind As String

        If txtCreateSN.Text = "" Then
            MsgBox("Please enter your name", 0 + MsgBoxStyle.Exclamation, "Invalid Name")
            txtCreateSN.Clear()
            Exit Sub

        ElseIf txtCreateP.Text = "" Then
            MsgBox("Please enter your profession", 0 + MsgBoxStyle.Exclamation, "Invalid Profession")
            txtCreateP.Clear()
            Exit Sub

        ElseIf mskIC.Text = "" Then
            MsgBox("Please enter your IC number", 0 + MsgBoxStyle.Exclamation, "Invalid IC Number")
            mskIC.Clear()
            Exit Sub

        ElseIf mskPhone.Text = "" Then
            MsgBox("Please enter your telephone number", 0 + MsgBoxStyle.Exclamation, "Invalid Telephone Number")
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
            Dim find_record = From Tutor_Profile In OmcEduBudDataSet.Tutor_Profile
                              Where Tutor_Profile.IC_Number = strFind
                              Select Tutor_Profile

            dgvTutor.DataSource = find_record.AsDataView
            Call SameData("IC Number", dataSame)

            'For Phone Number
            strFind = mskPhone.Text

            find_record = From Tutor_Profile In OmcEduBudDataSet.Tutor_Profile
                          Where Tutor_Profile.Phone_Number = strFind
                          Select Tutor_Profile

            dgvTutor.DataSource = find_record.AsDataView

            Call SameData("Telephone Number", dataSame)


            'For Email
            strFind = txtCreateSE.Text

            find_record = From Tutor_Profile In OmcEduBudDataSet.Tutor_Profile
                          Where Tutor_Profile.Email = strFind
                          Select Tutor_Profile

            dgvTutor.DataSource = find_record.AsDataView

            Call SameData("Email", dataSame)

            'For Username
            strFind = txtCreateSU.Text

            find_record = From Tutor_Profile In OmcEduBudDataSet.Tutor_Profile
                          Where Tutor_Profile.Username = strFind
                          Select Tutor_Profile

            dgvTutor.DataSource = find_record.AsDataView

            Call SameData("Username", dataSame)


            'For Password
            strFind = txtCreateSP.Text

            find_record = From Tutor_Profile In OmcEduBudDataSet.Tutor_Profile
                          Where Tutor_Profile.Password = strFind
                          Select Tutor_Profile

            dgvTutor.DataSource = find_record.AsDataView

            Call SameData("Password", dataSame)

            If dataSame = False Then
                Me.Validate()
                Me.Tutor_ProfileBindingSource.EndEdit()
                Me.Tutor_ProfileTableAdapter.Update(Me.OmcEduBudDataSet.Tutor_Profile.GetChanges)

                MsgBox("Account created! Please reopen Edu Bud and login using your username and password", 0 + MsgBoxStyle.Information, "Account Created")


                dgvTutor.DataSource = Tutor_ProfileBindingSource
                Me.Tutor_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Tutor_Profile)

                Form1.dgvTutor.DataSource = Tutor_ProfileBindingSource
                Form1.Tutor_ProfileTableAdapter.Fill(Form1.OmcEduBudDataSet.Tutor_Profile)
                Me.Close()
                Form1.Close()
            End If
        End If
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Tutor_Profile' table. You can move, or remove it, as needed.
        Me.Tutor_ProfileTableAdapter.Fill(Me.OmcEduBudDataSet.Tutor_Profile)
        Me.Tutor_ProfileBindingSource.AddNew()
    End Sub

    Sub SameData(ByVal dataName As String, ByRef variable As Boolean)
        If dgvTutor.Rows.Count > 1 Then
            MsgBox("Please use another " & dataName, 0 + MsgBoxStyle.Exclamation, dataName & " Registered")
            variable = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Procedure.CloseForm(Form1, Me)
    End Sub
End Class