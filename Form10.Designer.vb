<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.OmcEduBudDataSet = New Oh_My_Code_Edu_Bud.OmcEduBudDataSet()
        Me.Course_DesciptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Course_DesciptionTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Course_DesciptionTableAdapter()
        Me.TableAdapterManager = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.TableAdapterManager()
        Me.lblPageNo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSubscription = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.lblDesc3 = New System.Windows.Forms.Label()
        Me.CourseDesciptionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTitle3 = New System.Windows.Forms.Label()
        Me.pnlSAP = New System.Windows.Forms.Panel()
        Me.lblDesc2 = New System.Windows.Forms.Label()
        Me.CourseDesciptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.pnlVP = New System.Windows.Forms.Panel()
        Me.lblDesc1 = New System.Windows.Forms.Label()
        Me.lbllTitle1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCourse = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LinkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TutorsNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CourseDesciptionBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Course_DesciptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.CourseDesciptionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSAP.SuspendLayout()
        CType(Me.CourseDesciptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVP.SuspendLayout()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseDesciptionBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'lblPageNo
        '
        Me.lblPageNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPageNo.AutoSize = True
        Me.lblPageNo.BackColor = System.Drawing.Color.Transparent
        Me.lblPageNo.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageNo.Location = New System.Drawing.Point(568, 540)
        Me.lblPageNo.Name = "lblPageNo"
        Me.lblPageNo.Size = New System.Drawing.Size(29, 33)
        Me.lblPageNo.TabIndex = 79
        Me.lblPageNo.Text = "1"
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnBack.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(181, 553)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(87, 46)
        Me.btnBack.TabIndex = 78
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnNext.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(367, 553)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 46)
        Me.btnNext.TabIndex = 77
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(585, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(67, 53)
        Me.MenuStrip1.TabIndex = 76
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TestToolStripMenuItem.CheckOnClick = True
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.mnuProfile, Me.mnuSubscription, Me.mnuAbout, Me.mnuLogout})
        Me.TestToolStripMenuItem.Image = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.menu_strip_icon
        Me.TestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(60, 49)
        '
        'mnuHome
        '
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(224, 26)
        Me.mnuHome.Text = "Home"
        '
        'mnuProfile
        '
        Me.mnuProfile.Name = "mnuProfile"
        Me.mnuProfile.Size = New System.Drawing.Size(224, 26)
        Me.mnuProfile.Text = "Profile"
        '
        'mnuSubscription
        '
        Me.mnuSubscription.Name = "mnuSubscription"
        Me.mnuSubscription.Size = New System.Drawing.Size(224, 26)
        Me.mnuSubscription.Text = "Subscription"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(224, 26)
        Me.mnuAbout.Text = "About us"
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(224, 26)
        Me.mnuLogout.Text = "Log out"
        '
        'pnlContent
        '
        Me.pnlContent.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pnlContent.BackColor = System.Drawing.Color.Transparent
        Me.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContent.Controls.Add(Me.lblDesc3)
        Me.pnlContent.Controls.Add(Me.lblTitle3)
        Me.pnlContent.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.pnlContent.Location = New System.Drawing.Point(71, 362)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(490, 151)
        Me.pnlContent.TabIndex = 75
        '
        'lblDesc3
        '
        Me.lblDesc3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourseDesciptionBindingSource1, "Description", True))
        Me.lblDesc3.Font = New System.Drawing.Font("Segoe Print", 10.2!)
        Me.lblDesc3.Location = New System.Drawing.Point(26, 56)
        Me.lblDesc3.Name = "lblDesc3"
        Me.lblDesc3.Size = New System.Drawing.Size(356, 66)
        Me.lblDesc3.TabIndex = 1
        Me.lblDesc3.Text = "lblDesc3"
        '
        'CourseDesciptionBindingSource1
        '
        Me.CourseDesciptionBindingSource1.DataMember = "Course Desciption"
        Me.CourseDesciptionBindingSource1.DataSource = Me.OmcEduBudDataSet
        '
        'lblTitle3
        '
        Me.lblTitle3.AutoSize = True
        Me.lblTitle3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourseDesciptionBindingSource1, "Course Name", True))
        Me.lblTitle3.Location = New System.Drawing.Point(26, 29)
        Me.lblTitle3.Name = "lblTitle3"
        Me.lblTitle3.Size = New System.Drawing.Size(83, 30)
        Me.lblTitle3.TabIndex = 0
        Me.lblTitle3.Text = "lblTitle3"
        '
        'pnlSAP
        '
        Me.pnlSAP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pnlSAP.BackColor = System.Drawing.Color.Transparent
        Me.pnlSAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSAP.Controls.Add(Me.lblDesc2)
        Me.pnlSAP.Controls.Add(Me.lblTitle2)
        Me.pnlSAP.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.pnlSAP.Location = New System.Drawing.Point(71, 222)
        Me.pnlSAP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSAP.Name = "pnlSAP"
        Me.pnlSAP.Size = New System.Drawing.Size(490, 151)
        Me.pnlSAP.TabIndex = 74
        '
        'lblDesc2
        '
        Me.lblDesc2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourseDesciptionBindingSource, "Description", True))
        Me.lblDesc2.Font = New System.Drawing.Font("Segoe Print", 10.2!)
        Me.lblDesc2.Location = New System.Drawing.Point(26, 60)
        Me.lblDesc2.Name = "lblDesc2"
        Me.lblDesc2.Size = New System.Drawing.Size(365, 66)
        Me.lblDesc2.TabIndex = 1
        Me.lblDesc2.Text = "lblDesc2"
        '
        'CourseDesciptionBindingSource
        '
        Me.CourseDesciptionBindingSource.DataMember = "Course Desciption"
        Me.CourseDesciptionBindingSource.DataSource = Me.OmcEduBudDataSet
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourseDesciptionBindingSource, "Course Name", True))
        Me.lblTitle2.Location = New System.Drawing.Point(26, 23)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(83, 30)
        Me.lblTitle2.TabIndex = 0
        Me.lblTitle2.Text = "lblTitle2"
        '
        'pnlVP
        '
        Me.pnlVP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pnlVP.BackColor = System.Drawing.Color.Transparent
        Me.pnlVP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlVP.Controls.Add(Me.lblDesc1)
        Me.pnlVP.Controls.Add(Me.lbllTitle1)
        Me.pnlVP.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.pnlVP.Location = New System.Drawing.Point(71, 81)
        Me.pnlVP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlVP.Name = "pnlVP"
        Me.pnlVP.Size = New System.Drawing.Size(490, 151)
        Me.pnlVP.TabIndex = 73
        '
        'lblDesc1
        '
        Me.lblDesc1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Description", True))
        Me.lblDesc1.Font = New System.Drawing.Font("Segoe Print", 10.2!)
        Me.lblDesc1.Location = New System.Drawing.Point(26, 59)
        Me.lblDesc1.Name = "lblDesc1"
        Me.lblDesc1.Size = New System.Drawing.Size(356, 66)
        Me.lblDesc1.TabIndex = 1
        Me.lblDesc1.Text = "lblDesc1"
        '
        'lbllTitle1
        '
        Me.lbllTitle1.AutoSize = True
        Me.lbllTitle1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Course Name", True))
        Me.lbllTitle1.Location = New System.Drawing.Point(26, 22)
        Me.lbllTitle1.Name = "lbllTitle1"
        Me.lbllTitle1.Size = New System.Drawing.Size(83, 30)
        Me.lbllTitle1.TabIndex = 0
        Me.lbllTitle1.Text = "lblDesc1"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(254, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 54)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Courses"
        '
        'dgvCourse
        '
        Me.dgvCourse.AutoGenerateColumns = False
        Me.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCourse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn, Me.LinkDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.TutorsNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.PictureDataGridViewImageColumn})
        Me.dgvCourse.DataSource = Me.CourseDesciptionBindingSource2
        Me.dgvCourse.Location = New System.Drawing.Point(12, 25)
        Me.dgvCourse.Name = "dgvCourse"
        Me.dgvCourse.RowHeadersWidth = 51
        Me.dgvCourse.RowTemplate.Height = 27
        Me.dgvCourse.Size = New System.Drawing.Size(240, 150)
        Me.dgvCourse.TabIndex = 80
        Me.dgvCourse.Visible = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'CourseNameDataGridViewTextBoxColumn
        '
        Me.CourseNameDataGridViewTextBoxColumn.DataPropertyName = "Course Name"
        Me.CourseNameDataGridViewTextBoxColumn.HeaderText = "Course Name"
        Me.CourseNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CourseNameDataGridViewTextBoxColumn.Name = "CourseNameDataGridViewTextBoxColumn"
        Me.CourseNameDataGridViewTextBoxColumn.Width = 125
        '
        'LinkDataGridViewTextBoxColumn
        '
        Me.LinkDataGridViewTextBoxColumn.DataPropertyName = "Link"
        Me.LinkDataGridViewTextBoxColumn.HeaderText = "Link"
        Me.LinkDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LinkDataGridViewTextBoxColumn.Name = "LinkDataGridViewTextBoxColumn"
        Me.LinkDataGridViewTextBoxColumn.Width = 125
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Width = 125
        '
        'TutorsNameDataGridViewTextBoxColumn
        '
        Me.TutorsNameDataGridViewTextBoxColumn.DataPropertyName = "Tutor's Name"
        Me.TutorsNameDataGridViewTextBoxColumn.HeaderText = "Tutor's Name"
        Me.TutorsNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TutorsNameDataGridViewTextBoxColumn.Name = "TutorsNameDataGridViewTextBoxColumn"
        Me.TutorsNameDataGridViewTextBoxColumn.Width = 125
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.Width = 125
        '
        'PictureDataGridViewImageColumn
        '
        Me.PictureDataGridViewImageColumn.DataPropertyName = "Picture"
        Me.PictureDataGridViewImageColumn.HeaderText = "Picture"
        Me.PictureDataGridViewImageColumn.MinimumWidth = 6
        Me.PictureDataGridViewImageColumn.Name = "PictureDataGridViewImageColumn"
        Me.PictureDataGridViewImageColumn.Width = 125
        '
        'CourseDesciptionBindingSource2
        '
        Me.CourseDesciptionBindingSource2.DataMember = "Course Desciption"
        Me.CourseDesciptionBindingSource2.DataSource = Me.OmcEduBudDataSet
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.photo_2022_11_09_15_27_39
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(656, 623)
        Me.Controls.Add(Me.dgvCourse)
        Me.Controls.Add(Me.lblPageNo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSAP)
        Me.Controls.Add(Me.pnlVP)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Courses"
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Course_DesciptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.CourseDesciptionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSAP.ResumeLayout(False)
        Me.pnlSAP.PerformLayout()
        CType(Me.CourseDesciptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVP.ResumeLayout(False)
        Me.pnlVP.PerformLayout()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseDesciptionBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OmcEduBudDataSet As OmcEduBudDataSet
    Friend WithEvents Course_DesciptionBindingSource As BindingSource
    Friend WithEvents Course_DesciptionTableAdapter As OmcEduBudDataSetTableAdapters.Course_DesciptionTableAdapter
    Friend WithEvents TableAdapterManager As OmcEduBudDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblPageNo As Label
    Private WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents mnuProfile As ToolStripMenuItem
    Friend WithEvents mnuSubscription As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblDesc3 As Label
    Friend WithEvents lblTitle3 As Label
    Friend WithEvents pnlSAP As Panel
    Friend WithEvents lblDesc2 As Label
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents pnlVP As Panel
    Friend WithEvents lblDesc1 As Label
    Friend WithEvents lbllTitle1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CourseDesciptionBindingSource1 As BindingSource
    Friend WithEvents CourseDesciptionBindingSource As BindingSource
    Friend WithEvents dgvCourse As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LinkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TutorsNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents CourseDesciptionBindingSource2 As BindingSource
End Class
