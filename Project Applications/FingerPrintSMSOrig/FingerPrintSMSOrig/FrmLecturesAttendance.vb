
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb

Public Class FrmLecturesAttendance

    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand

    Public registeredStudents As ArrayList

    Public LecturerId, Course, Dept, Title, Unit, Prog, Period, theDate, TheSession, semester, Level As String

    Private Sub FrmLecturesAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblDate.Text = DateString

        Dim yr1, yr2 As Integer
        For yr1 = 2012 To 2050
            yr2 = (yr1 + 1) Mod 1000
            cboSession.Items.Add(yr1.ToString & "/" & yr2.ToString)
        Next

        With cboDept.Items
            .Add("CS")
            .Add("FT")
            .Add("LT")
            .Add("ST")
        End With

        With cboLevel
            .Items.Add("ND I")
            .Items.Add("ND I YR I")
            .Items.Add("ND II")
            .Items.Add("ND II YR II")
            .Items.Add("ND II YR III")
            .Items.Add("HND I")
            .Items.Add("HND II")

        End With

        With cboProgram
            .Items.Add("F/T")
            .Items.Add("P/T")
        End With

        With cboSemester
            .Items.Add("FIRST")
            .Items.Add("SECOND")
        End With
        cboDept.Text = "--Select Dept--"
        cboPeriod.Text = "--Select Period--"
        cboSession.Text = "--Select Session--"
        cboProgram.Text = "--Select Program--"
        cboLevel.Text = "--Select Level--"
        cboSemester.Text = "--Select Semester--"
        cboCourses.Text = "--Select course--"
        txtLecturerID.Text = FrmLogin.TheUserName
        radOne.Checked = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmMain.Show()

    End Sub

    Private Sub btnLoadCourses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadCourses.Click
        Try
            MyModule.ConnectToDBase(cn)
            Dim rdr As OleDbDataReader
            Dim sql As String = "SELECT CCode FROM AdminAllCourses WHERE LecturerID='" & txtLecturerID.Text.Trim.ToUpper & "'"
            cmd = New OleDbCommand(sql, cn)
            rdr = cmd.ExecuteReader()
            If rdr.HasRows Then
                While rdr.Read
                    cboCourses.Items.Add(rdr("CCode").ToString)
                End While
                cboCourses.SelectedIndex = 0
                MessageBox.Show("Courses loaded")
                pnlLoadcourse.Enabled = False
                Panel3.Enabled = True
                cboCourses.Focus()
                btnGetDetails.Enabled = True
                rdr.Close()
            Else
                MessageBox.Show("You are not assigned to any course." & vbCrLf & "visit the admin.")
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MyModule.DisconnectFromDbase(cn)
        End Try
    End Sub
    Private Sub validateControls(ByRef err As Boolean)
        err = False
        If txtLecturerID.Text = "" Then
            err = True
            MessageBox.Show("Supply your ID")
            txtLecturerID.Focus()
        ElseIf cboDept.Text.Trim.ToUpper = "--SELECT DEPT--" Or cboDept.Text = "" Then
            err = True
            MessageBox.Show("Please select the department to take attendance for")
            cboDept.Focus()
        ElseIf cboPeriod.Text.ToUpper = "--SELECT PERIOD--" Or cboPeriod.Text = "" Then
            err = True
            MessageBox.Show("please select the period for the lecture")
            cboPeriod.Focus()
        ElseIf cboSession.Text.Trim.ToUpper = "--SELECT SESSION--" Or cboSession.Text = "" Then
            err = True
            MessageBox.Show("Please select the current session")
            cboSession.Focus()
        ElseIf cboProgram.Text.Trim.ToUpper = "--SELECT PROGRAM--" Or cboProgram.Text = "" Then
            err = True
            MessageBox.Show("Please select the Program")
            cboProgram.Focus()
        ElseIf cboLevel.Text.Trim.ToUpper = "--SELECT LEVEL--" Or cboLevel.Text = "" Then
            err = True
            MessageBox.Show("Please select the Level")
            cboLevel.Focus()
        End If

    End Sub

    Private Sub btnGetDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDetails.Click
        If cboCourses.Text.Trim.ToUpper = "--SELECT COURSE--" Or cboCourses.Text = "" Then
            MessageBox.Show("Please select Course Code")
            cboCourses.Focus()
            Exit Sub
        ElseIf cboDept.Text.Trim.ToUpper = "--SELECT DEPT--" Or cboDept.Text = "" Then
            MessageBox.Show("Please select the department")
            cboDept.Focus()
            Exit Sub
        ElseIf cboLevel.Text.Trim.ToUpper = "--SELECT LEVEL--" Or cboDept.Text = "" Then
            MessageBox.Show("Please select the Level")
            cboLevel.Focus()
            Exit Sub
        End If

        Try
            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)
            Dim rdr As OleDbDataReader
            Dim sql As String = "SELECT * FROM AdminAllCourses WHERE " & _
                                "CCode ='" & cboCourses.Text.Trim.ToUpper & "' " & _
                                "AND Dept ='" & cboDept.Text.Trim.ToUpper & "' " & _
                                "AND TheLevel ='" & cboLevel.Text.Trim.ToUpper & "'"
            cmd = New OleDbCommand(sql, cn)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                txtTitle.Text = rdr("CTitle").ToString
                txtUnit.Text = rdr("CUnit").ToString
                cboSemester.Text = rdr("Semester").ToString
                'cboLevel.Text = rdr("TheLevel").ToString
                cboProgram.Text = rdr("TheProgram").ToString

                rdr.Close()
                txtTitle.Enabled = False
                txtUnit.Enabled = False
                cboSemester.Enabled = False
                cboLevel.Enabled = True
                cboProgram.Enabled = False

                Panel4.Enabled = True
                btnTakeAttendance.Enabled = True

                cboSession.Focus()
            Else
                MessageBox.Show("There is no such course offered by such Department" & vbCrLf & _
                                "Please visit the Admin for more details")
                If rdr.IsClosed = False Then rdr.Close()
                Exit Sub
            End If

            If rdr.IsClosed = False Then rdr.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnTakeAttendance_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTakeAttendance.Click

        Dim erOccured As Boolean = False

        Call validateControls(erOccured)
        If erOccured Then Exit Sub

        LecturerId = txtLecturerID.Text.Trim.ToUpper
        Course = cboCourses.Text.Trim.ToUpper
        Title = txtTitle.Text.Trim.ToUpper
        Unit = txtUnit.Text.Trim.ToUpper
        Dept = cboDept.Text.Trim.ToUpper
        TheSession = cboSession.Text.Trim
        Semester = cboSemester.Text.Trim.ToUpper
        Level = cboLevel.Text.Trim.ToUpper
        Prog = cboProgram.Text.Trim.ToUpper
        Period = cboPeriod.Text.Trim.ToUpper
        theDate = lblDate.Text

        Try

            registeredStudents = New ArrayList()
            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)

            Dim rdr As OleDbDataReader
            Dim sql As String = "SELECT * FROM RegisteredCourses WHERE CCode='" & _
                                Course & "' AND Dept='" & Dept & "' "

            cmd = New OleDbCommand(sql, cn)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                While rdr.Read()
                    registeredStudents.Add(rdr("Matric").ToString)
                End While

                If registeredStudents.Count > 0 Then registeredStudents.Sort()

                rdr.Close()

                Me.Hide()
                FrmLectureBiometrics.Show(frmMain)

            Else
                MessageBox.Show("No student has registered for this course")
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub radOne_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radOne.Click
        If radOne.Checked Then
            cboPeriod.Items.Clear()
            For i As Integer = 8 To 17
                Dim tm As String, j, k As Integer

                If i >= 12 Then
                    tm = "pm"
                Else
                    tm = "am"
                End If

                If i > 12 Then
                    k = i Mod 12
                Else
                    k = i
                End If

                If k = 12 Then
                    j = 1
                Else
                    j = k + 1
                End If


                cboPeriod.Items.Add(k.ToString & " - " & j.ToString & tm)
            Next
        End If
    End Sub

    Private Sub radTwo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radTwo.Click
        If radTwo.Checked Then
            cboPeriod.Items.Clear()

            Dim tm As String, j, k As Integer
            For i As Integer = 8 To 17 Step 2


                If i >= 12 Then
                    tm = "pm"
                Else
                    tm = "am"
                End If

                If i > 12 Then
                    k = i Mod 12
                Else
                    k = i
                End If

                If k = 12 Then
                    j = 2
                Else
                    j = k + 2
                End If


                cboPeriod.Items.Add(k.ToString & " - " & j.ToString & tm)
            Next
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.Show()
    End Sub
End Class