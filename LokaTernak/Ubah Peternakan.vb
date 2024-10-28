Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Ubah_Peternakan
    Private Sub tampil_dataPeternakan()
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Dim query As String = "SELECT nama_peternakan, alamat, deskripsi, email, username, password FROM peternakan WHERE kode_peternakan = @kode_peternakan"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@kode_peternakan", Module_Koneksi.GetKodePeternakan())
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        text_namaPeternakan.Text = reader("nama_peternakan").ToString()
                        text_alamat.Text = reader("alamat").ToString()
                        text_deskripsi.Text = reader("deskripsi").ToString()
                        text_email.Text = reader("email").ToString()
                        text_username.Text = reader("username").ToString()
                        text_password.Text = reader("password").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dashboard_Peternak.Show()
        Me.Hide()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Data_Katalog.Show()
        Me.Hide()
    End Sub
    Private Sub Ubah_Peternakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_dataPeternakan()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim query As String = "UPDATE peternakan SET nama_peternakan = @nama_peternakan, deskripsi = @deskripsi, alamat = @alamat, email = @email, username = @username, password = @password WHERE kode_peternakan = @kode_peternakan"
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nama_peternakan", text_namaPeternakan.Text)
                command.Parameters.AddWithValue("@deskripsi", text_deskripsi.Text)
                command.Parameters.AddWithValue("@alamat", text_alamat.Text)
                command.Parameters.AddWithValue("@email", text_email.Text)
                command.Parameters.AddWithValue("@username", text_username.Text)
                command.Parameters.AddWithValue("@password", text_password.Text)
                command.Parameters.AddWithValue("@kode_peternakan", Module_Koneksi.GetKodePeternakan())
                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Data Peternakan diubah!")
                Catch ex As Exception
                    MessageBox.Show("Terjadi Kesalahan, mohon coba lagi!")
                Finally
                    tampil_dataPeternakan()
                End Try
            End Using
        End Using
    End Sub
End Class