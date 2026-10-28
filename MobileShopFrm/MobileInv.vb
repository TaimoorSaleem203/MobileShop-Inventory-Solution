Imports System.Data.SqlClient

Public Class InventorySol

    Dim connection As String = My.Settings.MobileShopConnectionString

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

                'Select Case field
                '    Case "Category"
                '        categoryCbBox.Focus()
                '    Case "Brand"
                '        brandCbBox.Focus()
                'End Select

                Return False
            End If
        Next

        Return True
    End Function

    Private Sub InventorySol_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InventoryItem_DataLoad()
    End Sub

    Private Sub InventoryItem_DataLoad()
        enable_add_edit_delete()

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

        Add_Btn.Enabled = False
        Update_Btn.Enabled = False
        Delete_Btn.Enabled = False
    End Sub

    Private Sub enable_add_edit_delete()
        Save_Btn.Enabled = False
        'undo_Btn.Enabled = False

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

    Private Function InvItem_Exist()

        Using conn As New SqlConnection(connection)
            conn.Open()

            Dim query As String = "SELECT COUNT(*) FROM MobileInv WHERE ProductID = @find"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@find", SqlDbType.Int).Value = GetProductID() + 1
                Return CInt(cmd.ExecuteScalar())
            End Using

        End Using

    End Function

    Private Function IsBlank(value As Object) As Boolean

        Return value Is Nothing OrElse
               value Is DBNull.Value OrElse
               String.IsNullOrWhiteSpace(value.ToString())

    End Function

    Private Sub Add_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Add_Btn.Click

        Dim frm As New InvEntry
        frm.ShowDialog()

        frm.newItemBtn.Enabled = False
        frm.deleteItemBtn.Enabled = False

        frm.Dispose()

    End Sub

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click

        Try
            If MobileInv_DGV.CurrentCell Is Nothing Then Exit Sub
            Dim rowIndx As Integer = MobileInv_DGV.CurrentCell.RowIndex
            If rowIndx < 0 Then Exit Sub

            Using conn As New SqlConnection(connection)

                conn.Open()

                Using transaction As SqlTransaction = conn.BeginTransaction()

                    Try

                        For Each row As DataGridViewRow In MobileInv_DGV.Rows

                            If row.IsNewRow Then
                                Continue For
                            End If


                            Dim productIDVal As Object =
                                row.Cells("dgv_productID").Value

                            Dim productVal As Object =
                                row.Cells("dgv_product").Value

                            Dim categoryVal As Object =
                                row.Cells("dgv_category").Value

                            Dim brandVal As Object =
                                row.Cells("dgv_brand").Value

                            Dim modelVal As Object =
                                row.Cells("dgv_model").Value

                            Dim colorVal As Object =
                                row.Cells("dgv_color").Value

                            Dim storageVal As Object =
                                row.Cells("dgv_storage").Value

                            Dim unitVal As Object =
                                row.Cells("dgv_unit").Value

                            Dim ramVal As Object =
                                row.Cells("dgv_Ram").Value

                            Dim purchaseVal As Object =
                                row.Cells("dgv_purchase_price").Value

                            Dim saleVal As Object =
                                row.Cells("dgv_sale_price").Value

                            Dim warrantyVal As Object =
                                row.Cells("dgv_warranty_months").Value

                            Dim activeVal As Object =
                                row.Cells("dgv_isactive").Value


                            If IsBlank(productVal) Then
                                MessageBox.Show("Enter a valid product name.")
                                transaction.Rollback()
                                Exit Sub
                            End If

                            If IsBlank(categoryVal) Then
                                MessageBox.Show("Enter a valid category name.")
                                transaction.Rollback()
                                Exit Sub
                            End If

                            If IsBlank(brandVal) Then
                                MessageBox.Show("Enter a valid brand name.")
                                transaction.Rollback()
                                Exit Sub
                            End If

                            If IsBlank(modelVal) Then
                                MessageBox.Show("Enter a valid model name.")
                                transaction.Rollback()
                                Exit Sub
                            End If

                            If IsBlank(colorVal) Then
                                MessageBox.Show("Enter a valid color.")
                                transaction.Rollback()
                                Exit Sub
                            End If

                            If IsBlank(storageVal) Then
                                MessageBox.Show("Enter a valid storage value.")
                                transaction.Rollback()
                                Exit Sub
                            End If

                            If IsBlank(unitVal) Then
                                MessageBox.Show("Enter a valid unit.")
                                transaction.Rollback()
                                Exit Sub
                            End If

                            If IsBlank(ramVal) Then
                                MessageBox.Show("Enter a valid RAM value.")
                                transaction.Rollback()
                                Exit Sub
                            End If

                            If IsBlank(purchaseVal) Then
                                MessageBox.Show("Enter a valid purchase price.")
                                transaction.Rollback()
                                Exit Sub
                            End If

                            If IsBlank(saleVal) Then
                                MessageBox.Show("Enter a valid sale price.")
                                transaction.Rollback()
                                Exit Sub
                            End If

                            If IsBlank(warrantyVal) Then
                                MessageBox.Show("Enter a valid warranty period.")
                                transaction.Rollback()
                                Exit Sub
                            End If

                            Dim product As String =
                                Convert.ToString(productVal).Trim()

                            Dim category As String =
                                Convert.ToString(categoryVal).Trim()

                            Dim brand As String =
                                Convert.ToString(brandVal).Trim()

                            Dim model As String =
                                Convert.ToString(modelVal).Trim()

                            Dim color As String =
                                Convert.ToString(colorVal).Trim()

                            Dim storage As String =
                                Convert.ToString(storageVal).Trim()

                            Dim unit As String =
                                Convert.ToString(unitVal).Trim()

                            Dim ram As String =
                                Convert.ToString(ramVal).Trim()

                            Dim purchasePrice As Decimal =
                                Convert.ToDecimal(purchaseVal)

                            Dim salePrice As Decimal =
                                Convert.ToDecimal(saleVal)

                            Dim warrantyMonths As Integer =
                                Convert.ToInt32(warrantyVal)

                            Dim isActive As Boolean =
                                Convert.ToBoolean(activeVal)

                            If productIDVal Is Nothing OrElse
                               productIDVal Is DBNull.Value OrElse
                               String.IsNullOrWhiteSpace(productIDVal.ToString()) Then

                                Dim insertQuery As String =
                                    "INSERT INTO MobileInv " &
                                    "([Product], [Category], [Brand], [Model], [Color], " &
                                    "[Storage], [RAM], [Unit], [PurchasePrice], [SalePrice], " &
                                    "[WarrantyMonths], [IsActive]) " &
                                    "VALUES " &
                                    "(@Product, @Category, @Brand, @Model, @Color, " &
                                    "@Storage, @RAM, @Unit, @PurchasePrice, @SalePrice, " &
                                    "@WarrantyMonths, @IsActive); " &
                                    "SELECT CAST(SCOPE_IDENTITY() AS INT);"


                                Using cmd As New SqlCommand(
                                    insertQuery,
                                    conn,
                                    transaction)

                                    cmd.Parameters.Add("@Product", SqlDbType.NVarChar, 120).Value = product
                                    cmd.Parameters.Add("@Category", SqlDbType.NVarChar, 120).Value = category
                                    cmd.Parameters.Add("@Brand", SqlDbType.NVarChar, 120).Value = brand
                                    cmd.Parameters.Add("@Model", SqlDbType.NVarChar, 120).Value = model
                                    cmd.Parameters.Add("@Color", SqlDbType.NVarChar, 120).Value = color
                                    cmd.Parameters.Add("@Storage", SqlDbType.NVarChar, 120).Value = storage
                                    cmd.Parameters.Add("@RAM", SqlDbType.NVarChar, 120).Value = ram
                                    cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 20).Value = unit

                                    cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal).Value = purchasePrice
                                    cmd.Parameters.Add("@SalePrice", SqlDbType.Decimal).Value = salePrice

                                    cmd.Parameters.Add("@WarrantyMonths", SqlDbType.Int).Value = warrantyMonths
                                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive


                                    Dim newProductID As Integer =
                                        Convert.ToInt32(cmd.ExecuteScalar())

                                    row.Cells("dgv_productID").Value =
                                        newProductID

                                End Using


                            Else

                                Dim productID As Integer

                                If Not Integer.TryParse(
                                    productIDVal.ToString(),
                                    productID) Then

                                    Continue For

                                End If


                                Dim updateQuery As String =
                                    "UPDATE MobileInv SET " &
                                    "[Product] = @Product, " &
                                    "[Category] = @Category, " &
                                    "[Brand] = @Brand, " &
                                    "[Model] = @Model, " &
                                    "[Color] = @Color, " &
                                    "[Storage] = @Storage, " &
                                    "[RAM] = @RAM, " &
                                    "[Unit] = @Unit, " &
                                    "[PurchasePrice] = @PurchasePrice, " &
                                    "[SalePrice] = @SalePrice, " &
                                    "[WarrantyMonths] = @WarrantyMonths, " &
                                    "[IsActive] = @IsActive " &
                                    "WHERE ProductID = @ProductID"


                                Using cmd As New SqlCommand(
                                    updateQuery,
                                    conn,
                                    transaction)

                                    cmd.Parameters.Add("@Product", SqlDbType.NVarChar, 120).Value = product
                                    cmd.Parameters.Add("@Category", SqlDbType.NVarChar, 120).Value = category
                                    cmd.Parameters.Add("@Brand", SqlDbType.NVarChar, 120).Value = brand
                                    cmd.Parameters.Add("@Model", SqlDbType.NVarChar, 120).Value = model
                                    cmd.Parameters.Add("@Color", SqlDbType.NVarChar, 120).Value = color
                                    cmd.Parameters.Add("@Storage", SqlDbType.NVarChar, 120).Value = storage
                                    cmd.Parameters.Add("@RAM", SqlDbType.NVarChar, 120).Value = ram
                                    cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 20).Value = unit

                                    cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal).Value = purchasePrice
                                    cmd.Parameters.Add("@SalePrice", SqlDbType.Decimal).Value = salePrice

                                    cmd.Parameters.Add("@WarrantyMonths", SqlDbType.Int).Value = warrantyMonths
                                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive

                                    cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value =
                                        productID


                                    cmd.ExecuteNonQuery()

                                End Using

                            End If

                        Next

                        transaction.Commit()

                        InventoryItem_DataLoad()

                        enable_add_edit_delete()


                        MessageBox.Show(
                            "Inventory saved successfully!",
                            "Mobile Inventory",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )


                    Catch

                        transaction.Rollback()
                        Throw

                    End Try

                End Using

            End Using


        Catch ex As Exception

            MessageBox.Show(
                "Error: " & ex.Message,
                "Error Alert!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub Delete_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Delete_Btn.Click

        Try
            Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this record!", "Mobile - Inventory Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If confirm = Windows.Forms.DialogResult.Yes Then
                Try
                    Dim indx As Integer = Val(MobileInv_DGV.CurrentCell.RowIndex)
                    If indx < 0 Then Exit Sub

                    Using conn As New SqlConnection(connection)
                        conn.Open()

                        Dim query As String = "DELETE FROM MobileInv WHERE ProductID = @find"

                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.Add("@find", SqlDbType.Int).Value = Val(MobileInv_DGV.Rows(indx).Cells("dgv_productID").Value)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    enable_add_edit_delete()
                    InventoryItem_DataLoad()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Undo_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Undo_Btn.Click

        Try
            enable_add_edit_delete()
            InventoryItem_DataLoad()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Update_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Update_Btn.Click
        disable_add_edit_delete()

        Dim rc As Integer = 0
        rc = Me.MobileInv_DGV.Rows.Count

        If rc = 0 Then
            MessageBox.Show("Please select your record to edit!", "Mobile - Inventory Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        MessageBox.Show("Edit mode is enabled!", "Mobile - Inventory Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MobileInv_DGV.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
    End Sub

    Private Sub MobileInv_DGV_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles MobileInv_DGV.DataError
        e.ThrowException = False

        MessageBox.Show("Enter a valid input!", "Mobile Form", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub

    Private Sub MobileDGV_SelectionChanged(sender As Object, e As EventArgs) Handles MobileInv_DGV.SelectionChanged

        Try
            Dim rowIndx As Integer = Val(MobileInv_DGV.CurrentCell.RowIndex)
            Dim productIDValue As Object = (MobileInv_DGV.Rows(rowIndx).Cells("dgv_productID").Value)

            If rowIndx < 0 Then Exit Sub

            If MobileInv_DGV.CurrentCell Is Nothing OrElse MobileInv_DGV.Rows(rowIndx).IsNewRow Then
                'clearEntries()
                Exit Sub
            End If

            If productIDValue Is Nothing OrElse productIDValue Is DBNull.Value Then Exit Sub

            Dim productID As Integer
            Integer.TryParse(productIDValue, productID)

            Using conn As New SqlConnection(connection)
                conn.Open()
                Dim query As String = "SELECT Product, Category, Brand, PurchasePrice, SalePrice, IsActive FROM MobileInv WHERE ProductID = @find"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@find", SqlDbType.Int).Value = productID

                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.HasRows Then
                            If rdr.Read() Then
                                ProductTextBox.Text = rdr("Product")
                                CategoryTextBox.Text = rdr("Category")
                                BrandTextBox.Text = rdr("Brand")
                                'PurchasePriceTextBox.Text = rdr("PurchasePrice")
                                'SalePriceTextBox.Text = rdr("SalePrice")
                                'IsActiveCheckBox.Checked = If(Val(rdr("IsActive")) = 1, True, False)
                            End If
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        RefreshRowIndx()
    End Sub

    Private Sub MobileInv_DGV_CellValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles MobileInv_DGV.CellValidating

        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim purchasePrice As Decimal
        Dim salePrice As Decimal

        If MobileInv_DGV.Columns(e.ColumnIndex).HeaderText = "SalePrice" Then

            Dim saleVal As Object = MobileInv_DGV.Rows(e.RowIndex).Cells("dgv_sale_price").Value
            Dim purchaseVal As Object = MobileInv_DGV.Rows(e.RowIndex).Cells("dgv_purchase_price").Value

            If purchaseVal Is Nothing OrElse purchaseVal Is DBNull.Value Then
                Exit Sub
            End If

            If saleVal Is Nothing OrElse saleVal Is DBNull.Value Then
                Exit Sub
            End If

            Decimal.TryParse(purchaseVal, purchasePrice)
            Decimal.TryParse(e.FormattedValue.ToString, salePrice)

            If purchasePrice > salePrice Then
                MessageBox.Show("Sale Price must be greater or equal than Purchase Price!", "Mobile - Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
            End If
        End If

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
