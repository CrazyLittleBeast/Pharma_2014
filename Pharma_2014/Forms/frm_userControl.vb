Public Class frm_userControl

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim count As Integer = 0
        Dim userID, password, userType As String
        Dim user_dt As DataTable
        userID = txt_user.Text.Trim()
        password = txt_psswrd.Text.Trim()
        Try
            count = Me.UserTableAdapter.AuthenticateUser(userID, password)
            If count = 1 Then
                user_dt = Me.UserTableAdapter.GetUserDetail(userID)
                userType = user_dt(0).Item("type")
                If userType = "Administrator" Then
                    MainMenu.Show()
                    MainMenu.getuser(userID)
                    Me.Close()
                Else
                    With frm_Cashier
                        .Show()
                        .setUser(userID)
                    End With
                    Me.Close()
                End If
            Else
                MsgBox("UserID and Password Does not match!")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class