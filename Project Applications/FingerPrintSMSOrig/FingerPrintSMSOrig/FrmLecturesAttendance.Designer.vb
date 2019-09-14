<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLecturesAttendance
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
        Me.lblDate = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlLoadcourse = New System.Windows.Forms.Panel
        Me.btnLoadCourses = New System.Windows.Forms.Button
        Me.txtLecturerID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnTakeAttendance = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.cboSemester = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtUnit = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboProgram = New System.Windows.Forms.ComboBox
        Me.lbl1 = New System.Windows.Forms.Label
        Me.cboSession = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.radTwo = New System.Windows.Forms.RadioButton
        Me.radOne = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboPeriod = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cboLevel = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnGetDetails = New System.Windows.Forms.Button
        Me.cboDept = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboCourses = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.pnlLoadcourse.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(293, 42)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(81, 20)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pnlLoadcourse)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(10, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 437)
        Me.Panel1.TabIndex = 9
        '
        'pnlLoadcourse
        '
        Me.pnlLoadcourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLoadcourse.Controls.Add(Me.btnLoadCourses)
        Me.pnlLoadcourse.Controls.Add(Me.txtLecturerID)
        Me.pnlLoadcourse.Controls.Add(Me.Label1)
        Me.pnlLoadcourse.Location = New System.Drawing.Point(7, 7)
        Me.pnlLoadcourse.Name = "pnlLoadcourse"
        Me.pnlLoadcourse.Size = New System.Drawing.Size(364, 42)
        Me.pnlLoadcourse.TabIndex = 15
        '
        'btnLoadCourses
        '
        Me.btnLoadCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadCourses.Location = New System.Drawing.Point(250, 7)
        Me.btnLoadCourses.Name = "btnLoadCourses"
        Me.btnLoadCourses.Size = New System.Drawing.Size(92, 25)
        Me.btnLoadCourses.TabIndex = 14
        Me.btnLoadCourses.Text = "Load Courses"
        Me.btnLoadCourses.UseVisualStyleBackColor = True
        '
        'txtLecturerID
        '
        Me.txtLecturerID.Location = New System.Drawing.Point(108, 10)
        Me.txtLecturerID.Name = "txtLecturerID"
        Me.txtLecturerID.Size = New System.Drawing.Size(127, 20)
        Me.txtLecturerID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Lecturer ID"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(7, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(364, 372)
        Me.Panel2.TabIndex = 14
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnExit)
        Me.Panel5.Controls.Add(Me.btnTakeAttendance)
        Me.Panel5.Location = New System.Drawing.Point(6, 313)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(349, 49)
        Me.Panel5.TabIndex = 31
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(217, 8)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 33)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTakeAttendance
        '
        Me.btnTakeAttendance.Enabled = False
        Me.btnTakeAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTakeAttendance.Location = New System.Drawing.Point(26, 8)
        Me.btnTakeAttendance.Name = "btnTakeAttendance"
        Me.btnTakeAttendance.Size = New System.Drawing.Size(163, 33)
        Me.btnTakeAttendance.TabIndex = 23
        Me.btnTakeAttendance.Text = "TAKE ATTENDANCE"
        Me.btnTakeAttendance.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cboSemester)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.txtUnit)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txtTitle)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.cboProgram)
        Me.Panel4.Controls.Add(Me.lbl1)
        Me.Panel4.Controls.Add(Me.cboSession)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.radTwo)
        Me.Panel4.Controls.Add(Me.radOne)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cboPeriod)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Enabled = False
        Me.Panel4.Location = New System.Drawing.Point(6, 111)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(349, 195)
        Me.Panel4.TabIndex = 30
        '
        'cboSemester
        '
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Location = New System.Drawing.Point(106, 55)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(122, 21)
        Me.cboSemester.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Semester"
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(106, 31)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(123, 20)
        Me.txtUnit.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Course Unit"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(107, 7)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(233, 20)
        Me.txtTitle.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Course Title"
        '
        'cboProgram
        '
        Me.cboProgram.FormattingEnabled = True
        Me.cboProgram.Location = New System.Drawing.Point(106, 82)
        Me.cboProgram.Name = "cboProgram"
        Me.cboProgram.Size = New System.Drawing.Size(122, 21)
        Me.cboProgram.TabIndex = 37
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(7, 85)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(46, 13)
        Me.lbl1.TabIndex = 36
        Me.lbl1.Text = "Program"
        '
        'cboSession
        '
        Me.cboSession.FormattingEnabled = True
        Me.cboSession.Location = New System.Drawing.Point(107, 109)
        Me.cboSession.Name = "cboSession"
        Me.cboSession.Size = New System.Drawing.Size(122, 21)
        Me.cboSession.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Session"
        '
        'radTwo
        '
        Me.radTwo.AutoSize = True
        Me.radTwo.Location = New System.Drawing.Point(168, 138)
        Me.radTwo.Name = "radTwo"
        Me.radTwo.Size = New System.Drawing.Size(48, 17)
        Me.radTwo.TabIndex = 33
        Me.radTwo.TabStop = True
        Me.radTwo.Text = "2 hrs"
        Me.radTwo.UseVisualStyleBackColor = True
        '
        'radOne
        '
        Me.radOne.AutoSize = True
        Me.radOne.Location = New System.Drawing.Point(108, 138)
        Me.radOne.Name = "radOne"
        Me.radOne.Size = New System.Drawing.Size(43, 17)
        Me.radOne.TabIndex = 32
        Me.radOne.TabStop = True
        Me.radOne.Text = "1 hr"
        Me.radOne.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(8, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Duration"
        '
        'cboPeriod
        '
        Me.cboPeriod.FormattingEnabled = True
        Me.cboPeriod.Location = New System.Drawing.Point(107, 162)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(122, 21)
        Me.cboPeriod.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(8, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Period"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cboLevel)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.btnGetDetails)
        Me.Panel3.Controls.Add(Me.cboDept)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.cboCourses)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 97)
        Me.Panel3.TabIndex = 29
        '
        'cboLevel
        '
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(106, 65)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(123, 21)
        Me.cboLevel.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Level"
        '
        'btnGetDetails
        '
        Me.btnGetDetails.Enabled = False
        Me.btnGetDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDetails.Location = New System.Drawing.Point(242, 37)
        Me.btnGetDetails.Name = "btnGetDetails"
        Me.btnGetDetails.Size = New System.Drawing.Size(93, 48)
        Me.btnGetDetails.TabIndex = 29
        Me.btnGetDetails.Text = "Get Course Details"
        Me.btnGetDetails.UseVisualStyleBackColor = True
        '
        'cboDept
        '
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Location = New System.Drawing.Point(105, 36)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(123, 21)
        Me.cboDept.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Department"
        '
        'cboCourses
        '
        Me.cboCourses.FormattingEnabled = True
        Me.cboCourses.Location = New System.Drawing.Point(106, 6)
        Me.cboCourses.Name = "cboCourses"
        Me.cboCourses.Size = New System.Drawing.Size(122, 21)
        Me.cboCourses.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Course"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(52, 9)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(174, 18)
        Me.Label40.TabIndex = 32
        Me.Label40.Text = "ATTENDANCE FORM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(258, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Date:"
        '
        'FrmLecturesAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 511)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "FrmLecturesAttendance"
        Me.Text = "FrmLecturesAttendance"
        Me.Panel1.ResumeLayout(False)
        Me.pnlLoadcourse.ResumeLayout(False)
        Me.pnlLoadcourse.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents pnlLoadcourse As System.Windows.Forms.Panel
    Friend WithEvents btnLoadCourses As System.Windows.Forms.Button
    Friend WithEvents txtLecturerID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cboDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCourses As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboProgram As System.Windows.Forms.ComboBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents cboSession As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents radTwo As System.Windows.Forms.RadioButton
    Friend WithEvents radOne As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGetDetails As System.Windows.Forms.Button
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnTakeAttendance As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboSemester As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
