Public Class InvFind

    Private Sub InvFind_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MobileInvDS.MobileInv' table. You can move, or remove it, as needed.
        Me.MobileInvTableAdapter.Fill(Me.MobileInvDS.MobileInv)

    End Sub
End Class