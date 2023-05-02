Imports System.Data.SQLite
Imports System.IO

Public Class Login
    Public conn As SQLiteConnection
    Public CustLoginInfo As New LoginInfo
    Public Sub New()
        InitializeComponent()
        Dim path, dbPath, connString As String
        path = Directory.GetCurrentDirectory()
        dbPath = IO.Path.Combine(path, "..\..\..\database.db")
        connString = $"Data Source={dbPath}"
        conn = New SQLiteConnection(connString)
    End Sub

    Private Sub AdminLoginButton_Click(sender As Object, e As EventArgs) Handles admLoginBtn.Click
        Dim username As String = admUsernameTB.Text
        Dim password As String = admPasswordTB.Text
        If username = "admin" AndAlso password = "admin" Then
            Dim mainForm As New MainForm()
            mainForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Details")
        End If
    End Sub

    Private Sub custLoginBtn_Click(sender As Object, e As EventArgs) Handles custLoginBtn.Click
        Dim username As String = custUsernameTB.Text
        Dim password As String = custPasswordTB.Text
        conn.Open()
        Dim sqlQuery As String = $"SELECT * FROM customer WHERE Username='{username}' AND Password='{password}'"
        Dim cmd As New SQLiteCommand(sqlQuery, conn)
        Dim reader = cmd.ExecuteReader()
        If reader.Read() Then
            If reader("Username") = username And reader("Password") = password Then
                CustLoginInfo.username = reader("Username")
                CustLoginInfo.id = reader("ID")
                CustLoginInfo.gender = reader("Gender")
                CustLoginInfo.phoneno = reader("PhoneNo")
                CustLoginInfo.address = reader("Address")

                MessageBox.Show("Login Successfull")
                reader.Close()
                conn.Close()
                Me.Hide()
                CustomerHomeForm.Show()
            End If
        Else
            MessageBox.Show("Login Failed")
        End If
        reader.Close()
        conn.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub custPasswordTB_TextChanged(sender As Object, e As EventArgs) Handles custPasswordTB.TextChanged

    End Sub
End Class





Public Class LoginInfo
    Public username As String = ""
    Public id As String = ""
    Public gender As String = ""
    Public phoneno As String = ""
    Public address As String = ""
End Class