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

        MessageBox.Show("purchase sucessful")


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

    Private Sub ProdNameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProdNameCB.SelectedIndexChanged
        If (ProdNameCB.SelectedItem = "coco cola") Then
            PriceTB.Clear()
            PriceTB.Text = "20"
        ElseIf (ProdNameCB.SelectedItem = "kurkure") Then
            PriceTB.Clear()
            PriceTB.Text = "50"
        ElseIf (ProdNameCB.SelectedItem = "kitkat") Then
            PriceTB.Clear()
            PriceTB.Text = "35"
        ElseIf (ProdNameCB.SelectedItem = "jam") Then
            PriceTB.Clear()
            PriceTB.Text = "95"
        ElseIf (ProdNameCB.SelectedItem = "Bourborn") Then
            PriceTB.Clear()
            PriceTB.Text = "45"
        ElseIf (ProdNameCB.SelectedItem = "Lays") Then
            PriceTB.Clear()
            PriceTB.Text = "39"
        ElseIf (ProdNameCB.SelectedItem = "Top") Then
            PriceTB.Clear()
            PriceTB.Text = "100"
        ElseIf (ProdNameCB.SelectedItem = "Amul") Then
            PriceTB.Clear()
            PriceTB.Text = "60"

        End If
    End Sub
End Class