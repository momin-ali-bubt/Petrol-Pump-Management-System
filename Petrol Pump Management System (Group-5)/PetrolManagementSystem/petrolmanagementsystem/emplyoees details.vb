Imports System.Data.OleDb
Imports System.Data

Public Class emplyoees_details
    Dim conn As New OleDbConnection(MDIform.con)
    Dim ad As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim ds As DataSet

    Private Sub emplyoees_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbdesig.Items.Add("Manager")
        cmbdesig.Items.Add("Pump Attendant")
        cmbdesig.Items.Add("Worker")
        cmbdesig.Items.Add("Salesman")
        cmd = New OleDbCommand("select empid from empdetail ", conn)
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
        Dim str As String = "insert into empdetail(empid,empname,empadd1,empadd2,city,state,pincode,phno,mbno,dob,dept,desgn,bsal,jdate)values('" & ComboBox1.Text & "','" & txtname.Text & "','" & txtadd1.Text & "','" & txtadd2.Text & "' ,'" & txtcity.Text & "','" & cmbstate.Text & "','" & txtpin.Text & "','" & txtphone.Text & "','" & txtmobile.Text & "','" & (dtp1.Value()).ToString() & "','" & cmbdept.Text & "','" & cmbdesig.Text & "','" & txtbsal.Text & "','" & (dtp2.Value()).ToString() & "')"
        cmd = New OleDbCommand(str, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("record save")
        conn.Close()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim i As Integer = 0
        cmd = New OleDbCommand("select max(empid) from empdetail ", conn)
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

        txtmobile.Text = ""
        txtcity.Text = ""
        cmbstate.Text = ""
        txtpin.Text = ""
        txtphone.Text = ""
        txtbsal.Text = ""
        cmbdesig.Text = ""
        cmbdept.Text = ""
        txtname.Focus()
        conn.Close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        cmd = New OleDbCommand("delete from empdetail where empid = " & ComboBox1.Text & "", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show(" Record Delete ")
        conn.Close()
        txtname.Text = ""
        txtadd1.Text = ""
        txtadd2.Text = ""
        txtmobile.Text = ""
        txtcity.Text = ""
        cmbstate.Text = ""
        txtpin.Text = ""
        txtphone.Text = ""
        txtbsal.Text = ""
        cmbdesig.Text = ""
        cmbdept.Text = ""
        txtname.Focus()

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
        cmd = New OleDbCommand("select * from empdetail where empid = " & ComboBox1.Text & "", conn)
        conn.Open()
        dr = cmd.ExecuteReader()
        If (dr.Read) = True Then
            ComboBox1.Text = dr("empid").ToString
            txtname.Text = dr("empname").ToString
            txtadd1.Text = dr("empadd1").ToString
            txtadd2.Text = dr("empadd2").ToString
            txtcity.Text = dr("city").ToString
            cmbstate.Text = dr("state").ToString
            txtpin.Text = dr("pincode").ToString
            txtphone.Text = dr("phno").ToString
            txtmobile.Text = dr("mbno").ToString
            dtp1.Text = dr("dob").ToString
            cmbdept.Text = dr("dept").ToString
            cmbdesig.Text = dr("desgn").ToString
            txtbsal.Text = dr("bsal").ToString
            dtp1.Text = dr("jdate").ToString
        ElseIf (dr.Read()) = False Then
            txtname.Text = ""
            txtadd1.Text = ""
            txtadd2.Text = ""
            txtmobile.Text = ""
            txtcity.Text = ""
            cmbstate.Text = ""
            txtpin.Text = ""
            txtphone.Text = ""
            txtbsal.Text = ""
            cmbdesig.Text = ""
            cmbdept.Text = ""
            txtname.Focus()

        End If
        conn.Close()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        cmd = New OleDbCommand("update empdetail set empname = '" & txtname.Text & "',empadd1 = '" & txtadd1.Text & "',empadd2= '" & txtadd2.Text & "',city='" & txtcity.Text & "',state = '" & cmbstate.Text & "',pincode = " & txtpin.Text & ",phno =" & txtphone.Text & ",mbno = " & txtmobile.Text & ",dob = '" & dtp1.Value().ToString() & "',dept = '" & cmbdesig.Text & "',bsal = " & txtbsal.Text & ",jdate = '" & dtp2.Value().ToString() & "' where empid = " & ComboBox1.Text & "", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("record successfully updated")
        conn.Close()

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        emptableshow.Show()
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

    Private Sub txtadd1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadd1.KeyPress
        'If Char.IsDigit(e.KeyChar) = True Then
        '    MessageBox.Show("Student Number must contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub txtadd1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtadd1.TextChanged

    End Sub

    Private Sub txtadd2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadd2.KeyPress
        'If Char.IsDigit(e.KeyChar) = True Then
        '    MessageBox.Show("Student Number must contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub txtadd2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtadd2.TextChanged

    End Sub

    Private Sub txtcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcity.KeyPress
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

    Private Sub txtcity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcity.TextChanged

    End Sub

    Private Sub cmbstate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbstate.KeyPress
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

    Private Sub cmbstate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstate.SelectedIndexChanged

    End Sub

    Private Sub txtpin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpin.KeyPress
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

    Private Sub txtpin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpin.TextChanged

    End Sub

    Private Sub txtphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone.KeyPress
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

    Private Sub txtphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphone.TextChanged

    End Sub

    Private Sub txtmobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobile.KeyPress
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

    Private Sub txtmobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmobile.TextChanged

    End Sub

    Private Sub cmbdept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdept.KeyPress
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

    Private Sub cmbdept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdept.SelectedIndexChanged

    End Sub

    Private Sub cmbdesig_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdesig.KeyPress
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

    Private Sub cmbdesig_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdesig.SelectedIndexChanged

    End Sub

    Private Sub txtbsal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbsal.KeyPress
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

    Private Sub txtbsal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbsal.TextChanged

    End Sub
End Class