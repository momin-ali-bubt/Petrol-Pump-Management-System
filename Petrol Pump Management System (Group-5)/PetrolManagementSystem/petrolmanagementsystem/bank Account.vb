Imports System.Data.OleDb
Imports System.Data
Public Class bank_Account
    Dim conn As New OleDbConnection(MDIform.con)
    Dim ad As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim ds As DataSet
    Private Sub bank_Account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        


        Try
            cmd = New OleDbCommand("select bid from tobank ", conn)
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
        'conn.Open()
        'cmd = New OleDbCommand("select  sum(tamt) from custdiposit", conn)
        'cmd.ExecuteNonQuery()
        'conn.Close()

        ''conn.Close( )

    End Sub
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Dispose()
    End Sub
    'Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

    '    Try
    '        conn.Open()
    '        Dim str As String = "insert into bankaccount(bid,tdate,bname,camt,damt,tamt)values('" & ComboBox1.Text & "','" & (DateTimePicker1.Value()).ToString() & "','" & cmbname.Text & "','" & TextBox3.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "')"
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
    '        cmd = New OleDbCommand("select max(bid) from bankaccount ", conn)
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
    '    cmbbal.Text = ""
    '    cmbtrans.Text = ""
    '    txtamt.Text = ""
    '    txtfamt.Text = ""
    '    cmbname.Focus()

    'End Sub
    
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        'Try
        '    conn.Open()
        '    cmd = New OleDbCommand("select * from custdiposit where custacno = " & ComboBox1.Text & "", conn)
        '    dr = cmd.ExecuteReader()
        '    If (dr.HasRows()) = True Then
        '        While (dr.Read())
        '            DateTimePicker1.Value = dr("tdate").ToString
        '            cmbname.Text = dr("bname").ToString
        '            TextBox3.Text = dr("tamt").ToString
        '        End While
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Finally
        '    dr.Close()
        '    conn.Close()
        'End Try



        'conn.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged


        Try
            conn.Open()
            cmd = New OleDbCommand("select * from custdiposit where custacno = " & ComboBox1.Text & "", conn)
            dr = cmd.ExecuteReader()
            If (dr.HasRows()) = True Then
                While (dr.Read())
                    DateTimePicker1.Value = dr("tdate").ToString
                    cmbname.Text = dr("bname").ToString
                    TextBox3.Text = dr("tamt").ToString
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            dr.Close()
            conn.Close()
        End Try


    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        bankshow.Show()
    End Sub
    Private Sub txtamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSeparator(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
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
        
    End Sub
    Private Sub cmbbal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSeparator(e.KeyChar) = True Then
            MessageBox.Show("contains only DIGIT", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only DIGIT", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub
    Private Sub cmbtrans_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub
    Private Sub txtfamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSeparator(e.KeyChar) = True Then
            MessageBox.Show("contains only DIGIT", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only DIGIT", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        cmd = New OleDbCommand("update bankaccount set tdate = '" & DateTimePicker1.Value().ToString() & "',bname = '" & cmbname.Text & "',camt = '" & TextBox3.Text & "',damt = '" & TextBox1.Text & "',tamt = '" & TextBox2.Text & "' where bid = " & ComboBox1.Text & "", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("record successfully updated")
        conn.Close()

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub grpbox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpbox.Enter

    End Sub

    Private Sub txtfamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox2.Text = (Val(TextBox2.Text) + Val(TextBox3.Text)) - Val(TextBox1.Text)

    End Sub


    'Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
    '    Try
    '        conn.Open()
    '        cmd = New OleDbCommand("select  sum(tamt) from custdiposit where  tamt = '" & TextBox2.Text & "' ", conn)
    '        dr = cmd.ExecuteReader()
    '        If (dr.HasRows()) = True Then
    '            While (dr.Read())
    '                'DateTimePicker1.Value = dr("tdate").ToString
    '                'cmbname.Text = dr("bname").ToString
    '                TextBox3.Text = dr("tamt").ToString
    '            End While
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Finally
    '        dr.Close()
    '        conn.Close()
    '    End Try

    'End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        Try
            conn.Open()
            cmd = New OleDbCommand("select * from tobank where bid = " & ComboBox1.Text & "", conn)
            dr = cmd.ExecuteReader()
            If (dr.HasRows()) = True Then
                While (dr.Read())
                    'DateTimePicker1.Value = dr("tdate").ToString
                    ' TextBox1.Text = dr("cname").ToString
                    TextBox3.Text = dr("tbank").ToString
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

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        Try
            conn.Open()
            cmd = New OleDbCommand("select * from ttbank where bid = " & ComboBox1.Text & "", conn)
            dr = cmd.ExecuteReader()
            If (dr.HasRows()) = True Then
                While (dr.Read())
                    'DateTimePicker1.Value = dr("tdate").ToString
                    ' TextBox1.Text = dr("cname").ToString
                    TextBox1.Text = dr("tbnk").ToString
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            dr.Close()
            conn.Close()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class