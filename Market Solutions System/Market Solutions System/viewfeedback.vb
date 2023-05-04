Imports System.Data.SQLite

Public Class viewfeedback
    Public conn As SQLiteConnection = MainForm.conn
    Private Sub viewfeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim sqlQuery As String = "SELECT * FROM Feedback;"
        Dim cmd As New SQLiteCommand(sqlQuery, conn)
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            Dim index As Integer = FeedDGV.Rows.Add()
            FeedDGV.Rows(index).Cells("FDID").Value = reader("FDID")
            FeedDGV.Rows(index).Cells("CustID").Value = reader("CustID")
            FeedDGV.Rows(index).Cells("ProdName").Value = reader("ProdName")
            FeedDGV.Rows(index).Cells("Rating").Value = reader("Rating")
            FeedDGV.Rows(index).Cells("Feedback").Value = reader("Feedback")
        End While
        reader.Close()
        conn.Close()
    End Sub
End Class