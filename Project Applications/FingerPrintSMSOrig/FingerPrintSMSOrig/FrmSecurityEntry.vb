
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb
Imports GrFingerXLib

Public Class FrmSecurityEntry


    Const Logfile = "C:\Log.csv"

    'instance of the Util.vb class
    Private myUtil As Util
    Private _UserID As Integer

    'Database objects
    Private cn As OleDbConnection
    Private cmd As OleDbCommand
    'Private rdr As OleDbDataReader

    Dim isCaptured As Boolean = False
    Private sname, mname, fname, dept, sex, level, prog, matric, picPath, status, parPhone As String

    Private Sub FrmSecurityEntry_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        myUtil.FinalizeGrFinger()
        MyModule.SmsClosePort(SerialPort1)
        If cn.State = ConnectionState.Open Then MyModule.DisconnectFromDbase(cn)
    End Sub

    Private Sub FrmSecurityEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


        'Open connection to database
        MyModule.ConnectToDBase(cn)

        '---Open Connection to the serial port for sms---
        MyModule.SmsConnectToPort(SerialPort1)

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

            '---reset timer---
            Timer1.Enabled = False
            Timer1.Enabled = True
            Exit Sub

        Else
            '---User not found---
            lblError.Text = "...NOT A REGISTERED STUDENT..."
            Exit Sub
        End If
    End Sub
    '*************** END OF FINGERX CONTROL EVENTS ************************************
    '*********************************************************************************
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
    Public Sub clearDisplay()
        picFinger.Image = Image.FromFile(Application.StartupPath & "\image\fingerprintreader2.jpg")
        picPassport.Image = Nothing
        lblSname.Text = ""
        lblMiddlename.Text = ""
        lblFirstname.Text = ""
        lblMatric.Text = ""
        lblDept.Text = ""
        lblLevel.Text = ""
        lblProgram.Text = ""
        lblError.Text = "... (ANOTHER STUDENT) PLACE YOUR LEFT THUMB ON THE READER ..."
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        clearDisplay()
        Timer1.Enabled = False
    End Sub
    '--Gets user's information--
    Private Sub GetUserInfo()
        Try
            Dim rdr As OleDbDataReader
            Dim sql As String = ""
            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)

            
            sql = "SELECT * FROM enroll WHERE ID=" & _UserID
            cmd = New OleDbCommand(sql, cn)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                rdr.Read()
                sname = rdr("Surname").ToString
                mname = rdr("Middlename").ToString
                fname = rdr("Firstname").ToString
                matric = rdr("Matric").ToString
                level = rdr("TheLevel").ToString
                prog = rdr("TheProgram").ToString
                dept = rdr("Dept").ToString
                sex = rdr("Sex").ToString
                picPath = rdr("passportPath").ToString
                status = rdr("Status").ToString
                parPhone = rdr("ParPhone").ToString

                Dim TheSex As String = ""
                If sex = "MALE" Then
                    TheSex = "Son"
                ElseIf sex = "FEMALE" Then
                    TheSex = "Daughter"
                End If

                If rdr.IsClosed = False Then rdr.Close()

                'if what is in the database is Signed Out then, You now want to Sign In
                If status.Trim.ToUpper = "SIGNED OUT" Then
                    If lstSignedIn.Items.IndexOf(matric) = -1 Then

                        'remove metric number from signed out list
                        If lstSignedOut.Items.Contains(matric) Then
                            lstSignedOut.Items.RemoveAt(lstSignedOut.Items.IndexOf(matric))
                        End If

                        '---add matric number to signed In list---
                        lstSignedIn.Items.Add(matric)

                        '---update the database---
                        cmd = New OleDbCommand("UPDATE enroll SET Status ='SIGNED IN' WHERE ID=" & _UserID, cn)
                        Dim rep As Integer
                        rep = cmd.ExecuteNonQuery()

                        MsgBox("You are now Signed In")
                        '---Display the Student's Info---
                        lblSname.Text = sname
                        lblMiddlename.Text = mname
                        lblFirstname.Text = fname
                        lblMatric.Text = matric
                        lblDept.Text = dept
                        lblLevel.Text = level
                        lblProgram.Text = prog
                        picPassport.Image = Image.FromFile(Application.StartupPath & picPath)

                        '**********************************************************
                        '*********ADD CODE TO SEND SMS HERE FOR SIGNED IN*********

                        Dim TheMessage As String
                        TheMessage = "This is to inform you that your " & TheSex & ", " & sname & ", " & _
                                        mname & " " & fname & " is in School today " & Date.Now().ToString

                        MyModule.SmsSendMessage(SerialPort1, parPhone, TheMessage)


                        '**********************************************************
                    End If

                    'otherwise if the Dbase contained SIGNED IN then, you now want to Sign Out
                Else

                    If lstSignedOut.Items.IndexOf(matric) = -1 Then

                        '---remove matric number from signed in list---
                        If lstSignedIn.Items.Contains(matric) Then
                            lstSignedIn.Items.RemoveAt(lstSignedIn.Items.IndexOf(matric))
                        End If

                        '---add to sign out list---
                        lstSignedOut.Items.Add(matric)

                        '---update database---
                        cmd = New OleDbCommand("UPDATE enroll SET Status ='SIGNED OUT' WHERE ID=" & _UserID, cn)
                        Dim rep2 As Integer
                        rep2 = cmd.ExecuteNonQuery()

                        MsgBox("You are now Signed Out")

                        '---Display the Student's Info---
                        lblSname.Text = sname
                        lblMiddlename.Text = mname
                        lblFirstname.Text = fname
                        lblMatric.Text = matric
                        lblDept.Text = dept
                        lblLevel.Text = level
                        lblProgram.Text = prog
                        picPassport.Image = Image.FromFile(Application.StartupPath & picPath)


                        '**********************************************************
                        '*********ADD CODE TO SEND SMS HERE FOR SIGNED OUT *********

                        Dim TheMessage As String
                        TheMessage = "This is to inform you that your " & TheSex & ", " & sname & ", " & _
                                        mname & " " & fname & " is now out of School " & Date.Now().ToString

                        MyModule.SmsSendMessage(SerialPort1, parPhone, TheMessage)


                        '**********************************************************
                    End If


                End If

                
                '---reset timer---
                Timer1.Enabled = False
                Timer1.Enabled = True

            Else
                MsgBox("NOT A REGISTERED STUDENT")
                Beep()
                lblError.Text = "ERROR: ...NOT A REGISTERED STUDENT..."

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then MyModule.DisconnectFromDbase(cn)
        End Try
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        FrmInvigilatorForm.Close()
        frmMain.Show()
    End Sub

    Private Sub CloseForTheDayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForTheDayToolStripMenuItem.Click
        Dim reply As String
        Dim reply2 As DialogResult

        reply = InputBox("Please Supply your password", "AUTHENTICATING USER", "Password here")
        If reply <> "" Then
            reply = reply.Trim.ToUpper
            If reply <> FrmSecurityLogin.pswd Then
                MessageBox.Show("You are not qualified to perform this operation")
            Else
                reply2 = MessageBox.Show("Are You Sure You want to Clear Record for the day?", "CONFIRM OPERATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If reply2 = Windows.Forms.DialogResult.Yes Then
                    lstSignedIn.Items.Clear()
                    lstSignedOut.Items.Clear()
                    myUtil.FinalizeGrFinger()
                    If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)
                    cmd = New OleDbCommand("UPDATE enroll SET Status =''", cn)
                End If

            End If
        End If
    End Sub
End Class