Public Class PartytList


    Private Sub PartytList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MobilePartyDS.MobileParty' table. You can move, or remove it, as needed.
        Me.MobilePartyTableAdapter.Fill(Me.MobilePartyDS.MobileParty)
        enable_add_edit_delete()

        Me.KeyPreview = True
    End Sub

    Private Sub Action_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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
        MobileParty_DGV.EditMode = DataGridViewEditMode.EditProgrammatically

        Add_Btn.Enabled = False
        Update_Btn.Enabled = False
        Delete_Btn.Enabled = False

        PartyTextBox.ReadOnly = False
        AddressTextBox.ReadOnly = False
        CommentTextBox.ReadOnly = False
    End Sub

    Private Sub enable_add_edit_delete()
        Save_Btn.Enabled = False
        MobileParty_DGV.EditMode = DataGridViewEditMode.EditProgrammatically

        Add_Btn.Enabled = True
        Update_Btn.Enabled = True
        Delete_Btn.Enabled = True
        Undo_Btn.Enabled = True

        PartyTextBox.ReadOnly = True
        AddressTextBox.ReadOnly = True
        CommentTextBox.ReadOnly = True
    End Sub

    Private Sub Add_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Add_Btn.Click
        disable_add_edit_delete()
        Me.MobilePartyBindingSource.AddNew()

        MobileParty_DGV.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
    End Sub

    Private Sub Update_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Update_Btn.Click
        disable_add_edit_delete()

        Dim rc As Integer = 0
        rc = Me.MobilePartyDS.MobileParty.Rows.Count

        If rc = 0 Then
            MessageBox.Show("Please select your record to edit!", "Mobile - Inventory Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        MessageBox.Show("Edit mode is enabled!", "Mobile - Inventory Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MobileParty_DGV.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
    End Sub

    Private Function IsInputValid() As Boolean
        Dim currentRow As DataRowView =
            TryCast(Me.MobilePartyBindingSource.Current, DataRowView)

        Dim requiredFields As String() = {
            "Product",
            "Address",
            "Comment"
        }

        For Each field As String In requiredFields
            If currentRow(field) Is DBNull.Value OrElse String.IsNullOrWhiteSpace(currentRow(field).ToString) Then
                MessageBox.Show(field & " is required.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

                Return False
            End If
        Next

        Return True
    End Function

    Private Sub MobileParty_DGV_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles MobileParty_DGV.DataError
        e.ThrowException = False

        MessageBox.Show("Enter a valid input!", "Mobile Form", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub Save_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Save_Btn.Click
        Try

            enable_add_edit_delete()

            Me.Validate()
            Me.MobilePartyBindingSource.EndEdit()
            Me.MobilePartyTableAdapter.Update(Me.MobilePartyDS.MobileParty)

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
                Me.MobilePartyBindingSource.RemoveCurrent()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Undo_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Undo_Btn.Click

        Try
            enable_add_edit_delete()
            Me.MobilePartyTableAdapter.Fill(Me.MobilePartyDS.MobileParty)
            Me.MobilePartyBindingSource.RemoveCurrent()
            Me.MobilePartyDS.MobileParty.RejectChanges()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

End Class