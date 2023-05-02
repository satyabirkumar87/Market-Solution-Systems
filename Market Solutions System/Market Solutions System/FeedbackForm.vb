Imports System.Data.SQLite

Public Class FeedbackForm
    Dim conn As SQLiteConnection = Login.conn
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim custFeedback As String = feedbackRTB.Text
        Dim rating As Integer = ratingSelector.Text
        Dim custID As String = Login.CustLoginInfo.id
        Dim prodName As String = productCB.Text
        Dim sqlQuery As String = $"INSERT INTO FEEDBACK(CustID, ProdName, Rating, Feedback) VALUES ('{custID}', '{prodName}', {rating}, '{custFeedback}');"
        conn.Open()
        Dim cmd As New SQLiteCommand(sqlQuery, conn)
        Dim rowsAffected = cmd.ExecuteNonQuery()
        If rowsAffected = 1 Then
            MessageBox.Show("We Appreciate your feedback 😊")
        End If
        conn.Close()
        ratingSelector.Text = ""
        productCB.Text = ""
        feedbackRTB.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CustomerHomeForm.Show()
    End Sub

    Private Sub FeedbackForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ratingSelector.Items.Add(1)
        ratingSelector.Items.Add(2)
        ratingSelector.Items.Add(3)
        ratingSelector.Items.Add(4)
        ratingSelector.Items.Add(5)
        ratingSelector.Items.Add(6)
        ratingSelector.Items.Add(7)
        ratingSelector.Items.Add(8)
        ratingSelector.Items.Add(9)
        ratingSelector.Items.Add(10)

        conn.Open()
        Dim sqlQuery As String = "SELECT * FROM product;"
        Dim cmd As New SQLiteCommand(sqlQuery, conn)
        Dim reader = cmd.ExecuteReader()
        While reader.Read()
            productCB.Items.Add(reader("Name"))
        End While
        reader.Close()
        conn.Close()
    End Sub
End Class