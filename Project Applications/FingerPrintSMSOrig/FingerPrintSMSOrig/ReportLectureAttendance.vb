
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb
Public Class ReportLectureAttendance
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter

    Private Sub ReportLectureAttendance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cn.State <> ConnectionState.Closed Then MyModule.DisconnectFromDbase(cn)
        FrmLectureReportQuery.Close()
    End Sub
    Private Sub ReportLectureAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MyModule.ConnectToDBase(cn)
            da = New OleDbDataAdapter(FrmLectureReportQuery.theSqlStmt, cn)
            Dim ds As New DataSet
            da.Fill(ds, "ExamAttendance")

            If ds.Tables(0).Rows.Count = 0 Then MsgBox("No Record Saved meets those criteria")
            lblReportTitle.Text = FrmLectureReportQuery.TheReptLabel

            DataGridView1.RowHeadersVisible = False
            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            DataGridView1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub PrintReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReportToolStripMenuItem.Click
        MsgBox("No Printer Connected")
    End Sub
End Class