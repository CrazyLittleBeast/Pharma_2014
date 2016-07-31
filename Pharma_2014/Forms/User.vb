Public Class frm_User
    Dim dt As DataTable

#Region "userdefined"
    Public Sub addUser(userName As String, password As String, type As String)
        With Me.UserTableAdapter
            .Insert(userName, password, type)
            .Fill(Me.Pharma_DBDataSet.User)
        End With
    End Sub
#End Region

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        frm_newUser.Show()
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UserTableAdapter.Fill(Me.Pharma_DBDataSet.User)
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim userID As String
        Dim dt As DataTable
        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = vbYes Then
            Try
                dt = Me.UserTableAdapter.GetData()
                userID = dt(DG_user.CurrentRow.Index()).Item("userID")
                Me.UserTableAdapter.Delete(userID)
                Me.UserTableAdapter.Fill(Me.Pharma_DBDataSet.User)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub
End Class