Public Class frm_supplierEdit
    Dim supplier_dt As DataTable
    Dim current_index, id As Integer


    Private Sub frm_supplierEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        supplier_dt = Me.SupplierTableAdapter.GetData()
        current_index = Supplier.getDGindex()
        With supplier_dt(current_index)
            id = .Item("supplier_id")
            txt_name.Text = .Item("supplier_name")
            txt_address.Text = .Item("address")
        End With
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Me.SupplierTableAdapter.UpdateSupplier(txt_name.Text.Trim(), txt_address.Text.Trim(), id)
            MsgBox("Supplier successfully updated!")
            Supplier.updateTables()
            Me.Close()
        Catch ex As Exception
            MsgBox("btn_save Error:" & ex.ToString)
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class