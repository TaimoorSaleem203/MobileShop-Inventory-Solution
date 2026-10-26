<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.UtilityMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductList = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorList = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerList = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntryMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleInv = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleReturnInv = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseInv = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseReturnInv = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UtilityMI, Me.EntryMI, Me.UserMI})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1194, 25)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'UtilityMI
        '
        Me.UtilityMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductList, Me.VendorList, Me.CustomerList})
        Me.UtilityMI.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UtilityMI.ForeColor = System.Drawing.Color.White
        Me.UtilityMI.Name = "UtilityMI"
        Me.UtilityMI.Size = New System.Drawing.Size(55, 21)
        Me.UtilityMI.Text = "Utility"
        '
        'ProductList
        '
        Me.ProductList.BackColor = System.Drawing.Color.White
        Me.ProductList.ForeColor = System.Drawing.Color.Black
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(159, 22)
        Me.ProductList.Text = "Product List"
        '
        'VendorList
        '
        Me.VendorList.BackColor = System.Drawing.Color.White
        Me.VendorList.ForeColor = System.Drawing.Color.Black
        Me.VendorList.Name = "VendorList"
        Me.VendorList.Size = New System.Drawing.Size(159, 22)
        Me.VendorList.Text = "Vendor List"
        '
        'CustomerList
        '
        Me.CustomerList.BackColor = System.Drawing.Color.White
        Me.CustomerList.ForeColor = System.Drawing.Color.Black
        Me.CustomerList.Name = "CustomerList"
        Me.CustomerList.Size = New System.Drawing.Size(159, 22)
        Me.CustomerList.Text = "Customer List"
        '
        'EntryMI
        '
        Me.EntryMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaleInv, Me.SaleReturnInv, Me.PurchaseInv, Me.PurchaseReturnInv})
        Me.EntryMI.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.EntryMI.ForeColor = System.Drawing.Color.White
        Me.EntryMI.Name = "EntryMI"
        Me.EntryMI.Size = New System.Drawing.Size(53, 21)
        Me.EntryMI.Text = "Entry"
        '
        'UserMI
        '
        Me.UserMI.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.UserMI.ForeColor = System.Drawing.Color.White
        Me.UserMI.Name = "UserMI"
        Me.UserMI.Size = New System.Drawing.Size(132, 21)
        Me.UserMI.Text = "User Management"
        '
        'SaleInv
        '
        Me.SaleInv.BackColor = System.Drawing.Color.White
        Me.SaleInv.Name = "SaleInv"
        Me.SaleInv.Size = New System.Drawing.Size(223, 22)
        Me.SaleInv.Text = "Sale Invoice"
        '
        'SaleReturnInv
        '
        Me.SaleReturnInv.Name = "SaleReturnInv"
        Me.SaleReturnInv.Size = New System.Drawing.Size(223, 22)
        Me.SaleReturnInv.Text = "Sale Return Invoice"
        '
        'PurchaseInv
        '
        Me.PurchaseInv.BackColor = System.Drawing.Color.White
        Me.PurchaseInv.Name = "PurchaseInv"
        Me.PurchaseInv.Size = New System.Drawing.Size(223, 22)
        Me.PurchaseInv.Text = "Purchase Invoice"
        '
        'PurchaseReturnInv
        '
        Me.PurchaseReturnInv.Name = "PurchaseReturnInv"
        Me.PurchaseReturnInv.Size = New System.Drawing.Size(223, 22)
        Me.PurchaseReturnInv.Text = "Purchase Return Invoice"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MobileShopFrm.My.Resources.Resources.MainBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1194, 711)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobile - Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents UtilityMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntryMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendorList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleInv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleReturnInv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseInv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseReturnInv As System.Windows.Forms.ToolStripMenuItem
End Class
