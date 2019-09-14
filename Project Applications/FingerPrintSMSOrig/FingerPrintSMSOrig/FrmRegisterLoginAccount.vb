
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb

Public Class FrmRegisterLoginAccount
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim sql As String = ""

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Try

            Dim sname, fname, category, dept, username, pswd, secretQue, SecretAns As String
            Dim mname As String = ""


            If ControlsHasError() Then
                Exit Sub
            End If



            sname = txtSurname.Text.Trim.ToUpper
            If txtMiddlename.Text <> "" Then
                mname = txtMiddlename.Text.Trim.ToUpper
                'Else
                'mname = ""
            End If
            'mname = txtMiddlename.Text
            fname = txtFirstname.Text.Trim.ToUpper
            category = cboCategory.Text.Trim.ToUpper
            dept = cboDept.Text.Trim.ToUpper
            username = txtUsername.Text.Trim.ToUpper
            pswd = txtPassword.Text.Trim
            secretQue = cboQuestion.Text.Trim
            SecretAns = txtAnswer.Text.Trim

            sql = "INSERT INTO AccountLogin(Surname,Middlename,Firstname,Category,Dept," & _
                "Uname,pswd,SecretQue,SecretAns) VALUES ('" & _
                sname & "', '" & mname & "', '" & fname & "', '" & category & "', '" & _
            dept & "', '" & username & "', '" & pswd & "', '" & secretQue & "', '" & SecretAns & "')"

            cmd = New OleDbCommand(sql, cn)
            Dim reply As Integer = cmd.ExecuteNonQuery
            If reply > 0 Then
                MessageBox.Show("Congratulations, Your Registration was Successful." & vbCrLf & _
                                "You can now login with your just created account details.")
                FrmLogin.txtUsername.Text = username
                Call clearControls()
                Me.Hide()
                FrmLogin.Show()
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FrmRegisterLoginAccount_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MyModule.DisconnectFromDbase(cn)
    End Sub

    Private Sub FrmRegisterLoginAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Call clearControls()
            MyModule.ConnectToDBase(cn)

            With cboCategory.Items
                .Add("Student")
                .Add("Staff")
                .Add("ADMIN")
            End With

            With cboDept.Items
                .Add("CS")
                .Add("ST")
                .Add("FT")
                .Add("LT")
            End With

            With cboQuestion.Items
                .Add("What is your favourite pet?")
                .Add("What date in your life can you never forget?")
                .Add("What is your mother middle name?")
                .Add("What is your favourite food?")
                .Add("Where were you born?")
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ControlsHasError() As Boolean
        Dim er As Boolean

        If txtSurname.Text = "" Then
            er = True
            MessageBox.Show("Surname field is required")
            txtSurname.Focus()

        ElseIf txtFirstname.Text = "" Then
            er = True
            MessageBox.Show("Your Firstname is Required")
            txtFirstname.Focus()
        ElseIf cboCategory.Text.Trim.ToUpper = "--SELECT CATEGORY--" Then
            er = True
            MessageBox.Show("Please select your category")
            cboCategory.Focus()
        ElseIf cboDept.Text.Trim.ToUpper = "--SELECT DEPT--" Then
            er = True
            MessageBox.Show("Please select your department")
            cboDept.SelectAll()
            cboDept.Focus()
        ElseIf txtUsername.Text = "" Then
            er = True
            MessageBox.Show("Please supply your username")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            er = True
            MessageBox.Show("Your password field cannot be left empty")
            txtPassword.Focus()
        ElseIf txtRetypePassword.Text = "" Then
            er = True
            MessageBox.Show("Please retype the password to make confirmation")
            txtRetypePassword.Focus()
        ElseIf txtPassword.Text <> txtRetypePassword.Text Then
            er = True
            MessageBox.Show("The two passwords supplied does not tally" & vbCrLf & _
                            "Please retype password again")
            txtRetypePassword.Text = ""
            txtPassword.SelectAll()
            txtPassword.Focus()
        ElseIf cboQuestion.Text.Trim.ToUpper = "--SELECT/TYPE YOUR SECRET QUESTION--" Then
            er = True
            MessageBox.Show("Please select from list or type a your security question")
            cboQuestion.SelectAll()
            cboQuestion.Focus()
        ElseIf txtAnswer.Text = "" Then
            er = True
            MessageBox.Show("Please supply the your answer to your secret question")
            txtAnswer.Focus()
        End If

        If cboCategory.Text.Trim.ToUpper = "STUDENT" Then
            If (Not (txtUsername.Text.ToUpper.StartsWith(cboDept.Text.Trim))) Then

                MessageBox.Show("Your matric number should be your " & "username. " & _
                                vbCrLf & "And that should correlate with your department")
                er = True
                cboDept.SelectAll()
                txtUsername.SelectAll()
                txtUsername.Focus()
            ElseIf (Not (txtUsername.Text.Contains("/"))) Then
                MessageBox.Show("Your matric number should be your" & _
                                "username and the one you supply " & vbCrLf & _
                                "does not match Fedpoffa Matric Number format (e.g CS/HND/F13/1322)")
                er = True
                cboDept.SelectAll()
                txtUsername.SelectAll()
                txtUsername.Focus()
            End If
            
        End If



        sql = "SELECT * FROM AccountLogin WHERE Uname = '" & _
            txtUsername.Text.Trim.ToUpper & "'"

            cmd = New OleDbCommand(sql, cn)
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                er = True
            MessageBox.Show("Username already belonged to someone else")
                txtUsername.SelectAll()
                txtPassword.SelectAll()
                txtRetypePassword.SelectAll()
                txtUsername.Focus()
            End If

            If Not (rdr.IsClosed) Then
                rdr.Close()
        End If

        'Ensures the matric number OR StaffID supplied as username is in the database
        If cboCategory.Text.Trim.ToUpper = "STUDENT" Then
            If Not (MyModule.MatricNumberIsValid(txtUsername.Text.Trim.ToUpper)) Then
                er = True
                MessageBox.Show("The Username supplied is not a valid Matric Number Assigned to any Student")
                txtUsername.SelectAll()
                txtUsername.Focus()
            End If

        ElseIf cboCategory.Text.Trim.ToUpper = "STAFF" Or cboCategory.Text.Trim.ToUpper = "ADMIN" Then
            If Not (MyModule.IDIsValid(txtUsername.Text.Trim.ToUpper)) Then
                er = True
                MessageBox.Show("The Username supplied is not a valid Staff ID Assigned to any Staff")
                txtUsername.SelectAll()
                txtUsername.Focus()
            End If
        End If

            Return er
    End Function

    Private Sub clearControls()
        txtSurname.Clear()
        txtMiddlename.Clear()
        txtFirstname.Clear()
        cboCategory.Text = "--Select Category--"
        cboDept.Text = "--Select Dept--"
        txtUsername.Clear()
        txtPassword.Clear()
        txtRetypePassword.Clear()
        cboQuestion.Text = "--Select/Type your secret question--"
        txtAnswer.Clear()
        txtSurname.Focus()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Sub txtSurname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSurname.KeyPress
        Call MyModule.NoNumberAllowed(e)
    End Sub

    Private Sub txtMiddlename_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMiddlename.KeyPress
        Call MyModule.NoNumberAllowed(e)
    End Sub

    Private Sub txtFirstname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstname.KeyPress
        Call MyModule.NoNumberAllowed(e)
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        If cboCategory.SelectedIndex <> 0 Then
            cboDept.Items.Clear()
            With cboDept.Items
                .Clear()
                .Add("CS")
                .Add("FT")
                .Add("ST")
                .Add("LT")
                .Add("Bursary")
                .Add("Works")
                .Add("Security")
                .Add("Admin")
                .Add("MIS")
                .Add("ICT")
                .Add("Poly Consult")
                .Add("Medical Center")
            End With
        Else
            With cboDept.Items
                .Clear()
                .Add("CS")
                .Add("FT")
                .Add("ST")
                .Add("LT")
            End With
        End If
    End Sub
End Class