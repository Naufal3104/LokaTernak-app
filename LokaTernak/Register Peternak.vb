Imports MySql.Data.MySqlClient

Public Class Register_Peternak
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

    Private Function GenerateKodePeternakan() As String
        Dim kodeTerakhir As String = ""
        Dim query As String = "select kode_peternakan from peternakan order by kode_peternakan DESC LIMIT 1"

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
            Return "PRT001"
        End If

        Dim nomor As Integer = Integer.Parse(kodeTerakhir.Substring(3))
        nomor += 1

        Return "PTR" & nomor.ToString("D3")
    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            'siapkan command dengan parameter
            Dim query As String = "insert into peternakan (kode_peternakan, nama_peternakan, deskripsi, alamat, email, username, password) values (@kode, @nama, @deskripsi, @alamat, @email, @username, @password)"
            Using conn As MySqlConnection = Module_Koneksi.GetConnection()
                'membuat command dan menambahkan pararmeter
                Using cmd As New MySqlCommand(query, conn)
                    'menambahkan parameter
                    cmd.Parameters.AddWithValue("@kode", text_kode.Text)
                    cmd.Parameters.AddWithValue("@nama", text_nama_peternakan.Text)
                    cmd.Parameters.AddWithValue("@deskripsi", text_deskripsi.Text)
                    cmd.Parameters.AddWithValue("@alamat", text_alamat.Text)
                    cmd.Parameters.AddWithValue("@email", text_email.Text)
                    cmd.Parameters.AddWithValue("@username", text_username.Text)
                    cmd.Parameters.AddWithValue("@password", text_password.Text)

                    ' Eksekusi perintah
                    cmd.ExecuteNonQuery()
                    text_kode.Text = GenerateKodePeternakan()
                End Using
            End Using

            MessageBox.Show("Data berhasil ditambahkan")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        text_kode.Text = GenerateKodePeternakan()
    End Sub

    Private Sub Register_Peternak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        text_kode.Text = GenerateKodePeternakan()
    End Sub
End Class