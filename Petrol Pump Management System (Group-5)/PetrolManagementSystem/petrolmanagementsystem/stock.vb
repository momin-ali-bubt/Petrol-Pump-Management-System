
Imports System.Data.OleDb
Imports System.Data

Public Class stock
    Dim conn As New OleDbConnection(MDIform.con)
    Dim ad As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim cmd1 As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim ds As DataSet
    Dim flag As Integer

    Private Sub stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Try
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jibon\Documents\Visual Studio 2019\Projects\petrolmanagesystem\database\db1.mdb"
            conn.Open()
            cmd.CommandText = "select [proname] from [prostockdetail]"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            dr = cmd.ExecuteReader
            While dr.Read
                cmbprod.Items.Add(dr(0))
            End While
            dr.Close()

            cmd.CommandText = "select [lubname] from [lubdetail]"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            dr = cmd.ExecuteReader
            While dr.Read
                cmbitem.Items.Add(dr(0))
            End While
            dr.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub cmdrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrefresh.Click
        cmbprod.Enabled = True
        cmbitem.Enabled = True
        cmbprod.Text = ""
        cmbitem.Text = ""
        txtstock.Text = ""
    End Sub

    Private Sub cmbitem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbitem.SelectedIndexChanged
        flag = 0
        cmbprod.Enabled = False
    End Sub

    Private Sub cmbprod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprod.SelectedIndexChanged
        flag = 1
        cmbitem.Enabled = False
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        If cmbprod.Text = "" And cmbitem.Text = "" Then
            MsgBox("Please select Product or Item")
            cmbprod.Focus()
            Exit Sub
        End If

        Try

            conn.Open()
            If flag = 1 Then
                cmd.CommandText = "select [quantity ] from [prostockdetail] where [proname]=" & "'" & cmbprod.Text & "'"
            Else
                cmd.CommandText = "select [lubqlt] from [lubdetail] where [Lubricant Name]=" & "'" & cmbitem.Text & "'"
            End If

            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            dr = cmd.ExecuteReader()
            dr.Read()
            txtstock.Text = dr(0)
            dr.Close()
            conn.Close()
            cmbprod.Enabled = False
            cmbitem.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Dispose()
    End Sub
End Class