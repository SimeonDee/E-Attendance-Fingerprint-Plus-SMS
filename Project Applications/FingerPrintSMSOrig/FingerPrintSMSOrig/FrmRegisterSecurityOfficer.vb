
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb

Public Class FrmRegisterSecurityOfficer
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand

    Private Sub FrmRegisterSecurityOfficer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyModule.ConnectToDBase(cn)

    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If txtPassword.Text = "" Then
            MessageBox.Show("Password Field is required")
            txtSecurityID.Focus()
            Exit Sub
        ElseIf txtSecurityID.Text = "" Then
            MessageBox.Show("Security ID required")
            txtSecurityID.Focus()
            Exit Sub
        End If

        '---verify if user already exist---
        If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)
        Dim rdr As OleDbDataReader
        Dim sql1 As String = "SELECT * FROM SecurityOfficerAccount WHERE SecurityID ='" & _
                                txtSecurityID.Text.Trim.ToUpper & "'"
        cmd = New OleDbCommand(sql1, cn)
        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr.HasRows Then
            MessageBox.Show("Password already assigned to this staff")
            txtSecurityID.Focus()
            Exit Sub
        End If

        '---save record into database---
        Dim sql As String = "INSERT INTO SecurityOfficerAccount(SecurityID,Pswd) VALUES('" & _
                                txtSecurityID.Text.Trim.ToUpper & "','" & txtPassword.Text.Trim.ToUpper & _
                                "')"
        cmd = New OleDbCommand(sql, cn)
        Dim rep As Integer = cmd.ExecuteNonQuery
        If rep > 0 Then
            MessageBox.Show("Account Successfully Created")
            Call clearControls()

        End If

    End Sub
    Private Sub clearControls()
        txtSecurityID.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub FrmRegisterSecurityOfficer_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtSecurityID.Focus()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        '---verify if user already exist---
        Dim TheID As String
        TheID = InputBox("Please Supply user's security number below:", "SUPPLY SECURITY ID", "Security ID here")
        If TheID <> "" Then

            TheID = TheID.Trim.ToUpper
            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)
            Dim rdr As OleDbDataReader
            Dim sql1 As String = "SELECT * FROM SecurityOfficerAccount WHERE SecurityID ='" & _
                                    TheID & "'"
            cmd = New OleDbCommand(sql1, cn)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                MessageBox.Show("Password is << " & rdr("Pswd").ToString & " >>")
                Exit Sub
            Else
                MessageBox.Show("User Not Registered before")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub txtSecurityID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSecurityID.LostFocus
        If txtSecurityID.Text <> "" Then
            If Not (MyModule.IDIsValid(txtSecurityID.Text.Trim.ToUpper)) Then
                MsgBox("The SecurityID Number supplied does not exist" & vbCrLf & "Please Contact Admin For any Complaint")
                txtSecurityID.SelectAll()
            End If
        End If
    End Sub

    Private Sub txtSecurityID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSecurityID.TextChanged

    End Sub
End Class