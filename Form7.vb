Imports System.Security.Authentication.ExtendedProtection

Public Class Form7
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim currentDate As Date = Today
        Dim expiredDate As Date = DateTimePicker1.Value

        If txtbox1.Text = "" Then
            MsgBox("Please enter name on card", 0 + MsgBoxStyle.Exclamation, "Invalid Cardholder Name")
        ElseIf txtbox2.Text = "" Then
            MsgBox("Please enter bank name", 0 + MsgBoxStyle.Exclamation, "Invalid Bank Name")
        ElseIf expiredDate < currentDate Then
            MsgBox("Please enter a valid date", 0 + MsgBoxStyle.Exclamation, "Invalid Date")
        ElseIf mskCVV.Text.Length <> 3 Or IsNumeric(mskCVV.Text) = False Then
            MsgBox("Please enter a valid CVV (3 digit number at the back of your credit card or debit card)", 0 + MsgBoxStyle.Exclamation, "Invalid CVV")
        ElseIf rdbtn1.Checked = False And rdbtn2.Checked = False Then
            MsgBox("Please select a payment method (Visa or Master Card)", 0 + MsgBoxStyle.Exclamation, "Invalid Input")
        Else
            Me.Validate()
            Me.Subscription_recordBindingSource.EndEdit()
            Me.Subscription_recordTableAdapter.Update(Me.OmcEduBudDataSet.Subscription_record)

            MsgBox("Thank you for subscribing to the course!", 0 + MsgBoxStyle.Information, "Subscribed")
            Me.Close()
            CourseView.Close()
            StudentHomePage.Show()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Procedure.CloseForm(CourseView, Me)
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Subscription_record' table. You can move, or remove it, as needed.
        Me.Subscription_recordTableAdapter.Fill(Me.OmcEduBudDataSet.Subscription_record)
        Subscription_recordBindingSource.AddNew()

        lblStudentName.Text = Form1.student(0)
        lblCourseName.Text = Form10.CourseName
    End Sub

    Private Sub Subscription_recordBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Subscription_recordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OmcEduBudDataSet)
    End Sub
End Class