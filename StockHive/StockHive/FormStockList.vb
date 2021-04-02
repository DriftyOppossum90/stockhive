Imports System.Data.SqlClient

Public Class FormStockList

    Private Sub FormStockList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        FilterData("")
    End Sub

    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * From Stock WHERE CONCAT(ProductID, ProductName, ProductDesc, Quantity) like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, Conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        StockList.DataSource = table
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FilterData(SearchTxt.Text)
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        FilterData(SearchTxt.Text)
    End Sub
End Class