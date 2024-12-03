Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class balas_diskusi
    Private Sub buttonSimpan_Click(sender As Object, e As EventArgs) Handles buttonSimpan.Click
        Dim kodePeternakan As String = Module_Koneksi.GetKodePeternakan()
        Dim tanggalBalasan As DateTime = DateTime.Now
        Dim isiBalasan As String = textIsiBalasan.Text
        Dim kodeDiskusi As String = Module_Koneksi.GetKodeDiskusi()
        Dim connectionString As String = "server=localhost;user id=root;" & "password=;database=peternakan;"
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Dim command As New MySqlCommand("INSERT INTO balasan_diskusi (kode_balasan, kode_diskusi, kode_peternakan, isi_balasan, tanggal_balasan) VALUES (@kodeBalasan, @kodeDiskusi, @kodePeternakan, @isiBalasan, @tanggalBalasan)", connection)
            command.Parameters.AddWithValue("@kodeBalasan", GenerateKodeBalasan)
            command.Parameters.AddWithValue("@kodeDiskusi", kodeDiskusi)
            command.Parameters.AddWithValue("@kodePeternakan", kodePeternakan)
            command.Parameters.AddWithValue("@isiBalasan", isiBalasan)
            command.Parameters.AddWithValue("@tanggalBalasan", tanggalBalasan)
            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Balasan berhasil dikirim!")
            Catch ex As MySqlException
                MessageBox.Show("Terjadi kesalahan: " & ex.Message)
            Finally
                Me.Hide()
                Diskusi_Peternak_Rincian.LoadDataBalasan()
            End Try
        End Using
    End Sub

    Private Sub buttonBatal_Click(sender As Object, e As EventArgs) Handles buttonBatal.Click
        textIsiBalasan.Text = ""
        textKodeDiskusi.Text = ""
        Me.Hide()
    End Sub

    Public Sub balas_diskusi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim kodePeternakan As String = Module_Koneksi.GetKodePeternakan()
        textKodeDiskusi.Text = kodePeternakan
        textKodeDiskusi.ReadOnly = True
    End Sub

    Private Function GenerateKodeBalasan() As String
        Dim kodeTerakhir As String = ""
        Dim query As String = "SELECT kode_balasan FROM balasan_diskusi ORDER BY kode_balasan DESC LIMIT 1"

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
            Return "BLS001"
        End If

        Dim nomor As Integer = Integer.Parse(kodeTerakhir.Substring(3))
        nomor += 1

        Return "BLS" & nomor.ToString("D3")
    End Function
End Class