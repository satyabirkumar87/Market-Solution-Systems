Imports System.Data.SQLite
Imports System.Drawing.Printing

Public Class BillForm1
    Private conn As SQLiteConnection = Login.conn
    Private WithEvents PrintDocument1 As New Printing.PrintDocument


    Public Sub New(totalPrice As Integer)
        InitializeComponent()
        TotalPriceLabel.Text = totalPrice.ToString()
        LoadPurchaseHistory()
    End Sub

    Private Sub LoadPurchaseHistory()
        conn.Open()
        Dim sqlQuery As String = $"SELECT Name, Price, Qty FROM product INNER JOIN purchase ON product.Id = purchase.ProductId WHERE purchase.PurchaseDate = '{DateTime.Today.ToString("yyyy-MM-dd")}'"
        Dim cmd As New SQLiteCommand(sqlQuery, conn)
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            Dim productName = reader("Name")
            Dim productPrice = reader("Price")
            Dim productQty = reader("Qty")
            PurchaseHistoryGridView.Rows.Add(productName, productPrice, productQty)
        End While
        reader.Close()
        conn.Close()
    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 12, FontStyle.Regular)

        e.Graphics.DrawString("Product Purchase Bill", font, Brushes.Black, 10, 10)

        e.Graphics.DrawString($"Date: {DateTime.Today.ToShortDateString()}", font, Brushes.Black, 10, 40)

        e.Graphics.DrawString("Product Name", font, Brushes.Black, 10, 80)
        e.Graphics.DrawString("Price", font, Brushes.Black, 200, 80)
        e.Graphics.DrawString("Quantity", font, Brushes.Black, 300, 80)

        Dim startY = 100
        For Each row As DataGridViewRow In PurchaseHistoryGridView.Rows
            Dim productName = row.Cells(0).Value.ToString()
            Dim productPrice = row.Cells(1).Value.ToString()
            Dim productQty = row.Cells(2).Value.ToString()

            e.Graphics.DrawString(productName, font, Brushes.Black, 10, startY)
            e.Graphics.DrawString(productPrice, font, Brushes.Black, 200, startY)
            e.Graphics.DrawString(productQty, font, Brushes.Black, 300, startY)

            startY += 20
        Next

        e.Graphics.DrawString($"Total Price: {TotalPriceLabel.Text}", font, Brushes.Black, 10, startY + 20)
    End Sub
End Class
