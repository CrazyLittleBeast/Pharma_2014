Public Class frm_newUser
    Dim user, psswrd, type As String

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim count As Integer

        user = txt_user.Text
        psswrd = txt_psswrd.Text
        type = cmb_type.Text
        count = txt_user.Text.Length
        If count > 1 Then
            Try
                frm_User.addUser(user, psswrd, type)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Username Already exist!")
            End Try
        Else
            MessageBox.Show("User name field Empty!")
        End If

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class