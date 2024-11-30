Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Tambah_Diskusi
    Private fileData As Byte() = Nothing
    Private Sub buttonSimpan_Click(sender As Object, e As EventArgs) Handles buttonSimpan.Click
        Dim kodeDiskusi As String = GenerateKodeDiskusi()
        Dim kodePeternakan As String = Module_Koneksi.GetKodePeternakan()
        Dim judulDiskusi As String = textJudul.Text
        Dim isiDiskusi As String = textIsi.Text
        Dim tanggalDibuat As DateTime = DateTime.Now

        Dim connectionString As String = "server=localhost;user id=root;password=;database=peternakan;"
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Dim command As New MySqlCommand("INSERT INTO diskusi (kode_diskusi, kode_peternakan, judul_diskusi, isi_diskusi, gambar_lampiran, tanggal_dibuat) VALUES (@kodeDiskusi, @kodePeternakan, @judulDiskusi, @isiDiskusi, @gambarLampiran, @tanggalDibuat)", connection)
            command.Parameters.AddWithValue("@kodeDiskusi", kodeDiskusi)
            command.Parameters.AddWithValue("@kodePeternakan", kodePeternakan)
            command.Parameters.AddWithValue("@judulDiskusi", judulDiskusi)
            command.Parameters.AddWithValue("@isiDiskusi", isiDiskusi)
            command.Parameters.Add("@gambarLampiran", MySqlDbType.Blob).Value = fileData
            command.Parameters.AddWithValue("@tanggalDibuat", tanggalDibuat)

            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Data diskusi berhasil disimpan!")
            Catch ex As MySqlException
                MessageBox.Show("Terjadi kesalahan: " & ex.Message)
            Finally
                Me.Hide()
                Diskusi_Peternak.LoadDataDiskusi()
            End Try
        End Using
    End Sub

    Private Function GenerateKodeDiskusi() As String
        Dim kodeTerakhir As String = ""
        Dim query As String = "SELECT kode_diskusi FROM diskusi ORDER BY kode_diskusi DESC LIMIT 1"

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
            Return "DSK001"
        End If

        Dim nomor As Integer = Integer.Parse(kodeTerakhir.Substring(3))
        nomor += 1

        Return "DSK" & nomor.ToString("D3")
    End Function

    Private Sub clear()
        textIsi.Text = ""
        textJudul.Text = ""
        fileData = Nothing
    End Sub

    Private Sub Tambah_Diskusi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonFile_Click(sender As Object, e As EventArgs) Handles buttonFile.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Gambar"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = OpenFileDialog1.FileName
            fileData = File.ReadAllBytes(filePath) ' Membaca file ke dalam byte array
            MessageBox.Show("File berhasil dipilih: " & OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub buttonBatal_Click(sender As Object, e As EventArgs) Handles buttonBatal.Click
        Me.Hide()
        clear()
    End Sub
End Class