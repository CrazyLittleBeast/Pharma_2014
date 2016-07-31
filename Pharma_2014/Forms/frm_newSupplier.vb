Public Class frm_newSupplier
    Dim supplier_name, addrs As String

    Private Sub frm_newSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_supplierADD_Click(sender As Object, e As EventArgs) Handles btn_supplierADD.Click
        supplier_name = UCase(txt_supplierName.Text)
        addrs = UCase(txt_address.Text)

        If Application.OpenForms.OfType(Of frm_newProduct).Any Then
            frm_newProduct.addSupplier(supplier_name, addrs)
            Supplier.Close()
        Else
            Supplier.addSupplier(supplier_name, addrs)
        End If

    End Sub
End Class