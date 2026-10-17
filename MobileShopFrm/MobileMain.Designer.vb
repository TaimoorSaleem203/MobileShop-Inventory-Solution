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
        Me.ProductMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartyMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleListMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductMI, Me.PartyMI, Me.SaleListMI, Me.UserMI})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1194, 25)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ProductMI
        '
        Me.ProductMI.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductMI.ForeColor = System.Drawing.Color.White
        Me.ProductMI.Name = "ProductMI"
        Me.ProductMI.Size = New System.Drawing.Size(92, 21)
        Me.ProductMI.Text = "Product List"
        '
        'PartyMI
        '
        Me.PartyMI.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.PartyMI.ForeColor = System.Drawing.Color.White
        Me.PartyMI.Name = "PartyMI"
        Me.PartyMI.Size = New System.Drawing.Size(76, 21)
        Me.PartyMI.Text = "Party List"
        '
        'SaleListMI
        '
        Me.SaleListMI.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SaleListMI.ForeColor = System.Drawing.Color.White
        Me.SaleListMI.Name = "SaleListMI"
        Me.SaleListMI.Size = New System.Drawing.Size(68, 21)
        Me.SaleListMI.Text = "Sale List"
        '
        'UserMI
        '
        Me.UserMI.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.UserMI.ForeColor = System.Drawing.Color.White
        Me.UserMI.Name = "UserMI"
        Me.UserMI.Size = New System.Drawing.Size(132, 21)
        Me.UserMI.Text = "User Management"
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
    Friend WithEvents ProductMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartyMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleListMI As System.Windows.Forms.ToolStripMenuItem
End Class
