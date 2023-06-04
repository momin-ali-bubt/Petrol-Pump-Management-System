
Imports System.Data.OleDb
Imports System.Data
Public Class customer_diposit_pump_bank_detail
    Dim conn As New OleDbConnection(MDIform.con)
    Dim ad As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim ds As DataSet
    Private Sub customer_diposit_pump_bank_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox5.Text = 0
        Try
            cmd = New OleDbCommand("select sno from custaccount ", conn)
            conn.Open()
            dr = cmd.ExecuteReader()
            If (dr.HasRows) Then
                While (dr.Read())
                    ComboBox1.Items.Add(dr(0).ToString())

                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            'dr.Close()

            conn.Close()
        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Dispose()
    End Sub

    'Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
    '    Try
    '        conn.Open()
    '        Dim str As String = "insert into custdiposit(custacno,custname,tdate,bname,actype,mofaction,chddno,tamt)values('" & ComboBox1.Text & "','" & TextBox1.Text & "','" & (DateTimePicker1.Value()).ToString() & "','" & cmbname.Text & "','" & ComboBox2.Text & "','" & cmbtrans.Text & "','" & TextBox2.Text & "','" & txtamt.Text & "')"

    '        cmd = New OleDbCommand(str, conn)
    '        cmd.ExecuteNonQuery()
    '        MessageBox.Show("record saved")
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Finally
    '        conn.Close()
    '    End Try

    'End Sub

    'Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
    '    Try
    '        Dim i As Integer = 0
    '        cmd = New OleDbCommand("select max(custacno) from custdiposit ", conn)
    '        conn.Open()
    '        dr = cmd.ExecuteReader()
    '        If (dr.HasRows) Then
    '            While (dr.Read())
    '                i = Convert.ToInt32(dr(0).ToString())
    '                i = i + 1
    '                ComboBox1.Text = i
    '                ComboBox1.Items.Add(i)
    '            End While
    '        End If
    '        dr.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        conn.Close()
    '    End Try
    '    'conn.Close()
    '    cmbname.Text = ""
    '    TextBox1.Text = ""
    '    cmbtrans.Text = ""
    '    TextBox2.Text = ""
    '    txtamt.Text = ""
    '    '.Text = ""
    '    cmbname.Focus()
    'End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSeparator(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Leave
        Try
            conn.Open()
            cmd = New OleDbCommand("select * from custaccount where sno = " & ComboBox1.Text & "", conn)
            dr = cmd.ExecuteReader()
            If (dr.HasRows()) = True Then
                While (dr.Read())
                    'DateTimePicker1.Value = dr("tdate").ToString
                    TextBox1.Text = dr("cname").ToString
                    TextBox3.Text = dr("balamt").ToString
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            dr.Close()
            conn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            cmd = New OleDbCommand("select * from custdiposit where custacno = " & ComboBox1.Text & "", conn)
            conn.Open()
            dr = cmd.ExecuteReader()
            If (dr.Read) = True Then
                'ComboBox1.Text = dr("custacno").ToString
                ' TextBox1.Text = dr("custname").ToString
                DateTimePicker1.Text = dr("tdate").ToString
                cmbname.Text = dr("bname").ToString
                ComboBox2.Text = dr("actype").ToString
                cmbtrans.Text = dr("mofaction").ToString
                TextBox2.Text = dr("chddno").ToString
                txtamt.Text = dr("tamt").ToString
                'ComboBox1.Text = dr("closebal").ToString
            ElseIf (dr.Read) = False Then
                cmbname.Text = ""
                TextBox1.Text = ""
                cmbtrans.Text = ""
                TextBox2.Text = ""
                txtamt.Text = ""
                ComboBox2.Text = ""
                cmbname.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dr.Close()
            conn.Close()
        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        cmd = New OleDbCommand("update custdiposit set custname = '" & TextBox1.Text & "',tdate = '" & (DateTimePicker1.Value()).ToString() & "',bname= '" & cmbname.Text & "',actype='" & ComboBox2.Text & "',mofaction = '" & cmbtrans.Text & "',chddno = '" & TextBox2.Text & "',tamt = " & txtamt.Text & ",tobank = " & TextBox5.Text & " where  custacno = " & ComboBox1.Text & "", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("record successfully updated")
        conn.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub txtamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub txtamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamt.TextChanged

    End Sub

    Private Sub cmbname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbname.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub cmbname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbname.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub cmbtrans_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtrans.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub cmbtrans_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtrans.SelectedIndexChanged
        If cmbtrans.Text = "By Cash" Then
            TextBox2.Enabled = False
            TextBox2.Text = 0
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        custdipositshow.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.LostFocus
        TextBox4.Text = Val(TextBox3.Text) - Val(txtamt.Text)
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            conn.Open()
            Dim str As String = "insert into custdiposit(custacno,custname,tdate,bname,actype,mofaction,chddno,tamt,tobank)values('" & ComboBox1.Text & "','" & TextBox1.Text & "','" & (DateTimePicker1.Value()).ToString() & "','" & cmbname.Text & "','" & ComboBox2.Text & "','" & cmbtrans.Text & "','" & TextBox2.Text & "','" & txtamt.Text & "','" & TextBox5.Text & "')"

            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("record saved")
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim i As Integer = 0
            cmd = New OleDbCommand("select max(custacno) from custdiposit ", conn)
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        'conn.Close()
        cmbname.Text = ""
        TextBox1.Text = ""
        cmbtrans.Text = ""
        TextBox2.Text = ""
        txtamt.Text = ""
        '.Text = ""
        cmbname.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox5.Text = Val(TextBox5.Text) + Val(txtamt.Text) + Val(TextBox7.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Try
        '    conn.Open()
        '    Dim str As String = "insert into tobank(bid,tbank)values('" & TextBox6.Text & "','" & TextBox5.Text & "')"

        '    cmd = New OleDbCommand(str, conn)
        '    cmd.ExecuteNonQuery()
        '    MessageBox.Show("record saved")
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Finally
        '    conn.Close()
        'End Try
        cmd = New OleDbCommand("update tobank set tbank = '" & TextBox7.Text & "' where bid = " & TextBox6.Text & "", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("record successfully updated")
        conn.Close()

    End Sub

    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        Try
            conn.Open()
            cmd = New OleDbCommand("select * from tobank where bid = " & TextBox6.Text & "", conn)
            dr = cmd.ExecuteReader()
            If (dr.HasRows()) = True Then
                While (dr.Read())
                    'DateTimePicker1.Value = dr("tdate").ToString
                    TextBox7.Text = dr("tbank").ToString
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

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox7.Text = Val(TextBox5.Text) + Val(TextBox8.Text)
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class