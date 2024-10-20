Imports MySql.Data.MySqlClient

Public Class Sign_In
    Private Sub Sign_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        text_username.Text = "Username"
        text_username.ForeColor = Color.DarkGray
        text_password.Text = "Password"
        text_password.ForeColor = Color.DarkGray

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

    Private Sub button_login_Click(sender As Object, e As EventArgs) Handles button_login.Click
        Dim username As String = text_username.Text
        Dim password As String = text_password.Text

        ' Menggunakan koneksi dari Module_Koneksi
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            If connection IsNot Nothing Then
                Try
                    ' Memperbarui query untuk mengambil role
                    Dim query As String = "SELECT id_role FROM user WHERE username=@username AND password=@password"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@username", username)
                        command.Parameters.AddWithValue("@password", password)

                        Dim role As String = Convert.ToString(command.ExecuteScalar())
                        If Not String.IsNullOrEmpty(role) Then
                            MessageBox.Show("Login Berhasil! Role: " & role)

                            ' Arahkan ke form berdasarkan role
                            Select Case role
                                Case 1
                                    Dashboard_Admin.Show()
                                    Me.Hide() ' Sembunyikan form login
                                Case 2
                                    Dashboard_User.Show()
                                    Me.Hide() ' Sembunyikan form login
                                Case Else
                                    MessageBox.Show("Role tidak dikenali.")
                            End Select
                        Else
                            MessageBox.Show("Username atau Password salah.")
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End If
        End Using
    End Sub
End Class


