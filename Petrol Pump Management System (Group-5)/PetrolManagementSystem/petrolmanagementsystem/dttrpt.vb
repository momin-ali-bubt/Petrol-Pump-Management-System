Imports System.Data.OleDb
Imports System.Data

Public Class dttrpt
    Dim con As New OleDbConnection(MDIform.con)
    Dim da As OleDbDataAdapter
    Dim ds16 As New DataSet()
    Dim rpt As CrystalReport16

    Private Sub dttrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'CrystalReportViewer1.Visible = True
            con.Open()
            da = New OleDbDataAdapter("select * from dttdetail", con)
            da.Fill(ds16, "dttdetail")
            'rpt = New CrystalReport2
            rpt = New CrystalReport16()
            rpt.SetDataSource(ds16)
            CrystalReportViewer1.ReportSource = rpt


            ' ComboBox1.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class