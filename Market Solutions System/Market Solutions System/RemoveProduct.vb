Imports System.Data.SQLite

Public Class RemoveProduct
    Dim conn As SQLiteConnection = MainForm.conn
    Private Sub RemoveProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim sqlQuery As String = $"SELECT * FROM product;"
        Dim cmd As New SQLiteCommand(sqlQuery, conn)
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            prodNameCB.Items.Add(reader("Name"))
        End While
        conn.Close()
    End Sub

    Private Sub removeBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click
        conn.Open()
        Dim prodName As String = prodNameCB.Text
        Dim sqlQuery As String = $"DELETE FROM product WHERE Name='{prodName}'"
        Dim cmd As New SQLiteCommand(sqlQuery, conn)
        Try
            Dim rowsAffected = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                prodNameCB.Items.Remove(prodName)
                MessageBox.Show("Product Removed Successfully")
            End If
        Catch ex As Exception
            MessageBox.Show("No Such Product Registered")
        End Try
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class