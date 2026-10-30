Public Class Main

    Private Sub ProductList_Click(sender As System.Object, e As System.EventArgs) Handles ProductList.Click
        Dim frm As New InventorySol
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub CustomerList_Click(sender As System.Object, e As System.EventArgs) Handles CustomerList.Click
        Dim frm As New PartytList
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub SaleInv_Click(sender As System.Object, e As System.EventArgs) Handles SaleInv.Click
        Dim frm As New SaleList
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub UserMI_Click(sender As System.Object, e As System.EventArgs) Handles UserMI.Click
        Dim frm As New UserManagement
        frm.ShowDialog()
        frm.Dispose()
    End Sub


End Class