Imports System.Data.SqlClient

Public Class SaleList

    Dim connection As String = My.Settings.MobileShopConnectionString

    Dim rdr As SqlDataReader = Nothing 'Reads records returned by a SQL query, one row at a time.
    Dim adpt As SqlDataAdapter 'Transfers data between SQL Server and in-memory data objects such as a DataTable or DataSet.
    Dim cmd As SqlCommand = Nothing  'Represents a SQL statement or stored procedure to execute against a SQL Server database

    'Retrieve data with ExecuteReader().
    'Retrieve a single value with ExecuteScalar().
    'Insert, update, or delete records with ExecuteNonQuery().

    Private Sub SaleList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.SaleItem_DataLoad()
        Me.SaleMS_PartyCmbLoad()

        Me.KeyPreview = True
        enable_add_edit_delete()
    End Sub

    Private Sub clearEntries()
        EntryNoTextBox.Text = ""
        BillNoTextBox.Text = ""
        PartyComboBox.Text = ""
        RemarksTextBox.Text = ""
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
            e.Handled = True 'do not process it normally 
        End If

        If e.KeyCode = Keys.F7 Then
            search_Btn.PerformClick()
            e.Handled = True
        End If

    End Sub

    Private Sub disable_add_edit_delete()
        Save_Btn.Enabled = True
        InfoBox.Enabled = True

        Add_Btn.Enabled = False
        Update_Btn.Enabled = False
        Delete_Btn.Enabled = False
    End Sub

    Private Sub enable_add_edit_delete()
        Save_Btn.Enabled = False
        InfoBox.Enabled = False

        Add_Btn.Enabled = True
        Update_Btn.Enabled = True
        Delete_Btn.Enabled = True
        Undo_Btn.Enabled = True
    End Sub

    Private Sub SaleItem_DataLoad()
        Try
            Using conn As New SqlConnection(connection)
                conn.Open()
                Dim query As String =
                "SELECT SaleItem.ItemID, " &
                "SaleList.EntryNo, " &
                "SaleList.BillNo, " &
                "SaleList.Party, " &
                "SaleList.[Date], " &
                "SaleList.Remarks, " &
                "SaleItem.Item, " &
                "SaleItem.Qty, " &
                "SaleItem.Rate, " &
                "SaleItem.Amount " &
                "FROM MobileSaleItem AS SaleItem " &
                "INNER JOIN MobileSaleList AS SaleList " &
                "ON SaleItem.EntryNo = SaleList.EntryNo"
 
                Using cmd As New SqlCommand(query, conn)

                    Dim saleItemTbl As New DataTable()

                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(saleItemTbl)
                    End Using

                    MobileSaleList_DGV.DataSource = saleItemTbl
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Mobile Form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaleMS_PartyCmbLoad()
        Try

            Using conn As New SqlConnection(connection)
                conn.Open()

                Dim query As String = "SELECT Party FROM [MobileShop].[dbo].[MobileParty] WHERE Party IS NOT NULL"

                Using cmd As New SqlCommand(query, conn)

                    Using adp As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adp.Fill(dt)

                        PartyComboBox.DataSource = dt
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Mobile Form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaleListAdd()

        Using conn As New SqlConnection(connection)
            conn.Open()
            Dim entryVal As Object

            Using transaction As SqlTransaction = conn.BeginTransaction()
                Try
                    Dim entryQuery As String = "SELECT MAX(EntryNo) FROM [MobileShop].[dbo].[MobileSaleList]"

                    Using cmd As New SqlCommand(entryQuery, conn, transaction)
                        entryVal = cmd.ExecuteScalar() 'return a single value from the first row
                    End Using

                    If entryVal Is DBNull.Value OrElse entryVal Is Nothing Then
                        EntryNoTextBox.Text = "1"
                        disable_add_edit_delete()
                        MobileSaleList_DGV.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
                        Exit Sub
                    End If

                    Dim entryNo As Integer
                    Integer.TryParse(entryVal, entryNo)

                    Dim itemQuery As String = "SELECT * FROM [MobileShop].[dbo].[MobileSaleItem] WHERE EntryNo = @find"

                    Using cmd As New SqlCommand(itemQuery, conn, transaction)
                        cmd.Parameters.Add("@find", SqlDbType.Int).Value = entryNo

                        Dim saleItemTbl As New DataTable()

                        Using adapter As New SqlDataAdapter(cmd)
                            adapter.Fill(saleItemTbl)
                        End Using

                        saleItemTbl.Clear()
                        MobileSaleList_DGV.DataSource = saleItemTbl

                        cmd.ExecuteNonQuery()
                    End Using

                    EntryNoTextBox.Text = (entryNo + 1).ToString
                    transaction.Commit()

                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub SaleListSave()

        Try

            Using conn As New SqlConnection(connection)

                conn.Open()

                Using transaction As SqlTransaction = conn.BeginTransaction()

                    Try

                        Dim insertSaleMs As String =
                            "INSERT INTO MobileSaleList " &
                            "(BillNo, Party, [Date], Remarks) " &
                            "VALUES (@p1, @p2, @p3, @p4); " &
                            "SELECT CAST(SCOPE_IDENTITY() AS INT);"

                        Dim entryNo As Integer

                        Using cmd As New SqlCommand(
                            insertSaleMs,
                            conn,
                            transaction)

                            cmd.Parameters.Add("@p1", SqlDbType.Int).Value =
                                Integer.Parse(BillNoTextBox.Text)

                            cmd.Parameters.Add("@p2", SqlDbType.NVarChar, 20).Value =
                                PartyComboBox.Text

                            cmd.Parameters.Add("@p3", SqlDbType.Date).Value =
                                DateTimePicker.Value.Date

                            cmd.Parameters.Add("@p4", SqlDbType.NVarChar, 20).Value =
                                RemarksTextBox.Text

                            entryNo = CInt(cmd.ExecuteScalar())

                        End Using

                        Dim insertSaleDt As String =
                            "INSERT INTO MobileSaleItem " &
                            "(ItemID, EntryNo, Item, Qty, Rate, Amount) " &
                            "VALUES (@param1, @param2, @param3, @param4, @param5, @param6)"

                        For Each row As DataGridViewRow In MobileSaleList_DGV.Rows
                            Using cmd As New SqlCommand(
                           insertSaleDt,
                           conn,
                           transaction)

                                If row Is Nothing OrElse row.IsNewRow Then
                                    Continue For
                                End If

                                cmd.Parameters.Add("@param1", SqlDbType.Int).Value =
                                    Convert.ToInt32(row.Cells("dgv_item_id").Value)

                                cmd.Parameters.Add("@param2", SqlDbType.Int).Value =
                                    entryNo

                                cmd.Parameters.Add("@param3", SqlDbType.NVarChar).Value =
                                    Convert.ToString(
                                        row.Cells("dgv_item_name").Value)

                                cmd.Parameters.Add("@param4", SqlDbType.Int).Value =
                                    Convert.ToInt32(
                                        row.Cells("dgv_qty_rate").Value)

                                cmd.Parameters.Add("@param5", SqlDbType.Decimal).Value =
                                    Convert.ToDecimal(
                                        row.Cells("dgv_price_rate").Value)

                                cmd.Parameters.Add("@param6", SqlDbType.Decimal).Value =
                                    Convert.ToDecimal(
                                        row.Cells("dgv_amt_rate").Value)

                                cmd.ExecuteNonQuery()

                            End Using
                        Next

                        Dim updateMSQuery As String = "UPDATE MobileSaleList SET BillNo=param1, Party=@param2, [Date]=@param3, Remarks=@param4 WHERE EntryNo = @entryNo"
                        Dim updateDTQuery As String = "UPDATE MobileSaleItem SET BillNo=param1, Party=@param2, [Date]=@param3, Remarks=@param4 WHERE EntryNo = @entryNo"

                        transaction.Commit()

                        MessageBox.Show(
                            "Sale saved successfully!" &
                            vbCrLf &
                            "Entry No: " & entryNo.ToString(),
                            "Mobile Form",
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
                "Mobile Form",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub SaleListDelete()

        Using conn As New SqlConnection(connection)
            conn.Open()

            Dim rowAffected As Integer = 0

            Using transaction As SqlTransaction = conn.BeginTransaction()
                Try
                    Dim itemQuery As String = "DELETE FROM [MobileShop].[dbo].[MobileSaleItem] WHERE EntryNo = @find;"

                    Using cmd As New SqlCommand(itemQuery, conn, transaction)
                        cmd.Parameters.Add("@find", System.Data.SqlDbType.Int).Value = Trim(EntryNoTextBox.Text)
                        rowAffected = cmd.ExecuteNonQuery()
                    End Using

                    Dim listQuery As String = "DELETE FROM [MobileShop].[dbo].[MobileSaleList] WHERE EntryNo = @find;"

                    Using cmd As New SqlCommand(listQuery, conn, transaction)
                        cmd.Parameters.Add("@find", System.Data.SqlDbType.Int).Value = Trim(EntryNoTextBox.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    If rowAffected > 0 Then
                        MessageBox.Show("Sale deleted successfully!", "Mobile Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Sorry! No record found.", "Mobile Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    transaction.Commit()
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub MobileSaleList_DGV_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles MobileSaleList_DGV.DataError
        e.ThrowException = False 'Don't re-throw the exception

        MessageBox.Show("Enter a valid input!", "Mobile Form", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub Add_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Add_Btn.Click
        Me.SaleListAdd()
        disable_add_edit_delete()
        MobileSaleList_DGV.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
    End Sub

    Private Sub Update_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Update_Btn.Click
        disable_add_edit_delete()

        Dim rc As Integer = 0
        rc = Me.MobileSaleDS.MobileSaleList.Rows.Count

        If rc = 0 Then
            MessageBox.Show("Please select your record to edit!", "Mobile - Inventory Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        MessageBox.Show("Edit mode is enabled!", "Mobile - Inventory Solution", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MobileSaleList_DGV.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
    End Sub

    Private Sub Save_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Save_Btn.Click
        Try

            If Len(BillNoTextBox.Text.Trim()) = 0 Then
                MessageBox.Show("Please enter bill no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BillNoTextBox.Focus()
                Exit Sub
            End If

            If Len(PartyComboBox.Text.Trim()) = 0 Then
                MessageBox.Show("Please enter the party name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PartyComboBox.Focus()
                Exit Sub
            End If

            For Each row As DataGridViewRow In MobileSaleList_DGV.Rows
                If row Is Nothing OrElse row.IsNewRow Then Continue For

                If Len(row.Cells("dgv_qty_rate").Value.ToString) = 0 Then
                    MessageBox.Show("Qty Length: " & Len(row.Cells("dgv_qty_rate").Value.ToString), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next

            enable_add_edit_delete()
            Me.SaleListSave()
            clearEntries()

            MobileSaleList_DGV.EditMode = DataGridViewEditMode.EditProgrammatically
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Delete_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Delete_Btn.Click

        Try
            Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this record!" & vbNewLine & "Press Save After Deleting.", "Mobile - Inventory Solution", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If confirm = Windows.Forms.DialogResult.Yes Then
                disable_add_edit_delete()
                Me.SaleListDelete()
                MobileSaleList_DGV.EditMode = DataGridViewEditMode.EditProgrammatically
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Undo_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Undo_Btn.Click

        Try
            enable_add_edit_delete()
            Me.SaleItem_DataLoad()
            clearEntries()

            MobileSaleList_DGV.EditMode = DataGridViewEditMode.EditProgrammatically
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub SaleList_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles MobileSaleList_DGV.CellValueChanged
        Try
            If e.RowIndex < 0 Then Exit Sub
            Dim productValue As Object = MobileSaleList_DGV.Rows(e.RowIndex).Cells("dgv_item_name").Value

            If productValue Is Nothing OrElse productValue Is DBNull.Value Then
                Exit Sub
            End If

            Dim product As String = productValue.ToString().Trim()

            If String.IsNullOrWhiteSpace(product) Then
                Exit Sub
            End If

            If MobileSaleList_DGV.Columns(e.ColumnIndex).HeaderText = "Item" Then

                Using conn As New SqlConnection(connection)
                    conn.Open()
                    Dim filterQuery As String = "SELECT ProductID, Product, SalePrice FROM [MobileShop].[dbo].[MobileInv] WHERE Product = @product"

                    Using cmd As New SqlCommand(filterQuery, conn)
                        cmd.Parameters.Add("@product", SqlDbType.NVarChar, 120).Value = product

                        rdr = cmd.ExecuteReader()
                        If rdr.HasRows Then
                            If rdr.Read() Then
                                MobileSaleList_DGV.Rows(e.RowIndex).Cells("dgv_item_id").Value = rdr("ProductID")
                                MobileSaleList_DGV.Rows(e.RowIndex).Cells("dgv_price_rate").Value = rdr("SalePrice")
                            End If
                        Else

                            MessageBox.Show(
                                "Product not found.",
                                "Mobile Form",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            )
                        End If
                    End Using
                End Using

                Dim qtyValue As Object =
                MobileSaleList_DGV.Rows(e.RowIndex).Cells("dgv_qty_rate").Value

                If qtyValue Is Nothing OrElse qtyValue Is DBNull.Value Then
                    Exit Sub
                End If

                Dim qty As Integer
                If Not Integer.TryParse(qtyValue, qty) Then
                    Exit Sub
                End If

                calculateAmt(e.RowIndex)
            End If

            If MobileSaleList_DGV.Columns(e.ColumnIndex).HeaderText = "Qty" Then
                calculateAmt(e.RowIndex)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub calculateAmt(indx As Integer)
        If indx < 0 Then Exit Sub
        Dim item As Object = MobileSaleList_DGV.Rows(indx).Cells("dgv_item_name").Value

        If item IsNot Nothing OrElse item IsNot DBNull.Value Then
            Dim qty As Integer = CInt(MobileSaleList_DGV.Rows(indx).Cells("dgv_qty_rate").Value)
            Dim rate As Decimal = CDec(MobileSaleList_DGV.Rows(indx).Cells("dgv_price_rate").Value)

            Dim amt As Decimal = CDec(qty * rate)
            MobileSaleList_DGV.Rows(indx).Cells("dgv_amt_rate").Value = amt.ToString
        End If

    End Sub

    Private Sub MobileSaleList_DGV_CellValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles MobileSaleList_DGV.CellValidating

        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        If MobileSaleList_DGV.Columns(e.ColumnIndex).HeaderText = "Qty" Then

            If MobileSaleList_DGV.Rows(e.RowIndex).Cells("dgv_qty_rate") Is Nothing OrElse MobileSaleList_DGV.Rows(e.RowIndex).Cells("dgv_qty_rate") Is DBNull.Value Then Exit Sub

            Dim qtyVal As String = CStr(e.FormattedValue).Trim()

            If String.IsNullOrWhiteSpace(qtyVal) Then Exit Sub

            Dim qty As Integer
            If Not Integer.TryParse(qtyVal, qty) OrElse qty <= 0 Then
                MessageBox.Show("Qty must be a valid integer greater than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub SaleTotalAmt(entryNo As Integer)

        Try
            Dim total As Decimal = 0D

            For Each row As DataGridViewRow In MobileSaleList_DGV.Rows

                If row.IsNewRow Then Continue For

                Dim entryValue As Object =
                    row.Cells("dgv_entry").Value

                Dim amountValue As Object =
                    row.Cells("dgv_amt_rate").Value

                If amountValue Is Nothing OrElse
                amountValue Is DBNull.Value Then
                    Continue For
                End If

                Dim amount As Decimal

                If Not Decimal.TryParse(amountValue.ToString(), amount) Then
                    Continue For
                End If

                If entryValue IsNot Nothing AndAlso
                        entryValue IsNot DBNull.Value AndAlso Not String.IsNullOrWhiteSpace(entryValue.ToString) Then

                    Dim rowEntryNo As Integer

                    If Integer.TryParse(entryValue.ToString, rowEntryNo) Then
                        If rowEntryNo = entryNo Then
                            total += amount
                        End If
                    End If

                Else
                    total += amount
                End If
            Next

            totalAmtBox.Text = total.ToString("N2")

        Catch ex As Exception

            MessageBox.Show(
                "Error: " & ex.Message,
                "Error Alert!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub MobileSaleList_DGV_SelectionChanged(sender As System.Object, e As EventArgs) Handles MobileSaleList_DGV.SelectionChanged
        Try
            If MobileSaleList_DGV.CurrentCell.RowIndex < 0 OrElse MobileSaleList_DGV.CurrentCell.ColumnIndex < 0 Then Exit Sub

            Dim rowIndx As Integer = MobileSaleList_DGV.CurrentCell.RowIndex
            Dim row As DataGridViewRow = MobileSaleList_DGV.Rows(rowIndx)

            If row.IsNewRow Then Exit Sub
            If row Is DBNull.Value OrElse row Is Nothing Then Exit Sub

            Dim entryVal As Object = MobileSaleList_DGV.Rows(rowIndx).Cells("dgv_entry").Value

            If entryVal Is Nothing OrElse entryVal Is DBNull.Value OrElse String.IsNullOrWhiteSpace(entryVal.ToString) Then
                SaleTotalAmt(CInt(EntryNoTextBox.Text.ToString))
                Exit Sub
            End If

            Dim entryNo As Integer
            If Not Integer.TryParse(entryVal.ToString, entryNo) Then
                Exit Sub
            End If

            EntryNoTextBox.Text = entryNo.ToString
            SaleTotalAmt(entryNo)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Mobile Form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub search_Btn_Click(sender As System.Object, e As System.EventArgs) Handles search_Btn.Click
        MsgBox("Show Search Window")
    End Sub
End Class