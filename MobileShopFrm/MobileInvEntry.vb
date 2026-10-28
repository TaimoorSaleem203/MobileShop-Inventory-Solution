Imports System.Data.SqlClient

Public Class InvEntry

    Dim connection As String = My.Settings.MobileShopConnectionString

    Private Sub InvEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ProductIDTextBox.Text = GetProductID()
    End Sub

    Private Function GetProductID() As Integer

        Using conn As New SqlConnection(connection)
            conn.Open()

            Dim query As String = "SELECT ISNULL(MAX(ProductID),100) + 1 AS MAX_ID FROM MobileInv"

            Using cmd As New SqlCommand(query, conn)
                Return CInt(cmd.ExecuteScalar())
            End Using

        End Using

    End Function

    Private Sub clearEntries()
        ProductIDTextBox.Text = ""
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

    Private Sub saveItemBtn_Click(sender As System.Object, e As System.EventArgs) Handles saveItemBtn.Click
        Try
            Using conn As New SqlConnection(connection)

                conn.Open()

                Using transaction As SqlTransaction = conn.BeginTransaction()

                    Try
                        Dim productIDVal As Integer = CInt(ProductIDTextBox.Text)
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

                        If String.IsNullOrWhiteSpace(productVal) Then
                            MessageBox.Show("Enter a valid product name.")
                            transaction.Rollback()
                            Exit Sub
                        End If

                        If String.IsNullOrWhiteSpace(categoryVal) Then
                            MessageBox.Show("Enter a valid category name.")
                            transaction.Rollback()
                            Exit Sub
                        End If

                        If String.IsNullOrWhiteSpace(brandVal) Then
                            MessageBox.Show("Enter a valid brand name.")
                            transaction.Rollback()
                            Exit Sub
                        End If

                        If String.IsNullOrWhiteSpace(modelVal) Then
                            MessageBox.Show("Enter a valid model name.")
                            transaction.Rollback()
                            Exit Sub
                        End If

                        If String.IsNullOrWhiteSpace(colorVal) Then
                            MessageBox.Show("Enter a valid color.")
                            transaction.Rollback()
                            Exit Sub
                        End If

                        If String.IsNullOrWhiteSpace(storageVal) Then
                            MessageBox.Show("Enter a valid storage value.")
                            transaction.Rollback()
                            Exit Sub
                        End If

                        If String.IsNullOrWhiteSpace(unitVal) Then
                            MessageBox.Show("Enter a valid unit.")
                            transaction.Rollback()
                            Exit Sub
                        End If

                        If String.IsNullOrWhiteSpace(ramVal) Then
                            MessageBox.Show("Enter a valid RAM value.")
                            transaction.Rollback()
                            Exit Sub
                        End If

                        If String.IsNullOrWhiteSpace(purchaseVal) Then
                            MessageBox.Show("Enter a valid purchase price.")
                            transaction.Rollback()
                            Exit Sub
                        End If

                        If String.IsNullOrWhiteSpace(saleVal) Then
                            MessageBox.Show("Enter a valid sale price.")
                            transaction.Rollback()
                            Exit Sub
                        End If

                        If String.IsNullOrWhiteSpace(warrantyVal) Then
                            MessageBox.Show("Enter a valid warranty period.")
                            transaction.Rollback()
                            Exit Sub
                        End If

                        If String.IsNullOrWhiteSpace(productIDVal.ToString()) Then

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


                            End Using


                        Else

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
                                cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value =
                                    productIDVal


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
End Class