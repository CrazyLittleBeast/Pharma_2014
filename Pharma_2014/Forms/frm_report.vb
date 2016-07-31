Public Class frm_report
    Dim report_dt As DataTable


#Region "User Defined"

    Private Sub reloadTable(fromDate As Date, toDate As Date)
        report_dt = Me.ReportTableAdapter.GetProductsTotalQTY(fromDate, toDate)
        DG_productList.DataSource = report_dt
        calcNetTotal()
    End Sub

    Private Sub calcNetTotal()
        Dim totalRows, x As Integer
        Dim netTotal As Decimal
        Try
            totalRows = report_dt.Rows.Count()
            For x = 0 To totalRows - 1
                netTotal += report_dt(x).Item("totalSales")
            Next
            lbl_netTotal.Text = netTotal
            netTotal = 0
        Catch ex As Exception
            MsgBox("Error in Function calNetTotal")
        End Try

    End Sub


#End Region

    Private Sub frm_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadTable(Now.ToShortDateString, Now)
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs)
        Try
            reloadTable(dtp_from.Value.ToShortDateString, dtp_to.Value)
        Catch ex As Exception
            MsgBox("btn_search_click function Error:" & ex.ToString)
        End Try

    End Sub

    Private Sub btn_showAll_Click(sender As Object, e As EventArgs) Handles btn_showAll.Click
        frm_allProducts.Show()
    End Sub
End Class