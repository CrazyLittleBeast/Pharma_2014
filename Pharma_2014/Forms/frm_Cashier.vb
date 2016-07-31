Public Class frm_Cashier
    Dim dt, dt_cart As DataTable
    Dim search, currentUser, transID As String
    Dim selectedID As Integer
    Dim change, balanceDue, amountTendered, discount As Decimal


#Region "userdefined"

    Private Sub centerPanel()
        Panel1.Location = New Point(
            Me.ClientSize.Width / 2 - Panel1.Size.Width / 2,
            Me.ClientSize.Height / 2 - Panel1.Size.Height / 2)
        Panel1.Anchor = AnchorStyles.None
    End Sub

    Public Sub getDiscount(dis As Decimal)
        discount = dis
        calculate()
    End Sub

    Public Function getValue(num As Integer)
        Dim ret_val As Decimal
        If num = 1 Then
            ret_val = balanceDue
        ElseIf num = 2 Then
            ret_val = amountTendered
        ElseIf num = 3 Then
            ret_val = change
        ElseIf num = 4 Then
            ret_val = discount
        Else
            ret_val = 0
        End If
        Return ret_val
    End Function


    Public Function getTransID()
        Return transID
    End Function

    Public Function getCurrentUser()
        Return currentUser
    End Function

    Public Sub setUser(user As String)
        currentUser = user
    End Sub

    Public Sub getAmount(amount As Decimal)
        amountTendered = amount
        calculate()
    End Sub

    Private Sub calculate()
        Dim netTotal, less As Decimal

        If balanceDue = 0 And amountTendered = 0 Then
            lbl_total.Text = "0.00"
            lbl_amount.Text = "0.00"
            lbl_change.Text = "0.00"
            lbl_less.Text = "0(0%)"
            lbl_net.Text = "0"
        Else
            less = balanceDue * (discount / 100)
            netTotal = balanceDue - less
            change = netTotal - amountTendered
            lbl_less.Text = less & "(" & discount & "%)"
            lbl_net.Text = "Php " & netTotal

            change = change * -1

            lbl_amount.Text = "Php " & amountTendered
            lbl_change.Text = "Php " & change
            If change < 0 Then
                lbl_change.ForeColor = Color.Crimson
            Else
                lbl_change.ForeColor = Color.DimGray
            End If

        End If
    End Sub


    Private Sub reLoadCart()
        dt_cart = Me.CartTableAdapter.GetProductDetail()
        DG_Cart.DataSource = dt_cart
    End Sub

    Private Sub emptyCart()
        Try
            With Me.CartTableAdapter
                .DeleteALL()
                .Fill(Me.Pharma_DBDataSet.Cart)
            End With
            reLoadCart()
            totalRefresh()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub totalRefresh()
        Dim x, totalRow As Integer
        balanceDue = 0
        totalRow = CartTableAdapter.GetProductDetail().Count() - 1
        For x = 0 To totalRow
            balanceDue += DG_Cart.Rows(x).Cells("total").Value
        Next x
        lbl_total.Text = balanceDue
        calculate()
    End Sub

    Private Sub searchItem()
        search = txt_search.Text.Trim()
        If Len(search) > 1 And Not String.IsNullOrWhiteSpace(search.Trim()) Then
            search = search & "%"
            dt = Me.SearchProductTableAdapter.GetProduct(search, search)
            DG_productList.DataSource = dt
        Else
            dt = Me.SearchProductTableAdapter.GetProduct(search, search)
            DG_productList.DataSource = dt
        End If
    End Sub

