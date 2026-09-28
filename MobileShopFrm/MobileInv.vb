
Public Class InventorySol

    Private Sub InventorySol_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        form_load()
    End Sub

    Private Sub form_load()
        Add_Btn.Enabled = False
        Update_Btn.Enabled = False
        Delete_Btn.Enabled = False
        Save_Btn.Enabled = False
        Undo_Btn.Enabled = False

        Me.KeyPreview = True
    End Sub

    Private Sub Action_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Show_Btn.PerformClick()
            e.Handled = True
        End If

        If e.KeyCode = Keys.F2 Then
            Add_Btn.PerformClick()
            e.Handled = True
        End If

        If e.KeyCode = Keys.F3 Then
            Update_Btn.PerformClick()
            e.Handled = True
        End If

        If e.KeyCode = Keys.F4 Then
            Save_Btn.PerformClick()
            e.Handled = True
        End If

        If e.KeyCode = Keys.F5 Then
            Delete_Btn.PerformClick()
            e.Handled = True
        End If

        If e.KeyCode = Keys.F6 Then
            Undo_Btn.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub disable_add_edit_delete()
        Save_Btn.Enabled = True
        'Undo_Btn.Enabled = True
        MobileInv_DGV.EditMode = DataGridViewEditMode.EditProgrammatically

        Add_Btn.Enabled = False
        Update_Btn.Enabled = False
        Delete_Btn.Enabled = False
        Show_Btn.Enabled = False
    End Sub

    Private Sub enable_add_edit_delete()
        Save_Btn.Enabled = False
        'undo_Btn.Enabled = False
        MobileInv_DGV.EditMode = DataGridViewEditMode.EditProgrammatically

        Add_Btn.Enabled = True
        Update_Btn.Enabled = True
        Delete_Btn.Enabled = True
        Show_Btn.Enabled = True
        Undo_Btn.Enabled = True
    End Sub

    Private Sub Show_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Show_Btn.Click

        enable_add_edit_delete()
        Dim brand As String = brandCbBox.Text
        Dim category As String = categoryCbBox.Text

        Try
            NavBox.Enabled = True

            If brand.Trim() = "" OrElse category = "" Then
                Me.MobileInvTableAdapter.Fill(Me.MobileInvDS.MobileInv)
            Else
                Me.MobileInvTableAdapter.FillBy_BrandNCategory(Me.MobileInvDS.MobileInv, brand, category)
            End If

            RefreshRowIndx()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Add_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Add_Btn.Click
        disable_add_edit_delete()
        Me.MobileInvBindingSource.AddNew()

        MobileInv_DGV.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
    End Sub

    Private Sub Update_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Update_Btn.Click
        disable_add_edit_delete()

        Dim rc As Integer = 0
        rc = Me.MobileInvDS.MobileInv.Rows.Count

        If rc = 0 Then
            MessageBox.Show("Please select your record to edit!", "Mobile - Inventory Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        MessageBox.Show("Edit mode is enabled!", "Mobile - Inventory Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MobileInv_DGV.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
    End Sub

    Private Function IsInputValid() As Boolean
        Dim currentRow As DataRowView =
            TryCast(Me.MobileInvBindingSource.Current, DataRowView)

        Dim requiredFields As String() = {
            "Brand",
            "Category",
            "Product",
            "Model",
            "Color",
            "Storage",
            "Unit",
            "RAM",
            "PurchasePrice",
            "SalePrice",
            "TaxRate",
            "ReorderLevel",
            "WarrantyMonths",
            "IsActive"
        }

        For Each field As String In requiredFields
            If currentRow(field) Is DBNull.Value OrElse String.IsNullOrWhiteSpace(currentRow(field).ToString) Then
                MessageBox.Show(field & " is required.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

                Select Case field
                    Case "Category"
                        categoryCbBox.Focus()
                    Case "Brand"
                        brandCbBox.Focus()
                End Select

                Return False
            End If
        Next

        Return True
    End Function

    'Private Sub MobileInv_DGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles MobileInv_DGV.CellEndEdit
    '    If e.RowIndex < 0 Then Exit Sub

    '    If Not IsInputValid() Then Exit Sub
    '    If Not CellValidation() Then Exit Sub
    'End Sub

    Private Function CellValidation() As Boolean
        Dim rowIndx As Integer = MobileInv_DGV.CurrentCell.RowIndex

        Dim purchasePrice As Decimal = CDec(MobileInv_DGV.Rows(rowIndx).Cells("dgv_purchase_price").Value)
        Dim salePrice As Decimal = CDec(MobileInv_DGV.Rows(rowIndx).Cells("dgv_sale_price").Value)

        If purchasePrice < 0 Then
            MessageBox.Show("Purchase Price must be a valid integer", "Mobile - Inventory Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        ElseIf salePrice < 0 Then
            MessageBox.Show("Sale Price must be a valid integer", "Mobile - Inventory Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        ElseIf purchasePrice > salePrice Then
            MessageBox.Show("Sale Price must be greater than Purchase Price", "Mobile - Inventory Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Return True
    End Function

    Private Sub Save_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Save_Btn.Click
        Try
            If Not IsInputValid() Then Exit Sub
            If Not CellValidation() Then Exit Sub

            enable_add_edit_delete()

            Me.Validate()
            Me.MobileInvBindingSource.EndEdit()
            Me.MobileInvTableAdapter.Update(Me.MobileInvDS.MobileInv)

            MessageBox.Show("Saved successfully!", "Mobile - Inventory Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Delete_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Delete_Btn.Click

        Try
            Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this record!" & vbNewLine & "Press Save After Deleting.", "Mobile - Inventory Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If confirm = Windows.Forms.DialogResult.Yes Then
                disable_add_edit_delete()
                Me.MobileInvBindingSource.RemoveCurrent()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Undo_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Undo_Btn.Click

        Try
            enable_add_edit_delete()
            Me.MobileInvTableAdapter.Fill(Me.MobileInvDS.MobileInv)
            Me.MobileInvBindingSource.RemoveCurrent()
            Me.MobileInvDS.MobileInv.RejectChanges()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub RefreshRowIndx()

        If Me.MobileInv_DGV.CurrentRow Is Nothing Then
            Exit Sub
        End If

        Me.ToCount.Text = MobileInv_DGV.RowCount
        Me.FromCount.Text = MobileInv_DGV.CurrentRow.Index + 1

        If MobileInv_DGV.CurrentRow.Index = 0 Then
            MoveFirstBtn.Enabled = False
            MovePrevBtn.Enabled = False

            moveNextBtn.Enabled = True
            moveLastBtn.Enabled = True

        End If

        If MobileInv_DGV.CurrentRow.Index > 0 Then
            MoveFirstBtn.Enabled = True
            MovePrevBtn.Enabled = True

            moveNextBtn.Enabled = True
            moveLastBtn.Enabled = True

        End If

        If Me.MobileInv_DGV.RowCount = MobileInv_DGV.CurrentRow.Index + 1 Then
            moveNextBtn.Enabled = False
            moveLastBtn.Enabled = False

            MoveFirstBtn.Enabled = True
            MovePrevBtn.Enabled = True

        End If
    End Sub

    Private Sub MobileDGV_SelectionChanged(sender As Object, e As EventArgs) Handles MobileInv_DGV.SelectionChanged

        RefreshRowIndx()
    End Sub

    Private Sub moveNextBtn_Click(sender As System.Object, e As System.EventArgs) Handles moveNextBtn.Click
        Me.MobileInvBindingSource.MoveNext()
        RefreshRowIndx()
    End Sub

    Private Sub moveLastBtn_Click(sender As System.Object, e As System.EventArgs) Handles moveLastBtn.Click
        Me.MobileInvBindingSource.MoveLast()
        RefreshRowIndx()

    End Sub

    Private Sub movePrevBtn_Click(sender As System.Object, e As System.EventArgs) Handles MovePrevBtn.Click
        Me.MobileInvBindingSource.MovePrevious()
        RefreshRowIndx()
    End Sub

    Private Sub moveFirstBtn_Click(sender As System.Object, e As System.EventArgs) Handles MoveFirstBtn.Click
        Me.MobileInvBindingSource.MoveFirst()
        RefreshRowIndx()
    End Sub
End Class
