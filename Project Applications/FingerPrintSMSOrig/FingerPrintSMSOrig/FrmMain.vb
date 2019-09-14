'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports Microsoft.VisualBasic
Public Class frmMain
    Public buttonText As String = ""
    Private mycolor(15) As System.Drawing.Color
    Private Sub LecturesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LecturesToolStripMenuItem.Click
        FrmLecturesAttendance.Show(Me)
    End Sub

    Private Sub ExamsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExamsToolStripMenuItem.Click
        FrmInvigilatorForm.Show(Me)
    End Sub

    Private Sub AddCoursesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCoursesToolStripMenuItem.Click
        buttonText = "ADD"
        FrmAdminAddCourse.Show(Me)
    End Sub

    Private Sub EditCoursesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCoursesToolStripMenuItem.Click
        buttonText = "EDIT"
        FrmAdminAddCourse.Show(Me)
    End Sub

    Private Sub RemoveCoursesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveCoursesToolStripMenuItem.Click
        buttonText = "DELETE"
        FrmAdminAddCourse.Show(Me)
    End Sub

    Private Sub LecturesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LecturesToolStripMenuItem1.Click
        FrmLectureReportQuery.Show(Me)
    End Sub

    Private Sub ExamsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExamsToolStripMenuItem1.Click
        FrmExamReportQuery.Show(Me)
    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmLogin.Show()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case (FrmLogin.category)
            Case "STUDENT"
                RegistrationToolStripMenuItem.Enabled = True
                AttendanceToolStripMenuItem.Enabled = False
                ADMINToolStripMenuItem.Enabled = False
                ReportsToolStripMenuItem.Enabled = False
                StaffToolStripMenuItem.Enabled = False
            Case "STAFF"
                RegistrationToolStripMenuItem.Enabled = False
                AttendanceToolStripMenuItem.Enabled = True
                ADMINToolStripMenuItem.Enabled = False
                ReportsToolStripMenuItem.Enabled = True
                StaffToolStripMenuItem.Enabled = True
            Case "ADMIN"
                RegistrationToolStripMenuItem.Enabled = False
                AttendanceToolStripMenuItem.Enabled = False
                ADMINToolStripMenuItem.Enabled = True
                ReportsToolStripMenuItem.Enabled = True
                StaffToolStripMenuItem.Enabled = True
        End Select

        lblFullname.Text = "Welcome   " & FrmLogin.Surname & ",  " & FrmLogin.middleName & "   " & FrmLogin.lastName & _
                            vbCrLf & "                    ( " & FrmLogin.TheUserName & " )"

        lblCopyright.Text = "Adedoyin " & Chr(169).ToString & " 2016"

        'Loads Color
        mycolor(0) = Color.AliceBlue
        mycolor(1) = Color.Bisque
        mycolor(2) = Color.Black
        mycolor(3) = Color.Chocolate
        mycolor(4) = Color.Cornsilk
        mycolor(5) = Color.LightPink
        mycolor(6) = Color.Magenta
        mycolor(7) = Color.IndianRed
        mycolor(8) = Color.Lavender
        mycolor(9) = Color.RosyBrown
        mycolor(10) = Color.Yellow
        mycolor(11) = Color.Thistle
        mycolor(12) = Color.BlanchedAlmond
        mycolor(13) = Color.Moccasin
        mycolor(14) = Color.Fuchsia


        '---starts the animation---
        lblProjectTopic.Left = 1000
        TmrMove.Enabled = True
        TmrChangeColor.Enabled = True
    End Sub

    Private Sub BioDataToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BioDataToolStripMenuItem1.Click
        FrmBioData.Show(Me)
    End Sub

    Private Sub CourseRegToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseRegToolStripMenuItem1.Click
        FrmCourseReg.Show(Me)
    End Sub

    Private Sub FingerDataCaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FingerDataCaptureToolStripMenuItem.Click
        FrmBiometricsReg.Show(Me)
    End Sub

    Private Sub FingerDataCaptureToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FingerDataCaptureToolStripMenuItem1.Click
        FrmBiometricsReg.Show(Me)
    End Sub

    Private Sub CourseRegToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseRegToolStripMenuItem2.Click
        FrmCourseReg.Show(Me)
    End Sub

    Private Sub lnkLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkLogout.LinkClicked
        Me.Close()
        FrmLogin.Show()
    End Sub

    Private Sub AddSecurityOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSecurityOfficerToolStripMenuItem.Click
        FrmRegisterSecurityOfficer.Show(Me)
    End Sub

    Private Sub TmrChangeColor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrChangeColor.Tick
        Dim i As Integer
        Randomize()
        i = CInt((Rnd() * 10)) + 1
        lblProjectTopic.ForeColor = mycolor(i)
    End Sub

    Private Sub TmrMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrMove.Tick
        If lblProjectTopic.Left <= -850 Then
            lblProjectTopic.Left = 1000
        End If
        lblProjectTopic.Left -= 5
    End Sub

    Private Sub StaffRegistrationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffRegistrationsToolStripMenuItem.Click
        FrmStaffReg.Show(Me)
    End Sub

    Private Sub BioMetricsFingerPrintRegToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BioMetricsFingerPrintRegToolStripMenuItem.Click
        FrmBiometricsReg.Show(Me)
    End Sub

    Private Sub SendBulkSMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendBulkSMSToolStripMenuItem.Click
        FrmBulkSMS.Show(Me)
    End Sub

    Private Sub AllRegisteredStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllRegisteredStudentsToolStripMenuItem.Click
        ReportAllRegStudents.Show(Me)
    End Sub

    Private Sub AddStaffStuentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStaffStuentToolStripMenuItem.Click
        FrmAddMatricStaffID.Show(Me)
    End Sub

    Private Sub StaffAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffAttendanceToolStripMenuItem.Click
        FrmStaffAttendanceReportQuery.Show(Me)
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub


    Private Sub lblFullname_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblFullname.SizeChanged
        lnklblLogout.Top = lblFullname.Top + 10
        lnklblLogout.Left = lblFullname.Left + lblFullname.Width + 15

    End Sub

    Private Sub lblFullname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFullname.Click

    End Sub

    Private Sub lnklblLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnklblLogout.LinkClicked
        Me.Hide()
        FrmLogin.Show()
    End Sub
End Class
