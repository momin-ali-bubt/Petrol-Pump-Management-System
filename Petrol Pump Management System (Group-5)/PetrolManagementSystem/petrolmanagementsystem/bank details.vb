Imports System.Data.OleDb
Imports System.Data

Public Class bank_details
    Dim conn As New OleDbConnection(MDIform.con)
    Dim ad As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim ds As DataSet

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            conn.Open()
            Dim str As String = "insert into bankdetail(bid,bname,badd,conper,city,state,pincode,phno,taxno,emailid,obal)values('" & ComboBox1.Text & "','" & txtname.Text & "','" & txtadd1.Text & "','" & txtper.Text & "','" & txtcity.Text & "','" & cmbstate.Text & "','" & txtpin.Text & "','" & txtphone.Text & "','" & txtfax.Text & "','" & txtemail.Text & "','" & txtobal.Text & "')"
            If txtemail.Text.Contains("@") And txtemail.Text.EndsWith(".com") = True Then
                cmd = New OleDbCommand(str, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record Inserted Successfully")
            Else
                MessageBox.Show("Insert the Valid Email Id", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            Dim i As Integer = 0
            cmd = New OleDbCommand("select max(sno) from custaccount ", conn)
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

        txtname.Text = ""
        txtadd1.Text = ""
        txtper.Text = ""
        txtcity.Text = ""
        cmbstate.Text = ""
        txtpin.Text = ""
        txtphone.Text = ""
        txtfax.Text = ""
        txtemail.Text = ""
        txtobal.Text = ""
        txtname.Focus()
    End Sub

    Private Sub bank_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmd = New OleDbCommand("select bid from bankdetail ", conn)
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
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            'conn.Open()
            cmd = New OleDbCommand("delete from bankdetail where bid = " & ComboBox1.Text & "", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show(" Record Deleted Successfully ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
        txtname.Text = ""
        txtadd1.Text = ""
        txtper.Text = ""
        txtcity.Text = ""
        cmbstate.Text = ""
        txtpin.Text = ""
        txtphone.Text = ""
        txtfax.Text = ""
        txtemail.Text = ""
        txtobal.Text = ""
        txtname.Focus()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            cmd = New OleDbCommand("select * from bankdetail where bid = " & ComboBox1.Text & "", conn)
            conn.Open()
            dr = cmd.ExecuteReader()
            If (dr.Read) = True Then
                ComboBox1.Text = dr("bid").ToString
                txtname.Text = dr("bname").ToString
                txtadd1.Text = dr("badd").ToString
                txtper.Text = dr("conper").ToString
                txtcity.Text = dr("city").ToString
                cmbstate.Text = dr("state").ToString
                txtpin.Text = dr("pincode").ToString
                txtphone.Text = dr("phno").ToString
                txtfax.Text = dr("taxno").ToString
                txtemail.Text = dr("emailid").ToString
                txtobal.Text = dr("obal").ToString
            ElseIf (dr.Read) = False Then
                txtname.Text = ""
                txtadd1.Text = ""
                txtper.Text = ""
                txtcity.Text = ""
                cmbstate.Text = ""
                txtpin.Text = ""
                txtphone.Text = ""
                txtfax.Text = ""
                txtemail.Text = ""
                txtobal.Text = ""
                txtname.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dr.Close()
            conn.Close()
        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        bankdetailshow.Show()
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
    End Sub
    Private Sub txtadd1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadd1.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If


    End Sub

    Private Sub txtper_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtper.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show(" must contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub
    Private Sub txtcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcity.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show(" contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub
    Private Sub cmbstate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbstate.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
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
    Private Sub txtphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Private Sub txtemail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemail.KeyPress
        'If Char.IsLetter(e.KeyChar) = False Then
        '    MessageBox.Show("must contains letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    e.Handled = True
        'End If
        'If Char.IsSymbol(e.KeyChar) = False Then
        '    MessageBox.Show(" contains only symbol", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    e.Handled = True
        'End If
    End Sub
    Private Sub txtobal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtobal.KeyPress
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

    
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        cmd = New OleDbCommand("update bankdetail set bname = '" & txtname.Text & "',badd = '" & txtadd1.Text & "',conper= '" & txtper.Text & "',city='" & txtcity.Text & "',state = '" & cmbstate.Text & "', pincode = " & txtpin.Text & ",phno = " & txtphone.Text & ",taxno = " & txtfax.Text & ",emailid = '" & txtemail.Text & "',obal = " & txtobal.Text & " where bid = " & ComboBox1.Text & " ", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("record successfully updated")
        conn.Close()

    End Sub
End Class