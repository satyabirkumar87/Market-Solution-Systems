Imports System.Data.SQLite

Public Class ProductPurchase
    Private conn As SQLiteConnection = Login.conn
    Dim ProductList As New Dictionary(Of String, Integer)
    Private Sub Purchase_Click(sender As Object, e As EventArgs) Handles PurchaseBtn.Click
        If ProdNameCB.Text = "" Or QtyTB.Text = "" Then
            MessageBox.Show("Select A Product And Enter Quantity First")
        Else
            totalTB.Text = CInt(PriceTB.Text) * CInt(QtyTB.Text)
            conn.Open()
            Dim sqlQuery As String = $"UPDATE product SET ProdQty = ProdQty - {QtyTB.Text} WHERE Name='{ProdNameCB.Text}'"
            Dim cmd As New SQLiteCommand(sqlQuery, conn)
            Dim rowsAffected = cmd.ExecuteNonQuery()
            If rowsAffected = 1 Then
                MessageBox.Show("Purchase Sucessful")
            End If
            conn.Close()
        End If


    End Sub

    Private Sub ProductPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add items to dictionary
        conn.Open()
        Dim cmd As New SQLiteCommand("select * from product", conn)
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            ProductList.Add(reader("Name"), reader("Price"))
        End While
        reader.Close()
        conn.Close()

        ' Loop through each key in the dictionary and add it to the dropdown
        For Each prodName As String In ProductList.Keys
            ProdNameCB.Items.Add(prodName)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CustomerHomeForm.Show()
    End Sub

    Private Sub ProdNameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProdNameCB.SelectedIndexChanged
        PriceTB.Text = ProductList.Item(ProdNameCB.Text)
    End Sub
End Class