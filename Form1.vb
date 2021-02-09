Public Class LoginForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Passwordbox_TextChanged(sender As Object, e As EventArgs) Handles passwordbox.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RegistrationForm.Show()
        Me.Hide()
    End Sub
End Class
