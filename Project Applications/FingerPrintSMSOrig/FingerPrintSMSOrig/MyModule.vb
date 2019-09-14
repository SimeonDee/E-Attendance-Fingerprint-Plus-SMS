
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************


Imports System.Data
Imports System.Data.OleDb
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
Imports System.IO

Module MyModule

    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand

    Private provider As String = "Provider=Microsoft.Jet.OLEDB.4.0;"       'FOR ACCESS 2002 - 2003

    'Private provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"       'FOR ACCESS 2007 - 2010


    'Private DbFile As String = " Data Source=" & Application.StartupPath & "\DBase\FingerprintSMSDb.accdb; Persist Security Info=false"

    Private DbFile As String = "Data Source=C:\Users\ADEDOYIN\Desktop\E_Attendance\Project\Bio-Metrics Attendance\Database\FingerprintSMSDb.mdb; Persist Security Info=false"
    Public cnStr As String = ""

    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Public Sub ConnectToDBase(ByRef connObj As OleDbConnection)
        Try
            'Opens connection to the database using the connection string
            cnStr = provider & DbFile
            connObj = New OleDbConnection(cnStr)
            connObj.Open()
            'MessageBox.Show("Connection established")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DisconnectFromDbase(ByVal cnnObj As OleDbConnection)
        If cnnObj.State = ConnectionState.Open Then
            cnnObj.Close()
        End If
    End Sub

    Public Sub SmsConnectToPort(ByRef Theserialport As System.IO.Ports.SerialPort)
        Try
            With Theserialport
                .PortName = "COM4"
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .RtsEnable = True
                .DtrEnable = True
                .Encoding.GetEncoder()
                .ReceivedBytesThreshold = 1
                .NewLine = vbCrLf
                If .IsOpen Then .Close()
                .Open()
                MsgBox("SMSport connected")
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub SmsClosePort(ByRef Theserialport As System.IO.Ports.SerialPort)
        Theserialport.Close()
    End Sub

    Public Sub SmsSendMessage(ByRef Theserialport As System.IO.Ports.SerialPort, _
                                ByVal PhoneNumber As String, ByVal theMessage As String)
        Try
            With Theserialport

                If Theserialport.IsOpen = False Then
                    'MsgBox("Error on COM Port!! For SMS")
                    Exit Sub
                End If


                ' Send an 'AT' command to the phone
                .Write("AT" & vbCrLf)
                Sleep(500)
                .Write("AT+CMGF=1" & vbCrLf) 'This line can be removed if your modem will always be in Text Mode...
                Sleep(500)

                .Write("AT+CMGS=" & Chr(34) & PhoneNumber.Trim & Chr(34) & vbCrLf) 'ok here
                Sleep(1000)
                .Write(theMessage.Trim & Chr(26))
                Sleep(2000)

                MsgBox("Message Sent")
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub NumberOnly(ByRef arg As System.Windows.Forms.KeyPressEventArgs)
        If Not ((Asc(arg.KeyChar) >= Keys.NumPad0 - 48) And (Asc(arg.KeyChar) <= Keys.NumPad9 - 48) Or _
                   arg.KeyChar = Chr(Keys.Delete) Or arg.KeyChar = Chr(Keys.Back)) Then

            Beep()
            MsgBox("Invalid character pressed """ & arg.KeyChar & """ Key not allowed")
            arg.KeyChar = Chr(Keys.None)
        End If
    End Sub

    Public Sub NoNumberAllowed(ByRef arg As System.Windows.Forms.KeyPressEventArgs)
        If ((Asc(arg.KeyChar) >= Keys.NumPad0 - 48) And (Asc(arg.KeyChar) <= Keys.NumPad9 - 48)) Then

            Beep()
            MsgBox("Invalid character pressed """ & arg.KeyChar & """ Key not allowed.")
            arg.KeyChar = Chr(Keys.None)
        End If
    End Sub

    Public Sub CopyPassportToFolder(ByVal src As String, ByVal dest As String)
        Try
            'make a copy of the passport to the passports folder in the project
            'using the matric number of candidate as the new passport name

            If src <> "" And dest <> "" Then
                Dim destinationPath As String
                destinationPath = Application.StartupPath & dest

                If File.Exists(destinationPath) Then
                    File.Delete(destinationPath)
                End If

                File.Copy(src, destinationPath)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Function IDIsValid(ByVal myID As String) As Boolean
        Try

            ConnectToDBase(cn)

            Dim returnValue As Boolean = False
            Dim rdr2 As OleDbDataReader
            cmd = New OleDbCommand("SELECT * FROM AllStaffID WHERE StaffID ='" & myID & "'", cn)
            rdr2 = cmd.ExecuteReader
            If rdr2.HasRows Then
                returnValue = True
            Else
                returnValue = False
            End If
            If rdr2.IsClosed = False Then rdr2.Close()

            Return returnValue

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function MatricNumberIsValid(ByVal myMatric As String) As Boolean
        Try
            ConnectToDBase(cn)

            Dim returnValue As Boolean = False
            Dim rdr2 As OleDbDataReader
            cmd = New OleDbCommand("SELECT * FROM AllMatricNumbers WHERE Matric ='" & myMatric & "'", cn)
            rdr2 = cmd.ExecuteReader

            If rdr2.HasRows Then
                returnValue = True
            Else
                returnValue = False
            End If
            If rdr2.IsClosed = False Then rdr2.Close()

            Return returnValue

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Module
