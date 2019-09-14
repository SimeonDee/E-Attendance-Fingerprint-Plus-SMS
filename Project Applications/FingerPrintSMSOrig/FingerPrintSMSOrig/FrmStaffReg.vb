
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb

Imports System.IO

Public Class FrmStaffReg

    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim sql As String = ""

    Private Sub FrmStaffReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With cboCategory.Items
            .Add("Academic")
            .Add("Non-Academic")
        End With

        cboCategory.Text = "--Select Category--"
        cboDept.Text = "--Select Dept--"

        Call clearControls()

        txtStaffID.Text = FrmLogin.TheUserName
        'Connect to the Database
        MyModule.ConnectToDBase(cn)

    End Sub

    Private Sub btnBrowse_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim myStaffID, Sname, Mname, Fname, dept, phone, themail, Category As String
        Dim sex As String = ""
        Dim feedBackMsg As String = ""
        Dim isUpdate As Boolean = False
        Dim newFilePath As String = ""

        Dim errOcurred As Boolean

        'Try

        Call validateControls(errOcurred)

        If errOcurred Then
            Exit Sub
        End If

        myStaffID = txtStaffID.Text.Trim.ToUpper
        Sname = txtSurname.Text.Trim.ToUpper

        If txtMiddlename.Text = "" Then
            Mname = ""
        Else
            Mname = txtMiddlename.Text.Trim.ToUpper
        End If

        Fname = txtFirstname.Text.Trim.ToUpper
        dept = cboDept.Text.Trim
        phone = txtPhone.Text.Trim
        themail = txtEMail.Text.Trim
        Category = cboCategory.Text.Trim.ToUpper

        If optMale.Checked Then
            sex = "Male"
        ElseIf optFemale.Checked Then
            sex = "Female"
        End If

        'changing the passport name to the Staff ID number of staff as the new passport name
        'Replacing the slash(/) in the Staff ID with an underscore(_) if any
        If Not IsNothing(picPassport.Image) Then
            Dim newStr As String = txtStaffID.Text.Trim.ToUpper
            If txtStaffID.Text.Contains("/") Then
                newStr = txtStaffID.Text.Trim.ToUpper.Replace("/", "_")
            End If


            newFilePath = "\Passports\Staff\" & newStr & _
                            Mid(txtPicPath.Text.Trim, txtPicPath.Text.Trim.LastIndexOf(".") + 1)
        End If

        Dim sql1 As String = ""
        'Dim sql2 As String = ""

        ' Codes to save Record to the Database here
        If btnSave.Text.Trim.ToUpper = "SAVE" Then
            sql1 = "INSERT INTO StaffDataReg(StaffID,Surname,Middlename,Firstname," & _
                "Sex,Phone,TheMail,Dept,StaffCategory,passportPath) VALUES('" & myStaffID & "','" & Sname & "','" & _
                Mname & "','" & Fname & "','" & sex & "','" & phone & "','" & themail & _
                "','" & dept & "','" & Category & "','" & newFilePath & "')"

            feedBackMsg = "Record successfully saved"

        ElseIf btnSave.Text.Trim.ToUpper = "UPDATE" Then
            sql1 = "UPDATE StaffDataReg SET " & _
                    "Surname ='" & Sname & "', " & _
                    "Middlename ='" & Mname & "', " & _
                    "Firstname ='" & Fname & "', " & _
                    "Sex = '" & sex & "', " & _
                    "Phone ='" & phone & "', " & _
                    "TheMail ='" & themail & "', " & _
                    "Dept ='" & dept & "', " & _
                    "StaffCategory ='" & Category & "', " & _
                    "passportPath = '" & newFilePath & "' " & _
                    "WHERE StaffID = '" & myStaffID & "'"

            isUpdate = True
            feedBackMsg = "Record successfully Updated"
            GroupBox1.Enabled = False
        End If

        Dim reply1 As Integer
        cmd = New OleDbCommand(sql1, cn)


        reply1 = cmd.ExecuteNonQuery()


        If reply1 > 0 Then
            MessageBox.Show(feedBackMsg)

            'make a copy of the passport to the passports folder in the project
            'using the Staff ID of the Staff as the new passport name
            MyModule.CopyPassportToFolder(txtPicPath.Text.Trim, newFilePath)

            If isUpdate Then
                btnBrowse.Enabled = True
                btnUpload.Enabled = True
                btnSave.Text = "SAVE"
            End If

            Call clearControls()
            btnContinue.Enabled = True
            GroupBox1.Enabled = False
            btnSave.Enabled = False
        End If

        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub btnValidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidate.Click
        If txtStaffID.Text = "" Then
            MessageBox.Show("Your Staff ID must be Supplied")
            txtStaffID.Focus()
            Exit Sub
        End If

        If txtStaffID.Text.Trim.ToUpper <> FrmLogin.TheUserName Then
            MessageBox.Show("The Staff ID you supplied does not correlate with your login username")
            txtStaffID.SelectAll()
            txtStaffID.Focus()
            Exit Sub
        End If


        '**********************************************
        'NOTICE: verifying if Staff(using Staff ID) is already registered
        Dim rdr As OleDbDataReader
        sql = "SELECT * FROM StaffDataReg WHERE StaffID = '" & txtStaffID.Text.Trim.ToUpper & "'"
        cmd = New OleDbCommand(sql, cn)

        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            Dim reply As DialogResult
            reply = MessageBox.Show("You have already registered your personal details" & vbCrLf & _
                             "Would you like to proceed to Bio-Metrics Finger Registration?", "ALREADY REGISTERED", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If reply = Windows.Forms.DialogResult.Yes Then
                Call clearControls()
                Me.Hide()
                FrmBiometricsReg.Show(frmMain)
                Exit Sub
            Else
                Dim replyEdit As DialogResult
                replyEdit = MessageBox.Show("OR Would you like to EDIT Your Details?", "EDIT RECORD", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                If replyEdit = Windows.Forms.DialogResult.Yes Then
                    btnSave.Text = "UPDATE"
                    rdr.Read()
                    txtStaffID.Text = rdr("StaffID").ToString
                    GroupBox1.Enabled = True
                    btnSave.Enabled = True

                    txtSurname.Text = rdr("Surname").ToString
                    txtMiddlename.Text = rdr("Middlename").ToString
                    txtFirstname.Text = rdr("Firstname").ToString
                    If rdr("Sex").ToString.Trim.ToUpper = "MALE" Then
                        optMale.Checked = True
                    Else
                        optFemale.Checked = True
                    End If

                    txtPhone.Text = rdr("Phone").ToString
                    txtEMail.Text = rdr("TheMail").ToString
                    cboDept.Text = rdr("Dept").ToString
                    cboCategory.Text = rdr("StaffCategory").ToString
                    If rdr("PassportPath").ToString <> "" Then
                        picPassport.Image = Image.FromFile(Application.StartupPath & rdr("PassportPath").ToString)
                        txtPicPath.Text = Application.StartupPath & rdr("PassportPath").ToString
                        btnBrowse.Enabled = False
                        btnUpload.Enabled = False
                    End If

                    btnSave.Enabled = True

                    rdr.Close()
                    Exit Sub
                End If
            End If

        Else
            GroupBox1.Enabled = True
            btnSave.Enabled = True
            txtSurname.Text = FrmLogin.Surname
            txtMiddlename.Text = FrmLogin.middleName
            txtFirstname.Text = FrmLogin.lastName
        End If


        If Not (rdr.IsClosed) Then
            rdr.Close()
        End If

    End Sub

    '*************************************

    Private Sub validateControls(ByRef er As Boolean)
        er = False
        If txtStaffID.Text = "" Then
            MessageBox.Show("Staff ID must be supplied")
            txtStaffID.Focus()
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

        If optMale.Checked = False And optFemale.Checked = False Then
            MessageBox.Show("Please select your Sex/Gender")
            er = True
        End If

        If cboCategory.Text.Trim.ToUpper = "--SELECT CATEGORY--" Then
            MessageBox.Show("Please select your Category")

        End If

        If txtPhone.Text = "" Then
            MessageBox.Show("Your Phone Number is required")
            txtPhone.Focus()
            er = True
        ElseIf txtPhone.Text.Trim.Length < 11 Then
            MessageBox.Show("Phone Number has incomplete number of digits")
            txtPhone.SelectAll()
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

        If cboDept.Text.ToUpper = "--SELECT DEPT--" Or cboDept.Text = "" Then
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

    End Sub

    Private Sub clearControls()

        txtSurname.Clear()
        txtMiddlename.Clear()
        txtFirstname.Clear()
        optMale.Checked = optFemale.Checked = False
        txtPhone.Clear()
        txtEMail.Clear()
        cboDept.Text = "--Select Dept--"
        picPassport.Image = Nothing
        txtPicPath.Clear()
        btnContinue.Focus()
        cboCategory.Text = "--Select Category--"

    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        Call clearControls()
        Me.Hide()
        FrmBiometricsReg.Show(frmMain)
    End Sub

    Private Sub txtSurname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSurname.KeyPress
        Call MyModule.NoNumberAllowed(e)
    End Sub

    Private Sub txtMiddlename_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMiddlename.KeyPress
        Call MyModule.NoNumberAllowed(e)
    End Sub

    Private Sub txtFirstname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstname.KeyPress
        MyModule.NoNumberAllowed(e)
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        MyModule.NumberOnly(e)
    End Sub

    Private Sub txtPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhone.TextChanged

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

        cboDept.Sorted = True

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class