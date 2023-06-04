Imports System.Data.OleDb
Imports System.Data

Public Class ledgerdetails
    Dim conn As New OleDbConnection(MDIform.con)
    Dim ad As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim ds As DataSet

    Private Sub ledgerdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmd = New OleDbCommand("select ledid from ledgerdetail ", conn)
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

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        conn.Open()
        Dim str As String = "insert into ledgerdetail(ledid,ledname,ledtype,obal,cbal)values('" & ComboBox1.Text & "','" & txtname.Text & "','" & cmbtype.Text & "','" & txtobal.Text & "','" & txtcbal.Text & "' )"
        cmd = New OleDbCommand(str, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("record save")
        conn.Close()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim i As Integer = 0
        cmd = New OleDbCommand("select max(ledid) from ledgerdetail ", conn)
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
        cmbtype.Text = ""
        txtobal.Text = ""
        txtcbal.Text = ""
        txtname.Focus()
        conn.Close()

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        cmd = New OleDbCommand("delete from ledgerdetail where ledid = " & ComboBox1.Text & "", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show(" Record Delete ")
        conn.Close()
        txtname.Text = ""
        cmbtype.Text = ""
        txtobal.Text = ""
        txtcbal.Text = ""
        conn.Close()
    End Sub

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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New OleDbCommand("select * from ledgerdetail where ledid = " & ComboBox1.Text & "", conn)
        conn.Open()
        dr = cmd.ExecuteReader()
        If (dr.Read) = True Then
            ComboBox1.Text = dr("ledid").ToString
            txtname.Text = dr("ledname").ToString
            cmbtype.Text = dr("ledtype").ToString
            txtobal.Text = dr("obal").ToString
            txtcbal.Text = dr("cbal").ToString
        ElseIf (dr.Read()) = False Then
            txtname.Text = ""
            cmbtype.Text = ""
            txtobal.Text = ""
            txtcbal.Text = ""

        End If
        conn.Close()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        cmd = New OleDbCommand("update ledgerdetail set ledname = '" & txtname.Text & "',ledtype = '" & cmbtype.Text & "',obal= " & txtobal.Text & ",cbal=" & txtcbal.Text & " where ledid = " & ComboBox1.Text & "", conn)

        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("record successfully updated")
        conn.Close()

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Dispose()
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
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

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub cmbtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtype.KeyPress
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

    Private Sub cmbtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtype.SelectedIndexChanged

    End Sub

    Private Sub txtobal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtobal.KeyPress
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
    End Sub

    Private Sub txtobal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtobal.TextChanged

    End Sub

    Private Sub txtcbal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcbal.KeyPress
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
    End Sub

    Private Sub txtcbal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcbal.TextChanged

    End Sub

    Private Sub btnorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnorder.Click
        ledshow.Show()

    End Sub

    Private Sub grpbox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpbox.Enter

    End Sub
End Class