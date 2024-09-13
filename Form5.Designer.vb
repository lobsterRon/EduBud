<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.CourseDesciptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OmcEduBudDataSet = New Oh_My_Code_Edu_Bud.OmcEduBudDataSet()
        Me.txtLink = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUploadM = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mneUploadedMaterial = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Course_DesciptionTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Course_DesciptionTableAdapter()
        Me.TableAdapterManager = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.TableAdapterManager()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTutoName = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.CourseDesciptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourseDesciptionBindingSource, "Price", True))
        Me.txtPrice.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txtPrice.Location = New System.Drawing.Point(292, 451)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(439, 38)
        Me.txtPrice.TabIndex = 48
        '
        'CourseDesciptionBindingSource
        '
        Me.CourseDesciptionBindingSource.DataMember = "Course Desciption"
        Me.CourseDesciptionBindingSource.DataSource = Me.OmcEduBudDataSet
        '
        'OmcEduBudDataSet
        '
        Me.OmcEduBudDataSet.DataSetName = "OmcEduBudDataSet"
        Me.OmcEduBudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtLink
        '
        Me.txtLink.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLink.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourseDesciptionBindingSource, "Link", True))
        Me.txtLink.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txtLink.Location = New System.Drawing.Point(292, 401)
        Me.txtLink.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLink.Name = "txtLink"
        Me.txtLink.Size = New System.Drawing.Size(439, 38)
        Me.txtLink.TabIndex = 47
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourseDesciptionBindingSource, "Description", True))
        Me.txtDescription.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txtDescription.Location = New System.Drawing.Point(98, 241)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(633, 122)
        Me.txtDescription.TabIndex = 45
        '
        'txtCourse
        '
        Me.txtCourse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCourse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourseDesciptionBindingSource, "Course Name", True))
        Me.txtCourse.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txtCourse.Location = New System.Drawing.Point(290, 155)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(439, 38)
        Me.txtCourse.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(102, 451)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 30)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Course's Price  :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(102, 401)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 30)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Course's Link   :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(91, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 30)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Course Description :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(91, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 30)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Course Name   :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 40)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Upload Materials"
        '
        'btnUploadM
        '
        Me.btnUploadM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUploadM.Font = New System.Drawing.Font("Segoe Print", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadM.Location = New System.Drawing.Point(600, 554)
        Me.btnUploadM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUploadM.Name = "btnUploadM"
        Me.btnUploadM.Size = New System.Drawing.Size(133, 35)
        Me.btnUploadM.TabIndex = 52
        Me.btnUploadM.Text = "UPLOAD"
        Me.btnUploadM.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(719, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(68, 53)
        Me.MenuStrip1.TabIndex = 54
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TestToolStripMenuItem.CheckOnClick = True
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.mnuProfile, Me.mneUploadedMaterial, Me.mnuAbout, Me.mnuLogout})
        Me.TestToolStripMenuItem.Image = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.menu_strip_icon
        Me.TestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(60, 49)
        '
        'mnuHome
        '
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(181, 26)
        Me.mnuHome.Text = "Home"
        '
        'mnuProfile
        '
        Me.mnuProfile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuProfile.Name = "mnuProfile"
        Me.mnuProfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mnuProfile.Size = New System.Drawing.Size(181, 26)
        Me.mnuProfile.Text = "Profile"
        '
        'mneUploadedMaterial
        '
        Me.mneUploadedMaterial.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mneUploadedMaterial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mneUploadedMaterial.Name = "mneUploadedMaterial"
        Me.mneUploadedMaterial.Size = New System.Drawing.Size(181, 26)
        Me.mneUploadedMaterial.Text = "Your Course"
        Me.mneUploadedMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(181, 26)
        Me.mnuAbout.Text = "About us"
        '
        'mnuLogout
        '
        Me.mnuLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(181, 26)
        Me.mnuLogout.Text = "Log out"
        Me.mnuLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(93, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 30)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Tutor's Name   :"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(160, 519)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 30)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Status  :"
        '
        'lblTutoName
        '
        Me.lblTutoName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTutoName.AutoSize = True
        Me.lblTutoName.BackColor = System.Drawing.Color.Transparent
        Me.lblTutoName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourseDesciptionBindingSource, "Tutor's Name", True))
        Me.lblTutoName.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTutoName.Location = New System.Drawing.Point(287, 103)
        Me.lblTutoName.Name = "lblTutoName"
        Me.lblTutoName.Size = New System.Drawing.Size(70, 30)
        Me.lblTutoName.TabIndex = 62
        Me.lblTutoName.Text = "Label9"
        Me.lblTutoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CourseDesciptionBindingSource, "Status", True))
        Me.lblStatus.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(287, 519)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(70, 30)
        Me.lblStatus.TabIndex = 63
        Me.lblStatus.Text = "Label9"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form5
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.photo_2022_11_09_15_27_39
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(808, 629)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblTutoName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnUploadM)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtLink)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upload Materials"
        CType(Me.CourseDesciptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtLink As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUploadM As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents mnuProfile As ToolStripMenuItem
    Friend WithEvents mneUploadedMaterial As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents OmcEduBudDataSet As OmcEduBudDataSet
    Friend WithEvents CourseDesciptionBindingSource As BindingSource
    Friend WithEvents Course_DesciptionTableAdapter As OmcEduBudDataSetTableAdapters.Course_DesciptionTableAdapter
    Friend WithEvents TableAdapterManager As OmcEduBudDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTutoName As Label
    Friend WithEvents lblStatus As Label
End Class
