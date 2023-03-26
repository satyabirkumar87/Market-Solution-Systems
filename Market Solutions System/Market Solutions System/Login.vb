Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        If username = "admin" AndAlso password = "admin" Then
            Dim mainForm As New MainForm()
            mainForm.show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Details")
        End If
    End Sub
End Class