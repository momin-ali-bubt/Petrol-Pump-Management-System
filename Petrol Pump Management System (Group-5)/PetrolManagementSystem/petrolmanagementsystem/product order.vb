Imports System.Data.OleDb
Imports System.Data



Public Class product_order
    Dim conn As New OleDbConnection(MDIform.con)
    Dim ad As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim ds As DataSet
    Private Sub product_order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmd = New OleDbCommand("select oid from orderdetail ", conn)
        conn.Open()
        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            While (dr.Read())
                ComboBox1.Items.Add(dr(0).ToString())
            End While
        End If
        dr.Close()
        conn.Close()

    End Sub
    Private Sub saveorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveorder.Click
        Try
            conn.Open()
            Dim str As String = "insert into orderdetail(oid,odate,porder,suppname,prorate,quanorder,oamt)values('" & ComboBox1.Text & "','" & (DateTimePicker1.Value()).ToString & "','" & cmborder.Text & "','" & cmbsname.Text & "','" & cmbrate.Text & "','" & txtordered.Text & "','" & txtamt.Text & "' )"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("record save")
            'conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim i As Integer = 0
        cmd = New OleDbCommand("select max(oid) from orderdetail ", conn)
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
        dr.Close()
        conn.Close()
        cmborder.Text = ""
        cmbsname.Text = ""
        cmbrate.Text = ""
        txtordered.Text = ""
        txtamt.Text = ""
        cmborder.Focus()

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        cmd = New OleDbCommand("delete from orderdetail where oid = " & ComboBox1.Text & "", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show(" Record Delete ")
        conn.Close()
        cmborder.Text = ""
        cmbsname.Text = ""
        cmbrate.Text = ""
        txtordered.Text = ""
        txtamt.Text = ""
        'conn.Close()
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
        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New OleDbCommand("select * from orderdetail where oid = " & ComboBox1.Text & "", conn)
        conn.Open()
        dr = cmd.ExecuteReader()
        If (dr.Read) = True Then
            ComboBox1.Text = dr("oid").ToString
            DateTimePicker1.Text = dr("odate").ToString
            cmborder.Text = dr("porder").ToString
            cmbsname.Text = dr("suppname").ToString
            cmbrate.Text = dr("prorate").ToString
            txtordered.Text = dr("quanorder").ToString
            txtamt.Text = dr("oamt").ToString
            
        ElseIf (dr.Read) = False Then
            cmborder.Text = ""
            cmbsname.Text = ""
            cmbrate.Text = ""
            txtordered.Text = ""
            txtamt.Text = ""
        End If
        conn.Close()

    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        cmd = New OleDbCommand("update orderdetail set odate = '" & (DateTimePicker1.Value()).ToString & "',porder = '" & cmborder.Text & "',suppname= '" & cmbsname.Text & "',prorate='" & cmbrate.Text & "',quanorder='" & txtordered.Text & "',oamt='" & txtamt.Text & "' where oid = " & ComboBox1.Text & "", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("record successfully updated")
        conn.Close()

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Dispose()
    End Sub

    Private Sub btnorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnorder.Click
        productorderdetail.Show()
    End Sub

    Private Sub cmborder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmborder.KeyPress
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

    Private Sub cmborder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmborder.SelectedIndexChanged

    End Sub

    Private Sub cmbsname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbsname.KeyPress
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

    Private Sub cmbsname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsname.SelectedIndexChanged

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

    Private Sub txtordered_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtordered.KeyPress
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

    Private Sub txtordered_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtordered.TextChanged

    End Sub

    Private Sub txtamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamt.KeyPress
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

    Private Sub txtamt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamt.LostFocus
        txtamt.Text = Val(txtordered.Text) * Val(cmbrate.Text)
    End Sub

    Private Sub txtamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamt.TextChanged

    End Sub
End Class