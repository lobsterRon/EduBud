Public Class AdminView
    Private Sub AdminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OmcEduBudDataSet.Course_Desciption' table. You can move, or remove it, as needed.
        Me.Course_DesciptionTableAdapter.Fill(Me.OmcEduBudDataSet.Course_Desciption)

        AdminList.lblCourseName.Visible = True
        AdminList.lblTutoName.Visible = True
        AdminList.lblDesc.Visible = True
        AdminList.LinkLabel1.Visible = True
        AdminList.lblPrice.Visible = True
        AdminList.lblStatus.Visible = True

        lblCourseName.Text = AdminList.lblCourseName.Text
        lblTutoName.Text = AdminList.lblTutoName.Text
        lblDesc.Text = AdminList.lblDesc.Text
        LinkLinkLabel.Text = AdminList.LinkLabel1.Text
        lblPrice.Text = AdminList.lblPrice.Text
        lblStatus.Text = AdminList.lblStatus.Text

        If lblStatus.Text = "Pending" Then
            btnApprove.Visible = True
            btnReject.Visible = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminList.lblCourseName.Visible = False
        AdminList.lblTutoName.Visible = False
        AdminList.lblDesc.Visible = False
        AdminList.LinkLabel1.Visible = False
        AdminList.lblPrice.Visible = False
        AdminList.lblStatus.Visible = False

        AdminList.Show()
        Me.Close()
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        lblStatus.Text = "Approved"
        AdminList.lblStatus.Text = lblStatus.Text
        AdminList.Validate()
        AdminList.Course_DesciptionBindingSource.EndEdit()
        AdminList.TableAdapterManager.UpdateAll(AdminList.OmcEduBudDataSet)
        MsgBox("Successfully change")
        Course_DesciptionTableAdapter.Fill(AdminList.OmcEduBudDataSet.Course_Desciption)

        AdminList.lblCourseName.Visible = False
        AdminList.lblTutoName.Visible = False
        AdminList.lblDesc.Visible = False
        AdminList.LinkLabel1.Visible = False
        AdminList.lblPrice.Visible = False
        AdminList.lblStatus.Visible = False

        AdminList.Course_DesciptionTableAdapter.Fill(Me.OmcEduBudDataSet.Course_Desciption)
        Procedure.CloseForm(AdminList, Me)
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        lblStatus.Text = "Rejected"
        AdminList.lblStatus.Text = lblStatus.Text
        AdminList.Validate()
        AdminList.Course_DesciptionBindingSource.EndEdit()
        AdminList.Course_DesciptionTableAdapter.Update(AdminList.OmcEduBudDataSet.Course_Desciption)
        MsgBox("Successfully change")
        AdminList.Course_DesciptionTableAdapter.Fill(AdminList.OmcEduBudDataSet.Course_Desciption)

        AdminList.lblCourseName.Visible = False
        AdminList.lblTutoName.Visible = False
        AdminList.lblDesc.Visible = False
        AdminList.LinkLabel1.Visible = False
        AdminList.lblPrice.Visible = False
        AdminList.lblStatus.Visible = False
        AdminList.Course_DesciptionTableAdapter.Fill(AdminList.OmcEduBudDataSet.Course_Desciption)
        Procedure.CloseForm(AdminList, Me)
    End Sub

    Private Sub LinkLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLinkLabel.LinkClicked
        Process.Start(LinkLinkLabel.Text)
    End Sub
End Class