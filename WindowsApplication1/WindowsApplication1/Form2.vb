Public Class Form2

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If labCreatePass.Text <> Nothing And labCreateUser.Text <> Nothing Then
            My.Settings.Username = labCreatePass.Text
            My.Settings.Password = labCreateUser.Text
            My.Settings.Save()
            MsgBox("Create account!", MsgBoxStyle.Information, "Create")
            Me.Hide()
            login.Show()
        Else
            MsgBox("That Isn't A Suitable Username Or Password!")
        End If
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        login.Show()
    End Sub
End Class