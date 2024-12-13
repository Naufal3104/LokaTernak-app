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

    Private Sub ubah_peternakan()
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
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Dashboard_Peternak.Show()
        Me.Hide()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Data_Katalog.Show()
        Me.Hide()
    End Sub
    Private Sub Ubah_Peternakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_dataPeternakan()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrEmpty(text_namaPeternakan.Text) Or String.IsNullOrEmpty(text_alamat.Text) Or String.IsNullOrEmpty(text_deskripsi.Text) Or String.IsNullOrEmpty(text_email.Text) Or String.IsNullOrEmpty(text_username.Text) Or String.IsNullOrEmpty(text_password.Text) Then
            MessageBox.Show("Cek Input Yang Dibutuhkan Sebelum Melakukan Operasi Ini!")
        Else
            ubah_peternakan()
        End If
    End Sub

    Private Sub Ubah_Peternakan_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        tampil_dataPeternakan()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Sign_In.Show()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Diskusi_Peternak.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Artikel_Peternak.Show()
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        Dashboard_Peternak.Show()
    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        Data_Katalog.Show()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Order_Peternak.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

    End Sub

    Private Sub Guna2Button1_Click_2(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Dashboard_Peternak.Show()
    End Sub

    Private Sub Guna2Button2_Click_2(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Data_Katalog.Show()
    End Sub

    Private Sub Guna2Button5_Click_1(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Me.Hide()
        Diskusi_Peternak.Show()
    End Sub

    Private Sub Guna2Button6_Click_1(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Me.Hide()
        Artikel_Peternak.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Me.Hide()
        Order_Peternak.Show()
    End Sub

    Private Sub Guna2Button8_Click_1(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Hide()
        Laporan_Peternak.Show()
    End Sub

    Private Sub Guna2Button4_Click_1(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        Main_Form.Show()
    End Sub
End Class