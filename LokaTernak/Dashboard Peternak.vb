Imports MySql.Data.MySqlClient

Public Class Dashboard_Peternak
    Private Sub LoadKatalog()
        ' Menggunakan koneksi dari Module_Koneksi
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            If connection IsNot Nothing Then
                Try
                    ' Query untuk mengambil semua data dari tabel katalog
                    Dim query As String = "SELECT kode_produk, nama_produk, jenis_produk, deskripsi FROM katalog WHERE kode_peternakan = '" & Module_Koneksi.GetKodePeternakan() & "'"
                    Using command As New MySqlCommand(query, connection)
                        ' Eksekusi query dan menggunakan MySqlDataReader untuk membaca data
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            ' Kosongkan ListView sebelum mengisi data baru
                            ListView1.Items.Clear()

                            ' Membaca data dari reader
                            While reader.Read()
                                ' Membuat item baru untuk ListView
                                Dim item As New ListViewItem(reader("kode_produk").ToString())
                                item.SubItems.Add(reader("nama_produk").ToString())
                                item.SubItems.Add(reader("jenis_produk").ToString())
                                item.SubItems.Add(reader("deskripsi").ToString())

                                ' Menambahkan item ke ListView
                                ListView1.Items.Add(item)
                            End While
                        End Using
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End If
        End Using
    End Sub

    Private Sub Dashboard_Peternak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKatalog()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Data_Katalog.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Ubah_Peternakan.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub
End Class