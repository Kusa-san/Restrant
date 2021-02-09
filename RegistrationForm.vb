Public Class RegistrationForm
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Register(sender As Object, e As EventArgs) Handles loginbutton.Click
        ''check for wrong crapa 
        If String.IsNullOrEmpty(NameBox.Text) Or String.IsNullOrEmpty(passwordbox.Text) Then
            MessageBox.Show(Me, "Name or password can't be empty", "Invaild data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        ''creating database object
        ''"Using" is not "Dim" google it up nigga !
        Using datatbase As New MyDBEntities
            ''creating a new nigga
            Dim person As New Person()
            ''filling the nigga data
            person.Name = NameBox.Text
            person.Password = passwordbox.Text
            ''adding the data to a virtual DB object
            datatbase.People.Add(person)
            ''saving the data to database on disk
            datatbase.SaveChanges()
        End Using
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class