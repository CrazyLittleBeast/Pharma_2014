<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_newProduct
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
        Dim Brand_nameLabel As System.Windows.Forms.Label
        Dim Generic_nameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim Aqrd_dateLabel As System.Windows.Forms.Label
        Dim Expr_dateLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim Selling_priceLabel As System.Windows.Forms.Label
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_generic = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.dtp_aqrd = New System.Windows.Forms.DateTimePicker()
        Me.dtp_expr = New System.Windows.Forms.DateTimePicker()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_sprice = New System.Windows.Forms.TextBox()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.cmb_supplier = New System.Windows.Forms.ComboBox()
        Me.SupplierTableAdapter = New Pharma_2014.Pharma_DBDataSetTableAdapters.SupplierTableAdapter()
        Me.Pharma_DBDataSet = New Pharma_2014.Pharma_DBDataSet()
        Brand_nameLabel = New System.Windows.Forms.Label()
        Generic_nameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        Aqrd_dateLabel = New System.Windows.Forms.Label()
        Expr_dateLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Selling_priceLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Pharma_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Brand_nameLabel
        '
        Brand_nameLabel.AutoSize = True
        Brand_nameLabel.BackColor = System.Drawing.Color.Transparent
        Brand_nameLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Brand_nameLabel.Location = New System.Drawing.Point(26, 38)
        Brand_nameLabel.Name = "Brand_nameLabel"
        Brand_nameLabel.Size = New System.Drawing.Size(83, 13)
        Brand_nameLabel.TabIndex = 1
        Brand_nameLabel.Text = "Brand Name:"
        '
        'Generic_nameLabel
        '
        Generic_nameLabel.AutoSize = True
        Generic_nameLabel.BackColor = System.Drawing.Color.Transparent
        Generic_nameLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Generic_nameLabel.Location = New System.Drawing.Point(16, 66)
        Generic_nameLabel.Name = "Generic_nameLabel"
        Generic_nameLabel.Size = New System.Drawing.Size(93, 13)
        Generic_nameLabel.TabIndex = 3
        Generic_nameLabel.Text = "Generic Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.BackColor = System.Drawing.Color.Transparent
        DescriptionLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        DescriptionLabel.Location = New System.Drawing.Point(33, 94)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(76, 13)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.BackColor = System.Drawing.Color.Transparent
        QtyLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        QtyLabel.Location = New System.Drawing.Point(49, 122)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(60, 13)
        QtyLabel.TabIndex = 7
        QtyLabel.Text = "Quantity:"
        '
        'Aqrd_dateLabel
        '
        Aqrd_dateLabel.AutoSize = True
        Aqrd_dateLabel.BackColor = System.Drawing.Color.Transparent
        Aqrd_dateLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Aqrd_dateLabel.Location = New System.Drawing.Point(24, 151)
        Aqrd_dateLabel.Name = "Aqrd_dateLabel"
        Aqrd_dateLabel.Size = New System.Drawing.Size(85, 13)
        Aqrd_dateLabel.TabIndex = 9
        Aqrd_dateLabel.Text = "Aquired date:"
        '
        'Expr_dateLabel
        '
        Expr_dateLabel.AutoSize = True
        Expr_dateLabel.BackColor = System.Drawing.Color.Transparent
        Expr_dateLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Expr_dateLabel.Location = New System.Drawing.Point(9, 179)
        Expr_dateLabel.Name = "Expr_dateLabel"
        Expr_dateLabel.Size = New System.Drawing.Size(100, 13)
        Expr_dateLabel.TabIndex = 11
        Expr_dateLabel.Text = "Expiration Date:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.BackColor = System.Drawing.Color.Transparent
        PriceLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        PriceLabel.Location = New System.Drawing.Point(69, 206)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(40, 13)
        PriceLabel.TabIndex = 13
        PriceLabel.Text = "Price:"
        '
        'Selling_priceLabel
        '
        Selling_priceLabel.AutoSize = True
        Selling_priceLabel.BackColor = System.Drawing.Color.Transparent
        Selling_priceLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Selling_priceLabel.Location = New System.Drawing.Point(27, 234)
        Selling_priceLabel.Name = "Selling_priceLabel"
        Selling_priceLabel.Size = New System.Drawing.Size(82, 13)
        Selling_priceLabel.TabIndex = 15
        Selling_priceLabel.Text = "Selling Price:"
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(125, 35)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(233, 21)
        Me.txt_brand.TabIndex = 2
        '
        'txt_generic
        '
        Me.txt_generic.Location = New System.Drawing.Point(125, 63)
        Me.txt_generic.Name = "txt_generic"
        Me.txt_generic.Size = New System.Drawing.Size(233, 21)
        Me.txt_generic.TabIndex = 4
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(125, 91)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(233, 21)
        Me.txt_desc.TabIndex = 6
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(125, 119)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(233, 21)
        Me.txt_qty.TabIndex = 8
        '
        'dtp_aqrd
        '
        Me.dtp_aqrd.Location = New System.Drawing.Point(125, 147)
        Me.dtp_aqrd.Name = "dtp_aqrd"
        Me.dtp_aqrd.Size = New System.Drawing.Size(233, 21)
        Me.dtp_aqrd.TabIndex = 10
        '
        'dtp_expr
        '
        Me.dtp_expr.Location = New System.Drawing.Point(125, 175)
        Me.dtp_expr.Name = "dtp_expr"
        Me.dtp_expr.Size = New System.Drawing.Size(233, 21)
        Me.dtp_expr.TabIndex = 12
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(125, 203)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(233, 21)
        Me.txt_price.TabIndex = 14
        '
        'txt_sprice
        '
        Me.txt_sprice.Location = New System.Drawing.Point(125, 231)
        Me.txt_sprice.Name = "txt_sprice"
        Me.txt_sprice.Size = New System.Drawing.Size(233, 21)
        Me.txt_sprice.TabIndex = 16
        '
        'btn_addnew
        '
        Me.btn_addnew.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addnew.Location = New System.Drawing.Point(184, 323)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(133, 37)
        Me.btn_addnew.TabIndex = 17
        Me.btn_addnew.Text = "ADD"
        Me.btn_addnew.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Location = New System.Drawing.Point(44, 323)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(133, 37)
        Me.btn_cancel.TabIndex = 18
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Supplier:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.btn_new)
        Me.Panel1.Controls.Add(Me.cmb_supplier)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 259)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 41)
        Me.Panel1.TabIndex = 20
        '
        'btn_new
        '
        Me.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.ForeColor = System.Drawing.Color.White
        Me.btn_new.Location = New System.Drawing.Point(311, 8)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(56, 23)
        Me.btn_new.TabIndex = 21
        Me.btn_new.Text = "NEW"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'cmb_supplier
        '
        Me.cmb_supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_supplier.FormattingEnabled = True
        Me.cmb_supplier.Location = New System.Drawing.Point(76, 10)
        Me.cmb_supplier.Name = "cmb_supplier"
        Me.cmb_supplier.Size = New System.Drawing.Size(229, 21)
        Me.cmb_supplier.TabIndex = 20
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Pharma_DBDataSet
        '
        Me.Pharma_DBDataSet.DataSetName = "Pharma_DBDataSet"
        Me.Pharma_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frm_newProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(380, 387)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_addnew)
        Me.Controls.Add(Brand_nameLabel)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Generic_nameLabel)
        Me.Controls.Add(Me.txt_generic)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(QtyLabel)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Aqrd_dateLabel)
        Me.Controls.Add(Me.dtp_aqrd)
        Me.Controls.Add(Expr_dateLabel)
        Me.Controls.Add(Me.dtp_expr)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Selling_priceLabel)
        Me.Controls.Add(Me.txt_sprice)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_newProduct"
        Me.Text = "New Product"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Pharma_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_brand As System.Windows.Forms.TextBox
    Friend WithEvents txt_generic As System.Windows.Forms.TextBox
    Friend WithEvents txt_desc As System.Windows.Forms.TextBox
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents dtp_aqrd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_expr As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_sprice As System.Windows.Forms.TextBox
    Friend WithEvents btn_addnew As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmb_supplier As System.Windows.Forms.ComboBox
    Friend WithEvents SupplierTableAdapter As Pharma_2014.Pharma_DBDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents Pharma_DBDataSet As Pharma_2014.Pharma_DBDataSet
End Class
