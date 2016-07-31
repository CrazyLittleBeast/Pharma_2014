<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_supplierADD = New System.Windows.Forms.Button()
        Me.DG_supplier = New System.Windows.Forms.DataGridView()
        Me.SuppliernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pharma_DBDataSet = New Pharma_2014.Pharma_DBDataSet()
        Me.SupplierTableAdapter = New Pharma_2014.Pharma_DBDataSetTableAdapters.SupplierTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pharma_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_Edit)
        Me.GroupBox2.Controls.Add(Me.btn_del)
        Me.GroupBox2.Controls.Add(Me.btn_supplierADD)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(169, 188)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supplier"
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.GreenYellow
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.ForeColor = System.Drawing.Color.Black
        Me.btn_Edit.Location = New System.Drawing.Point(26, 72)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(114, 37)
        Me.btn_Edit.TabIndex = 6
        Me.btn_Edit.Text = "EDIT"
        Me.btn_Edit.UseVisualStyleBackColor = False
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.Tomato
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(26, 115)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(114, 37)
        Me.btn_del.TabIndex = 5
        Me.btn_del.Text = "DELETE"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_supplierADD
        '
        Me.btn_supplierADD.BackColor = System.Drawing.Color.GreenYellow
        Me.btn_supplierADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_supplierADD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supplierADD.ForeColor = System.Drawing.Color.Black
        Me.btn_supplierADD.Location = New System.Drawing.Point(26, 29)
        Me.btn_supplierADD.Name = "btn_supplierADD"
        Me.btn_supplierADD.Size = New System.Drawing.Size(114, 37)
        Me.btn_supplierADD.TabIndex = 4
        Me.btn_supplierADD.Text = "ADD"
        Me.btn_supplierADD.UseVisualStyleBackColor = False
        '
        'DG_supplier
        '
        Me.DG_supplier.AllowUserToAddRows = False
        Me.DG_supplier.AllowUserToDeleteRows = False
        Me.DG_supplier.AutoGenerateColumns = False
        Me.DG_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_supplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SuppliernameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.product_count})
        Me.DG_supplier.DataSource = Me.SupplierBindingSource
        Me.DG_supplier.Location = New System.Drawing.Point(201, 22)
        Me.DG_supplier.Name = "DG_supplier"
        Me.DG_supplier.ReadOnly = True
        Me.DG_supplier.RowTemplate.Height = 24
        Me.DG_supplier.Size = New System.Drawing.Size(643, 324)
        Me.DG_supplier.TabIndex = 7
        '
        'SuppliernameDataGridViewTextBoxColumn
        '
        Me.SuppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name"
        Me.SuppliernameDataGridViewTextBoxColumn.HeaderText = "Supplier Name"
        Me.SuppliernameDataGridViewTextBoxColumn.Name = "SuppliernameDataGridViewTextBoxColumn"
        Me.SuppliernameDataGridViewTextBoxColumn.Width = 200
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 300
        '
        'product_count
        '
        Me.product_count.DataPropertyName = "product_count"
        Me.product_count.HeaderText = "Product"
        Me.product_count.Name = "product_count"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.Pharma_DBDataSet
        '
        'Pharma_DBDataSet
        '
        Me.Pharma_DBDataSet.DataSetName = "Pharma_DBDataSet"
        Me.Pharma_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(888, 377)
        Me.Controls.Add(Me.DG_supplier)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Supplier"
        Me.Text = "Supplier"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pharma_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_supplierADD As System.Windows.Forms.Button
    Friend WithEvents DG_supplier As System.Windows.Forms.DataGridView
    Friend WithEvents Pharma_DBDataSet As Pharma_2014.Pharma_DBDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As Pharma_2014.Pharma_DBDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents SuppliernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents product_count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
End Class
