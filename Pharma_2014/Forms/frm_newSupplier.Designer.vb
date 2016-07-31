<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_newSupplier
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
        Dim Supplier_nameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Me.Pharma_DBDataSet = New Pharma_2014.Pharma_DBDataSet()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New Pharma_2014.Pharma_DBDataSetTableAdapters.SupplierTableAdapter()
        Me.TableAdapterManager = New Pharma_2014.Pharma_DBDataSetTableAdapters.TableAdapterManager()
        Me.txt_supplierName = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.btn_supplierADD = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Supplier_nameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CType(Me.Pharma_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Supplier_nameLabel
        '
        Supplier_nameLabel.AutoSize = True
        Supplier_nameLabel.ForeColor = System.Drawing.Color.White
        Supplier_nameLabel.Location = New System.Drawing.Point(39, 38)
        Supplier_nameLabel.Name = "Supplier_nameLabel"
        Supplier_nameLabel.Size = New System.Drawing.Size(93, 13)
        Supplier_nameLabel.TabIndex = 3
        Supplier_nameLabel.Text = "supplier name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.ForeColor = System.Drawing.Color.White
        AddressLabel.Location = New System.Drawing.Point(39, 66)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(57, 13)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "address:"
        '
        'Pharma_DBDataSet
        '
        Me.Pharma_DBDataSet.DataSetName = "Pharma_DBDataSet"
        Me.Pharma_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.Pharma_DBDataSet
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CartTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.supplier_contactTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Me.SupplierTableAdapter
        Me.TableAdapterManager.TransactionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pharma_2014.Pharma_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'txt_supplierName
        '
        Me.txt_supplierName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "supplier_name", True))
        Me.txt_supplierName.Location = New System.Drawing.Point(143, 35)
        Me.txt_supplierName.Name = "txt_supplierName"
        Me.txt_supplierName.Size = New System.Drawing.Size(262, 21)
        Me.txt_supplierName.TabIndex = 4
        '
        'txt_address
        '
        Me.txt_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "address", True))
        Me.txt_address.Location = New System.Drawing.Point(143, 63)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(262, 21)
        Me.txt_address.TabIndex = 6
        '
        'btn_supplierADD
        '
        Me.btn_supplierADD.BackColor = System.Drawing.Color.GreenYellow
        Me.btn_supplierADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_supplierADD.Location = New System.Drawing.Point(244, 113)
        Me.btn_supplierADD.Name = "btn_supplierADD"
        Me.btn_supplierADD.Size = New System.Drawing.Size(114, 37)
        Me.btn_supplierADD.TabIndex = 7
        Me.btn_supplierADD.Text = "ADD"
        Me.btn_supplierADD.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Location = New System.Drawing.Point(104, 113)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(114, 37)
        Me.btn_cancel.TabIndex = 8
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'frm_newSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(446, 177)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_supplierADD)
        Me.Controls.Add(Supplier_nameLabel)
        Me.Controls.Add(Me.txt_supplierName)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.txt_address)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_newSupplier"
        Me.Text = "New Supplier"
        CType(Me.Pharma_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pharma_DBDataSet As Pharma_2014.Pharma_DBDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As Pharma_2014.Pharma_DBDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents TableAdapterManager As Pharma_2014.Pharma_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txt_supplierName As System.Windows.Forms.TextBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents btn_supplierADD As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
End Class
