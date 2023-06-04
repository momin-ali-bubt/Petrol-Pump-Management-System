Public Class login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_submit.Click
        Dim count As Integer
        count = count + 1
        Dim pass, user As String
        pass = "1"
        user = "1"
        If count = 3 Then
            MsgBox("sorry U have completed three attemp")
            OK_submit.Enabled = False
            Me.Hide()
        Else
            If (txtusername.Text = pass And txtpassword.Text = user) Then
                MDIform.Show()
                Me.Hide()
            Else
                MsgBox("enter valid password " & count & "times")
                txtusername.Text = ""
                txtpassword.Text = ""
            End If
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
           End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Dispose()
    End Sub
End Class