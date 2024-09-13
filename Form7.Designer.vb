<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Dim Student_NameLabel As System.Windows.Forms.Label
        Dim Course_NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.rdbtn2 = New System.Windows.Forms.RadioButton()
        Me.rdbtn1 = New System.Windows.Forms.RadioButton()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.mskCVV = New System.Windows.Forms.MaskedTextBox()
        Me.txtbox1 = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.OmcEduBudDataSet = New Oh_My_Code_Edu_Bud.OmcEduBudDataSet()
        Me.Subscription_recordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Subscription_recordTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Subscription_recordTableAdapter()
        Me.TableAdapterManager = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.TableAdapterManager()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblCourseName = New System.Windows.Forms.Label()
        Student_NameLabel = New System.Windows.Forms.Label()
        Course_NameLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Subscription_recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_NameLabel
        '
        Student_NameLabel.AutoSize = True
        Student_NameLabel.BackColor = System.Drawing.Color.Transparent
        Student_NameLabel.Font = New System.Drawing.Font("Segoe Print", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_NameLabel.ForeColor = System.Drawing.Color.Black
        Student_NameLabel.Location = New System.Drawing.Point(41, 93)
        Student_NameLabel.Name = "Student_NameLabel"
        Student_NameLabel.Size = New System.Drawing.Size(150, 31)
        Student_NameLabel.TabIndex = 46
        Student_NameLabel.Text = "Student Name:"
        '
        'Course_NameLabel
        '
        Course_NameLabel.AutoSize = True
        Course_NameLabel.BackColor = System.Drawing.Color.Transparent
        Course_NameLabel.Font = New System.Drawing.Font("Segoe Print", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Course_NameLabel.ForeColor = System.Drawing.Color.Black
        Course_NameLabel.Location = New System.Drawing.Point(41, 133)
        Course_NameLabel.Name = "Course_NameLabel"
        Course_NameLabel.Size = New System.Drawing.Size(139, 31)
        Course_NameLabel.TabIndex = 48
        Course_NameLabel.Text = "Course Name:"
        '
        'rdbtn2
        '
        Me.rdbtn2.AutoSize = True
        Me.rdbtn2.BackColor = System.Drawing.Color.Transparent
        Me.rdbtn2.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtn2.Location = New System.Drawing.Point(400, 533)
        Me.rdbtn2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbtn2.Name = "rdbtn2"
        Me.rdbtn2.Size = New System.Drawing.Size(128, 30)
        Me.rdbtn2.TabIndex = 40
        Me.rdbtn2.TabStop = True
        Me.rdbtn2.Text = "Master Card"
        Me.rdbtn2.UseVisualStyleBackColor = False
        '
        'rdbtn1
        '
        Me.rdbtn1.AutoSize = True
        Me.rdbtn1.BackColor = System.Drawing.Color.Transparent
        Me.rdbtn1.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtn1.Location = New System.Drawing.Point(118, 533)
        Me.rdbtn1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbtn1.Name = "rdbtn1"
        Me.rdbtn1.Size = New System.Drawing.Size(63, 30)
        Me.rdbtn1.TabIndex = 39
        Me.rdbtn1.TabStop = True
        Me.rdbtn1.Text = "Visa"
        Me.rdbtn1.UseVisualStyleBackColor = False
        '
        'txtbox2
        '
        Me.txtbox2.Font = New System.Drawing.Font("Segoe Print", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox2.Location = New System.Drawing.Point(204, 244)
        Me.txtbox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(431, 38)
        Me.txtbox2.TabIndex = 38
        '
        'mskCVV
        '
        Me.mskCVV.Font = New System.Drawing.Font("Segoe Print", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCVV.Location = New System.Drawing.Point(204, 303)
        Me.mskCVV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskCVV.Mask = "###"
        Me.mskCVV.Name = "mskCVV"
        Me.mskCVV.Size = New System.Drawing.Size(53, 38)
        Me.mskCVV.TabIndex = 37
        '
        'txtbox1
        '
        Me.txtbox1.Font = New System.Drawing.Font("Segoe Print", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox1.Location = New System.Drawing.Point(204, 184)
        Me.txtbox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(431, 38)
        Me.txtbox1.TabIndex = 35
        '
        'btnsubmit
        '
        Me.btnsubmit.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Location = New System.Drawing.Point(185, 596)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(128, 39)
        Me.btnsubmit.TabIndex = 34
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(42, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 30)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Expiry Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(42, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 30)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "CVV :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(42, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 30)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Name On Card :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(42, 244)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 30)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Card Number :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(67, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(568, 30)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Please fill in the the details below to complete your registration"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(118, 415)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(181, 112)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(400, 415)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(204, 363)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(317, 34)
        Me.DateTimePicker1.TabIndex = 43
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(377, 596)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(128, 39)
        Me.btnBack.TabIndex = 44
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'OmcEduBudDataSet
        '
        Me.OmcEduBudDataSet.DataSetName = "OmcEduBudDataSet"
        Me.OmcEduBudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Subscription_recordBindingSource
        '
        Me.Subscription_recordBindingSource.DataMember = "Subscription record"
        Me.Subscription_recordBindingSource.DataSource = Me.OmcEduBudDataSet
        '
        'Subscription_recordTableAdapter
        '
        Me.Subscription_recordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Course_DesciptionTableAdapter = Nothing
        Me.TableAdapterManager.Student_ProfileTableAdapter = Nothing
        Me.TableAdapterManager.Subscription_recordTableAdapter = Me.Subscription_recordTableAdapter
        Me.TableAdapterManager.Tutor_ProfileTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Subscription_recordBindingSource, "Student Name", True))
        Me.lblStudentName.Font = New System.Drawing.Font("Segoe Print", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.Black
        Me.lblStudentName.Location = New System.Drawing.Point(206, 93)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(73, 31)
        Me.lblStudentName.TabIndex = 47
        Me.lblStudentName.Text = "Label6"
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCourseName
        '
        Me.lblCourseName.AutoSize = True
        Me.lblCourseName.BackColor = System.Drawing.Color.Transparent
        Me.lblCourseName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Subscription_recordBindingSource, "Course Name", True))
        Me.lblCourseName.Font = New System.Drawing.Font("Segoe Print", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseName.ForeColor = System.Drawing.Color.Black
        Me.lblCourseName.Location = New System.Drawing.Point(206, 133)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(73, 31)
        Me.lblCourseName.TabIndex = 49
        Me.lblCourseName.Text = "Label6"
        Me.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.photo_2022_11_09_15_27_39
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(689, 663)
        Me.Controls.Add(Student_NameLabel)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Course_NameLabel)
        Me.Controls.Add(Me.lblCourseName)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rdbtn2)
        Me.Controls.Add(Me.rdbtn1)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.mskCVV)
        Me.Controls.Add(Me.txtbox1)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subscription"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Subscription_recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rdbtn2 As RadioButton
    Friend WithEvents rdbtn1 As RadioButton
    Friend WithEvents txtbox2 As TextBox
    Friend WithEvents mskCVV As MaskedTextBox
    Friend WithEvents txtbox1 As TextBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnBack As Button
    Friend WithEvents OmcEduBudDataSet As OmcEduBudDataSet
    Friend WithEvents Subscription_recordBindingSource As BindingSource
    Friend WithEvents Subscription_recordTableAdapter As OmcEduBudDataSetTableAdapters.Subscription_recordTableAdapter
    Friend WithEvents TableAdapterManager As OmcEduBudDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblCourseName As Label
End Class
