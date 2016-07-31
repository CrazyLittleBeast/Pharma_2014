Public Class Inventory
    Dim uncommitedData As Boolean = False
#Region "UserDefined"

    Public Sub addNew(brand As String, generic As String, desc As String, qty As Integer, aqrd As Date, exprd As Date, price As Decimal, selling As Decimal, supplier As Integer)
        Me.ProductTableAdapter.Insert(brand, generic, desc, qty, aqrd, exprd, price, selling, supplier)
        Me.SupplierTableAdapter.Fill(Me.Pharma_DBDataSet.Supplier)

    
        Me.ProductTableAdapter.FillByRecentProduct(Me.Pharma_DBDataSet.Product, Now.ToShortDateString(), Now())

        lbl_tblResult.Text = "Table Result: Recently Added Products"
    End Sub

    Private Sub search_product()
        Dim search As String
        Dim p_id, search_count As Integer

        search = txt_search.Text.Trim()

       

        If Len(search) > 1 And Not String.IsNullOrWhiteSpace(search.Trim()) Then
            If Not (Microsoft.VisualBasic.Asc(search) < 4) Or (Microsoft.VisualBasic.Asc(search) > 57) Then
                p_id = Val(search)
            Else
                p_id = Nothing
            End If

            search = search & "%"
            search_count = Me.ProductTableAdapter.FillBySearchResult(Me.Pharma_DBDataSet.Product, search, search, p_id, search)
            Me.SupplierTableAdapter.Fill(Me.Pharma_DBDataSet.Supplier)
            lbl_result.Text = "Result: " & search_count
        Else
            search_count = Me.ProductTableAdapter.FillBySearchResult(Me.Pharma_DBDataSet.Product, search, search, p_id, search)
            Me.SupplierTableAdapter.Fill(Me.Pharma_DBDataSet.Supplier)
            lbl_result.Text = "Result: " & search_count
        End If
    End Sub

    Private Sub centerPanel()
        Panel1.Location = New Point(
            Me.ClientSize.Width / 2 - Panel1.Size.Width / 2,
            Me.ClientSize.Height / 2 - Panel1.Size.Height / 2)
        Panel1.Anchor = AnchorStyles.None
    End Sub


#End Region



    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centerPanel()
        Me.ProductTableAdapter.FillByRecentProduct(Me.Pharma_DBDataSet.Product, Now.ToShortDateString, Now)
        Me.SupplierTableAdapter.Fill(Me.Pharma_DBDataSet.Supplier)
        lbl_tblResult.Text = "Table Result: Recently Added Products"
    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        frm_newProduct.Show()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim id As Integer
        Dim result As DialogResult

        Try
            id = Me.ProductBindingSource.Current("product_id")
        Catch ex As Exception
            MessageBox.Show("No Selected Product to be deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End Try

        result = MsgBox("Are you sure you want to Delete this product?", vbYesNo, "Delte Product")

        If result = vbYes Then
            With Me
                .ProductTableAdapter.Delete(id)
                .ProductTableAdapter.FillByRecentProduct(.Pharma_DBDataSet.Product, Now.ToShortDateString, Now)
                Me.SupplierTableAdapter.Fill(Me.Pharma_DBDataSet.Supplier)
                lbl_tblResult.Text = "Table Result: Recently Added Products"
            End With
        Else
            Return
        End If


    End Sub



  
    Private Sub btn_supplier_Click(sender As Object, e As EventArgs) Handles btn_supplier.Click
        Supplier.Show()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim update_count As Integer
        Try
            With Me.ProductTableAdapter
                update_count = .Update(Me.Pharma_DBDataSet.Product)
                .FillByRecentProduct(Me.Pharma_DBDataSet.Product, Now.ToShortDateString, Now)
                uncommitedData = False
                btn_save.BackColor = Color.DeepSkyBlue
                txt_search.Text = ""
                MessageBox.Show(update_count & " Product successfully Updated!", "Product Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                .FillByRecentProduct(Me.Pharma_DBDataSet.Product, Now.ToShortDateString, Now)
                lbl_tblResult.Text = "Table Result: Recently Added Products"
            End With
        Catch ex As Exception
            MsgBox("btn_save Error: " & ex.ToString)
        End Try


        
    End Sub

    Private Sub ProductDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDataGridView.CellValueChanged
        uncommitedData = True
        btn_save.BackColor = Color.GreenYellow
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        search_product()
        lbl_tblResult.Text = "Table Result: Search result"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub CashierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashierToolStripMenuItem.Click
        frm_Cashier.Show()
        Me.Close()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        frm_User.Show()
        Me.Close()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        frm_report.Show()
        Me.Close()
    End Sub

    Private Sub btn_showall_Click(sender As Object, e As EventArgs) Handles btn_showall.Click
        Me.ProductTableAdapter.Fill(Me.Pharma_DBDataSet.Product)
        lbl_tblResult.Text = "Table Result: All Products"
    End Sub

End Class