Public Class MainMenu
    Dim currentUser As String
#Region "userdefined"
    Public Sub getuser(userID As String)
        currentUser = userID
        lbl_user.Text = currentUser
    End Sub

    Public Function theUser() As String
        Return currentUser
    End Function

#End Region

    Private Sub btn_inventory_Click(sender As Object, e As EventArgs) Handles btn_inventory.Click
        Inventory.Show()
    End Sub

    Private Sub btn_cashier_Click(sender As Object, e As EventArgs) Handles btn_cashier.Click
        frm_Cashier.Show()
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        frm_User.Show()
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        frm_report.Show()
    End Sub
End Class