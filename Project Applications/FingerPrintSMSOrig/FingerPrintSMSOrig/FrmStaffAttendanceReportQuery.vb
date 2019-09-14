
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************



Public Class FrmStaffAttendanceReportQuery
    Public TheSqlStmt As String = ""
    Public theReptLabel As String = ""
    Private Sub chkByDept_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkByDept.CheckedChanged
        If chkByDept.CheckState = CheckState.Checked Then
            cboCategory.Enabled = True
            cboDept.Enabled = True
            cboCategory.Focus()
        Else
            cboCategory.Enabled = False
            cboDept.Enabled = False
        End If
    End Sub

    Private Sub chkByDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkByDate.CheckedChanged
        If chkByDate.CheckState = CheckState.Checked Then
            dtpFromDate.Enabled = True
            dtpToDate.Enabled = True
            dtpFromDate.Focus()
        Else
            dtpFromDate.Enabled = False
            dtpToDate.Enabled = False

        End If
    End Sub

    Private Sub FrmStaffAttendanceReportQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cboCategory.Items
            .Add("Academic")
            .Add("Non-Academic")
        End With

        cboCategory.Text = "--Select Category--"
        cboDept.Text = "--Select Dept--"
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        If cboCategory.SelectedIndex = 0 Then
            With cboDept.Items
                .Clear()
                .Add("CS")
                .Add("FT")
                .Add("ST")
                .Add("LT")
            End With


        ElseIf cboCategory.SelectedIndex = 1 Then
            With cboDept.Items
                .Clear()
                .Add("Bursary")
                .Add("Works")
                .Add("Security")
                .Add("Admin")
                .Add("MIS")
                .Add("ICT")
                .Add("Poly Consult")
                .Add("Medical Center")
            End With
        End If
    End Sub

    Private Sub btnGetReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetReport.Click
        Dim CategoryCode, deptCode As String
        TheSqlStmt = ""
        CategoryCode = ""
        deptCode = ""

        If chkByDept.CheckState = CheckState.Unchecked And chkByDate.CheckState = CheckState.Unchecked Then
            MsgBox("Atleast one of the options must be checked")
            Exit Sub
        End If

        If chkByDept.CheckState = CheckState.Checked Then
            If cboCategory.Text = "" Or cboCategory.Text.Trim.ToUpper = "--SELECT CATEGORY--" Then
                MsgBox("Please select the category")
                cboCategory.Focus()
                Exit Sub
            ElseIf cboDept.Text = "" Or cboDept.Text.Trim.ToUpper = "--SELECT DEPT--" Then
                MsgBox("Please select the Department")
                cboDept.Focus()
                Exit Sub
            End If


            If cboCategory.SelectedIndex = 0 Then
                CategoryCode = "AC"         'Academic Staff
                deptCode = cboDept.Text.Trim

            Else
                CategoryCode = "NA"          'Non Academic Staff
                Select Case (cboDept.SelectedIndex)
                    Case 0 : deptCode = "BUR"           'Bursary
                    Case 1 : deptCode = "WKS"           'Works
                    Case 2 : deptCode = "SEC"           'Security
                    Case 3 : deptCode = "ADM"           'Admin
                    Case 4 : deptCode = "MIS"           'MIS
                    Case 5 : deptCode = "ICT"           'ICT
                    Case 6 : deptCode = "PLC"           'Poly Consult
                    Case 7 : deptCode = "MED"           'Medical Center
                End Select
            End If
        End If

        If chkByDept.CheckState = CheckState.Checked And chkByDate.CheckState <> CheckState.Checked Then
            TheSqlStmt = "SELECT TheDate, StaffID,Surname,Middlename,Firstname,Dept,Status,TheTime " & _
                        "FROM StaffDailyAttendance WHERE Dept Like('*" & CategoryCode & "/" & deptCode & "*')" & _
                        " ORDER BY TheDate, StaffID"

            theReptLabel = "THE REPORT OF THE DAILY ATTENDANCE OF THE " & cboCategory.Text.Trim.ToUpper & _
                            " STAFF IN " & cboDept.Text.Trim.ToUpper & " DEPARTMENT"

        ElseIf chkByDate.CheckState = CheckState.Checked And chkByDept.CheckState <> CheckState.Checked Then
            TheSqlStmt = "SELECT TheDate, StaffID,Surname,Middlename,Firstname,Dept,Status,TheTime " & _
                                    "FROM StaffDailyAttendance WHERE TheDate >= #" & dtpFromDate.Value & "#" & _
                                     " AND TheDate <= #" & dtpToDate.Value & "#" & _
                                    " ORDER BY TheDate, Dept, StaffID"

            If dtpFromDate.Value = dtpToDate.Value Then
                theReptLabel = "THE REPORT OF THE DAILY ATTENDANCE OF THE ALL STAFF ON " & dtpFromDate.Value.ToString
            Else
                theReptLabel = "THE REPORT OF THE DAILY ATTENDANCE OF THE ALL STAFF FROM " & dtpFromDate.Value.ToString & _
                                " TO " & dtpToDate.Value.ToString
            End If


        ElseIf chkByDate.CheckState = CheckState.Checked And chkByDept.CheckState = CheckState.Checked Then

            TheSqlStmt = "SELECT TheDate, StaffID,Surname,Middlename,Firstname,Dept,Status,TheTime " & _
                                    "FROM StaffDailyAttendance WHERE Dept Like('*" & CategoryCode & "/" & deptCode & "*')" & _
                                    " AND (TheDate >= #" & dtpFromDate.Value & "#" & " AND TheDate <= #" & dtpToDate.Value & "#)" & _
                                    " ORDER BY TheDate, dEPT, StaffID"

            theReptLabel = "THE REPORT OF THE DAILY ATTENDANCE OF " & cboCategory.Text.Trim.ToUpper & _
                            " STAFF IN " & cboDept.Text.Trim.ToUpper & " DEPARTMENT FROM " & dtpFromDate.Value.ToString & _
                            " TO " & dtpToDate.Value.ToString
        End If


        cboCategory.Text = "--Select Category--"
        cboDept.Text = "--Select Dept--"
        dtpFromDate.Value = Now
        dtpToDate.Value = Now
        chkByDept.CheckState = CheckState.Unchecked
        chkByDate.CheckState = CheckState.Unchecked
        Me.Hide()
        ReportStaffAttendance.Show(frmMain)

    End Sub
End Class