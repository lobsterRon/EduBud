<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtStudent = New System.Windows.Forms.RadioButton()
        Me.rbtTutor = New System.Windows.Forms.RadioButton()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OmcEduBudDataSet = New Oh_My_Code_Edu_Bud.OmcEduBudDataSet()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.Student_ProfileTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Student_ProfileTableAdapter()
        Me.TableAdapterManager = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.TableAdapterManager()
        Me.Tutor_ProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tutor_ProfileTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Tutor_ProfileTableAdapter()
        Me.dgvTutor = New System.Windows.Forms.DataGridView()
        Me.TutorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ICNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tutor_ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTutor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(243, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 18)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Haven't Register?"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(47, 415)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 31)
        Me.btnClose.TabIndex = 42
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.Logo_OMC_2
        Me.PictureBox1.Location = New System.Drawing.Point(330, 39)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbtStudent)
        Me.GroupBox1.Controls.Add(Me.rbtTutor)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Print", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 293)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(179, 115)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Role"
        '
        'rbtStudent
        '
        Me.rbtStudent.AutoSize = True
        Me.rbtStudent.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtStudent.Location = New System.Drawing.Point(31, 32)
        Me.rbtStudent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbtStudent.Name = "rbtStudent"
        Me.rbtStudent.Size = New System.Drawing.Size(109, 30)
        Me.rbtStudent.TabIndex = 7
        Me.rbtStudent.TabStop = True
        Me.rbtStudent.Text = "STUDENT"
        Me.rbtStudent.UseVisualStyleBackColor = True
        '
        'rbtTutor
        '
        Me.rbtTutor.AutoSize = True
        Me.rbtTutor.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtTutor.Location = New System.Drawing.Point(31, 68)
        Me.rbtTutor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbtTutor.Name = "rbtTutor"
        Me.rbtTutor.Size = New System.Drawing.Size(88, 30)
        Me.rbtTutor.TabIndex = 8
        Me.rbtTutor.TabStop = True
        Me.rbtTutor.Text = "TUTOR"
        Me.rbtTutor.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(149, 251)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(319, 38)
        Me.txtPassword.TabIndex = 39
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsername.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(149, 195)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(319, 38)
        Me.txtUsername.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 30)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Password :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 30)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Username :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 130)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "WELCOME TO EDU BUD"
        '
        'btnSign
        '
        Me.btnSign.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSign.Enabled = False
        Me.btnSign.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSign.Location = New System.Drawing.Point(305, 316)
        Me.btnSign.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(100, 48)
        Me.btnSign.TabIndex = 34
        Me.btnSign.Text = "SIGN IN"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRegister.Enabled = False
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Arial", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegister.Location = New System.Drawing.Point(363, 372)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(133, 34)
        Me.btnRegister.TabIndex = 33
        Me.btnRegister.Text = "CLICK HERE"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'dgvStudent
        '
        Me.dgvStudent.AutoGenerateColumns = False
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgvStudent.DataSource = Me.StudentProfileBindingSource
        Me.dgvStudent.Location = New System.Drawing.Point(51, 39)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.RowHeadersWidth = 51
        Me.dgvStudent.RowTemplate.Height = 27
        Me.dgvStudent.Size = New System.Drawing.Size(256, 164)
        Me.dgvStudent.TabIndex = 43
        Me.dgvStudent.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Student ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IC Number"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IC Number"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Phone Number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Phone Number"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
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
        'btnPassword
        '
        Me.btnPassword.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.view
        Me.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPassword.Location = New System.Drawing.Point(474, 251)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(43, 41)
        Me.btnPassword.TabIndex = 48
        Me.btnPassword.UseVisualStyleBackColor = True
        '
        'Student_ProfileTableAdapter
        '
        Me.Student_ProfileTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Course_DesciptionTableAdapter = Nothing
        Me.TableAdapterManager.Student_ProfileTableAdapter = Me.Student_ProfileTableAdapter
        Me.TableAdapterManager.Subscription_recordTableAdapter = Nothing
        Me.TableAdapterManager.Tutor_ProfileTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tutor_ProfileBindingSource
        '
        Me.Tutor_ProfileBindingSource.DataMember = "Tutor Profile"
        Me.Tutor_ProfileBindingSource.DataSource = Me.OmcEduBudDataSet
        '
        'Tutor_ProfileTableAdapter
        '
        Me.Tutor_ProfileTableAdapter.ClearBeforeFill = True
        '
        'dgvTutor
        '
        Me.dgvTutor.AutoGenerateColumns = False
        Me.dgvTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTutor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TutorIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.ProfessionDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.ICNumberDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn})
        Me.dgvTutor.DataSource = Me.Tutor_ProfileBindingSource
        Me.dgvTutor.Location = New System.Drawing.Point(97, 214)
        Me.dgvTutor.Name = "dgvTutor"
        Me.dgvTutor.RowHeadersWidth = 51
        Me.dgvTutor.RowTemplate.Height = 27
        Me.dgvTutor.Size = New System.Drawing.Size(240, 150)
        Me.dgvTutor.TabIndex = 49
        Me.dgvTutor.Visible = False
        '
        'TutorIDDataGridViewTextBoxColumn
        '
        Me.TutorIDDataGridViewTextBoxColumn.DataPropertyName = "Tutor ID"
        Me.TutorIDDataGridViewTextBoxColumn.HeaderText = "Tutor ID"
        Me.TutorIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TutorIDDataGridViewTextBoxColumn.Name = "TutorIDDataGridViewTextBoxColumn"
        Me.TutorIDDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'ProfessionDataGridViewTextBoxColumn
        '
        Me.ProfessionDataGridViewTextBoxColumn.DataPropertyName = "Profession"
        Me.ProfessionDataGridViewTextBoxColumn.HeaderText = "Profession"
        Me.ProfessionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProfessionDataGridViewTextBoxColumn.Name = "ProfessionDataGridViewTextBoxColumn"
        Me.ProfessionDataGridViewTextBoxColumn.Width = 125
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.Width = 125
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.Width = 125
        '
        'ICNumberDataGridViewTextBoxColumn
        '
        Me.ICNumberDataGridViewTextBoxColumn.DataPropertyName = "IC Number"
        Me.ICNumberDataGridViewTextBoxColumn.HeaderText = "IC Number"
        Me.ICNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ICNumberDataGridViewTextBoxColumn.Name = "ICNumberDataGridViewTextBoxColumn"
        Me.ICNumberDataGridViewTextBoxColumn.Width = 125
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.photo_2022_11_09_15_27_39
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(538, 484)
        Me.Controls.Add(Me.dgvTutor)
        Me.Controls.Add(Me.btnPassword)
        Me.Controls.Add(Me.dgvStudent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.btnRegister)
        Me.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDU BUD"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tutor_ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTutor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OmcEduBudDataSet As OmcEduBudDataSet
    Friend WithEvents StudentProfileBindingSource As BindingSource
    Friend WithEvents Student_ProfileTableAdapter As OmcEduBudDataSetTableAdapters.Student_ProfileTableAdapter
    Friend WithEvents TableAdapterManager As OmcEduBudDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtStudent As RadioButton
    Friend WithEvents rbtTutor As RadioButton
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSign As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents btnPassword As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Tutor_ProfileBindingSource As BindingSource
    Friend WithEvents Tutor_ProfileTableAdapter As OmcEduBudDataSetTableAdapters.Tutor_ProfileTableAdapter
    Friend WithEvents dgvTutor As DataGridView
    Friend WithEvents TutorIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProfessionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ICNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
