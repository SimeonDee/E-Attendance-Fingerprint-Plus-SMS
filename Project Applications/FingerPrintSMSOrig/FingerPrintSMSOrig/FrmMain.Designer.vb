<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BioDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BioDataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CourseRegToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FingerDataCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CourseRegToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CourseRegToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.FingerDataCaptureToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StaffRegistrationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BioMetricsFingerPrintRegToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LecturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADMINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddCoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditCoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveCoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddSecurityOfficerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddStaffStuentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SendBulkSMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LecturesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExamsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StaffAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllRegisteredStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblFullname = New System.Windows.Forms.Label
        Me.lnkLogout = New System.Windows.Forms.LinkLabel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.lblOwner1 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblProjectTopic = New System.Windows.Forms.Label
        Me.TmrChangeColor = New System.Windows.Forms.Timer(Me.components)
        Me.TmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.lnklblLogout = New System.Windows.Forms.LinkLabel
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.StaffToolStripMenuItem, Me.AttendanceToolStripMenuItem, Me.ADMINToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BioDataToolStripMenuItem, Me.CourseRegToolStripMenuItem})
        Me.RegistrationToolStripMenuItem.Enabled = False
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.RegistrationToolStripMenuItem.Text = "Registrations"
        '
        'BioDataToolStripMenuItem
        '
        Me.BioDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BioDataToolStripMenuItem1, Me.CourseRegToolStripMenuItem1, Me.FingerDataCaptureToolStripMenuItem})
        Me.BioDataToolStripMenuItem.Name = "BioDataToolStripMenuItem"
        Me.BioDataToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.BioDataToolStripMenuItem.Text = "Fresher"
        '
        'BioDataToolStripMenuItem1
        '
        Me.BioDataToolStripMenuItem1.Name = "BioDataToolStripMenuItem1"
        Me.BioDataToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.BioDataToolStripMenuItem1.Text = "Bio-Data"
        '
        'CourseRegToolStripMenuItem1
        '
        Me.CourseRegToolStripMenuItem1.Name = "CourseRegToolStripMenuItem1"
        Me.CourseRegToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.CourseRegToolStripMenuItem1.Text = "Course Reg"
        '
        'FingerDataCaptureToolStripMenuItem
        '
        Me.FingerDataCaptureToolStripMenuItem.Name = "FingerDataCaptureToolStripMenuItem"
        Me.FingerDataCaptureToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.FingerDataCaptureToolStripMenuItem.Text = "Finger Data Capture"
        '
        'CourseRegToolStripMenuItem
        '
        Me.CourseRegToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CourseRegToolStripMenuItem2, Me.FingerDataCaptureToolStripMenuItem1})
        Me.CourseRegToolStripMenuItem.Name = "CourseRegToolStripMenuItem"
        Me.CourseRegToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.CourseRegToolStripMenuItem.Text = "Staylite"
        '
        'CourseRegToolStripMenuItem2
        '
        Me.CourseRegToolStripMenuItem2.Name = "CourseRegToolStripMenuItem2"
        Me.CourseRegToolStripMenuItem2.Size = New System.Drawing.Size(179, 22)
        Me.CourseRegToolStripMenuItem2.Text = "Course Reg"
        '
        'FingerDataCaptureToolStripMenuItem1
        '
        Me.FingerDataCaptureToolStripMenuItem1.Name = "FingerDataCaptureToolStripMenuItem1"
        Me.FingerDataCaptureToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.FingerDataCaptureToolStripMenuItem1.Text = "Finger Data Capture"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffRegistrationsToolStripMenuItem, Me.BioMetricsFingerPrintRegToolStripMenuItem})
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.StaffToolStripMenuItem.Text = "Staff Registrations"
        '
        'StaffRegistrationsToolStripMenuItem
        '
        Me.StaffRegistrationsToolStripMenuItem.Name = "StaffRegistrationsToolStripMenuItem"
        Me.StaffRegistrationsToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.StaffRegistrationsToolStripMenuItem.Text = "Bio-Data Registrations"
        '
        'BioMetricsFingerPrintRegToolStripMenuItem
        '
        Me.BioMetricsFingerPrintRegToolStripMenuItem.Name = "BioMetricsFingerPrintRegToolStripMenuItem"
        Me.BioMetricsFingerPrintRegToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.BioMetricsFingerPrintRegToolStripMenuItem.Text = "Bio-Metrics FingerPrint Reg"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LecturesToolStripMenuItem, Me.ExamsToolStripMenuItem})
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AttendanceToolStripMenuItem.Text = "Attendance"
        '
        'LecturesToolStripMenuItem
        '
        Me.LecturesToolStripMenuItem.Name = "LecturesToolStripMenuItem"
        Me.LecturesToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.LecturesToolStripMenuItem.Text = "Lectures"
        '
        'ExamsToolStripMenuItem
        '
        Me.ExamsToolStripMenuItem.Name = "ExamsToolStripMenuItem"
        Me.ExamsToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ExamsToolStripMenuItem.Text = "Exams"
        '
        'ADMINToolStripMenuItem
        '
        Me.ADMINToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCoursesToolStripMenuItem, Me.EditCoursesToolStripMenuItem, Me.RemoveCoursesToolStripMenuItem, Me.AddSecurityOfficerToolStripMenuItem, Me.AddStaffStuentToolStripMenuItem, Me.SendBulkSMSToolStripMenuItem})
        Me.ADMINToolStripMenuItem.Name = "ADMINToolStripMenuItem"
        Me.ADMINToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ADMINToolStripMenuItem.Text = "ADMIN"
        '
        'AddCoursesToolStripMenuItem
        '
        Me.AddCoursesToolStripMenuItem.Name = "AddCoursesToolStripMenuItem"
        Me.AddCoursesToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.AddCoursesToolStripMenuItem.Text = "Add Courses"
        '
        'EditCoursesToolStripMenuItem
        '
        Me.EditCoursesToolStripMenuItem.Name = "EditCoursesToolStripMenuItem"
        Me.EditCoursesToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.EditCoursesToolStripMenuItem.Text = "Edit Courses"
        '
        'RemoveCoursesToolStripMenuItem
        '
        Me.RemoveCoursesToolStripMenuItem.Name = "RemoveCoursesToolStripMenuItem"
        Me.RemoveCoursesToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.RemoveCoursesToolStripMenuItem.Text = "Remove Courses"
        '
        'AddSecurityOfficerToolStripMenuItem
        '
        Me.AddSecurityOfficerToolStripMenuItem.Name = "AddSecurityOfficerToolStripMenuItem"
        Me.AddSecurityOfficerToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.AddSecurityOfficerToolStripMenuItem.Text = "Add Security Officer"
        '
        'AddStaffStuentToolStripMenuItem
        '
        Me.AddStaffStuentToolStripMenuItem.Name = "AddStaffStuentToolStripMenuItem"
        Me.AddStaffStuentToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.AddStaffStuentToolStripMenuItem.Text = "Generate Staff ID/Student Matric "
        '
        'SendBulkSMSToolStripMenuItem
        '
        Me.SendBulkSMSToolStripMenuItem.Name = "SendBulkSMSToolStripMenuItem"
        Me.SendBulkSMSToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.SendBulkSMSToolStripMenuItem.Text = "Send Bulk SMS"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LecturesToolStripMenuItem1, Me.ExamsToolStripMenuItem1, Me.StaffAttendanceToolStripMenuItem, Me.AllRegisteredStudentsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'LecturesToolStripMenuItem1
        '
        Me.LecturesToolStripMenuItem1.Name = "LecturesToolStripMenuItem1"
        Me.LecturesToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.LecturesToolStripMenuItem1.Text = "Lectures"
        '
        'ExamsToolStripMenuItem1
        '
        Me.ExamsToolStripMenuItem1.Name = "ExamsToolStripMenuItem1"
        Me.ExamsToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.ExamsToolStripMenuItem1.Text = "Exams"
        '
        'StaffAttendanceToolStripMenuItem
        '
        Me.StaffAttendanceToolStripMenuItem.Name = "StaffAttendanceToolStripMenuItem"
        Me.StaffAttendanceToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.StaffAttendanceToolStripMenuItem.Text = "Staff Attendance"
        '
        'AllRegisteredStudentsToolStripMenuItem
        '
        Me.AllRegisteredStudentsToolStripMenuItem.Name = "AllRegisteredStudentsToolStripMenuItem"
        Me.AllRegisteredStudentsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AllRegisteredStudentsToolStripMenuItem.Text = "All Registered Students"
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.ForeColor = System.Drawing.Color.Navy
        Me.lblFullname.Location = New System.Drawing.Point(417, 41)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(440, 20)
        Me.lblFullname.TabIndex = 5
        Me.lblFullname.Text = "Welcome (ADELANDE, IBUKUNOLUWA EMMANUEL)"
        '
        'lnkLogout
        '
        Me.lnkLogout.AutoSize = True
        Me.lnkLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkLogout.Location = New System.Drawing.Point(1182, 38)
        Me.lnkLogout.Name = "lnkLogout"
        Me.lnkLogout.Size = New System.Drawing.Size(74, 24)
        Me.lnkLogout.TabIndex = 6
        Me.lnkLogout.TabStop = True
        Me.lnkLogout.Text = "Logout"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblCopyright)
        Me.Panel1.Controls.Add(Me.lblOwner1)
        Me.Panel1.Location = New System.Drawing.Point(4, 652)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1363, 96)
        Me.Panel1.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "08064555381"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 7)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 1000, 3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "For Info., Contact: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(486, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 1000, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Copyright:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(574, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ADEYEMI ADEDOYIN SIMEON    {13/52HA107}"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(574, 27)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(99, 24)
        Me.lblCopyright.TabIndex = 10
        Me.lblCopyright.Text = "Copyright"
        '
        'lblOwner1
        '
        Me.lblOwner1.AutoSize = True
        Me.lblOwner1.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwner1.Location = New System.Drawing.Point(391, 9)
        Me.lblOwner1.Margin = New System.Windows.Forms.Padding(3, 1000, 3, 0)
        Me.lblOwner1.Name = "lblOwner1"
        Me.lblOwner1.Size = New System.Drawing.Size(180, 17)
        Me.lblOwner1.TabIndex = 9
        Me.lblOwner1.Text = "Written and Designed By:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Location = New System.Drawing.Point(1, 175)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1363, 477)
        Me.Panel4.TabIndex = 14
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.Label15)
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Controls.Add(Me.Label14)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Location = New System.Drawing.Point(536, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(487, 468)
        Me.Panel7.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(413, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "ABOUT FINGERPRINT BIO-METRICS AND SMS ATTENDANCE SYSTEM..."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(473, 284)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Wingdings 2", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 21)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "E"
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(49, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(407, 24)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Click on SAVE then FINISH button once captured."
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Wingdings 2", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 21)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "E"
        '
        'Label14
        '
        Me.Label14.AllowDrop = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(51, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(402, 24)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Press CAPTURE button once well positioned"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Wingdings 2", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "E"
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(413, 28)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Place your Left Index Finger on the Finger Reader device"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(160, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "INSTRUCTIONS"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.PictureBox4)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Location = New System.Drawing.Point(3, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(532, 468)
        Me.Panel6.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(296, 458)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(302, 247)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(227, 215)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(301, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(229, 241)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.lblProjectTopic)
        Me.Panel2.Location = New System.Drawing.Point(2, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1025, 83)
        Me.Panel2.TabIndex = 15
        '
        'lblProjectTopic
        '
        Me.lblProjectTopic.AllowDrop = True
        Me.lblProjectTopic.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectTopic.Location = New System.Drawing.Point(154, 20)
        Me.lblProjectTopic.Name = "lblProjectTopic"
        Me.lblProjectTopic.Size = New System.Drawing.Size(692, 50)
        Me.lblProjectTopic.TabIndex = 10
        Me.lblProjectTopic.Text = "E-ATTENDANCE SYSTEM FOR UNDERGRADUATE STUDENTS INTEGRATING " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BIO-METRICS AND SMS " & _
            "TECHNOLOGIES"
        Me.lblProjectTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TmrChangeColor
        '
        Me.TmrChangeColor.Interval = 2000
        '
        'TmrMove
        '
        '
        'lnklblLogout
        '
        Me.lnklblLogout.AutoSize = True
        Me.lnklblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblLogout.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnklblLogout.Location = New System.Drawing.Point(877, 55)
        Me.lnklblLogout.Name = "lnklblLogout"
        Me.lnklblLogout.Size = New System.Drawing.Size(120, 24)
        Me.lnklblLogout.TabIndex = 16
        Me.lnklblLogout.TabStop = True
        Me.lnklblLogout.Text = "< Log Out >"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1028, 745)
        Me.Controls.Add(Me.lnklblLogout)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lnkLogout)
        Me.Controls.Add(Me.lblFullname)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "ADEDOYIN BIO-METRIC ATTENDANCE SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BioDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseRegToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LecturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADMINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCoursesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditCoursesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveCoursesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LecturesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BioDataToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseRegToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FingerDataCaptureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseRegToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FingerDataCaptureToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents lnkLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents AddSecurityOfficerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblOwner1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblProjectTopic As System.Windows.Forms.Label
    Friend WithEvents TmrChangeColor As System.Windows.Forms.Timer
    Friend WithEvents TmrMove As System.Windows.Forms.Timer
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffRegistrationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BioMetricsFingerPrintRegToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendBulkSMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllRegisteredStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStaffStuentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lnklblLogout As System.Windows.Forms.LinkLabel

End Class
