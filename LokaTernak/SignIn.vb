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

        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            If connection IsNot Nothing Then
                Try
                    Dim queryUser As String = "SELECT id_role FROM user WHERE username=@username AND password=@password"
                    Using command As New MySqlCommand(queryUser, connection)
                        command.Parameters.AddWithValue("@username", username)
                        command.Parameters.AddWithValue("@password", password)

                        Dim role As String = Convert.ToString(command.ExecuteScalar())
                        If Not String.IsNullOrEmpty(role) Then
                            MessageBox.Show("Login Berhasil! Role: " & role)
                            Select Case role
                                Case 1
                                    Dashboard_Admin.Show()
                                    Me.Hide()
                                Case 2
                                    Dash_User.Show()
                                    Me.Hide()
                                Case Else
                                    MessageBox.Show("Role tidak dikenali.")
                            End Select
                        Else
                            Dim queryFarm As String = "SELECT kode_peternakan FROM peternakan WHERE username=@username AND password=@password"
                            Using farmCommand As New MySqlCommand(queryFarm, connection)
                                farmCommand.Parameters.AddWithValue("@username", username)
                                farmCommand.Parameters.AddWithValue("@password", password)

                                Using reader As MySqlDataReader = farmCommand.ExecuteReader()
                                    If reader.Read() Then
                                        MessageBox.Show("Login sebagai Peternak berhasil!")
                                        Dim kodePeternakan As String = reader("kode_peternakan").ToString()
                                        Module_Koneksi.SetKodePeternakan(kodePeternakan)
                                        Dashboard_Peternak.Show()
                                        Me.Hide()
                                    Else
                                        MessageBox.Show("Username atau Password salah.")
                                    End If
                                End Using
                            End Using
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End If
            text_username.Text = ""
            text_password.Text = ""
        End Using
    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        text_username.Text = ""
        text_password.Text = ""
        Me.Hide()
        Main_Form.Show()
    End Sub
End Class


