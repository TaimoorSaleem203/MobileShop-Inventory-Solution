<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventorySol
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
        Dim TaxRateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventorySol))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.productBox = New System.Windows.Forms.GroupBox()
        Me.brandCbBox = New System.Windows.Forms.ComboBox()
        Me.MobileInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MobileInvDS = New MobileShopFrm.MobileInvDS()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.categoryCbBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.actionBox = New System.Windows.Forms.GroupBox()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.Add_Btn = New System.Windows.Forms.Button()
        Me.Undo_Btn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.Show_Btn = New System.Windows.Forms.Button()
        Me.Update_Btn = New System.Windows.Forms.Button()
        Me.pricingBox = New System.Windows.Forms.GroupBox()
        Me.TaxRateTextBox = New System.Windows.Forms.TextBox()
        Me.reorderTxtBox = New System.Windows.Forms.TextBox()
        Me.warantyTxtBox = New System.Windows.Forms.ComboBox()
        Me.saleTxtBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.purchaseTxtBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MobileInvTableAdapter = New MobileShopFrm.MobileInvDSTableAdapters.MobileInvTableAdapter()
        Me.TableAdapterManager = New MobileShopFrm.MobileInvDSTableAdapters.TableAdapterManager()
        Me.MobileInv_DGV = New System.Windows.Forms.DataGridView()
        Me.dgv_product_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_color = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgv_storage = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgv_unit = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgv_Ram = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgv_purchase_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_sale_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_tax_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_reorder_level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_warranty_months = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_isactive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NavBox = New System.Windows.Forms.GroupBox()
        Me.ToCount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FromCount = New System.Windows.Forms.Label()
        Me.moveLastBtn = New System.Windows.Forms.Button()
        Me.moveNextBtn = New System.Windows.Forms.Button()
        Me.MovePrevBtn = New System.Windows.Forms.Button()
        Me.MoveFirstBtn = New System.Windows.Forms.Button()
        TaxRateLabel = New System.Windows.Forms.Label()
        Me.productBox.SuspendLayout()
        CType(Me.MobileInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileInvDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.actionBox.SuspendLayout()
        Me.pricingBox.SuspendLayout()
        CType(Me.MobileInv_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TaxRateLabel
        '
        TaxRateLabel.AutoSize = True
        TaxRateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        TaxRateLabel.Location = New System.Drawing.Point(419, 45)
        TaxRateLabel.Name = "TaxRateLabel"
        TaxRateLabel.Size = New System.Drawing.Size(59, 17)
        TaxRateLabel.TabIndex = 12
        TaxRateLabel.Text = "Tax Rate"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1350, 729)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.MenuHighlight
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(-2, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1373, 44)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRODUCT MASTER"
        '
        'productBox
        '
        Me.productBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.productBox.Controls.Add(Me.brandCbBox)
        Me.productBox.Controls.Add(Me.Label2)
        Me.productBox.Controls.Add(Me.categoryCbBox)
        Me.productBox.Controls.Add(Me.Label4)
        Me.productBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.productBox.Location = New System.Drawing.Point(17, 61)
        Me.productBox.Name = "productBox"
        Me.productBox.Size = New System.Drawing.Size(476, 87)
        Me.productBox.TabIndex = 3
        Me.productBox.TabStop = False
        Me.productBox.Text = "Product Information"
        '
        'brandCbBox
        '
        Me.brandCbBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.brandCbBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "Brand", True))
        Me.brandCbBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.brandCbBox.FormattingEnabled = True
        Me.brandCbBox.Items.AddRange(New Object() {"Apple", "Samsung", "Xiaomi", "Oppo", "Vivo", "OnePlus", "Realme", "Google", "Infinix", "Tecno", "Anker", "Baseus", "JBL", "Generic"})
        Me.brandCbBox.Location = New System.Drawing.Point(62, 42)
        Me.brandCbBox.Name = "brandCbBox"
        Me.brandCbBox.Size = New System.Drawing.Size(149, 25)
        Me.brandCbBox.TabIndex = 10
        '
        'MobileInvBindingSource
        '
        Me.MobileInvBindingSource.DataMember = "MobileInv"
        Me.MobileInvBindingSource.DataSource = Me.MobileInvDS
        '
        'MobileInvDS
        '
        Me.MobileInvDS.DataSetName = "MobileInvDS"
        Me.MobileInvDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Snow
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Brand"
        '
        'categoryCbBox
        '
        Me.categoryCbBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.categoryCbBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "Category", True))
        Me.categoryCbBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.categoryCbBox.FormattingEnabled = True
        Me.categoryCbBox.Items.AddRange(New Object() {"Mobile Phone", "Phone Case", "Charger", "Cable", "Screen Protector", "Power Bank", "Earphones", "Headphones", "Smart Watch", "Bluetooth Speaker", "Mobile Stand", "Car Accessories", "Other"})
        Me.categoryCbBox.Location = New System.Drawing.Point(311, 42)
        Me.categoryCbBox.Name = "categoryCbBox"
        Me.categoryCbBox.Size = New System.Drawing.Size(149, 25)
        Me.categoryCbBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Snow
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(241, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Category"
        '
        'actionBox
        '
        Me.actionBox.Controls.Add(Me.Save_Btn)
        Me.actionBox.Controls.Add(Me.Add_Btn)
        Me.actionBox.Controls.Add(Me.Undo_Btn)
        Me.actionBox.Controls.Add(Me.Delete_Btn)
        Me.actionBox.Controls.Add(Me.Show_Btn)
        Me.actionBox.Controls.Add(Me.Update_Btn)
        Me.actionBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.actionBox.Location = New System.Drawing.Point(782, 51)
        Me.actionBox.Name = "actionBox"
        Me.actionBox.Size = New System.Drawing.Size(546, 87)
        Me.actionBox.TabIndex = 11
        Me.actionBox.TabStop = False
        Me.actionBox.Text = "Actions"
        '
        'Save_Btn
        '
        Me.Save_Btn.BackColor = System.Drawing.Color.DarkCyan
        Me.Save_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save_Btn.FlatAppearance.BorderSize = 0
        Me.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Save_Btn.ForeColor = System.Drawing.Color.White
        Me.Save_Btn.Image = CType(resources.GetObject("Save_Btn.Image"), System.Drawing.Image)
        Me.Save_Btn.Location = New System.Drawing.Point(276, 31)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(84, 45)
        Me.Save_Btn.TabIndex = 5
        Me.Save_Btn.Text = "F4"
        Me.Save_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Save_Btn.UseVisualStyleBackColor = False
        '
        'Add_Btn
        '
        Me.Add_Btn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Add_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Btn.FlatAppearance.BorderSize = 0
        Me.Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Add_Btn.ForeColor = System.Drawing.Color.White
        Me.Add_Btn.Image = CType(resources.GetObject("Add_Btn.Image"), System.Drawing.Image)
        Me.Add_Btn.Location = New System.Drawing.Point(96, 31)
        Me.Add_Btn.Name = "Add_Btn"
        Me.Add_Btn.Size = New System.Drawing.Size(84, 45)
        Me.Add_Btn.TabIndex = 10
        Me.Add_Btn.Text = "F2"
        Me.Add_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Add_Btn.UseVisualStyleBackColor = False
        '
        'Undo_Btn
        '
        Me.Undo_Btn.BackColor = System.Drawing.Color.DimGray
        Me.Undo_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Undo_Btn.FlatAppearance.BorderSize = 0
        Me.Undo_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Undo_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Undo_Btn.ForeColor = System.Drawing.Color.White
        Me.Undo_Btn.Image = CType(resources.GetObject("Undo_Btn.Image"), System.Drawing.Image)
        Me.Undo_Btn.Location = New System.Drawing.Point(456, 31)
        Me.Undo_Btn.Name = "Undo_Btn"
        Me.Undo_Btn.Size = New System.Drawing.Size(84, 45)
        Me.Undo_Btn.TabIndex = 8
        Me.Undo_Btn.Text = "F6"
        Me.Undo_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Undo_Btn.UseVisualStyleBackColor = False
        '
        'Delete_Btn
        '
        Me.Delete_Btn.BackColor = System.Drawing.Color.Brown
        Me.Delete_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete_Btn.FlatAppearance.BorderSize = 0
        Me.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Delete_Btn.ForeColor = System.Drawing.Color.White
        Me.Delete_Btn.Image = CType(resources.GetObject("Delete_Btn.Image"), System.Drawing.Image)
        Me.Delete_Btn.Location = New System.Drawing.Point(366, 31)
        Me.Delete_Btn.Name = "Delete_Btn"
        Me.Delete_Btn.Size = New System.Drawing.Size(84, 45)
        Me.Delete_Btn.TabIndex = 7
        Me.Delete_Btn.Text = "F5"
        Me.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Delete_Btn.UseVisualStyleBackColor = False
        '
        'Show_Btn
        '
        Me.Show_Btn.BackColor = System.Drawing.Color.SkyBlue
        Me.Show_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Show_Btn.FlatAppearance.BorderSize = 0
        Me.Show_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Show_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Show_Btn.ForeColor = System.Drawing.Color.White
        Me.Show_Btn.Image = CType(resources.GetObject("Show_Btn.Image"), System.Drawing.Image)
        Me.Show_Btn.Location = New System.Drawing.Point(6, 31)
        Me.Show_Btn.Name = "Show_Btn"
        Me.Show_Btn.Size = New System.Drawing.Size(84, 45)
        Me.Show_Btn.TabIndex = 9
        Me.Show_Btn.Text = "F1"
        Me.Show_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Show_Btn.UseVisualStyleBackColor = False
        '
        'Update_Btn
        '
        Me.Update_Btn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Update_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Update_Btn.FlatAppearance.BorderSize = 0
        Me.Update_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Update_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Update_Btn.ForeColor = System.Drawing.Color.White
        Me.Update_Btn.Image = CType(resources.GetObject("Update_Btn.Image"), System.Drawing.Image)
        Me.Update_Btn.Location = New System.Drawing.Point(186, 31)
        Me.Update_Btn.Name = "Update_Btn"
        Me.Update_Btn.Size = New System.Drawing.Size(84, 45)
        Me.Update_Btn.TabIndex = 6
        Me.Update_Btn.Text = "F3"
        Me.Update_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Update_Btn.UseVisualStyleBackColor = False
        '
        'pricingBox
        '
        Me.pricingBox.Controls.Add(TaxRateLabel)
        Me.pricingBox.Controls.Add(Me.TaxRateTextBox)
        Me.pricingBox.Controls.Add(Me.reorderTxtBox)
        Me.pricingBox.Controls.Add(Me.warantyTxtBox)
        Me.pricingBox.Controls.Add(Me.saleTxtBox)
        Me.pricingBox.Controls.Add(Me.Label10)
        Me.pricingBox.Controls.Add(Me.Label11)
        Me.pricingBox.Controls.Add(Me.Label12)
        Me.pricingBox.Controls.Add(Me.purchaseTxtBox)
        Me.pricingBox.Controls.Add(Me.Label13)
        Me.pricingBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pricingBox.Location = New System.Drawing.Point(29, 192)
        Me.pricingBox.Name = "pricingBox"
        Me.pricingBox.Size = New System.Drawing.Size(555, 134)
        Me.pricingBox.TabIndex = 11
        Me.pricingBox.TabStop = False
        Me.pricingBox.Text = "Pricing  "
        Me.pricingBox.Visible = False
        '
        'TaxRateTextBox
        '
        Me.TaxRateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "TaxRate", True))
        Me.TaxRateTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TaxRateTextBox.Location = New System.Drawing.Point(481, 42)
        Me.TaxRateTextBox.Name = "TaxRateTextBox"
        Me.TaxRateTextBox.Size = New System.Drawing.Size(57, 25)
        Me.TaxRateTextBox.TabIndex = 13
        '
        'reorderTxtBox
        '
        Me.reorderTxtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reorderTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "ReorderLevel", True))
        Me.reorderTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.reorderTxtBox.Location = New System.Drawing.Point(107, 86)
        Me.reorderTxtBox.Name = "reorderTxtBox"
        Me.reorderTxtBox.Size = New System.Drawing.Size(168, 25)
        Me.reorderTxtBox.TabIndex = 12
        '
        'warantyTxtBox
        '
        Me.warantyTxtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.warantyTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "WarrantyMonths", True))
        Me.warantyTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.warantyTxtBox.FormattingEnabled = True
        Me.warantyTxtBox.Items.AddRange(New Object() {"0", "3", "6", "12", "24"})
        Me.warantyTxtBox.Location = New System.Drawing.Point(368, 86)
        Me.warantyTxtBox.Name = "warantyTxtBox"
        Me.warantyTxtBox.Size = New System.Drawing.Size(170, 25)
        Me.warantyTxtBox.TabIndex = 11
        '
        'saleTxtBox
        '
        Me.saleTxtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saleTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "SalePrice", True))
        Me.saleTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.saleTxtBox.Location = New System.Drawing.Point(294, 42)
        Me.saleTxtBox.Name = "saleTxtBox"
        Me.saleTxtBox.Size = New System.Drawing.Size(122, 25)
        Me.saleTxtBox.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Snow
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(229, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Sale Price"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Snow
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(297, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Warranty"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Snow
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(11, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Reorder Level"
        '
        'purchaseTxtBox
        '
        Me.purchaseTxtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.purchaseTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "PurchasePrice", True))
        Me.purchaseTxtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.purchaseTxtBox.Location = New System.Drawing.Point(107, 42)
        Me.purchaseTxtBox.Name = "purchaseTxtBox"
        Me.purchaseTxtBox.Size = New System.Drawing.Size(122, 25)
        Me.purchaseTxtBox.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Snow
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(11, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 17)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Purchase Price"
        '
        'MobileInvTableAdapter
        '
        Me.MobileInvTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MobileInvTableAdapter = Me.MobileInvTableAdapter
        Me.TableAdapterManager.UpdateOrder = MobileShopFrm.MobileInvDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MobileInv_DGV
        '
        Me.MobileInv_DGV.AllowUserToAddRows = False
        Me.MobileInv_DGV.AllowUserToResizeColumns = False
        Me.MobileInv_DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.MobileInv_DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MobileInv_DGV.AutoGenerateColumns = False
        Me.MobileInv_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MobileInv_DGV.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.MobileInv_DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MobileInv_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.MobileInv_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MobileInv_DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MobileInv_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MobileInv_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_product_id, Me.dgv_product, Me.dgv_model, Me.dgv_color, Me.dgv_storage, Me.dgv_unit, Me.dgv_Ram, Me.dgv_purchase_price, Me.dgv_sale_price, Me.dgv_tax_rate, Me.dgv_reorder_level, Me.dgv_warranty_months, Me.dgv_isactive})
        Me.MobileInv_DGV.DataSource = Me.MobileInvBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MobileInv_DGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.MobileInv_DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.MobileInv_DGV.EnableHeadersVisualStyles = False
        Me.MobileInv_DGV.Location = New System.Drawing.Point(17, 154)
        Me.MobileInv_DGV.Name = "MobileInv_DGV"
        Me.MobileInv_DGV.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MobileInv_DGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MobileInv_DGV.Size = New System.Drawing.Size(1311, 534)
        Me.MobileInv_DGV.TabIndex = 0
        '
        'dgv_product_id
        '
        Me.dgv_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_product_id.DataPropertyName = "ProductID"
        Me.dgv_product_id.HeaderText = "ProductID"
        Me.dgv_product_id.Name = "dgv_product_id"
        Me.dgv_product_id.ReadOnly = True
        Me.dgv_product_id.Width = 75
        '
        'dgv_product
        '
        Me.dgv_product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_product.DataPropertyName = "Product"
        Me.dgv_product.HeaderText = "Product"
        Me.dgv_product.Name = "dgv_product"
        Me.dgv_product.Width = 170
        '
        'dgv_model
        '
        Me.dgv_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_model.DataPropertyName = "Model"
        Me.dgv_model.HeaderText = "Model"
        Me.dgv_model.Name = "dgv_model"
        Me.dgv_model.Width = 140
        '
        'dgv_color
        '
        Me.dgv_color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_color.DataPropertyName = "Color"
        Me.dgv_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgv_color.HeaderText = "Color"
        Me.dgv_color.Items.AddRange(New Object() {"Black", "White", "Blue", "Green", "Red", "Gold", "Silver", "Purple", "Gray", "Natural Titanium", "Clear"})
        Me.dgv_color.Name = "dgv_color"
        Me.dgv_color.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dgv_storage
        '
        Me.dgv_storage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_storage.DataPropertyName = "Storage"
        Me.dgv_storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgv_storage.HeaderText = "Storage"
        Me.dgv_storage.Items.AddRange(New Object() {"32GB", "64GB", "128GB", "256GB", "512GB", "1TB", "N/A"})
        Me.dgv_storage.Name = "dgv_storage"
        Me.dgv_storage.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_storage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dgv_unit
        '
        Me.dgv_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_unit.DataPropertyName = "Unit"
        Me.dgv_unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgv_unit.HeaderText = "Unit"
        Me.dgv_unit.Items.AddRange(New Object() {"Piece", "Box", "Pack", "Pair"})
        Me.dgv_unit.Name = "dgv_unit"
        Me.dgv_unit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dgv_Ram
        '
        Me.dgv_Ram.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_Ram.DataPropertyName = "RAM"
        Me.dgv_Ram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgv_Ram.HeaderText = "RAM"
        Me.dgv_Ram.Items.AddRange(New Object() {"2GB", "4GB", "6GB", "8GB", "12GB", "16GB", "N/A"})
        Me.dgv_Ram.Name = "dgv_Ram"
        Me.dgv_Ram.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Ram.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgv_Ram.Width = 80
        '
        'dgv_purchase_price
        '
        Me.dgv_purchase_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_purchase_price.DataPropertyName = "PurchasePrice"
        Me.dgv_purchase_price.HeaderText = "PurchasePrice"
        Me.dgv_purchase_price.Name = "dgv_purchase_price"
        Me.dgv_purchase_price.Width = 115
        '
        'dgv_sale_price
        '
        Me.dgv_sale_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_sale_price.DataPropertyName = "SalePrice"
        Me.dgv_sale_price.HeaderText = "SalePrice"
        Me.dgv_sale_price.Name = "dgv_sale_price"
        Me.dgv_sale_price.Width = 115
        '
        'dgv_tax_rate
        '
        Me.dgv_tax_rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_tax_rate.DataPropertyName = "TaxRate"
        Me.dgv_tax_rate.HeaderText = "TaxRate"
        Me.dgv_tax_rate.Name = "dgv_tax_rate"
        Me.dgv_tax_rate.Width = 60
        '
        'dgv_reorder_level
        '
        Me.dgv_reorder_level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_reorder_level.DataPropertyName = "ReorderLevel"
        Me.dgv_reorder_level.HeaderText = "ReorderLevel"
        Me.dgv_reorder_level.Name = "dgv_reorder_level"
        Me.dgv_reorder_level.Width = 80
        '
        'dgv_warranty_months
        '
        Me.dgv_warranty_months.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_warranty_months.DataPropertyName = "WarrantyMonths"
        Me.dgv_warranty_months.HeaderText = "WarrantyMonths"
        Me.dgv_warranty_months.Name = "dgv_warranty_months"
        Me.dgv_warranty_months.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_warranty_months.Width = 110
        '
        'dgv_isactive
        '
        Me.dgv_isactive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgv_isactive.DataPropertyName = "IsActive"
        Me.dgv_isactive.HeaderText = "IsActive"
        Me.dgv_isactive.Name = "dgv_isactive"
        Me.dgv_isactive.Width = 63
        '
        'NavBox
        '
        Me.NavBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavBox.Controls.Add(Me.ToCount)
        Me.NavBox.Controls.Add(Me.Label5)
        Me.NavBox.Controls.Add(Me.FromCount)
        Me.NavBox.Controls.Add(Me.moveLastBtn)
        Me.NavBox.Controls.Add(Me.moveNextBtn)
        Me.NavBox.Controls.Add(Me.MovePrevBtn)
        Me.NavBox.Controls.Add(Me.MoveFirstBtn)
        Me.NavBox.Enabled = False
        Me.NavBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NavBox.Location = New System.Drawing.Point(519, 61)
        Me.NavBox.Name = "NavBox"
        Me.NavBox.Size = New System.Drawing.Size(238, 87)
        Me.NavBox.TabIndex = 11
        Me.NavBox.TabStop = False
        Me.NavBox.Text = "Navigator"
        '
        'ToCount
        '
        Me.ToCount.AutoSize = True
        Me.ToCount.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ToCount.ForeColor = System.Drawing.Color.Black
        Me.ToCount.Location = New System.Drawing.Point(132, 43)
        Me.ToCount.Name = "ToCount"
        Me.ToCount.Size = New System.Drawing.Size(17, 20)
        Me.ToCount.TabIndex = 6
        Me.ToCount.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(101, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "To"
        '
        'FromCount
        '
        Me.FromCount.AutoSize = True
        Me.FromCount.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FromCount.ForeColor = System.Drawing.Color.Black
        Me.FromCount.Location = New System.Drawing.Point(78, 43)
        Me.FromCount.Name = "FromCount"
        Me.FromCount.Size = New System.Drawing.Size(17, 20)
        Me.FromCount.TabIndex = 4
        Me.FromCount.Text = "0"
        '
        'moveLastBtn
        '
        Me.moveLastBtn.FlatAppearance.BorderSize = 0
        Me.moveLastBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.moveLastBtn.ForeColor = System.Drawing.Color.Snow
        Me.moveLastBtn.Image = Global.MobileShopFrm.My.Resources.Resources.last
        Me.moveLastBtn.Location = New System.Drawing.Point(175, 37)
        Me.moveLastBtn.Name = "moveLastBtn"
        Me.moveLastBtn.Size = New System.Drawing.Size(23, 31)
        Me.moveLastBtn.TabIndex = 3
        Me.moveLastBtn.UseVisualStyleBackColor = True
        '
        'moveNextBtn
        '
        Me.moveNextBtn.FlatAppearance.BorderSize = 0
        Me.moveNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.moveNextBtn.ForeColor = System.Drawing.Color.Snow
        Me.moveNextBtn.Image = Global.MobileShopFrm.My.Resources.Resources._next
        Me.moveNextBtn.Location = New System.Drawing.Point(155, 37)
        Me.moveNextBtn.Name = "moveNextBtn"
        Me.moveNextBtn.Size = New System.Drawing.Size(23, 31)
        Me.moveNextBtn.TabIndex = 2
        Me.moveNextBtn.UseVisualStyleBackColor = True
        '
        'MovePrevBtn
        '
        Me.MovePrevBtn.FlatAppearance.BorderSize = 0
        Me.MovePrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MovePrevBtn.ForeColor = System.Drawing.Color.Snow
        Me.MovePrevBtn.Image = Global.MobileShopFrm.My.Resources.Resources.prev
        Me.MovePrevBtn.Location = New System.Drawing.Point(49, 37)
        Me.MovePrevBtn.Name = "MovePrevBtn"
        Me.MovePrevBtn.Size = New System.Drawing.Size(23, 31)
        Me.MovePrevBtn.TabIndex = 1
        Me.MovePrevBtn.UseVisualStyleBackColor = True
        '
        'MoveFirstBtn
        '
        Me.MoveFirstBtn.FlatAppearance.BorderSize = 0
        Me.MoveFirstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MoveFirstBtn.ForeColor = System.Drawing.Color.Snow
        Me.MoveFirstBtn.Image = Global.MobileShopFrm.My.Resources.Resources.first
        Me.MoveFirstBtn.Location = New System.Drawing.Point(30, 37)
        Me.MoveFirstBtn.Name = "MoveFirstBtn"
        Me.MoveFirstBtn.Size = New System.Drawing.Size(23, 31)
        Me.MoveFirstBtn.TabIndex = 0
        Me.MoveFirstBtn.UseVisualStyleBackColor = True
        '
        'InventorySol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.MobileInv_DGV)
        Me.Controls.Add(Me.NavBox)
        Me.Controls.Add(Me.pricingBox)
        Me.Controls.Add(Me.actionBox)
        Me.Controls.Add(Me.productBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.KeyPreview = True
        Me.Name = "InventorySol"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobile - Inventory Solution"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.productBox.ResumeLayout(False)
        Me.productBox.PerformLayout()
        CType(Me.MobileInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileInvDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.actionBox.ResumeLayout(False)
        Me.pricingBox.ResumeLayout(False)
        Me.pricingBox.PerformLayout()
        CType(Me.MobileInv_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBox.ResumeLayout(False)
        Me.NavBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents productBox As System.Windows.Forms.GroupBox
    Friend WithEvents categoryCbBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents brandCbBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents actionBox As System.Windows.Forms.GroupBox
    Friend WithEvents pricingBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents purchaseTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents reorderTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents warantyTxtBox As System.Windows.Forms.ComboBox
    Friend WithEvents saleTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Undo_Btn As System.Windows.Forms.Button
    Friend WithEvents Delete_Btn As System.Windows.Forms.Button
    Friend WithEvents Update_Btn As System.Windows.Forms.Button
    Friend WithEvents Save_Btn As System.Windows.Forms.Button
    Friend WithEvents MobileInvDS As MobileShopFrm.MobileInvDS
    Friend WithEvents MobileInvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MobileInvTableAdapter As MobileShopFrm.MobileInvDSTableAdapters.MobileInvTableAdapter
    Friend WithEvents TableAdapterManager As MobileShopFrm.MobileInvDSTableAdapters.TableAdapterManager
    Friend WithEvents MobileInv_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Show_Btn As System.Windows.Forms.Button
    Friend WithEvents TaxRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Add_Btn As System.Windows.Forms.Button
    Friend WithEvents dgv_product_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_product As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_color As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_storage As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_unit As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_Ram As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_purchase_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_sale_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_tax_rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_reorder_level As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_warranty_months As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_isactive As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NavBox As System.Windows.Forms.GroupBox
    Friend WithEvents MoveFirstBtn As System.Windows.Forms.Button
    Friend WithEvents moveLastBtn As System.Windows.Forms.Button
    Friend WithEvents moveNextBtn As System.Windows.Forms.Button
    Friend WithEvents MovePrevBtn As System.Windows.Forms.Button
    Friend WithEvents ToCount As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FromCount As System.Windows.Forms.Label

End Class
