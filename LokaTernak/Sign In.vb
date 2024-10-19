Imports MySql.Data.MySqlClient

Public Class Sign_In
    Private Sub Sign_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        text_username.Text = "Username"
        text_username.ForeColor = Color.DarkGray
        text_password.Text = "Password"
        text_password.ForeColor = Color.DarkGray

        'Panggil fungsi koneksi dari modul modKoneksi
        Dim conn As MySqlConnection = GetConnection()
        If conn.State = ConnectionState.Open Then
            Console.WriteLine("Koneksi berhasil!")
        Else
            Console.WriteLine("Koneksi gagal.")
        End If
        'Pastikan untuk menutup koneksi setelah selesai digunakan
        conn.Close()
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username=@username
        AND password=@password"
        'Panggil koneksi dari modul modKoneksi
        Dim conn As MySqlConnection = GetConnection()
        Using command As New MySqlCommand(query, conn)
            ' Parameterisasi query untuk mencegah SQL Injection
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)
            Try
                'Eksekusi query dan ambil hasilnya
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                'Jika hasilnya lebih besar dari 0, user ditemukan
                Return result > 0
            Catch ex As MySqlException
                MessageBox.Show("Error saat login: " & ex.Message)
                Return False
            Finally
                'Pastikan koneksi ditutup
                conn.Close()
            End Try
        End Using
    End Function

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username As String = text_username.Text
        Dim password As String = text_password.Text
        'Check if fields are not empty
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Username and password cannot be empty.")
            Exit Sub
        End If
        'Autentifikasi user
        If AuthenticateUser(username, password) Then
            'Jika login berhasil
            MessageBox.Show("Login successful!")
            Me.Hide()
            Dashboard.Show()
        Else
            'Jika login failed, show error message
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub
    Private Sub text_username_GotFocus(sender As Object, e As EventArgs) Handles text_username.GotFocus
        If text_username.Text = "Username" Then
            text_username.Text = ""
            text_username.ForeColor = Color.Black
        End If
    End Sub

    Private Sub text_username_LostFocus(sender As Object, e As EventArgs) Handles text_username.LostFocus
        If text_username.Text = "" Then
            text_username.Text = "Username"
            text_username.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub text_password_GotFocus(sender As Object, e As EventArgs) Handles text_password.GotFocus
        If text_password.Text = "Password" Then
            text_password.Text = ""
            text_password.PasswordChar = "•"
            text_password.ForeColor = Color.Black
        End If
    End Sub

    Private Sub text_password_LostFocus(sender As Object, e As EventArgs) Handles text_password.LostFocus
        If text_password.Text = "" Then
            text_password.Text = "Password"
            text_password.PasswordChar = ""
            text_password.ForeColor = Color.DarkGray
        End If
    End Sub
End Class

'Imports MySql.Data.MySqlClient
'Public Class Form1
'    'Sub koneksi()
'    '    conn.ConnectionString = "server=localhost;user id=root;" & "password=;database=db_trial"

'    '    'Try
'    '    '    conn.Open()
'    '    '    MsgBox("Koneksi Berhasil")
'    '    'Catch myerror As MySqlException
'    '    '    MsgBox("Error Koneksi : " & myerror.Message)
'    '    '    conn.Close()
'    '    'End Try
'    'End Sub
'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        text_username.Text = "Username"
'        text_username.ForeColor = Color.DarkGray
'        text_password.Text = "Password"
'        text_password.ForeColor = Color.DarkGray

'        'Panggil fungsi koneksi dari modul modKoneksi
'        Dim conn As MySqlConnection = GetConnection()
'        If conn.State = ConnectionState.Open Then
'            Console.WriteLine("Koneksi berhasil!")
'        Else
'            Console.WriteLine("Koneksi gagal.")
'        End If
'        'Pastikan untuk menutup koneksi setelah selesai digunakan
'        conn.Close()
'    End Sub

'    Private Function AuthenticateUser(username As String, password As String) As Boolean
'        Dim query As String = "SELECT COUNT(*) FROM users WHERE username=@username
'    AND password=@password"
'        'Panggil koneksi dari modul modKoneksi
'        Dim conn As MySqlConnection = GetConnection()
'        Using command As New MySqlCommand(query, conn)
'            ' Parameterisasi query untuk mencegah SQL Injection
'            command.Parameters.AddWithValue("@username", username)
'            command.Parameters.AddWithValue("@password", password)
'            Try
'                'Eksekusi query dan ambil hasilnya
'                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
'                'Jika hasilnya lebih besar dari 0, user ditemukan
'                Return result > 0
'            Catch ex As MySqlException
'                MessageBox.Show("Error saat login: " & ex.Message)
'                Return False
'            Finally
'                'Pastikan koneksi ditutup
'                conn.Close()
'            End Try
'        End Using
'    End Function

'    Private Sub button_login_Click(sender As Object, e As EventArgs) Handles button_login.Click
'        Dim username As String = text_username.Text
'        Dim password As String = text_password.Text
'        'Check if fields are not empty
'        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
'            MessageBox.Show("Username and password cannot be empty.")
'            Exit Sub
'        End If
'        'Autentifikasi user
'        If AuthenticateUser(username, password) Then
'            'Jika login berhasil
'            MessageBox.Show("Login successful!")
'            Me.Hide()
'            Form2.Show()
'        Else
'            'Jika login failed, show error message
'            MessageBox.Show("Invalid username or password.")
'        End If
'    End Sub
'    Private Sub text_username_GotFocus(sender As Object, e As EventArgs) Handles text_username.GotFocus
'        If text_username.Text = "Username" Then
'            text_username.Text = ""
'            text_username.ForeColor = Color.Black
'        End If
'    End Sub

'    Private Sub text_username_LostFocus(sender As Object, e As EventArgs) Handles text_username.LostFocus
'        If text_username.Text = "" Then
'            text_username.Text = "Username"
'            text_username.ForeColor = Color.DarkGray
'        End If
'    End Sub

'    Private Sub text_password_GotFocus(sender As Object, e As EventArgs) Handles text_password.GotFocus
'        If text_password.Text = "Password" Then
'            text_password.Text = ""
'            text_password.PasswordChar = "•"
'            text_password.ForeColor = Color.Black
'        End If
'    End Sub

'    Private Sub text_password_LostFocus(sender As Object, e As EventArgs) Handles text_password.LostFocus
'        If text_password.Text = "" Then
'            text_password.Text = "Password"
'            text_password.PasswordChar = ""
'            text_password.ForeColor = Color.DarkGray
'        End If
'    End Sub


'End Class


