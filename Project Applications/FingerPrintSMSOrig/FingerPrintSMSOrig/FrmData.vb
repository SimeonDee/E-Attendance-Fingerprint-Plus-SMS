
'******************************************************** 
'*** PROGRAMMER:    Adeyemi Adedoyin Simeon
'*** DATE CREATED:  Copyright 2014
'*** LAST MODIFIED: May 5, 2016, 1:12 pm
'*** LOCATION:      Offa, Kwara State, Nigeria.
'********************************************************

Imports System.Data
Imports System.Data.OleDb

Public Class FrmData
    Dim cn As OleDbConnection
    Dim da As OleDbDataAdapter

    Private Sub FrmData_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MyModule.DisconnectFromDbase(cn)
    End Sub

    Private Sub FrmData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyModule.ConnectToDBase(cn)
        Dim sql As String
        sql = "SELECT * FROM AdminAllCourses WHERE TheLevel = 'ND I'"
        da = New OleDbDataAdapter(sql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "NDICourses")

        DataGridView1.RowHeadersVisible = False
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Refresh()


    End Sub
End Class