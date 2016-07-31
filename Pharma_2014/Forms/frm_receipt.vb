Public Class frm_receipt

    Private Sub frm_receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cashier, transID, discount, netTotal As String
        Dim balanceDue, change, tendered, dis_value As Decimal
        Dim par_balanceDue, par_change, par_tendered, par_cashier, par_transID, par_discount, par_net As Microsoft.Reporting.WinForms.ReportParameter

        Me.Cart_DetailedListTableAdapter.Fill(Me.Pharma_DBDataSet.Cart_DetailedList)

       

        With frm_Cashier
            cashier = .getCurrentUser()
            transID = .getTransID()
            balanceDue = .getValue(1)
            tendered = .getValue(2)
            change = .getValue(3)
            dis_value = .getValue(4)
            discount = (balanceDue * (dis_value / 100)) & "(" & dis_value & "%)"
            netTotal = balanceDue - (balanceDue * (dis_value / 100))
        End With


        par_balanceDue = New Microsoft.Reporting.WinForms.ReportParameter("balanceDue", balanceDue)
        par_change = New Microsoft.Reporting.WinForms.ReportParameter("change", change)
        par_tendered = New Microsoft.Reporting.WinForms.ReportParameter("amountTendered", tendered)
        par_cashier = New Microsoft.Reporting.WinForms.ReportParameter("cashier", cashier)
        par_transID = New Microsoft.Reporting.WinForms.ReportParameter("TransID", transID)
        par_discount = New Microsoft.Reporting.WinForms.ReportParameter("less_discount", discount)
        par_net = New Microsoft.Reporting.WinForms.ReportParameter("netTotal", netTotal)

        With ReportViewer1.LocalReport()
            .SetParameters(par_balanceDue)
            .SetParameters(par_tendered)
            .SetParameters(par_change)
            .SetParameters(par_cashier)
            .SetParameters(par_transID)
            .SetParameters(par_discount)
            .SetParameters(par_net)
        End With
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class