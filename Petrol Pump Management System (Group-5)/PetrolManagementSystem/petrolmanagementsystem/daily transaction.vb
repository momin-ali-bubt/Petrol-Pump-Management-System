Imports System.Data.OleDb
Imports System.Data
Public Class daily_transaction
    Dim conn As New OleDbConnection(MDIform.con)
    'Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jibon\Documents\Visual Studio 2019\Projects\petrolmanagesystem\database\db1.mdb")


    'Dim con1 As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim cmd1 As New OleDbCommand
    Dim cmd2 As New OleDbCommand
    Dim dr As OleDbDataReader
    'Dim strdate As String
    Dim flag As Integer
    Dim qflag As Integer
    Dim amt As Integer
    Dim rate As Integer
    Dim sale As Integer
    Dim stock As Integer
    Dim amount As Integer = 0
    Dim ltrans As Integer = 0

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Dispose()
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        Try
            conn.Open()
            Dim str As String = "insert into dttdetail(dt,empid,ometer,ostock,cmeter,cstock,adstock,var)values(" & "'" & cmbunit.Text & "'" & "," & "'" & cmbemp.Text & "'" & "," & "'" & txtom.Text & "'" & "," & "'" & txtos.Text & "'" & "," & "'" & txtcm.Text & "'" & "," & "'" & txtcs.Text & "'" & "," & "'" & txtdstk.Text & "'" & "," & "'" & txtvar.Text & "')"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("record are saved")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
        Select Case cmbunit.SelectedIndex
            Case 0
                txtpamt.Text = Val(txtsqty.Text) * Val(cmbrate.Text)
            Case 1
                txtspamt.Text = Val(txtsqty.Text) * Val(cmbrate.Text)
            Case 2
                txtdamt.Text = Val(txtsqty.Text) * Val(cmbrate.Text)
            Case 3
                txttdamt.Text = Val(txtsqty.Text) * Val(cmbrate.Text)
        End Select

    End Sub

    Private Sub cmbrate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrate.SelectedIndexChanged

    End Sub

    Private Sub daily_transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtpamt.Text = 0
        txtspamt.Text = 0
        txtdamt.Text = 0
        txttdamt.Text = 0
        txtpsaleamt.Text = 0
        txtprodamt.Text = 0
        txtprodamt.Text = 0
        txtexp.Text = 0
        txtdebt.Text = 0
        conn.Open()
        cmd.CommandText = "select [empid] from [empDetail]"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbemp.Items.Add(dr(0))
        End While
        dr.Close()
        cmd.CommandText = "select [prorate] from [prodetail] where [proname]=" & "'" & "Petrol" & "'"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        dr = cmd.ExecuteReader()
        dr.Read()
        'lblpetrol.Text = dr(0)
        dr.Close()
        cmd.CommandText = "select [prorate] from [prodetail] where [prorate]=" & "'" & "Speed Petrol" & "'"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        dr = cmd.ExecuteReader()
        dr.Read()
        'lblspetrol.Text = dr(0)
        dr.Close()
        cmd.CommandText = "select [prorate] from [prodetail] where [prorate]=" & "'" & "Diesel" & "'"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        dr = cmd.ExecuteReader()
        dr.Read()
        'lbldiesel.Text = dr(0)
        dr.Close()
        cmd.CommandText = "select [prorate] from [prodetail] where [prorate]=" & "'" & "Turbo Diesel" & "'"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        dr = cmd.ExecuteReader()
        dr.Read()
        'lbltdiesel.Text = dr(0)
        dr.Close()

        cmd.CommandText = "select [prorate] from [prodetail]"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        dr = cmd.ExecuteReader
        While dr.Read
            cmbrate.Items.Add(dr(0))
        End While
        dr.Close()


        cmd.CommandText = "select * from [boothsetting]"
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        dr = cmd.ExecuteReader()
        While dr.Read
            cmbunit.Items.Add(dr(1))
        End While
        dr.Close()

        Try


            cmd.CommandText = "select [lubname] from [lubdetail] "
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            dr = cmd.ExecuteReader
            While dr.Read
                cmbprodsale.Items.Add(dr(0))
            End While
            dr.Close()
            'conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
        'con.Close()

    End Sub

    Private Sub cmbprodsale_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprodsale.SelectedIndexChanged
        Try
            conn.Open()
            cmd.CommandText = "select [lubrate] from [lubdetail] where [lubname]=" & "'" & cmbprodsale.Text & "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            dr = cmd.ExecuteReader
            dr.Read()
            rate = dr(0)
            MsgBox(dr(0))
            dr.Close()
            ' conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub cmdsaleamt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsaleamt.Click
        If cmbprodsale.Text = "" Then
            MsgBox("Please select product")
            cmbprodsale.Focus()
            Exit Sub
        Else
            If txtquasale.Text = "" Then
                MsgBox("Please enter quantity sold")
                txtquasale.Focus()
                Exit Sub
            End If
        End If
        txtpsaleamt.Text = txtpsaleamt.Text + (txtquasale.Text * rate)

        Try
            conn.Open()
            cmd.CommandText = "select [lubqlt] from [lubdetail] where [lubname]=" & "'" & cmbprodsale.Text & "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            dr = cmd.ExecuteReader
            dr.Read()
            stock = dr(0) - txtquasale.Text
            dr.Close()
            cmd.CommandText = "update [lubdetail] set [lubqlt]=" & stock & " where [lubname]=" & "'" & cmbprodsale.Text & "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            MsgBox("updated successfully")

            'conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
        cmbprodsale.Items.RemoveAt(cmbprodsale.SelectedValue)
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        txtfamt.Text = (Val(txtpamt.Text) + Val(txtspamt.Text) + Val(txtdamt.Text) + Val(txttdamt.Text) + Val(txtpsaleamt.Text)) - (Val(txtprodamt.Text) + Val(txtitem.Text) + Val(txtexp.Text) + Val(txtdebt.Text))

        Try
            conn.Open()
            Dim str As String = "insert into dtdetail(famt,pamt,spamt,damt,tdamt,proamt,debamt,testamt,expamt,ffamt)values('" & txtpamt.Text & "','" & txtspamt.Text & "','" & txtdamt.Text & "','" & txttdamt.Text & "','" & txtpsaleamt.Text & "','" & txtprodamt.Text & "','" & txtexp.Text & "','" & txtdebt.Text & "','" & txtitem.Text & "','" & txtfamt.Text & "')"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("record are saved")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub txtcm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcm.LostFocus
        txtsqty.Text = Val(txtcm.Text) - Val(txtom.Text)
    End Sub

    Private Sub txtdstk_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdstk.LostFocus
        txtvar.Text = Val(txtcs.Text) - Val(txtdstk.Text)
    End Sub

    Private Sub cmdexpamt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexpamt.Click
        txtprodamt.Text = Val(txtpsaleamt.Text)
        txtitem.Text = Val(Val(txtpamt.Text) + Val(txtspamt.Text) + Val(txtdamt.Text) + Val(txttdamt.Text))
    End Sub

    Private Sub cmbunit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbunit.SelectedIndexChanged
        If cmbunit.Text = "Petrol Unit" Then
            flag = 0
            Exit Sub
        ElseIf cmbunit.Text = "Speed Petrol Unit" Then
            flag = 1
            Exit Sub
        ElseIf cmbunit.Text = "Diesel Unit" Then
            flag = 2
            Exit Sub
        ElseIf cmbunit.Text = "Turbo Diesel Unit" Then
            flag = 3
        End If

    End Sub

    Private Sub lblpetrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblpetrol.Click

    End Sub
End Class