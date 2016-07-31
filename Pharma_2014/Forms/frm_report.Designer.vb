<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_report
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ReportTableAdapter = New Pharma_2014.Pharma_DBDataSetTableAdapters.ReportTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_netTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_showAll = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG_productList = New System.Windows.Forms.DataGridView()
        Me.Product_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePurchased = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenericnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellingpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalSales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DG_productList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportTableAdapter
        '
        Me.ReportTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_netTotal)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DG_productList)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 610)
        Me.Panel1.TabIndex = 2
        '
        'lbl_netTotal
        '
        Me.lbl_netTotal.AutoSize = True
        Me.lbl_netTotal.BackColor = System.Drawing.Color.White
        Me.lbl_netTotal.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_netTotal.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_netTotal.Location = New System.Drawing.Point(775, 460)
        Me.lbl_netTotal.Name = "lbl_netTotal"
        Me.lbl_netTotal.Size = New System.Drawing.Size(67, 29)
        Me.lbl_netTotal.TabIndex = 12
        Me.lbl_netTotal.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(620, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "NET TOTAL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(24, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "SALES SUMMARY"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.btn_showAll)
        Me.Panel2.Controls.Add(Me.btn_search)
        Me.Panel2.Controls.Add(Me.dtp_from)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dtp_to)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(21, 445)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 151)
        Me.Panel2.TabIndex = 9
        '
        'btn_showAll
        '
        Me.btn_showAll.BackColor = System.Drawing.Color.GreenYellow
        Me.btn_showAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_showAll.ForeColor = System.Drawing.Color.Black
        Me.btn_showAll.Location = New System.Drawing.Point(160, 88)
        Me.btn_showAll.Name = "btn_showAll"
        Me.btn_showAll.Size = New System.Drawing.Size(104, 46)
        Me.btn_showAll.TabIndex = 9
        Me.btn_showAll.Text = "Show All Products"
        Me.btn_showAll.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.GreenYellow
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.Location = New System.Drawing.Point(50, 88)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(104, 46)
        Me.btn_search.TabIndex = 8
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'dtp_from
        '
        Me.dtp_from.Location = New System.Drawing.Point(50, 22)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(234, 21)
        Me.dtp_from.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TO"
        '
        'dtp_to
        '
        Me.dtp_to.Location = New System.Drawing.Point(50, 51)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(234, 21)
        Me.dtp_to.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "FROM"
        '
        'DG_productList
        '
        Me.DG_productList.AllowUserToAddRows = False
        Me.DG_productList.AllowUserToDeleteRows = False
        Me.DG_productList.BackgroundColor = System.Drawing.Color.White
        Me.DG_productList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_productList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_productList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_productList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product_id, Me.DatePurchased, Me.UserID, Me.BrandnameDataGridViewTextBoxColumn, Me.GenericnameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.SellingpriceDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.totalSales})
        Me.DG_productList.EnableHeadersVisualStyles = False
        Me.DG_productList.Location = New System.Drawing.Point(21, 55)
        Me.DG_productList.Name = "DG_productList"
        Me.DG_productList.ReadOnly = True
        Me.DG_productList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_productList.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DG_productList.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_productList.RowTemplate.Height = 24
        Me.DG_productList.Size = New System.Drawing.Size(894, 382)
        Me.DG_productList.TabIndex = 3
        '
        'Product_id
        '
        Me.Product_id.DataPropertyName = "product_id"
        Me.Product_id.HeaderText = "ID"
        Me.Product_id.Name = "Product_id"
        Me.Product_id.ReadOnly = True
        Me.Product_id.Visible = False
        '
        'DatePurchased
        '
        Me.DatePurchased.DataPropertyName = "Date"
        Me.DatePurchased.HeaderText = "Date"
        Me.DatePurchased.Name = "DatePurchased"
        Me.DatePurchased.ReadOnly = True
        Me.DatePurchased.Visible = False
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "UserID"
        Me.UserID.HeaderText = "User"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        Me.UserID.Visible = False
        '
        'BrandnameDataGridViewTextBoxColumn
        '
        Me.BrandnameDataGridViewTextBoxColumn.DataPropertyName = "brand_name"
        Me.BrandnameDataGridViewTextBoxColumn.HeaderText = "Brand"
        Me.BrandnameDataGridViewTextBoxColumn.Name = "BrandnameDataGridViewTextBoxColumn"
        Me.BrandnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.BrandnameDataGridViewTextBoxColumn.Width = 150
        '
        'GenericnameDataGridViewTextBoxColumn
        '
        Me.GenericnameDataGridViewTextBoxColumn.DataPropertyName = "generic_name"
        Me.GenericnameDataGridViewTextBoxColumn.HeaderText = "Generic"
        Me.GenericnameDataGridViewTextBoxColumn.Name = "GenericnameDataGridViewTextBoxColumn"
        Me.GenericnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenericnameDataGridViewTextBoxColumn.Width = 150
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 200
        '
        'SellingpriceDataGridViewTextBoxColumn
        '
        Me.SellingpriceDataGridViewTextBoxColumn.DataPropertyName = "selling_price"
        Me.SellingpriceDataGridViewTextBoxColumn.HeaderText = "Each"
        Me.SellingpriceDataGridViewTextBoxColumn.Name = "SellingpriceDataGridViewTextBoxColumn"
        Me.SellingpriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.SellingpriceDataGridViewTextBoxColumn.Width = 125
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        Me.QtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'totalSales
        '
        Me.totalSales.DataPropertyName = "totalSales"
        Me.totalSales.HeaderText = "Total Sales"
        Me.totalSales.Name = "totalSales"
        Me.totalSales.ReadOnly = True
        Me.totalSales.Width = 125
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(953, 610)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.White
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(598, 443)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(318, 64)
        '
        'frm_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(983, 639)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DG_productList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportTableAdapter As Pharma_2014.Pharma_DBDataSetTableAdapters.ReportTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_netTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DG_productList As System.Windows.Forms.DataGridView
    Friend WithEvents Product_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatePurchased As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrandnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenericnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SellingpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalSales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btn_showAll As System.Windows.Forms.Button
End Class
