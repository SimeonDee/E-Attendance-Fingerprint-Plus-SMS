
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb
Imports GrFingerXLib


Public Class FrmLectureBiometrics

    Const Logfile = "C:\Log.csv"

    'instance of the Util.vb class
    Private myUtil As Util
    Private _UserID As Integer

    'Database objects
    Private cn As OleDbConnection
    Private cmd As OleDbCommand
    'Private rdr As OleDbDataReader

    Dim isCaptured As Boolean = False
    Private sname, mname, fname, dept, sex, level, prog, matric, picPath As String

    Private Sub FrmLectureBiometrics_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myUtil.FinalizeGrFinger()
        If cn.State = ConnectionState.Open Then MyModule.DisconnectFromDbase(cn)
    End Sub


    Private Sub LectureBiometrics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitle.Text &= " " & FrmLecturesAttendance.Course

        Dim err As Integer
        '--initializing util class--
        myUtil = New Util(ListBox1, picFinger, AxGrFingerXCtrl1)

        '--initializing GrFingerx Library--
        err = myUtil.InitializeGrFinger()

        '--print rresult in log--
        If err < 0 Then
            myUtil.WriteError(err)
            myUtil.WriteLog("**Failed to Initialize**")
            Exit Sub
        Else
            myUtil.WriteLog("**GrFingerX Successfully initialized**")
        End If

        '--create a log file--
        If Not (System.IO.File.Exists(Logfile)) Then
            System.IO.File.Create(Logfile)
        End If

        'load registered students into combobox
        'lstRegStudents.DataSource = FrmInvigilatorForm.registeredStudents

        For i As Integer = 0 To (FrmLecturesAttendance.registeredStudents.Count - 1)
            lstRegStudents.Items.Add(FrmLecturesAttendance.registeredStudents.Item(i).ToString)
        Next

        lstRegStudents.Sorted = True
        Call clearDisplay("** NEW USER **  ")
        'Open connection to database
        MyModule.ConnectToDBase(cn)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        FrmLecturesAttendance.Close()
        frmMain.Show()
    End Sub


    '***********    GrFinger Events Starts Here     ***************

    '-- When a FingerPrint Reader is plugged into the System --
    Private Sub AxGrFingerXCtrl1_SensorPlug(ByVal sender As System.Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent) Handles AxGrFingerXCtrl1.SensorPlug
        '--- Starts image capturing ---
        myUtil.WriteLog("FingerPrint Reader: " & e.idSensor & " is Connected.")
        lblError.Text = "...READER CONNECTED...    (PLACE YOUR LEFT INDEX FINGER ON THE READER)"
        AxGrFingerXCtrl1.CapStartCapture(e.idSensor)
    End Sub

    '-- When a FingerPrint Reader is Unplugged from the System --
    Private Sub AxGrFingerXCtrl1_SensorUnplug(ByVal sender As Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEvent) Handles AxGrFingerXCtrl1.SensorUnplug
        myUtil.WriteLog("FingerPrint Reader: " & e.idSensor & " is Disconnected.")
        lblError.Text = "...READER DISCONNECTED..."
        AxGrFingerXCtrl1.CapStopCapture(e.idSensor)
    End Sub

    '--- A finger is placed on the Reader ---
    Private Sub AxGrFingerXCtrl1_FingerDown(ByVal sender As Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEvent) Handles AxGrFingerXCtrl1.FingerDown
        myUtil.WriteLog("On Finger Reader: " & e.idSensor & " Finger Detected")
        lblError.Text = "...FINGER DETECTED..."
    End Sub

    '--- A finger is removed from the Reader ---
    Private Sub AxGrFingerXCtrl1_FingerUp(ByVal sender As Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEvent) Handles AxGrFingerXCtrl1.FingerUp
        myUtil.WriteLog("On Finger Reader: " & e.idSensor & " Finger Removed")

        If Not isCaptured Then lblError.Text = "...FINGER REMOVED..."
    End Sub

    ' --- An Image is acquired from the Reader ---
    Private Sub AxGrFingerXCtrl1_ImageAcquired(ByVal sender As Object, ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent) Handles AxGrFingerXCtrl1.ImageAcquired

        '-- Copying Acquired image Attributes ---
        myUtil.raw.height = e.height
        myUtil.raw.width = e.width
        myUtil.raw.res = e.res
        myUtil.raw.img = e.rawImage

        '--- Update the Log Status ---
        myUtil.WriteLog("On FingerPrint Reader: " & e.idSensor & ", Image Captured/Scanned")
        lblError.Text = "...FINGERPRINT IMAGE SCANNED..."
        isCaptured = True


        '--- Display the Captured FingerPrint Image ---
        myUtil.PrintBiometricDisplay(False, GRConstants.GR_DEFAULT_CONTEXT)

        '--- Extracting the Template from the image scanned ---
        ExtractTemplate()

        '--- Identify the User ---
        _UserID = IdentifyFinger()

        If _UserID > 0 Then
            '--- User is Found ---
            myUtil.WriteLog("User Found")

            '--Display user's information--
            GetUserInfo()

            lblError.Text = "...A VALID REGISTERED STUDENT...  (" & sname & ", " & mname & "  " & fname & ")"
            btnNext.Enabled = True
            Exit Sub

        Else
            '---User not found---
            lblError.Text = "...NOT A REGISTERED STUDENT..."
            Exit Sub
        End If
    End Sub


    '*************** END OF FINGERX CONTROL EVENTS ************************************
    '*********************************************************************************

    Private Sub GetUserInfo()
        Try
            Dim rdr1, rdr2 As OleDbDataReader
            Dim sql As String = ""
            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)

            '--Retrieves user's particulars--
            'sql = "SELECT * FROM enroll, PersonalData, RegisteredCourses WHERE enroll.ID =" & _UserID & _
            '        " AND enroll.Matric = PersonalData.Matric AND enroll.Matric = RegisteredCourses.Matric"
            'cmd = New OleDbCommand(sql, cn)
            'rdr = cmd.ExecuteReader()
            'If rdr.HasRows Then
            '    rdr.Read()
            '    If rdr("RegisteredCourses.CCode").ToString.ToUpper = FrmInvigilatorForm.Course Then
            '        lblSname.Text = rdr("PersonalData.Surname").ToString
            '        lblMiddlename.Text = rdr("PersonalData.Middlename").ToString
            '        lblFirstname.Text = rdr("PersonalData.Firstname").ToString
            '        lblMatric.Text = rdr("PersonalData.Matric").ToString
            '        lblDept.Text = rdr("PersonalData.Dept").ToString
            '        lblLevel.Text = rdr("PersonalData.TheLevel").ToString
            '        lblProgram.Text = rdr("PersonalData.TheProgram").ToString
            '        picPassport.Image = Image.FromFile(Application.StartupPath & rdr("PersonalData.passportPath").ToString)

            sql = "SELECT * FROM enroll WHERE ID=" & _UserID
            cmd = New OleDbCommand(sql, cn)
            rdr1 = cmd.ExecuteReader
            If rdr1.HasRows Then
                rdr1.Read()
                sname = rdr1("Surname").ToString
                mname = rdr1("Middlename").ToString
                fname = rdr1("Firstname").ToString
                matric = rdr1("Usrname").ToString
                level = rdr1("TheLevel").ToString
                prog = rdr1("TheProgram").ToString
                dept = rdr1("Dept").ToString
                sex = rdr1("Sex").ToString
                picPath = rdr1("passportPath").ToString

                If rdr1.IsClosed = False Then rdr1.Close()

                '--Check whether the student detected has registered for this course--
                Dim sql2 As String = "SELECT * FROM RegisteredCourses WHERE " & _
                                    "Matric='" & matric & "' AND CCode='" & FrmLecturesAttendance.Course & "'"

                cmd = New OleDbCommand(sql2, cn)
                rdr2 = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                If rdr2.HasRows Then
                    lblSname.Text = sname
                    lblMiddlename.Text = mname
                    lblFirstname.Text = fname
                    lblMatric.Text = matric
                    lblDept.Text = dept
                    lblLevel.Text = level
                    lblProgram.Text = prog
                    picPassport.Image = Image.FromFile(Application.StartupPath & picPath)


                    'Transfers the matric number of the student to the attendance listbox

                    Dim i As Integer = lstRegStudents.Items.IndexOf(matric)
                    If (lstRegStudents.Items.Count > 0) And (i <> -1) Then

                        'if there are elements in the attendance listbox
                        'Search the list to ensure the matric number is not duplicated
                        'Before adding it to the list

                        If Not (lstAttendance.Items.Contains(lstRegStudents.GetItemText(i))) Then
                            lstAttendance.Items.Add(lstRegStudents.Items.Item(i).ToString)
                            lstRegStudents.Items.RemoveAt(i)

                            lstRegStudents.Refresh()
                            lstRegStudents.Sorted = True

                            lstAttendance.Refresh()
                            lstAttendance.Sorted = True
                        End If

                    End If

                    Timer1.Enabled = False
                    Timer1.Enabled = True
                    btnNext.Focus()

                    rdr2.Close()
                Else
                    lblError.Text = "--A STUDENT ...BUT NOT REGISTERED FOR THIS COURSE--"
                    Exit Sub
                End If
                If rdr2.IsClosed = False Then rdr2.Close()

            Else
                Beep()
                lblError.Text = "ERROR: ...NOT A REGISTERED STUDENT..."

                '--Cause a little delay to see the backcolor change--
                For j As Integer = 1 To 2
                    lblError.BackColor = Color.White
                    For k As Long = 0 To 50000 : Next k
                    lblError.BackColor = Color.Black
                    For k As Long = 0 To 50000 : Next k
                Next j
            End If

            If rdr1.IsClosed = False Then rdr1.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--- Extract a template from the captured Image ---
    Private Function ExtractTemplate() As Integer
        Dim ret As Integer

        '--- Extract The Template ---
        ret = myUtil.ExtractTemplate()

        '--- Write Template quality to log ---
        If ret = GRConstants.GR_BAD_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. " & "Bad Quality.")
        ElseIf ret = GRConstants.GR_MEDIUM_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. " & "Medium Quality.")
        ElseIf ret = GRConstants.GR_HIGH_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. " & "High Quality.")
        End If

        If ret >= 0 Then
            '--if no error occured, display minutiae/segments/directions into the image
            myUtil.PrintBiometricDisplay(True, GRConstants.GR_NO_CONTEXT)
        Else
            '--- Write error to log ---
            myUtil.WriteError(ret)
            myUtil.WriteLog("Error occured.")
        End If
        Return (ret)
    End Function

    Private Function IdentifyFinger() As Integer
        Dim ret As Integer, score As Integer
        score = 0

        '--- Identify image ---
        ret = myUtil.Identify(score)

        '--- write result to log ---
        If ret > 0 Then
            myUtil.WriteLog("FingerPrint Identified. ID = " & ret & ", and Score = " & score & ".")
            myUtil.PrintBiometricDisplay(True, GRConstants.GR_DEFAULT_CONTEXT)
        ElseIf ret < 0 Then
            myUtil.WriteError(ret)
            myUtil.WriteLog("ID not recognized")
        End If

        Return ret

    End Function

    Public Sub WriteToLog(ByVal id As Integer)
        Dim sw As New System.IO.StreamWriter(Logfile, True, System.Text.Encoding.ASCII)
        sw.WriteLine(id & ", " & Now.ToString)
        sw.Close()
    End Sub
    Public Sub clearDisplay(ByVal newuser As String)
        picFinger.Image = Image.FromFile(Application.StartupPath & "\image\fingerprintreader2.jpg")
        picPassport.Image = Nothing
        lblSname.Text = ""
        lblMiddlename.Text = ""
        lblFirstname.Text = ""
        lblMatric.Text = ""
        lblDept.Text = ""
        lblLevel.Text = ""
        lblProgram.Text = ""
        lblError.Text = newuser & "... PLACE YOUR LEFT INDEX FINGER ON THE READER ..."
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        clearDisplay("")
        Timer1.Enabled = False
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        '--Clear the display for another Student--
        Call clearDisplay("** ANOTHER STUDENT **  ")
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'establish connection to database
        MyModule.ConnectToDBase(cn)
        Dim success As Boolean = True
        If lstAttendance.Items.Count > 0 Then
            For i As Integer = 0 To (lstAttendance.Items.Count - 1)

                Dim sql As String = ""
                Dim reply As Integer

                sql = "INSERT INTO LectureAttendance(TheDate,LecturerID,CCode,Matric,Dept,TheLevel,TheProgram,Period,Semester,TheSession) " & _
                        "VALUES(#" & CDate(FrmLecturesAttendance.theDate) & "#,'" & _
                        FrmLecturesAttendance.LecturerId & "','" & _
                        FrmLecturesAttendance.Course & "','" & _
                        lstAttendance.Items.Item(i).ToString.Trim & "','" & _
                        FrmLecturesAttendance.Dept & "','" & _
                        FrmLecturesAttendance.Level & "','" & _
                        FrmLecturesAttendance.Prog & "','" & _
                        FrmLecturesAttendance.Period & "','" & _
                        FrmLecturesAttendance.semester & "','" & _
                        FrmLecturesAttendance.TheSession & "')"
                cmd = New OleDbCommand(sql, cn)
                reply = cmd.ExecuteNonQuery()

                If reply < 1 Then success = False
            Next
            If success Then
                MessageBox.Show("Attendance successfully saved into the database")
                If cn.State = ConnectionState.Open Then MyModule.DisconnectFromDbase(cn)
                lstAttendance.Items.Clear()
                Me.Close()
                FrmLecturesAttendance.Close()
                frmMain.Show()
            Else
                MessageBox.Show("An error occured while saving attendance")
            End If
        End If
    End Sub
End Class