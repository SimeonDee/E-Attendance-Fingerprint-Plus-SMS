
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb

Public Class FrmInvigilatorForm

    'Creating Database connection ojects
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand

    Public registeredStudents As ArrayList
    Public regStudentsCounter As Integer = 0
    Public InvigilatorID, Code, Title, Unit, Semester, Dept, Level, TheProgram, TheSession, Venue, TheTime, TheDate As String


    Private Sub radOne_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub radTwo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub radThree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnTakeAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTakeAttendance.Click

        Dim erOccured As Boolean = False

        Call validateControls(erOccured)
        If erOccured Then Exit Sub

        InvigilatorID = txtInvigilatorID.Text.Trim.ToUpper
        Code = txtCcode.Text.Trim.ToUpper
        Title = txtCTitle.Text.Trim.ToUpper
        Unit = cboCUnit.Text.Trim.ToUpper
        Dept = cboDept.Text.Trim.ToUpper
        TheSession = cboSession.Text.Trim
        Semester = cboSemester.Text.Trim.ToUpper
        Level = cboLevel.Text.Trim.ToUpper
        TheProgram = cboProgram.Text.Trim.ToUpper
        Venue = txtVenue.Text.Trim.ToUpper
        TheTime = cboTime.Text.Trim.ToUpper
        TheDate = lblDate.Text.Trim

        Try

            registeredStudents = New ArrayList()
            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)

            Dim rdr As OleDbDataReader
            Dim sql As String = "SELECT * FROM RegisteredCourses WHERE CCode='" & _
                                Code & "' AND Dept='" & Dept & "' "

            cmd = New OleDbCommand(sql, cn)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                While rdr.Read()
                    registeredStudents.Add(rdr("Matric").ToString)
                End While

                If registeredStudents.Count > 0 Then registeredStudents.Sort()

                rdr.Close()

                Me.Hide()
                FrmExamBiometrics.Show(frmMain)

            Else
                MessageBox.Show("No student has registered for this course")
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub FrmInvigilatorForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If cn.State = ConnectionState.Open Then MyModule.DisconnectFromDbase(cn)
    End Sub

    Private Sub FrmInvigilatorForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = DateString

        Dim yr1, yr2 As Integer
        For yr1 = 2012 To 2050
            yr2 = (yr1 + 1) Mod 1000
            cboSession.Items.Add(yr1.ToString & "/" & yr2.ToString)
        Next

        For k As Integer = 1 To 6
            cboCUnit.Items.Add(k)
        Next

        With cboDept
            .Items.Add("CS")
            .Items.Add("FT")
            .Items.Add("ST")
            .Items.Add("LT")
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

        txtInvigilatorID.Text = FrmLogin.TheUserName
        cboSession.Text = "--Select Session--"
        cboCUnit.Text = "--Select Unit--"
        cboDept.Text = "--Select Dept--"
        cboLevel.Text = "--Select Level--"
        cboProgram.Text = "--Select Program--"
        cboSemester.Text = "--Select Semester--"
        cboTime.Text = "--Select Exam Time--"

        radOne.Checked = True
        'connect to database
        MyModule.ConnectToDBase(cn)

    End Sub

    Private Sub validateControls(ByRef er As Boolean)
        er = False
        If txtInvigilatorID.Text = "" Then
            er = True
            MessageBox.Show("Ingilator's ID is required")
            txtInvigilatorID.Focus()
        ElseIf txtCcode.Text = "" Then
            er = True
            MessageBox.Show("Please supply the course code")
            txtCcode.Focus()
        ElseIf txtCTitle.Text = "" Then
            er = True
            MessageBox.Show("Please supply the Course Title")
            txtCTitle.Focus()
        ElseIf cboDept.Text.Trim.ToUpper = "--SELECT DEPT--" Or cboDept.Text = "" Then
            er = True
            MessageBox.Show("Please select the department")
            cboDept.Focus()
        ElseIf cboCUnit.Text.Trim.ToUpper = "--SELECT UNIT--" Or cboCUnit.Text = "" Then
            er = True
            MessageBox.Show("Please select the Course Unit")
            cboCUnit.Focus()
        ElseIf cboSession.Text.Trim.ToUpper = "--SELECT SESSION--" Or cboSession.Text = "" Then
            er = True
            MessageBox.Show("Please select the current session")
            cboSession.Focus()
        ElseIf cboSemester.Text.Trim.ToUpper = "--SELECT SEMESTER--" Or cboSemester.Text = "" Then
            er = True
            MessageBox.Show("Please select the current semester")
            cboSemester.Focus()
        ElseIf cboLevel.Text.Trim.ToUpper = "--SELECT LEVEL--" Or cboLevel.Text = "" Then
            er = True
            MessageBox.Show("Please select the level")
            cboLevel.Focus()
        ElseIf cboProgram.Text.Trim.ToUpper = "--SELECT PROGRAM--" Or cboProgram.Text = "" Then
            er = True
            MessageBox.Show("Please select the program")
            cboProgram.Focus()
        ElseIf txtVenue.Text = "" Then
            er = True
            MessageBox.Show("Please supply the Venue of Examination")
            txtVenue.Focus()
        ElseIf cboTime.Text.Trim.ToUpper = "--SELECT TIME--" Or cboTime.Text = "" Then
            er = True
            MessageBox.Show("Please select the time")
            cboTime.Focus()
        End If
    End Sub

    Private Sub btnGetCourseDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetCourseDetails.Click
        If txtInvigilatorID.Text = "" Then
            MessageBox.Show("Please supply Invigilator's ID")
            txtInvigilatorID.Focus()
            Exit Sub
        ElseIf txtCcode.Text = "" Then
            MessageBox.Show("Please supply the exam Course Code")
            txtCcode.Focus()
            Exit Sub
        ElseIf cboDept.Text.Trim.ToUpper = "--SELECT DEPT--" Or cboDept.Text = "" Then
            MessageBox.Show("Please select the department")
            cboDept.Focus()
            Exit Sub
        End If

        If txtInvigilatorID.Text <> "" Then
            If Not (MyModule.IDIsValid(txtInvigilatorID.Text.Trim.ToUpper)) Then
                MsgBox("The SecurityID Number supplied does not exist" & vbCrLf & _
                        "Please Contact Admin For any Complaint")
                txtInvigilatorID.SelectAll()
                Exit Sub
            End If
        End If


        Try
            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)
            Dim rdr As OleDbDataReader
            Dim sql As String = "SELECT * FROM AdminAllCourses WHERE " & _
                                "CCode ='" & txtCcode.Text.Trim.ToUpper & "' " & _
                                "AND Dept ='" & cboDept.Text.Trim.ToUpper & "'"
            cmd = New OleDbCommand(sql, cn)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                txtCTitle.Text = rdr("CTitle").ToString
                cboCUnit.Text = rdr("CUnit").ToString
                cboSemester.Text = rdr("Semester").ToString
                cboLevel.Text = rdr("TheLevel").ToString
                cboProgram.Text = rdr("TheProgram").ToString

                rdr.Close()
                txtCTitle.Enabled = False
                cboCUnit.Enabled = False
                cboSemester.Enabled = False
                cboLevel.Enabled = False
                cboProgram.Enabled = False

                Panel3.Enabled = True
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

    Private Sub radOne_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radOne.Click
        If radOne.Checked Then
            cboTime.Items.Clear()
            Dim tm As String, j, k As Integer
            For i As Integer = 8 To 17


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

                cboTime.Items.Add(k.ToString & " - " & j.ToString & tm)
            Next
        End If
    End Sub

    Private Sub radTwo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radTwo.Click
        If radTwo.Checked Then
            cboTime.Items.Clear()

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


                cboTime.Items.Add(k.ToString & " - " & j.ToString & tm)
            Next
        End If
    End Sub

    Private Sub radThree_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radThree.Click
        If radThree.Checked Then
            cboTime.Items.Clear()

            cboTime.Items.Add("8:30 - 11:30am")
            cboTime.Items.Add("12:00 - 3:00pm")
            cboTime.Items.Add("3:30 - 6:30pm")
        End If
    End Sub

    Private Sub FrmInvigilatorForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtCcode.Focus()
    End Sub
End Class