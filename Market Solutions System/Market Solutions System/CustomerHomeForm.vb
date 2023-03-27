Public Class CustomerHomeForm
    Private Sub PurchaseProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseProductToolStripMenuItem.Click
        Me.Hide()
        ProductPurchase.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()


    End Sub





    Private Sub CustomerHomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RateToolStripMenuItem.Click

    End Sub
End Class