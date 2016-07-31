Public Class Supplier


#Region "User defined"
    Public Sub addSupplier(supplier_name As String, address As String)
        Dim count As Integer

        Try
            With Me
                count = .SupplierTableAdapter.Insert(supplier_name, address)
                .SupplierTableAdapter.FillSupplierAndProductCount(.Pharma_DBDataSet.Supplier)
            End With
            MessageBox.Show("Successfully Added " & count & " New Supplier ", "Supplier Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frm_newSupplier.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to add new supplier. Error: " & ex.ToString, "Failed", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Function updateTables()
        Me.SupplierTableAdapter.FillSupplierAndProductCount(Me.Pharma_DBDataSet.Supplier)
    End Function


    Public Function getDGindex()
        Return DG_supplier.CurrentRow.Index()
    End Function

#End Region

    Private Sub btn_supplierADD_Click(sender As Object, e As EventArgs) Handles btn_supplierADD.Click
        frm_newSupplier.Show()
    End Sub

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pharma_DBDataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.FillSupplierAndProductCount(Me.Pharma_DBDataSet.Supplier)

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim id As Integer
        Dim result As DialogResult


        Try
            Dim supplierName As String = Me.SupplierBindingSource.Current("supplier_name")
            result = MessageBox.Show("Are you sure you want to delete this Supplier?(" & supplierName & ")", "Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = vbYes Then
                With Me
                    id = .SupplierBindingSource.Current("supplier_id")
                    .SupplierTableAdapter.DeleteSupplier(id)
                    .SupplierTableAdapter.FillSupplierAndProductCount(.Pharma_DBDataSet.Supplier)
                End With
            End If
        Catch ex As Exception
            MsgBox("Unable to Delete Supplier." & vbNewLine & "Either no selected Supplier. Current Error: " & ex.ToString)
        End Try

    End Sub


    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        frm_supplierEdit.Show()
    End Sub
End Class