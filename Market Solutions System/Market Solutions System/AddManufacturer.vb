Imports System.Data.SQLite

Public Class AddManufacturer
    Private conn As SQLiteConnection = MainForm.conn

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim name As String = NameTB.Text
        Dim phoneNo As String = PhonenoTB.Text
        Dim address As String = AddressTB.Text

        conn.Open()
        Dim sqlQuery As String = $"INSERT INTO company VALUES ('{Name}', '{address}', '{phoneNo}')"
        Dim cmd As New SQLiteCommand(sqlQuery, conn)
        Dim rowsAffected = cmd.ExecuteNonQuery()
        If rowsAffected = 1 Then
            MessageBox.Show("Manufacturer Added")
        End If
        conn.Close()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class