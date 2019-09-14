
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************


Imports System.Data
Imports System.Data.OleDb

Public Class FrmAdminAddCourse
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim sql As String
    Dim currentCCode As String = "", currentDept As String = ""

    Private Sub FrmAdminAddCourse_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MyModule.DisconnectFromDbase(cn)
    End Sub


    Private Sub FrmAdminAddCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        With cboDept
            .Items.Add("CS")
            .Items.Add("FT")
            .Items.Add("ST")
            .Items.Add("LT")

            .SelectedIndex = 0
        End With

        With cboLevel
            .Items.Add("ND I")
            .Items.Add("ND I YR I")
            .Items.Add("ND II")
            .Items.Add("ND II YR II")
            .Items.Add("ND II YR III")
            .Items.Add("HND I")
            .Items.Add("HND II")

            .SelectedIndex = 0
        End With

        With cboProgram
            .Items.Add("F/T")
            .Items.Add("P/T")

            .SelectedIndex = 0
        End With

        With cboSemester
            .Items.Add("FIRST")
            .Items.Add("SECOND")

            .SelectedIndex = 0
        End With

        MyModule.ConnectToDBase(cn)

        Select Case frmMain.buttonText
            Case "ADD"
                btnEditUpdate.Enabled = False
                btnDelete.Enabled = False
            Case "EDIT"
                btnAdd.Enabled = False
                btnDelete.Enabled = False
            Case "DELETE"
                btnAdd.Enabled = False
                btnEditUpdate.Enabled = False
        End Select


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub clearControls()
        txtCcode.Clear()
        txtCtitle.Clear()
        txtLecturerID.Clear()
        txtCUnit.Clear()
        cboDept.SelectedIndex = cboLevel.SelectedIndex = cboProgram.SelectedIndex = _
            cboSemester.SelectedIndex = 0

        txtCcode.Focus()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If txtCcode.Text = "" Then
            MsgBox("Supply the Course Code")
            txtCcode.Focus()
            Exit Sub
        End If

        If txtCtitle.Text = "" Then
            MsgBox("Supply the Course Title")
            txtCtitle.Focus()
            Exit Sub
        End If

        If cboDept.Text.Trim = "" Then
            MsgBox("Select the department")
            cboDept.Focus()
            Exit Sub
        End If

        If cboSemester.Text.Trim = "" Then
            MsgBox("Select the Semester")
            cboSemester.Focus()
            Exit Sub
        End If

        If cboLevel.Text.Trim = "" Then
            MsgBox("Select the Level")
            cboLevel.Focus()
            Exit Sub
        End If

        If cboProgram.Text.Trim = "" Then
            MsgBox("Select the Program")
            cboProgram.Focus()
            Exit Sub
        End If

        If txtLecturerID.Text.Trim = "" Then
            MsgBox("Supply the Staff ID number of the Lecturer for the Course")
            txtLecturerID.Focus()
            Exit Sub
        End If

        Try

            sql = "INSERT INTO AdminAllCourses " & _
                "(CCode, CTitle, CUnit, Dept, Semester, TheLevel, TheProgram, LecturerID) " & _
                "VALUES ('" & txtCcode.Text.Trim.ToUpper & "', '" & _
                txtCtitle.Text.Trim.ToUpper & "', " & CByte(txtCUnit.Text.Trim) & ", '" & _
                cboDept.Text.Trim.ToUpper & "', '" & cboSemester.Text.Trim.ToUpper & "', '" & _
                cboLevel.Text.Trim.ToUpper & "', '" & cboProgram.Text.Trim.ToUpper & "', '" & txtLecturerID.Text.Trim.ToUpper & "');"

            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Course successfully added")
            Call clearControls()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEditUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditUpdate.Click
        Try
            Select Case btnEditUpdate.Text
                Case "EDIT"


                    currentCCode = InputBox("Enter the Course Code to Edit", "SEARCH COURSE", "COM122")
