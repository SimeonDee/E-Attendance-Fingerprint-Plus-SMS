Imports System.Data
Imports System.Data.OleDb
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports

Module MyModule

    Private provider As String = "Provider=Microsoft.Jet.OLEDB.4.0;"
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
                MsgBox("Please check your device now to allow connection")
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
                Sleep(400)
                'Sleep(100)
                .Write("AT+CMGF=1" & vbCrLf) 'This line can be removed if your modem will always be in Text Mode...
                Sleep(400)
                'Sleep(100)

                .Write("AT+CMGS=" & Chr(34) & PhoneNumber.Trim & Chr(34) & vbCrLf) 'ok here
                Sleep(800)
                'Sleep(200)
                .Write(theMessage.Trim & Chr(26))
                Sleep(1800)
                'Sleep(200)

                MsgBox("Message Sent")
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
