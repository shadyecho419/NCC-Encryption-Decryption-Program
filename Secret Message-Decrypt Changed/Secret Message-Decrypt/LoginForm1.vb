Public Class LoginForm1
    Dim counter As Integer
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "user" And PasswordTextBox.Text = "login" Then
            My.Forms.frmDecrypt.Show()
        Else
            If counter = 2 Then
                MessageBox.Show("You are not a registered to use this program, program is closing", "Secret Message- Decrypt", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Me.Close()
            End If
            MessageBox.Show("Your Username or password is incorrect, try again.", "Secret Message- Decrypt", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            UsernameTextBox.Clear()
            UsernameTextBox.Focus()
            PasswordTextBox.Clear()
            counter += 1
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
