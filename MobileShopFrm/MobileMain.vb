Public Class Main
    Private Sub ProductMI_Click(sender As System.Object, e As System.EventArgs) Handles ProductMI.Click
        Dim frm As New InventorySol
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub PartyMI_Click(sender As System.Object, e As System.EventArgs) Handles PartyMI.Click
        Dim frm As New PartytList
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub SaleListMI_Click(sender As System.Object, e As System.EventArgs) Handles SaleListMI.Click
        Dim frm As New SaleList
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub UserMI_Click(sender As System.Object, e As System.EventArgs) Handles UserMI.Click
        Dim frm As New UserManagement
        frm.ShowDialog()
        frm.Dispose()
    End Sub
End Class