Imports System.Data
Imports System.Data.OleDb

Public Class FrmSecurityLogin
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Public securityID, pswd As String

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        '---verify if user already exist---
        If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)
        Dim rdr As OleDbDataReader
        Dim sql As String = "SELECT * FROM SecurityOfficerAccount WHERE SecurityID ='" & _
                                txtSecurityID.Text.Trim.ToUpper & "' AND Pswd ='" & txtPassword.Text.Trim.ToUpper & "'"
        cmd = New OleDbCommand(sql, cn)
        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr.HasRows Then
            rdr.Read()
            securityID = rdr("SecurityID").ToString
            pswd = rdr("Pswd").ToString

            Call clearControls()

            If rdr.IsClosed = False Then rdr.Close()

            Me.Hide()
            FrmSecurityEntry.Show(Me)
        Else
            MessageBox.Show("Invalid Account Details." & vbCrLf & _
                            "Please verify your details or visit the Admin to obtain your password")

            clearControls()
            txtSecurityID.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub FrmSecurityLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyModule.ConnectToDBase(cn)
    End Sub
    Private Sub clearControls()
        txtSecurityID.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub FrmSecurityLogin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtSecurityID.Focus()
    End Sub
End Class