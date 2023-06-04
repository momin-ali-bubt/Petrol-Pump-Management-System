
Imports System.Data.OleDb
Imports System.Data

Public Class bankdetailrpt

    Dim con As New OleDbConnection(MDIform.con)
    Dim da As OleDbDataAdapter
    Dim ds16 As New DataSet()
    Dim rpt As CrystalReport2


    Private Sub bankdetailrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'CrystalReportViewer1.Visible = True
            con.Open()
            da = New OleDbDataAdapter("select * from bankdetail", con)
            da.Fill(ds16, "bankdetail")
            'rpt = New CrystalReport2
            rpt = New CrystalReport2()
            rpt.SetDataSource(ds16)
            CrystalReportViewer1.ReportSource = rpt


            ' ComboBox1.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim s As New MDIform()
        Me.Hide()
        s.Show()
    End Sub
End Class