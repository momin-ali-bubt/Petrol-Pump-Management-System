Imports System.Data.OleDb
Imports System.Data

Public Class supplier_account
    Dim conn As New OleDbConnection(MDIform.con)
    Dim ad As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim ds As DataSet
    Private Sub supplier_account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmd = New OleDbCommand("select orderno from supplieraccount ", conn)
            conn.Open()
            dr = cmd.ExecuteReader()
            If (dr.HasRows) Then
                While (dr.Read())
                    ComboBox1.Items.Add(dr(0).ToString())
                End While
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dr.Close()
            conn.Close()
        End Try
        'conn.Close()
        cmbmode.Items.Add("By Cheque")
        cmbmode.Items.Add("By Demand Draft")
        cmbmode.Items.Add("By Cash")
        txtddno.Text = 0
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            conn.Open()
            Dim str As String = "insert into supplieraccount(orderno,suppname,proname,prorate,quant,tamt,pamt,mofpay,chddno,balamt,tdate)values('" & ComboBox1.Text & "','" & cmbname.Text & "','" & cmbproduct.Text & "','" & cmbrate.Text & "','" & txtqty.Text & "','" & txttamt.Text & "','" & txtpamt.Text & "','" & cmbmode.Text & "','" & txtddno.Text & "','" & txtbamt.Text & "','" & (dtp1.Value()).ToString() & "')"

            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("record are saved")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        ' conn.Close()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            Dim i As Integer = 0
            cmd = New OleDbCommand("select max(orderno) from supplieraccount ", conn)
            conn.Open()
            dr = cmd.ExecuteReader()
            If (dr.HasRows) Then
                While (dr.Read())
                    i = Convert.ToInt32(dr(0).ToString())
                    i = i + 1
                    ComboBox1.Text = i
                    ComboBox1.Items.Add(i)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            dr.Close()
            conn.Close()
        End Try
        ' conn.Close()
        cmbname.Text = ""
        cmbproduct.Text = ""
        cmbrate.Text = ""
        txtqty.Text = ""
        txttamt.Text = ""
        txtpamt.Text = ""
        cmbmode.Text = ""
        txtddno.Text = ""
        txtbamt.Text = ""
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try


            cmd = New OleDbCommand("select * from supplieraccount where orderno = " & ComboBox1.Text & "", conn)
            conn.Open()
            dr = cmd.ExecuteReader()
            If (dr.Read) = True Then
                'ComboBox1.Text = dr("orderno").ToString
                cmbname.Text = dr("suppname").ToString
                cmbproduct.Text = dr("proname").ToString
                cmbrate.Text = dr("prorate").ToString
                txtqty.Text = dr("quant").ToString
                txttamt.Text = dr("tamt").ToString
                txtpamt.Text = dr("pamt").ToString
                cmbmode.Text = dr("mofpay").ToString
                txtddno.Text = dr("chddno").ToString
                txtbamt.Text = dr("balamt").ToString
                dtp1.Text = dr("tdate").ToString
            ElseIf (dr.Read) = False Then
                cmbname.Text = ""
                cmbproduct.Text = ""
                cmbrate.Text = ""
                txtqty.Text = ""
                txttamt.Text = ""
                txtpamt.Text = ""
                cmbmode.Text = ""
                txtddno.Text = ""
                txtbamt.Text = ""
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dr.Close()
            conn.Close()
        End Try
        ' conn.Close()

    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click

        cmd = New OleDbCommand("update supplieraccount set suppname = '" & cmbname.Text & "',proname = '" & cmbproduct.Text & "',prorate= " & cmbrate.Text & ",quant=" & txtqty.Text & ",tamt = " & txttamt.Text & ", pamt = " & txtpamt.Text & ",mofpay = '" & cmbmode.Text & "',chddno = " & txtddno.Text & ",balamt = " & txtbamt.Text & ",tdate = '" & dtp1.Value().ToString() & "' where orderno = " & ComboBox1.Text & "", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("record successfully updated")
        conn.Close()

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Dispose()
    End Sub

    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub txtqty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqty.LostFocus
        txttamt.Text = Val(cmbrate.Text) * Val(txtqty.Text)
    End Sub

    Private Sub cmbmode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbmode.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub


    Private Sub cmbmode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmode.SelectedIndexChanged
        If cmbmode.Text = "By Cash" Then
            txtddno.Text = 0
            txtddno.Enabled = False
        End If

    End Sub

    Private Sub txtbamt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbamt.GotFocus
        txtbamt.Text = Val(txttamt.Text) - Val(txtpamt.Text)
    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        supllieraccountdetail.Show()
    End Sub

    Private Sub cmbname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbname.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If


    End Sub

    Private Sub cmbname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbname.SelectedIndexChanged

    End Sub

    Private Sub cmbproduct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbproduct.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub cmbproduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproduct.SelectedIndexChanged

    End Sub

    Private Sub cmbrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbrate.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub cmbrate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrate.SelectedIndexChanged

    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged

    End Sub

    Private Sub txttamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttamt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub txttamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttamt.TextChanged

    End Sub

    Private Sub txtpamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpamt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub txtpamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpamt.TextChanged

    End Sub

    Private Sub txtddno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtddno.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub txtddno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtddno.TextChanged

    End Sub

    Private Sub txtbamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbamt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only digit", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub txtbamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbamt.TextChanged

    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        Try
            conn.Open()
            cmd = New OleDbCommand("select * from suppwithdraw where suppacno = " & ComboBox1.Text & "", conn)
            dr = cmd.ExecuteReader()
            If (dr.HasRows()) = True Then
                While (dr.Read())
                    'DateTimePicker1.Value = dr("tdate").ToString
                    TextBox2.Text = dr("tamt").ToString
                    cmbname.Text = dr("suppname").ToString
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            dr.Close()
            conn.Close()
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtbamt.Text = Val(txtbamt.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        Try
            conn.Open()
            cmd = New OleDbCommand("select * from suppwithdraw where suppacno = " & ComboBox1.Text & "", conn)
            dr = cmd.ExecuteReader()
            If (dr.HasRows()) = True Then
                While (dr.Read())
                    'DateTimePicker1.Value = dr("tdate").ToString
                    TextBox3.Text = dr("pamt").ToString
                    'TextBox3.Text = dr("balamt").ToString
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            dr.Close()
            conn.Close()
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtbamt.Text = Val(txtbamt.Text) + Val(TextBox3.Text)
    End Sub
End Class