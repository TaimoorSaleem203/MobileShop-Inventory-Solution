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
        Dim GSTLabel As System.Windows.Forms.Label
        Dim FTaxLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaleList))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim valueLbl_1 As System.Windows.Forms.Label
        Dim valueLbl_2 As System.Windows.Forms.Label
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
        Me.FTaxTextBox = New System.Windows.Forms.TextBox()
        Me.valueBox_2 = New System.Windows.Forms.TextBox()
        Me.valueBox_1 = New System.Windows.Forms.TextBox()
        Me.GSTTextBox = New System.Windows.Forms.TextBox()
        Me.PartyComboBox = New System.Windows.Forms.ComboBox()
        Me.Undo_Btn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.Update_Btn = New System.Windows.Forms.Button()
        Me.Add_Btn = New System.Windows.Forms.Button()
        Me.MobileSaleList_DGV = New System.Windows.Forms.DataGridView()
        Me.dgv_idno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_item_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_entry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_item_name = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgv_qty_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_price_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_amt_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.search_Btn = New System.Windows.Forms.Button()
        Me.totalAmtBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.currEntryLbl = New System.Windows.Forms.Label()
        Me.firstBtn = New System.Windows.Forms.Button()
        Me.prevBtn = New System.Windows.Forms.Button()
        Me.lastBtn = New System.Windows.Forms.Button()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.totalEntryLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.navBox = New System.Windows.Forms.GroupBox()
        Me.MobileSaleItemTableAdapter = New MobileShopFrm.MobileSaleDSTableAdapters.MobileSaleItemTableAdapter()
        Me.MobileSaleListTableAdapter = New MobileShopFrm.MobileSaleDSTableAdapters.MobileSaleListTableAdapter()
        Me.TableAdapterManager = New MobileShopFrm.MobileSaleDSTableAdapters.TableAdapterManager()
        EntryNoLabel = New System.Windows.Forms.Label()
        BillNoLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        PartyLabel = New System.Windows.Forms.Label()
        GSTLabel = New System.Windows.Forms.Label()
        FTaxLabel = New System.Windows.Forms.Label()
        valueLbl_1 = New System.Windows.Forms.Label()
        valueLbl_2 = New System.Windows.Forms.Label()
        CType(Me.MobileSaleItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileSaleDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileSaleListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoBox.SuspendLayout()
        CType(Me.MobileSaleList_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'EntryNoLabel
        '
        EntryNoLabel.AutoSize = True
        EntryNoLabel.ForeColor = System.Drawing.Color.DimGray
        EntryNoLabel.Location = New System.Drawing.Point(22, 30)
        EntryNoLabel.Name = "EntryNoLabel"
        EntryNoLabel.Size = New System.Drawing.Size(66, 17)
        EntryNoLabel.TabIndex = 0
        EntryNoLabel.Text = "Entry No:"
        '
        'BillNoLabel
        '
        BillNoLabel.AutoSize = True
        BillNoLabel.ForeColor = System.Drawing.Color.DimGray
        BillNoLabel.Location = New System.Drawing.Point(140, 30)
        BillNoLabel.Name = "BillNoLabel"
        BillNoLabel.Size = New System.Drawing.Size(50, 17)
        BillNoLabel.TabIndex = 2
        BillNoLabel.Text = "Bill No:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.ForeColor = System.Drawing.Color.DimGray
        DateLabel.Location = New System.Drawing.Point(22, 85)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(39, 17)
        DateLabel.TabIndex = 4
        DateLabel.Text = "Date:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.ForeColor = System.Drawing.Color.DimGray
        RemarksLabel.Location = New System.Drawing.Point(258, 84)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(63, 17)
        RemarksLabel.TabIndex = 6
        RemarksLabel.Text = "Remarks:"
        '
        'PartyLabel
        '
        PartyLabel.AutoSize = True
        PartyLabel.ForeColor = System.Drawing.Color.DimGray
        PartyLabel.Location = New System.Drawing.Point(258, 30)
        PartyLabel.Name = "PartyLabel"
        PartyLabel.Size = New System.Drawing.Size(43, 17)
        PartyLabel.TabIndex = 8
        PartyLabel.Text = "Party:"
        '
        'GSTLabel
        '
        GSTLabel.AutoSize = True
        GSTLabel.ForeColor = System.Drawing.Color.DimGray
        GSTLabel.Location = New System.Drawing.Point(620, 30)
        GSTLabel.Name = "GSTLabel"
        GSTLabel.Size = New System.Drawing.Size(45, 17)
        GSTLabel.TabIndex = 10
        GSTLabel.Text = "GST%:"
        '
        'FTaxLabel
        '
        FTaxLabel.AutoSize = True
        FTaxLabel.ForeColor = System.Drawing.Color.DimGray
        FTaxLabel.Location = New System.Drawing.Point(620, 85)
        FTaxLabel.Name = "FTaxLabel"
        FTaxLabel.Size = New System.Drawing.Size(49, 17)
        FTaxLabel.TabIndex = 14
        FTaxLabel.Text = "FTax%:"
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
        Me.ShapeContainer1.Size = New System.Drawing.Size(1004, 609)
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
        Me.EntryNoTextBox.Location = New System.Drawing.Point(25, 50)
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
        Me.BillNoTextBox.Location = New System.Drawing.Point(143, 50)
        Me.BillNoTextBox.Name = "BillNoTextBox"
        Me.BillNoTextBox.ReadOnly = True
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
        Me.DateTimePicker.Location = New System.Drawing.Point(25, 104)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(218, 25)
        Me.DateTimePicker.TabIndex = 5
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.BackColor = System.Drawing.Color.White
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileSaleListBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(261, 104)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(215, 25)
        Me.RemarksTextBox.TabIndex = 7
        '
        'InfoBox
        '
        Me.InfoBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoBox.Controls.Add(valueLbl_2)
        Me.InfoBox.Controls.Add(valueLbl_1)
        Me.InfoBox.Controls.Add(FTaxLabel)
        Me.InfoBox.Controls.Add(Me.FTaxTextBox)
        Me.InfoBox.Controls.Add(Me.valueBox_2)
        Me.InfoBox.Controls.Add(Me.valueBox_1)
        Me.InfoBox.Controls.Add(GSTLabel)
        Me.InfoBox.Controls.Add(Me.GSTTextBox)
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
        Me.InfoBox.Size = New System.Drawing.Size(932, 145)
        Me.InfoBox.TabIndex = 8
        Me.InfoBox.TabStop = False
        Me.InfoBox.Text = "Sale Info"
        '
        'FTaxTextBox
        '
        Me.FTaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileSaleListBindingSource, "FTax", True))
        Me.FTaxTextBox.Location = New System.Drawing.Point(623, 104)
        Me.FTaxTextBox.Name = "FTaxTextBox"
        Me.FTaxTextBox.Size = New System.Drawing.Size(131, 25)
        Me.FTaxTextBox.TabIndex = 15
        '
        'valueBox_2
        '
        Me.valueBox_2.BackColor = System.Drawing.Color.White
        Me.valueBox_2.Location = New System.Drawing.Point(774, 104)
        Me.valueBox_2.Name = "valueBox_2"
        Me.valueBox_2.ReadOnly = True
        Me.valueBox_2.Size = New System.Drawing.Size(131, 25)
        Me.valueBox_2.TabIndex = 13
        '
        'valueBox_1
        '
        Me.valueBox_1.BackColor = System.Drawing.Color.White
        Me.valueBox_1.Location = New System.Drawing.Point(774, 50)
        Me.valueBox_1.Name = "valueBox_1"
        Me.valueBox_1.ReadOnly = True
        Me.valueBox_1.Size = New System.Drawing.Size(131, 25)
        Me.valueBox_1.TabIndex = 12
        '
        'GSTTextBox
        '
        Me.GSTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileSaleItemBindingSource1, "GST", True))
        Me.GSTTextBox.Location = New System.Drawing.Point(623, 50)
        Me.GSTTextBox.Name = "GSTTextBox"
        Me.GSTTextBox.Size = New System.Drawing.Size(131, 25)
        Me.GSTTextBox.TabIndex = 11
        '
        'PartyComboBox
        '
        Me.PartyComboBox.BackColor = System.Drawing.Color.White
        Me.PartyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobileSaleListBindingSource, "Party", True))
        Me.PartyComboBox.DisplayMember = "Party"
        Me.PartyComboBox.FormattingEnabled = True
        Me.PartyComboBox.Location = New System.Drawing.Point(261, 50)
        Me.PartyComboBox.Name = "PartyComboBox"
        Me.PartyComboBox.Size = New System.Drawing.Size(215, 25)
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
        Me.Undo_Btn.Location = New System.Drawing.Point(803, 0)
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
        Me.Delete_Btn.Location = New System.Drawing.Point(722, 0)
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
        Me.Save_Btn.Size = New System.Drawing.Size(91, 43)
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
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.MobileSaleList_DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MobileSaleList_DGV.AutoGenerateColumns = False
        Me.MobileSaleList_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MobileSaleList_DGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.MobileSaleList_DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MobileSaleList_DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MobileSaleList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MobileSaleList_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_idno, Me.dgv_item_id, Me.dgv_entry, Me.dgv_item_name, Me.dgv_qty_rate, Me.dgv_price_rate, Me.dgv_amt_rate})
        Me.MobileSaleList_DGV.DataSource = Me.MobileSaleItemBindingSource1
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MobileSaleList_DGV.DefaultCellStyle = DataGridViewCellStyle7
        Me.MobileSaleList_DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.MobileSaleList_DGV.EnableHeadersVisualStyles = False
        Me.MobileSaleList_DGV.GridColor = System.Drawing.Color.Silver
        Me.MobileSaleList_DGV.Location = New System.Drawing.Point(29, 202)
        Me.MobileSaleList_DGV.Name = "MobileSaleList_DGV"
        Me.MobileSaleList_DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.MobileSaleList_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MobileSaleList_DGV.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.MobileSaleList_DGV.Size = New System.Drawing.Size(931, 344)
        Me.MobileSaleList_DGV.TabIndex = 16
        '
        'dgv_idno
        '
        Me.dgv_idno.DataPropertyName = "idno"
        Me.dgv_idno.HeaderText = "ID"
        Me.dgv_idno.Name = "dgv_idno"
        Me.dgv_idno.ReadOnly = True
        Me.dgv_idno.Visible = False
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
        Me.dgv_entry.MinimumWidth = 80
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
        Me.search_Btn.Location = New System.Drawing.Point(887, 0)
        Me.search_Btn.Name = "search_Btn"
        Me.search_Btn.Size = New System.Drawing.Size(74, 43)
        Me.search_Btn.TabIndex = 17
        Me.search_Btn.Text = "F7"
        Me.search_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.search_Btn.UseVisualStyleBackColor = False
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
        'currEntryLbl
        '
        Me.currEntryLbl.AutoSize = True
        Me.currEntryLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.currEntryLbl.ForeColor = System.Drawing.Color.DimGray
        Me.currEntryLbl.Location = New System.Drawing.Point(57, 19)
        Me.currEntryLbl.Name = "currEntryLbl"
        Me.currEntryLbl.Size = New System.Drawing.Size(15, 17)
        Me.currEntryLbl.TabIndex = 22
        Me.currEntryLbl.Text = "0"
        '
        'firstBtn
        '
        Me.firstBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.firstBtn.FlatAppearance.BorderSize = 0
        Me.firstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.firstBtn.Image = Global.MobileShopFrm.My.Resources.Resources.first
        Me.firstBtn.Location = New System.Drawing.Point(1, 16)
        Me.firstBtn.Name = "firstBtn"
        Me.firstBtn.Size = New System.Drawing.Size(28, 23)
        Me.firstBtn.TabIndex = 23
        Me.firstBtn.UseVisualStyleBackColor = True
        '
        'prevBtn
        '
        Me.prevBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.prevBtn.FlatAppearance.BorderSize = 0
        Me.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prevBtn.Image = Global.MobileShopFrm.My.Resources.Resources.prev
        Me.prevBtn.Location = New System.Drawing.Point(26, 16)
        Me.prevBtn.Name = "prevBtn"
        Me.prevBtn.Size = New System.Drawing.Size(28, 23)
        Me.prevBtn.TabIndex = 24
        Me.prevBtn.UseVisualStyleBackColor = True
        '
        'lastBtn
        '
        Me.lastBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lastBtn.FlatAppearance.BorderSize = 0
        Me.lastBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lastBtn.Image = Global.MobileShopFrm.My.Resources.Resources.last
        Me.lastBtn.Location = New System.Drawing.Point(149, 16)
        Me.lastBtn.Name = "lastBtn"
        Me.lastBtn.Size = New System.Drawing.Size(28, 23)
        Me.lastBtn.TabIndex = 26
        Me.lastBtn.UseVisualStyleBackColor = True
        '
        'nextBtn
        '
        Me.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextBtn.FlatAppearance.BorderSize = 0
        Me.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextBtn.Image = Global.MobileShopFrm.My.Resources.Resources._next
        Me.nextBtn.Location = New System.Drawing.Point(124, 16)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(28, 23)
        Me.nextBtn.TabIndex = 25
        Me.nextBtn.UseVisualStyleBackColor = True
        '
        'totalEntryLbl
        '
        Me.totalEntryLbl.AutoSize = True
        Me.totalEntryLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.totalEntryLbl.ForeColor = System.Drawing.Color.DimGray
        Me.totalEntryLbl.Location = New System.Drawing.Point(106, 19)
        Me.totalEntryLbl.Name = "totalEntryLbl"
        Me.totalEntryLbl.Size = New System.Drawing.Size(15, 17)
        Me.totalEntryLbl.TabIndex = 27
        Me.totalEntryLbl.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(78, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "To"
        '
        'navBox
        '
        Me.navBox.BackColor = System.Drawing.Color.Transparent
        Me.navBox.Controls.Add(Me.Label5)
        Me.navBox.Controls.Add(Me.currEntryLbl)
        Me.navBox.Controls.Add(Me.totalEntryLbl)
        Me.navBox.Controls.Add(Me.firstBtn)
        Me.navBox.Controls.Add(Me.lastBtn)
        Me.navBox.Controls.Add(Me.prevBtn)
        Me.navBox.Controls.Add(Me.nextBtn)
        Me.navBox.Location = New System.Drawing.Point(29, 547)
        Me.navBox.Name = "navBox"
        Me.navBox.Size = New System.Drawing.Size(184, 50)
        Me.navBox.TabIndex = 29
        Me.navBox.TabStop = False
        '
        'MobileSaleItemTableAdapter
        '
        Me.MobileSaleItemTableAdapter.ClearBeforeFill = True
        '
        'MobileSaleListTableAdapter
        '
        Me.MobileSaleListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MobileShopFrm.MobileSaleDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'valueLbl_1
        '
        valueLbl_1.AutoSize = True
        valueLbl_1.ForeColor = System.Drawing.Color.DimGray
        valueLbl_1.Location = New System.Drawing.Point(771, 30)
        valueLbl_1.Name = "valueLbl_1"
        valueLbl_1.Size = New System.Drawing.Size(43, 17)
        valueLbl_1.TabIndex = 16
        valueLbl_1.Text = "Value:"
        '
        'valueLbl_2
        '
        valueLbl_2.AutoSize = True
        valueLbl_2.ForeColor = System.Drawing.Color.DimGray
        valueLbl_2.Location = New System.Drawing.Point(771, 85)
        valueLbl_2.Name = "valueLbl_2"
        valueLbl_2.Size = New System.Drawing.Size(43, 17)
        valueLbl_2.TabIndex = 17
        valueLbl_2.Text = "Value:"
        '
        'SaleList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1004, 609)
        Me.Controls.Add(Me.navBox)
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
        Me.MinimizeBox = False
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
        Me.navBox.ResumeLayout(False)
        Me.navBox.PerformLayout()
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
    Friend WithEvents totalAmtBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents currEntryLbl As System.Windows.Forms.Label
    Friend WithEvents firstBtn As System.Windows.Forms.Button
    Friend WithEvents prevBtn As System.Windows.Forms.Button
    Friend WithEvents lastBtn As System.Windows.Forms.Button
    Friend WithEvents nextBtn As System.Windows.Forms.Button
    Friend WithEvents totalEntryLbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents navBox As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_idno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_item_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_entry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_item_name As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dgv_qty_rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_price_rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_amt_rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As MobileShopFrm.MobileSaleDSTableAdapters.TableAdapterManager
    Friend WithEvents valueBox_2 As System.Windows.Forms.TextBox
    Friend WithEvents valueBox_1 As System.Windows.Forms.TextBox
    Friend WithEvents FTaxTextBox As System.Windows.Forms.TextBox
    'Friend WithEvents MobileSaleItemDS As MobileShopFrm.MobileSaleItemDS
    'Friend WithEvents MobileSaleItemTableAdapter As MobileShopFrm.MobileSaleItemDSTableAdapters.MobileSaleItemTableAdapter
End Class
