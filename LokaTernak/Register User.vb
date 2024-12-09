Imports MySql.Data.MySqlClient

Public Class Register_User
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Sub koneksi()
        conn.ConnectionString = "server=localhost;user id=root;" & "password=;database=peternakan"

        Try
            conn.Open()
            MsgBox("Koneksi Berhasil")
        Catch myerror As MySqlException
            MsgBox("Error Koneksi : " & myerror.Message)
            conn.Close()
        End Try
    End Sub

    Private Function GenerateKodeUser() As String
        Dim kodeTerakhir As String = ""
        Dim query As String = "select kode_user from user order by kode_user DESC LIMIT 1"

        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Using command As New MySqlCommand(query, connection)
                Try
                    Dim result = command.ExecuteScalar
                    If result IsNot Nothing Then
                        kodeTerakhir = result.ToString()
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                End Try
            End Using
        End Using

        If String.IsNullOrEmpty(kodeTerakhir) Then
            Return "USR001"
        End If

        Dim nomor As Integer = Integer.Parse(kodeTerakhir.Substring(3))
        nomor += 1

        Return "USR" & nomor.ToString("D3")
    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            'siapkan command dengan parameter
            Dim query As String = "insert into user (kode_user, id_role, username, password, email, no_telpon) values (@kode, @id_role, @nama, @password, @email, @no_telpon)"
            Using connection As MySqlConnection = Module_Koneksi.GetConnection()
                Using cmd As New MySqlCommand(query, connection)
                    'menambahkan parameter
                    cmd.Parameters.AddWithValue("@kode", text_kode_user.Text)
                    cmd.Parameters.AddWithValue("@id_role", 2)
                    cmd.Parameters.AddWithValue("@nama", text_username.Text)
                    cmd.Parameters.AddWithValue("@password", text_password.Text)
                    cmd.Parameters.AddWithValue("@email", text_email.Text)
                    cmd.Parameters.AddWithValue("@no_telpon", text_noTelp.Text)
                    'eksekusi perintah
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Data berhasil ditambahkan")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        text_kode_user.Text = GenerateKodeUser()
    End Sub

    Private Sub Register_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        text_kode_user.Text = GenerateKodeUser()
    End Sub
End Class