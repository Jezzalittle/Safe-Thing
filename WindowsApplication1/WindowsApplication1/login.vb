Public Class login

    Private Sub lnklabAccCreate_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklabAccCreate.LinkClicked
        Form2.Show()
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        End
    End Sub

    Private Sub bntLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        If txtbUsername.Text = My.Settings.Username And txtbPassword.Text = My.Settings.Password Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Username Or Password Inccorect")
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.Username.Length = 0 Or My.Settings.Password.Length = 0 Then
            MsgBox("Username And Password Not Created Yet" & vbNewLine & "Please Create New Username And Password")
            Form2.Show()
            Me.Hide()
        End If

    End Sub
End Class
