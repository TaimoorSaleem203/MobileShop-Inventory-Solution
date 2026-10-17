<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MobileUser_DGV = New System.Windows.Forms.DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserImageDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MobileUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MobileUserDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MobileUserDS = New MobileShopFrm.MobileUserDS()
        Me.MobileUserTableAdapter = New MobileShopFrm.MobileUserDSTableAdapters.MobileUserTableAdapter()
        CType(Me.MobileUser_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileUserDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileUserDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MobileUser_DGV
        '
        Me.MobileUser_DGV.AllowUserToAddRows = False
        Me.MobileUser_DGV.AllowUserToDeleteRows = False
        Me.MobileUser_DGV.AllowUserToResizeColumns = False
        Me.MobileUser_DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window
        Me.MobileUser_DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MobileUser_DGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MobileUser_DGV.AutoGenerateColumns = False
        Me.MobileUser_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MobileUser_DGV.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.MobileUser_DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MobileUser_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MobileUser_DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MobileUser_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MobileUser_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.UserPasswordDataGridViewTextBoxColumn, Me.UserImageDataGridViewImageColumn})
        Me.MobileUser_DGV.DataSource = Me.MobileUserBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MobileUser_DGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.MobileUser_DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.MobileUser_DGV.EnableHeadersVisualStyles = False
        Me.MobileUser_DGV.Location = New System.Drawing.Point(30, 125)
        Me.MobileUser_DGV.Name = "MobileUser_DGV"
        Me.MobileUser_DGV.RowHeadersVisible = False
        Me.MobileUser_DGV.RowHeadersWidth = 40
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MobileUser_DGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MobileUser_DGV.RowTemplate.Height = 40
        Me.MobileUser_DGV.Size = New System.Drawing.Size(920, 411)
        Me.MobileUser_DGV.TabIndex = 14
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "User_Name"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        '
        'UserPasswordDataGridViewTextBoxColumn
        '
        Me.UserPasswordDataGridViewTextBoxColumn.DataPropertyName = "User_Password"
        Me.UserPasswordDataGridViewTextBoxColumn.HeaderText = "User_Password"
        Me.UserPasswordDataGridViewTextBoxColumn.Name = "UserPasswordDataGridViewTextBoxColumn"
        '
        'UserImageDataGridViewImageColumn
        '
        Me.UserImageDataGridViewImageColumn.DataPropertyName = "User_Image"
        Me.UserImageDataGridViewImageColumn.HeaderText = "User_Image"
        Me.UserImageDataGridViewImageColumn.Name = "UserImageDataGridViewImageColumn"
        '
        'MobileUserBindingSource
        '
        Me.MobileUserBindingSource.DataMember = "MobileUser"
        Me.MobileUserBindingSource.DataSource = Me.MobileUserDSBindingSource
        '
        'MobileUserDSBindingSource
        '
        Me.MobileUserDSBindingSource.DataSource = Me.MobileUserDS
        Me.MobileUserDSBindingSource.Position = 0
        '
        'MobileUserDS
        '
        Me.MobileUserDS.DataSetName = "MobileUserDS"
        Me.MobileUserDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MobileUserTableAdapter
        '
        Me.MobileUserTableAdapter.ClearBeforeFill = True
        '
        'UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.MobileUser_DGV)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "UserManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobile - UserManagement"
        CType(Me.MobileUser_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileUserDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileUserDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MobileUser_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents MobileUserDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MobileUserDS As MobileShopFrm.MobileUserDS
    Friend WithEvents MobileUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MobileUserTableAdapter As MobileShopFrm.MobileUserDSTableAdapters.MobileUserTableAdapter
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserPasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserImageDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
End Class
