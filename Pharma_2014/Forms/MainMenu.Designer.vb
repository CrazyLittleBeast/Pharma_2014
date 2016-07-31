<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.btn_cashier = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.btn_inventory = New System.Windows.Forms.Button()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btn_report)
        Me.Panel1.Controls.Add(Me.btn_cashier)
        Me.Panel1.Controls.Add(Me.btn_user)
        Me.Panel1.Controls.Add(Me.btn_inventory)
        Me.Panel1.Location = New System.Drawing.Point(2, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 264)
        Me.Panel1.TabIndex = 0
        '
        'btn_report
        '
        Me.btn_report.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_report.Image = Global.Pharma_2014.My.Resources.Resources.TaskList
        Me.btn_report.Location = New System.Drawing.Point(509, 0)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Size = New System.Drawing.Size(140, 264)
        Me.btn_report.TabIndex = 3
        Me.btn_report.Text = "Report"
        Me.btn_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_report.UseVisualStyleBackColor = False
        '
        'btn_cashier
        '
        Me.btn_cashier.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_cashier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cashier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.btn_cashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cashier.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cashier.Image = Global.Pharma_2014.My.Resources.Resources.roadsideShop
        Me.btn_cashier.Location = New System.Drawing.Point(229, 0)
        Me.btn_cashier.Name = "btn_cashier"
        Me.btn_cashier.Size = New System.Drawing.Size(140, 264)
        Me.btn_cashier.TabIndex = 2
        Me.btn_cashier.Text = "Cashier"
        Me.btn_cashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_cashier.UseVisualStyleBackColor = False
        '
        'btn_user
        '
        Me.btn_user.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_user.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_user.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_user.Image = Global.Pharma_2014.My.Resources.Resources.MiscUser
        Me.btn_user.Location = New System.Drawing.Point(369, 0)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(140, 264)
        Me.btn_user.TabIndex = 1
        Me.btn_user.Text = "User"
        Me.btn_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_user.UseVisualStyleBackColor = False
        '
        'btn_inventory
        '
        Me.btn_inventory.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_inventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inventory.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inventory.Image = Global.Pharma_2014.My.Resources.Resources.palet_G
        Me.btn_inventory.Location = New System.Drawing.Point(89, 0)
        Me.btn_inventory.Name = "btn_inventory"
        Me.btn_inventory.Size = New System.Drawing.Size(140, 264)
        Me.btn_inventory.TabIndex = 0
        Me.btn_inventory.Text = "Inventory"
        Me.btn_inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_inventory.UseVisualStyleBackColor = False
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.BackColor = System.Drawing.Color.Transparent
        Me.lbl_user.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_user.Location = New System.Drawing.Point(192, 44)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(46, 16)
        Me.lbl_user.TabIndex = 1
        Me.lbl_user.Text = "User*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(143, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lbl_user)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(2, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(745, 417)
        Me.Panel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(140, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Zenkar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 125)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(746, 475)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_inventory As System.Windows.Forms.Button
    Friend WithEvents btn_user As System.Windows.Forms.Button
    Friend WithEvents btn_cashier As System.Windows.Forms.Button
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_report As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
