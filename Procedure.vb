Public Class Procedure

    Public Shared Sub Error_checking(ByVal text As String, ByVal label As String)
        If text = "" Then
            MsgBox("error in " & label)

        End If
    End Sub

    Public Shared Sub NumError_checking(ByVal text As String, ByVal label As String)
        If IsNumeric(text) = False Then
            MsgBox("Invalid input in " & label)
        End If
    End Sub

    Public Shared Sub CloseForm(ByVal formOpen As Form, ByVal formClose As Form)
        formOpen.Show()
        formClose.Close()
    End Sub

    Public Shared Sub HideForm(ByVal formOpen As Form, ByVal formClose As Form)
        formOpen.Show()
        formClose.Hide()
    End Sub

    Public Shared Sub Logout(ByVal form As Form)
        Dim MsgR As MsgBoxResult = MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo, "Logout")

        If MsgR = MsgBoxResult.Yes Then
            Form1.txtUsername.Clear()
            Form1.txtPassword.Clear()
            Form1.rbtStudent.Checked = False
            Form1.rbtTutor.Checked = False
            Form1.btnSign.Enabled = False
            Form1.Show()
            form.Close()
        End If
    End Sub

    Public Shared Sub AboutboxOpened(ByVal prevForm As Form)
        Form1.previousform = prevForm
        prevForm.Hide()
        AboutBoxEduBud.Show()
    End Sub


End Class
