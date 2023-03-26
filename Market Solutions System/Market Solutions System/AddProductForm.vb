Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class AddProductForm
    Private conn As SQLiteConnection = MainForm.conn

    Private Sub FillCombo()
        conn.Open()
        Dim cmd As New SQLiteCommand("select * from product", conn)
        Dim adapter As New SQLiteDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        ComboBox1.DataSource = Tbl
        ComboBox1.DisplayMember = "Name"
        ComboBox1.ValueMember = "Name"
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Dim query As String
        query = " insert into product values('" & TextBox1.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.SelectedValue & "','" & TextBox4.Text & "', '" & TextBox2.Text & "')"
        Dim cmd As SQLiteCommand
        cmd = New SQLiteCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Product Added Successfully")
        conn.Close()
    End Sub
End Class
