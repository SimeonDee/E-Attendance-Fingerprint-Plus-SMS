
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb

Public Class FrmExamReportQuery
    Public theSQL As String = ""
    Public ReportLabel As String = ""
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Call clearControls()
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub FrmExamReportQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim yr1, yr2 As Integer
        For yr1 = 2011 To 2050
            yr2 = (yr1 + 1) Mod 1000
            cboSession.Items.Add(yr1.ToString & "/" & yr2.ToString)
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


        With cboSemester.Items
            .Add("FIRST")
            .Add("SECOND")
        End With

        txtInvigilatorID.Text = FrmLogin.TheUserName
        Call clearControls()
    End Sub

    Private Sub clearControls()
        cboDept.Text = "--Select Dept--"
        cboSession.Text = "--Select Session--"
        cboLevel.Text = "--Select Level--"
        cboSemester.Text = "--Select Semester--"
        cboProgram.Text = "--Select Program--"
        txtCcode.Text = ""
        txtVenue.Text = ""
        dtpDate.Value = Now
        txtInvigilatorID.Focus()

    End Sub
    Private Function isvalidateFailed() As Boolean
        Dim er As Boolean = False
        If txtInvigilatorID.Text = "" Then
            er = True
            MsgBox("Invigilator's ID  field is required")
            txtInvigilatorID.Focus()
        ElseIf txtCcode.Text = "" Then
            er = True
            MsgBox("Course Code Field is required")
            txtCcode.Focus()
        ElseIf cboDept.Text = "" Or cboDept.Text.Trim.ToUpper = "--SELECT DEPT--" Then
            er = True
            MsgBox("Please select the department offering the course")
            cboDept.Focus()
        ElseIf cboProgram.Text = "" Or cboProgram.Text.Trim.ToUpper = "--SELECT PROGRAM--" Then
            er = True
            MsgBox("Please select the Program")
            cboProgram.Focus()
        ElseIf cboSession.Text = "" Or cboSession.Text.Trim.ToUpper = "--SELECT SESSION--" Then
            er = True
            MsgBox("Please select the session")
            cboSession.Focus()
        ElseIf cboSemester.Text = "" Or cboSemester.Text.Trim.ToUpper = "--SELECT SEMESTER--" Then
            er = True
            MsgBox("Please select the semester")
            cboSemester.Focus()
        ElseIf cboLevel.Text = "" Or cboLevel.Text.Trim.ToUpper = "--SELECT LEVEL--" Then
            er = True
            MsgBox("Please select the Level")
            cboLevel.Focus()
        ElseIf txtVenue.Text = "" Then
            er = True
            MsgBox("Please type the venue of the Examination")
            txtVenue.Focus()
        End If

        Return er
    End Function
    Private Sub cboLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLevel.SelectedIndexChanged
        If cboLevel.SelectedIndex = 1 Or cboLevel.SelectedIndex = 3 Or cboLevel.SelectedIndex = 4 Then
            cboProgram.Items.Clear()
            cboProgram.Items.Add("P/T")
            cboProgram.Text = "P/T"
        Else
            cboProgram.Items.Clear()
            cboProgram.Items.Add("F/T")
            cboProgram.Text = "F/T"
        End If
    End Sub

    Private Sub btnGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateReport.Click
        Dim invigId, code, dept, level, prog, sess, venue, semester As String
        Dim theDate As Date
        If isvalidateFailed() Then Exit Sub
        invigId = txtInvigilatorID.Text.Trim.ToUpper
        code = txtCcode.Text.Trim.ToUpper
        dept = cboDept.Text.Trim
        level = cboLevel.Text.Trim.ToUpper
        prog = cboProgram.Text.Trim.ToUpper
        sess = cboSession.Text.Trim
        venue = txtVenue.Text.Trim.ToUpper
        theDate = dtpDate.Value.ToShortDateString
        semester = cboSemester.Text.Trim

        ReportLabel = "THE EXAM ATTENDANCE OF " & code & " OFFERED BY " & dept & _
                        ", " & level & " (" & prog & ") " & sess & " SESSION " & semester & _
                        " SEMESTER, " & " HELD AT " & venue & " ON " & theDate.ToString & _
                        " INVIGILATED BY " & invigId

        theSQL = "SELECT ExamAttendance.Matric as Matric, PersonalData.Surname as Surname, " & _
                "PersonalData.Middlename as Middlename, PersonalData.Firstname as Firstname " & _
                "FROM ExamAttendance, PersonalData WHERE ExamAttendance.InvigilatorID = '" & invigId & "'" & _
                " AND ExamAttendance.CCode = '" & code & "'" & _
                " AND ExamAttendance.Dept = '" & dept & "'" & _
                " AND ExamAttendance.TheSession = '" & sess & "'" & _
                " AND ExamAttendance.TheLevel = '" & level & "'" & _
                " AND ExamAttendance.Semester = '" & semester & "'" & _
                " AND ExamAttendance.TheProgram = '" & prog & "'" & _
                " AND ExamAttendance.TheDate = #" & theDate & "#" & _
                " AND ExamAttendance.Matric = PersonalData.Matric "

        Call clearControls()

        Me.Hide()
        ReportExamAttendance.Show(frmMain)

    End Sub
End Class