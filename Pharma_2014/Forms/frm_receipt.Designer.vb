<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_receipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Pharma_DBDataSet = New Pharma_2014.Pharma_DBDataSet()
        Me.Cart_DetailedListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cart_DetailedListTableAdapter = New Pharma_2014.Pharma_DBDataSetTableAdapters.Cart_DetailedListTableAdapter()
        CType(Me.Pharma_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cart_DetailedListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "cart_list_DataSet"
        ReportDataSource1.Value = Me.Cart_DetailedListBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Pharma_2014.CustomerReceipt.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(21, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(635, 428)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomPercent = 75
        '
        'Pharma_DBDataSet
        '
        Me.Pharma_DBDataSet.DataSetName = "Pharma_DBDataSet"
        Me.Pharma_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cart_DetailedListBindingSource
        '
        Me.Cart_DetailedListBindingSource.DataMember = "Cart_DetailedList"
        Me.Cart_DetailedListBindingSource.DataSource = Me.Pharma_DBDataSet
        '
        'Cart_DetailedListTableAdapter
        '
        Me.Cart_DetailedListTableAdapter.ClearBeforeFill = True
        '
        'frm_receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(679, 454)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_receipt"
        Me.Text = "Receipt"
        CType(Me.Pharma_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cart_DetailedListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Cart_DetailedListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pharma_DBDataSet As Pharma_2014.Pharma_DBDataSet
    Friend WithEvents Cart_DetailedListTableAdapter As Pharma_2014.Pharma_DBDataSetTableAdapters.Cart_DetailedListTableAdapter
End Class
