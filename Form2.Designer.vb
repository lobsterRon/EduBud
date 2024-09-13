<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCreateConfirm = New System.Windows.Forms.TextBox()
        Me.btnStuCreate = New System.Windows.Forms.Button()
        Me.StudentProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OmcEduBudDataSet = New Oh_My_Code_Edu_Bud.OmcEduBudDataSet()
        Me.txtCreateSP = New System.Windows.Forms.TextBox()
        Me.txtCreateSU = New System.Windows.Forms.TextBox()
        Me.txtCreateSE = New System.Windows.Forms.TextBox()
        Me.txtCreateSN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Student_ProfileTableAdapter = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.Student_ProfileTableAdapter()
        Me.TableAdapterManager = New Oh_My_Code_Edu_Bud.OmcEduBudDataSetTableAdapters.TableAdapterManager()
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mskIC = New System.Windows.Forms.MaskedTextBox()
        Me.mskPhone = New System.Windows.Forms.MaskedTextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.StudentProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.CausesValidation = False
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 490)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 30)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Confirm Password"
        '
        'txtCreateConfirm
        '
        Me.txtCreateConfirm.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCreateConfirm.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateConfirm.Location = New System.Drawing.Point(37, 522)
        Me.txtCreateConfirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCreateConfirm.Name = "txtCreateConfirm"
        Me.txtCreateConfirm.Size = New System.Drawing.Size(286, 34)
        Me.txtCreateConfirm.TabIndex = 56
        '
        'btnStuCreate
        '
        Me.btnStuCreate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnStuCreate.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStuCreate.Location = New System.Drawing.Point(379, 447)
        Me.btnStuCreate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStuCreate.Name = "btnStuCreate"
        Me.btnStuCreate.Size = New System.Drawing.Size(133, 38)
        Me.btnStuCreate.TabIndex = 54
        Me.btnStuCreate.Text = "Create"
        Me.btnStuCreate.UseVisualStyleBackColor = True
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
        'txtCreateSP
        '
        Me.txtCreateSP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCreateSP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentProfileBindingSource, "Password", True))
        Me.txtCreateSP.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateSP.Location = New System.Drawing.Point(37, 451)
        Me.txtCreateSP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCreateSP.Name = "txtCreateSP"
        Me.txtCreateSP.Size = New System.Drawing.Size(286, 34)
        Me.txtCreateSP.TabIndex = 52
        '
        'txtCreateSU
        '
        Me.txtCreateSU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCreateSU.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentProfileBindingSource, "Username", True))
        Me.txtCreateSU.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateSU.Location = New System.Drawing.Point(39, 380)
        Me.txtCreateSU.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCreateSU.Name = "txtCreateSU"
        Me.txtCreateSU.Size = New System.Drawing.Size(284, 34)
        Me.txtCreateSU.TabIndex = 51
        '
        'txtCreateSE
        '
        Me.txtCreateSE.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCreateSE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentProfileBindingSource, "Email", True))
        Me.txtCreateSE.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateSE.Location = New System.Drawing.Point(39, 309)
        Me.txtCreateSE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCreateSE.Name = "txtCreateSE"
        Me.txtCreateSE.Size = New System.Drawing.Size(284, 34)
        Me.txtCreateSE.TabIndex = 49
        '
        'txtCreateSN
        '
        Me.txtCreateSN.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCreateSN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentProfileBindingSource, "Name", True))
        Me.txtCreateSN.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateSN.Location = New System.Drawing.Point(39, 94)
        Me.txtCreateSN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCreateSN.Name = "txtCreateSN"
        Me.txtCreateSN.Size = New System.Drawing.Size(284, 34)
        Me.txtCreateSN.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 276)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 30)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Email        "
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 205)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 30)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Telephone No"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 419)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 30)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Password  "
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 30)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "IC Number      "
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 40)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "STUDENT REGISTRATION"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 348)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 30)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Username    "
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 30)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Name "
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
        'dgvStudent
        '
        Me.dgvStudent.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvStudent.AutoGenerateColumns = False
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgvStudent.DataSource = Me.StudentProfileBindingSource
        Me.dgvStudent.Location = New System.Drawing.Point(190, 139)
        Me.dgvStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.RowHeadersWidth = 51
        Me.dgvStudent.RowTemplate.Height = 23
        Me.dgvStudent.Size = New System.Drawing.Size(400, 275)
        Me.dgvStudent.TabIndex = 58
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
        'mskIC
        '
        Me.mskIC.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.mskIC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentProfileBindingSource, "IC Number", True))
        Me.mskIC.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskIC.Location = New System.Drawing.Point(39, 167)
        Me.mskIC.Mask = "######-##-####"
        Me.mskIC.Name = "mskIC"
        Me.mskIC.Size = New System.Drawing.Size(284, 34)
        Me.mskIC.TabIndex = 59
        '
        'mskPhone
        '
        Me.mskPhone.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.mskPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentProfileBindingSource, "Phone Number", True))
        Me.mskPhone.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskPhone.Location = New System.Drawing.Point(39, 239)
        Me.mskPhone.Mask = "###-########"
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(284, 34)
        Me.mskPhone.TabIndex = 64
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnBack.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(379, 522)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(133, 38)
        Me.btnBack.TabIndex = 65
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.Logo_OMC_2
        Me.PictureBox1.Location = New System.Drawing.Point(379, 94)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Oh_My_Code_Edu_Bud.My.Resources.Resources.photo_2022_11_09_15_27_39
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(589, 584)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.mskPhone)
        Me.Controls.Add(Me.mskIC)
        Me.Controls.Add(Me.dgvStudent)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCreateConfirm)
        Me.Controls.Add(Me.btnStuCreate)
        Me.Controls.Add(Me.txtCreateSP)
        Me.Controls.Add(Me.txtCreateSU)
        Me.Controls.Add(Me.txtCreateSE)
        Me.Controls.Add(Me.txtCreateSN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENT REGISTRATION"
        CType(Me.StudentProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OmcEduBudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCreateConfirm As TextBox
    Friend WithEvents btnStuCreate As Button
    Friend WithEvents txtCreateSP As TextBox
    Friend WithEvents txtCreateSU As TextBox
    Friend WithEvents txtCreateSE As TextBox
    Friend WithEvents txtCreateSN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OmcEduBudDataSet As OmcEduBudDataSet
    Friend WithEvents StudentProfileBindingSource As BindingSource
    Friend WithEvents Student_ProfileTableAdapter As OmcEduBudDataSetTableAdapters.Student_ProfileTableAdapter
    Friend WithEvents TableAdapterManager As OmcEduBudDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents mskIC As MaskedTextBox
    Friend WithEvents mskPhone As MaskedTextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
