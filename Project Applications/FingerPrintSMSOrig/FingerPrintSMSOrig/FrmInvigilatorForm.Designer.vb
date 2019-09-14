<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvigilatorForm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnGetCourseDetails = New System.Windows.Forms.Button
        Me.cboDept = New System.Windows.Forms.ComboBox
        Me.txtCcode = New System.Windows.Forms.TextBox
        Me.txtInvigilatorID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cboSession = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.radThree = New System.Windows.Forms.RadioButton
        Me.radTwo = New System.Windows.Forms.RadioButton
        Me.radOne = New System.Windows.Forms.RadioButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboTime = New System.Windows.Forms.ComboBox
        Me.txtVenue = New System.Windows.Forms.TextBox
        Me.cboProgram = New System.Windows.Forms.ComboBox
        Me.cboLevel = New System.Windows.Forms.ComboBox
        Me.cboSemester = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnTakeAttendance = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.txtCTitle = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboCUnit = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(19, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 433)
        Me.Panel1.TabIndex = 21
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnGetCourseDetails)
        Me.Panel4.Controls.Add(Me.cboDept)
        Me.Panel4.Controls.Add(Me.txtCcode)
        Me.Panel4.Controls.Add(Me.txtInvigilatorID)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(10, 11)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(320, 85)
        Me.Panel4.TabIndex = 47
        '
        'btnGetCourseDetails
        '
        Me.btnGetCourseDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetCourseDetails.Location = New System.Drawing.Point(225, 32)
        Me.btnGetCourseDetails.Name = "btnGetCourseDetails"
        Me.btnGetCourseDetails.Size = New System.Drawing.Size(84, 45)
        Me.btnGetCourseDetails.TabIndex = 39
        Me.btnGetCourseDetails.Text = "Get Details"
        Me.btnGetCourseDetails.UseVisualStyleBackColor = True
        '
        'cboDept
        '
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Location = New System.Drawing.Point(95, 57)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(111, 21)
        Me.cboDept.TabIndex = 38
        '
        'txtCcode
        '
        Me.txtCcode.Location = New System.Drawing.Point(94, 31)
        Me.txtCcode.Name = "txtCcode"
        Me.txtCcode.Size = New System.Drawing.Size(110, 20)
        Me.txtCcode.TabIndex = 37
        '
        'txtInvigilatorID
        '
        Me.txtInvigilatorID.Location = New System.Drawing.Point(94, 5)
        Me.txtInvigilatorID.Name = "txtInvigilatorID"
        Me.txtInvigilatorID.Size = New System.Drawing.Size(161, 20)
        Me.txtInvigilatorID.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Dept."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Course Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Invigilator ID"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cboCUnit)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtCTitle)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.cboSession)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.radThree)
        Me.Panel3.Controls.Add(Me.radTwo)
        Me.Panel3.Controls.Add(Me.radOne)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.cboTime)
        Me.Panel3.Controls.Add(Me.txtVenue)
        Me.Panel3.Controls.Add(Me.cboProgram)
        Me.Panel3.Controls.Add(Me.cboLevel)
        Me.Panel3.Controls.Add(Me.cboSemester)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(10, 104)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 271)
        Me.Panel3.TabIndex = 46
        '
        'cboSession
        '
        Me.cboSession.FormattingEnabled = True
        Me.cboSession.Location = New System.Drawing.Point(94, 149)
        Me.cboSession.Name = "cboSession"
        Me.cboSession.Size = New System.Drawing.Size(111, 21)
        Me.cboSession.TabIndex = 61
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Session"
        '
        'radThree
        '
        Me.radThree.AutoSize = True
        Me.radThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radThree.Location = New System.Drawing.Point(208, 204)
        Me.radThree.Name = "radThree"
        Me.radThree.Size = New System.Drawing.Size(53, 17)
        Me.radThree.TabIndex = 59
        Me.radThree.TabStop = True
        Me.radThree.Text = "3 hrs"
        Me.radThree.UseVisualStyleBackColor = True
        '
        'radTwo
        '
        Me.radTwo.AutoSize = True
        Me.radTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTwo.Location = New System.Drawing.Point(145, 204)
        Me.radTwo.Name = "radTwo"
        Me.radTwo.Size = New System.Drawing.Size(53, 17)
        Me.radTwo.TabIndex = 58
        Me.radTwo.TabStop = True
        Me.radTwo.Text = "2 hrs"
        Me.radTwo.UseVisualStyleBackColor = True
        '
        'radOne
        '
        Me.radOne.AutoSize = True
        Me.radOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOne.Location = New System.Drawing.Point(96, 204)
        Me.radOne.Name = "radOne"
        Me.radOne.Size = New System.Drawing.Size(47, 17)
        Me.radOne.TabIndex = 57
        Me.radOne.TabStop = True
        Me.radOne.Text = "1 hr"
        Me.radOne.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Duration"
        '
        'cboTime
        '
        Me.cboTime.FormattingEnabled = True
        Me.cboTime.Location = New System.Drawing.Point(94, 226)
        Me.cboTime.Name = "cboTime"
        Me.cboTime.Size = New System.Drawing.Size(111, 21)
        Me.cboTime.TabIndex = 55
        '
        'txtVenue
        '
        Me.txtVenue.Location = New System.Drawing.Point(94, 176)
        Me.txtVenue.MaxLength = 15
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(111, 20)
        Me.txtVenue.TabIndex = 54
        '
        'cboProgram
        '
        Me.cboProgram.FormattingEnabled = True
        Me.cboProgram.Location = New System.Drawing.Point(94, 122)
        Me.cboProgram.Name = "cboProgram"
        Me.cboProgram.Size = New System.Drawing.Size(111, 21)
        Me.cboProgram.TabIndex = 53
        '
        'cboLevel
        '
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(94, 93)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(111, 21)
        Me.cboLevel.TabIndex = 52
        '
        'cboSemester
        '
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Location = New System.Drawing.Point(94, 64)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(110, 21)
        Me.cboSemester.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Venue"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Program"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Semester"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnTakeAttendance)
        Me.Panel2.Location = New System.Drawing.Point(10, 381)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(321, 53)
        Me.Panel2.TabIndex = 43
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(207, 11)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 32)
        Me.btnExit.TabIndex = 44
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTakeAttendance
        '
        Me.btnTakeAttendance.Enabled = False
        Me.btnTakeAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTakeAttendance.Location = New System.Drawing.Point(13, 9)
        Me.btnTakeAttendance.Name = "btnTakeAttendance"
        Me.btnTakeAttendance.Size = New System.Drawing.Size(140, 33)
        Me.btnTakeAttendance.TabIndex = 43
        Me.btnTakeAttendance.Text = "TAKE ATTENDANCE"
        Me.btnTakeAttendance.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(73, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(183, 18)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "INVIGILATOR'S FORM"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(255, 40)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(77, 15)
        Me.lblDate.TabIndex = 32
        Me.lblDate.Text = "Today date"
        '
        'txtCTitle
        '
        Me.txtCTitle.Location = New System.Drawing.Point(95, 9)
        Me.txtCTitle.MaxLength = 15
        Me.txtCTitle.Name = "txtCTitle"
        Me.txtCTitle.Size = New System.Drawing.Size(214, 20)
        Me.txtCTitle.TabIndex = 63
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Course Title"
        '
        'cboCUnit
        '
        Me.cboCUnit.FormattingEnabled = True
        Me.cboCUnit.Location = New System.Drawing.Point(95, 35)
        Me.cboCUnit.Name = "cboCUnit"
        Me.cboCUnit.Size = New System.Drawing.Size(111, 21)
        Me.cboCUnit.TabIndex = 65
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Course Unit"
        '
        'FrmInvigilatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 486)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmInvigilatorForm"
        Me.Text = "FrmSupervisorForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnTakeAttendance As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cboSession As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents radThree As System.Windows.Forms.RadioButton
    Friend WithEvents radTwo As System.Windows.Forms.RadioButton
    Friend WithEvents radOne As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboTime As System.Windows.Forms.ComboBox
    Friend WithEvents txtVenue As System.Windows.Forms.TextBox
    Friend WithEvents cboProgram As System.Windows.Forms.ComboBox
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cboSemester As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGetCourseDetails As System.Windows.Forms.Button
    Friend WithEvents cboDept As System.Windows.Forms.ComboBox
    Friend WithEvents txtCcode As System.Windows.Forms.TextBox
    Friend WithEvents txtInvigilatorID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboCUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
