Imports System.Data.SQLite
Imports System.IO

Public Class MainForm
    Public Shared conn As SQLiteConnection

    Public Sub New()
        InitializeComponent()
        Dim path, dbPath, connString As String
        path = Directory.GetCurrentDirectory()
        dbPath = IO.Path.Combine(path, "..\..\..\database.db")
        connString = $"Data Source={dbPath}"
        conn = New SQLiteConnection(connString)
        conn.Open()
        conn.Close()
    End Sub


    Private Sub CashSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashSalesToolStripMenuItem.Click
        Me.Hide()
        CashSalesForm.Show()
    End Sub

    Private Sub AddProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductToolStripMenuItem.Click
        Me.Hide()
        AddProductForm.Show()
    End Sub

    Private Sub ViewProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductsToolStripMenuItem.Click
        Me.Hide()
        ViewProducts.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