#End Region

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        searchItem()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim result As String

        Dim item_index, product_chk, update_qty, current_qty As Integer
        Dim temp_dt As DataTable

        Try
            current_qty = 0
            item_index = DG_productList.CurrentRow.Index()
            With dt(item_index)
                selectedID = .Item("product_id")
                current_qty = .Item("qty")
            End With
            result = InputBox("Enter Quantity", "Quantity")
            product_chk = 0

            If Val(result) > 0 Then
                If current_qty > Val(result) Then
                    product_chk = Me.SearchProductTableAdapter.ProductCheck(selectedID)

                    If product_chk > 0 Then
                        With Me.CartTableAdapter
                            temp_dt = .GetQTY(selectedID)
                            update_qty = temp_dt(0).Item("qty")
                            update_qty += Val(result)
                            .UpdateCart(update_qty, selectedID)
                            .Fill(Me.Pharma_DBDataSet.Cart)
                        End With
                        reLoadCart()
                    Else

                        With Me.CartTableAdapter
                            .Insert(selectedID, Val(result))
                            .Fill(Me.Pharma_DBDataSet.Cart)
                        End With
                        reLoadCart()
                    End If
                    totalRefresh()
                Else
                    MsgBox("Insufficient item quantity")
                End If
            End If
        Catch ex As Exception
            MsgBox("No Item Selected: btn_addClick Error: " & ex.ToString, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim currentUser As String
        Dim trans_chk, sales_chk As Integer
        Dim sysGUID As Guid

        If amountTendered >= balanceDue And amountTendered > 0 Then
            currentUser = MainMenu.theUser()
            sysGUID = System.Guid.NewGuid()
            transID = sysGUID.ToString
            Try
                trans_chk = Me.TransactionTableAdapter.Insert(Now(), currentUser, sysGUID)
                sales_chk = Me.SalesTableAdapter.recordSale(sysGUID)
                searchItem()
                If sales_chk > 0 And trans_chk > 0 Then
                    MessageBox.Show("Transaction Recorded.", "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
                End If
                frm_receipt.Show()
            Catch ex As Exception
                MsgBox("Failed to record Sale. Error:" & ex.ToString)
            End Try
            transID = ""
            amountTendered = 0
        Else
            MsgBox("You haven't receive any amount or customer payment is insuficient!", MsgBoxStyle.Exclamation, "Insuficient amount")
        End If

    End Sub

    Private Sub frm_Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        centerPanel()
        currentUser = MainMenu.theUser
        reLoadCart()
        txt_search.Focus()
    End Sub

    Private Sub btn_clearCart_Click(sender As Object, e As EventArgs) Handles btn_clearCart.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to empty the cart?", "Empty Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = vbYes Then
            amountTendered = 0
            emptyCart()
            totalRefresh()
        End If

    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim item_index As Integer
        Dim item_id As Integer
        dt_cart = CartTableAdapter.GetProductDetail()
        Try
            item_index = DG_Cart.CurrentRow.Index()
            item_id = dt_cart(item_index).Item("product_id")

            With Me.CartTableAdapter
                .RemoveItem(item_id)
                .Fill(Me.Pharma_DBDataSet.Cart)
            End With
            reLoadCart()
            totalRefresh()
        Catch ex As Exception
            MsgBox("No Items to be removed!", MsgBoxStyle.Exclamation, "Remove Item")
        End Try


    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_search.Clear()
    End Sub

    Private Sub DG_productList_SelectionChanged(sender As Object, e As EventArgs) Handles DG_productList.SelectionChanged
        Dim item_index As Integer
        Try
            item_index = DG_productList.CurrentRow.Index()
            With dt(item_index)
                lbl_expiration.Text = Format(.Item("expr_date"), "MMMM dd yyyy").ToString
                lbl_qty.Text = .Item("qty").ToString

            End With

        Catch ex As Exception
            lbl_expiration.Text = "---"
            lbl_qty.Text = "---"

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = Format(Now(), "hh:mm")
        lbl_phase.Text = Format(Now(), "tt")
        lbl_today.Text = Format(Now(), "dddd" & vbCrLf & "MMMM dd, yyyy")
        lbl_sec.Text = Format(Now, "ss")
    End Sub

    Private Sub btn_LogOut_Click(sender As Object, e As EventArgs) Handles btn_LogOut.Click
        Me.Close()
        frm_userControl.Show()
        MainMenu.Close()

    End Sub

    Private Sub btn_cash_Click(sender As Object, e As EventArgs) Handles btn_cash.Click
        frm_tendered.Show()
    End Sub

    Private Sub btn_discount_Click(sender As Object, e As EventArgs) Handles btn_discount.Click
        frm_discount.Show()
    End Sub
End Class