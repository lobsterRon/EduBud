<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentHomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentHomePage))
        Me.lblName = New System.Windows.Forms.Label()
        Me.StudentProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OmcEduBudDataSet = New Oh_My_Code_Edu_Bud.OmcEduBudDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSubscription = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Student_ProfileTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Student_ProfileTableAdapter()
        CType(Me.StudentProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(115, 136)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(411, 172)
        Me.lblName.TabIndex = 33
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentProfileBindingSource
        '
        Me.StudentProfileBindingSource.DataMember = "Student Profile"
        Me.StudentProfileBindingSource.DataSource = Me.OmcEduBudDataSet
        '
        'OmcEduBudDataSet
        '
        Me.OmcEduBudDataSet.DataSetName = "OmcEduBudDataSet"
        Me.OmcEduBudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 54)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Welcome"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(571, 11)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(68, 53)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.TestToolStripMenuItem.CheckOnClick = True
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProfile, Me.mnuSubscription, Me.mnuSearch, Me.mnuAbout, Me.mnuLogout})
        Me.TestToolStripMenuItem.Image = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.menu_strip_icon
        Me.TestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(60, 49)
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
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(196, 26)
        Me.mnuAbout.Text = "About Us"
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
        'Student_ProfileTableAdapter
        '
        Me.Student_ProfileTableAdapter.ClearBeforeFill = True
        '
        'StudentHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.photo_2022_11_09_15_27_39
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(651, 358)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "StudentHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Home Page"
        CType(Me.StudentProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSubscription As ToolStripMenuItem
    Friend WithEvents mnuSearch As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents mnuProfile As ToolStripMenuItem
    Friend WithEvents OmcEduBudDataSet As OmcEduBudDataSet
    Friend WithEvents StudentProfileBindingSource As BindingSource
    Friend WithEvents Student_ProfileTableAdapter As OmcEduBudDataSetTableAdapters.Student_ProfileTableAdapter
    Friend WithEvents mnuAbout As ToolStripMenuItem
End Class
