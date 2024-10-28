Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Tls

Public Class Data_Katalog
    Private Sub LoadKatalog()
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            If connection IsNot Nothing Then
                Try
                    Dim query As String = "SELECT kode_produk, nama_produk, jenis_produk, deskripsi FROM katalog WHERE kode_peternakan = '" & Module_Koneksi.GetKodePeternakan() & "'"
                    Using command As New MySqlCommand(query, connection)
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            ListView1.Items.Clear()
                            While reader.Read()
                                Dim item As New ListViewItem(reader("kode_produk").ToString())
                                item.SubItems.Add(reader("nama_produk").ToString())
                                item.SubItems.Add(reader("jenis_produk").ToString())
                                item.SubItems.Add(reader("deskripsi").ToString())
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

    Private Sub reset()
        text_kodeProduk.Text = ""
        text_namaProduk.Text = ""
        combo_jenisProduk.SelectedIndex = 0
        text_deskripsi.Text = ""
    End Sub
    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dashboard_Peternak.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Ubah_Peternakan.Show()
        Me.Hide()
    End Sub

    Private Sub Data_Katalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKatalog()
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        If e.IsSelected Then
            Dim kode_produk As String = e.Item.SubItems(0).Text
            Dim nama_produk As String = e.Item.SubItems(1).Text
            Dim jenis_produk As String = e.Item.SubItems(2).Text
            Dim deskripsi As String = e.Item.SubItems(3).Text
            text_kodeProduk.Text = kode_produk
            text_namaProduk.Text = nama_produk
            combo_jenisProduk.SelectedItem = jenis_produk
            text_deskripsi.Text = deskripsi
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim query As String = "INSERT INTO katalog (kode_produk, nama_produk, jenis_produk, kode_peternakan, deskripsi) VALUES (@kode_produk, @nama_produk, @jenis_produk, @kode_peternakan, @deskripsi)"
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@kode_produk", text_kodeProduk.Text)
                command.Parameters.AddWithValue("@nama_produk", text_namaProduk.Text)
                command.Parameters.AddWithValue("@jenis_produk", combo_jenisProduk.SelectedItem.ToString())
                command.Parameters.AddWithValue("@kode_peternakan", Module_Koneksi.GetKodePeternakan())
                command.Parameters.AddWithValue("@deskripsi", text_deskripsi.Text)
                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Data Katalog ditambahkan!")
                Catch ex As Exception
                    MessageBox.Show("Terjadi Kesalahan, mohon coba lagi!")
                Finally
                    LoadKatalog()
                    reset()
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim query As String = "UPDATE katalog SET nama_produk = @nama_produk, jenis_produk = @jenis_produk, deskripsi = @deskripsi WHERE kode_produk = @kode_produk"
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nama_produk", text_namaProduk.Text)
                command.Parameters.AddWithValue("@jenis_produk", combo_jenisProduk.SelectedItem.ToString())
                command.Parameters.AddWithValue("@deskripsi", text_deskripsi.Text)
                command.Parameters.AddWithValue("@kode_produk", text_kodeProduk.Text)
                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Data Katalog diubah!")
                Catch ex As Exception
                    MessageBox.Show("Terjadi Kesalahan, mohon coba lagi!")
                Finally
                    LoadKatalog()
                    reset()
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim query As String = "DELETE FROM katalog WHERE kode_produk = @kode_produk"
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@kode_produk", text_kodeProduk.Text)
                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Data Katalog dihapus!")
                Catch ex As Exception
                    MessageBox.Show("Terjadi Kesalahan, mohon coba lagi!")
                Finally
                    LoadKatalog()
                    reset()
                End Try
            End Using
        End Using
    End Sub
End Class