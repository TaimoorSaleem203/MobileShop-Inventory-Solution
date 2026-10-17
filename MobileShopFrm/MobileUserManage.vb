Public Class UserManagement
    Private Sub UserManagement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MobileUserDS.MobileUser' table. You can move, or remove it, as needed.
        Me.MobileUserTableAdapter.Fill(Me.MobileUserDS.MobileUser)
    End Sub
End Class