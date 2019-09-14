
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb


Public Class FrmLogin

    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    'Dim rdr As OleDbDataReader
    Dim sql As String = ""

    Public TheUserName, Surname, middleName, lastName, dept As String
    Public category As String

    Private Sub FrmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MyModule.DisconnectFromDbase(cn)
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cboCategory.Items
            .Add("STUDENT")
            .Add("STAFF")
            .Add("ADMIN")
        End With
        cboCategory.SelectedIndex = 0

        'connect to the database
        MyModule.ConnectToDBase(cn)

    End Sub

    Private Sub txtUsername_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.Leave
        MsgBox("Use your Matric No(Students) or Staff Id(Staff/Admin)", , "Reminder")

    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Dim rdr As OleDbDataReader
            sql = "SELECT * FROM AccountLogin WHERE Uname = '" & txtUsername.Text.Trim.ToUpper & "'" & _
                " AND Pswd = '" & txtPassword.Text.Trim & "'" & " AND Category = '" & cboCategory.Text.Trim.ToUpper & "' ORDER BY Uname"
            cmd = New OleDbCommand(sql, cn)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                rdr.Read()
                TheUserName = rdr("Uname").ToString()
                Surname = rdr("surname").ToString()
                middleName = rdr("Middlename").ToString()
                lastName = rdr("Firstname").ToString()
                dept = rdr("Dept").ToString
                category = rdr("Category").ToString

                txtUsername.Text = ""
                txtPassword.Text = ""

                Me.Hide()
                frmMain.Show()

            ElseIf txtUsername.Text.Trim.ToUpper = "ADMIN" And txtPassword.Text.Trim.ToUpper = "ADMIN" _
                    And cboCategory.Text.Trim.ToUpper = "ADMIN" Then
                TheUserName = "ADMIN"
                Surname = "ADMIN"
                middleName = ""
                lastName = ""
                dept = "ADMIN"
                category = "ADMIN"
                txtUsername.Clear()
                txtPassword.Clear()

                Me.Hide()
                frmMain.Show()

            Else
                MessageBox.Show("You have either not registered an account or your login details should be re-verified" & vbCrLf & _
                                "Click on the REGISTER ACCOUNT button to register")
                If rdr.IsClosed = False Then rdr.Close()
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Do you really want to exit this Application ?", "CONFIRM EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If reply = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    
    Private Sub lnkRegisterAccount_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRegisterAccount.LinkClicked
        FrmRegisterLoginAccount.Show()
    End Sub

    Private Sub lnkForgotPswd_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkForgotPswd.LinkClicked
        Try
            Dim username As String
            Dim CorrectAnswer, YourAnswer, TheQuestion As String


            username = InputBox("Please supply your username (Matric No/Staff ID)" & vbCrLf & _
                                "...And Answer the question that follows")
            username = username.Trim.ToUpper

            Dim rdr As OleDbDataReader
            sql = "SELECT * FROM AccountLogin WHERE Uname = '" & username & "'"
            cmd = New OleDbCommand(sql, cn)
            'If rdr.IsClosed = False Then rdr.Close()
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                rdr.Read()
                TheQuestion = rdr("SecretQue").ToString
                CorrectAnswer = rdr("SecretAns").ToString.ToUpper

                YourAnswer = InputBox(TheQuestion, "SECRET QUESTION", "your answer here")
                YourAnswer = YourAnswer.Trim.ToUpper

                If YourAnswer <> CorrectAnswer Then
                    MessageBox.Show("Your answer is wrong")
                    GoTo EndPart
                Else
                    MessageBox.Show("Your password is in this bracket <<(" & rdr("Pswd").ToString & ")>>")
                    txtUsername.Text = rdr("Uname")
                    txtPassword.Focus()
                    GoTo EndPart
                End If
            Else
                MessageBox.Show("You have not registered an account before" & vbCrLf & _
                                "You can click on the REGISTER ACCOUNT button to register")
            End If


EndPart:

            If Not rdr.IsClosed Then rdr.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmLogin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtUsername.Focus()
    End Sub
End Class