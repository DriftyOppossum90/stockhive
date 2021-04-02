Imports System.Data.SqlClient

Module Connect_Database
    Public Conn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public dt As DataTable
    Public ds As DataSet
    Public Sql As String
    Public Sub ConnectDatabase()
        Try
            Conn = New SqlConnection
            Conn.ConnectionString = "DATA SOURCE=DESKTOP-C7URQFD\SQLEXPRESS;INITIAL CATALOG=StockHive;TRUSTED_CONNECTION=TRUE;INTEGRATED SECURITY=TRUE"
            Conn.Open()
        Catch ex As Exception
        End Try
    End Sub
End Module
