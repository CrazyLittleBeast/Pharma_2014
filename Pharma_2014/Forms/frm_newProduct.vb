Public Class frm_newProduct
    Dim bname, gname, desc As String
    Dim supplier, qty As Integer
    Dim aqrd, exprd As Date
    Dim price, sprice As Decimal
    Dim dt As DataTable

#Region "userdefined"
    Public Sub addSupplier(supplier_name As String, address As String)
        Dim count As Integer

        Try
            With Me
                count = .SupplierTableAdapter.Insert(supplier_name, address)
                .SupplierTableAdapter.Fill(.Pharma_DBDataSet.Supplier)
                loadComboBox()
            End With
            MessageBox.Show("Successfully Added " & count & " New Supplier ", "Supplier Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frm_newSupplier.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to add new supplier. Supplier Already Exists", "ADD Supplier Failed", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub loadComboBox()
        dt = Me.SupplierTableAdapter.GetData()
        With cmb_supplier
            .DataSource = dt
            .DisplayMember = "supplier_name"
        End With
    End Sub
#End Region


    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        bname = UCase(txt_brand.Text)
        gname = UCase(txt_generic.Text)
        desc = UCase(txt_desc.Text)
        qty = Val(txt_qty.Text)
        aqrd = dtp_aqrd.Value
        exprd = dtp_expr.Value
        price = Val(txt_price.Text)
        sprice = Val(txt_sprice.Text)
        supplier = Val(dt(cmb_supplier.SelectedIndex).Item("supplier_id"))
        Inventory.addNew(bname, gname, desc, qty, aqrd, exprd, price, sprice, supplier)
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_newProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadComboBox()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        frm_newSupplier.Show()
    End Sub
End Class