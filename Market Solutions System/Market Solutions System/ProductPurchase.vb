Imports System.Data.SQLite

Public Class ProductPurchase
    Private conn As SQLiteConnection = Login.conn
    Dim ProductList As New Dictionary(Of String, Integer)

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


    Private Sub Purchase_Click(sender As Object, e As EventArgs) Handles PurchaseBtn.Click
        If ProdNameCB.Text = "" Or QtyTB.Text = "" Then
            MessageBox.Show("Select A Product And Enter Quantity First")
        Else
            totalTB.Text = CInt(PriceTB.Text) * CInt(QtyTB.Text)
            conn.Open()
            For Each row As DataGridViewRow In OrderDGV.Rows
                Dim prodName As String = row.Cells(0).Value
                Dim prodQty As String = row.Cells(2).Value
                If Not prodName = "" Then
                    Dim sqlQuery As String = $"UPDATE product SET ProdQty = ProdQty - {prodQty} WHERE Name='{prodName}'"
                    Dim purchaseQuery As String = $"INSERT INTO cash_sale (ProdName, ProdQty, Discount) Values ('{prodName}', {prodQty}, 0)"
                    MessageBox.Show(sqlQuery)
                    MessageBox.Show(purchaseQuery)
                    Dim cmd As New SQLiteCommand(sqlQuery, conn)
                    Dim purchaseCmd As New SQLiteCommand(purchaseQuery, conn)
                    cmd.ExecuteNonQuery()
                    purchaseCmd.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("Purchase Sucessful")
            conn.Close()
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CustomerHomeForm.Show()
    End Sub

    Private Sub ProdNameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProdNameCB.SelectedIndexChanged
        If Not String.IsNullOrEmpty(ProdNameCB.Text) AndAlso ProductList.ContainsKey(ProdNameCB.Text) Then
            PriceTB.Text = ProductList.Item(ProdNameCB.Text)
            QtyTB.Text = 1
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProdNameCB.SelectedIndex = -1
        QtyTB.Clear()
        PriceTB.Clear()
        totalTB.Clear()
        OrderDGV.Rows.Clear()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim prodFound As Integer = 0
        If QtyTB.Text = "" Then
            MessageBox.Show("Enter Quantity First")
            Return
        End If
        For Each row As DataGridViewRow In OrderDGV.Rows
            If row.Cells(0).FormattedValue = ProdNameCB.Text Then
                prodFound = 1
                row.Cells(2).Value += CInt(QtyTB.Text)
                row.Cells(3).Value = CInt(row.Cells(2).FormattedValue) * CInt(PriceTB.Text)
            End If
        Next
        If prodFound = 0 Then
            Dim index As Integer = OrderDGV.Rows.Add()
            Dim prodName As String = ProdNameCB.Text
            Dim prodPrice As Integer = CInt(PriceTB.Text)
            Dim ProdQty As Integer = CInt(QtyTB.Text)
            OrderDGV.Rows(index).Cells("ProdName").Value = ProdNameCB.Text
            OrderDGV.Rows(index).Cells("ProdPrice").Value = prodPrice
            OrderDGV.Rows(index).Cells("ProdQty").Value = ProdQty
            OrderDGV.Rows(index).Cells("Total").Value = prodPrice * ProdQty
        End If
    End Sub
End Class