Imports System.Data.SqlClient
Imports System.Data
Public Class FormEdit
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ConnectDatabase()
        Dim dr As New DialogResult
        dr = MessageBox.Show("Are you sure you want to Update?", "Change Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.OK Then
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Dim st As String = "UPDATE [Stock] SET ProductID = '" & IDTxt.Text &
               "', ProductName = '" & NameTxt.Text & "', ProductDesc = '" & DescTxt.Text &
                "', Price = '" & PriceTxt.Text & "', Quantity = '" & QuantityTxt.Text &
                "'  WHERE ProductID = '" & FormManage.StockList.SelectedCells(0).Value & "'"
            MessageBox.Show("Process Successful!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmd.ExecuteNonQuery()
            Conn.Close()
            FormManage.fill()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class