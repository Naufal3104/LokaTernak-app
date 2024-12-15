Imports System.Data.Common
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Order_Peternak
    Private barangList As New List(Of Tuple(Of String, String))()
    Private dataAdapter As MySqlDataAdapter
    Private dataSet As DataSet
    Public Sub InsertOrder()
        Dim pelanggan As String = tbNama.Text
        Dim kodeProduk As String = tbKodeProduk.Text
        Dim jumlah As Integer = tbJumlah.Value
        Dim totalHarga As Decimal = tbTotal.Text
        Dim tanggalOrder As DateTime = tbTanggal.Value

        'Validasi nama pelanggan
        If String.IsNullOrWhiteSpace(pelanggan) Then
            MessageBox.Show("Nama pelanggan harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Validasi barang harus dipilih
        If tbProduk.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih barang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Validasi Jumlah
        If jumlah <= 0 Then
            MessageBox.Show("Jumlah barang harus > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim conn As MySqlConnection = GetConnection()
        Dim query As String = "INSERT INTO transaksi (Pelanggan, kode_produk, Jumlah, TotalHarga, TanggalOrder) VALUES (@Pelanggan, @kode_produk, @Jumlah, @TotalHarga, @TanggalOrder)"
        Using cmd As New MySqlCommand(query, conn)
            Try
                cmd.Parameters.AddWithValue("@Pelanggan", pelanggan)
                cmd.Parameters.AddWithValue("@kode_produk", kodeProduk)
                cmd.Parameters.AddWithValue("@Jumlah", jumlah)
                cmd.Parameters.AddWithValue("@TotalHarga", totalHarga)
                cmd.Parameters.AddWithValue("@TanggalOrder", tanggalOrder)
                cmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("Order berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Reset form dan refresh data
                RefreshForm()
            Catch ex As Exception
                MessageBox.Show("Error saving order: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub
    Private Sub RefreshForm()
        tbNama.Clear() ' Clear the customer name input
        'tbNama.Focus() ' Set focus back to the customer name TextBox
        tbKodeProduk.Clear()
        tbTotal.Clear()
        tbJumlah.Value = 0
        LoadData()
    End Sub
    Private Sub pesan_Click(sender As Object, e As EventArgs) Handles tbPesan.Click
        InsertOrder()
    End Sub

    Sub LoadData()
        Dim selectQuery As String = "SELECT pelanggan AS Pelanggan, kode_produk AS 'Kode Produk', jumlah AS 'Jumlah', total_harga AS 'Total Harga', tanggal_order AS 'Tanggal Order' FROM transaksi"
        Dim conn As MySqlConnection = GetConnection()
        dataAdapter = New MySqlDataAdapter(selectQuery, conn)
        dataSet = New DataSet()
        Try
            dataAdapter.Fill(dataSet, "transaksi")
            Guna2DataGridView1.DataSource = dataSet.Tables("transaksi")
        Catch ex As MySqlException
            MessageBox.Show("Error : " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadBarangList()
        Dim query As String = "SELECT kode_produk, nama_produk , jenis_produk FROM katalog"
        'Panggil koneksi dari modul modKoneksi
        Dim conn As MySqlConnection = GetConnection()
        Using command As New MySqlCommand(query, conn)
            Try
                Dim reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    'Tambahkan Nama_Barang ke ComboBox
                    Dim namaBarang As String = reader("nama_produk").ToString()
                    Dim kodeBarang As String = reader("kode_produk").ToString()

                    tbProduk.Items.Add(namaBarang)

                    'Simpan Nama_Barang dan Jenis ke dalam List
                    barangList.Add(Tuple.Create(namaBarang, kodeBarang))
                End While
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error loading barang list: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub cbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbProduk.SelectedIndexChanged
        Dim selectedBarang As String = tbProduk.SelectedItem.ToString()

        'Cari jenis barang berdasarkan Nama_Barang yang dipilih
        For Each barang In barangList
            If barang.Item1 = selectedBarang Then
                tbKodeProduk.Text = barang.Item2
                Exit For
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbKodeProduk.ReadOnly = True
        LoadBarangList()
        LoadData()
    End Sub

    Private Sub Guna2Button14_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dashboard_Peternak.Show()
    End Sub

    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Data_Katalog.Show()
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Ubah_Peternakan.Show()
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Diskusi_Peternak.Show()
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Artikel_Peternak.Show()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Hide()
        Dashboard_Peternak.Show()
    End Sub

    Private Sub Guna2Button9_Click_1(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Me.Hide()
        Data_Katalog.Show()
    End Sub

    Private Sub Guna2Button10_Click_1(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Me.Hide()
        Ubah_Peternakan.Show()
    End Sub

    Private Sub Guna2Button15_Click(sender As Object, e As EventArgs) Handles Guna2Button15.Click
        Me.Hide()
        Diskusi_Peternak.Show()
    End Sub

    Private Sub Guna2Button14_Click_1(sender As Object, e As EventArgs) Handles Guna2Button14.Click
        Me.Hide()
        Artikel_Peternak.Show()
    End Sub

    Private Sub Guna2Button12_Click_1(sender As Object, e As EventArgs) Handles Guna2Button12.Click
        Me.Hide()
        Laporan_Peternak.Show()
    End Sub

    Private Sub Guna2Button16_Click(sender As Object, e As EventArgs) Handles Guna2Button16.Click
        Me.Hide()
        Main_Form.Show()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub
End Class