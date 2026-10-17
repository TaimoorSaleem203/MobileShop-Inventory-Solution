<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartytList
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
        Dim PartyLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CommentLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PartytList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.Add_Btn = New System.Windows.Forms.Button()
        Me.Undo_Btn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.Update_Btn = New System.Windows.Forms.Button()
        Me.MobilePartyDS = New MobileShopFrm.MobilePartyDS()
        Me.MobilePartyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MobilePartyTableAdapter = New MobileShopFrm.MobilePartyDSTableAdapters.MobilePartyTableAdapter()
        Me.TableAdapterManager = New MobileShopFrm.MobilePartyDSTableAdapters.TableAdapterManager()
        Me.MobileParty_DGV = New System.Windows.Forms.DataGridView()
        Me.PartyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfoBox = New System.Windows.Forms.GroupBox()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PartyTextBox = New System.Windows.Forms.TextBox()
        PartyLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CommentLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        CType(Me.MobilePartyDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobilePartyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileParty_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PartyLabel
        '
        PartyLabel.AutoSize = True
        PartyLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        PartyLabel.ForeColor = System.Drawing.Color.DimGray
        PartyLabel.Location = New System.Drawing.Point(141, 34)
        PartyLabel.Name = "PartyLabel"
        PartyLabel.Size = New System.Drawing.Size(43, 17)
        PartyLabel.TabIndex = 0
        PartyLabel.Text = "Party:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        AddressLabel.ForeColor = System.Drawing.Color.DimGray
        AddressLabel.Location = New System.Drawing.Point(378, 34)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(60, 17)
        AddressLabel.TabIndex = 2
        AddressLabel.Text = "Address:"
        '
        'CommentLabel
        '
        CommentLabel.AutoSize = True
        CommentLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        CommentLabel.ForeColor = System.Drawing.Color.DimGray
        CommentLabel.Location = New System.Drawing.Point(649, 34)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(71, 17)
        CommentLabel.TabIndex = 4
        CommentLabel.Text = "Comment:"
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        CodeLabel.ForeColor = System.Drawing.Color.DimGray
        CodeLabel.Location = New System.Drawing.Point(12, 34)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(42, 17)
        CodeLabel.TabIndex = 6
        CodeLabel.Text = "Code:"
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
        Me.ShapeContainer1.Size = New System.Drawing.Size(994, 571)
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
        Me.Label1.Size = New System.Drawing.Size(151, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PARTY MASTER"
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
        Me.Save_Btn.Location = New System.Drawing.Point(704, 0)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(84, 43)
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
        Me.Add_Btn.Location = New System.Drawing.Point(542, 0)
        Me.Add_Btn.Name = "Add_Btn"
        Me.Add_Btn.Size = New System.Drawing.Size(84, 43)
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
        Me.Undo_Btn.Location = New System.Drawing.Point(865, 0)
        Me.Undo_Btn.Name = "Undo_Btn"
        Me.Undo_Btn.Size = New System.Drawing.Size(84, 43)
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
        Me.Delete_Btn.Location = New System.Drawing.Point(784, 0)
        Me.Delete_Btn.Name = "Delete_Btn"
        Me.Delete_Btn.Size = New System.Drawing.Size(84, 43)
        Me.Delete_Btn.TabIndex = 7
        Me.Delete_Btn.Text = "F5"
        Me.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Delete_Btn.UseVisualStyleBackColor = False
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
        Me.Update_Btn.Location = New System.Drawing.Point(623, 0)
        Me.Update_Btn.Name = "Update_Btn"
        Me.Update_Btn.Size = New System.Drawing.Size(84, 43)
        Me.Update_Btn.TabIndex = 6
        Me.Update_Btn.Text = "F3"
        Me.Update_Btn.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Update_Btn.UseVisualStyleBackColor = False
        '
        'MobilePartyDS
        '
        Me.MobilePartyDS.DataSetName = "MobilePartyDS"
        Me.MobilePartyDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MobilePartyBindingSource
        '
        Me.MobilePartyBindingSource.DataMember = "MobileParty"
        Me.MobilePartyBindingSource.DataSource = Me.MobilePartyDS
        '
        'MobilePartyTableAdapter
        '
        Me.MobilePartyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MobilePartyTableAdapter = Me.MobilePartyTableAdapter
        Me.TableAdapterManager.UpdateOrder = MobileShopFrm.MobilePartyDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MobileParty_DGV
        '
        Me.MobileParty_DGV.AllowUserToAddRows = False
        Me.MobileParty_DGV.AllowUserToDeleteRows = False
        Me.MobileParty_DGV.AllowUserToResizeColumns = False
        Me.MobileParty_DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.MobileParty_DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MobileParty_DGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MobileParty_DGV.AutoGenerateColumns = False
        Me.MobileParty_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MobileParty_DGV.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.MobileParty_DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MobileParty_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MobileParty_DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MobileParty_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MobileParty_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PartyDataGridViewTextBoxColumn, Me.Address, Me.Comment})
        Me.MobileParty_DGV.DataSource = Me.MobilePartyBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MobileParty_DGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.MobileParty_DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.MobileParty_DGV.EnableHeadersVisualStyles = False
        Me.MobileParty_DGV.Location = New System.Drawing.Point(29, 153)
        Me.MobileParty_DGV.Name = "MobileParty_DGV"
        Me.MobileParty_DGV.RowHeadersVisible = False
        Me.MobileParty_DGV.RowHeadersWidth = 50
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MobileParty_DGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MobileParty_DGV.Size = New System.Drawing.Size(930, 396)
        Me.MobileParty_DGV.TabIndex = 13
        '
        'PartyDataGridViewTextBoxColumn
        '
        Me.PartyDataGridViewTextBoxColumn.DataPropertyName = "Party"
        Me.PartyDataGridViewTextBoxColumn.FillWeight = 118.7817!
        Me.PartyDataGridViewTextBoxColumn.HeaderText = "Party"
        Me.PartyDataGridViewTextBoxColumn.Name = "PartyDataGridViewTextBoxColumn"
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        '
        'Comment
        '
        Me.Comment.DataPropertyName = "Comment"
        Me.Comment.HeaderText = "Comment"
        Me.Comment.Name = "Comment"
        '
        'InfoBox
        '
        Me.InfoBox.Controls.Add(CodeLabel)
        Me.InfoBox.Controls.Add(Me.CodeTextBox)
        Me.InfoBox.Controls.Add(CommentLabel)
        Me.InfoBox.Controls.Add(Me.CommentTextBox)
        Me.InfoBox.Controls.Add(AddressLabel)
        Me.InfoBox.Controls.Add(Me.AddressTextBox)
        Me.InfoBox.Controls.Add(PartyLabel)
        Me.InfoBox.Controls.Add(Me.PartyTextBox)
        Me.InfoBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.InfoBox.Location = New System.Drawing.Point(29, 50)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Size = New System.Drawing.Size(920, 97)
        Me.InfoBox.TabIndex = 14
        Me.InfoBox.TabStop = False
        Me.InfoBox.Text = "Party Info"
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobilePartyBindingSource, "Code", True))
        Me.CodeTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CodeTextBox.Location = New System.Drawing.Point(15, 54)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.ReadOnly = True
        Me.CodeTextBox.Size = New System.Drawing.Size(112, 25)
        Me.CodeTextBox.TabIndex = 7
        '
        'CommentTextBox
        '
        Me.CommentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobilePartyBindingSource, "Comment", True))
        Me.CommentTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CommentTextBox.Location = New System.Drawing.Point(652, 54)
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Size = New System.Drawing.Size(250, 25)
        Me.CommentTextBox.TabIndex = 5
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobilePartyBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.AddressTextBox.Location = New System.Drawing.Point(381, 54)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(250, 25)
        Me.AddressTextBox.TabIndex = 3
        '
        'PartyTextBox
        '
        Me.PartyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MobilePartyBindingSource, "Party", True))
        Me.PartyTextBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.PartyTextBox.Location = New System.Drawing.Point(144, 54)
        Me.PartyTextBox.Name = "PartyTextBox"
        Me.PartyTextBox.Size = New System.Drawing.Size(218, 25)
        Me.PartyTextBox.TabIndex = 1
        '
        'PartytList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(994, 571)
        Me.Controls.Add(Me.Undo_Btn)
        Me.Controls.Add(Me.Delete_Btn)
        Me.Controls.Add(Me.Save_Btn)
        Me.Controls.Add(Me.Update_Btn)
        Me.Controls.Add(Me.Add_Btn)
        Me.Controls.Add(Me.InfoBox)
        Me.Controls.Add(Me.MobileParty_DGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "PartytList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobile - Party List"
        CType(Me.MobilePartyDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobilePartyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileParty_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoBox.ResumeLayout(False)
        Me.InfoBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Save_Btn As System.Windows.Forms.Button
    Friend WithEvents Add_Btn As System.Windows.Forms.Button
    Friend WithEvents Undo_Btn As System.Windows.Forms.Button
    Friend WithEvents Delete_Btn As System.Windows.Forms.Button
    Friend WithEvents Update_Btn As System.Windows.Forms.Button
    Friend WithEvents MobilePartyDS As MobileShopFrm.MobilePartyDS
    Friend WithEvents MobilePartyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MobilePartyTableAdapter As MobileShopFrm.MobilePartyDSTableAdapters.MobilePartyTableAdapter
    Friend WithEvents TableAdapterManager As MobileShopFrm.MobilePartyDSTableAdapters.TableAdapterManager
    Friend WithEvents MobileParty_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents InfoBox As System.Windows.Forms.GroupBox
    Friend WithEvents PartyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comment As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
