Imports System.Data.SqlClient

Public Class InventorySol

    Dim connection As String = My.Settings.MobileShopConnectionString
    Dim ID As Integer

    Private Sub InventorySol_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InventoryItem_DataLoad()
    End Sub

    Private Sub InventoryItem_DataLoad()

        Using conn As New SqlConnection(connection)
            conn.Open()
            Dim dataQuery As String = "SELECT [ProductID],[Product],[Category],[Brand],[Model],[Color],[Storage],[RAM]" &
                ",[Unit],[PurchasePrice],[SalePrice],[WarrantyMonths],[IsActive] FROM [MobileShop].[dbo].[MobileInv]"

            Using cmd As New SqlCommand(dataQuery, conn)
                Dim invTable As New DataTable()

                Using adp As New SqlDataAdapter(cmd)
                    adp.Fill(invTable)
                End Using

                MobileInv_DGV.DataSource = invTable
                cmd.ExecuteNonQuery()
            End Using

        End Using

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
        'Undo_Btn.Enabled = True
        MobileInv_DGV.EditMode = DataGridViewEditMode.EditProgrammatically

        Add_Btn.Enabled = False
        Update_Btn.Enabled = False
        Delete_Btn.Enabled = False
    End Sub

    Private Sub enable_add_edit_delete()
        Save_Btn.Enabled = False
        'undo_Btn.Enabled = False
        MobileInv_DGV.EditMode = DataGridViewEditMode.EditProgrammatically

        Add_Btn.Enabled = True
        Update_Btn.Enabled = True
        Delete_Btn.Enabled = True
        Undo_Btn.Enabled = True
    End Sub

    Private Function GetProductID() As Integer
        Using conn As New SqlConnection(connection)
            conn.Open()

            Dim query As String = "SELECT ISNULL(MAX(ProductID),100) FROM MobileInv"

            Using cmd As New SqlCommand(query, conn)
                Return CInt(cmd.ExecuteScalar())
            End Using

        End Using
    End Function

    Private Sub Add_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Add_Btn.Click
        disable_add_edit_delete()

        'Dim productID As Integer = GetProductID()
        'MobileInv_DGV.Rows(MobileInv_DGV.Rows.Count - 1).Cells("dgv_productID").Value = productID

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

    'Private Function IsInputValid() As Boolean
    '    Dim currentRow As DataRowView =
    '        TryCast(Me.MobileInvBindingSource.Current, DataRowView)

    '    Dim requiredFields As String() = {
    '        "Brand",
    '        "Category",
    '        "Product",
    '        "Model",
    '        "Color",
    '        "Storage",
    '        "Unit",
    '        "RAM",
    '        "PurchasePrice",
    '        "SalePrice",
    '        "TaxRate",
    '        "ReorderLevel",
    '        "WarrantyMonths",
    '        "IsActive"
    '    }

    '    For Each field As String In requiredFields
    '        If currentRow(field) Is DBNull.Value OrElse String.IsNullOrWhiteSpace(currentRow(field).ToString) Then
    '            MessageBox.Show(field & " is required.",
    '            "Validation",
    '            MessageBoxButtons.OK,
    '            MessageBoxIcon.Warning)

    '            Select Case field
    '                Case "Category"
    '                    categoryCbBox.Focus()
    '                Case "Brand"
    '                    brandCbBox.Focus()
    '            End Select

    '            Return False
    '        End If
    '    Next

    '    Return True
    'End Function

    Private Sub MobileInv_DGV_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles MobileInv_DGV.DataError
        e.ThrowException = False

        MessageBox.Show("Enter a valid input!", "Mobile Form", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub

    Private Function InvItem_Exist(productID As Integer)

        Using conn As New SqlConnection(connection)
            conn.Open()

            Dim query As String = "SELECT COUNT(*) FROM MobileInv WHERE ProductID = @find"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@find", SqlDbType.Int).Value = productID
                Return CInt(cmd.ExecuteScalar())
            End Using

        End Using

    End Function

    Private Function IsBlank(value As Object) As Boolean

        Return value Is Nothing OrElse
               value Is DBNull.Value OrElse
               String.IsNullOrWhiteSpace(value.ToString())

    End Function

    Private Sub Save_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Save_Btn.Click
        Try
            Dim rowIndx As Integer = MobileInv_DGV.CurrentCell.RowIndex

            If MobileInv_DGV.CurrentCell Is Nothing Then Exit Sub
            If rowIndx < 0 Then Exit Sub

            'Dim idVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_product_id").Value
            Dim productVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_product").Value
            Dim categoryVal As String = MobileInv_DGV.Rows(rowIndx).Cells("dgv_category").Value
            Dim brandVal As String = MobileInv_DGV.Rows(rowIndx).Cells("dgv_brand").Value
            Dim modelVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_model").Value
            Dim colorVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_color").Value
            Dim storageVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_storage").Value
            Dim unitVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_unit").Value
            Dim ramVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_Ram").Value
            Dim purchaseVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_purchase_price").Value
            Dim saleVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_sale_price").Value
            'Dim taxVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_tax_rate").Value
            'Dim reorderVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_reorder_level").Value
            Dim warrantyVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_warranty_months").Value
            Dim activeVal As Object = MobileInv_DGV.Rows(rowIndx).Cells("dgv_isactive").Value

            'If IsBlank(idVal) Then
            'MessageBox.Show("Enter a valid product id.", "MobileInv",
            '               MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Exit Sub
            'End If

            If IsBlank(productVal) Then
                MessageBox.Show("Enter a valid product name.", "MobileInv",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsBlank(categoryVal) Then
                MessageBox.Show("Enter a valid category name.", "MobileInv",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsBlank(brandVal) Then
                MessageBox.Show("Enter a valid brand name.", "MobileInv",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsBlank(categoryVal) Then
                MessageBox.Show("Enter a valid category name.", "MobileInv",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsBlank(modelVal) Then
                MessageBox.Show("Enter a valid model name.", "MobileInv",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsBlank(colorVal) Then
                MessageBox.Show("Enter a valid color.", "MobileInv",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsBlank(storageVal) Then
                MessageBox.Show("Enter a valid storage value.", "MobileInv",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsBlank(unitVal) Then
                MessageBox.Show("Enter a valid unit.", "MobileInv",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsBlank(ramVal) Then
                MessageBox.Show("Enter a valid RAM value.", "MobileInv",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsBlank(purchaseVal) Then
                MessageBox.Show("Enter a valid purchase price.", "MobileInv",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsBlank(saleVal) Then
                MessageBox.Show("Enter a valid sale price.", "MobileInv",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'If IsBlank(taxVal) Then
            '    MessageBox.Show("Enter a valid tax rate.", "MobileInv",
            '                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            'If IsBlank(reorderVal) Then
            '    MessageBox.Show("Enter a valid reorder level.", "MobileInv",
            '                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            If IsBlank(warrantyVal) Then
                MessageBox.Show("Enter a valid warranty period.", "MobileInv",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If IsBlank(activeVal) Then
                MessageBox.Show("Select the active status.", "MobileInv",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'Dim productID As Integer = Convert.ToInt32(idVal)
            Dim product As String = Convert.ToString(productVal).Trim()
            Dim model As String = Convert.ToString(modelVal).Trim()
            Dim color As String = Convert.ToString(colorVal).Trim()
            Dim storage As String = Convert.ToString(storageVal).Trim()
            Dim unit As String = Convert.ToString(unitVal).Trim()
            Dim ram As String = Convert.ToString(ramVal).Trim()

            Dim purchasePrice As Decimal = Convert.ToDecimal(purchaseVal)
            Dim salePrice As Decimal = Convert.ToDecimal(saleVal)
            'Dim taxRate As Decimal = Convert.ToDecimal(taxVal)

            'Dim reorderLevel As Integer = Convert.ToInt32(reorderVal)
            Dim warrantyMonths As Integer = Convert.ToInt32(warrantyVal)

            Dim isActive As Boolean = Convert.ToBoolean(activeVal)

            Using conn As New SqlConnection(connection)
                conn.Open()

                'Dim itemExist As Integer = InvItem_Exist(ID)

                Dim insertQuery As String = "INSERT INTO MobileInv " &
               "([Product], [Category], [Brand], [Model], [Color], [Storage], [RAM], [Unit], [PurchasePrice], " &
               "[SalePrice], [WarrantyMonths], [IsActive]) " &
               "VALUES (@Product, @Category, @Brand, @Model, @Color, @Storage, @RAM, @Unit, @PurchasePrice, @SalePrice, " &
               "@WarrantyMonths, @IsActive); SELECT CAST(SCOPE_IDENTITY() AS INT);"

                'If itemExist = 0 Then
                Using cmd As New SqlCommand(insertQuery, conn)
                    'cmd.Parameters.Add("@ProductID", SqlDbType.Int  ).Value = productID
                    cmd.Parameters.Add("@Product", SqlDbType.NVarChar).Value = product
                    cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value = categoryVal
                    cmd.Parameters.Add("@Brand", SqlDbType.NVarChar).Value = brandVal
                    cmd.Parameters.Add("@Model", SqlDbType.NVarChar).Value = model
                    cmd.Parameters.Add("@Color", SqlDbType.NVarChar).Value = color
                    cmd.Parameters.Add("@Storage", SqlDbType.NVarChar).Value = storage
                    cmd.Parameters.Add("@RAM", SqlDbType.NVarChar).Value = ram
                    cmd.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = unit
                    cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal).Value = purchasePrice
                    cmd.Parameters.Add("@SalePrice", SqlDbType.Decimal).Value = salePrice
                    'cmd.Parameters.Add("@ReorderLevel", SqlDbType.Int).Value = reorderLevel
                    cmd.Parameters.Add("@WarrantyMonths", SqlDbType.Int).Value = warrantyMonths
                    'cmd.Parameters.Add("@TaxRate", SqlDbType.Int).Value = taxRate
                    cmd.Parameters.Add("@IsActive", SqlDbType.Int).Value = isActive

                    cmd.ExecuteNonQuery()
                End Using
                'End If
            End Using

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
