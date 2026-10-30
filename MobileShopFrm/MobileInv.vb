Imports System.Data.SqlClient

Public Class InventorySol

    Dim connection As String = My.Settings.MobileShopConnectionString
    Dim PRODUCT_ID As Integer
    Dim frm As New InvEntry

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

                MobileInvBindingSource.DataSource = invTable
                MobileInv_DGV.DataSource = MobileInvBindingSource
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

        If e.KeyCode = Keys.F5 Then
            Delete_Btn.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Function GetProductID() As Integer
        Using conn As New SqlConnection(connection)
            conn.Open()

            Dim query As String = "SELECT ISNULL(MAX(ProductID),100) + 1 FROM MobileInv"

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
                cmd.Parameters.Add("@find", SqlDbType.Int).Value = GetProductID()
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
        Using frm As New InvEntry
            frm.BTN_NAME = Add_Btn.Name.ToString

            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                InventoryItem_DataLoad()
            End If
        End Using
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

                    InventoryItem_DataLoad()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Update_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Update_Btn.Click
        Using frm As New InvEntry
            frm.BTN_NAME = Update_Btn.Name.ToString()
            frm.PRODUCT_ID = PRODUCT_ID

            frm.ShowDialog()
            InventoryItem_DataLoad()
        End Using
    End Sub

    Private Sub Find_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Find_Btn.Click
        Using frm As New InvFind
            frm.ShowDialog()
            InventoryItem_DataLoad()
        End Using
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
                Exit Sub
            End If

            If productIDValue Is Nothing OrElse productIDValue Is DBNull.Value Then Exit Sub

            Integer.TryParse(productIDValue, PRODUCT_ID)

            Using conn As New SqlConnection(connection)
                conn.Open()
                Dim query As String = "SELECT Product, Category, Brand, PurchasePrice, SalePrice, WarrantyMonths, IsActive FROM MobileInv WHERE ProductID = @find"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.Add("@find", SqlDbType.Int).Value = PRODUCT_ID

                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.HasRows Then
                            If rdr.Read() Then
                                ProductTextBox.Text = rdr("Product")
                                CategoryTextBox.Text = rdr("Category")
                                BrandTextBox.Text = rdr("Brand")
                                PurchasePriceTextBox.Text = rdr("PurchasePrice")
                                SalePriceTextBox.Text = rdr("SalePrice")
                                WarrantyMonthsTextBox.Text = rdr("WarrantyMonths")
                                IsActiveCheckBox.Checked = If(Val(rdr("IsActive")) = 1, True, False)
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
