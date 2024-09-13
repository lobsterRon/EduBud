<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.StudentProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OmcEduBudDataSet = New Oh_My_Code_Edu_Bud.OmcEduBudDataSet()
        Me.lblStuEmail = New System.Windows.Forms.Label()
        Me.lblStuNum = New System.Windows.Forms.Label()
        Me.lblStuIc = New System.Windows.Forms.Label()
        Me.lblStuName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
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
        'lblStuEmail
        '
        Me.lblStuEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblStuEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentProfileBindingSource, "Email", True))
        Me.lblStuEmail.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuEmail.Location = New System.Drawing.Point(121, 389)
        Me.lblStuEmail.Name = "lblStuEmail"
        Me.lblStuEmail.Size = New System.Drawing.Size(401, 28)
        Me.lblStuEmail.TabIndex = 52
        '
        'lblStuNum
        '
        Me.lblStuNum.BackColor = System.Drawing.Color.Transparent
        Me.lblStuNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentProfileBindingSource, "Phone Number", True))
        Me.lblStuNum.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuNum.Location = New System.Drawing.Point(121, 318)
        Me.lblStuNum.Name = "lblStuNum"
        Me.lblStuNum.Size = New System.Drawing.Size(401, 28)
        Me.lblStuNum.TabIndex = 51
        '
        'lblStuIc
        '
        Me.lblStuIc.BackColor = System.Drawing.Color.Transparent
        Me.lblStuIc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentProfileBindingSource, "IC Number", True))
        Me.lblStuIc.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuIc.Location = New System.Drawing.Point(121, 246)
        Me.lblStuIc.Name = "lblStuIc"
        Me.lblStuIc.Size = New System.Drawing.Size(401, 28)
        Me.lblStuIc.TabIndex = 50
        '
        'lblStuName
        '
        Me.lblStuName.BackColor = System.Drawing.Color.Transparent
        Me.lblStuName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentProfileBindingSource, "Name", True))
        Me.lblStuName.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuName.Location = New System.Drawing.Point(121, 174)
        Me.lblStuName.Name = "lblStuName"
        Me.lblStuName.Size = New System.Drawing.Size(401, 28)
        Me.lblStuName.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(105, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 35)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Email :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 35)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "IC Number :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 35)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Phone Number :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 35)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 54)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Student's Profile"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(683, 8)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(68, 53)
        Me.MenuStrip1.TabIndex = 58
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.TestToolStripMenuItem.CheckOnClick = True
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.mnuSubscription, Me.mnuSearch, Me.mnuAbout, Me.mnuLogout})
        Me.TestToolStripMenuItem.Image = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.menu_strip_icon
        Me.TestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(60, 49)
        '
        'mnuHome
        '
        Me.mnuHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mnuHome.Size = New System.Drawing.Size(196, 26)
        Me.mnuHome.Text = "Home"
        '
        'mnuSubscription
        '
        Me.mnuSubscription.Name = "mnuSubscription"
        Me.mnuSubscription.Size = New System.Drawing.Size(196, 26)
        Me.mnuSubscription.Text = "Subscription"
        '
        'mnuSearch
        '
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.Size = New System.Drawing.Size(196, 26)
        Me.mnuSearch.Text = "Search Course"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(196, 26)
        Me.mnuAbout.Text = "About us"
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(196, 26)
        Me.mnuLogout.Text = "Log out"
        '
        'Student_ProfileTableAdapter
        '
        Me.Student_ProfileTableAdapter.ClearBeforeFill = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.photo_2022_11_09_15_27_39
        Me.ClientSize = New System.Drawing.Size(763, 485)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblStuEmail)
        Me.Controls.Add(Me.lblStuNum)
        Me.Controls.Add(Me.lblStuIc)
        Me.Controls.Add(Me.lblStuName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Profile"
        CType(Me.StudentProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStuEmail As Label
    Friend WithEvents lblStuNum As Label
    Friend WithEvents lblStuIc As Label
    Friend WithEvents lblStuName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents mnuSubscription As ToolStripMenuItem
    Friend WithEvents mnuSearch As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OmcEduBudDataSet As OmcEduBudDataSet
    Friend WithEvents StudentProfileBindingSource As BindingSource
    Friend WithEvents Student_ProfileTableAdapter As OmcEduBudDataSetTableAdapters.Student_ProfileTableAdapter
    Friend WithEvents mnuAbout As ToolStripMenuItem
End Class
