Public Class CustomerHomeForm
    Private Sub PurchaseProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseProductToolStripMenuItem.Click
        Me.Hide()
        ProductPurchase.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()


    End Sub
End Class