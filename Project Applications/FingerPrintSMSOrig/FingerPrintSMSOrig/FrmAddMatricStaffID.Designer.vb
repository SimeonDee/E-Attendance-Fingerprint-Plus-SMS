<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddMatricStaffID
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.lstGenerated = New System.Windows.Forms.ListBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.radStaff = New System.Windows.Forms.RadioButton
        Me.radStudent = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grpStudents = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnGenerateMatric = New System.Windows.Forms.Button
        Me.txtStudentNumber = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtStudentStart = New System.Windows.Forms.TextBox
        Me.lblMatricStartPath = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboSession = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboProgram = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboLevel = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboStudentDept = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpStaff = New System.Windows.Forms.GroupBox
        Me.cboStaffCategory = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnGenerateStaffID = New System.Windows.Forms.Button
        Me.txtStaffNumber = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtStaffStart = New System.Windows.Forms.TextBox
        Me.lblIDStartPath = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboStaffDept = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpStudents.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.grpStaff.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.lstGenerated)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Location = New System.Drawing.Point(17, 45)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(684, 367)
        Me.Panel5.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(511, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "GENERATED NUMBERS"
        '
        'lstGenerated
        '
        Me.lstGenerated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGenerated.FormattingEnabled = True
        Me.lstGenerated.Location = New System.Drawing.Point(511, 85)
        Me.lstGenerated.Name = "lstGenerated"
        Me.lstGenerated.Size = New System.Drawing.Size(153, 212)
        Me.lstGenerated.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnExit)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Location = New System.Drawing.Point(500, 311)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(174, 42)
        Me.Panel4.TabIndex = 18
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(102, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(58, 26)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(9, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 27)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.radStaff)
        Me.Panel3.Controls.Add(Me.radStudent)
        Me.Panel3.Location = New System.Drawing.Point(8, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(666, 47)
        Me.Panel3.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Select what to Add:"
        '
        'radStaff
        '
        Me.radStaff.AutoSize = True
        Me.radStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStaff.Location = New System.Drawing.Point(432, 13)
        Me.radStaff.Name = "radStaff"
        Me.radStaff.Size = New System.Drawing.Size(82, 22)
        Me.radStaff.TabIndex = 3
        Me.radStaff.TabStop = True
        Me.radStaff.Text = "Staff ID"
        Me.radStaff.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStudent.Location = New System.Drawing.Point(156, 15)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(208, 22)
        Me.radStudent.TabIndex = 2
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "Students Matric Number"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.grpStudents)
        Me.Panel1.Controls.Add(Me.grpStaff)
        Me.Panel1.Location = New System.Drawing.Point(8, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 292)
        Me.Panel1.TabIndex = 4
        '
        'grpStudents
        '
        Me.grpStudents.Controls.Add(Me.Panel2)
        Me.grpStudents.Controls.Add(Me.cboSession)
        Me.grpStudents.Controls.Add(Me.Label4)
        Me.grpStudents.Controls.Add(Me.cboProgram)
        Me.grpStudents.Controls.Add(Me.Label3)
        Me.grpStudents.Controls.Add(Me.cboLevel)
        Me.grpStudents.Controls.Add(Me.Label2)
        Me.grpStudents.Controls.Add(Me.cboStudentDept)
        Me.grpStudents.Controls.Add(Me.Label1)
        Me.grpStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudents.Location = New System.Drawing.Point(3, 11)
        Me.grpStudents.Name = "grpStudents"
        Me.grpStudents.Size = New System.Drawing.Size(226, 272)
        Me.grpStudents.TabIndex = 19
        Me.grpStudents.TabStop = False
        Me.grpStudents.Text = "Students Matric Generator"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnGenerateMatric)
        Me.Panel2.Controls.Add(Me.txtStudentNumber)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtStudentStart)
        Me.Panel2.Controls.Add(Me.lblMatricStartPath)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(6, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(207, 132)
        Me.Panel2.TabIndex = 23
        '
        'btnGenerateMatric
        '
        Me.btnGenerateMatric.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateMatric.Location = New System.Drawing.Point(26, 102)
        Me.btnGenerateMatric.Name = "btnGenerateMatric"
        Me.btnGenerateMatric.Size = New System.Drawing.Size(164, 21)
        Me.btnGenerateMatric.TabIndex = 20
        Me.btnGenerateMatric.Text = "Generate Matric Numbers"
        Me.btnGenerateMatric.UseVisualStyleBackColor = True
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNumber.Location = New System.Drawing.Point(136, 11)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.Size = New System.Drawing.Size(56, 26)
        Me.txtStudentNumber.TabIndex = 19
        Me.txtStudentNumber.Text = "4385"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "No of Students"
        '
        'txtStudentStart
        '
        Me.txtStudentStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentStart.Location = New System.Drawing.Point(141, 65)
        Me.txtStudentStart.Name = "txtStudentStart"
        Me.txtStudentStart.Size = New System.Drawing.Size(56, 26)
        Me.txtStudentStart.TabIndex = 16
        Me.txtStudentStart.Text = "4385"
        '
        'lblMatricStartPath
        '
        Me.lblMatricStartPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblMatricStartPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMatricStartPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricStartPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMatricStartPath.Location = New System.Drawing.Point(11, 65)
        Me.lblMatricStartPath.Name = "lblMatricStartPath"
        Me.lblMatricStartPath.Size = New System.Drawing.Size(128, 26)
        Me.lblMatricStartPath.TabIndex = 15
        Me.lblMatricStartPath.Text = "CS/HND/F14/"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Starting Point"
        '
        'cboSession
        '
        Me.cboSession.FormattingEnabled = True
        Me.cboSession.Location = New System.Drawing.Point(65, 105)
        Me.cboSession.Name = "cboSession"
        Me.cboSession.Size = New System.Drawing.Size(138, 23)
        Me.cboSession.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Session"
        '
        'cboProgram
        '
        Me.cboProgram.FormattingEnabled = True
        Me.cboProgram.Location = New System.Drawing.Point(65, 79)
        Me.cboProgram.Name = "cboProgram"
        Me.cboProgram.Size = New System.Drawing.Size(138, 23)
        Me.cboProgram.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Program"
        '
        'cboLevel
        '
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(65, 54)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(138, 23)
        Me.cboLevel.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Level"
        '
        'cboStudentDept
        '
        Me.cboStudentDept.FormattingEnabled = True
        Me.cboStudentDept.Location = New System.Drawing.Point(65, 29)
        Me.cboStudentDept.Name = "cboStudentDept"
        Me.cboStudentDept.Size = New System.Drawing.Size(138, 23)
        Me.cboStudentDept.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Dept."
        '
        'grpStaff
        '
        Me.grpStaff.Controls.Add(Me.cboStaffCategory)
        Me.grpStaff.Controls.Add(Me.Label17)
        Me.grpStaff.Controls.Add(Me.Panel6)
        Me.grpStaff.Controls.Add(Me.cboStaffDept)
        Me.grpStaff.Controls.Add(Me.Label11)
        Me.grpStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStaff.Location = New System.Drawing.Point(235, 11)
        Me.grpStaff.Name = "grpStaff"
        Me.grpStaff.Size = New System.Drawing.Size(226, 271)
        Me.grpStaff.TabIndex = 18
        Me.grpStaff.TabStop = False
        Me.grpStaff.Text = "Staff ID Generator"
        '
        'cboStaffCategory
        '
        Me.cboStaffCategory.FormattingEnabled = True
        Me.cboStaffCategory.Location = New System.Drawing.Point(64, 29)
        Me.cboStaffCategory.Name = "cboStaffCategory"
        Me.cboStaffCategory.Size = New System.Drawing.Size(138, 23)
        Me.cboStaffCategory.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Category"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnGenerateStaffID)
        Me.Panel6.Controls.Add(Me.txtStaffNumber)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.txtStaffStart)
        Me.Panel6.Controls.Add(Me.lblIDStartPath)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Location = New System.Drawing.Point(7, 131)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(207, 131)
        Me.Panel6.TabIndex = 15
        '
        'btnGenerateStaffID
        '
        Me.btnGenerateStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateStaffID.Location = New System.Drawing.Point(72, 101)
        Me.btnGenerateStaffID.Name = "btnGenerateStaffID"
        Me.btnGenerateStaffID.Size = New System.Drawing.Size(123, 21)
        Me.btnGenerateStaffID.TabIndex = 20
        Me.btnGenerateStaffID.Text = "Generate IDs"
        Me.btnGenerateStaffID.UseVisualStyleBackColor = True
        '
        'txtStaffNumber
        '
        Me.txtStaffNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffNumber.Location = New System.Drawing.Point(139, 13)
        Me.txtStaffNumber.Name = "txtStaffNumber"
        Me.txtStaffNumber.Size = New System.Drawing.Size(56, 26)
        Me.txtStaffNumber.TabIndex = 19
        Me.txtStaffNumber.Text = "4385"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 15)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "No of Staff"
        '
        'txtStaffStart
        '
        Me.txtStaffStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffStart.Location = New System.Drawing.Point(141, 66)
        Me.txtStaffStart.Name = "txtStaffStart"
        Me.txtStaffStart.Size = New System.Drawing.Size(56, 26)
        Me.txtStaffStart.TabIndex = 16
        Me.txtStaffStart.Text = "4385"
        '
        'lblIDStartPath
        '
        Me.lblIDStartPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblIDStartPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIDStartPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDStartPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblIDStartPath.Location = New System.Drawing.Point(9, 66)
        Me.lblIDStartPath.Name = "lblIDStartPath"
        Me.lblIDStartPath.Size = New System.Drawing.Size(128, 26)
        Me.lblIDStartPath.TabIndex = 15
        Me.lblIDStartPath.Text = "CS/HND/F14/"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Starting Point"
        '
        'cboStaffDept
        '
        Me.cboStaffDept.FormattingEnabled = True
        Me.cboStaffDept.Location = New System.Drawing.Point(64, 58)
        Me.cboStaffDept.Name = "cboStaffDept"
        Me.cboStaffDept.Size = New System.Drawing.Size(138, 23)
        Me.cboStaffDept.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Dept."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(141, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(428, 18)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "MATRIC NUMBER AND STAFF ID GENERATOR FORM"
        '
        'FrmAddMatricStaffID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 421)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "FrmAddMatricStaffID"
        Me.Text = "FrmAddMatricStaffID"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.grpStudents.ResumeLayout(False)
        Me.grpStudents.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.grpStaff.ResumeLayout(False)
        Me.grpStaff.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents radStaff As System.Windows.Forms.RadioButton
    Friend WithEvents radStudent As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grpStaff As System.Windows.Forms.GroupBox
    Friend WithEvents cboStaffDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnGenerateStaffID As System.Windows.Forms.Button
    Friend WithEvents txtStaffNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtStaffStart As System.Windows.Forms.TextBox
    Friend WithEvents lblIDStartPath As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents grpStudents As System.Windows.Forms.GroupBox
    Friend WithEvents cboSession As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboProgram As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboStudentDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnGenerateMatric As System.Windows.Forms.Button
    Friend WithEvents txtStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStudentStart As System.Windows.Forms.TextBox
    Friend WithEvents lblMatricStartPath As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lstGenerated As System.Windows.Forms.ListBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboStaffCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
