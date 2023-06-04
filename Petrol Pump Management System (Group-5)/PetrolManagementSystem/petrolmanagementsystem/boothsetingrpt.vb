
Imports System.Data.OleDb
Imports System.Data

Public Class boothsetingrpt
    Dim con As New OleDbConnection(MDIform.con)
    Dim da As OleDbDataAdapter
    Dim ds16 As New DataSet()
    Dim rpt As CrystalReport3

    Private Sub boothsetingrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'CrystalReportViewer1.Visible = True
            con.Open()
            da = New OleDbDataAdapter("select * from boothsetting", con)
            da.Fill(ds16, "boothsetting")
            'rpt = New CrystalReport2
            rpt = New CrystalReport3()
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