Imports System.Data.SqlClient

Public Class InvEntry
    Dim connection As String = My.Settings.MobileShopConnectionString
    Public PRODUCT_ID As Integer
    Public BTN_NAME As String

    Private Sub InvEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If BTN_NAME = "Update_Btn" Then
            InventoryItem_DataLoad(PRODUCT_ID)
        End If
    End Sub

    Private Sub InventoryItem_DataLoad(Optional productID As Integer = 0)
        Using conn As New SqlConnection(connection)
            conn.Open()

            Dim dataQuery As String = "SELECT [ProductID],[Product],[Category],[Brand],[Model],[Color],[Storage],[RAM]" &
                ",[Unit],[PurchasePrice],[SalePrice],[WarrantyMonths],[IsActive] FROM [MobileShop].[dbo].[MobileInv] WHERE (@find = 0 OR [ProductID] = @find)"

            Dim invTable As New DataTable()

            Using cmd As New SqlCommand(dataQuery, conn)
                cmd.Parameters.Add("@find", SqlDbType.Int).Value = productID

                Using adp As New SqlDataAdapter(cmd)
                    adp.Fill(invTable)
                End Using

                MobileInvBindingSource.DataSource = invTable
            End Using

        End Using
    End Sub

    Private Sub clearEntries()
        ProductIDTextBox.Text = ""
        ProductIDTextBox.Enabled = False

        ProductTextBox.Text = ""
        CategoryTextBox.Text = ""
        BrandTextBox.Text = ""
        ModelTextBox.Text = ""
        ColorComboBox.Text = ""
        StorageComboBox.Text = ""
        UnitComboBox.Text = ""
        RAMComboBox.Text = ""
        WarrantyMonthsTextBox.Text = ""
        PurchasePriceTextBox.Text = ""
        SalePriceTextBox.Text = ""
        IsActiveCheckBox.Checked = False
    End Sub

    Private Sub newItemBtn_Click(sender As System.Object, e As System.EventArgs) Handles newItemBtn.Click
        clearEntries()
    End Sub

    Private Sub saveItemBtn_Click(sender As System.Object, e As System.EventArgs) Handles saveItemBtn.Click
        Try
            If String.IsNullOrWhiteSpace(ProductTextBox.Text) Then
                MessageBox.Show("Enter a valid product name.", "Mobile - Product Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ProductTextBox.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(CategoryTextBox.Text) Then
                MessageBox.Show("Enter a valid category name.", "Mobile - Product Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CategoryTextBox.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(BrandTextBox.Text) Then
                MessageBox.Show("Enter a valid brand name.", "Mobile - Product Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BrandTextBox.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(ModelTextBox.Text) Then
                MessageBox.Show("Enter a valid model name.", "Mobile - Product Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ModelTextBox.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(ColorComboBox.Text) Then
                MessageBox.Show("Enter a valid color.", "Mobile - Product Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ColorComboBox.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(StorageComboBox.Text) Then
                MessageBox.Show("Enter a valid storage value.", "Mobile - Product Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                StorageComboBox.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(UnitComboBox.Text) Then
                MessageBox.Show("Enter a valid unit.", "Mobile - Product Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UnitComboBox.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(RAMComboBox.Text) Then
                MessageBox.Show("Enter a valid RAM value.", "Mobile - Product Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RAMComboBox.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(WarrantyMonthsTextBox.Text) Then
                MessageBox.Show("Enter a valid warranty period.", "Mobile - Product Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                WarrantyMonthsTextBox.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(PurchasePriceTextBox.Text) Then
                MessageBox.Show("Enter a valid purchase price.", "Mobile - Product Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PurchasePriceTextBox.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(SalePriceTextBox.Text) Then
                MessageBox.Show("Enter a valid sale price.", "Mobile - Product Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SalePriceTextBox.Focus()
                Exit Sub
            End If

            If Val(PurchasePriceTextBox.Text) > Val(SalePriceTextBox.Text) Then
                MessageBox.Show("Sale price must be greater or equal to Purchase Price.", "Mobile - Product Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SalePriceTextBox.Focus()
                Exit Sub
            End If

            Using conn As New SqlConnection(connection)

                conn.Open()

                Using transaction As SqlTransaction = conn.BeginTransaction()

                    Try
                        Dim productVal As String = CStr(ProductTextBox.Text)
                        Dim categoryVal As String = CStr(CategoryTextBox.Text)
                        Dim brandVal As String = CStr(BrandTextBox.Text)
                        Dim modelVal As String = CStr(ModelTextBox.Text)
                        Dim colorVal As String = CStr(ColorComboBox.Text)
                        Dim storageVal As String = CStr(StorageComboBox.Text)
                        Dim unitVal As String = CStr(UnitComboBox.Text)
                        Dim ramVal As String = CStr(RAMComboBox.Text)
                        Dim warrantyVal As Integer = CInt(WarrantyMonthsTextBox.Text)
                        Dim purchaseVal As Decimal = CDec(PurchasePriceTextBox.Text)
                        Dim saleVal As Decimal = CDec(SalePriceTextBox.Text)
                        Dim active As Integer = CInt(If(IsActiveCheckBox.Checked, 1, 0))

                        If String.IsNullOrWhiteSpace(ProductIDTextBox.Text) Then

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

                                cmd.Parameters.Add("@Product", SqlDbType.NVarChar, 120).Value = productVal
                                cmd.Parameters.Add("@Category", SqlDbType.NVarChar, 120).Value = categoryVal
                                cmd.Parameters.Add("@Brand", SqlDbType.NVarChar, 120).Value = brandVal
                                cmd.Parameters.Add("@Model", SqlDbType.NVarChar, 120).Value = modelVal
                                cmd.Parameters.Add("@Color", SqlDbType.NVarChar, 120).Value = colorVal
                                cmd.Parameters.Add("@Storage", SqlDbType.NVarChar, 120).Value = storageVal
                                cmd.Parameters.Add("@RAM", SqlDbType.NVarChar, 120).Value = ramVal
                                cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 20).Value = unitVal
                                cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal).Value = purchaseVal
                                cmd.Parameters.Add("@SalePrice", SqlDbType.Decimal).Value = saleVal
                                cmd.Parameters.Add("@WarrantyMonths", SqlDbType.Int).Value = warrantyVal
                                cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = active

                                ProductIDTextBox.Text = Val(cmd.ExecuteScalar())
                            End Using

                        Else

                            Dim productIDVal As Integer = Val(ProductIDTextBox.Text)

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
                                "WHERE [ProductID] = @ProductID"


                            Using cmd As New SqlCommand(
                                updateQuery,
                                conn,
                                transaction)

                                cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar, 120).Value = productIDVal
                                cmd.Parameters.Add("@Product", SqlDbType.NVarChar, 120).Value = productVal
                                cmd.Parameters.Add("@Category", SqlDbType.NVarChar, 120).Value = categoryVal
                                cmd.Parameters.Add("@Brand", SqlDbType.NVarChar, 120).Value = brandVal
                                cmd.Parameters.Add("@Model", SqlDbType.NVarChar, 120).Value = modelVal
                                cmd.Parameters.Add("@Color", SqlDbType.NVarChar, 120).Value = colorVal
                                cmd.Parameters.Add("@Storage", SqlDbType.NVarChar, 120).Value = storageVal
                                cmd.Parameters.Add("@RAM", SqlDbType.NVarChar, 120).Value = ramVal
                                cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 20).Value = unitVal
                                cmd.Parameters.Add("@PurchasePrice", SqlDbType.Decimal).Value = purchaseVal
                                cmd.Parameters.Add("@SalePrice", SqlDbType.Decimal).Value = saleVal
                                cmd.Parameters.Add("@WarrantyMonths", SqlDbType.Int).Value = warrantyVal
                                cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = active

                                cmd.ExecuteNonQuery()

                            End Using

                        End If

                        transaction.Commit()

                        MessageBox.Show(
                            "Inventory saved successfully!",
                            "Mobile Inventory",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )

                        clearEntries()
                        Me.DialogResult = DialogResult.OK
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

    Private Sub showItemBtn_Click(sender As System.Object, e As System.EventArgs) Handles showItemBtn.Click
        InventoryItem_DataLoad()
    End Sub

End Class