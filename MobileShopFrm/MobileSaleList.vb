Imports System.Data.SqlClient

Public Class SaleList

    Dim connection As String = My.Settings.MobileShopConnectionString

    Dim rdr As SqlDataReader = Nothing 'Reads records returned by a SQL query, one row at a time.
    Dim adpt As SqlDataAdapter 'Transfers data between SQL Server and in-memory data objects such as a DataTable or DataSet.
    Dim cmd As SqlCommand = Nothing  'Represents a SQL statement or stored procedure to execute against a SQL Server database

    Dim entryNo As Integer

    Private Sub SaleList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.SaleMS_PartyCmbLoad()

        entryNo = GetLastEntryNo()
        Me.SaleItem_DataLoad(entryNo)
        Me.RefreshEntryCounters()

        Me.KeyPreview = True
        enable_add_edit_delete()
    End Sub

    Private Sub clearEntries()
        'BillNoTextBox.Text = ""
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

        navBox.Enabled = False
        Add_Btn.Enabled = False
        Update_Btn.Enabled = False
        Delete_Btn.Enabled = False
    End Sub

    Private Sub enable_add_edit_delete()
        Save_Btn.Enabled = False
        InfoBox.Enabled = False

        navBox.Enabled = True
        Add_Btn.Enabled = True
        Update_Btn.Enabled = True
        Delete_Btn.Enabled = True
        Undo_Btn.Enabled = True
    End Sub

    Private Sub SaleItem_DataLoad(entryNo As Integer)
        Try

            Using conn As New SqlConnection(connection)
                conn.Open()
                Dim query As String =
                "SELECT SaleItem.idno, " &
                "SaleItem.ItemID, " &
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
                "ON SaleItem.EntryNo = SaleList.EntryNo " &
                "WHERE SaleList.EntryNo = @EntryNo"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.Add("@EntryNo", SqlDbType.Int).Value = entryNo

                    Dim saleItemTbl As New DataTable()

                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(saleItemTbl)
                    End Using

                    MobileSaleList_DGV.DataSource = saleItemTbl
                End Using
            End Using

            MobileSaleItem_Amt(entryNo)
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

        Dim entryVal As Integer
        Dim billVal As Integer

        Using conn As New SqlConnection(connection)
            conn.Open()

            Using transaction As SqlTransaction = conn.BeginTransaction()
                Try
                    Dim listQuery As String = "SELECT ISNULL(MAX(EntryNo),1) As MAX_ENTRY, ISNULL(MAX(BillNo),100) AS MAX_BILL FROM [MobileShop].[dbo].[MobileSaleList]"

                    Using cmd As New SqlCommand(listQuery, conn, transaction)
                        Using rdr As SqlDataReader = cmd.ExecuteReader()
                            If rdr.Read() Then
                                entryVal = rdr("MAX_ENTRY")
                                billVal = rdr("MAX_BILL")
                            End If
                        End Using
                    End Using

                    Dim saleItemTbl As New DataTable()
                    MobileSaleList_DGV.DataSource = saleItemTbl

                    totalAmtBox.Text = "0.00"
                    EntryNoTextBox.Text = (entryVal + 1).ToString()
                    BillNoTextBox.Text = (billVal + 1).ToString()

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

            Me.MobileSaleList_DGV.EndEdit()
            Me.Validate()

            Using conn As New SqlConnection(connection)

                conn.Open()

                Using transaction As SqlTransaction = conn.BeginTransaction()

                    Try

                        If Not String.IsNullOrWhiteSpace(EntryNoTextBox.Text) Then

                            If Not Integer.TryParse(
                                EntryNoTextBox.Text,
                                entryNo) Then

                                Throw New Exception("Invalid Entry No.")

                            End If

                        End If

                        Dim saleExists As Boolean =
                            SaleListExist(entryNo, conn, transaction)

                        If Not saleExists Then

                            Dim insertHeaderQuery As String =
                                "INSERT INTO MobileSaleList " &
                                "(BillNo, Party, [Date], Remarks) " &
                                "VALUES (@BillNo, @Party, @SaleDate, @Remarks);" &
                                "SELECT CAST(SCOPE_IDENTITY() AS INT);"   'Execute the INSERT and retrieve the newly generated EntryNo


                            Using cmd As New SqlCommand(
                                insertHeaderQuery,
                                conn,
                                transaction)


                                cmd.Parameters.Add(
                                    "@BillNo",
                                    SqlDbType.Int
                                ).Value =
                                    Convert.ToInt32(BillNoTextBox.Text)


                                cmd.Parameters.Add(
                                    "@Party",
                                    SqlDbType.NVarChar,
                                    20
                                ).Value =
                                    PartyComboBox.Text


                                cmd.Parameters.Add(
                                    "@SaleDate",
                                    SqlDbType.Date
                                ).Value =
                                    DateTimePicker.Value.Date


                                cmd.Parameters.Add(
                                    "@Remarks",
                                    SqlDbType.NVarChar,
                                    20
                                ).Value =
                                    RemarksTextBox.Text

                                entryNo =
                                    Convert.ToInt32(cmd.ExecuteScalar())

                            End Using


                            EntryNoTextBox.Text =
                                entryNo.ToString()

                        Else

                            Dim updateHeaderQuery As String =
                                "UPDATE MobileSaleList " &
                                "SET BillNo = @BillNo, " &
                                "    Party = @Party, " &
                                "    [Date] = @SaleDate, " &
                                "    Remarks = @Remarks " &
                                "WHERE EntryNo = @EntryNo"


                            Using cmd As New SqlCommand(
                                updateHeaderQuery,
                                conn,
                                transaction)

                                cmd.Parameters.Add(
                                    "@BillNo",
                                    SqlDbType.Int
                                ).Value =
                                    Convert.ToInt32(BillNoTextBox.Text)


                                cmd.Parameters.Add(
                                    "@Party",
                                    SqlDbType.NVarChar,
                                    20
                                ).Value =
                                    PartyComboBox.Text


                                cmd.Parameters.Add(
                                    "@SaleDate",
                                    SqlDbType.Date
                                ).Value =
                                    DateTimePicker.Value.Date


                                cmd.Parameters.Add(
                                    "@Remarks",
                                    SqlDbType.NVarChar,
                                    20
                                ).Value =
                                    RemarksTextBox.Text


                                cmd.Parameters.Add(
                                    "@EntryNo",
                                    SqlDbType.Int
                                ).Value =
                                    Convert.ToInt32(EntryNoTextBox.Text)


                                cmd.ExecuteNonQuery()

                            End Using

                        End If

                        Dim deleteDetailQuery As String =
                            "DELETE FROM MobileSaleItem " &
                            "WHERE EntryNo = @EntryNo"


                        Using cmd As New SqlCommand(
                            deleteDetailQuery,
                            conn,
                            transaction)

                            cmd.Parameters.Add(
                                "@EntryNo",
                                SqlDbType.Int
                            ).Value =
                                entryNo

                            cmd.ExecuteNonQuery()

                        End Using

                        Dim insertDetailQuery As String =
                            "INSERT INTO MobileSaleItem " &
                            "(ItemID, EntryNo, Item, Qty, Rate, Amount) " &
                            "VALUES " &
                            "(@ItemID, @EntryNo, @Item, @Qty, @Rate, @Amount)"


                        For Each row As DataGridViewRow In
                            MobileSaleList_DGV.Rows

                            If row.IsNewRow Then Continue For

                            Dim entryValue As Object =
                                row.Cells("dgv_entry").Value

                            Dim itemValue As Object =
                                row.Cells("dgv_item_name").Value

                            Dim qtyValue As Object =
                                row.Cells("dgv_qty_rate").Value

                            Dim rateValue As Object =
                                row.Cells("dgv_price_rate").Value

                            Dim itemIDValue As Object =
                                row.Cells("dgv_item_id").Value

                            'If entryValue Is Nothing OrElse
                            '    entryValue Is DBNull.Value Then

                            '    Continue For

                            'End If

                            If itemValue Is Nothing OrElse
                               itemValue Is DBNull.Value OrElse
                               String.IsNullOrWhiteSpace(
                                   itemValue.ToString()) Then

                                Continue For

                            End If

                            If qtyValue Is Nothing OrElse
                               qtyValue Is DBNull.Value Then

                                Continue For

                            End If

                            If rateValue Is Nothing OrElse
                               rateValue Is DBNull.Value Then

                                Continue For

                            End If

                            Dim itemID As Integer

                            If Not Integer.TryParse(
                                itemIDValue.ToString(),
                                itemID) Then

                                Continue For

                            End If


                            Dim qty As Integer

                            If Not Integer.TryParse(
                                qtyValue.ToString(),
                                qty) OrElse qty <= 0 Then

                                Throw New Exception(
                                    "Invalid quantity for item: " &
                                    itemValue.ToString())

                            End If


                            Dim rate As Decimal

                            If Not Decimal.TryParse(
                                rateValue.ToString(),
                                rate) OrElse rate <= 0 Then

                                Throw New Exception(
                                    "Invalid rate for item: " &
                                    itemValue.ToString())

                            End If


                            Dim amount As Decimal =
                                qty * rate

                            row.Cells("dgv_amt_rate").Value =
                                amount

                            Using cmd As New SqlCommand(
                                insertDetailQuery,
                                conn,
                                transaction)


                                cmd.Parameters.Add(
                                    "@ItemID",
                                    SqlDbType.Int
                                ).Value =
                                    itemID


                                cmd.Parameters.Add(
                                    "@EntryNo",
                                    SqlDbType.Int
                                ).Value =
                                    Val(EntryNoTextBox.Text.Trim())


                                cmd.Parameters.Add(
                                    "@Item",
                                    SqlDbType.NVarChar,
                                    120
                                ).Value =
                                    itemValue.ToString()


                                cmd.Parameters.Add(
                                    "@Qty",
                                    SqlDbType.Int
                                ).Value =
                                    qty


                                Dim rateParameter =
                                    cmd.Parameters.Add(
                                        "@Rate",
                                        SqlDbType.Decimal)

                                rateParameter.Value = rate

                                Dim amountParameter =
                                    cmd.Parameters.Add(
                                        "@Amount",
                                        SqlDbType.Decimal)

                                amountParameter.Value = amount


                                cmd.ExecuteNonQuery()

                            End Using

                        Next

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
                    Dim itemQuery As String = "DELETE FROM [MobileShop].[dbo].[MobileSaleItem] WHERE idno = @find;"

                    Using cmd As New SqlCommand(itemQuery, conn, transaction)
                        cmd.Parameters.Add("@find", System.Data.SqlDbType.Int).Value = Val(MobileSaleList_DGV.Rows(MobileSaleList_DGV.CurrentCell.RowIndex).Cells("dgv_idno").Value)
                        rowAffected = cmd.ExecuteNonQuery()
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

    Private Function SaleListExist(entryNo As Integer, conn As SqlConnection, transaction As SqlTransaction)

        Dim query As String = "SELECT COUNT(*) FROM MobileSaleList WHERE EntryNo = @entryNo"

        Using cmd As New SqlCommand(query, conn, transaction)
            cmd.Parameters.Add("@entryNo", SqlDbType.Int).Value = entryNo
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        End Using

    End Function

    Private Sub MobileSaleList_DGV_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles MobileSaleList_DGV.DataError
        e.ThrowException = False 'Don't re-throw the exception

        MsgBox(
    "DataError: " &
    e.Exception.Message &
    " | Row: " &
    e.RowIndex.ToString() &
    " | Column: " &
    e.ColumnIndex.ToString()
)
    End Sub

    Private Sub Add_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Add_Btn.Click
        Me.SaleListAdd()
        clearEntries()
        disable_add_edit_delete()
        MobileSaleList_DGV.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2
    End Sub

    Private Sub Update_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Update_Btn.Click
        disable_add_edit_delete()

        Dim rc As Integer = 0
        rc = Me.MobileSaleList_DGV.Rows.Count

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
                Me.SaleListDelete()
                Me.SaleItem_DataLoad(entryNo)
                MobileSaleList_DGV.EditMode = DataGridViewEditMode.EditProgrammatically
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Undo_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Undo_Btn.Click
        Try
            enable_add_edit_delete()
            Me.clearEntries()

            entryNo = GetLastEntryNo()
            Me.SaleItem_DataLoad(entryNo)

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

                MobileSaleItem_Amt(entryNo)
            End If

            If MobileSaleList_DGV.Columns(e.ColumnIndex).HeaderText = "Qty" Then
                MobileSaleItem_Amt(entryNo)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub MobileSaleItem_Amt(entryNo As Integer)

        Try

            Dim total As Decimal = 0D

            For Each row As DataGridViewRow In MobileSaleList_DGV.Rows

                If row.IsNewRow Then Continue For

                Dim entryValue As Object =
                    row.Cells("dgv_entry").Value

                Dim itemValue As Object =
                    row.Cells("dgv_item_name").Value

                Dim qtyValue As Object =
                    row.Cells("dgv_qty_rate").Value

                Dim rateValue As Object =
                    row.Cells("dgv_price_rate").Value

                Dim amtValue As Object =
                    row.Cells("dgv_amt_rate").Value

                If itemValue Is Nothing OrElse
                   itemValue Is DBNull.Value OrElse
                   String.IsNullOrWhiteSpace(itemValue.ToString()) Then
                    Continue For
                End If

                Dim qty As Integer

                If qtyValue Is Nothing OrElse
                   qtyValue Is DBNull.Value OrElse
                   Not Integer.TryParse(qtyValue.ToString(), qty) OrElse
                   qty <= 0 Then

                    Continue For

                End If

                Dim rate As Decimal
                Dim amount As Decimal

                If rateValue Is Nothing OrElse
                   rateValue Is DBNull.Value OrElse
                   Not Decimal.TryParse(rateValue.ToString(), rate) OrElse
                   rate <= 0 Then

                    Continue For

                End If

                amount = qty * rate
                row.Cells("dgv_amt_rate").Value = amount

                If entryValue Is Nothing OrElse
                   entryValue Is DBNull.Value OrElse
                   String.IsNullOrWhiteSpace(entryValue.ToString()) Then

                    total += amount

                Else

                    Dim rowEntryNo As Integer

                    If Integer.TryParse(
                        entryValue.ToString(),
                        rowEntryNo) Then

                        If rowEntryNo = entryNo Then
                            total += amount
                        End If

                    End If

                End If

            Next

            totalAmtBox.Text =
                total.ToString("N2")

        Catch ex As Exception

            MessageBox.Show(
                "Error: " & ex.Message,
                "Error Alert!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

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

    Private Sub MobileSaleList_DGV_SelectionChanged(sender As System.Object, e As EventArgs) Handles MobileSaleList_DGV.SelectionChanged
        Try
            If MobileSaleList_DGV.CurrentCell.RowIndex < 0 OrElse MobileSaleList_DGV.CurrentCell.ColumnIndex < 0 Then Exit Sub

            Dim rowIndx As Integer = MobileSaleList_DGV.CurrentCell.RowIndex
            Dim row As DataGridViewRow = MobileSaleList_DGV.Rows(rowIndx)

            If row.IsNewRow Then Exit Sub
            If row Is DBNull.Value OrElse row Is Nothing Then Exit Sub

            Dim entryVal As Object = MobileSaleList_DGV.Rows(rowIndx).Cells("dgv_entry").Value

            If entryVal Is Nothing OrElse entryVal Is DBNull.Value OrElse String.IsNullOrWhiteSpace(entryVal.ToString) Then
                Exit Sub
            End If

            Dim entryNo As Integer
            If Not Integer.TryParse(entryVal.ToString, entryNo) Then
                Exit Sub
            End If

            Using conn As New SqlConnection(connection)
                conn.Open()
                Dim query As String = "SELECT * FROM MobileSaleList WHERE EntryNo = " & entryNo.ToString

                Using cmd As New SqlCommand(query, conn)
                    rdr = cmd.ExecuteReader()

                    If rdr.Read() Then
                        BillNoTextBox.Text = CInt(rdr("BillNo"))
                        PartyComboBox.Text = rdr("Party")
                        DateTimePicker.Text = rdr("Date")
                        RemarksTextBox.Text = rdr("Remarks")
                    End If
                End Using
            End Using

            EntryNoTextBox.Text = entryNo.ToString
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Mobile Form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub search_Btn_Click(sender As System.Object, e As System.EventArgs) Handles search_Btn.Click
        MsgBox("Show Search Window")
    End Sub

    Private Function ScalarInt(query As String, Optional entryNo As Integer = 0)
        Using conn As New SqlConnection(connection)
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@entryNo", SqlDbType.Int).Value = entryNo
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Private Function GetLastEntryNo() As Integer
        Return (ScalarInt("SELECT ISNULL(MAX(EntryNo),0) FROM MobileSaleItem"))
    End Function

    Private Function GetFirstEntryNo() As Integer
        Return ScalarInt("SELECT ISNULL(MIN(EntryNo),0) FROM MobileSaleItem")
    End Function

    Private Function GetNextEntryNo(ByVal current As Integer) As Integer
        Return ScalarInt("SELECT ISNULL(MIN(EntryNo), 0) FROM MobileSaleItem WHERE EntryNo > @EntryNo", current)
    End Function

    Private Function GetPrevEntryNo(ByVal current As Integer) As Integer
        Return ScalarInt("SELECT ISNULL(MAX(EntryNo), 0) FROM MobileSaleItem WHERE EntryNo < @EntryNo", current)
    End Function

    Private Sub RefreshEntryCounters()
        Dim total As Integer = ScalarInt("SELECT COUNT(*) FROM MobileSaleList")
        Dim position As Integer = 0

        If total > 0 Then
            position = ScalarInt("SELECT COUNT(*) FROM MobileSaleList WHERE EntryNo <= @EntryNo", entryNo)
        End If

        totalEntryLbl.Text = total.ToString
        currEntryLbl.Text = position.ToString

        firstBtn.Enabled = position > 1
        prevBtn.Enabled = position > 1
        nextBtn.Enabled = position < total
        lastBtn.Enabled = position < total
    End Sub

    Private Sub ShowEntry(ByVal target As Integer)
        If target <= 0 Then Exit Sub
        entryNo = target
        Me.SaleItem_DataLoad(entryNo)
        RefreshEntryCounters()
    End Sub

    Private Sub nextBtn_Click(sender As System.Object, e As System.EventArgs) Handles nextBtn.Click
        ShowEntry(GetNextEntryNo(entryNo))
    End Sub

    Private Sub lastBtn_Click(sender As System.Object, e As System.EventArgs) Handles lastBtn.Click
        ShowEntry(GetLastEntryNo())
    End Sub

    Private Sub prevBtn_Click(sender As System.Object, e As System.EventArgs) Handles prevBtn.Click
        ShowEntry(GetPrevEntryNo(entryNo))
    End Sub

    Private Sub firstBtn_Click(sender As System.Object, e As System.EventArgs) Handles firstBtn.Click
        ShowEntry(GetFirstEntryNo())
    End Sub

End Class