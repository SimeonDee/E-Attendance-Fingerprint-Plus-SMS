
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb

Public Class FrmBulkSMS
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim sql As String = ""

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Try
            If radAllStaff.Checked = False And radAllParents.Checked = False Then
                MsgBox("Please select the option above (To All Staff or All Parents)")
                Exit Sub
            End If
            If TxtMessage.Text = "" Then
                MessageBox.Show("Please type your message")
                TxtMessage.Focus()
                Exit Sub
            End If

            If radAllStaff.Checked Then
                sql = "SELECT Phone FROM StaffDataReg"
            ElseIf radAllParents.Checked Then
                sql = "SELECT parPhone FROM PersonalData"
            End If

            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)
            cmd = New OleDbCommand(sql, cn)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                While rdr.Read
                    If rdr(0).ToString <> "" Then
                        MyModule.SmsSendMessage(SerialPort1, rdr(0).ToString, TxtMessage.Text.Trim)
                    End If
                End While

                MessageBox.Show("Message successfully sent")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmBulkSMS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MyModule.DisconnectFromDbase(cn)
        MyModule.SmsClosePort(SerialPort1)
    End Sub

    Private Sub FrmBulkSMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyModule.ConnectToDBase(cn)
        MyModule.SmsConnectToPort(SerialPort1)
        pnlMsg.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub radAllStaff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAllStaff.CheckedChanged

    End Sub

    Private Sub radAllStaff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radAllStaff.Click
        pnlMsg.Enabled = True
    End Sub
End Class