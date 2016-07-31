<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cashier
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
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DG_Cart = New System.Windows.Forms.DataGridView()
        Me.Product_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_sec = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_today = New System.Windows.Forms.Label()
        Me.lbl_phase = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_expiration = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DG_productList = New System.Windows.Forms.DataGridView()
        Me.BrandnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenericnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExprdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellingpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pharma_DBDataSet = New Pharma_2014.Pharma_DBDataSet()
        Me.CartTableAdapter = New Pharma_2014.Pharma_DBDataSetTableAdapters.CartTableAdapter()
        Me.SearchProductTableAdapter = New Pharma_2014.Pharma_DBDataSetTableAdapters.SearchProductTableAdapter()
        Me.TransactionTableAdapter = New Pharma_2014.Pharma_DBDataSetTableAdapters.TransactionTableAdapter()
        Me.SalesTableAdapter = New Pharma_2014.Pharma_DBDataSetTableAdapters.SalesTableAdapter()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_less = New System.Windows.Forms.Label()
        Me.btn_discount = New System.Windows.Forms.Button()
        Me.btn_cash = New System.Windows.Forms.Button()
        Me.btn_clearCart = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_LogOut = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_net = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DG_Cart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DG_productList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.Pharma_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.DG_Cart)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(1, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1348, 696)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.lbl_net)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.lbl_less)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.btn_discount)
        Me.Panel3.Controls.Add(Me.lbl_change)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lbl_amount)
        Me.Panel3.Controls.Add(Me.btn_cash)
        Me.Panel3.Controls.Add(Me.btn_clearCart)
        Me.Panel3.Controls.Add(Me.btn_remove)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lbl_total)
        Me.Panel3.Controls.Add(Me.btn_confirm)
        Me.Panel3.Controls.Add(Me.ShapeContainer2)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel3.Location = New System.Drawing.Point(801, 450)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(533, 208)
        Me.Panel3.TabIndex = 7
        '
        'lbl_change
        '
        Me.lbl_change.BackColor = System.Drawing.Color.Transparent
        Me.lbl_change.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_change.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_change.Location = New System.Drawing.Point(410, 95)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(107, 19)
        Me.lbl_change.TabIndex = 14
        Me.lbl_change.Text = "00.0"
        Me.lbl_change.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(60, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 26)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Change:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_amount
        '
        Me.lbl_amount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amount.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_amount.Location = New System.Drawing.Point(410, 66)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(107, 26)
        Me.lbl_amount.TabIndex = 12
        Me.lbl_amount.Text = "00.0"
        Me.lbl_amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(27, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 26)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Amount Tendered:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(97, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TOTAL:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_total.Location = New System.Drawing.Point(218, 16)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(107, 26)
        Me.lbl_total.TabIndex = 0
        Me.lbl_total.Text = "0.00"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape5, Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(533, 208)
        Me.ShapeContainer2.TabIndex = 9
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 17
        Me.LineShape2.X2 = 508
        Me.LineShape2.Y1 = 127
        Me.LineShape2.Y2 = 127
        '
        'DG_Cart
        '
        Me.DG_Cart.AllowUserToAddRows = False
        Me.DG_Cart.AllowUserToDeleteRows = False
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black
        Me.DG_Cart.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle31
        Me.DG_Cart.BackgroundColor = System.Drawing.Color.White
        Me.DG_Cart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_Cart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle32.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Cart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.DG_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Cart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product_ID, Me.Brand, Me.qty, Me.Price, Me.total})
        Me.DG_Cart.EnableHeadersVisualStyles = False
        Me.DG_Cart.Location = New System.Drawing.Point(803, 70)
        Me.DG_Cart.Name = "DG_Cart"
        Me.DG_Cart.ReadOnly = True
        Me.DG_Cart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Cart.RowHeadersDefaultCellStyle = DataGridViewCellStyle36
        Me.DG_Cart.RowHeadersWidth = 20
        Me.DG_Cart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DG_Cart.RowsDefaultCellStyle = DataGridViewCellStyle37
        Me.DG_Cart.RowTemplate.Height = 24
        Me.DG_Cart.Size = New System.Drawing.Size(532, 375)
        Me.DG_Cart.TabIndex = 3
        '
        'Product_ID
        '
        Me.Product_ID.DataPropertyName = "product_id"
        Me.Product_ID.HeaderText = "ID"
        Me.Product_ID.Name = "Product_ID"
        Me.Product_ID.ReadOnly = True
        Me.Product_ID.Visible = False
        '
        'Brand
        '
        Me.Brand.DataPropertyName = "brand_name"
        Me.Brand.HeaderText = "Name"
        Me.Brand.Name = "Brand"
        Me.Brand.ReadOnly = True
        Me.Brand.Width = 200
        '
        'qty
        '
        Me.qty.DataPropertyName = "qty"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.qty.DefaultCellStyle = DataGridViewCellStyle33
        Me.qty.HeaderText = "Quantity"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 99
        '
        'Price
        '
        Me.Price.DataPropertyName = "selling_price"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Price.DefaultCellStyle = DataGridViewCellStyle34
        Me.Price.HeaderText = "Each"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'total
        '
        Me.total.DataPropertyName = "Total"
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.total.DefaultCellStyle = DataGridViewCellStyle35
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 112
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.btn_LogOut)
        Me.Panel2.Controls.Add(Me.lbl_sec)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lbl_today)
        Me.Panel2.Controls.Add(Me.lbl_phase)
        Me.Panel2.Controls.Add(Me.lbl_time)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btn_clear)
        Me.Panel2.Controls.Add(Me.btn_close)
        Me.Panel2.Controls.Add(Me.DG_productList)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(25, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 636)
        Me.Panel2.TabIndex = 6
        '
        'lbl_sec
        '
        Me.lbl_sec.AutoSize = True
        Me.lbl_sec.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sec.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_sec.Location = New System.Drawing.Point(117, 33)
        Me.lbl_sec.Name = "lbl_sec"
        Me.lbl_sec.Size = New System.Drawing.Size(21, 13)
        Me.lbl_sec.TabIndex = 12
        Me.lbl_sec.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(174, 521)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Search:"
        '
        'lbl_today
        '
        Me.lbl_today.BackColor = System.Drawing.Color.Transparent
        Me.lbl_today.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_today.Location = New System.Drawing.Point(24, 53)
        Me.lbl_today.Name = "lbl_today"
        Me.lbl_today.Size = New System.Drawing.Size(116, 34)
        Me.lbl_today.TabIndex = 10
        Me.lbl_today.Text = "MONDAY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "January 3,2014"
        Me.lbl_today.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_phase
        '
        Me.lbl_phase.AutoSize = True
        Me.lbl_phase.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phase.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_phase.Location = New System.Drawing.Point(115, 23)
        Me.lbl_phase.Name = "lbl_phase"
        Me.lbl_phase.Size = New System.Drawing.Size(24, 13)
        Me.lbl_phase.TabIndex = 9
        Me.lbl_phase.Text = "AM"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_time.Location = New System.Drawing.Point(30, 17)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(95, 32)
        Me.lbl_time.TabIndex = 8
        Me.lbl_time.Text = "12:00"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lbl_expiration)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.lbl_qty)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.ShapeContainer3)
        Me.Panel4.Location = New System.Drawing.Point(174, 48)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(465, 61)
        Me.Panel4.TabIndex = 7
        '
        'lbl_expiration
        '
        Me.lbl_expiration.AutoSize = True
        Me.lbl_expiration.ForeColor = System.Drawing.Color.White
        Me.lbl_expiration.Location = New System.Drawing.Point(130, 26)
        Me.lbl_expiration.Name = "lbl_expiration"
        Me.lbl_expiration.Size = New System.Drawing.Size(22, 13)
        Me.lbl_expiration.TabIndex = 2
        Me.lbl_expiration.Text = "---"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Expiration Date:"
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty.ForeColor = System.Drawing.Color.Gold
        Me.lbl_qty.Location = New System.Drawing.Point(353, 14)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(51, 32)
        Me.lbl_qty.TabIndex = 3
        Me.lbl_qty.Text = "---"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(255, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Quantity:"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4})
        Me.ShapeContainer3.Size = New System.Drawing.Size(463, 59)
        Me.ShapeContainer3.TabIndex = 4
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.White
        Me.LineShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 248
        Me.LineShape4.X2 = 248
        Me.LineShape4.Y1 = 10
        Me.LineShape4.Y2 = 53
        '
        'DG_productList
        '
        Me.DG_productList.AllowUserToAddRows = False
        Me.DG_productList.AllowUserToDeleteRows = False
        Me.DG_productList.BackgroundColor = System.Drawing.Color.White
        Me.DG_productList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_productList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle38.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_productList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle38
        Me.DG_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_productList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BrandnameDataGridViewTextBoxColumn, Me.GenericnameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.ExprdateDataGridViewTextBoxColumn, Me.SellingpriceDataGridViewTextBoxColumn, Me.ProductidDataGridViewTextBoxColumn})
        Me.DG_productList.EnableHeadersVisualStyles = False
        Me.DG_productList.GridColor = System.Drawing.Color.DarkGray
        Me.DG_productList.Location = New System.Drawing.Point(174, 115)
        Me.DG_productList.Name = "DG_productList"
        Me.DG_productList.ReadOnly = True
        Me.DG_productList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_productList.RowHeadersDefaultCellStyle = DataGridViewCellStyle39
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DG_productList.RowsDefaultCellStyle = DataGridViewCellStyle40
        Me.DG_productList.RowTemplate.Height = 24
        Me.DG_productList.Size = New System.Drawing.Size(569, 395)
        Me.DG_productList.TabIndex = 2
        '
        'BrandnameDataGridViewTextBoxColumn
        '
        Me.BrandnameDataGridViewTextBoxColumn.DataPropertyName = "brand_name"
        Me.BrandnameDataGridViewTextBoxColumn.HeaderText = "Brand"
        Me.BrandnameDataGridViewTextBoxColumn.Name = "BrandnameDataGridViewTextBoxColumn"
        Me.BrandnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.BrandnameDataGridViewTextBoxColumn.Width = 141
        '
        'GenericnameDataGridViewTextBoxColumn
        '
        Me.GenericnameDataGridViewTextBoxColumn.DataPropertyName = "generic_name"
        Me.GenericnameDataGridViewTextBoxColumn.HeaderText = "Generic"
        Me.GenericnameDataGridViewTextBoxColumn.Name = "GenericnameDataGridViewTextBoxColumn"
        Me.GenericnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenericnameDataGridViewTextBoxColumn.Width = 140
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 145
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        Me.QtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtyDataGridViewTextBoxColumn.Visible = False
        '
        'ExprdateDataGridViewTextBoxColumn
        '
        Me.ExprdateDataGridViewTextBoxColumn.DataPropertyName = "expr_date"
        Me.ExprdateDataGridViewTextBoxColumn.HeaderText = "Expiration"
        Me.ExprdateDataGridViewTextBoxColumn.Name = "ExprdateDataGridViewTextBoxColumn"
        Me.ExprdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExprdateDataGridViewTextBoxColumn.Visible = False
        '
        'SellingpriceDataGridViewTextBoxColumn
        '
        Me.SellingpriceDataGridViewTextBoxColumn.DataPropertyName = "selling_price"
        Me.SellingpriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.SellingpriceDataGridViewTextBoxColumn.Name = "SellingpriceDataGridViewTextBoxColumn"
        Me.SellingpriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductidDataGridViewTextBoxColumn
        '
        Me.ProductidDataGridViewTextBoxColumn.DataPropertyName = "product_id"
        Me.ProductidDataGridViewTextBoxColumn.HeaderText = "product_id"
        Me.ProductidDataGridViewTextBoxColumn.Name = "ProductidDataGridViewTextBoxColumn"
        Me.ProductidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductidDataGridViewTextBoxColumn.Visible = False
        '
        'txt_search
        '
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Location = New System.Drawing.Point(234, 519)
        Me.txt_search.MaxLength = 100
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(509, 21)
        Me.txt_search.TabIndex = 1
        Me.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(772, 636)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 23
        Me.LineShape3.X2 = 146
        Me.LineShape3.Y1 = 49
        Me.LineShape3.Y2 = 49
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 168
        Me.LineShape1.X2 = 36
        Me.LineShape1.Y1 = 301
        Me.LineShape1.Y2 = 301
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(804, 21)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(532, 49)
        Me.Panel5.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CART"
        '
        'Timer1
        '
        '
        'Pharma_DBDataSet
        '
        Me.Pharma_DBDataSet.DataSetName = "Pharma_DBDataSet"
        Me.Pharma_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CartTableAdapter
        '
        Me.CartTableAdapter.ClearBeforeFill = True
        '
        'SearchProductTableAdapter
        '
        Me.SearchProductTableAdapter.ClearBeforeFill = True
        '
        'TransactionTableAdapter
        '
        Me.TransactionTableAdapter.ClearBeforeFill = True
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 95
        Me.LineShape5.X2 = 475
        Me.LineShape5.Y1 = 93
        Me.LineShape5.Y2 = 93
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(168, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "LESS:"
        '
        'lbl_less
        '
        Me.lbl_less.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_less.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_less.Location = New System.Drawing.Point(218, 39)
        Me.lbl_less.Name = "lbl_less"
        Me.lbl_less.Size = New System.Drawing.Size(107, 26)
        Me.lbl_less.TabIndex = 17
        Me.lbl_less.Text = "0(0%)"
        Me.lbl_less.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_discount
        '
        Me.btn_discount.BackColor = System.Drawing.Color.Transparent
        Me.btn_discount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_discount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_discount.FlatAppearance.BorderSize = 0
        Me.btn_discount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_discount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_discount.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_discount.ForeColor = System.Drawing.Color.DimGray
        Me.btn_discount.Image = Global.Pharma_2014.My.Resources.Resources.Percent_32
        Me.btn_discount.Location = New System.Drawing.Point(115, 131)
        Me.btn_discount.Name = "btn_discount"
        Me.btn_discount.Size = New System.Drawing.Size(94, 62)
        Me.btn_discount.TabIndex = 15
        Me.btn_discount.TabStop = False
        Me.btn_discount.Text = "ADD DISCOUNT"
        Me.btn_discount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_discount.UseVisualStyleBackColor = False
        '
        'btn_cash
        '
        Me.btn_cash.BackColor = System.Drawing.Color.Transparent
        Me.btn_cash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cash.FlatAppearance.BorderSize = 0
        Me.btn_cash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_cash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cash.ForeColor = System.Drawing.Color.DimGray
        Me.btn_cash.Image = Global.Pharma_2014.My.Resources.Resources.Money_48
        Me.btn_cash.Location = New System.Drawing.Point(21, 131)
        Me.btn_cash.Name = "btn_cash"
        Me.btn_cash.Size = New System.Drawing.Size(94, 62)
        Me.btn_cash.TabIndex = 10
        Me.btn_cash.TabStop = False
        Me.btn_cash.Text = "CASH"
        Me.btn_cash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_cash.UseVisualStyleBackColor = False
        '
        'btn_clearCart
        '
        Me.btn_clearCart.BackColor = System.Drawing.Color.Transparent
        Me.btn_clearCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clearCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clearCart.FlatAppearance.BorderSize = 0
        Me.btn_clearCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_clearCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_clearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearCart.ForeColor = System.Drawing.Color.DimGray
        Me.btn_clearCart.Image = Global.Pharma_2014.My.Resources.Resources.shopping_basket_48
        Me.btn_clearCart.Location = New System.Drawing.Point(303, 131)
        Me.btn_clearCart.Name = "btn_clearCart"
        Me.btn_clearCart.Size = New System.Drawing.Size(94, 62)
        Me.btn_clearCart.TabIndex = 5
        Me.btn_clearCart.TabStop = False
        Me.btn_clearCart.Text = "&Empty Cart"
        Me.btn_clearCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_clearCart.UseVisualStyleBackColor = False
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.Transparent
        Me.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_remove.FlatAppearance.BorderSize = 0
        Me.btn_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove.ForeColor = System.Drawing.Color.DimGray
        Me.btn_remove.Image = Global.Pharma_2014.My.Resources.Resources.basket_remove_48
        Me.btn_remove.Location = New System.Drawing.Point(397, 131)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(94, 62)
        Me.btn_remove.TabIndex = 8
        Me.btn_remove.TabStop = False
        Me.btn_remove.Text = "&Remove Item"
        Me.btn_remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.Transparent
        Me.btn_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirm.FlatAppearance.BorderSize = 0
        Me.btn_confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirm.ForeColor = System.Drawing.Color.DimGray
        Me.btn_confirm.Image = Global.Pharma_2014.My.Resources.Resources.basket_accept_48
        Me.btn_confirm.Location = New System.Drawing.Point(209, 131)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(94, 62)
        Me.btn_confirm.TabIndex = 4
        Me.btn_confirm.TabStop = False
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'btn_LogOut
        '
        Me.btn_LogOut.BackColor = System.Drawing.Color.Transparent
        Me.btn_LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_LogOut.FlatAppearance.BorderSize = 0
        Me.btn_LogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LogOut.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LogOut.ForeColor = System.Drawing.Color.DimGray
        Me.btn_LogOut.Image = Global.Pharma_2014.My.Resources.Resources.ButtonLogOff_48
        Me.btn_LogOut.Location = New System.Drawing.Point(30, 412)
        Me.btn_LogOut.Name = "btn_LogOut"
        Me.btn_LogOut.Size = New System.Drawing.Size(110, 57)
        Me.btn_LogOut.TabIndex = 13
        Me.btn_LogOut.TabStop = False
        Me.btn_LogOut.Text = "Log-out"
        Me.btn_LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_LogOut.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.DimGray
        Me.btn_clear.Image = Global.Pharma_2014.My.Resources.Resources.clear_48
        Me.btn_clear.Location = New System.Drawing.Point(30, 209)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(110, 57)
        Me.btn_clear.TabIndex = 5
        Me.btn_clear.TabStop = False
        Me.btn_clear.Text = "&Clear Search"
        Me.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.DimGray
        Me.btn_close.Image = Global.Pharma_2014.My.Resources.Resources.Close_48
        Me.btn_close.Location = New System.Drawing.Point(30, 324)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(110, 57)
        Me.btn_close.TabIndex = 4
        Me.btn_close.TabStop = False
        Me.btn_close.Text = "CLOSE"
        Me.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Transparent
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.DimGray
        Me.btn_add.Image = Global.Pharma_2014.My.Resources.Resources.shoppingBasket_add_48
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(29, 152)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(110, 57)
        Me.btn_add.TabIndex = 3
        Me.btn_add.TabStop = False
        Me.btn_add.Text = "&ADD"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'LineShape6
        '
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 95
        Me.LineShape6.X2 = 475
        Me.LineShape6.Y1 = 65
        Me.LineShape6.Y2 = 65
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(325, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Net Total:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_net
        '
        Me.lbl_net.BackColor = System.Drawing.Color.Transparent
        Me.lbl_net.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_net.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_net.Location = New System.Drawing.Point(410, 46)
        Me.lbl_net.Name = "lbl_net"
        Me.lbl_net.Size = New System.Drawing.Size(107, 18)
        Me.lbl_net.TabIndex = 19
        Me.lbl_net.Text = "0"
        Me.lbl_net.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1349, 730)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cashier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DG_Cart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DG_productList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Pharma_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Pharma_DBDataSet As Pharma_2014.Pharma_DBDataSet
    Friend WithEvents CartTableAdapter As Pharma_2014.Pharma_DBDataSetTableAdapters.CartTableAdapter
    Friend WithEvents DG_Cart As System.Windows.Forms.DataGridView
    Friend WithEvents DG_productList As System.Windows.Forms.DataGridView
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents btn_confirm As System.Windows.Forms.Button
    Friend WithEvents SearchProductTableAdapter As Pharma_2014.Pharma_DBDataSetTableAdapters.SearchProductTableAdapter
    Friend WithEvents btn_clearCart As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TransactionTableAdapter As Pharma_2014.Pharma_DBDataSetTableAdapters.TransactionTableAdapter
    Friend WithEvents SalesTableAdapter As Pharma_2014.Pharma_DBDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_expiration As System.Windows.Forms.Label
    Friend WithEvents lbl_qty As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents lbl_phase As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbl_today As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_sec As System.Windows.Forms.Label
    Friend WithEvents btn_LogOut As System.Windows.Forms.Button
    Friend WithEvents Product_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_cash As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_amount As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_change As System.Windows.Forms.Label
    Friend WithEvents BrandnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenericnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExprdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SellingpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_discount As System.Windows.Forms.Button
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbl_less As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbl_net As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
