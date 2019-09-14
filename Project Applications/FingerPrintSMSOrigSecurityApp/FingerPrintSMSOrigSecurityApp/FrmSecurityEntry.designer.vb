<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSecurityEntry
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSecurityEntry))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pnlStudents = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.picPassport = New System.Windows.Forms.PictureBox
        Me.lblSname = New System.Windows.Forms.Label
        Me.lblProgram = New System.Windows.Forms.Label
        Me.lblLevel = New System.Windows.Forms.Label
        Me.lblDept = New System.Windows.Forms.Label
        Me.lblMatric = New System.Windows.Forms.Label
        Me.lblMiddlename = New System.Windows.Forms.Label
        Me.lblFirstname = New System.Windows.Forms.Label
        Me.lblSurname = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlStaff = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.picStaffPassport = New System.Windows.Forms.PictureBox
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.lblStaffID = New System.Windows.Forms.Label
        Me.lblStaffSex = New System.Windows.Forms.Label
        Me.lblStaffDept = New System.Windows.Forms.Label
        Me.lblStaffCategory = New System.Windows.Forms.Label
        Me.lblStaffFirstname = New System.Windows.Forms.Label
        Me.lblStaffSurname = New System.Windows.Forms.Label
        Me.lblStaffMiddleName = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.lblError = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.picFinger = New System.Windows.Forms.PictureBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.AxGrFingerXCtrl1 = New AxGrFingerXLib.AxGrFingerXCtrl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseForTheDayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstStaffSignedOut = New System.Windows.Forms.ListBox
        Me.lstStaffSignedIn = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstSignedOut = New System.Windows.Forms.ListBox
        Me.lstSignedIn = New System.Windows.Forms.ListBox
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pnlStudents.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.picPassport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStaff.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.picStaffPassport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.picFinger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxGrFingerXCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pnlStudents)
        Me.Panel1.Controls.Add(Me.pnlStaff)
        Me.Panel1.Controls.Add(Me.lblError)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(7, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 262)
        Me.Panel1.TabIndex = 36
        '
        'pnlStudents
        '
        Me.pnlStudents.BackColor = System.Drawing.Color.Black
        Me.pnlStudents.Controls.Add(Me.Panel5)
        Me.pnlStudents.Controls.Add(Me.Label12)
        Me.pnlStudents.Controls.Add(Me.Label11)
        Me.pnlStudents.Controls.Add(Me.Label10)
        Me.pnlStudents.Controls.Add(Me.Label9)
        Me.pnlStudents.Controls.Add(Me.Label8)
        Me.pnlStudents.Controls.Add(Me.Label7)
        Me.pnlStudents.Controls.Add(Me.Label6)
        Me.pnlStudents.Controls.Add(Me.Label5)
        Me.pnlStudents.Location = New System.Drawing.Point(162, 5)
        Me.pnlStudents.Name = "pnlStudents"
        Me.pnlStudents.Size = New System.Drawing.Size(351, 203)
        Me.pnlStudents.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.picPassport)
        Me.Panel5.Controls.Add(Me.lblSname)
        Me.Panel5.Controls.Add(Me.lblProgram)
        Me.Panel5.Controls.Add(Me.lblLevel)
        Me.Panel5.Controls.Add(Me.lblDept)
        Me.Panel5.Controls.Add(Me.lblMatric)
        Me.Panel5.Controls.Add(Me.lblMiddlename)
        Me.Panel5.Controls.Add(Me.lblFirstname)
        Me.Panel5.Controls.Add(Me.lblSurname)
        Me.Panel5.Location = New System.Drawing.Point(79, 32)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(238, 158)
        Me.Panel5.TabIndex = 8
        '
        'picPassport
        '
        Me.picPassport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPassport.Location = New System.Drawing.Point(147, 5)
        Me.picPassport.Name = "picPassport"
        Me.picPassport.Size = New System.Drawing.Size(85, 72)
        Me.picPassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPassport.TabIndex = 16
        Me.picPassport.TabStop = False
        '
        'lblSname
        '
        Me.lblSname.AutoSize = True
        Me.lblSname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSname.Location = New System.Drawing.Point(8, 9)
        Me.lblSname.Name = "lblSname"
        Me.lblSname.Size = New System.Drawing.Size(68, 15)
        Me.lblSname.TabIndex = 15
        Me.lblSname.Text = "lblSname"
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblProgram.Location = New System.Drawing.Point(8, 136)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(78, 15)
        Me.lblProgram.TabIndex = 14
        Me.lblProgram.Text = "lblProgram"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblLevel.Location = New System.Drawing.Point(8, 116)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(57, 15)
        Me.lblLevel.TabIndex = 13
        Me.lblLevel.Text = "lblLevel"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblDept.Location = New System.Drawing.Point(8, 97)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(53, 15)
        Me.lblDept.TabIndex = 12
        Me.lblDept.Text = "lblDept"
        '
        'lblMatric
        '
        Me.lblMatric.AutoSize = True
        Me.lblMatric.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatric.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMatric.Location = New System.Drawing.Point(7, 75)
        Me.lblMatric.Name = "lblMatric"
        Me.lblMatric.Size = New System.Drawing.Size(63, 15)
        Me.lblMatric.TabIndex = 11
        Me.lblMatric.Text = "lblMatric"
        '
        'lblMiddlename
        '
        Me.lblMiddlename.AutoSize = True
        Me.lblMiddlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMiddlename.Location = New System.Drawing.Point(7, 32)
        Me.lblMiddlename.Name = "lblMiddlename"
        Me.lblMiddlename.Size = New System.Drawing.Size(103, 15)
        Me.lblMiddlename.TabIndex = 10
        Me.lblMiddlename.Text = "lblMiddlename"
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblFirstname.Location = New System.Drawing.Point(7, 53)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(87, 15)
        Me.lblFirstname.TabIndex = 9
        Me.lblFirstname.Text = "lblFirstname"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSurname.Location = New System.Drawing.Point(7, 8)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(0, 15)
        Me.lblSurname.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(13, 166)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Program:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(13, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Level:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(13, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Dept.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(12, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Matric:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(12, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Middlename:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(12, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Firstname:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(12, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Surname:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(55, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "STUDENT'S DETAILS"
        '
        'pnlStaff
        '
        Me.pnlStaff.BackColor = System.Drawing.Color.Black
        Me.pnlStaff.Controls.Add(Me.Panel9)
        Me.pnlStaff.Controls.Add(Me.Label25)
        Me.pnlStaff.Controls.Add(Me.Label26)
        Me.pnlStaff.Controls.Add(Me.Label27)
        Me.pnlStaff.Controls.Add(Me.Label28)
        Me.pnlStaff.Controls.Add(Me.Label29)
        Me.pnlStaff.Controls.Add(Me.Label30)
        Me.pnlStaff.Controls.Add(Me.Label31)
        Me.pnlStaff.Controls.Add(Me.Label32)
        Me.pnlStaff.Location = New System.Drawing.Point(161, 17)
        Me.pnlStaff.Name = "pnlStaff"
        Me.pnlStaff.Size = New System.Drawing.Size(352, 198)
        Me.pnlStaff.TabIndex = 6
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.picStaffPassport)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Location = New System.Drawing.Point(84, 26)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(260, 165)
        Me.Panel9.TabIndex = 10
        '
        'picStaffPassport
        '
        Me.picStaffPassport.Location = New System.Drawing.Point(157, 3)
        Me.picStaffPassport.Name = "picStaffPassport"
        Me.picStaffPassport.Size = New System.Drawing.Size(93, 81)
        Me.picStaffPassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStaffPassport.TabIndex = 11
        Me.picStaffPassport.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.lblStaffID)
        Me.Panel10.Controls.Add(Me.lblStaffSex)
        Me.Panel10.Controls.Add(Me.lblStaffDept)
        Me.Panel10.Controls.Add(Me.lblStaffCategory)
        Me.Panel10.Controls.Add(Me.lblStaffFirstname)
        Me.Panel10.Controls.Add(Me.lblStaffSurname)
        Me.Panel10.Controls.Add(Me.lblStaffMiddleName)
        Me.Panel10.Controls.Add(Me.Label24)
        Me.Panel10.Location = New System.Drawing.Point(4, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(149, 158)
        Me.Panel10.TabIndex = 10
        '
        'lblStaffID
        '
        Me.lblStaffID.AccessibleName = "lblSurname"
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStaffID.Location = New System.Drawing.Point(6, 9)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(66, 15)
        Me.lblStaffID.TabIndex = 15
        Me.lblStaffID.Text = "lblStaffID"
        '
        'lblStaffSex
        '
        Me.lblStaffSex.AutoSize = True
        Me.lblStaffSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStaffSex.Location = New System.Drawing.Point(6, 136)
        Me.lblStaffSex.Name = "lblStaffSex"
        Me.lblStaffSex.Size = New System.Drawing.Size(76, 15)
        Me.lblStaffSex.TabIndex = 14
        Me.lblStaffSex.Text = "lblStaffSex"
        '
        'lblStaffDept
        '
        Me.lblStaffDept.AutoSize = True
        Me.lblStaffDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffDept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStaffDept.Location = New System.Drawing.Point(6, 116)
        Me.lblStaffDept.Name = "lblStaffDept"
        Me.lblStaffDept.Size = New System.Drawing.Size(82, 15)
        Me.lblStaffDept.TabIndex = 13
        Me.lblStaffDept.Text = "lblStaffDept"
        '
        'lblStaffCategory
        '
        Me.lblStaffCategory.AutoSize = True
        Me.lblStaffCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStaffCategory.Location = New System.Drawing.Point(6, 97)
        Me.lblStaffCategory.Name = "lblStaffCategory"
        Me.lblStaffCategory.Size = New System.Drawing.Size(108, 15)
        Me.lblStaffCategory.TabIndex = 12
        Me.lblStaffCategory.Text = "lblStaffCategory"
        '
        'lblStaffFirstname
        '
        Me.lblStaffFirstname.AutoSize = True
        Me.lblStaffFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStaffFirstname.Location = New System.Drawing.Point(5, 75)
        Me.lblStaffFirstname.Name = "lblStaffFirstname"
        Me.lblStaffFirstname.Size = New System.Drawing.Size(116, 15)
        Me.lblStaffFirstname.TabIndex = 11
        Me.lblStaffFirstname.Text = "lblStaffFirstname"
        '
        'lblStaffSurname
        '
        Me.lblStaffSurname.AutoSize = True
        Me.lblStaffSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffSurname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStaffSurname.Location = New System.Drawing.Point(5, 32)
        Me.lblStaffSurname.Name = "lblStaffSurname"
        Me.lblStaffSurname.Size = New System.Drawing.Size(110, 15)
        Me.lblStaffSurname.TabIndex = 10
        Me.lblStaffSurname.Text = "lblStaffSurname"
        '
        'lblStaffMiddleName
        '
        Me.lblStaffMiddleName.AutoSize = True
        Me.lblStaffMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStaffMiddleName.Location = New System.Drawing.Point(5, 53)
        Me.lblStaffMiddleName.Name = "lblStaffMiddleName"
        Me.lblStaffMiddleName.Size = New System.Drawing.Size(132, 15)
        Me.lblStaffMiddleName.TabIndex = 9
        Me.lblStaffMiddleName.Text = "lblStaffMiddlename"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(7, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(0, 15)
        Me.Label24.TabIndex = 8
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Yellow
        Me.Label25.Location = New System.Drawing.Point(13, 166)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(28, 13)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Sex:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Yellow
        Me.Label26.Location = New System.Drawing.Point(13, 145)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(33, 13)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Dept:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Yellow
        Me.Label27.Location = New System.Drawing.Point(13, 126)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(52, 13)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "Category:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Yellow
        Me.Label28.Location = New System.Drawing.Point(12, 105)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(55, 13)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "Firstname:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Yellow
        Me.Label29.Location = New System.Drawing.Point(12, 66)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(52, 13)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "Surname:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Yellow
        Me.Label30.Location = New System.Drawing.Point(12, 85)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(67, 13)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Middlename:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Yellow
        Me.Label31.Location = New System.Drawing.Point(12, 43)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(46, 13)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Staff ID:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(108, 7)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(137, 16)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "STAFF'S DETAILS"
        '
        'lblError
        '
        Me.lblError.BackColor = System.Drawing.Color.Black
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(7, 218)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(506, 37)
        Me.lblError.TabIndex = 4
        Me.lblError.Text = "ERROR: NOT REGISTERED FOR THIS COURSE"
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.btnExit)
        Me.Panel3.Location = New System.Drawing.Point(6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(149, 207)
        Me.Panel3.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.picFinger)
        Me.Panel6.Location = New System.Drawing.Point(6, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(132, 157)
        Me.Panel6.TabIndex = 5
        '
        'picFinger
        '
        Me.picFinger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFinger.Image = CType(resources.GetObject("picFinger.Image"), System.Drawing.Image)
        Me.picFinger.Location = New System.Drawing.Point(7, 7)
        Me.picFinger.Name = "picFinger"
        Me.picFinger.Size = New System.Drawing.Size(115, 139)
        Me.picFinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFinger.TabIndex = 4
        Me.picFinger.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(33, 175)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 25)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 294)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 15)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Status Logs"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 310)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(492, 82)
        Me.ListBox1.TabIndex = 37
        '
        'AxGrFingerXCtrl1
        '
        Me.AxGrFingerXCtrl1.Enabled = True
        Me.AxGrFingerXCtrl1.Location = New System.Drawing.Point(436, 332)
        Me.AxGrFingerXCtrl1.Name = "AxGrFingerXCtrl1"
        Me.AxGrFingerXCtrl1.OcxState = CType(resources.GetObject("AxGrFingerXCtrl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxGrFingerXCtrl1.Size = New System.Drawing.Size(32, 32)
        Me.AxGrFingerXCtrl1.TabIndex = 38
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(791, 24)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseForTheDayToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseForTheDayToolStripMenuItem
        '
        Me.CloseForTheDayToolStripMenuItem.Name = "CloseForTheDayToolStripMenuItem"
        Me.CloseForTheDayToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CloseForTheDayToolStripMenuItem.Text = "Close For The Day"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lstStaffSignedOut)
        Me.Panel4.Controls.Add(Me.lstStaffSignedIn)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.lstSignedOut)
        Me.Panel4.Controls.Add(Me.lstSignedIn)
        Me.Panel4.Location = New System.Drawing.Point(531, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(255, 357)
        Me.Panel4.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(106, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Staff"
        '
        'lstStaffSignedOut
        '
        Me.lstStaffSignedOut.FormattingEnabled = True
        Me.lstStaffSignedOut.Location = New System.Drawing.Point(129, 228)
        Me.lstStaffSignedOut.Name = "lstStaffSignedOut"
        Me.lstStaffSignedOut.Size = New System.Drawing.Size(117, 121)
        Me.lstStaffSignedOut.TabIndex = 50
        '
        'lstStaffSignedIn
        '
        Me.lstStaffSignedIn.FormattingEnabled = True
        Me.lstStaffSignedIn.Location = New System.Drawing.Point(6, 229)
        Me.lstStaffSignedIn.Name = "lstStaffSignedIn"
        Me.lstStaffSignedIn.Size = New System.Drawing.Size(117, 121)
        Me.lstStaffSignedIn.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Students"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Signed Out"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 23)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Signed In"
        '
        'lstSignedOut
        '
        Me.lstSignedOut.FormattingEnabled = True
        Me.lstSignedOut.Location = New System.Drawing.Point(129, 50)
        Me.lstSignedOut.Name = "lstSignedOut"
        Me.lstSignedOut.Size = New System.Drawing.Size(117, 160)
        Me.lstSignedOut.TabIndex = 45
        '
        'lstSignedIn
        '
        Me.lstSignedIn.FormattingEnabled = True
        Me.lstSignedIn.Location = New System.Drawing.Point(6, 51)
        Me.lstSignedIn.Name = "lstSignedIn"
        Me.lstSignedIn.Size = New System.Drawing.Size(117, 160)
        Me.lstSignedIn.TabIndex = 44
        '
        'FrmSecurityEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 399)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.AxGrFingerXCtrl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmSecurityEntry"
        Me.Text = "FrmSecurityEntry"
        Me.Panel1.ResumeLayout(False)
        Me.pnlStudents.ResumeLayout(False)
        Me.pnlStudents.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.picPassport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStaff.ResumeLayout(False)
        Me.pnlStaff.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.picStaffPassport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.picFinger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxGrFingerXCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents picFinger As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnlStudents As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents picPassport As System.Windows.Forms.PictureBox
    Friend WithEvents lblSname As System.Windows.Forms.Label
    Friend WithEvents lblProgram As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents lblMatric As System.Windows.Forms.Label
    Friend WithEvents lblMiddlename As System.Windows.Forms.Label
    Friend WithEvents lblFirstname As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents AxGrFingerXCtrl1 As AxGrFingerXLib.AxGrFingerXCtrl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstSignedOut As System.Windows.Forms.ListBox
    Friend WithEvents lstSignedIn As System.Windows.Forms.ListBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseForTheDayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstStaffSignedOut As System.Windows.Forms.ListBox
    Friend WithEvents lstStaffSignedIn As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlStaff As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents picStaffPassport As System.Windows.Forms.PictureBox
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents lblStaffID As System.Windows.Forms.Label
    Friend WithEvents lblStaffSex As System.Windows.Forms.Label
    Friend WithEvents lblStaffDept As System.Windows.Forms.Label
    Friend WithEvents lblStaffCategory As System.Windows.Forms.Label
    Friend WithEvents lblStaffFirstname As System.Windows.Forms.Label
    Friend WithEvents lblStaffSurname As System.Windows.Forms.Label
    Friend WithEvents lblStaffMiddleName As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
End Class
