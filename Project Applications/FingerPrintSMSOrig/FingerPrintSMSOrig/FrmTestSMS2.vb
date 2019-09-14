
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************


'Imports System
'Imports System.IO.Ports
'Imports System.ComponentModel

Public Class FrmTestSMS2
    Dim sms As SMSCOMMS

    Private Sub FrmTestSMS2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To (System.IO.Ports.SerialPort.GetPortNames.Length - 1)
            cboPorts.Items.Add(System.IO.Ports.SerialPort.GetPortNames(i).Trim)
        Next
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        If btnConnect.Text = "Connect" Then
            sms = New SMSCOMMS(cboPorts.Text.Trim)
            sms.Open()
            If sms.IsOpen() Then

                MsgBox("Connected Successfully")
                btnConnect.Text = "Disconnected"
                cboPorts.Enabled = False
            End If
        Else
            If sms.IsOpen() Then
                sms.Close()
                MsgBox("Disconnection successful")
                btnConnect.Text = "Connect"
                cboPorts.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sms.SendSMS(TxtNumber.Text.Trim, TxtMessage.Text.Trim)
        MsgBox("Message Sent")
    End Sub
End Class