<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Course_NameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim LinkLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblCourseName = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.LinkLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.OmcEduBudDataSet = New Oh_My_Code_Edu_Bud.OmcEduBudDataSet()
        Me.Course_DesciptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Course_DesciptionTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Course_DesciptionTableAdapter()
        Me.TableAdapterManager = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.TableAdapterManager()
        Me.lblTutoName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Course_NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        LinkLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Course_DesciptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Course_NameLabel
        '
        Course_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Course_NameLabel.AutoSize = True
        Course_NameLabel.BackColor = System.Drawing.Color.Transparent
        Course_NameLabel.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Course_NameLabel.Location = New System.Drawing.Point(112, 58)
        Course_NameLabel.Name = "Course_NameLabel"
        Course_NameLabel.Size = New System.Drawing.Size(149, 33)
        Course_NameLabel.TabIndex = 59
        Course_NameLabel.Text = "Course Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DescriptionLabel.AutoSize = True
        DescriptionLabel.BackColor = System.Drawing.Color.Transparent
        DescriptionLabel.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(112, 141)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(131, 33)
        DescriptionLabel.TabIndex = 61
        DescriptionLabel.Text = "Description:"
        '
        'LinkLabel
        '
        LinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        LinkLabel.AutoSize = True
        LinkLabel.BackColor = System.Drawing.Color.Transparent
        LinkLabel.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LinkLabel.Location = New System.Drawing.Point(112, 352)
        LinkLabel.Name = "LinkLabel"
        LinkLabel.Size = New System.Drawing.Size(63, 33)
        LinkLabel.TabIndex = 63
        LinkLabel.Text = "Link:"
        '
        'StatusLabel
        '
        StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        StatusLabel.AutoSize = True
        StatusLabel.BackColor = System.Drawing.Color.Transparent
        StatusLabel.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(112, 461)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(82, 33)
        StatusLabel.TabIndex = 65
        StatusLabel.Text = "Status:"
        '
        'Label1
        '
        Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(112, 103)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(152, 33)
        Label1.TabIndex = 69
        Label1.Text = "Tutor's Name:"
        '
        'Label3
        '
        Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(112, 415)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(70, 33)
        Label3.TabIndex = 71
        Label3.Text = "Price:"
        '
        'btnReject
        '
        Me.btnReject.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnReject.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.Location = New System.Drawing.Point(297, 513)
        Me.btnReject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(89, 37)
        Me.btnReject.TabIndex = 68
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = True
        Me.btnReject.Visible = False
        '
        'btnApprove
        '
        Me.btnApprove.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnApprove.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.Location = New System.Drawing.Point(130, 513)
        Me.btnApprove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(96, 37)
        Me.btnApprove.TabIndex = 67
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = True
        Me.btnApprove.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(192, 461)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(78, 33)
        Me.lblStatus.TabIndex = 66
        Me.lblStatus.Text = "Label1"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourseName
        '
        Me.lblCourseName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCourseName.AutoSize = True
        Me.lblCourseName.BackColor = System.Drawing.Color.Transparent
        Me.lblCourseName.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseName.Location = New System.Drawing.Point(258, 58)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(86, 33)
        Me.lblCourseName.TabIndex = 60
        Me.lblCourseName.Text = "Label 1"
        '
        'lblDesc
        '
        Me.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(113, 167)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(451, 185)
        Me.lblDesc.TabIndex = 62
        Me.lblDesc.Text = "Label1"
        '
        'LinkLinkLabel
        '
        Me.LinkLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LinkLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.LinkLinkLabel.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLinkLabel.LinkVisited = True
        Me.LinkLinkLabel.Location = New System.Drawing.Point(113, 378)
        Me.LinkLinkLabel.Name = "LinkLinkLabel"
        Me.LinkLinkLabel.Size = New System.Drawing.Size(437, 23)
        Me.LinkLinkLabel.TabIndex = 64
        Me.LinkLinkLabel.TabStop = True
        Me.LinkLinkLabel.Text = "LinkLabel1"
        Me.LinkLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnBack.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(469, 513)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 37)
        Me.btnBack.TabIndex = 58
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'OmcEduBudDataSet
        '
        Me.OmcEduBudDataSet.DataSetName = "OmcEduBudDataSet"
        Me.OmcEduBudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Course_DesciptionBindingSource
        '
        Me.Course_DesciptionBindingSource.DataMember = "Course Desciption"
        Me.Course_DesciptionBindingSource.DataSource = Me.OmcEduBudDataSet
        '
        'Course_DesciptionTableAdapter
        '
        Me.Course_DesciptionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Course_DesciptionTableAdapter = Me.Course_DesciptionTableAdapter
        Me.TableAdapterManager.Student_ProfileTableAdapter = Nothing
        Me.TableAdapterManager.Subscription_recordTableAdapter = Nothing
        Me.TableAdapterManager.Tutor_ProfileTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblTutoName
        '
        Me.lblTutoName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTutoName.AutoSize = True
        Me.lblTutoName.BackColor = System.Drawing.Color.Transparent
        Me.lblTutoName.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTutoName.Location = New System.Drawing.Point(258, 103)
        Me.lblTutoName.Name = "lblTutoName"
        Me.lblTutoName.Size = New System.Drawing.Size(86, 33)
        Me.lblTutoName.TabIndex = 70
        Me.lblTutoName.Text = "Label 1"
        Me.lblTutoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(192, 415)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(78, 33)
        Me.lblPrice.TabIndex = 72
        Me.lblPrice.Text = "Label1"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.photo_2022_11_09_15_27_39
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(722, 587)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.lblTutoName)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Course_NameLabel)
        Me.Controls.Add(Me.lblCourseName)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(LinkLabel)
        Me.Controls.Add(Me.LinkLinkLabel)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AdminView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminView"
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Course_DesciptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReject As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblCourseName As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents LinkLinkLabel As LinkLabel
    Friend WithEvents btnBack As Button
    Friend WithEvents OmcEduBudDataSet As OmcEduBudDataSet
    Friend WithEvents Course_DesciptionBindingSource As BindingSource
    Friend WithEvents Course_DesciptionTableAdapter As OmcEduBudDataSetTableAdapters.Course_DesciptionTableAdapter
    Friend WithEvents TableAdapterManager As OmcEduBudDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblTutoName As Label
    Friend WithEvents lblPrice As Label
End Class
