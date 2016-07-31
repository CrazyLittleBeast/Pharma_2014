Public Class frm_discount

    Private Sub txt_discount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_discount.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 4 Or Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
            If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub txt_discount_TextChanged(sender As Object, e As EventArgs) Handles txt_discount.TextChanged
        lbl_percent.Text = txt_discount.Text & "%"
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim discount As Decimal
        discount = Val(txt_discount.Text)
        If discount > 100 Then
            MsgBox("Discount must be less than or equal to 100")
        Else
            frm_Cashier.getDiscount(discount)
            Me.Close()
        End If
    End Sub
End Class