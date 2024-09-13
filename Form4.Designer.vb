<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.lblTutoName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.COURSEUPLOADEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCourseStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OmcEduBudDataSet = New Oh_My_Code_Edu_Bud.OmcEduBudDataSet()
        Me.lblNameTuto = New System.Windows.Forms.Label()
        Me.lblProfessionTuto = New System.Windows.Forms.Label()
        Me.lblICTuto = New System.Windows.Forms.Label()
        Me.lblPhoneTuto = New System.Windows.Forms.Label()
        Me.lblEmailTuto = New System.Windows.Forms.Label()
        Me.Tutor_ProfileTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Tutor_ProfileTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TutorProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTutoName
        '
        Me.lblTutoName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTutoName.AutoSize = True
        Me.lblTutoName.Font = New System.Drawing.Font("Segoe Print", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTutoName.Location = New System.Drawing.Point(67, 140)
        Me.lblTutoName.Name = "lblTutoName"
        Me.lblTutoName.Size = New System.Drawing.Size(0, 23)
        Me.lblTutoName.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(117, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 35)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Email :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(117, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 35)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Phone Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(117, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 35)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "IC Number :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 35)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Profession :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 35)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 54)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Tutor's Profile"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COURSEUPLOADEDToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(597, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(163, 64)
        Me.MenuStrip1.TabIndex = 45
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'COURSEUPLOADEDToolStripMenuItem
        '
        Me.COURSEUPLOADEDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ViewCourseStatusToolStripMenuItem, Me.UploadCourseToolStripMenuItem, Me.mnuAbout, Me.LogOutToolStripMenuItem})
        Me.COURSEUPLOADEDToolStripMenuItem.Image = CType(resources.GetObject("COURSEUPLOADEDToolStripMenuItem.Image"), System.Drawing.Image)
        Me.COURSEUPLOADEDToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.COURSEUPLOADEDToolStripMenuItem.Name = "COURSEUPLOADEDToolStripMenuItem"
        Me.COURSEUPLOADEDToolStripMenuItem.Size = New System.Drawing.Size(60, 60)
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ViewCourseStatusToolStripMenuItem
        '
        Me.ViewCourseStatusToolStripMenuItem.Name = "ViewCourseStatusToolStripMenuItem"
        Me.ViewCourseStatusToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ViewCourseStatusToolStripMenuItem.Text = "Your Course"
        '
        'UploadCourseToolStripMenuItem
        '
        Me.UploadCourseToolStripMenuItem.Name = "UploadCourseToolStripMenuItem"
        Me.UploadCourseToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.UploadCourseToolStripMenuItem.Text = "Upload Materials"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(224, 26)
        Me.mnuAbout.Text = "About us"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
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
        'lblNameTuto
        '
        Me.lblNameTuto.BackColor = System.Drawing.Color.Transparent
        Me.lblNameTuto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutorProfileBindingSource, "Name", True))
        Me.lblNameTuto.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameTuto.Location = New System.Drawing.Point(117, 140)
        Me.lblNameTuto.Name = "lblNameTuto"
        Me.lblNameTuto.Size = New System.Drawing.Size(428, 32)
        Me.lblNameTuto.TabIndex = 46
        '
        'lblProfessionTuto
        '
        Me.lblProfessionTuto.BackColor = System.Drawing.Color.Transparent
        Me.lblProfessionTuto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutorProfileBindingSource, "Profession", True))
        Me.lblProfessionTuto.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfessionTuto.Location = New System.Drawing.Point(117, 216)
        Me.lblProfessionTuto.Name = "lblProfessionTuto"
        Me.lblProfessionTuto.Size = New System.Drawing.Size(428, 32)
        Me.lblProfessionTuto.TabIndex = 47
        '
        'lblICTuto
        '
        Me.lblICTuto.BackColor = System.Drawing.Color.Transparent
        Me.lblICTuto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutorProfileBindingSource, "IC Number", True))
        Me.lblICTuto.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblICTuto.Location = New System.Drawing.Point(117, 279)
        Me.lblICTuto.Name = "lblICTuto"
        Me.lblICTuto.Size = New System.Drawing.Size(428, 32)
        Me.lblICTuto.TabIndex = 48
        '
        'lblPhoneTuto
        '
        Me.lblPhoneTuto.BackColor = System.Drawing.Color.Transparent
        Me.lblPhoneTuto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutorProfileBindingSource, "Phone Number", True))
        Me.lblPhoneTuto.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneTuto.Location = New System.Drawing.Point(117, 340)
        Me.lblPhoneTuto.Name = "lblPhoneTuto"
        Me.lblPhoneTuto.Size = New System.Drawing.Size(428, 32)
        Me.lblPhoneTuto.TabIndex = 49
        '
        'lblEmailTuto
        '
        Me.lblEmailTuto.BackColor = System.Drawing.Color.Transparent
        Me.lblEmailTuto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutorProfileBindingSource, "Email", True))
        Me.lblEmailTuto.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailTuto.Location = New System.Drawing.Point(117, 410)
        Me.lblEmailTuto.Name = "lblEmailTuto"
        Me.lblEmailTuto.Size = New System.Drawing.Size(428, 32)
        Me.lblEmailTuto.TabIndex = 50
        '
        'Tutor_ProfileTableAdapter
        '
        Me.Tutor_ProfileTableAdapter.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.photo_2022_11_09_15_27_39
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(769, 510)
        Me.Controls.Add(Me.lblEmailTuto)
        Me.Controls.Add(Me.lblPhoneTuto)
        Me.Controls.Add(Me.lblICTuto)
        Me.Controls.Add(Me.lblProfessionTuto)
        Me.Controls.Add(Me.lblNameTuto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblTutoName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutor Profile"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TutorProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTutoName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents COURSEUPLOADEDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UploadCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCourseStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNameTuto As Label
    Friend WithEvents lblProfessionTuto As Label
    Friend WithEvents lblICTuto As Label
    Friend WithEvents lblPhoneTuto As Label
    Friend WithEvents lblEmailTuto As Label
    Friend WithEvents OmcEduBudDataSet As OmcEduBudDataSet
    Friend WithEvents TutorProfileBindingSource As BindingSource
    Friend WithEvents Tutor_ProfileTableAdapter As OmcEduBudDataSetTableAdapters.Tutor_ProfileTableAdapter
    Friend WithEvents mnuAbout As ToolStripMenuItem
End Class
