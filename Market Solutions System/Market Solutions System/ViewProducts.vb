Imports System.Data.SQLite

Public Class ViewProducts
    Public conn As SQLiteConnection = MainForm.conn
    Private Sub ViewProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim sqlQuery As String = "SELECT * FROM product;"
        Dim cmd As New SQLiteCommand(sqlQuery, conn)
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            Dim index As Integer = ProductGV.Rows.Add()
            ProductGV.Rows(index).Cells("prodName").Value = reader("Name")
            ProductGV.Rows(index).Cells("compName").Value = reader("CompanyName")
            ProductGV.Rows(index).Cells("prodPrice").Value = reader("Price")
            ProductGV.Rows(index).Cells("prodQty").Value = reader("ProdQty")
        End While
        conn.Close()
    End Sub
End Class