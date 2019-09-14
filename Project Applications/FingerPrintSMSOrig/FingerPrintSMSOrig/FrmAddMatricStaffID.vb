
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb
Public Class FrmAddMatricStaffID

    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand

    Private dept, lev, prog, sess As String
    Private isStaff As Boolean = False
    Private isMatricExist As Boolean = False
    Private isStaffIDExist As Boolean = False
    Dim existingMatrics As New List(Of String)
    Dim existingStaffIDs As New List(Of String)

    Private Sub FrmAddMatricStaffID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dept = ""
        lev = ""
        prog = ""
        sess = ""

        Dim yr1, yr2 As Integer
        For yr1 = 2011 To 2050
            yr2 = (yr1 + 1) Mod 1000
            cboSession.Items.Add(yr1.ToString & "/" & yr2.ToString)
        Next

        With cboStudentDept
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

        'With cboProgram
        '.Items.Add("F/T")
        '.Items.Add("P/T")
        'End With

        With cboStaffCategory.Items
            .Add("Academic")
            .Add("Non-Academic")
        End With

        Call clearControls()
        grpStudents.Enabled = False
        grpStaff.Enabled = False
        MyModule.ConnectToDBase(cn)
    End Sub

    Private Sub cboStaffCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStaffCategory.SelectedIndexChanged
        If cboStaffCategory.SelectedIndex = 0 Then
            With cboStaffDept.Items
                .Clear()
                .Add("CS")
                .Add("FT")
                .Add("ST")
                .Add("LT")
                .Add("GNS")
            End With


        ElseIf cboStaffCategory.SelectedIndex = 1 Then
            With cboStaffDept.Items
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

    Private Sub txtStudentNumber_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudentNumber.GotFocus

        If cboStudentDept.Text <> "" And cboStudentDept.Text.Trim.ToUpper <> "--SELECT DEPT--" Then
            dept = cboStudentDept.Text.Trim
        End If

        If cboLevel.Text <> "" And cboLevel.Text.Trim.ToUpper <> "--SELECT PROGRAM--" Then
            If cboLevel.Text.Contains("HND") Then
                lev = "HND"
            Else
                lev = "ND"
            End If
        End If

        If cboProgram.Text <> "" And cboProgram.Text.Trim.ToUpper <> "--SELECT PROGRAM--" Then
            prog = cboProgram.Text.Substring(0, 1)
            'lblMatricStartPath.Text &= prog
        End If

        If cboSession.Text <> "" And cboSession.Text.Trim.ToUpper <> "--SELECT PROGRAM--" Then
            sess = (CInt(cboSession.Text.Substring(cboSession.Text.Trim.IndexOf("/") + 1)) - 1).ToString
        End If

        lblMatricStartPath.Text = ""

        If dept <> "" Then
            lblMatricStartPath.Text &= dept & "/"
        Else
            MsgBox("Department should be selected")
            Exit Sub
        End If

        If lev <> "" Then
            lblMatricStartPath.Text &= lev & "/"
        Else
            MsgBox("Level should be selected")
            Exit Sub
        End If

        If prog <> "" Then
            lblMatricStartPath.Text &= prog
        Else
            MsgBox("Program should be selected")
            Exit Sub
        End If

        If sess <> "" Then
            lblMatricStartPath.Text &= sess & "/"
        Else
            MsgBox("Session should be selected")
            Exit Sub
        End If

    End Sub


    Private Function validateStudentFailed() As Boolean
        Dim er As Boolean = False
        If cboStudentDept.Text = "" Or cboStudentDept.Text.Trim.ToUpper = "--SELECT DEPT--" Then
            er = True
            MsgBox("Select department")
            cboStudentDept.Focus()
        End If

        If cboLevel.Text = "" Or cboLevel.Text.Trim.ToUpper = "--SELECT DEPT--" Then
            er = True
            MsgBox("Select the level")
            cboLevel.Focus()
        End If

        If cboProgram.Text = "" Or cboProgram.Text.Trim.ToUpper = "--SELECT DEPT--" Then
            er = True
            MsgBox("Select program")
            cboProgram.Focus()
        End If

        If cboSession.Text = "" Or cboSession.Text.Trim.ToUpper = "--SELECT DEPT--" Then
            er = True
            MsgBox("Select session")
            cboSession.Focus()
        End If

        If txtStudentNumber.Text = "" Or IsNumeric(txtStudentNumber.Text.Trim) = False Then
            er = True
            MsgBox("Number of Students to generate matric number for is required and this must be a number")
            txtStudentNumber.Focus()
        End If

        Return er
    End Function

    Private Function validateStaffFailed() As Boolean
        Dim er As Boolean
        If cboStaffCategory.Text = "" Or cboStaffCategory.Text.Trim.ToUpper = "--SELECT CATEGORY--" Then
            er = True
            MsgBox("Select Staff Category")
            cboStaffCategory.Focus()
        End If

        If cboStaffDept.Text = "" Or cboStaffDept.Text.Trim.ToUpper = "--SELECT DEPT--" Then
            er = True
            MsgBox("Select staff Department")
            cboStaffDept.Focus()
        End If

        If txtStaffNumber.Text = "" Or IsNumeric(txtStaffNumber.Text.Trim) = False Then
            er = True
            MsgBox("Number of staff to generate ID for is required and this must be a number")
            txtStaffNumber.Focus()
        End If

        Return er
    End Function

    Private Sub radStudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radStudent.CheckedChanged
        grpStudents.Enabled = True
        grpStaff.Enabled = False
        lstGenerated.Items.Clear()
    End Sub

    Private Sub radStaff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radStaff.CheckedChanged
        grpStaff.Enabled = True
        grpStudents.Enabled = False
        lstGenerated.Items.Clear()
    End Sub

    Private Sub txtStudentNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentNumber.TextChanged

    End Sub

    Private Sub btnGenerateMatric_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateMatric.Click

        If Not (validateStudentFailed()) Then
            Dim matric As Integer
            matric = CInt(txtStudentNumber.Text.Trim)
            lstGenerated.Items.Clear()
            For i As Integer = CInt(txtStudentStart.Text) To (CInt(txtStudentStart.Text) + matric - 1)
                lstGenerated.Items.Add(lblMatricStartPath.Text.Trim & i.ToString.PadLeft(4, "0"))
            Next
            isStaff = False
        End If

        'Call clearControls()
        grpStudents.Enabled = False
        grpStaff.Enabled = False
    End Sub

    Private Sub btnGenerateStaffID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateStaffID.Click
        If Not (validateStaffFailed()) Then
            Dim id As Integer
            id = CInt(txtStaffNumber.Text.Trim) - 1
            lstGenerated.Items.Clear()
            For i As Integer = CInt(txtStaffStart.Text) To (CInt(txtStaffStart.Text) + id)
                lstGenerated.Items.Add(lblIDStartPath.Text.Trim & i.ToString.PadLeft(4, "0"))
            Next
            isStaff = True
        End If

        'Call clearControls()

        grpStudents.Enabled = False
        grpStaff.Enabled = False
    End Sub

    Private Sub txtStaffNumber_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStaffNumber.GotFocus
        Dim deptCode, CategoryCode As String
        deptCode = ""
        CategoryCode = ""

        If cboStaffCategory.Text = "" Or cboStaffCategory.Text.Trim.ToUpper = "--SELECT CATEGORY--" Then
            MsgBox("Staff Category should be selected")
            cboStaffCategory.Focus()
            Exit Sub
        ElseIf cboStaffDept.Text = "" Or cboStaffDept.Text.Trim.ToUpper = "--SELECT DEPT--" Then
            MsgBox("Staff Department should be selected")
            cboStaffDept.Focus()
            Exit Sub
        End If



        If cboStaffCategory.SelectedIndex = 0 Then
            CategoryCode = "AC"         'Academic Staff
            deptCode = cboStaffDept.Text.Trim

        Else
            CategoryCode = "NA"          'Non Academic Staff
            Select Case (cboStaffDept.SelectedIndex)
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

        lblIDStartPath.Text = "ST/" & CategoryCode & "/" & deptCode & "/"

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim sql As String = ""
            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)

            If isStaff Then

                For i As Integer = 0 To (lstGenerated.Items.Count - 1)

                    Dim theStaffID, theTest As String
                    theStaffID = lstGenerated.Items.Item(i).ToString.Trim
                    theTest = checkIDAlreadyExist(theStaffID)
                    If theTest = "" Then
                        sql = "INSERT INTO AllStaffID(StaffID) VALUES('" & theStaffID & "')"
                        cmd = New OleDbCommand(sql, cn)
                        Dim reply As Integer
                        reply = cmd.ExecuteNonQuery()
                        existingStaffIDs.Add(theStaffID)
                    Else

                        isStaffIDExist = True
                        isMatricExist = False
                    End If
                Next
                MsgBox("Staff IDs Successfully saved")

                Call clearControls()

            Else

                For j As Integer = 0 To (lstGenerated.Items.Count - 1)

                    Dim theMatric, theTest As String
                    theMatric = lstGenerated.Items.Item(j).ToString.Trim
                    theTest = checkMatricAlreadyExist(theMatric)
                    If theTest = "" Then
                        sql = "INSERT INTO AllMatricNumbers(Matric) VALUES('" & _
                                theMatric & "')"
                        cmd = New OleDbCommand(sql, cn)
                        Dim reply As Integer
                        reply = cmd.ExecuteNonQuery()
                        existingMatrics.Add(theMatric)
                    Else

                        isMatricExist = True
                        isStaffIDExist = False
                    End If
                Next
                MsgBox("Matric Numbers Successfully saved")

                Call clearControls()

            End If


            If existingMatrics.Count > 0 Then
                For i As Integer = 0 To existingMatrics.Count - 1
                    Dim j As Integer = lstGenerated.Items.IndexOf(existingMatrics.Item(i).ToUpper)
                    If lstGenerated.Items.Count > 0 And j <> -1 Then
                        lstGenerated.Items.RemoveAt(j)
                    End If
                Next
                existingMatrics.Clear()
            End If

            If existingStaffIDs.Count > 0 Then
                For i As Integer = 0 To existingStaffIDs.Count - 1
                    Dim j As Integer = lstGenerated.Items.IndexOf(existingStaffIDs.Item(i).ToUpper)
                    If lstGenerated.Items.Count > 0 And j <> -1 Then
                        lstGenerated.Items.RemoveAt(j)
                    End If
                Next
                existingStaffIDs.Clear()
            End If


            If isStaffIDExist Then
                MsgBox("These Staff IDs Left in the List ""Already Exist"" in the Database")
                isStaffIDExist = False
            End If

            If isMatricExist Then
                MsgBox("These Matric Numbers Left in the List ""Already Exist"" in the Database")
                isMatricExist = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function checkMatricAlreadyExist(ByVal theMatric As String) As String
        Try
            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)
            Dim rdr As OleDbDataReader
            Dim returnValue As String = ""
            cmd = New OleDbCommand("SELECT * FROM AllMatricNumbers WHERE MATRIC ='" & _
                    theMatric.Trim.ToUpper & "'", cn)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                rdr.Read()
                returnValue = rdr("Matric").ToString
            Else
                returnValue = ""
            End If
            If rdr.IsClosed = False Then rdr.Close()

            Return returnValue

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return "Error"
        End Try
    End Function

    Private Function checkIDAlreadyExist(ByVal theStaffID As String) As String
        Try
            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)
            Dim rdr As OleDbDataReader
            Dim returnValue As String = ""
            cmd = New OleDbCommand("SELECT * FROM AllStaffID WHERE StaffID ='" & _
                    theStaffID.Trim.ToUpper & "'", cn)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                rdr.Read()
                returnValue = rdr("StaffID").ToString
            Else
                returnValue = ""
            End If
            If rdr.IsClosed = False Then rdr.Close()

            Return returnValue
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return "Error"
        End Try
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub clearControls()
        cboStudentDept.Text = "--Select Dept--"
        cboSession.Text = "--Select Session--"
        cboLevel.Text = "--Select Level--"
        cboProgram.Text = "--Select Program--"
        txtStudentStart.Text = ""
        txtStudentNumber.Text = ""
        lblMatricStartPath.Text = ""

        cboStaffCategory.Text = "--Select Category--"
        cboStaffDept.Text = "--Select Dept--"
        txtStudentStart.Text = ""
        txtStaffStart.Text = ""
        txtStaffNumber.Text = ""
        lblIDStartPath.Text = ""

    End Sub
End Class