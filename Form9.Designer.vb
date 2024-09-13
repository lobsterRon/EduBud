<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Course_NameLabel As System.Windows.Forms.Label
        Dim LinkLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Tutor_s_NameLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.btnViewCourse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpload = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.OmcEduBudDataSet = New Oh_My_Code_Edu_Bud.OmcEduBudDataSet()
        Me.Course_DesciptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Course_DesciptionTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Course_DesciptionTableAdapter()
        Me.TableAdapterManager = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.TableAdapterManager()
        Me.dgvCourse = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCourseName = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblTutoName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Course_NameLabel = New System.Windows.Forms.Label()
        LinkLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Tutor_s_NameLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Course_DesciptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Course_NameLabel
        '
        Course_NameLabel.AutoSize = True
        Course_NameLabel.Location = New System.Drawing.Point(12, 341)
        Course_NameLabel.Name = "Course_NameLabel"
        Course_NameLabel.Size = New System.Drawing.Size(115, 26)
        Course_NameLabel.TabIndex = 13
        Course_NameLabel.Text = "Course Name:"
        Course_NameLabel.Visible = False
        '
        'LinkLabel
        '
        LinkLabel.AutoSize = True
        LinkLabel.Location = New System.Drawing.Point(12, 367)
        LinkLabel.Name = "LinkLabel"
        LinkLabel.Size = New System.Drawing.Size(48, 26)
        LinkLabel.TabIndex = 15
        LinkLabel.Text = "Link:"
        LinkLabel.Visible = False
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(12, 393)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(101, 26)
        DescriptionLabel.TabIndex = 17
        DescriptionLabel.Text = "Description:"
        DescriptionLabel.Visible = False
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(12, 419)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(64, 26)
        StatusLabel.TabIndex = 19
        StatusLabel.Text = "Status:"
        StatusLabel.Visible = False
        '
        'Tutor_s_NameLabel
        '
        Tutor_s_NameLabel.AutoSize = True
        Tutor_s_NameLabel.Location = New System.Drawing.Point(12, 445)
        Tutor_s_NameLabel.Name = "Tutor_s_NameLabel"
        Tutor_s_NameLabel.Size = New System.Drawing.Size(117, 26)
        Tutor_s_NameLabel.TabIndex = 21
        Tutor_s_NameLabel.Text = "Tutor's Name:"
        Tutor_s_NameLabel.Visible = False
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(12, 471)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(55, 26)
        PriceLabel.TabIndex = 23
        PriceLabel.Text = "Price:"
        PriceLabel.Visible = False
        '
        'btnViewCourse
        '
        Me.btnViewCourse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnViewCourse.Font = New System.Drawing.Font("Segoe Print", 10.2!)
        Me.btnViewCourse.Location = New System.Drawing.Point(265, 426)
        Me.btnViewCourse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnViewCourse.Name = "btnViewCourse"
        Me.btnViewCourse.Size = New System.Drawing.Size(82, 39)
        Me.btnViewCourse.TabIndex = 7
        Me.btnViewCourse.Text = "View"
        Me.btnViewCourse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 54)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Your Courses"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(459, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 4, 0, 4)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(150, 63)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.mnuProfile, Me.mnuUpload, Me.mnuAbout, Me.mnuLogout})
        Me.ProfileToolStripMenuItem.Image = CType(resources.GetObject("ProfileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProfileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(60, 55)
        '
        'mnuHome
        '
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(216, 26)
        Me.mnuHome.Text = "Home"
        '
        'mnuProfile
        '
        Me.mnuProfile.Name = "mnuProfile"
        Me.mnuProfile.Size = New System.Drawing.Size(216, 26)
        Me.mnuProfile.Text = "Profile"
        '
        'mnuUpload
        '
        Me.mnuUpload.Name = "mnuUpload"
        Me.mnuUpload.Size = New System.Drawing.Size(216, 26)
        Me.mnuUpload.Text = "Upload Materials"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(216, 26)
        Me.mnuAbout.Text = "About us"
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(216, 26)
        Me.mnuLogout.Text = "Log Out"
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
        'dgvCourse
        '
        Me.dgvCourse.AutoGenerateColumns = False
        Me.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCourse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgvCourse.DataSource = Me.Course_DesciptionBindingSource
        Me.dgvCourse.Location = New System.Drawing.Point(87, 118)
        Me.dgvCourse.Name = "dgvCourse"
        Me.dgvCourse.RowHeadersWidth = 51
        Me.dgvCourse.RowTemplate.Height = 23
        Me.dgvCourse.Size = New System.Drawing.Size(459, 259)
        Me.dgvCourse.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Course Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Course Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Link"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Link"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Tutor's Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tutor's Name"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'lblCourseName
        '
        Me.lblCourseName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Course Name", True))
        Me.lblCourseName.Location = New System.Drawing.Point(135, 341)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(100, 23)
        Me.lblCourseName.TabIndex = 14
        Me.lblCourseName.Text = "Label2"
        Me.lblCourseName.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Link", True))
        Me.LinkLabel1.Location = New System.Drawing.Point(135, 367)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(100, 23)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.Text = "Label2"
        Me.LinkLabel1.Visible = False
        '
        'lblDesc
        '
        Me.lblDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Description", True))
        Me.lblDesc.Location = New System.Drawing.Point(135, 393)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(100, 23)
        Me.lblDesc.TabIndex = 18
        Me.lblDesc.Text = "Label2"
        Me.lblDesc.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Status", True))
        Me.lblStatus.Location = New System.Drawing.Point(135, 419)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 23)
        Me.lblStatus.TabIndex = 20
        Me.lblStatus.Text = "Label2"
        Me.lblStatus.Visible = False
        '
        'lblTutoName
        '
        Me.lblTutoName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Tutor's Name", True))
        Me.lblTutoName.Location = New System.Drawing.Point(135, 445)
        Me.lblTutoName.Name = "lblTutoName"
        Me.lblTutoName.Size = New System.Drawing.Size(100, 23)
        Me.lblTutoName.TabIndex = 22
        Me.lblTutoName.Text = "Label2"
        Me.lblTutoName.Visible = False
        '
        'lblPrice
        '
        Me.lblPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Course_DesciptionBindingSource, "Price", True))
        Me.lblPrice.Location = New System.Drawing.Point(135, 471)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 24
        Me.lblPrice.Text = "Label2"
        Me.lblPrice.Visible = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.photo_2022_11_09_15_27_39
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(618, 493)
        Me.Controls.Add(Course_NameLabel)
        Me.Controls.Add(Me.lblCourseName)
        Me.Controls.Add(LinkLabel)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Tutor_s_NameLabel)
        Me.Controls.Add(Me.lblTutoName)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.dgvCourse)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnViewCourse)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Your Courses"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Course_DesciptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnViewCourse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents mnuProfile As ToolStripMenuItem
    Friend WithEvents mnuUpload As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents OmcEduBudDataSet As OmcEduBudDataSet
    Friend WithEvents Field1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Course_DesciptionBindingSource As BindingSource
    Friend WithEvents Course_DesciptionTableAdapter As OmcEduBudDataSetTableAdapters.Course_DesciptionTableAdapter
    Friend WithEvents TableAdapterManager As OmcEduBudDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvCourse As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents lblCourseName As Label
    Friend WithEvents LinkLabel1 As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTutoName As Label
    Friend WithEvents lblPrice As Label
End Class