Again:
                    currentDept = InputBox("Enter the Department Offering the Course", "SEARCH COURSE", "CS")

                    If currentDept.Trim.Length > 2 Then
                        MessageBox.Show("Two character Code version is required for the department e.g. ST (Math and Stat.)")
                        GoTo Again
                    End If

                    If currentCCode <> "" And currentDept <> "" Then


                        sql = "SELECT * FROM AdminAllCourses WHERE CCode='" & currentCCode.Trim.ToUpper & _
                            "' AND Dept = '" & currentDept.Trim.ToUpper & "'"

                        cmd = New OleDbCommand(sql, cn)

                        'If rdr.IsClosed = False Then rdr.Close()

                        rdr = cmd.ExecuteReader
                        If rdr.HasRows Then
                            rdr.Read()
                            txtCcode.Text = rdr("CCode").ToString
                            txtCtitle.Text = rdr("CTitle").ToString
                            txtCUnit.Text = rdr("CUnit").ToString
                            cboDept.Text = rdr("Dept").ToString
                            cboLevel.Text = rdr("TheLevel").ToString
                            cboProgram.Text = rdr("TheProgram").ToString
                            cboSemester.Text = rdr("Semester").ToString
                            txtLecturerID.Text = rdr("LecturerID").ToString
                            btnEditUpdate.Text = "UPDATE"
                            btnAdd.Enabled = False

                            rdr.Close()
                        Else
                            MessageBox.Show("Record not found. Courses not registered before")
                            Exit Sub
                        End If
                    End If

                Case "UPDATE"
                    Dim reply As Integer
                    sql = "UPDATE AdminAllCourses SET CCode = '" & txtCcode.Text.Trim.ToUpper & "'," & _
                        "CTitle = '" & txtCtitle.Text.Trim.ToUpper & "', CUnit = " & CByte(txtCUnit.Text.Trim) & _
                        ", Dept = '" & cboDept.Text.Trim.ToUpper & "', TheLevel = '" & cboLevel.Text.Trim.ToUpper & _
                        "', TheProgram = '" & cboProgram.Text.Trim.ToUpper & "', Semester = '" & _
                        cboSemester.Text.Trim.ToUpper & "', LecturerID = '" & txtLecturerID.Text.Trim.ToUpper & _
                        "' WHERE CCode = '" & currentCCode.Trim.ToUpper & "' AND Dept = '" & currentDept.Trim.ToUpper & "'"

                    cmd = New OleDbCommand(sql, cn)
                    reply = cmd.ExecuteNonQuery()
                    If reply > 0 Then
                        MessageBox.Show("Course Details successfully updated")
                        Call clearControls()

                        btnEditUpdate.Text = "EDIT"
                        btnAdd.Enabled = True
                    End If

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        currentCCode = InputBox("Enter the Course Code to Delete", "SEARCH COURSE", "COM122")
Again:
        currentDept = InputBox("Enter the Department Offering the Course", "SEARCH COURSE", "CS")

        If currentDept.Trim.Length > 2 Then
            MessageBox.Show("Two character Code version is required for the department e.g. ST (Math and Stat.)")
            GoTo Again
        End If

        If currentCCode <> "" And currentDept <> "" Then

            If cn.State <> ConnectionState.Open Then MyModule.ConnectToDBase(cn)

            sql = "SELECT * FROM AdminAllCourses WHERE CCode='" & currentCCode.Trim.ToUpper & _
                "' AND Dept = '" & currentDept.Trim.ToUpper & "'"

            cmd = New OleDbCommand(sql, cn)

            'If rdr.IsClosed = False Then rdr.Close()

            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                rdr.Read()
                txtCcode.Text = rdr("CCode").ToString
                txtCtitle.Text = rdr("CTitle").ToString
                txtCUnit.Text = rdr("CUnit").ToString
                cboDept.Text = rdr("Dept").ToString
                cboLevel.Text = rdr("TheLevel").ToString
                cboProgram.Text = rdr("TheProgram").ToString
                cboSemester.Text = rdr("Semester").ToString
                txtLecturerID.Text = rdr("LecturerID").ToString
                btnEditUpdate.Text = "UPDATE"
                btnAdd.Enabled = False

                rdr.Close()
                Dim rep As DialogResult
                rep = MessageBox.Show("Are You sure you really want to Delete (Permanently Remove) " & _
                                            "this Course?", "CONFIRM DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If rep = Windows.Forms.DialogResult.Yes Then
                    Dim sql As String = "DELETE FROM AdminAllCourses WHERE CCode='" & currentCCode.Trim.ToUpper & _
                                            "' AND Dept = '" & currentDept.Trim.ToUpper & "'"
                    cmd = New OleDbCommand(sql, cn)
                    cmd.ExecuteNonQuery()
                    Call clearControls()
                End If

            Else
                MessageBox.Show("Record not found. Courses not registered before")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtCUnit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCUnit.KeyDown

    End Sub

    Private Sub txtCUnit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCUnit.KeyPress

    End Sub

    Private Sub txtCUnit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCUnit.KeyUp
        If (e.KeyData >= Keys.NumPad1 And e.KeyData <= Keys.NumPad9) Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtCUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCUnit.TextChanged

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

    Private Sub txtLecturerID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLecturerID.LostFocus
        If txtLecturerID.Text <> "" Then
            If IDIsValid(txtLecturerID.Text.Trim.ToUpper) Then
                Exit Sub
            Else
                MessageBox.Show("The staffID supplied is not valid for any Lecturer")
                txtLecturerID.SelectAll()
            End If
        End If
    End Sub

    Private Sub txtLecturerID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLecturerID.TextChanged

    End Sub
    
End Class