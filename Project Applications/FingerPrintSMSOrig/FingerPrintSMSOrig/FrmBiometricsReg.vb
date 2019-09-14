
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb
Imports GrFingerXLib

Public Class FrmBiometricsReg

    'name of the Database
    Const DBFile = "FingerPrintSMSDb.mdb"
    Const Logfile = "C:\Log.csv"

    'instance of the Util.vb class
    Private myUtil As Util
    Private _UserID As Integer

    'Database objects
    Private cn As OleDbConnection
    Private cmd As OleDbCommand
    'Private rdr As OleDbDataReader
    Dim theUserName, theCategory, sname, mname, fname, dept, level, prog, sex, picPath, parPhone As String
    Dim staffID, StaffSname, StaffMname, StaffFname, StaffSex, StaffDept, StaffCategory, StaffPicPath As String

    Dim isCaptured As Boolean = False
    Dim isStaff As Boolean = False

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub FrmBiometricsReg_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myUtil.FinalizeGrFinger()
        If cn.State = ConnectionState.Open Then MyModule.DisconnectFromDbase(cn)
    End Sub

    Private Sub FrmBiometricsReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim err As Integer
        Try

            theUserName = FrmLogin.TheUserName
            theCategory = FrmLogin.category
            '--- connect to the database ---
            MyModule.ConnectToDBase(cn)

            '--get other details from Bio-Data Table--
            
            Dim rdr As OleDbDataReader
            Dim sql As String = ""

            '---write appropriate sql statement depending on staff or student---
            If theCategory = "STUDENT" Then
                sql = "SELECT * FROM PersonalData WHERE Matric='" & theUserName & "'"
                isStaff = False
            ElseIf (theCategory = "STAFF") Or (theCategory = "ADMIN") Then
                sql = "SELECT * FROM StaffDataReg WHERE StaffID='" & theUserName & "'"
                isStaff = True
            End If

            cmd = New OleDbCommand(sql, cn)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                '--- if it is a staff ---
                If isStaff Then
                    staffID = rdr("StaffID").ToString
                    StaffSname = rdr("Surname").ToString
                    StaffMname = rdr("Middlename").ToString
                    StaffFname = rdr("Firstname").ToString
                    StaffSex = rdr("Sex").ToString
                    StaffCategory = rdr("StaffCategory").ToString
                    StaffDept = rdr("Dept").ToString
                    StaffPicPath = rdr("passportPath").ToString

                Else
                    '--- else if it is a student ---
                    sname = rdr("Surname").ToString
                    mname = rdr("Middlename").ToString
                    fname = rdr("Firstname").ToString
                    dept = rdr("Dept").ToString
                    level = rdr("TheLevel").ToString
                    prog = rdr("TheProgram").ToString
                    sex = rdr("Sex").ToString
                    picPath = rdr("passportPath").ToString
                    parPhone = rdr("ParPhone").ToString
                    If rdr.IsClosed = False Then rdr.Close()

                End If
                
            End If
            If rdr.IsClosed = False Then rdr.Close()

            pnlStudents.Visible = False
            pnlStaff.Visible = False

            '***************************************************************


            '----Initialize util class----
            myUtil = New Util(ListBox1, picFinger, AxGrFingerXCtrl1)

            '----Initialize GrFingerX Library ----
            err = myUtil.InitializeGrFinger()

            '---Print result in Log --
            If err < 0 Then
                myUtil.WriteError(err)
                Exit Sub
            Else
                myUtil.WriteLog("** GrFingerX initialization Successful **")
            End If

            '--- Create a LogFile if it doesn't already exist  ---
            If Not (System.IO.File.Exists(Logfile)) Then
                System.IO.File.Create(Logfile)
            End If

            lblError.Text = "LILLY BIO-METRICS ATTENDANCE SYSTEM"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
            '--- User is already Registered ---
            Beep()
            myUtil.WriteLog("User already Registered")
            If isStaff Then
                MessageBox.Show("You have already registered your Bio-Metric Details Before." & vbCrLf & _
                                    "(" & StaffSname & ", " & StaffMname & "  " & StaffFname & ")")
                lblError.Text = "...USER ALREADY REGISTERED...  (" & StaffSname & ", " & StaffMname & "  " & StaffFname & ")"
            Else
                MessageBox.Show("You have already registered your Bio-Metric Details Before." & vbCrLf & _
                                                    "(" & sname & ", " & mname & "  " & fname & ")")
                lblError.Text = "...USER ALREADY REGISTERED...  (" & sname & ", " & mname & "  " & fname & ")"
            End If

            Call GetUserInfo()

            btnSave.Enabled = False
            Exit Sub
        Else
            MessageBox.Show("Your FingerPrint Image has been captured but not yet saved." & vbCrLf & _
                            "Please Click on the SAVE button to save your Bio-Metric Details")
            lblError.Text &= "     (Click on SAVE button to enroll.)"
            btnSave.Enabled = True
            btnSave.Focus()
        End If
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '--- First Add the fingerprint into the DB ---
        _UserID = EnrollFingerPrint()

        '--- Add other Particulars ---
        AddNewUser()

        WriteToLog(_UserID)
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

    Private Function EnrollFingerPrint() As Integer
        Dim id As Integer

        '--- Add Fingerprint image ---
        id = myUtil.Enroll()

        '--- write result to log ---
        If id >= 0 Then
            myUtil.WriteLog("FingerPrint successfully enrolled with id " & id & ".")
            MessageBox.Show("Congratulations, You have been successfully enrolled." & _
                            "Your Bio-Metrics details have been successfully saved.")

            btnSave.Enabled = False
            picFinger.Image = Nothing
        Else
            myUtil.WriteLog("Error: FingerPrint failed to enroll.")
            lblError.Text = "Failed to enroll..."
        End If

        Return id

    End Function

    '--- Add a new User Information to the Database ---
    Private Sub AddNewUser()
        Try
            If cn.State = ConnectionState.Closed Then
                MyModule.ConnectToDBase(cn)
            End If
            '--- Enter User's particulars ---
            Dim sql As String = ""
            If Not (isStaff) Then
                sql = "UPDATE enroll SET Usrname = '" & theUserName & "', " & _
                "Surname = '" & sname & "', " & _
                "Middlename = '" & mname & "', " & _
                "Firstname = '" & fname & "', " & _
                "TheLevel = '" & level & "', " & _
                "TheProgram = '" & prog & "', " & _
                "Dept = '" & dept & "', " & _
                "Sex = '" & sex & "', " & _
                "passportPath = '" & picPath & "', " & _
                "ParPhone = '" & parPhone & "', " & _
                "Category = '" & theCategory & "' " & _
                "WHERE ID = " & _UserID

                MessageBox.Show("Thank you " & sname & ", " & mname & _
                                            "   " & fname & vbCrLf & "You Have Completed Your Registrations successfully")

            Else
                sql = "UPDATE enroll SET Usrname = '" & theUserName & "', " & _
                                "Surname = '" & StaffSname & "', " & _
                                "Middlename = '" & StaffMname & "', " & _
                                "Firstname = '" & StaffFname & "', " & _
                                "Dept = '" & StaffDept & "', " & _
                                "Sex = '" & StaffSex & "', " & _
                                "passportPath = '" & StaffPicPath & "', " & _
                                "Category = '" & theCategory & "' " & _
                                "WHERE ID = " & _UserID

                MessageBox.Show("Thank you " & StaffSname & ", " & StaffMname & _
                                            "   " & StaffFname & vbCrLf & "You Have Completed Your Registrations successfully")
            End If

            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteNonQuery()

            lblError.Text = "...SUCCESSFULLY ENROLLED..."

            Call GetUserInfo()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GetUserInfo()
        Try
            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)

            Dim rdr As OleDbDataReader
            Dim sql As String = "SELECT * FROM enroll WHERE ID=" & _UserID
            cmd = New OleDbCommand(sql, cn)
            rdr = cmd.ExecuteReader()
            If rdr.HasRows Then
                rdr.Read()

                If rdr("Category").ToString.Trim = "STUDENT" Then

                    pnlStaff.Visible = False
                    pnlStudents.Visible = True

                    lblSname.Text = rdr("Surname").ToString
                    lblMiddlename.Text = rdr("Middlename").ToString
                    lblFirstname.Text = rdr("Firstname").ToString
                    lblMatric.Text = rdr("Usrname").ToString
                    lblDept.Text = rdr("Dept").ToString
                    lblLevel.Text = rdr("TheLevel").ToString
                    lblProgram.Text = rdr("TheProgram").ToString
                    picPassport.Image = Image.FromFile(Application.StartupPath & rdr("passportPath").ToString)

                Else
                    If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)

                    Dim rdr2 As OleDbDataReader
                    Dim sql2 As String
                    sql2 = "SELECT * FROM StaffDataReg WHERE StaffID ='" & rdr("Usrname").ToString.Trim & "'"
                    cmd = New OleDbCommand(sql2, cn)
                    rdr2 = cmd.ExecuteReader()

                    If rdr2.HasRows Then

                        pnlStudents.Visible = False


                        rdr2.Read()
                        lblStaffID.Text = rdr2("StaffID").ToString
                        lblStaffSurname.Text = rdr2("Surname").ToString
                        lblStaffMiddleName.Text = rdr2("Middlename").ToString
                        lblStaffFirstname.Text = rdr2("Firstname").ToString
                        lblStaffCategory.Text = rdr2("StaffCategory").ToString
                        lblStaffDept.Text = rdr2("Dept").ToString
                        lblStaffSex.Text = rdr2("Sex").ToString
                        picStaffPassport.Image = Image.FromFile(Application.StartupPath & rdr2("passportPath").ToString)

                        pnlStaff.Visible = True

                    End If
                    If rdr2.IsClosed = False Then rdr2.Close()

                End If
            End If
            If rdr.IsClosed = False Then rdr.Close()


            btnSave.Enabled = False

            Timer1.Enabled = False
            Timer1.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub WriteToLog(ByVal id As Integer)
        Dim sw As New System.IO.StreamWriter(Logfile, True, System.Text.Encoding.ASCII)
        sw.WriteLine(id & ", " & Now.ToString)
        sw.Close()
    End Sub
    Public Sub clearDisplay()
        picFinger.Image = Image.FromFile(Application.StartupPath & "\image\fingerprintreader2.jpg")

        picPassport.Image = Nothing
        lblSname.Text = String.Empty
        lblMiddlename.Text = String.Empty
        lblFirstname.Text = String.Empty
        lblMatric.Text = String.Empty
        lblDept.Text = String.Empty
        lblLevel.Text = String.Empty
        lblProgram.Text = String.Empty
        lblError.Text = "LILLY BIO-METRICS ATTENDANCE SYSTEM"

        lblStaffID.Text = String.Empty
        picStaffPassport.Image = Nothing
        lblStaffSurname.Text = String.Empty
        lblStaffMiddleName.Text = String.Empty
        lblStaffFirstname.Text = String.Empty
        lblStaffCategory.Text = String.Empty
        lblStaffDept.Text = String.Empty
        lblStaffSex.Text = String.Empty

        pnlStudents.Visible = False
        pnlStaff.Visible = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        clearDisplay()
        Timer1.Enabled = False
    End Sub
End Class