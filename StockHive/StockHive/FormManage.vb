Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.DataTable
Public Class FormManage
    Dim source1 As New BindingSource()
    Dim source2 As New BindingSource()
    Dim ds As DataSet = New DataSet
    Dim tables As DataTableCollection = ds.Tables

    Sub fill()
        Dim dt As New DataTable
        Dim str As String = "Select ProductID as [Product ID], ProductName as [Name],ProductDesc as [Description], Price as [Price], Quantity as [Quantity] from Stock ORDER By ProductID "
        Dim da As New SqlDataAdapter(str, Conn)
        da.Fill(dt)
        da.Dispose()
        source1.DataSource = dt
        StockList.DataSource = dt
        StockList.Refresh()
    End Sub

    Public Sub clear()
        IDTxt.Clear()
        NameTxt.Clear()
        DescTxt.Clear()
        PriceTxt.Clear()
        QuantityTxt.Clear()
    End Sub

    Public Sub clearitems()
        ListView1.Items.Clear()
    End Sub

    Public Sub delterminated(ByRef ProductID As String)
        Try
            Dim str1 As String = "Delete * from Stock where [Stock.ProductID]= '" & ProductID & "'"
            Dim cmd1 As New SqlCommand(str1, Conn)
            cmd1.ExecuteNonQuery()
            fill()
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub FormManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ConnectDatabase()
        Dim sql As String = "Select * FROM Stock where ProductID = '" & IDTxt.Text & "' "
        Dim cmd1 As New SqlCommand(sql, Conn)
        Using reader As SqlDataReader = cmd1.ExecuteReader()
            If reader.HasRows Then
                MsgBox("ID already exists!")
                IDTxt.Focus()
                IDTxt.SelectAll()
            Else
                ListView1.Items.Add(IDTxt.Text.ToString)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(NameTxt.Text).ToString)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(DescTxt.Text).ToString)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(PriceTxt.Text).ToString)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(QuantityTxt.Text).ToString)
                clear()
            End If
            Conn.Close()
        End Using
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ConnectDatabase()
        Try
            For Each item As ListViewItem In ListView1.Items
                Dim st As String = "INSERT INTO [Stock](ProductID,ProductName,ProductDesc,Price,Quantity) VALUES ('" & item.Text & "','" & item.SubItems(1).Text & "','" & item.SubItems(2).Text & "','" & item.SubItems(3).Text & "','" & item.SubItems(4).Text & "' )"
                Dim cmdd As New SqlCommand(st, Conn)
                cmdd.ExecuteNonQuery()
                Conn.Close()
                Me.fill()
                clearitems()
            Next
            MessageBox.Show("Saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click, btnSave.Click, btnCancel.Click
        btnCancel.Show()
        Me.IDTxt.Text = Me.StockList.SelectedCells(0).Value.ToString
        Me.NameTxt.Text = Me.StockList.SelectedCells(1).Value.ToString
        Me.DescTxt.Text = Me.StockList.SelectedCells(2).Value.ToString
        Me.PriceTxt.Text = Me.StockList.SelectedCells(3).Value.ToString
        Me.QuantityTxt.Text = Me.StockList.SelectedCells(4).Value.ToString
        ConnectDatabase()
        Dim dr As New DialogResult
        dr = MessageBox.Show("Are you sure you want to Update?", "Change Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.OK Then
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Dim st As String = "UPDATE [Stock] SET ProductID = '" & IDTxt.Text &
               "', ProductName = '" & NameTxt.Text & "', ProductDesc = '" & DescTxt.Text &
                "', Price = '" & PriceTxt.Text & "', Quantity = '" & QuantityTxt.Text &
                "'  WHERE ProductID = '" & Me.StockList.SelectedCells(0).Value & "'"
            MessageBox.Show("Process Successful!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmd.ExecuteNonQuery()
            Conn.Close()
            Me.fill()
            btnCancel.Hide()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If StockList.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 Then
            If StockList.Rows.GetRowCount(DataGridViewElementStates.Selected) > 1 Then
                Dim dr As New DialogResult
                dr = MessageBox.Show("Do you want to permanently delete the selected data?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If dr = Windows.Forms.DialogResult.Cancel Then
                    MessageBox.Show("Action aborted!", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    For i = StockList.SelectedRows.Count - 1 To 0 Step -1
                        delterminated(StockList.SelectedRows(i).Cells(0).Value)
                        fill()
                    Next
                End If
            Else
                Dim dr As New DialogResult
                dr = MessageBox.Show("Do you want to permanently delete " & StockList.SelectedCells(0).Value & "?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If dr = Windows.Forms.DialogResult.Cancel Then
                    MessageBox.Show("Action aborted!", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    StockList.ClearSelection()
                    Exit Sub
                Else
                    delterminated(StockList.SelectedCells(0).Value)
                    fill()
                End If
            End If
        End If
    End Sub

End Class
