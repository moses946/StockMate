Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader
        Dim username As String
        Dim password As String
        Dim query As String
        Dim found As Boolean
        Dim connString As String
        connString = "server=localhost;userid=root;password=;database=stocksasadb"
        conn = New MySqlConnection(connString)
        conn.Open()
        username = TextBox1.Text.Trim
        password = TextBox2.Text.Trim
        query = "SELECT * FROM registered_users WHERE username = '" & username & "' AND password = '" & password & "'"
        cmd = New MySqlCommand(query, conn)
        reader = cmd.ExecuteReader
        found = False
        While reader.Read
            found = True
        End While
        If found = True Then
            MsgBox("Login Successful")
        Else
            MsgBox("Login Failed")
        End If
        conn.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
