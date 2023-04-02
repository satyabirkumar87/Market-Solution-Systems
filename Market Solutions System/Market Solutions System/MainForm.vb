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
    End Sub

    Private Sub AddProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductToolStripMenuItem.Click
        Me.Hide()
        AddProductForm.Show()
    End Sub

    Private Sub ViewProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductsToolStripMenuItem.Click
        Me.Hide()
        ViewProducts.Show()
    End Sub

    Private Sub AddManufacturerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddManufacturerToolStripMenuItem.Click
        Me.Hide()
        AddManufacturer.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub CashSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashSalesToolStripMenuItem.Click
        Me.Hide()
        BillForm1.Show()
    End Sub
End Class
