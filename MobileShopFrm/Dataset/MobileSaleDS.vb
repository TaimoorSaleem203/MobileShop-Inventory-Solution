Partial Class MobileSaleDS
    Partial Class MobileSaleItemDataTable

        Private Sub MobileSaleItemDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ItemIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
