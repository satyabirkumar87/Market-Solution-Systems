Imports System.Data.SqlClient

Public Class FeedbackForm
    Private connectionString As String = "Data Source=myServerAddress;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;"

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim conn As New SqlConnection(connectionString)
        conn.Open()

        Dim command As New SqlCommand("INSERT INTO Feedback (name, email, message) VALUES (@name, @email, @message)")
        command.Parameters.AddWithValue("@name", txtName.Text)
        command.Parameters.AddWithValue("@email", txtEmail.Text)
        command.Parameters.AddWithValue("@message", txtMessage.Text)
        command.Connection = conn

        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Thank you for your feedback!")
        Catch ex As Exception
            MessageBox.Show("Error submitting feedback: " & ex.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
