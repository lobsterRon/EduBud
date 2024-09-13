<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TutoHomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TutoHomePage))
        Me.lblName = New System.Windows.Forms.Label()
        Me.TutorProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OmcEduBudDataSet = New Oh_My_Code_Edu_Bud.OmcEduBudDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUploaded = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpload = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tutor_ProfileTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Tutor_ProfileTableAdapter()
        CType(Me.TutorProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutorProfileBindingSource, "Name", True))
        Me.lblName.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(67, 118)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(399, 133)
        Me.lblName.TabIndex = 3
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TutorProfileBindingSource
        '
        Me.TutorProfileBindingSource.DataMember = "Tutor Profile"
        Me.TutorProfileBindingSource.DataSource = Me.OmcEduBudDataSet
        '
        'OmcEduBudDataSet
        '
        Me.OmcEduBudDataSet.DataSetName = "OmcEduBudDataSet"
        Me.OmcEduBudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(446, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(64, 53)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.TestToolStripMenuItem.CheckOnClick = True
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProfile, Me.mnuUploaded, Me.mnuUpload, Me.mnuAbout, Me.mnuLogout})
        Me.TestToolStripMenuItem.Image = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.menu_strip_icon
        Me.TestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(58, 49)
        '
        'mnuProfile
        '
        Me.mnuProfile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuProfile.Name = "mnuProfile"
        Me.mnuProfile.Size = New System.Drawing.Size(180, 22)
        Me.mnuProfile.Text = "Profile"
        Me.mnuProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mnuUploaded
        '
        Me.mnuUploaded.Name = "mnuUploaded"
        Me.mnuUploaded.Size = New System.Drawing.Size(180, 22)
        Me.mnuUploaded.Text = "Your Course"
        '
        'mnuUpload
        '
        Me.mnuUpload.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuUpload.Name = "mnuUpload"
        Me.mnuUpload.Size = New System.Drawing.Size(180, 22)
        Me.mnuUpload.Text = "Upload Course"
        Me.mnuUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(180, 22)
        Me.mnuAbout.Text = "About Us"
        '
        'mnuLogout
        '
        Me.mnuLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(180, 22)
        Me.mnuLogout.Text = "Log out"
        Me.mnuLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tutor_ProfileTableAdapter
        '
        Me.Tutor_ProfileTableAdapter.ClearBeforeFill = True
        '
        'TutoHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.photo_2022_11_09_15_27_39
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(518, 292)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "TutoHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutor Home Pages"
        CType(Me.TutorProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents mnuProfile As ToolStripMenuItem
    Friend WithEvents mnuUpload As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents OmcEduBudDataSet As OmcEduBudDataSet
    Friend WithEvents TutorProfileBindingSource As BindingSource
    Friend WithEvents Tutor_ProfileTableAdapter As OmcEduBudDataSetTableAdapters.Tutor_ProfileTableAdapter
    Friend WithEvents mnuUploaded As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
End Class
