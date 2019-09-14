Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports

Delegate Sub SetTextCallback(ByVal [text] As String)

Public Class FrmSMSTester

    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        SerialPort1.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To (System.IO.Ports.SerialPort.GetPortNames.Length - 1)
            cboPorts.Items.Add(System.IO.Ports.SerialPort.GetPortNames(i).Trim)
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With SerialPort1

            If SerialPort1.IsOpen = False Then
                MsgBox("Error on COmport!!")
                Exit Sub
            End If


            ' Send an 'AT' command to the phone
            .Write("AT" & vbCrLf)
            Sleep(500)
            .Write("AT+CMGF=1" & vbCrLf) 'This line can be removed if your modem will always be in Text Mode...
            Sleep(500)

            .Write("AT+CMGS=" & Chr(34) & TxtNumber.Text.Trim & Chr(34) & vbCrLf) 'ok here
            Sleep(1000)
            .Write(TxtMessage.Text.Trim & Chr(26))
            Sleep(2000)

            MsgBox("Message Sent")
        End With

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(LinkLabel1.Text)
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        'Dim buffer As String
        SetText(SerialPort1.ReadExisting())


    End Sub
    Private Sub SetText(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.TextBox1.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.TextBox1.Text &= [text]
        End If
    End Sub

    Private Sub setMyText()

    End Sub
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        If btnConnect.Text = "Connect" Then
            With SerialPort1
                .PortName = cboPorts.Text.Trim
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .RtsEnable = True
                .DtrEnable = True
                SerialPort1.Encoding.GetEncoder()
                .ReceivedBytesThreshold = 1
                .NewLine = vbCrLf
                If .IsOpen Then .Close()
                .Open()
                MsgBox("Connected")
                btnConnect.Text = "Disconnect"
                cboPorts.Enabled = False
            End With
        Else
            SerialPort1.Close()
            MsgBox("Disconnected")
            btnConnect.Text = "Connect"
            cboPorts.Enabled = True
        End If
    End Sub

End Class
