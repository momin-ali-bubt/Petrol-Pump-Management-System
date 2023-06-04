
Imports System.Data.OleDb
Imports System.Data

Public Class customer_detail
    Dim conn As New OleDbConnection(MDIform.con)
    Dim ad As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim ds As DataSet

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            conn.Open()
            Dim str As String = "insert into customerdetail(custid,cname,cadd,cadd1,city,state,pincode,phno,mobno,faxno,emailid,conper)values('" & ComboBox1.Text & "','" & txtname.Text & "','" & txtadd1.Text & "','" & txtadd2.Text & "' ,'" & txtcity.Text & "','" & cmbstate.Text & "','" & txtpin.Text & "','" & txtphone.Text & "','" & txtmob.Text & "','" & txtfax.Text & "','" & txtemail.Text & "','" & txtper.Text & "')"
            If txtemail.Text.Contains("@") And txtemail.Text.EndsWith(".com") = True Then
                cmd = New OleDbCommand(str, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("record save")
            Else
                MessageBox.Show("Insert the Valid Email Id", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            'conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim i As Integer = 0
        cmd = New OleDbCommand("select max(custid) from customerdetail ", conn)
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
        txtname.Text = ""
        txtadd1.Text = ""
        txtadd2.Text = ""

        txtmob.Text = ""
        txtcity.Text = ""
        cmbstate.Text = ""
        txtpin.Text = ""
        txtphone.Text = ""
        txtfax.Text = ""
        txtemail.Text = ""
        txtper.Text = ""
        txtname.Focus()
        conn.Close()
    End Sub

    Private Sub customer_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmd = New OleDbCommand("select custid from customerdetail ", conn)
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

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        cmd = New OleDbCommand("delete from customerdetail where custid = " & ComboBox1.Text & "", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show(" Record Delete ")
        conn.Close()
        txtname.Text = ""
        txtadd1.Text = ""
        txtadd2.Text = ""
        txtmob.Text = ""
        txtcity.Text = ""
        cmbstate.Text = ""
        txtpin.Text = ""
        txtphone.Text = ""
        txtfax.Text = ""
        txtemail.Text = ""
        txtper.Text = ""
        txtname.Focus()

        'conn.Close()

    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New OleDbCommand("select * from customerdetail where custid = " & ComboBox1.Text & "", conn)
        conn.Open()
        dr = cmd.ExecuteReader()
        If (dr.Read) = True Then
            ComboBox1.Text = dr("custid").ToString
            txtname.Text = dr("cname").ToString
            txtadd1.Text = dr("cadd").ToString
            txtadd2.Text = dr("cadd1").ToString
            txtcity.Text = dr("city").ToString
            cmbstate.Text = dr("state").ToString
            txtpin.Text = dr("pincode").ToString
            txtphone.Text = dr("phno").ToString
            txtmob.Text = dr("mobno").ToString
            txtfax.Text = dr("faxno").ToString
            txtemail.Text = dr("emailid").ToString
            txtper.Text = dr("conper").ToString
        ElseIf (dr.Read()) = False Then
            txtname.Text = ""
            txtadd1.Text = ""
            txtadd2.Text = ""
            txtmob.Text = ""
            txtcity.Text = ""
            cmbstate.Text = ""
            txtpin.Text = ""
            txtphone.Text = ""
            txtfax.Text = ""
            txtemail.Text = ""
            txtper.Text = ""
            txtname.Focus()
        End If
        conn.Close()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Dispose()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Try
            cmd = New OleDbCommand("update customerdetail set cname = '" & txtname.Text & "',cadd = '" & txtadd1.Text & "',cadd1= '" & txtadd2.Text & "',city='" & txtcity.Text & "',state = '" & cmbstate.Text & "',pincode = " & txtpin.Text & ",phno = " & txtphone.Text & ",mobno = " & txtmob.Text & ",faxno = " & txtfax.Text & ",emailid = '" & txtemail.Text & "',conper = '" & txtper.Text & "' where  custid = " & ComboBox1.Text & "", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("record successfully updated")
            'conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        customerdetailshow.Show()
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub txtadd1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadd1.KeyPress
        'If Char.IsLetter(e.KeyChar) = True Then
        '    MessageBox.Show("Student Number must contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub txtadd1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtadd1.TextChanged

    End Sub

    Private Sub txtadd2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadd2.KeyPress
        'If Char.IsLetter(e.KeyChar) = True Then
        '    MessageBox.Show("Student Number must contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub txtadd2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtadd2.TextChanged

    End Sub

    Private Sub txtcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcity.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub txtcity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcity.TextChanged

    End Sub

    Private Sub cmbstate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbstate.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub cmbstate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstate.SelectedIndexChanged

    End Sub

    Private Sub txtpin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If


    End Sub

    Private Sub txtpin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpin.TextChanged

    End Sub

    Private Sub txtphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If


    End Sub

    Private Sub txtphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphone.TextChanged

    End Sub

    Private Sub txtmob_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmob.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub txtmob_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmob.TextChanged

    End Sub

    Private Sub txtfax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfax.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub txtfax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfax.TextChanged

    End Sub

    Private Sub txtper_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtper.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub txtper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtper.TextChanged

    End Sub
End Class