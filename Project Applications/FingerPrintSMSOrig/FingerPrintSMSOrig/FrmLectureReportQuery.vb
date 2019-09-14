
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************


'Imports System.Data
'Imports System.Data.OleDb

Public Class FrmLectureReportQuery
    Public theSqlStmt As String = ""
    Public TheReptLabel As String = ""


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub FrmLectureReportQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        txtStaffID.Text = FrmLogin.TheUserName
        Call clearControls()
    End Sub

    Private Sub btnGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateReport.Click
        If txtStaffID.Text <> "" Then
            If Not (MyModule.IDIsValid(txtStaffID.Text.Trim.ToUpper)) Then
                MsgBox("The Staff ID Number supplied does not exist" & vbCrLf & _
                        "Please Contact Admin For any Complaint")
                txtStaffID.SelectAll()
                Exit Sub
            End If
        End If

        Dim StaffId, code, dept, level, prog, sess, semester As String
        Dim dateFrom, dateTo As Date

        If isvalidateFailed() Then Exit Sub

        StaffId = txtStaffID.Text.Trim.ToUpper
        code = txtCcode.Text.Trim.ToUpper
        dept = cboDept.Text.Trim
        level = cboLevel.Text.Trim.ToUpper
        prog = cboProgram.Text.Trim.ToUpper
        sess = cboSession.Text.Trim
        semester = cboSemester.Text.Trim
        dateFrom = dtpFromDate.Value
        dateTo = dtpToDate.Value

        Dim FullDate As String = ""
        If dateFrom = dateTo Then
            FullDate = " ON " & dateFrom.ToString
        ElseIf dateFrom < dateTo Then
            FullDate = " BETWEEN " & dateFrom & " TO " & dateTo
        Else
            FullDate = " BETWEEN " & dateTo & " TO " & dateFrom
        End If


        TheReptLabel = "THE LECTURE ATTENDANCE OF " & code & " OFFERED BY " & dept & _
                        ", " & level & " (" & prog & ") " & sess & " SESSION " & semester & _
                        " SEMESTER, " & FullDate & _
                        ", TAKEN BY " & StaffId

        theSqlStmt = "SELECT LectureAttendance.TheDate as TheDate, LectureAttendance.Matric as Matric, " & _
                "PersonalData.Surname as Surname, " & _
                "PersonalData.Middlename as Middlename, PersonalData.Firstname as Firstname " & _
                "FROM LectureAttendance, PersonalData WHERE LectureAttendance.LecturerID = '" & StaffId & "'" & _
                " AND LectureAttendance.CCode = '" & code & "'" & _
                " AND LectureAttendance.Dept = '" & dept & "'" & _
                " AND LectureAttendance.TheSession= '" & sess & "'" & _
                " AND LectureAttendance.TheLevel = '" & level & "'" & _
                " AND LectureAttendance.Semester = '" & semester & "'" & _
                " AND LectureAttendance.TheProgram = '" & prog & "'" & _
                " AND LectureAttendance.TheDate >= #" & dateFrom & "#" & _
                " AND LectureAttendance.TheDate <= #" & dateTo & "#" & _
                " AND LectureAttendance.Matric = PersonalData.Matric "

        Call clearControls()

        Me.Hide()
        ReportLectureAttendance.Show(frmMain)


    End Sub

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

    Private Sub clearControls()
        cboDept.Text = "--Select Dept--"
        cboSession.Text = "--Select Session--"
        cboLevel.Text = "--Select Level--"
        cboSemester.Text = "--Select Semester--"
        cboProgram.Text = "--Select Program--"
        txtCcode.Text = ""
        dtpFromDate.Value = Now
        dtpToDate.Value = Now
        txtStaffID.Focus()

    End Sub

    Private Function isvalidateFailed() As Boolean
        Dim er As Boolean = False
        If txtStaffID.Text = "" Then
            er = True
            MsgBox("Staff ID  field is required")
            txtStaffID.Focus()
        ElseIf txtCcode.Text = "" Then
            er = True
            MsgBox("Course Code Field is required")
            txtCcode.Focus()
        ElseIf cboDept.Text = "" Or cboDept.Text.Trim.ToUpper = "--SELECT DEPT--" Then
            er = True
            MsgBox("Please select the department offering the course")
            cboDept.Focus()
        ElseIf cboLevel.Text = "" Or cboLevel.Text.Trim.ToUpper = "--SELECT LEVEL--" Then
            er = True
            MsgBox("Please select the Level")
            cboLevel.Focus()
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
        
        ElseIf dtpFromDate.Value > dtpToDate.Value Then
            er = True
            MsgBox("The ""From Date"" field should be less than or equal to the ""To Date"" field")
            dtpToDate.Select()
            dtpFromDate.Select()
            dtpFromDate.Focus()
        End If

        Return er
    End Function
End Class