
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb
Public Class ReportAllRegStudents
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim rdr As OleDbDataReader

    Private Sub ReportAllRegStudents_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cn.State <> ConnectionState.Closed Then MyModule.DisconnectFromDbase(cn)
    End Sub

    Private Sub ReportAllRegStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyModule.ConnectToDBase(cn)
        Dim sql As String
        sql = "SELECT PersonalData.Matric as Matric, PersonalData.Surname as Surname,PersonalData.Middlename as Middlename, " & _
            "PersonalData.Firstname as Firstname, " & _
            "PersonalData.Dept as Dept, PersonalData.Sex as Sex FROM enroll, personalData WHERE enroll.Category = 'STUDENT' AND " & _
            "PersonalData.Matric = enroll.Usrname"

        da = New OleDbDataAdapter(sql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "AllRegisteredStudents")
        If ds.Tables(0).Rows.Count = 0 Then MsgBox("No Student has completed registration yet")
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Refresh()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        MsgBox("No Printer Connected")
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class