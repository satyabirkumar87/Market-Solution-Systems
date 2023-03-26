Imports System.Data.SQLite


Public Class ProductPurchase
    Private conn As SQLiteConnection = MainForm.conn
    Private Sub Purchase_Click(sender As Object, e As EventArgs) Handles PurchaseBtn.Click
        Dim ProdName As String = ProdNameCB.Text
        Dim price As Integer = PriceTB.Text
        Dim quantity As Integer = QtyTB.Text
        MessageBox.Show(ProdName)
        MessageBox.Show(price)
        MessageBox.Show(quantity)


    End Sub

    Private Sub ProductPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' conn.Open()
        ' Dim cmd As New SQLiteCommand("select * from product", conn)
        'Dim reader = cmd.ExecuteReader()
        'While reader.Read()
        'ProdNameCB.Items.Add(reader("Name"))
        'End While
        'conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CustomerHomeForm.Show()
    End Sub
End Class