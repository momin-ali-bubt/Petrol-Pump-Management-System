Imports System.Data.OleDb
Imports System.Data

Public Class booth_settings
    Dim conn As New OleDbConnection(MDIform.con)
    Dim ad As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim ds As DataSet

    Private Sub booth_settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Petrol")
        ComboBox1.Items.Add("Speed")
        ComboBox1.Items.Add("Diesel")
        ComboBox1.Items.Add("Turbo")
        cmbno.Items.Add("1")
        cmbno.Items.Add("2")
        cmbno.Items.Add("3")
        cmbno.Items.Add("4")
        cmbno.Items.Add("5")
        cmbno.Items.Add("6")

        cmd = New OleDbCommand("select boid from boothsetting ", conn)
        conn.Open()
        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            While (dr.Read())
                ComboBox2.Items.Add(dr(0).ToString())
            End While
        End If
        dr.Close()
        conn.Close()


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        conn.Open()
        Dim str As String = "insert into boothsetting(boid,selpro,noofbooth)values('" & ComboBox2.Text & "','" & ComboBox1.Text & "','" & cmbno.Text & "')"
        cmd = New OleDbCommand(str, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("record are saved")
        conn.Close()
    End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim up As String = "update bankaccount set selpro=" & ComboBox1.Text & ",noofbooth='" & cmbno.Text & "'"
        conn.Open()
        cmd = New OleDbCommand(up, conn)
        MessageBox.Show("Record Updated", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        conn.Close()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        Dim i As Integer = 0
        cmd = New OleDbCommand("select max(boid) from boothsetting ", conn)
        conn.Open()
        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            While (dr.Read())
                i = Convert.ToInt32(dr(0).ToString())
                i = i + 1
                ComboBox2.Text = i
                ComboBox2.Items.Add(i)
            End While
        End If
        dr.Close()
        conn.Close()
        ComboBox1.Text = ""
        cmbno.Text = ""
        conn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmd = New OleDbCommand("delete from boothsetting where boid = " & ComboBox2.Text & "", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show(" Record Delete ")
        conn.Close()
        ComboBox1.Text = ""
        cmbno.Text = ""
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show("contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        cmd = New OleDbCommand("select * from boothsetting where boid = " & ComboBox2.Text & "", conn)
        conn.Open()
        dr = cmd.ExecuteReader()
        If (dr.Read) = True Then
            ComboBox2.Text = dr("boid").ToString
            ComboBox1.Text = dr("selpro").ToString
            cmbno.Text = dr("noofbooth").ToString
        ElseIf (dr.Read) = False Then
            ComboBox1.Text = ""
            cmbno.Text = ""
        End If
        conn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        boothsetingshow.Show()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Dispose()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Char.IsDigit(e.KeyChar) = True Then
            MessageBox.Show(" must contains only leter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
        If Char.IsPunctuation(e.KeyChar) = True Then
            MessageBox.Show("contains only letter", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub cmbno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbno.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            MessageBox.Show(" contains only Digits", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub cmbno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbno.SelectedIndexChanged

    End Sub
End Class