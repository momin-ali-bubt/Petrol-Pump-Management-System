
Imports System.Data.OleDb
Imports System.Data

Public Class boothsetingshow
    Dim conn As New OleDbConnection(MDIform.con)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conn.Open()
        Dim cmd As New OleDbCommand("select  *  from boothsetting", conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds)
        DataGrid1.DataSource = ds
        conn.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class