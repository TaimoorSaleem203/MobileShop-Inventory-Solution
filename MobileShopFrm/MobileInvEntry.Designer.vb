<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvEntry
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
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim StorageLabel As System.Windows.Forms.Label
        Dim UnitLabel As System.Windows.Forms.Label
        Dim RAMLabel As System.Windows.Forms.Label
        Dim PurchasePriceLabel As System.Windows.Forms.Label
        Dim SalePriceLabel As System.Windows.Forms.Label
        Dim WarrantyMonthsLabel As System.Windows.Forms.Label
        Dim IsActiveLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvEntry))
        Me.MobileInvDS = New MobileShopFrm.MobileInvDS()
        Me.MobileInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MobileInvTableAdapter = New MobileShopFrm.MobileInvDSTableAdapters.MobileInvTableAdapter()
        Me.TableAdapterManager = New MobileShopFrm.MobileInvDSTableAdapters.TableAdapterManager()
        Me.MobileInvBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.newItemBtn = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.deleteItemBtn = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.saveItemBtn = New System.Windows.Forms.ToolStripButton()
        Me.ProductTextBox = New System.Windows.Forms.TextBox()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.ColorComboBox = New System.Windows.Forms.ComboBox()
        Me.StorageComboBox = New System.Windows.Forms.ComboBox()
        Me.UnitComboBox = New System.Windows.Forms.ComboBox()
        Me.RAMComboBox = New System.Windows.Forms.ComboBox()
        Me.PurchasePriceTextBox = New System.Windows.Forms.TextBox()
        Me.SalePriceTextBox = New System.Windows.Forms.TextBox()
        Me.WarrantyMonthsTextBox = New System.Windows.Forms.TextBox()
        Me.IsActiveCheckBox = New System.Windows.Forms.CheckBox()
        ProductLabel = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        StorageLabel = New System.Windows.Forms.Label()
        UnitLabel = New System.Windows.Forms.Label()
        RAMLabel = New System.Windows.Forms.Label()
        PurchasePriceLabel = New System.Windows.Forms.Label()
        SalePriceLabel = New System.Windows.Forms.Label()
        WarrantyMonthsLabel = New System.Windows.Forms.Label()
        IsActiveLabel = New System.Windows.Forms.Label()
        CType(Me.MobileInvDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileInvBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MobileInvBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductLabel
        '
        ProductLabel.AutoSize = True
        ProductLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        ProductLabel.ForeColor = System.Drawing.Color.Black
        ProductLabel.Location = New System.Drawing.Point(18, 110)
        ProductLabel.Name = "ProductLabel"
        ProductLabel.Size = New System.Drawing.Size(59, 17)
        ProductLabel.TabIndex = 1
        ProductLabel.Text = "Product:"
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductIDLabel.ForeColor = System.Drawing.Color.Black
        ProductIDLabel.Location = New System.Drawing.Point(18, 75)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(76, 17)
        ProductIDLabel.TabIndex = 3
        ProductIDLabel.Text = "Product ID:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        CategoryLabel.ForeColor = System.Drawing.Color.Black
        CategoryLabel.Location = New System.Drawing.Point(312, 113)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(67, 17)
        CategoryLabel.TabIndex = 5
        CategoryLabel.Text = "Category:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        BrandLabel.ForeColor = System.Drawing.Color.Black
        BrandLabel.Location = New System.Drawing.Point(18, 147)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(47, 17)
        BrandLabel.TabIndex = 7
        BrandLabel.Text = "Brand:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        ModelLabel.ForeColor = System.Drawing.Color.Black
        ModelLabel.Location = New System.Drawing.Point(312, 151)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(49, 17)
        ModelLabel.TabIndex = 9
        ModelLabel.Text = "Model:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        ColorLabel.ForeColor = System.Drawing.Color.Black
        ColorLabel.Location = New System.Drawing.Point(18, 182)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(44, 17)
        ColorLabel.TabIndex = 11
        ColorLabel.Text = "Color:"
        '
        'StorageLabel
        '
        StorageLabel.AutoSize = True
        StorageLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        StorageLabel.ForeColor = System.Drawing.Color.Black
        StorageLabel.Location = New System.Drawing.Point(216, 185)
        StorageLabel.Name = "StorageLabel"
        StorageLabel.Size = New System.Drawing.Size(58, 17)
        StorageLabel.TabIndex = 13
        StorageLabel.Text = "Storage:"
        '
        'UnitLabel
        '
        UnitLabel.AutoSize = True
        UnitLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        UnitLabel.ForeColor = System.Drawing.Color.Black
        UnitLabel.Location = New System.Drawing.Point(427, 185)
        UnitLabel.Name = "UnitLabel"
        UnitLabel.Size = New System.Drawing.Size(36, 17)
        UnitLabel.TabIndex = 15
        UnitLabel.Text = "Unit:"
        '
        'RAMLabel
        '
        RAMLabel.AutoSize = True
        RAMLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        RAMLabel.ForeColor = System.Drawing.Color.Black
        RAMLabel.Location = New System.Drawing.Point(18, 221)
        RAMLabel.Name = "RAMLabel"
        RAMLabel.Size = New System.Drawing.Size(40, 17)
        RAMLabel.TabIndex = 17
        RAMLabel.Text = "RAM:"
        '
        'PurchasePriceLabel
        '
        PurchasePriceLabel.AutoSize = True
        PurchasePriceLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        PurchasePriceLabel.ForeColor = System.Drawing.Color.Black
        PurchasePriceLabel.Location = New System.Drawing.Point(18, 261)
        PurchasePriceLabel.Name = "PurchasePriceLabel"
        PurchasePriceLabel.Size = New System.Drawing.Size(99, 17)
        PurchasePriceLabel.TabIndex = 19
        PurchasePriceLabel.Text = "Purchase Price:"
        '
        'SalePriceLabel
        '
        SalePriceLabel.AutoSize = True
        SalePriceLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        SalePriceLabel.ForeColor = System.Drawing.Color.Black
        SalePriceLabel.Location = New System.Drawing.Point(314, 261)
        SalePriceLabel.Name = "SalePriceLabel"
        SalePriceLabel.Size = New System.Drawing.Size(68, 17)
        SalePriceLabel.TabIndex = 21
        SalePriceLabel.Text = "Sale Price:"
        '
        'WarrantyMonthsLabel
        '
        WarrantyMonthsLabel.AutoSize = True
        WarrantyMonthsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        WarrantyMonthsLabel.ForeColor = System.Drawing.Color.Black
        WarrantyMonthsLabel.Location = New System.Drawing.Point(216, 221)
        WarrantyMonthsLabel.Name = "WarrantyMonthsLabel"
        WarrantyMonthsLabel.Size = New System.Drawing.Size(118, 17)
        WarrantyMonthsLabel.TabIndex = 27
        WarrantyMonthsLabel.Text = "Warranty Months:"
        '
        'IsActiveLabel
        '
        IsActiveLabel.AutoSize = True
        IsActiveLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        IsActiveLabel.ForeColor = System.Drawing.Color.Black
        IsActiveLabel.Location = New System.Drawing.Point(252, 76)
        IsActiveLabel.Name = "IsActiveLabel"
        IsActiveLabel.Size = New System.Drawing.Size(45, 17)
        IsActiveLabel.TabIndex = 29
        IsActiveLabel.Text = "Active"
        '
        'MobileInvDS
        '
        Me.MobileInvDS.DataSetName = "MobileInvDS"
        Me.MobileInvDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MobileInvBindingSource
        '
        Me.MobileInvBindingSource.DataMember = "MobileInv"
        Me.MobileInvBindingSource.DataSource = Me.MobileInvDS
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
        'MobileInvBindingNavigator
        '
        Me.MobileInvBindingNavigator.AddNewItem = Me.newItemBtn
        Me.MobileInvBindingNavigator.AutoSize = False
        Me.MobileInvBindingNavigator.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MobileInvBindingNavigator.BindingSource = Me.MobileInvBindingSource
        Me.MobileInvBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MobileInvBindingNavigator.DeleteItem = Me.deleteItemBtn
        Me.MobileInvBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MobileInvBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.ToolStripSeparator1, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.ToolStripSeparator2, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.newItemBtn, Me.ToolStripSeparator3, Me.deleteItemBtn, Me.ToolStripSeparator4, Me.saveItemBtn})
        Me.MobileInvBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MobileInvBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MobileInvBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MobileInvBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MobileInvBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MobileInvBindingNavigator.Name = "MobileInvBindingNavigator"
        Me.MobileInvBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MobileInvBindingNavigator.Size = New System.Drawing.Size(619, 40)
        Me.MobileInvBindingNavigator.TabIndex = 0
        Me.MobileInvBindingNavigator.Text = "BindingNavigator1"
        '
        'newItemBtn
        '
        Me.newItemBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newItemBtn.ForeColor = System.Drawing.Color.Snow
        Me.newItemBtn.Image = CType(resources.GetObject("newItemBtn.Image"), System.Drawing.Image)
        Me.newItemBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.newItemBtn.Name = "newItemBtn"
        Me.newItemBtn.RightToLeftAutoMirrorImage = True
        Me.newItemBtn.Size = New System.Drawing.Size(59, 37)
        Me.newItemBtn.Text = "New"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.ForeColor = System.Drawing.Color.Snow
        Me.BindingNavigatorCountItem.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 37)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'deleteItemBtn
        '
        Me.deleteItemBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteItemBtn.ForeColor = System.Drawing.Color.Snow
        Me.deleteItemBtn.Image = CType(resources.GetObject("deleteItemBtn.Image"), System.Drawing.Image)
        Me.deleteItemBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.deleteItemBtn.Name = "deleteItemBtn"
        Me.deleteItemBtn.RightToLeftAutoMirrorImage = True
        Me.deleteItemBtn.Size = New System.Drawing.Size(69, 37)
        Me.deleteItemBtn.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BindingNavigatorMoveFirstItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorMoveFirstItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(31, 37)
        Me.BindingNavigatorMoveFirstItem.Text = "Top"
        Me.BindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Snow
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BindingNavigatorMovePreviousItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorMovePreviousItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(36, 37)
        Me.BindingNavigatorMovePreviousItem.Text = "Back"
        Me.BindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BindingNavigatorPositionItem.ForeColor = System.Drawing.Color.Black
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BindingNavigatorMoveNextItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorMoveNextItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(36, 37)
        Me.BindingNavigatorMoveNextItem.Text = "Next"
        Me.BindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.Snow
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BindingNavigatorMoveLastItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorMoveLastItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(32, 37)
        Me.BindingNavigatorMoveLastItem.Text = "Last"
        Me.BindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.ForeColor = System.Drawing.Color.Snow
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.Snow
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.ForeColor = System.Drawing.Color.Snow
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 40)
        '
        'saveItemBtn
        '
        Me.saveItemBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveItemBtn.ForeColor = System.Drawing.Color.Snow
        Me.saveItemBtn.Image = CType(resources.GetObject("saveItemBtn.Image"), System.Drawing.Image)
        Me.saveItemBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.saveItemBtn.Name = "saveItemBtn"
        Me.saveItemBtn.Size = New System.Drawing.Size(60, 37)
        Me.saveItemBtn.Text = "Save"
        '
        'ProductTextBox
        '
        Me.ProductTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "Product", True))
        Me.ProductTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ProductTextBox.Location = New System.Drawing.Point(101, 109)
        Me.ProductTextBox.Name = "ProductTextBox"
        Me.ProductTextBox.Size = New System.Drawing.Size(199, 25)
        Me.ProductTextBox.TabIndex = 2
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.BackColor = System.Drawing.Color.White
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "ProductID", True))
        Me.ProductIDTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ProductIDTextBox.Location = New System.Drawing.Point(101, 74)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.ReadOnly = True
        Me.ProductIDTextBox.Size = New System.Drawing.Size(121, 25)
        Me.ProductIDTextBox.TabIndex = 4
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "Category", True))
        Me.CategoryTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CategoryTextBox.Location = New System.Drawing.Point(385, 109)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(199, 25)
        Me.CategoryTextBox.TabIndex = 6
        '
        'BrandTextBox
        '
        Me.BrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "Brand", True))
        Me.BrandTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BrandTextBox.Location = New System.Drawing.Point(101, 146)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(199, 25)
        Me.BrandTextBox.TabIndex = 8
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "Model", True))
        Me.ModelTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ModelTextBox.Location = New System.Drawing.Point(385, 146)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(199, 25)
        Me.ModelTextBox.TabIndex = 10
        '
        'ColorComboBox
        '
        Me.ColorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "Color", True))
        Me.ColorComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ColorComboBox.FormattingEnabled = True
        Me.ColorComboBox.Items.AddRange(New Object() {"Black", "White", "Blue", "Green", "Red", "Gold", "Silver", "Purple", "Gray", "Natural Titanium", "Clear"})
        Me.ColorComboBox.Location = New System.Drawing.Point(101, 182)
        Me.ColorComboBox.Name = "ColorComboBox"
        Me.ColorComboBox.Size = New System.Drawing.Size(101, 25)
        Me.ColorComboBox.TabIndex = 12
        '
        'StorageComboBox
        '
        Me.StorageComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "Storage", True))
        Me.StorageComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.StorageComboBox.FormattingEnabled = True
        Me.StorageComboBox.Items.AddRange(New Object() {"32GB", "64GB", "128GB", "256GB", "512GB", "1TB", "N/A"})
        Me.StorageComboBox.Location = New System.Drawing.Point(292, 182)
        Me.StorageComboBox.Name = "StorageComboBox"
        Me.StorageComboBox.Size = New System.Drawing.Size(121, 25)
        Me.StorageComboBox.TabIndex = 14
        '
        'UnitComboBox
        '
        Me.UnitComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "Unit", True))
        Me.UnitComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.UnitComboBox.FormattingEnabled = True
        Me.UnitComboBox.Items.AddRange(New Object() {"Piece", "Box", "Pack", "Pair"})
        Me.UnitComboBox.Location = New System.Drawing.Point(477, 180)
        Me.UnitComboBox.Name = "UnitComboBox"
        Me.UnitComboBox.Size = New System.Drawing.Size(107, 25)
        Me.UnitComboBox.TabIndex = 16
        '
        'RAMComboBox
        '
        Me.RAMComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "RAM", True))
        Me.RAMComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RAMComboBox.FormattingEnabled = True
        Me.RAMComboBox.Items.AddRange(New Object() {"2GB", "4GB", "6GB", "8GB", "12GB", "16GB", "N/A"})
        Me.RAMComboBox.Location = New System.Drawing.Point(101, 221)
        Me.RAMComboBox.Name = "RAMComboBox"
        Me.RAMComboBox.Size = New System.Drawing.Size(101, 25)
        Me.RAMComboBox.TabIndex = 18
        '
        'PurchasePriceTextBox
        '
        Me.PurchasePriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "PurchasePrice", True))
        Me.PurchasePriceTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.PurchasePriceTextBox.Location = New System.Drawing.Point(123, 258)
        Me.PurchasePriceTextBox.Name = "PurchasePriceTextBox"
        Me.PurchasePriceTextBox.Size = New System.Drawing.Size(177, 25)
        Me.PurchasePriceTextBox.TabIndex = 20
        '
        'SalePriceTextBox
        '
        Me.SalePriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "SalePrice", True))
        Me.SalePriceTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SalePriceTextBox.Location = New System.Drawing.Point(385, 258)
        Me.SalePriceTextBox.Name = "SalePriceTextBox"
        Me.SalePriceTextBox.Size = New System.Drawing.Size(199, 25)
        Me.SalePriceTextBox.TabIndex = 22
        '
        'WarrantyMonthsTextBox
        '
        Me.WarrantyMonthsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileInvBindingSource, "WarrantyMonths", True))
        Me.WarrantyMonthsTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.WarrantyMonthsTextBox.Location = New System.Drawing.Point(340, 218)
        Me.WarrantyMonthsTextBox.Name = "WarrantyMonthsTextBox"
        Me.WarrantyMonthsTextBox.Size = New System.Drawing.Size(101, 25)
        Me.WarrantyMonthsTextBox.TabIndex = 28
        '
        'IsActiveCheckBox
        '
        Me.IsActiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MobileInvBindingSource, "IsActive", True))
        Me.IsActiveCheckBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.IsActiveCheckBox.Location = New System.Drawing.Point(235, 73)
        Me.IsActiveCheckBox.Name = "IsActiveCheckBox"
        Me.IsActiveCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.IsActiveCheckBox.TabIndex = 30
        Me.IsActiveCheckBox.UseVisualStyleBackColor = True
        '
        'InvEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(619, 342)
        Me.Controls.Add(ProductLabel)
        Me.Controls.Add(Me.ProductTextBox)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorComboBox)
        Me.Controls.Add(StorageLabel)
        Me.Controls.Add(Me.StorageComboBox)
        Me.Controls.Add(UnitLabel)
        Me.Controls.Add(Me.UnitComboBox)
        Me.Controls.Add(RAMLabel)
        Me.Controls.Add(Me.RAMComboBox)
        Me.Controls.Add(PurchasePriceLabel)
        Me.Controls.Add(Me.PurchasePriceTextBox)
        Me.Controls.Add(SalePriceLabel)
        Me.Controls.Add(Me.SalePriceTextBox)
        Me.Controls.Add(WarrantyMonthsLabel)
        Me.Controls.Add(Me.WarrantyMonthsTextBox)
        Me.Controls.Add(IsActiveLabel)
        Me.Controls.Add(Me.IsActiveCheckBox)
        Me.Controls.Add(Me.MobileInvBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InvEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobile - Product Entry"
        CType(Me.MobileInvDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileInvBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MobileInvBindingNavigator.ResumeLayout(False)
        Me.MobileInvBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MobileInvDS As MobileShopFrm.MobileInvDS
    Friend WithEvents MobileInvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MobileInvTableAdapter As MobileShopFrm.MobileInvDSTableAdapters.MobileInvTableAdapter
    Friend WithEvents TableAdapterManager As MobileShopFrm.MobileInvDSTableAdapters.TableAdapterManager
    Friend WithEvents MobileInvBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents newItemBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents deleteItemBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents saveItemBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StorageComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UnitComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RAMComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PurchasePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WarrantyMonthsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
