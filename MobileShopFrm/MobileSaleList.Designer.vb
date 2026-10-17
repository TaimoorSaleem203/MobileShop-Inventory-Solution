<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleList
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
        Dim EntryNoLabel As System.Windows.Forms.Label
        Dim BillNoLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim PartyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaleList))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EntryNoTextBox = New System.Windows.Forms.TextBox()
        Me.MobileSaleItemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MobileSaleDS = New MobileShopFrm.MobileSaleDS()
        Me.BillNoTextBox = New System.Windows.Forms.TextBox()
        Me.MobileSaleListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.InfoBox = New System.Windows.Forms.GroupBox()
        Me.PartyComboBox = New System.Windows.Forms.ComboBox()
        Me.Undo_Btn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.Update_Btn = New System.Windows.Forms.Button()
        Me.Add_Btn = New System.Windows.Forms.Button()
        Me.MobileSaleList_DGV = New System.Windows.Forms.DataGridView()
        Me.idno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_item_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_entry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_item_name = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgv_qty_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_price_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_amt_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.search_Btn = New System.Windows.Forms.Button()
        Me.MobileSaleItemTableAdapter = New MobileShopFrm.MobileSaleDSTableAdapters.MobileSaleItemTableAdapter()
        Me.MobileSaleListTableAdapter = New MobileShopFrm.MobileSaleDSTableAdapters.MobileSaleListTableAdapter()
        Me.totalAmtBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        EntryNoLabel = New System.Windows.Forms.Label()
        BillNoLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        PartyLabel = New System.Windows.Forms.Label()
        CType(Me.MobileSaleItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileSaleDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileSaleListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoBox.SuspendLayout()
        CType(Me.MobileSaleList_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EntryNoLabel
        '
        EntryNoLabel.AutoSize = True
        EntryNoLabel.ForeColor = System.Drawing.Color.DimGray
        EntryNoLabel.Location = New System.Drawing.Point(8, 30)
        EntryNoLabel.Name = "EntryNoLabel"
        EntryNoLabel.Size = New System.Drawing.Size(66, 17)
        EntryNoLabel.TabIndex = 0
        EntryNoLabel.Text = "Entry No:"
        '
        'BillNoLabel
        '
        BillNoLabel.AutoSize = True
        BillNoLabel.ForeColor = System.Drawing.Color.DimGray
        BillNoLabel.Location = New System.Drawing.Point(126, 30)
        BillNoLabel.Name = "BillNoLabel"
        BillNoLabel.Size = New System.Drawing.Size(50, 17)
        BillNoLabel.TabIndex = 2
        BillNoLabel.Text = "Bill No:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.ForeColor = System.Drawing.Color.DimGray
        DateLabel.Location = New System.Drawing.Point(460, 31)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(39, 17)
        DateLabel.TabIndex = 4
        DateLabel.Text = "Date:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.ForeColor = System.Drawing.Color.DimGray
        RemarksLabel.Location = New System.Drawing.Point(703, 30)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(63, 17)
        RemarksLabel.TabIndex = 6
        RemarksLabel.Text = "Remarks:"
        '
        'PartyLabel
        '
        PartyLabel.AutoSize = True
        PartyLabel.ForeColor = System.Drawing.Color.DimGray
        PartyLabel.Location = New System.Drawing.Point(244, 30)
        PartyLabel.Name = "PartyLabel"
        PartyLabel.Size = New System.Drawing.Size(43, 17)
        PartyLabel.TabIndex = 8
        PartyLabel.Text = "Party:"
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.MenuHighlight
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1373, 44)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(994, 609)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SALE MASTER"
        '
        'EntryNoTextBox
        '
        Me.EntryNoTextBox.BackColor = System.Drawing.Color.White
        Me.EntryNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileSaleItemBindingSource1, "EntryNo", True))
        Me.EntryNoTextBox.Location = New System.Drawing.Point(11, 50)
        Me.EntryNoTextBox.Name = "EntryNoTextBox"
        Me.EntryNoTextBox.ReadOnly = True
        Me.EntryNoTextBox.Size = New System.Drawing.Size(96, 25)
        Me.EntryNoTextBox.TabIndex = 1
        '
        'MobileSaleItemBindingSource1
        '
        Me.MobileSaleItemBindingSource1.DataMember = "MobileSaleItem"
        Me.MobileSaleItemBindingSource1.DataSource = Me.MobileSaleDS
        '
        'MobileSaleDS
        '
        Me.MobileSaleDS.DataSetName = "MobileSaleDS"
        Me.MobileSaleDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillNoTextBox
        '
        Me.BillNoTextBox.BackColor = System.Drawing.Color.White
        Me.BillNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileSaleListBindingSource, "BillNo", True))
        Me.BillNoTextBox.Location = New System.Drawing.Point(129, 50)
        Me.BillNoTextBox.Name = "BillNoTextBox"
        Me.BillNoTextBox.Size = New System.Drawing.Size(96, 25)
        Me.BillNoTextBox.TabIndex = 3
        '
        'MobileSaleListBindingSource
        '
        Me.MobileSaleListBindingSource.DataMember = "MobileSaleList"
        Me.MobileSaleListBindingSource.DataSource = Me.MobileSaleDS
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileSaleListBindingSource, "Date", True))
        Me.DateTimePicker.Location = New System.Drawing.Point(463, 50)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(224, 25)
        Me.DateTimePicker.TabIndex = 5
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.BackColor = System.Drawing.Color.White
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileSaleListBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(706, 50)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(215, 25)
        Me.RemarksTextBox.TabIndex = 7
        '
        'InfoBox
        '
        Me.InfoBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoBox.Controls.Add(PartyLabel)
        Me.InfoBox.Controls.Add(Me.PartyComboBox)
        Me.InfoBox.Controls.Add(Me.RemarksTextBox)
        Me.InfoBox.Controls.Add(EntryNoLabel)
        Me.InfoBox.Controls.Add(Me.EntryNoTextBox)
        Me.InfoBox.Controls.Add(BillNoLabel)
        Me.InfoBox.Controls.Add(Me.BillNoTextBox)
        Me.InfoBox.Controls.Add(DateLabel)
        Me.InfoBox.Controls.Add(Me.DateTimePicker)
        Me.InfoBox.Controls.Add(RemarksLabel)
        Me.InfoBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoBox.Location = New System.Drawing.Point(29, 51)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Size = New System.Drawing.Size(931, 92)
        Me.InfoBox.TabIndex = 8
        Me.InfoBox.TabStop = False
        Me.InfoBox.Text = "Sale Info"
        '
        'PartyComboBox
        '
        Me.PartyComboBox.BackColor = System.Drawing.Color.White
        Me.PartyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileSaleListBindingSource, "Party", True))
        Me.PartyComboBox.DisplayMember = "Party"
        Me.PartyComboBox.FormattingEnabled = True
        Me.PartyComboBox.Location = New System.Drawing.Point(247, 50)
        Me.PartyComboBox.Name = "PartyComboBox"
        Me.PartyComboBox.Size = New System.Drawing.Size(193, 25)
        Me.PartyComboBox.TabIndex = 9
        Me.PartyComboBox.ValueMember = "Party"
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
        Me.Undo_Btn.Location = New System.Drawing.Point(792, 0)
        Me.Undo_Btn.Name = "Undo_Btn"
        Me.Undo_Btn.Size = New System.Drawing.Size(84, 43)
        Me.Undo_Btn.TabIndex = 14
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
        Me.Delete_Btn.Location = New System.Drawing.Point(711, 0)
        Me.Delete_Btn.Name = "Delete_Btn"
        Me.Delete_Btn.Size = New System.Drawing.Size(84, 43)
        Me.Delete_Btn.TabIndex = 13
        Me.Delete_Btn.Text = "F5"
        Me.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Delete_Btn.UseVisualStyleBackColor = False
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
        Me.Save_Btn.Location = New System.Drawing.Point(634, 0)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(84, 43)
        Me.Save_Btn.TabIndex = 11
        Me.Save_Btn.Text = "F4"
        Me.Save_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Save_Btn.UseVisualStyleBackColor = False
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
        Me.Update_Btn.Location = New System.Drawing.Point(553, 0)
        Me.Update_Btn.Name = "Update_Btn"
        Me.Update_Btn.Size = New System.Drawing.Size(84, 43)
        Me.Update_Btn.TabIndex = 12
        Me.Update_Btn.Text = "F3"
        Me.Update_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Update_Btn.UseVisualStyleBackColor = False
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
        Me.Add_Btn.Location = New System.Drawing.Point(468, -1)
        Me.Add_Btn.Name = "Add_Btn"
        Me.Add_Btn.Size = New System.Drawing.Size(84, 43)
        Me.Add_Btn.TabIndex = 15
        Me.Add_Btn.Text = "F2"
        Me.Add_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Add_Btn.UseVisualStyleBackColor = False
        '
        'MobileSaleList_DGV
        '
        Me.MobileSaleList_DGV.AllowUserToResizeColumns = False
        Me.MobileSaleList_DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        Me.MobileSaleList_DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.MobileSaleList_DGV.AutoGenerateColumns = False
        Me.MobileSaleList_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MobileSaleList_DGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.MobileSaleList_DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MobileSaleList_DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.MobileSaleList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MobileSaleList_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idno, Me.dgv_item_id, Me.dgv_entry, Me.dgv_item_name, Me.dgv_qty_rate, Me.dgv_price_rate, Me.dgv_amt_rate})
        Me.MobileSaleList_DGV.DataSource = Me.MobileSaleItemBindingSource1
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MobileSaleList_DGV.DefaultCellStyle = DataGridViewCellStyle15
        Me.MobileSaleList_DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.MobileSaleList_DGV.EnableHeadersVisualStyles = False
        Me.MobileSaleList_DGV.GridColor = System.Drawing.Color.Silver
        Me.MobileSaleList_DGV.Location = New System.Drawing.Point(29, 149)
        Me.MobileSaleList_DGV.Name = "MobileSaleList_DGV"
        Me.MobileSaleList_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.MobileSaleList_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MobileSaleList_DGV.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.MobileSaleList_DGV.Size = New System.Drawing.Size(931, 397)
        Me.MobileSaleList_DGV.TabIndex = 16
        '
        'idno
        '
        Me.idno.DataPropertyName = "idno"
        Me.idno.HeaderText = "ID"
        Me.idno.Name = "idno"
        Me.idno.ReadOnly = True
        Me.idno.Visible = False
        '
        'dgv_item_id
        '
        Me.dgv_item_id.DataPropertyName = "ItemID"
        Me.dgv_item_id.FillWeight = 12.69035!
        Me.dgv_item_id.HeaderText = "ItemID"
        Me.dgv_item_id.MinimumWidth = 80
        Me.dgv_item_id.Name = "dgv_item_id"
        Me.dgv_item_id.ReadOnly = True
        '
        'dgv_entry
        '
        Me.dgv_entry.DataPropertyName = "EntryNo"
        Me.dgv_entry.HeaderText = "EntryNo"
        Me.dgv_entry.Name = "dgv_entry"
        Me.dgv_entry.ReadOnly = True
        Me.dgv_entry.Visible = False
        '
        'dgv_item_name
        '
        Me.dgv_item_name.DataPropertyName = "Item"
        Me.dgv_item_name.FillWeight = 449.2386!
        Me.dgv_item_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dgv_item_name.HeaderText = "Item"
        Me.dgv_item_name.Items.AddRange(New Object() {"iPhone 15 128GB", "iPhone 15 Pro 256GB", "iPhone 16 128GB", "Samsung Galaxy S24 256GB", "Samsung Galaxy A55 256GB", "Samsung Galaxy A15 128GB", "Xiaomi Redmi Note 14 256GB", "Xiaomi Redmi 13 128GB", "Oppo Reno 12 256GB", "Vivo V40 256GB", "OnePlus 12 256GB", "Realme 13 Pro 256GB", "Apple 20W USB-C Charger", "Samsung 25W Fast Charger", "Anker USB-C Cable", "Baseus Lightning Cable", "Tempered Glass Screen Protector", "iPhone 15 Silicone Case", "Samsung S24 Silicone Case", "Anker Power Bank 10000mAh", "Apple Charger", "Apple Phone Cover", "Samsung 2026", "Apple 2026", "Iphone 203", "Shampoo"})
        Me.dgv_item_name.MinimumWidth = 200
        Me.dgv_item_name.Name = "dgv_item_name"
        Me.dgv_item_name.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_item_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dgv_qty_rate
        '
        Me.dgv_qty_rate.DataPropertyName = "Qty"
        Me.dgv_qty_rate.FillWeight = 12.69035!
        Me.dgv_qty_rate.HeaderText = "Qty"
        Me.dgv_qty_rate.MinimumWidth = 80
        Me.dgv_qty_rate.Name = "dgv_qty_rate"
        '
        'dgv_price_rate
        '
        Me.dgv_price_rate.DataPropertyName = "Rate"
        Me.dgv_price_rate.FillWeight = 12.69035!
        Me.dgv_price_rate.HeaderText = "Rate"
        Me.dgv_price_rate.MinimumWidth = 120
        Me.dgv_price_rate.Name = "dgv_price_rate"
        Me.dgv_price_rate.ReadOnly = True
        '
        'dgv_amt_rate
        '
        Me.dgv_amt_rate.DataPropertyName = "Amount"
        Me.dgv_amt_rate.FillWeight = 12.69035!
        Me.dgv_amt_rate.HeaderText = "Amount"
        Me.dgv_amt_rate.MinimumWidth = 120
        Me.dgv_amt_rate.Name = "dgv_amt_rate"
        Me.dgv_amt_rate.ReadOnly = True
        '
        'search_Btn
        '
        Me.search_Btn.BackColor = System.Drawing.Color.SkyBlue
        Me.search_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_Btn.FlatAppearance.BorderSize = 0
        Me.search_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.search_Btn.ForeColor = System.Drawing.Color.White
        Me.search_Btn.Image = CType(resources.GetObject("search_Btn.Image"), System.Drawing.Image)
        Me.search_Btn.Location = New System.Drawing.Point(876, 0)
        Me.search_Btn.Name = "search_Btn"
        Me.search_Btn.Size = New System.Drawing.Size(84, 43)
        Me.search_Btn.TabIndex = 17
        Me.search_Btn.Text = "F7"
        Me.search_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.search_Btn.UseVisualStyleBackColor = False
        '
        'MobileSaleItemTableAdapter
        '
        Me.MobileSaleItemTableAdapter.ClearBeforeFill = True
        '
        'MobileSaleListTableAdapter
        '
        Me.MobileSaleListTableAdapter.ClearBeforeFill = True
        '
        'totalAmtBox
        '
        Me.totalAmtBox.BackColor = System.Drawing.Color.White
        Me.totalAmtBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.totalAmtBox.Location = New System.Drawing.Point(849, 547)
        Me.totalAmtBox.Name = "totalAmtBox"
        Me.totalAmtBox.ReadOnly = True
        Me.totalAmtBox.Size = New System.Drawing.Size(111, 25)
        Me.totalAmtBox.TabIndex = 18
        Me.totalAmtBox.Text = "0.00"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(849, 574)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(111, 25)
        Me.TextBox2.TabIndex = 19
        Me.TextBox2.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(773, 550)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Total Amt."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(780, 577)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Net Amt."
        '
        'SaleList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(994, 609)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.totalAmtBox)
        Me.Controls.Add(Me.search_Btn)
        Me.Controls.Add(Me.MobileSaleList_DGV)
        Me.Controls.Add(Me.Undo_Btn)
        Me.Controls.Add(Me.Add_Btn)
        Me.Controls.Add(Me.Delete_Btn)
        Me.Controls.Add(Me.Update_Btn)
        Me.Controls.Add(Me.Save_Btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InfoBox)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "SaleList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobile - Sale List"
        CType(Me.MobileSaleItemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileSaleDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileSaleListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoBox.ResumeLayout(False)
        Me.InfoBox.PerformLayout()
        CType(Me.MobileSaleList_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MobileSaleDS As MobileShopFrm.MobileSaleDS
    Friend WithEvents EntryNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InfoBox As System.Windows.Forms.GroupBox
    Friend WithEvents Undo_Btn As System.Windows.Forms.Button
    Friend WithEvents Delete_Btn As System.Windows.Forms.Button
    Friend WithEvents Save_Btn As System.Windows.Forms.Button
    Friend WithEvents Update_Btn As System.Windows.Forms.Button
    Friend WithEvents Add_Btn As System.Windows.Forms.Button
    'Friend WithEvents MobileSaleInvDS As MobileShopFrm.MobileSaleInvDS
    'Friend WithEvents MobileInvTableAdapter As MobileShopFrm.MobileSaleInvDSTableAdapters.MobileInvTableAdapter
    Friend WithEvents PartyComboBox As System.Windows.Forms.ComboBox
    'Friend WithEvents MobileSalePartyDS As MobileShopFrm.MobileSalePartyDS
    'Friend WithEvents MobilePartyTableAdapter As MobileShopFrm.MobileSalePartyDSTableAdapters.MobilePartyTableAdapter
    Friend WithEvents dgv_item As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileSaleList_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents ItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileSaleItemBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MobileSaleItemTableAdapter As MobileShopFrm.MobileSaleDSTableAdapters.MobileSaleItemTableAdapter
    Friend WithEvents MobileSaleListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MobileSaleListTableAdapter As MobileShopFrm.MobileSaleDSTableAdapters.MobileSaleListTableAdapter
    Friend WithEvents search_Btn As System.Windows.Forms.Button
    Friend WithEvents idno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_item_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_entry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_item_name As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_qty_rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_price_rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_amt_rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalAmtBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    'Friend WithEvents MobileSaleItemDS As MobileShopFrm.MobileSaleItemDS
    'Friend WithEvents MobileSaleItemTableAdapter As MobileShopFrm.MobileSaleItemDSTableAdapters.MobileSaleItemTableAdapter
End Class
