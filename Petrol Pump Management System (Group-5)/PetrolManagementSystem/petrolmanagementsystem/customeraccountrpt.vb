Imports System.Data.OleDb
Imports System.Data


Public Class customeraccountrpt
    Dim conn As New OleDbConnection(MDIform.con)
    Dim da As OleDbDataAdapter
    Dim ds16 As New DataSet()
    Dim rpt As CrystalReport4
    Private Sub customeraccountrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            da = New OleDbDataAdapter("select * from custaccount ", conn)
            da.Fill(ds16, "custaccount")
            rpt = New CrystalReport4
            rpt.SetDataSource(ds16)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class