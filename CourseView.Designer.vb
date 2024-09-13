<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourseView
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Course_DesciptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OmcEduBudDataSet = New Oh_My_Code_Edu_Bud.OmcEduBudDataSet()
        Me.lblLink = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSubscription = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSubscribe = New System.Windows.Forms.Button()
        Me.lblCourseName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblTutoName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Subscription_recordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Course_DesciptionTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Course_DesciptionTableAdapter()
        Me.TableAdapterManager = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.TableAdapterManager()
        Me.Subscription_recordTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Subscription_recordTableAdapter()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRecord = New System.Windows.Forms.DataGridView()
        CType(Me.Course_DesciptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Subscription_recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Link", True))
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(144, 470)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(366, 24)
        Me.LinkLabel1.TabIndex = 61
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Course_DesciptionBindingSource
        '
        Me.Course_DesciptionBindingSource.DataMember = "Course Desciption"
        Me.Course_DesciptionBindingSource.DataSource = Me.OmcEduBudDataSet
        '
        'OmcEduBudDataSet
        '
        Me.OmcEduBudDataSet.DataSetName = "OmcEduBudDataSet"
        Me.OmcEduBudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblLink
        '
        Me.lblLink.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLink.AutoSize = True
        Me.lblLink.BackColor = System.Drawing.Color.Transparent
        Me.lblLink.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLink.Location = New System.Drawing.Point(138, 439)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(155, 33)
        Me.lblLink.TabIndex = 60
        Me.lblLink.Text = "Course's Link :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(593, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(218, 53)
        Me.MenuStrip1.TabIndex = 59
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.TestToolStripMenuItem.CheckOnClick = True
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.mnuProfile, Me.mnuSubscription, Me.mnuSearch, Me.mnuLogout})
        Me.TestToolStripMenuItem.Image = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.menu_strip_icon
        Me.TestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(60, 49)
        '
        'mnuHome
        '
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(196, 26)
        Me.mnuHome.Text = "Home"
        '
        'mnuProfile
        '
        Me.mnuProfile.Name = "mnuProfile"
        Me.mnuProfile.Size = New System.Drawing.Size(196, 26)
        Me.mnuProfile.Text = "Profile"
        '
        'mnuSubscription
        '
        Me.mnuSubscription.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuSubscription.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuSubscription.Name = "mnuSubscription"
        Me.mnuSubscription.Size = New System.Drawing.Size(196, 26)
        Me.mnuSubscription.Text = "Subscription"
        Me.mnuSubscription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mnuSearch
        '
        Me.mnuSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.Size = New System.Drawing.Size(196, 26)
        Me.mnuSearch.Text = "Search Course"
        Me.mnuSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mnuLogout
        '
        Me.mnuLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(196, 26)
        Me.mnuLogout.Text = "Log out"
        Me.mnuLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSubscribe
        '
        Me.btnSubscribe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubscribe.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubscribe.Location = New System.Drawing.Point(588, 514)
        Me.btnSubscribe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubscribe.Name = "btnSubscribe"
        Me.btnSubscribe.Size = New System.Drawing.Size(123, 32)
        Me.btnSubscribe.TabIndex = 58
        Me.btnSubscribe.Text = "SUBSCRIBE"
        Me.btnSubscribe.UseVisualStyleBackColor = True
        '
        'lblCourseName
        '
        Me.lblCourseName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCourseName.AutoSize = True
        Me.lblCourseName.BackColor = System.Drawing.Color.Transparent
        Me.lblCourseName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Course Name", True))
        Me.lblCourseName.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseName.Location = New System.Drawing.Point(135, 29)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(0, 52)
        Me.lblCourseName.TabIndex = 57
        Me.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Price", True))
        Me.lblPrice.Location = New System.Drawing.Point(222, 381)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(270, 44)
        Me.lblPrice.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(138, 381)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 33)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Price :"
        '
        'lblDesc
        '
        Me.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Description", True))
        Me.lblDesc.Location = New System.Drawing.Point(138, 205)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(509, 154)
        Me.lblDesc.TabIndex = 54
        '
        'lblTutoName
        '
        Me.lblTutoName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTutoName.BackColor = System.Drawing.Color.Transparent
        Me.lblTutoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTutoName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Tutor's Name", True))
        Me.lblTutoName.Location = New System.Drawing.Point(144, 126)
        Me.lblTutoName.Name = "lblTutoName"
        Me.lblTutoName.Size = New System.Drawing.Size(317, 32)
        Me.lblTutoName.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 33)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = " Course Description :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 33)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Tutor's Name :"
        '
        'Subscription_recordBindingSource
        '
        Me.Subscription_recordBindingSource.DataMember = "Subscription record"
        Me.Subscription_recordBindingSource.DataSource = Me.OmcEduBudDataSet
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
        'Subscription_recordTableAdapter
        '
        Me.Subscription_recordTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Course Name"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Course Name"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Student Name"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Student Name"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'dgvRecord
        '
        Me.dgvRecord.AutoGenerateColumns = False
        Me.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgvRecord.DataSource = Me.Subscription_recordBindingSource
        Me.dgvRecord.Location = New System.Drawing.Point(436, 117)
        Me.dgvRecord.Name = "dgvRecord"
        Me.dgvRecord.RowHeadersWidth = 51
        Me.dgvRecord.RowTemplate.Height = 27
        Me.dgvRecord.Size = New System.Drawing.Size(300, 220)
        Me.dgvRecord.TabIndex = 61
        Me.dgvRecord.Visible = False
        '
        'CourseView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.photo_2022_11_09_15_27_39
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(820, 575)
        Me.Controls.Add(Me.dgvRecord)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblLink)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnSubscribe)
        Me.Controls.Add(Me.lblCourseName)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblTutoName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "CourseView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CourseView"
        CType(Me.Course_DesciptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Subscription_recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OmcEduBudDataSet As OmcEduBudDataSet
    Friend WithEvents Course_DesciptionBindingSource As BindingSource
    Friend WithEvents Course_DesciptionTableAdapter As OmcEduBudDataSetTableAdapters.Course_DesciptionTableAdapter
    Friend WithEvents TableAdapterManager As OmcEduBudDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblLink As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents mnuProfile As ToolStripMenuItem
    Friend WithEvents mnuSubscription As ToolStripMenuItem
    Friend WithEvents mnuSearch As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents btnSubscribe As Button
    Friend WithEvents lblCourseName As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblTutoName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Subscription_recordBindingSource As BindingSource
    Friend WithEvents Subscription_recordTableAdapter As OmcEduBudDataSetTableAdapters.Subscription_recordTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents dgvRecord As DataGridView
End Class
