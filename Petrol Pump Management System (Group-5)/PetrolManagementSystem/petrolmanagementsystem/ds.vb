Imports System.Data.OleDb
Imports System.Data

Public Class ds
    Dim conn As New OleDbConnection(MDIform.con)



    Dim cmd As New OleDbCommand
    Dim cmd1 As New OleDbCommand
    Dim cmd2 As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim strdate As String
    Dim flag As Integer
    Dim qflag As Integer
    Dim amt As Integer
    Dim rate As Integer
    Dim sale As Integer
    Dim stock As Integer
    Dim amount As Integer = 0
    Dim ltrans As Integer = 0
    Private Sub ds_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'conn.Open()
        cmbunit.Items.Add("petrol")
        cmbunit.Items.Add("disel")
        cmbunit.Items.Add("Turbo Disel")
        cmbunit.Items.Add("Speed petrol")
        txtpamt.Text = 0
        'txtspamt.Text = 0
        txtdamt.Text = 0
        TextBox1.Text = 0
        TextBox2.Text = 0
        txtfamt.Text = 0
        'txtpsaleamt.Text = 0
        'txtprodamt.Text = 0
        'txtprodamt.Text = 0
        'txtexp.Text = 0
        txtdebt.Text = 0
        Label2.Text = DateString


        strdate = DateString
        MsgBox(strdate)
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jibon\Documents\Visual Studio 2019\Projects\petrolmanagesystem\database\db1.mdb"
        conn.Open()
        conn.Close()

    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        Try
            conn.Open()
            Dim str As String = "insert into dttdetail(dt,ometer,ostock,cmeter,cstock,adstock,var,datet)values(" & "'" & cmbunit.Text & "'" & "," & "'" & txtom.Text & "'" & "," & "'" & txtos.Text & "'" & "," & "'" & txtcm.Text & "'" & "," & "'" & txtcs.Text & "'" & "," & "'" & txtdstk.Text & "'" & "," & "'" & txtvar.Text & "'," & "'" & DateString & "')"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("record are saved")
            
       

            Select Case cmbunit.SelectedIndex
                Case 0
                    txtpamt.Text = Val(txtsqty.Text) * Val(cmbrate.Text)
                Case 1
                    txtdamt.Text = Val(txtsqty.Text) * Val(cmbrate.Text)
                Case 2
                    TextBox1.Text = Val(txtsqty.Text) * Val(cmbrate.Text)
                Case 3
                    TextBox2.Text = Val(txtsqty.Text) * Val(cmbrate.Text)


            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
            txtom.Text = ""
            txtos.Text = ""
            txtsqty.Text = ""
            cmbrate.Text = ""
            txtcm.Text = ""
            txtcs.Text = ""
            txtdstk.Text = ""
            txtvar.Text = ""
        End Try

        
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmbunit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbunit.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub cmbunit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbunit.SelectedIndexChanged
        If cmbunit.Text = "petrol" Then
            flag = 0
            Exit Sub
        ElseIf cmbunit.Text = "disel" Then
            flag = 1
            Exit Sub
        ElseIf cmbunit.Text = "Turbo Disel" Then
            flag = 2
            Exit Sub
        ElseIf cmbunit.Text = "Speed petrol" Then
            flag = 3
            Exit Sub
            
        End If
    End Sub

    Private Sub txtcm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcm.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub txtcm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcm.LostFocus
        txtsqty.Text = Val(txtcm.Text)- Val(txtom.Text)
    End Sub

    Private Sub txtcm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcm.TextChanged

    End Sub

    Private Sub txtdstk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdstk.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub txtdstk_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdstk.LostFocus
        txtvar.Text = Val(txtdstk.Text) - Val(txtcs.Text)
    End Sub

    Private Sub txtdstk_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdstk.TextChanged

    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        txtfamt.Text = (Val(txtpamt.Text) + Val(txtdamt.Text) + Val(TextBox1.Text) + Val(TextBox2.Text)) - (Val(txtdebt.Text))
        Try
            conn.Open()
            Dim str As String = "insert into dtdetail(famt,pamt,ddamt,tdamt,spamt,datet)values(" & "'" & txtfamt.Text & "'" & "," & "'" & txtpamt.Text & "'" & "," & "'" & txtdamt.Text & "'" & "," & "'" & TextBox1.Text & "'" & "," & "'" & TextBox2.Text & "'" & "," & "'" & DateString & "')"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("record are saved")

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtos.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub txtos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtos.LostFocus
        Try

            conn.Open()
            If flag = 0 Then
                cmd.CommandText = "select [quantity] from [prostockdetail] where [proname]=" & "'" & cmbunit.Text & "'"

            Else : flag = 1
                cmd.CommandText = "select [quantity] from [prostockdetail] where [proname]=" & "'" & cmbunit.Text & "'"

                ' Else
                '    cmd.CommandText = "select [lubqlt] from [lubdetail] where [Lubricant Name]=" & "'" & cmbitem.Text & "'"
            End If
            If flag = 2 Then
                cmd.CommandText = "select [quantity] from [prostockdetail] where [proname]=" & "'" & cmbunit.Text & "'"

            Else : flag = 3
                cmd.CommandText = "select [quantity] from [prostockdetail] where [proname]=" & "'" & cmbunit.Text & "'"

                ' Else
                '    cmd.CommandText = "select [lubqlt] from [lubdetail] where [Lubricant Name]=" & "'" & cmbitem.Text & "'"
            End If



            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            dr = cmd.ExecuteReader()
            dr.Read()
            txtos.Text = dr(0)
            dr.Close()
            conn.Close()
            'cmbprod.Enabled = False
            'cmbitem.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()


        End Try
    End Sub

    Private Sub txtos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtos.TextChanged

    End Sub

    Private Sub txtcs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcs.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub txtcs_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcs.LostFocus
        txtcs.Text = Val(txtos.Text) - Val(txtcm.Text)
    End Sub

    Private Sub txtcs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcs.TextChanged

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        stock1 = New stock
        stock1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pdetails1 = New product_details
        pdetails1.Show()
    End Sub

    Private Sub txtom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtom.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub txtom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtom.TextChanged

    End Sub

    Private Sub txtsqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsqty.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub txtsqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsqty.TextChanged

    End Sub

    Private Sub cmbrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbrate.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub cmbrate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrate.SelectedIndexChanged

    End Sub

    Private Sub txtvar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvar.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub txtvar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvar.TextChanged

    End Sub

    Private Sub txtpamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpamt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub txtpamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpamt.TextChanged

    End Sub

    Private Sub txtdamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdamt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub txtdamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdamt.TextChanged

    End Sub

    Private Sub txtdebt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdebt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub txtdebt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdebt.TextChanged

    End Sub

    Private Sub Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Product.Click

    End Sub

    Private Sub txtfamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfamt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsSymbol(e.KeyChar) = True Then
            MessageBox.Show("only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Private Sub txtfamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfamt.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        showds.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        showfinalds.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtom.Text = ""
        txtos.Text = ""
        txtsqty.Text = ""
        cmbrate.Text = ""
        txtcm.Text = ""
        txtcs.Text = ""
        txtdstk.Text = ""
        txtvar.Text = ""
        txtpamt.Text = 0
        'txtspamt.Text = 0
        txtdamt.Text = 0
        TextBox1.Text = 0
        TextBox2.Text = 0
        txtfamt.Text = 0
        'txtpsaleamt.Text = 0
        'txtprodamt.Text = 0
        'txtprodamt.Text = 0
        'txtexp.Text = 0
        txtdebt.Text = 0
    End Sub
End Class