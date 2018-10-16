Public Class Login

    Dim funksioni As New funksionet

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If Me.txtUsername.Text = "" Then
            Me.Label3.Text = "Username can't be empty !"
            Me.txtUsername.Focus()
        ElseIf Me.txtPassword.Text = "" Then
            Me.Label3.Text = "Password can't be empty !"
            Me.txtPassword.Focus()
        Else
            funksioni.Identifikimi("Select * from tblPuntoret where Username='" & Me.txtUsername.Text & "' and Password = '" & Me.txtPassword.Text & "'")
        End If
    End Sub
End Class