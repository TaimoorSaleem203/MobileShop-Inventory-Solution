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
        Dim ProductLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventorySol))
        Me.NavBox = New System.Windows.Forms.GroupBox()
        Me.ToCount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FromCount = New System.Windows.Forms.Label()
        Me.moveLastBtn = New System.Windows.Forms.Button()
        Me.moveNextBtn = New System.Windows.Forms.Button()
        Me.MovePrevBtn = New System.Windows.Forms.Button()
        Me.MoveFirstBtn = New System.Windows.Forms.Button()
        Me.MobileInv_DGV = New System.Windows.Forms.DataGridView()
        Me.dgv_productID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_color = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgv_storage = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgv_unit = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgv_Ram = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgv_purchase_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_sale_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_warranty_months = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_isactive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MobileInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MobileInvDS = New MobileShopFrm.MobileInvDS()
        Me.ProductTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.MobileInvTableAdapter = New MobileShopFrm.MobileInvDSTableAdapters.MobileInvTableAdapter()
        Me.TableAdapterManager = New MobileShopFrm.MobileInvDSTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Undo_Btn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.Update_Btn = New System.Windows.Forms.Button()
        Me.Add_Btn = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        ProductLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        Me.NavBox.SuspendLayout()
        CType(Me.MobileInv_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileInvDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductLabel
        '
        ProductLabel.AutoSize = True
        ProductLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        ProductLabel.ForeColor = System.Drawing.Color.Black
        ProductLabel.Location = New System.Drawing.Point(9, 65)
        ProductLabel.Name = "ProductLabel"
        ProductLabel.Size = New System.Drawing.Size(61, 19)
        ProductLabel.TabIndex = 0
        ProductLabel.Text = "Product:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        BrandLabel.ForeColor = System.Drawing.Color.Black
        BrandLabel.Location = New System.Drawing.Point(400, 63)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(48, 19)
        BrandLabel.TabIndex = 4
        BrandLabel.Text = "Brand:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        CategoryLabel.ForeColor = System.Drawing.Color.Black
        CategoryLabel.Location = New System.Drawing.Point(233, 65)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(69, 19)
        CategoryLabel.TabIndex = 2
        CategoryLabel.Text = "Category:"
        '
        'NavBox
        '
        Me.NavBox.Controls.Add(Me.ToCount)
        Me.NavBox.Controls.Add(Me.Label5)
        Me.NavBox.Controls.Add(Me.FromCount)
        Me.NavBox.Controls.Add(Me.moveLastBtn)
        Me.NavBox.Controls.Add(Me.moveNextBtn)
        Me.NavBox.Controls.Add(Me.MovePrevBtn)
        Me.NavBox.Controls.Add(Me.MoveFirstBtn)
        Me.NavBox.Enabled = False
        Me.NavBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NavBox.Location = New System.Drawing.Point(475, 172)
        Me.NavBox.Name = "NavBox"
        Me.NavBox.Size = New System.Drawing.Size(229, 87)
        Me.NavBox.TabIndex = 11
        Me.NavBox.TabStop = False
        Me.NavBox.Text = "Navigator"
        Me.NavBox.Visible = False
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
        'MobileInv_DGV
        '
        Me.MobileInv_DGV.AllowUserToResizeColumns = False
        Me.MobileInv_DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.MobileInv_DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MobileInv_DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MobileInv_DGV.AutoGenerateColumns = False
        Me.MobileInv_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MobileInv_DGV.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.MobileInv_DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        Me.MobileInv_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_productID, Me.dgv_product, Me.dgv_category, Me.dgv_model, Me.dgv_brand, Me.dgv_color, Me.dgv_storage, Me.dgv_unit, Me.dgv_Ram, Me.dgv_purchase_price, Me.dgv_sale_price, Me.dgv_warranty_months, Me.dgv_isactive})
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
        Me.MobileInv_DGV.Location = New System.Drawing.Point(12, 132)
        Me.MobileInv_DGV.Name = "MobileInv_DGV"
        Me.MobileInv_DGV.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MobileInv_DGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MobileInv_DGV.Size = New System.Drawing.Size(1170, 527)
        Me.MobileInv_DGV.TabIndex = 0
        '
        'dgv_productID
        '
        Me.dgv_productID.DataPropertyName = "ProductID"
        Me.dgv_productID.HeaderText = "ID"
        Me.dgv_productID.MinimumWidth = 60
        Me.dgv_productID.Name = "dgv_productID"
        Me.dgv_productID.ReadOnly = True
        '
        'dgv_product
        '
        Me.dgv_product.DataPropertyName = "Product"
        Me.dgv_product.HeaderText = "Product"
        Me.dgv_product.MinimumWidth = 160
        Me.dgv_product.Name = "dgv_product"
        '
        'dgv_category
        '
        Me.dgv_category.DataPropertyName = "Category"
        Me.dgv_category.HeaderText = "Category"
        Me.dgv_category.MinimumWidth = 100
        Me.dgv_category.Name = "dgv_category"
        '
        'dgv_model
        '
        Me.dgv_model.DataPropertyName = "Model"
        Me.dgv_model.HeaderText = "Model"
        Me.dgv_model.MinimumWidth = 100
        Me.dgv_model.Name = "dgv_model"
        '
        'dgv_brand
        '
        Me.dgv_brand.DataPropertyName = "Brand"
        Me.dgv_brand.HeaderText = "Brand"
        Me.dgv_brand.MinimumWidth = 100
        Me.dgv_brand.Name = "dgv_brand"
        '
        'dgv_color
        '
        Me.dgv_color.DataPropertyName = "Color"
        Me.dgv_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgv_color.HeaderText = "Color"
        Me.dgv_color.Items.AddRange(New Object() {"Black", "White", "Blue", "Green", "Red", "Gold", "Silver", "Purple", "Gray", "Natural Titanium", "Clear"})
        Me.dgv_color.MinimumWidth = 80
        Me.dgv_color.Name = "dgv_color"
        Me.dgv_color.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dgv_storage
        '
        Me.dgv_storage.DataPropertyName = "Storage"
        Me.dgv_storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgv_storage.HeaderText = "Storage"
        Me.dgv_storage.Items.AddRange(New Object() {"32GB", "64GB", "128GB", "256GB", "512GB", "1TB", "N/A"})
        Me.dgv_storage.MinimumWidth = 80
        Me.dgv_storage.Name = "dgv_storage"
        Me.dgv_storage.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_storage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dgv_unit
        '
        Me.dgv_unit.DataPropertyName = "Unit"
        Me.dgv_unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgv_unit.HeaderText = "Unit"
        Me.dgv_unit.Items.AddRange(New Object() {"Piece", "Box", "Pack", "Pair"})
        Me.dgv_unit.MinimumWidth = 70
        Me.dgv_unit.Name = "dgv_unit"
        Me.dgv_unit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dgv_Ram
        '
        Me.dgv_Ram.DataPropertyName = "RAM"
        Me.dgv_Ram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgv_Ram.HeaderText = "RAM"
        Me.dgv_Ram.Items.AddRange(New Object() {"2GB", "4GB", "6GB", "8GB", "12GB", "16GB", "N/A"})
        Me.dgv_Ram.MinimumWidth = 70
        Me.dgv_Ram.Name = "dgv_Ram"
        Me.dgv_Ram.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Ram.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dgv_purchase_price
        '
        Me.dgv_purchase_price.DataPropertyName = "PurchasePrice"
        Me.dgv_purchase_price.HeaderText = "PurchasePrice"
        Me.dgv_purchase_price.MinimumWidth = 100
        Me.dgv_purchase_price.Name = "dgv_purchase_price"
        '
        'dgv_sale_price
        '
        Me.dgv_sale_price.DataPropertyName = "SalePrice"
        Me.dgv_sale_price.HeaderText = "SalePrice"
        Me.dgv_sale_price.MinimumWidth = 100
        Me.dgv_sale_price.Name = "dgv_sale_price"
        '
        'dgv_warranty_months
        '
        Me.dgv_warranty_months.DataPropertyName = "WarrantyMonths"
        Me.dgv_warranty_months.HeaderText = "WarrantyMonths"
        Me.dgv_warranty_months.MinimumWidth = 100
        Me.dgv_warranty_months.Name = "dgv_warranty_months"
        Me.dgv_warranty_months.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'dgv_isactive
        '
        Me.dgv_isactive.DataPropertyName = "IsActive"
        Me.dgv_isactive.HeaderText = "Active"
        Me.dgv_isactive.MinimumWidth = 50
        Me.dgv_isactive.Name = "dgv_isactive"
        Me.dgv_isactive.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_isactive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        'ProductTextBox
        '
        Me.ProductTextBox.BackColor = System.Drawing.Color.White
        Me.ProductTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "Product", True))
        Me.ProductTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ProductTextBox.Location = New System.Drawing.Point(13, 91)
        Me.ProductTextBox.Name = "ProductTextBox"
        Me.ProductTextBox.ReadOnly = True
        Me.ProductTextBox.Size = New System.Drawing.Size(204, 25)
        Me.ProductTextBox.TabIndex = 1
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.BackColor = System.Drawing.Color.White
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "Category", True))
        Me.CategoryTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CategoryTextBox.Location = New System.Drawing.Point(237, 91)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.ReadOnly = True
        Me.CategoryTextBox.Size = New System.Drawing.Size(143, 25)
        Me.CategoryTextBox.TabIndex = 3
        '
        'BrandTextBox
        '
        Me.BrandTextBox.BackColor = System.Drawing.Color.White
        Me.BrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "Brand", True))
        Me.BrandTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BrandTextBox.Location = New System.Drawing.Point(404, 91)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.ReadOnly = True
        Me.BrandTextBox.Size = New System.Drawing.Size(143, 25)
        Me.BrandTextBox.TabIndex = 5
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRODUCT MASTER"
        '
        'Undo_Btn
        '
        Me.Undo_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Undo_Btn.BackColor = System.Drawing.Color.DimGray
        Me.Undo_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Undo_Btn.FlatAppearance.BorderSize = 0
        Me.Undo_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Undo_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Undo_Btn.ForeColor = System.Drawing.Color.White
        Me.Undo_Btn.Image = CType(resources.GetObject("Undo_Btn.Image"), System.Drawing.Image)
        Me.Undo_Btn.Location = New System.Drawing.Point(1012, 0)
        Me.Undo_Btn.Name = "Undo_Btn"
        Me.Undo_Btn.Size = New System.Drawing.Size(84, 48)
        Me.Undo_Btn.TabIndex = 8
        Me.Undo_Btn.Text = "F6"
        Me.Undo_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Undo_Btn.UseVisualStyleBackColor = False
        '
        'Delete_Btn
        '
        Me.Delete_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Delete_Btn.BackColor = System.Drawing.Color.Brown
        Me.Delete_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete_Btn.FlatAppearance.BorderSize = 0
        Me.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Delete_Btn.ForeColor = System.Drawing.Color.White
        Me.Delete_Btn.Image = CType(resources.GetObject("Delete_Btn.Image"), System.Drawing.Image)
        Me.Delete_Btn.Location = New System.Drawing.Point(928, 0)
        Me.Delete_Btn.Name = "Delete_Btn"
        Me.Delete_Btn.Size = New System.Drawing.Size(84, 48)
        Me.Delete_Btn.TabIndex = 7
        Me.Delete_Btn.Text = "F5"
        Me.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Delete_Btn.UseVisualStyleBackColor = False
        '
        'Save_Btn
        '
        Me.Save_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Save_Btn.BackColor = System.Drawing.Color.DarkCyan
        Me.Save_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save_Btn.FlatAppearance.BorderSize = 0
        Me.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Save_Btn.ForeColor = System.Drawing.Color.White
        Me.Save_Btn.Image = CType(resources.GetObject("Save_Btn.Image"), System.Drawing.Image)
        Me.Save_Btn.Location = New System.Drawing.Point(844, 0)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(84, 48)
        Me.Save_Btn.TabIndex = 5
        Me.Save_Btn.Text = "F4"
        Me.Save_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Save_Btn.UseVisualStyleBackColor = False
        '
        'Update_Btn
        '
        Me.Update_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Update_Btn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Update_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Update_Btn.FlatAppearance.BorderSize = 0
        Me.Update_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Update_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Update_Btn.ForeColor = System.Drawing.Color.White
        Me.Update_Btn.Image = CType(resources.GetObject("Update_Btn.Image"), System.Drawing.Image)
        Me.Update_Btn.Location = New System.Drawing.Point(760, 0)
        Me.Update_Btn.Name = "Update_Btn"
        Me.Update_Btn.Size = New System.Drawing.Size(84, 48)
        Me.Update_Btn.TabIndex = 6
        Me.Update_Btn.Text = "F3"
        Me.Update_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Update_Btn.UseVisualStyleBackColor = False
        '
        'Add_Btn
        '
        Me.Add_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Add_Btn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Add_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Btn.FlatAppearance.BorderSize = 0
        Me.Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Add_Btn.ForeColor = System.Drawing.Color.White
        Me.Add_Btn.Image = CType(resources.GetObject("Add_Btn.Image"), System.Drawing.Image)
        Me.Add_Btn.Location = New System.Drawing.Point(675, 0)
        Me.Add_Btn.Name = "Add_Btn"
        Me.Add_Btn.Size = New System.Drawing.Size(84, 48)
        Me.Add_Btn.TabIndex = 10
        Me.Add_Btn.Text = "F2"
        Me.Add_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Add_Btn.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1194, 671)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.MenuHighlight
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(0, -2)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1373, 50)
        '
        'InventorySol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1194, 671)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(ProductLabel)
        Me.Controls.Add(Me.ProductTextBox)
        Me.Controls.Add(Me.Undo_Btn)
        Me.Controls.Add(Me.Delete_Btn)
        Me.Controls.Add(Me.Save_Btn)
        Me.Controls.Add(Me.Update_Btn)
        Me.Controls.Add(Me.Add_Btn)
        Me.Controls.Add(Me.MobileInv_DGV)
        Me.Controls.Add(Me.NavBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(1366, 750)
        Me.MinimumSize = New System.Drawing.Size(1200, 700)
        Me.Name = "InventorySol"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobile - Product List"
        Me.NavBox.ResumeLayout(False)
        Me.NavBox.PerformLayout()
        CType(Me.MobileInv_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileInvDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MobileInvDS As MobileShopFrm.MobileInvDS
    Friend WithEvents MobileInvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MobileInvTableAdapter As MobileShopFrm.MobileInvDSTableAdapters.MobileInvTableAdapter
    Friend WithEvents TableAdapterManager As MobileShopFrm.MobileInvDSTableAdapters.TableAdapterManager
    Friend WithEvents NavBox As System.Windows.Forms.GroupBox
    Friend WithEvents MoveFirstBtn As System.Windows.Forms.Button
    Friend WithEvents moveLastBtn As System.Windows.Forms.Button
    Friend WithEvents moveNextBtn As System.Windows.Forms.Button
    Friend WithEvents MovePrevBtn As System.Windows.Forms.Button
    Friend WithEvents ToCount As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FromCount As System.Windows.Forms.Label
    Friend WithEvents MobileInv_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents ProductTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dgv_productID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_product As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_color As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_storage As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_unit As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_Ram As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_purchase_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_sale_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_warranty_months As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_isactive As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Undo_Btn As System.Windows.Forms.Button
    Friend WithEvents Delete_Btn As System.Windows.Forms.Button
    Friend WithEvents Save_Btn As System.Windows.Forms.Button
    Friend WithEvents Update_Btn As System.Windows.Forms.Button
    Friend WithEvents Add_Btn As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape

End Class
