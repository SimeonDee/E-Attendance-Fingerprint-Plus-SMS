Imports GrFingerXLib
Public Class frminec2
    '---Database name---------------------------------------------------
    Const DBFile = "GrFingerSample.mdb"
    Const Logfile = "C:\Log.csv"
    Const ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="

    '--- this is for Util.vb class that define the management of fingerprint -------------
    Private myUtil As util
    '---this declaration is to store user’s ID----------
    Private _UserID As Integer
    '---this is database connection string---
    Private connection As System.Data.OleDb.OleDbConnection
    '                                           GrFingerX events
    ' -----------------------------------------------------------------------------------
    ' ------ When fingerprint reader was plugged on system ----
    Private Sub AxGrFingerXCtrl1_SensorPlug( _
       ByVal sender As System.Object, _
       ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent) _
       Handles AxGrFingerXCtrl1.SensorPlug
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Plugged.")
        AxGrFingerXCtrl1.CapStartCapture(e.idSensor)
    End Sub
    ' ---- When remove fingerprint reader from system ----
    Private Sub AxGrFingerXCtrl1_SensorUnplug( _
       ByVal sender As System.Object, _
       ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEvent) _
       Handles AxGrFingerXCtrl1.SensorUnplug
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Unplugged.")
        AxGrFingerXCtrl1.CapStopCapture(e.idSensor)
    End Sub
    ' ---- When finger was placed on fingerreader-----
    Private Sub AxGrFingerXCtrl1_FingerDown( _
       ByVal sender As System.Object, _
       ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEvent) _
       Handles AxGrFingerXCtrl1.FingerDown
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Finger Placed.")
    End Sub
    ' ---- When finger was removed from fingerreader-----
    Private Sub AxGrFingerXCtrl1_FingerUp( _
       ByVal sender As System.Object, _
       ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEvent) _
       Handles AxGrFingerXCtrl1.FingerUp
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Finger removed.")
    End Sub
    ' ---When an image was acquired from fingerreader----
    Private Sub AxGrFingerXCtrl1_ImageAcquired( _
       ByVal sender As System.Object, _
       ByVal e As AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent) _
       Handles AxGrFingerXCtrl1.ImageAcquired

        '--- To Copying aquired image----
        myUtil.raw.height = e.height
        myUtil.raw.width = e.width
        myUtil.raw.res = e.res
        myUtil.raw.img = e.rawImage

        ' -----To Signal that an Image Event occurred -----
        myUtil.WriteLog("Sensor: " & e.idSensor & ". Event: Image captured.")

        ' -----TO display fingerprint image----
        myUtil.PrintBiometricDisplay(False, GRConstants.GR_DEFAULT_CONTEXT)

        '---To extract the template from the fingerprint scanned---
        ExtractTemplate()

        '---To identify whom the user is---
        _UserID = IdentifyFingerprint()
        If _UserID > 0 Then
            '---If user found---
            Beep()
            bttRegister.Enabled = False
            bttLoad.Enabled = False
            GetControlDisable()
            chkyes.Visible = False
            chkno.Visible = False
            '---display user's information---
            GetUserInfo()
            '---writes to log file---
            WriteToLog(_UserID)
        Else
            '---user not found---
            'btnedit.Enabled = False
            ClearDisplay()
            chkyes.Visible = True
            chkno.Visible = True
            Beep()
            lblmessage.Text = "User not found! You can proceed your registration"
        End If
    End Sub
    '---get user's information---
    Public Sub GetUserInfo()
        Dim filePath As String
        Try
            'filePath = Application.StartupPath() & "\" & DBFile
            filePath = "C:\INEC\INEC" & "\" & DBFile
            connection = New OleDb.OleDbConnection(ConnectionString & filePath)
            connection.Open()
            Dim reader As OleDb.OleDbDataReader
            Dim command As OleDb.OleDbCommand = New OleDb.OleDbCommand
            command.Connection = connection
            '---retrieve user's particulars---
            command.CommandText = "SELECT * FROM Enroll WHERE ID=" & _UserID
            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            reader.Read()
            '---display user's particulars---
            lblmessage.Text = "You are not permmited to register again, " & reader("surname")
            txtsurname.Text = reader("surname")
            txtother.Text = reader("othername")
            txtnumber.Text = reader("phonenum")
            txtoccupate.Text = reader("occupation")
            txtage.Text = reader("age")
            txtemail.Text = reader("email")
            txtsex.Text = reader("sex")
            txtdate.Text = reader("birthday")
            txtid.Text = reader("id")
            txtstate.Text = reader("state")
            txtaddress.Text = reader("resident")
            Me.lblpicture.Text = reader("picture")
            '---reset the timer to another 5 seconds---
            Timer1.Enabled = False
            Timer1.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            connection.Close()
        End Try
    End Sub
    '---Add a new user's information to the database---
    Public Sub AddNewUser()
        Dim filePath As String
        Try

            'filePath = Application.StartupPath() & "\" & DBFile
            filePath = "C:\INEC\INEC" & "\" & DBFile
            connection = New OleDb.OleDbConnection(ConnectionString & filePath)
            connection.Open()
            ' Dim command As OleDb.OleDbCommand = New OleDb.OleDbCommand
            '---set the user's particulars in the table---
            Dim sql As String = "UPDATE enroll SET surname='" & txtsurname.Text & "', " & _
               " phonenum=" & txtnumber.Text & ", " & _
               " occupation='" & txtoccupate.Text & "', " & _
               " birthday='" & txtdate.Text & "', " & _
               " state='" & txtstate.Text & "', " & _
               " age='" & txtage.Text & "', " & _
               " othername='" & txtother.Text & "', " & _
               " email='" & txtemail.Text & "', " & _
               " sex='" & txtsex.Text & "', " & _
               " picture='" & Me.lblpicture.Text & "', " & _
               " resident='" & txtaddress.Text & "' " & _
               " WHERE ID=" & _UserID
            Dim command As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, connection)
            'command.CommandText = sql
            command.ExecuteNonQuery()
            MsgBox("User added successfully!")
            chkyes.Visible = True
            chkno.Visible = True
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    '---the Timer control---
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClearDisplay()
        Me.PictureBox1.Image = Nothing
        GetControlEnable()
        Timer1.Enabled = False
    End Sub
    Public Sub ClearDisplay()
        lblmessage.Text = _
           "Please place your left thumb on the fingerprint reader"
        'PictureBox1.Image = My.Resources.fingerprintreader
        txtsurname.Text = String.Empty
        txtnumber.Text = String.Empty
        txtemail.Text = String.Empty
        txtsex.Text = String.Empty
        txtaddress.Text = String.Empty
        Me.txtage.Text = String.Empty
        Me.txtdate.Text = String.Empty
        Me.txtoccupate.Text = String.Empty
        Me.txtother.Text = String.Empty
        Me.txtstate.Text = String.Empty
        Me.PictureBox2.Image = Nothing
        Me.lblpicture.Text = String.Empty

    End Sub
    Public Sub GetControlDisable()
        Me.txtaddress.Enabled = False
        Me.txtemail.Enabled = False
        Me.txtnumber.Enabled = False
        Me.txtsex.Enabled = False
        Me.txtsurname.Enabled = False
        Me.txtage.Enabled = False
        Me.txtoccupate.Enabled = False
        Me.txtother.Enabled = False
        Me.txtstate.Enabled = False
        Me.txtdate.Enabled = False
    End Sub
    Public Sub GetControlEnable()
        Me.txtaddress.Enabled = True
        Me.txtemail.Enabled = True
        Me.txtsurname.Enabled = True
        Me.txtsex.Enabled = True
        Me.txtnumber.Enabled = True
        Me.txtage.Enabled = False
        Me.txtoccupate.Enabled = True
        Me.txtother.Enabled = True
        Me.txtstate.Enabled = True
        Me.txtdate.Enabled = True
    End Sub

    ' Extract a template from a fingerprint image
    Private Function ExtractTemplate() As Integer
        Dim ret As Integer
        ' extract template
        ret = myUtil.ExtractTemplate()
        ' write template quality to log
        If ret = GRConstants.GR_BAD_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. Bad quality.")
        ElseIf ret = GRConstants.GR_MEDIUM_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. Medium quality.")
        ElseIf ret = GRConstants.GR_HIGH_QUALITY Then
            myUtil.WriteLog("Template extracted successfully. High quality.")
        End If
        If ret >= 0 Then
            ' if no error, display minutiae/segments/directions into the image
            myUtil.PrintBiometricDisplay(True, GRConstants.GR_NO_CONTEXT)
        Else
            ' write error to log
            myUtil.WriteError(ret)
        End If
        Return ret
    End Function
    '  Public img As String
    Private Function IdentifyFingerprint() As Integer
        '---Identify a fingerprint; returns the ID of the user---
        Dim ret As Integer, score As Integer
        score = 0
        ' identify it
        ret = myUtil.Identify(score)
        ' write result to log
        If ret > 0 Then
            myUtil.WriteLog("Fingerprint identified. ID = " & ret & ". Score = " & score & ".")
            myUtil.PrintBiometricDisplay(True, GRConstants.GR_DEFAULT_CONTEXT)
            'NOTE THIS AREA WHEN RUN THE PROGRAM
        ElseIf ret = 0 Then
            myUtil.WriteLog("Fingerprint not Found.")
        Else
            myUtil.WriteError(ret)
        End If
        Return ret
    End Function
    Private Sub frminec2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' --- initialize error -----
        Dim err As Integer
        'Dim day, month, year As Integer
        '--- to initialize util class -----
        myUtil = New util(ListBox1, PictureBox1, AxGrFingerXCtrl1)
        ' ----- to Initialize GrFingerX Library ----
        err = myUtil.InitializeGrFinger()
        ' ---- to Print the result in log ------
        If err < 0 Then
            myUtil.WriteError(err)
            Exit Sub
        Else
            myUtil.WriteLog( _
               "**GrFingerX Initialized Successfull**")
        End If

        '--- to create a log file  ---
        If Not System.IO.File.Exists(Logfile) Then
            System.IO.File.Create(Logfile)
        End If
        bttRegister.Enabled = False
        bttLoad.Enabled = False
        GetControlDisable()
        chkyes.Visible = False
        chkno.Visible = False
        With txtsex
            .Items.Add("MALE")
            .Items.Add("FEMALE")
        End With
        With txtstate
            .Items.Add("ABIA")
            .Items.Add("ADAMAWA")
            .Items.Add("AKWA IBOM")
            .Items.Add("ANAMBRA")
            .Items.Add("BAUCHI")
            .Items.Add("BANUE")
            .Items.Add("BORNU")
            .Items.Add("CROSS RIVER")
            .Items.Add("DELTA")
            .Items.Add("EDO")
            .Items.Add("ENUGU")
            .Items.Add("EKITI")
            .Items.Add("GOMBE")
            .Items.Add("IMO")
            .Items.Add("JIGAWA")
            .Items.Add("KADUNA")
            .Items.Add("KANO")
            .Items.Add("KASTINA")
            .Items.Add("KEBI")
            .Items.Add("KOGI")
            .Items.Add("KWARA")
            .Items.Add("LAGOS")
            .Items.Add("NASARAWA")
            .Items.Add("NIGER")
            .Items.Add("OGUN")
            .Items.Add("ONDO")
            .Items.Add("OSUN")
            .Items.Add("OYO")
            .Items.Add("PLATUE")
            .Items.Add("RIVER")
            .Items.Add("SOKOTO")
            .Items.Add("TARABA")
            .Items.Add("ZAMFARA")
            .Items.Add("FCT")


        End With
    End Sub
    Private Sub lblpicture_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblpicture.TextChanged
        If lblpicture.Text = "" Then
            'Me.PictureBox2.Image = My.Resources.fingerprintreader
            Exit Sub
        End If
        Me.PictureBox2.Image = Image.FromFile(Me.lblpicture.Text)
    End Sub
    Public Sub WriteToLog(ByVal ID As String)
        '---write to a log file---
        Dim sw As New System.IO.StreamWriter( _
           Logfile, True, System.Text.Encoding.ASCII)
        sw.WriteLine(ID & "," & Now.ToString)
        sw.Close()
    End Sub
    Private Function EnrollFingerprint() As Integer
        Dim id As Integer
        ' add fingerprint
        id = myUtil.Enroll()
        ' write result to log
        If id >= 0 Then
            myUtil.WriteLog("Fingerprint enrolled with id = " & id)
        Else
            myUtil.WriteLog("Error: Fingerprint not enrolled")
        End If
        Return id
    End Function
    Private Sub bttExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttExit.Click
        End
    End Sub

    Private Sub bttLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttLoad.Click
        OpenFileDialog1.Filter = "Images|*.GIF;*.JPG;*.TIF;*.JPEG;*.BMP"
        Me.OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        Else
            Me.lblpicture.Text = Me.OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub bttRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttRegister.Click
        '---first add the fingerprint---
        _UserID = EnrollFingerprint()
        '---then add the particulars---
        If txtsurname.Text = "" Then
            MsgBox("Enter your surname!")
            txtsurname.Focus()
            Exit Sub
        End If
        If txtage.Text < 18 Then
            MsgBox("You are not qualify to register")
            MsgBox("Thank you")
            End
        End If

        AddNewUser()
        PictureBox1.Image = Nothing

        '---clears the display---
        ClearDisplay()
        chkno.Visible = False
        chkyes.Visible = False
        '---writes to log file---
        WriteToLog(_UserID)
    End Sub

    Private Sub chkyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkyes.CheckedChanged
        If chkyes.Checked = True Then
            MsgBox("YOU CHOOSE YES TO REGISTER AS A VOTER", MsgBoxStyle.Information)
            bttRegister.Enabled = True
            bttLoad.Enabled = True
            GetControlEnable()
            txtsurname.Focus()
        End If
    End Sub

    Private Sub chkno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkno.CheckedChanged
        If chkno.Checked = True Then
            MsgBox("YOU CHOOSE NO TO END PROJECT", MsgBoxStyle.Information)
            End
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtdate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdate.LostFocus
        Dim sDate1 As String
        Dim dDate1 As Date
        Dim aDate As Date
        aDate = Now()
        sDate1 = txtdate.Text
        Try
            dDate1 = System.DateTime.Parse(sDate1)
            txtage.Text = DateDiff(DateInterval.Year, dDate1, aDate)
        Catch exc As Exception
            MsgBox("You’ve entered an invalid date")
            txtdate.Text = ""
            txtage.Text = ""
        End Try
    End Sub
  
End Class