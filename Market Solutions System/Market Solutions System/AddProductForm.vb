Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class AddProductForm
    Private conn As SQLiteConnection = MainForm.conn

    Private Sub FillCombo()
        conn.Open()
        Dim cmd As New SQLiteCommand("select * from company", conn)
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            CompCb.Items.Add(reader("Name"))
        End While
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prodName As String = ProdNameTB.Text
        Dim quantity As String = QtyTB.Text
        Dim price As Integer = CInt(UnitPriceTB.Text)
        Dim compName As String = CompCb.Text

        conn.Open()
        Dim query As String
        ' query = " insert into product values('" & ProdName.Text & "', '" & CompCb.SelectedValue.ToString() & "'," & UnitPrice.Text & ", " & Qty.Text & ")"
        query = $"INSERT INTO product VALUES ('{prodName}', '{compName}', {price}, {quantity})"

        MessageBox.Show(query)
        Dim cmd = New SQLiteCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Product Added Successfully")
        conn.Close()
    End Sub

    Private Sub AddProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class
