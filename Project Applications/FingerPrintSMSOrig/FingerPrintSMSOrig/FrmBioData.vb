
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb

Imports System.IO
Public Class FrmBioData

    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    'Dim rdr As OleDbDataReader
    Dim sql As String = ""

    Private Sub FrmBioData_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        MyModule.DisconnectFromDbase(cn)
    End Sub

    Private Sub FrmBioData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        With cboProgram
            .Items.Add("F/T")
            .Items.Add("P/T")
        End With

        Call clearControls()

        txtMatric.Text = FrmLogin.TheUserName
        'Connect to the Database
        MyModule.ConnectToDBase(cn)

    End Sub


    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Me.Hide()
        FrmCourseReg.Show(frmMain)
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim thefilename As DialogResult
        OpenFileDialog1.DefaultExt = "jpg"
        OpenFileDialog1.Filter = "Images| *.jpg"

        thefilename = OpenFileDialog1.ShowDialog(Me)
        If thefilename <> Windows.Forms.DialogResult.Cancel Then
            Dim ab As New FileInfo(OpenFileDialog1.FileName)
            Dim filesize As Integer
            filesize = ab.Length

            If filesize > (1024 * 1024) Then
                MsgBox("Picture size too big. Required size must be less than 1Mb")
                Exit Sub
            Else
                txtPicPath.Text = OpenFileDialog1.FileName
            End If
        End If

    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        If txtPicPath.Text <> "" And txtPicPath.Text.Trim.EndsWith(".jpg") Then
            picPassport.Load(txtPicPath.Text)
        Else
            MsgBox("No passport to upload. Please browse for the passport to upload")
            btnBrowse.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub btnValidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidate.Click

        If txtMatric.Text = "" Then
            MessageBox.Show("Your Matric Number must be Supplied")
            txtMatric.Focus()
            Exit Sub
        ElseIf Not (txtMatric.Text.Contains("/")) Then
            MessageBox.Show("Invalid Fedpoffa Matric Number Format supplied" & vbCrLf & _
                            "Please check the matric Number supplied")
            txtMatric.SelectAll()
            txtMatric.Focus()
            Exit Sub
        End If

        If txtMatric.Text.Trim.ToUpper <> FrmLogin.TheUserName Then
            MessageBox.Show("The matric number you supplied does not correlate with your login username")
            txtMatric.SelectAll()
            txtMatric.Focus()
            Exit Sub
        End If

        'NOTICE: verifying if candidate (Matric Number) is already registered
        Dim rdr As OleDbDataReader
        sql = "SELECT * FROM PersonalData WHERE Matric = '" & txtMatric.Text.Trim.ToUpper & "'"
        cmd = New OleDbCommand(sql, cn)

        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            Dim reply As DialogResult
            reply = MessageBox.Show("You have already registered your personal details" & vbCrLf & _
                             "Would you like to proceed to Course Registration?", "ALREADY REGISTERED", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If reply = Windows.Forms.DialogResult.Yes Then
                Me.Hide()
                FrmCourseReg.Show(frmMain)
                Exit Sub
            Else
                Dim replyEdit As DialogResult
                replyEdit = MessageBox.Show("OR Would you like to EDIT Your Details?", "EDIT RECORD", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                If replyEdit = Windows.Forms.DialogResult.Yes Then
                    btnSave.Text = "UPDATE"
                    rdr.Read()
                    txtMatric.Text = rdr("Matric").ToString
                    GroupBox1.Enabled = True
                    GroupBox2.Enabled = True
                    btnSave.Enabled = True

                    txtSurname.Text = rdr("Surname").ToString
                    txtMiddlename.Text = rdr("Middlename").ToString
                    txtFirstname.Text = rdr("Firstname").ToString
                    dtpDOB.Value = CDate(rdr("DOB"))
                    If rdr("Sex").ToString.Trim.ToUpper = "MALE" Then
                        optMale.Checked = True
                    Else
                        optFemale.Checked = True
                    End If

                    cboDept.Text = rdr("Dept").ToString
                    cboLevel.Text = rdr("TheLevel").ToString
                    cboProgram.Text = rdr("TheProgram").ToString
                    cboSession.Text = rdr("TheSession").ToString
                    txtPhone.Text = rdr("PhoneNo").ToString
                    txtEMail.Text = rdr("TheEmail").ToString
                    If rdr("PassportPath").ToString <> "" Then
                        picPassport.Image = Image.FromFile(Application.StartupPath & rdr("PassportPath").ToString)
                        txtPicPath.Text = Application.StartupPath & rdr("PassportPath").ToString
                        'btnBrowse.Enabled = False
                        'btnUpload.Enabled = False
                    End If
                    txtParName.Text = rdr("ParFullname").ToString
                    txtParEmail.Text = rdr("ParMail").ToString
                    txtparPhone.Text = rdr("ParPhone").ToString

                    btnSave.Enabled = True

                    rdr.Close()
                    Exit Sub
                End If
            End If

        Else
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            btnSave.Enabled = True
            txtSurname.Text = FrmLogin.Surname
            txtMiddlename.Text = FrmLogin.middleName
            txtFirstname.Text = FrmLogin.lastName
            cboDept.Text = FrmLogin.dept
        End If

        
        If Not (rdr.IsClosed) Then
            rdr.Close()
        End If

    End Sub

    Private Sub clearControls()

        txtSurname.Clear()
        txtMiddlename.Clear()
        txtFirstname.Clear()
        dtpDOB.Value = CDate(Now)
        optMale.Checked = optFemale.Checked = False
        txtPhone.Clear()
        txtEMail.Clear()
        cboDept.Text = "--Select Dept--"
        picPassport.Image = Nothing
        txtPicPath.Clear()
        cboSession.Text = "--Select Session--"
        cboLevel.Text = "--Select Level--"
        cboProgram.Text = "--Select Program--"
        txtParName.Clear()
        txtParEmail.Clear()
        txtparPhone.Clear()
        btnContinue.Focus()

    End Sub

    Private Sub validateControls(ByRef er As Boolean)
        er = False
        If txtMatric.Text = "" Then
            MessageBox.Show("Matric Number must be supplied")
            txtMatric.Focus()
            er = True
        End If

        If txtSurname.Text = "" Then
            MessageBox.Show("Surname Field left Empty")
            txtSurname.Focus()
            er = True
        End If

        If txtFirstname.Text = "" Then
            MessageBox.Show("Firstname Field left empty")
            txtFirstname.Focus()
            er = True
        End If

        If Year(Now) - Year(dtpDOB.Value) <= 12 Then
            MessageBox.Show("Invalid Date of Birth Supplied")
            dtpDOB.Select()
            dtpDOB.Focus()
            er = True
        End If

        If optMale.Checked = False And optFemale.Checked = False Then
            MessageBox.Show("Please select your Sex/Gender")
            er = True
        End If

        If txtPhone.Text = "" Then
            MessageBox.Show("Your Phone Number is required")
            txtPhone.Focus()
            er = True
        End If


        If txtEMail.Text <> "" And (Not (txtEMail.Text.Contains("@"))) _
                                    Or Not (txtEMail.Text.EndsWith(".com")) Then

            MessageBox.Show("Invalid Email Address Format given")
            txtEMail.SelectAll()
            txtEMail.Focus()
            er = True
        End If

        If cboDept.Text.ToUpper = "--SELECT DEPT--" Then
            MessageBox.Show("Please Select Your Department")
            cboDept.SelectAll()
            cboDept.Focus()
            er = True
        End If

        If IsNothing(picPassport.Image) And txtPicPath.Text <> "" Then
            MessageBox.Show("Please upload the passport you selected by clicking the UPLOAD button")
            btnUpload.Focus()
            er = True
        ElseIf IsNothing(picPassport.Image) And txtPicPath.Text = "" Then
            MessageBox.Show("Your Passport must be uploaded")
            btnBrowse.Focus()
            er = True
        End If

        If cboSession.Text.Trim.ToUpper = "--SELECT SESSION--" Then
            MessageBox.Show("Please select the current session")
            cboSession.SelectAll()
            cboSession.Focus()
            er = True
        End If

        If cboLevel.Text.Trim.ToUpper = "--SELECT LEVEL--" Then
            MessageBox.Show("Pease select your Level")
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

        If txtParName.Text = "" Then
            MessageBox.Show("Parent/Guradian name field is required")
            txtParName.Focus()
            er = True
        End If

        If txtparPhone.Text = "" Then
            MessageBox.Show("Parent/Guardian Phone Number is required")
            txtparPhone.Focus()
            er = True
        ElseIf txtparPhone.Text.Trim.Length < 11 Then
            MessageBox.Show("Parent/Guardian Phone Number has incomplete number of digits")
            txtparPhone.SelectAll()
            txtparPhone.Focus()
            er = True
        End If

        If txtParEmail.Text <> "" And ((Not (txtParEmail.Text.Contains("@"))) _
                                    Or (Not (txtParEmail.Text.EndsWith(".com")))) Then

            MessageBox.Show("Invalid Parent/Guardian Email Address Format given")
            txtParEmail.SelectAll()
            txtParEmail.Focus()
            er = True
        End If

        If (Not (txtMatric.Text.ToUpper.StartsWith(cboDept.Text.Trim.ToUpper))) Then

            MessageBox.Show("Your matric number should be your " & "username. " & _
                            vbCrLf & "And that should correlate with your department")
            er = True
            cboDept.SelectAll()
            txtMatric.SelectAll()
            cboDept.Focus()
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim matric, Sname, Mname, Fname, dept, level, prog, ses As String
        Dim phone, themail, parName, parEmail, parPhone As String
        Dim sex As String = ""
        Dim feedBackMsg As String = ""
        Dim isUpdate As Boolean = False
        Dim dob As String
        Dim newFilePath As String = ""

        Dim errOcurred As Boolean

        Try

            Call validateControls(errOcurred)

            If errOcurred Then
                Exit Sub
            End If

            matric = txtMatric.Text.Trim.ToUpper
            Sname = txtSurname.Text.Trim.ToUpper

            If txtMiddlename.Text = "" Then
                Mname = ""
            Else
                Mname = txtMiddlename.Text.Trim.ToUpper
            End If

            Fname = txtFirstname.Text.Trim.ToUpper
            dob = dtpDOB.Value.ToString
            dept = cboDept.Text.Trim
            level = cboLevel.Text.Trim
            prog = cboProgram.Text.Trim
            ses = cboSession.Text.Trim
            phone = txtPhone.Text.Trim
            themail = txtEMail.Text.Trim
            parName = txtParName.Text.Trim
            parEmail = txtParEmail.Text.Trim
            parPhone = txtparPhone.Text.Trim

            If optMale.Checked Then
                sex = "Male"
            ElseIf optFemale.Checked Then
                sex = "Female"
            End If

            'changing the passport name to the matric number of candidate as the new passport name
            'Replacing the slash(/) in the matric number with an underscore(_)
            If Not IsNothing(picPassport.Image) Then
                newFilePath = "\Passports\Students\" & txtMatric.Text.Trim.ToUpper.Replace("/", "_") & _
                                Mid(txtPicPath.Text.Trim, txtPicPath.Text.Trim.LastIndexOf(".") + 1)
            End If

            Dim sql1 As String = ""
            Dim sql2 As String = ""
            'dim  sql3, sql4 As String
            ' Codes to save Record to the Database here
            If btnSave.Text.Trim.ToUpper = "SAVE" Then

                sql1 = "INSERT INTO PersonalData(Matric,Surname,Middlename,Firstname," & _
                    "DOB,Sex,Dept,TheLevel,TheProgram,TheSession) VALUES('" & matric & "','" & Sname & "','" & _
                    Mname & "','" & Fname & "',#" & CDate(dob) & "#,'" & sex & "','" & dept & "','" & level & _
                    "','" & prog & "','" & ses & "')"

                sql2 = "UPDATE PersonalData SET " & _
                            "PhoneNo ='" & phone & "', " & _
                            "TheEmail ='" & themail & "', " & _
                            "passportPath ='" & newFilePath & "', " & _
                            "parFullname ='" & parName & "', " & _
                            "parPhone ='" & parPhone & "', " & _
                            "parMail ='" & parEmail & "' WHERE Matric ='" & matric & "'"

                feedBackMsg = "Record successfully saved"

            ElseIf btnSave.Text.Trim.ToUpper = "UPDATE" Then

                sql1 = "UPDATE PersonalData SET Surname ='" & Sname & "', Middlename ='" & _
                      Mname & "', Firstname ='" & Fname & "', DOB = #" & CDate(dob) & "#, Sex = '" & sex & "', Dept = '" & dept & _
                      "', TheLevel ='" & level & "', TheProgram = '" & prog & "' WHERE Matric = '" & matric & "'"

                sql2 = "UPDATE PersonalData SET TheSession = '" & ses & "', PhoneNo = '" & phone & _
                      "', TheEmail = '" & themail & "', passportPath = '" & newFilePath & _
                      "', ParFullname = '" & parName & "', ParPhone = '" & parPhone & _
                      "', ParMail = '" & parEmail & "' WHERE Matric = '" & matric & "'"

                isUpdate = True
                feedBackMsg = "Record successfully Updated"
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
            End If

            cmd = New OleDbCommand(sql1, cn)

            Dim reply1, reply2 As Integer
            reply1 = cmd.ExecuteNonQuery()

            cmd = New OleDbCommand(sql2, cn)
            reply2 = cmd.ExecuteNonQuery()

            If reply1 > 0 And reply2 > 0 Then
                MessageBox.Show(feedBackMsg)

                'make a copy of the passport to the passports folder in the project
                'using the matric number of candidate as the new passport name
                MyModule.CopyPassportToFolder(txtPicPath.Text.Trim, newFilePath)

                If isUpdate Then
                    btnBrowse.Enabled = True
                    btnUpload.Enabled = True
                    btnSave.Text = "SAVE"
                End If

                Call clearControls()
                btnContinue.Enabled = True
                btnSave.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        MyModule.NumberOnly(e)
    End Sub

    Private Sub txtparPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtparPhone.KeyPress
        Call MyModule.NumberOnly(e)
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

    Private Sub txtParName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParName.KeyPress
        Call MyModule.NoNumberAllowed(e)
    End Sub

    Private Sub txtparPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtparPhone.TextChanged

    End Sub
End Class