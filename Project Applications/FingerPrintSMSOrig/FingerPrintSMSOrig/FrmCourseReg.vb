
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb

Public Class FrmCourseReg

    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    'Dim rdr As OleDbDataReader
    Dim sql As String = ""
    Dim ThereIsCarryOver As Boolean = False

    Dim FCode(15) As Label, FTitle(15) As Label, FUnit(15) As Label
    Dim FCOCode(6) As ComboBox, FCOTitle(6) As Label, FCOUnit(6) As Label

    Dim SCode(15) As Label, STitle(15) As Label, SUnit(15) As Label
    Dim SCOCode(6) As ComboBox, SCOTitle(6) As Label, SCOUnit(6) As Label

    Dim checkFirst(6), checkSecond(6) As CheckBox

    Dim FCOcopyArrayCode(6), FCOcopyArrayTitle(6), FCOcopyArrayUnit(6) As String
    Dim SCOcopyArrayCode(6), SCOcopyArrayTitle(6), SCOcopyArrayUnit(6) As String

    Dim FirstCourseCounter As Integer = 0
    Dim FirstCOCounter As Integer = 0
    Dim FCOcounter As Integer = 0


    Dim SecCourseCounter As Integer = 0
    Dim SecCOCounter As Integer = 0
    Dim SCOcounter As Integer = 0
    Dim matric, level, program, dept, session As String

    Private Sub FrmCourseReg_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MyModule.DisconnectFromDbase(cn)
    End Sub


    Private Sub FrmCourseReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Dim yr1, yr2 As Integer
        For yr1 = 2012 To 2050
            yr2 = (yr1 + 1) Mod 1000
            cboSession.Items.Add(yr1.ToString & "/" & yr2.ToString)
        Next

        'Establishes connection to the database
        MyModule.ConnectToDBase(cn)


        '*****Loading Controls into the Control Array********

        'FIRST SEMESTER
        '**************
        FCode(0) = FCode0 : FTitle(0) = FTitle0 : FUnit(0) = FUnit0
        FCode(1) = FCode1 : FTitle(1) = FTitle1 : FUnit(1) = FUnit1
        FCode(2) = FCode2 : FTitle(2) = FTitle2 : FUnit(2) = FUnit2
        FCode(3) = FCode3 : FTitle(3) = FTitle3 : FUnit(3) = FUnit3
        FCode(4) = FCode4 : FTitle(4) = FTitle4 : FUnit(4) = FUnit4
        FCode(5) = FCode5 : FTitle(5) = FTitle5 : FUnit(5) = FUnit5
        FCode(6) = FCode6 : FTitle(6) = FTitle6 : FUnit(6) = FUnit6
        FCode(7) = FCode7 : FTitle(7) = FTitle7 : FUnit(7) = FUnit7
        FCode(8) = FCode8 : FTitle(8) = FTitle8 : FUnit(8) = FUnit8
        FCode(9) = FCode9 : FTitle(9) = FTitle9 : FUnit(9) = FUnit9
        FCode(10) = FCode10 : FTitle(10) = FTitle10 : FUnit(10) = FUnit10
        FCode(11) = FCode11 : FTitle(11) = FTitle11 : FUnit(11) = FUnit11
        FCode(12) = FCode12 : FTitle(12) = FTitle12 : FUnit(12) = FUnit12
        FCode(13) = FCode13 : FTitle(13) = FTitle13 : FUnit(13) = FUnit13
        FCode(14) = FCode14 : FTitle(14) = FTitle14 : FUnit(14) = FUnit14

        'Carry Over
        FCOCode(0) = FCOCode0 : FCOTitle(0) = FCOTitle0 : FCOUnit(0) = FCOUnit0
        FCOCode(1) = FCOCode1 : FCOTitle(1) = FCOTitle1 : FCOUnit(1) = FCOUnit1
        FCOCode(2) = FCOCode2 : FCOTitle(2) = FCOTitle2 : FCOUnit(2) = FCOUnit2
        FCOCode(3) = FCOCode3 : FCOTitle(3) = FCOTitle3 : FCOUnit(3) = FCOUnit3
        FCOCode(4) = FCOCode4 : FCOTitle(4) = FCOTitle4 : FCOUnit(4) = FCOUnit4
        FCOCode(5) = FCOCode5 : FCOTitle(5) = FCOTitle5 : FCOUnit(5) = FCOUnit5

        'Carry Over Checkboxes for first semester
        checkFirst(0) = Fchk0 : checkFirst(1) = Fchk1 : checkFirst(2) = Fchk2
        checkFirst(3) = Fchk3 : checkFirst(4) = Fchk4 : checkFirst(5) = Fchk5

        'SECOND SEMESTER
        '***************
        SCode(0) = SCode0 : STitle(0) = STitle0 : SUnit(0) = SUnit0
        SCode(1) = SCode1 : STitle(1) = STitle1 : SUnit(1) = SUnit1
        SCode(2) = SCode2 : STitle(2) = STitle2 : SUnit(2) = SUnit2
        SCode(3) = SCode3 : STitle(3) = STitle3 : SUnit(3) = SUnit3
        SCode(4) = SCode4 : STitle(4) = STitle4 : SUnit(4) = SUnit4
        SCode(5) = SCode5 : STitle(5) = STitle5 : SUnit(5) = SUnit5
        SCode(6) = SCode6 : STitle(6) = STitle6 : SUnit(6) = SUnit6
        SCode(7) = SCode7 : STitle(7) = STitle7 : SUnit(7) = SUnit7
        SCode(8) = SCode8 : STitle(8) = STitle8 : SUnit(8) = SUnit8
        SCode(9) = SCode9 : STitle(9) = STitle9 : SUnit(9) = SUnit9
        SCode(10) = SCode10 : STitle(10) = STitle10 : SUnit(10) = SUnit10
        SCode(11) = SCode11 : STitle(11) = STitle11 : SUnit(11) = SUnit11
        SCode(12) = SCode12 : STitle(12) = STitle12 : SUnit(12) = SUnit12
        SCode(13) = SCode13 : STitle(13) = STitle13 : SUnit(13) = SUnit13
        SCode(14) = SCode14 : STitle(14) = STitle14 : SUnit(14) = SUnit14

        'Carry Over
        SCOCode(0) = SCOCode0 : SCOTitle(0) = SCOTitle0 : SCOUnit(0) = SCOUnit0
        SCOCode(1) = SCOCode1 : SCOTitle(1) = SCOTitle1 : SCOUnit(1) = SCOUnit1
        SCOCode(2) = SCOCode2 : SCOTitle(2) = SCOTitle2 : SCOUnit(2) = SCOUnit2
        SCOCode(3) = SCOCode3 : SCOTitle(3) = SCOTitle3 : SCOUnit(3) = SCOUnit3
        SCOCode(4) = SCOCode4 : SCOTitle(4) = SCOTitle4 : SCOUnit(4) = SCOUnit4
        SCOCode(5) = SCOCode5 : SCOTitle(5) = SCOTitle5 : SCOUnit(5) = SCOUnit5

        'Carry Over Checkboxes for second semester
        checksecond(0) = Fchk0 : checksecond(1) = Fchk1 : checkSecond(2) = Fchk2
        checkSecond(3) = Fchk3 : checkSecond(4) = Fchk4 : checkSecond(5) = Fchk5

        Dim rdr As OleDbDataReader
        sql = "SELECT * FROM PersonalData WHERE Matric = '" & FrmLogin.TheUserName & "'"
        cmd = New OleDbCommand(sql, cn)
        rdr = cmd.ExecuteReader()
        If rdr.HasRows Then
            rdr.Read()
            txtMatric.Text = rdr("Matric").ToString
            cboDept.Text = rdr("Dept").ToString
            'cboLevel.Text = rdr("TheLevel").ToString
            cboProgram.Text = rdr("TheProgram").ToString
            If rdr("Matric").ToString.Trim.Contains("HND") Then
                With cboLevel.Items
                    .Clear()
                    .Add("HND I")
                    .Add("HND II")
                End With
                cboProgram.Items.Clear()
                cboProgram.Items.Add("F/T")
                cboProgram.Text = "F/T"
            Else
                With cboLevel.Items
                    .Clear()
                    .Add("ND I")
                    .Add("ND I YR I")
                    .Add("ND II")
                    .Add("ND II YR II")
                    .Add("ND II YR III")
                End With
            End If

        Else
            MessageBox.Show("You have to register your Bio-Data First before the course Registration.")
            pnlHeader.Enabled = False
            Me.Hide()
            FrmBioData.Show()

        End If
        If Not rdr.IsClosed Then rdr.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Me.Hide()
        FrmBiometricsReg.Show(frmMain)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub btnGenerateCourses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateCourses.Click
        Dim errOccured As Boolean
        Call validateControls(errOccured)

        If errOccured Then
            Exit Sub
        End If

        'Bio-Data registration must come before course registrations
        '**********************************************************************************
        If (isBioDataRegistered(txtMatric.Text) = False) Then
            Dim rep As DialogResult
            rep = MessageBox.Show("Sorry, You have not yet registered your Bio-Data" & vbCrLf & _
                          "Register your Bio-Data before registering for courses" & vbCrLf & vbCrLf & _
                          "Would you like to register your Bio-Data details now?", _
                         "BIO-DATA NOT REGISTERED", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If rep = Windows.Forms.DialogResult.Yes Then
                Me.Close()
                FrmBioData.Show(frmMain)
                Exit Sub
            Else
                MessageBox.Show("You can as well get to the Bio-Data Registration form through the menu " & vbCrLf & _
                               "REGISTRATIONS >> Fresher  >> Bio-Data")
                Exit Sub
            End If
        End If
        '***********************************************************************

        'Checks if the student has already registered h(is/er) courses for the session
        If IsAlreadyRegistered(txtMatric.Text, cboSession.Text, cboLevel.Text) Then
            Dim reply As DialogResult
            reply = MessageBox.Show("You have already registered your courses for the session and Level specified" & vbCrLf & _
                             "Would you like to proceed to Finger Data Capture Registration?", "ALREADY REGISTERED", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If reply = Windows.Forms.DialogResult.Yes Then
                Me.Hide()
                FrmBiometricsReg.Show(frmMain)
                Exit Sub
            Else
                txtMatric.SelectAll()
                txtMatric.Focus()
                Exit Sub
            End If
        End If

        '####################################################
        'CONTINUE NOW WITH COURSE GENERATION AND REGISTERATION
        '######################################################
        '#####################################################
        '####################################################

        'Try
        Dim rdr As OleDbDataReader
        sql = "SELECT * FROM AdminAllCourses WHERE Dept = '" & cboDept.Text.Trim.ToUpper & "'" & _
            " AND TheLevel = '" & cboLevel.Text.Trim.ToUpper & "'" & _
            " AND TheProgram = '" & cboProgram.Text.Trim.ToUpper & "' ORDER BY CCode"
        cmd = New OleDbCommand(sql, cn)

        'If rdr.IsClosed = False Then rdr.Close()

        rdr = cmd.ExecuteReader()
        If rdr.HasRows Then

            pnlFirstSem.Enabled = True
            pnlSecondSem.Enabled = True
            pnlButtons.Enabled = True

            While rdr.Read
                If rdr("Semester").ToString = "FIRST" Then
                    FCode(FirstCourseCounter).Text = rdr("CCode").ToString
                    FTitle(FirstCourseCounter).Text = rdr("CTitle").ToString
                    FUnit(FirstCourseCounter).Text = rdr("CUnit").ToString

                    'Increment First Semester course Counter
                    FirstCourseCounter += 1

                ElseIf rdr("Semester").ToString = "SECOND" Then
                    SCode(SecCourseCounter).Text = rdr("CCode").ToString
                    STitle(SecCourseCounter).Text = rdr("CTitle").ToString
                    SUnit(SecCourseCounter).Text = rdr("CUnit").ToString

                    'Increment Second Semester course Counter
                    SecCourseCounter += 1
                End If

            End While
            btnGenerateCourses.Enabled = False
            pnlHeader.Enabled = False

        Else            'If there is no record match in rdr

            MessageBox.Show("There is no course available for your entry")


        End If

        If (rdr.IsClosed = False) Then rdr.Close()


        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Function IsAlreadyRegistered(ByVal theMatric As String, ByVal thesession As String, ByVal thelevel As String) As Boolean
        Try
            Dim value As Boolean = False
            Dim rdr As OleDbDataReader
            sql = "SELECT * FROM RegisteredCourses WHERE Matric='" & theMatric.Trim.ToUpper & "'" & _
                " AND TheSession = '" & thesession.Trim.ToUpper & "' AND TheLevel = '" & thelevel.Trim.ToUpper & "'"
            cmd = New OleDbCommand(sql, cn)
            rdr = cmd.ExecuteReader

            If rdr.HasRows Then
                value = True
            Else
                value = False
            End If

            If Not (rdr.IsClosed) Then
                rdr.Close()
            End If

            Return value

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function

    Private Function isBioDataRegistered(ByVal theMatric As String)
        Dim value As Boolean = False
        Dim rdr As OleDbDataReader
        sql = "SELECT Matric FROM PersonalData WHERE Matric = '" & theMatric.Trim.ToUpper & "'"

        cmd = New OleDbCommand(sql, cn)
        rdr = cmd.ExecuteReader

        If rdr.HasRows Then
            value = True
        Else
            value = False
        End If

        If Not (rdr.IsClosed) Then
            rdr.Close()
        End If

        Return value
    End Function

    Private Sub validateControls(ByRef er As Boolean)
        er = False
        If txtMatric.Text = "" Then
            MessageBox.Show("Your Matric Number is Required")
            txtMatric.Focus()
            er = True
        End If

        If cboLevel.Text.Trim.ToUpper = "--SELECT LEVEL--" Then
            MessageBox.Show("Please select your level")
            cboLevel.SelectAll()
            cboLevel.Focus()
            er = True
        End If

        If cboProgram.Text.Trim.ToUpper = "--SELECT PROGRAM--" Then
            MessageBox.Show("Please select your program")
            cboProgram.SelectAll()
            cboProgram.Focus()
            er = True
        End If

        If cboSession.Text.Trim.ToUpper = "--SELECT SESSION--" Then
            MessageBox.Show("Please select your current session")
            cboSession.SelectAll()
            cboSession.Focus()
            er = True
        End If

        If cboLevel.Text.Trim.ToUpper = "" Then
            MessageBox.Show("Please select your level")
            cboLevel.SelectAll()
            cboLevel.Focus()
            er = True
        End If

        If cboProgram.Text.Trim.ToUpper = "" Then
            MessageBox.Show("Please select your program")
            cboProgram.SelectAll()
            cboProgram.Focus()
            er = True
        End If

        If cboSession.Text.Trim.ToUpper = "" Then
            MessageBox.Show("Please select your current session")
            cboSession.SelectAll()
            cboSession.Focus()
            er = True
        End If


    End Sub

    
    Private Sub FrmCourseReg_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        MessageBox.Show("Remeber to select your ""current Level"" and ""current Session"" before saving your courses")
    End Sub

    Private Sub FCOCode0_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCOCode0.SelectedIndexChanged
        'LoadTextFirst(FCOCode0.SelectedIndex)
        FCOTitle(0).Text = FCOcopyArrayTitle(FCOCode0.SelectedIndex)
        FCOUnit(0).Text = FCOcopyArrayUnit(FCOCode0.SelectedIndex)
    End Sub

    Private Sub LoadTextFirst(ByVal i As Integer)
        FCOTitle(i).Text = FCOcopyArrayTitle(i)
        FCOUnit(i).Text = FCOcopyArrayUnit(i)
    End Sub

    Private Sub LoadTextSecond(ByVal i As Integer)
        SCOTitle(i).Text = SCOcopyArrayTitle(i)
        SCOUnit(i).Text = SCOcopyArrayUnit(i)
    End Sub

    Private Sub FCOCode1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCOCode1.SelectedIndexChanged
        'LoadTextFirst(FCOCode1.SelectedIndex)
        FCOTitle(1).Text = FCOcopyArrayTitle(FCOCode1.SelectedIndex)
        FCOUnit(1).Text = FCOcopyArrayUnit(FCOCode1.SelectedIndex)
    End Sub

    Private Sub FCOCode2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCOCode2.SelectedIndexChanged
        'LoadTextFirst(FCOCode2.SelectedIndex)
        FCOTitle(2).Text = FCOcopyArrayTitle(FCOCode2.SelectedIndex)
        FCOUnit(2).Text = FCOcopyArrayUnit(FCOCode2.SelectedIndex)
    End Sub

    Private Sub FCOCode3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCOCode3.SelectedIndexChanged
        'LoadTextFirst(FCOCode3.SelectedIndex)
        FCOTitle(3).Text = FCOcopyArrayTitle(FCOCode3.SelectedIndex)
        FCOUnit(3).Text = FCOcopyArrayUnit(FCOCode3.SelectedIndex)
    End Sub

    Private Sub FCOCode4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCOCode4.SelectedIndexChanged
        'LoadTextFirst(FCOCode4.SelectedIndex)
        FCOTitle(4).Text = FCOcopyArrayTitle(FCOCode4.SelectedIndex)
        FCOUnit(4).Text = FCOcopyArrayUnit(FCOCode4.SelectedIndex)
    End Sub

    Private Sub FCOCode5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCOCode5.SelectedIndexChanged
        'LoadTextFirst(FCOCode5.SelectedIndex)
        FCOTitle(5).Text = FCOcopyArrayTitle(FCOCode5.SelectedIndex)
        FCOUnit(5).Text = FCOcopyArrayUnit(FCOCode5.SelectedIndex)
    End Sub

    Private Sub SCOCode0_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCOCode0.SelectedIndexChanged
        'LoadTextSecond(SCOCode0.SelectedIndex)
        SCOTitle(0).Text = SCOcopyArrayTitle(SCOCode0.SelectedIndex)
        SCOUnit(0).Text = SCOcopyArrayUnit(SCOCode0.SelectedIndex)
    End Sub

    Private Sub SCOCode1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCOCode1.SelectedIndexChanged
        'LoadTextSecond(SCOCode1.SelectedIndex)
        SCOTitle(1).Text = SCOcopyArrayTitle(SCOCode1.SelectedIndex)
        SCOUnit(1).Text = SCOcopyArrayUnit(SCOCode1.SelectedIndex)
    End Sub

    Private Sub SCOCode2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCOCode2.SelectedIndexChanged
        'LoadTextSecond(SCOCode2.SelectedIndex)
        SCOTitle(2).Text = SCOcopyArrayTitle(SCOCode2.SelectedIndex)
        SCOUnit(2).Text = SCOcopyArrayUnit(SCOCode2.SelectedIndex)
    End Sub

    Private Sub SCOCode3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCOCode3.SelectedIndexChanged
        'LoadTextSecond(SCOCode3.SelectedIndex)
        SCOTitle(3).Text = SCOcopyArrayTitle(SCOCode3.SelectedIndex)
        SCOUnit(3).Text = SCOcopyArrayUnit(SCOCode3.SelectedIndex)
    End Sub

    Private Sub SCOCode4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCOCode4.SelectedIndexChanged
        'LoadTextSecond(SCOCode4.SelectedIndex)
        SCOTitle(4).Text = SCOcopyArrayTitle(SCOCode4.SelectedIndex)
        SCOUnit(4).Text = SCOcopyArrayUnit(SCOCode4.SelectedIndex)
    End Sub

    Private Sub SCOCode5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCOCode5.SelectedIndexChanged
        'LoadTextSecond(SCOCode5.SelectedIndex)
        SCOTitle(5).Text = SCOcopyArrayTitle(SCOCode5.SelectedIndex)
        SCOUnit(5).Text = SCOcopyArrayUnit(SCOCode5.SelectedIndex)
    End Sub

    Private Sub btnCarryOver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarryOver.Click
        Dim myCOLevel As String = ""

        Select Case (cboLevel.Text.Trim)
            Case "ND I"
            Case "ND I YR I"
            Case "HND I"
                MessageBox.Show("You are still a fresher and so cannot yet register for carry Over")
                Exit Sub
            Case "ND II" : myCOLevel = "ND I"
            Case "ND II YR II" : myCOLevel = "ND I YR I"
            Case "ND II YR III" : myCOLevel = "ND II YR II"
            Case "HND II" : myCOLevel = "HND I"
            Case Else : MessageBox.Show("Unknown Level Supplied") : Exit Sub
        End Select

        Dim rdr As OleDbDataReader
        '************************************************
        sql = "SELECT * FROM AdminAllCourses WHERE Dept = '" & cboDept.Text.Trim.ToUpper & "'" & _
                    " AND TheLevel = '" & myCOLevel & "'" & _
                    " AND TheProgram = '" & cboProgram.Text.Trim.ToUpper & "' ORDER BY CCode"
        cmd = New OleDbCommand(sql, cn)

        rdr = cmd.ExecuteReader()
        If rdr.HasRows Then

            ThereIsCarryOver = True

            While rdr.Read
                If rdr("Semester").ToString = "FIRST" Then
                    For i As Integer = 0 To 5
                        FCOCode(i).Items.Add(rdr("CCode").ToString)
                    Next

                    'copy all the records into an array to be used later
                    FCOcopyArrayCode(FCOcounter) = rdr("CCode").ToString
                    FCOcopyArrayTitle(FCOcounter) = rdr("CTitle").ToString
                    FCOcopyArrayUnit(FCOcounter) = rdr("CUnit").ToString


                    'Increment First Semester course Counter
                    FCOcounter += 1

                ElseIf rdr("Semester").ToString = "SECOND" Then
                    For i As Integer = 0 To 5
                        SCOCode(i).Items.Add(rdr("CCode").ToString)
                    Next

                    'copy all the records into an array to be used later
                    SCOcopyArrayCode(SCOcounter) = rdr("CCode").ToString
                    SCOcopyArrayTitle(SCOcounter) = rdr("CTitle").ToString
                    SCOcopyArrayUnit(SCOcounter) = rdr("CUnit").ToString

                    'Increment Second Semester course Counter
                    SCOcounter += 1
                End If

            End While

        Else            'If there is no record match in rdr

            MessageBox.Show("There is no course available for your entry")


        End If

        If (rdr.IsClosed = False) Then rdr.Close()


        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

        Try
            '*****************FIRST SEMESTER (MAIN & CARRY OVER) REGISTRATION *************
            '******************************************************************************
            'Handles first Semester main Courses
            For i As Integer = 0 To FirstCourseCounter - 1
                Dim sql As String
                sql = "INSERT INTO RegisteredCourses(Matric,Dept,TheSession," & _
                        "Semester,TheLevel,TheProgram,CCode,CTitle,CUnit) " & _
                        "VALUES('" & FrmLogin.TheUserName & "','" & _
                        cboDept.Text.Trim & "','" & cboSession.Text.Trim & "','FIRST','" & _
                        cboLevel.Text.Trim & "','" & cboProgram.Text.Trim & "','" & _
                        FCode(i).Text.Trim & "','" & FTitle(i).Text.Trim & "'," & _
                        CByte(FUnit(i).Text.Trim) & ")"
                cmd = New OleDbCommand(sql, cn)
                cmd.ExecuteNonQuery()
            Next

            'Handles First Semester Carry Over Courses
            If (ThereIsCarryOver) Then

                For j As Integer = 0 To 5
                    If checkFirst(j).Checked Then
                        Dim sql As String
                        sql = "INSERT INTO RegisteredCourses(Matric,Dept,TheSession," & _
                                "Semester,TheLevel,TheProgram,CCode,CTitle,CUnit,Status) " & _
                                "VALUES('" & FrmLogin.TheUserName & "','" & _
                                cboDept.Text.Trim & "','" & cboSession.Text.Trim & "','FIRST','" & _
                                cboLevel.Text.Trim & "','" & cboProgram.Text.Trim & "','" & _
                                FCOCode(j).Text.Trim & "','" & FCOTitle(j).Text.Trim & "'," & _
                                CByte(FCOUnit(j).Text.Trim) & ",'C.O.')"
                        cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End If
                Next
            End If
            '***************************END OF FIRST SEMESTER*************************************
            '*************************************************************************************


            '*****************SECOND SEMESTER (MAIN & CARRY OVER) REGISTRATION *************
            '******************************************************************************
            'Handles Second Semester main Courses
            For i As Integer = 0 To SecCourseCounter - 1
                Dim sql As String
                sql = "INSERT INTO RegisteredCourses(Matric,Dept,TheSession," & _
                        "Semester,TheLevel,TheProgram,CCode,CTitle,CUnit) " & _
                        "VALUES('" & FrmLogin.TheUserName & "','" & _
                        cboDept.Text.Trim & "','" & cboSession.Text.Trim & "','SECOND','" & _
                        cboLevel.Text.Trim & "','" & cboProgram.Text.Trim & "','" & _
                        SCode(i).Text.Trim & "','" & STitle(i).Text.Trim & "'," & _
                        CByte(SUnit(i).Text.Trim) & ")"
                cmd = New OleDbCommand(sql, cn)
                cmd.ExecuteNonQuery()
            Next

            'Handles Second Semester Carry Over Courses
            If (ThereIsCarryOver) Then

                For j As Integer = 0 To 5
                    If checkSecond(j).Checked Then
                        Dim sql As String
                        sql = "INSERT INTO RegisteredCourses(Matric,Dept,TheSession," & _
                                "Semester,TheLevel,TheProgram,CCode,CTitle,CUnit,Status) " & _
                                "VALUES('" & FrmLogin.TheUserName & "','" & _
                                cboDept.Text.Trim & "','" & cboSession.Text.Trim & "','SECOND','" & _
                                cboLevel.Text.Trim & "','" & cboProgram.Text.Trim & "','" & _
                                SCOCode(j).Text.Trim & "','" & SCOTitle(j).Text.Trim & "','" & _
                                SCOUnit(j).Text.Trim & "','C.O.')"
                        cmd = New OleDbCommand(sql, cn)
                        cmd.ExecuteNonQuery()
                    End If
                Next
            End If
            '***************************END OF SECOND SEMESTER*************************************
            '*************************************************************************************

            MessageBox.Show("Your Courses for this session has been successfully registered" & vbCrLf & _
                            "Click on the CONTINUE button to proceed to Bio-Metrics Registration")
            btnRegister.Enabled = False
            Call clearControls()
            btnRegister.Enabled = False
            btnContinue.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub clearControls()

        'CLEAR MAIN COURSE FIELDS
        For i As Integer = 0 To FirstCourseCounter - 1
            FCode(i).Text = ""
            FTitle(i).Text = ""
            FUnit(i).Text = ""
        Next

        For i As Integer = 0 To SecCourseCounter - 1
            SCode(i).Text = ""
            STitle(i).Text = ""
            SUnit(i).Text = ""
        Next

        'CLEAR ALL CARRY OVER FIELDS
        For co As Integer = 0 To 5
            'first semester
            checkFirst(co).Checked = False
            FCOCode(co).Items.Clear()
            FCOCode(co).Text = ""
            FCOTitle(co).Text = ""
            FCOUnit(co).Text = ""

            'second semester
            checkSecond(co).Checked = False
            SCOCode(co).Items.Clear()
            SCOCode(co).Text = ""
            SCOTitle(co).Text = ""
            SCOUnit(co).Text = ""

            'clears the temporary array created
            FCOcopyArrayCode(co) = ""
            FCOcopyArrayTitle(co) = ""
            FCOcopyArrayUnit(co) = ""

            SCOcopyArrayCode(co) = ""
            SCOcopyArrayTitle(co) = ""
            SCOcopyArrayUnit(co) = ""

            ThereIsCarryOver = False
        Next

    End Sub

    Private Sub cboLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLevel.SelectedIndexChanged
        If cboLevel.Items.Count > 2 Then
            If cboLevel.SelectedIndex = 1 Or cboLevel.SelectedIndex = 3 Or cboLevel.SelectedIndex = 4 Then
                cboProgram.Items.Clear()
                cboProgram.Items.Add("P/T")
                cboProgram.Text = "P/T"
            Else
                cboProgram.Items.Clear()
                cboProgram.Items.Add("F/T")
                cboProgram.Text = "F/T"
            End If
        End If
    End Sub
End Class