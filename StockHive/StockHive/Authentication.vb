Imports System.Data.SqlClient
Imports System.Threading
Public Class Authentication

    Sub Authentication()
        If UsernameTxt.Text = "" Then
            MsgBox("Username is required", MsgBoxStyle.Critical)
            UsernameTxt.Focus()
        ElseIf PassTxt.Text = "" Then
            MsgBox("Password is required", MsgBoxStyle.Critical)
            PassTxt.Focus()
        Else
            ConnectDatabase()
            Sql = "select * from Login where Username ='" + UsernameTxt.Text + "' and Password='" + PassTxt.Text + "'"
            cmd = New SqlCommand
            With cmd
                .Connection = Conn
                .CommandText = Sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Username", UsernameTxt.Text)
                .Parameters.AddWithValue("@Password", PassTxt.Text)
                .ExecuteNonQuery()
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            Conn.Close()
            da.Dispose()
            If dt.Rows.Count > 0 Then
                Label2.Hide()
                MsgBox("Welcome " & UsernameTxt.Text)
                UsernameTxt.Text = ""
                PassTxt.Text = ""
                Me.Hide()
                StockHive.Show()
            Else
                Label2.Show()
                PassTxt.Text = ""
                UsernameTxt.Focus()
                UsernameTxt.Text = ""
                PassTxt.Text = ""
            End If
        End If
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Authentication()
    End Sub

    Private Sub ShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPass.CheckedChanged
        PassTxt.UseSystemPasswordChar = Not ShowPass.Checked
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

End Class

