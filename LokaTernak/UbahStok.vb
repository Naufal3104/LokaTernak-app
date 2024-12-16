Imports MySql.Data.MySqlClient

Public Class UbahStok
    Public Sub LoadBarangList()
        Dim query As String = "SELECT kode_produk, nama_produk, jenis_produk FROM katalog"
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Using command As New MySqlCommand(query, connection)
                Try
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ComboProduk.Items.Clear()
                        While reader.Read()
                            Dim namaProduk As String = reader("nama_produk").ToString()
                            ComboProduk.Items.Add(namaProduk) ' Tambahkan nama produk ke ComboBox
                        End While
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                Finally
                    connection.Close() ' Pastikan koneksi ditutup
                End Try
            End Using
        End Using
    End Sub

    Public Sub defaultDate()
        tanggal_riwayat.Value = DateTime.Now
    End Sub

    Public Function GenerateKodeRiwayat() As String
        Dim kodeTerakhir As String = ""
        Dim query As String = "SELECT kode_riwayat FROM riwayat_katalog ORDER BY kode_riwayat DESC LIMIT 1"

        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Using command As New MySqlCommand(query, connection)
                Try
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        kodeTerakhir = result.ToString()
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                End Try
            End Using
        End Using

        If String.IsNullOrEmpty(kodeTerakhir) Then
            Return "RWT001"
        End If

        Dim nomor As Integer = Integer.Parse(kodeTerakhir.Substring(3))
        nomor += 1

        Return "RWT" & nomor.ToString("D3")
    End Function

    Private Sub UbahStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBarangList()
        defaultDate()
        NumericKurangi.Enabled = False
        NumericTambah.Enabled = False
    End Sub

    Private Sub buttonBatal_Click(sender As Object, e As EventArgs) Handles buttonBatal.Click
        Me.Hide()
    End Sub

    Private Sub ComboProduk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProduk.SelectedIndexChanged
        If ComboProduk.SelectedItem IsNot Nothing Then
            Dim selectedProductName As String = ComboProduk.SelectedItem.ToString()
            Dim query As String = "SELECT kode_produk FROM katalog WHERE nama_produk = @nama_produk"
            Using connection As MySqlConnection = Module_Koneksi.GetConnection()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@nama_produk", selectedProductName)

                    Try
                        Dim kodeProduk As String = Convert.ToString(command.ExecuteScalar())
                        If Not String.IsNullOrEmpty(kodeProduk) Then
                            textKodeKatalog.Text = kodeProduk
                        Else
                            MessageBox.Show("Kode produk tidak ditemukan.")
                        End If
                    Catch ex As MySqlException
                        MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                    Finally
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            NumericKurangi.Enabled = False ' Nonaktifkan NumericKurangi
            NumericTambah.Enabled = True    ' Aktifkan NumericTambah
        ElseIf radioButton2.Checked Then
            NumericTambah.Enabled = False    ' Nonaktifkan NumericTambah
            NumericKurangi.Enabled = True     ' Aktifkan NumericKurangi
        End If
    End Sub

    Private Sub buttonSimpan_Click(sender As Object, e As EventArgs) Handles buttonSimpan.Click
        Dim kodeRiwayat As String = GenerateKodeRiwayat()

        ' Ambil data dari input pengguna
        Dim kodeProduk As String = textKodeKatalog.Text
        Dim penambahanStok As Integer = NumericTambah.Value
        Dim penguranganStok As Integer = NumericKurangi.Value
        Dim tanggalRiwayat As Date = Date.Now ' Mengambil tanggal saat ini

        ' Validasi input sebelum menyimpan data
        If kodeProduk = "" Then
            MessageBox.Show("Kode Produk tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Query SQL untuk menambahkan data
        Dim query As String = "INSERT INTO riwayat_katalog (kode_riwayat, kode_produk, penambahan_stok, pengurangan_stok, tanggal_riwayat) " &
                              "VALUES (@kodeRiwayat, @kodeProduk, @penambahanStok, @penguranganStok, @tanggalRiwayat)"

        ' Gunakan koneksi dari Module_Koneksi
        Using conn As MySqlConnection = Module_Koneksi.GetConnection()
            Try
                ' Buat command dan parameter
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeRiwayat", kodeRiwayat)
                    cmd.Parameters.AddWithValue("@kodeProduk", kodeProduk)
                    cmd.Parameters.AddWithValue("@penambahanStok", penambahanStok)
                    cmd.Parameters.AddWithValue("@penguranganStok", penguranganStok)
                    cmd.Parameters.AddWithValue("@tanggalRiwayat", tanggalRiwayat)

                    ' Eksekusi query
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Beri informasi ke pengguna
                    If rowsAffected > 0 Then
                        MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Data gagal disimpan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                ' Tangani error koneksi atau eksekusi SQL
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Pastikan koneksi tertutup
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                Me.Hide()
            End Try
        End Using
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            NumericKurangi.Enabled = False ' Nonaktifkan NumericKurangi
            NumericTambah.Enabled = True    ' Aktifkan NumericTambah
        ElseIf RadioButton2.Checked Then
            NumericTambah.Enabled = False    ' Nonaktifkan NumericTambah
            NumericKurangi.Enabled = True     ' Aktifkan NumericKurangi
        End If
    End Sub
End Class