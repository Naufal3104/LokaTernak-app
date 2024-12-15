Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Dash_User_4
    Public Sub load_diskusi()
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Dim query As String = "SELECT judul_diskusi, gambar_lampiran FROM diskusi WHERE kode_diskusi = @kode_diskusi"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@kode_diskusi", Module_Koneksi.GetKodeDiskusi())
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        label_judul.Text = reader("judul_diskusi").ToString()

                        ' Memeriksa apakah kolom gambar_lampiran adalah DBNull
                        If Not reader.IsDBNull(reader.GetOrdinal("gambar_lampiran")) Then
                            Dim gambarData As Byte() = CType(reader("gambar_lampiran"), Byte())
                            If gambarData IsNot Nothing AndAlso gambarData.Length > 0 Then
                                Using ms As New MemoryStream(gambarData)
                                    ' Misalkan Anda menggunakan Guna2PictureBox untuk menampilkan gambar
                                    GambarLampiran.Image = Image.FromStream(ms)
                                    GambarLampiran.SizeMode = PictureBoxSizeMode.Zoom
                                End Using
                            Else
                                ' Jika tidak ada gambar, Anda bisa mengatur gambar default
                                GambarLampiran.Image = Nothing ' Atau gambar default lainnya
                            End If
                        Else
                            ' Jika gambar_lampiran adalah DBNull, atur gambar ke null atau default
                            GambarLampiran.Image = Nothing ' Atau gambar default lainnya
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub load_isiDiskusi()
        Dim dt As New DataTable()
        Dim conn As MySqlConnection = Module_Koneksi.GetConnection()
        Dim query As String = "SELECT kode_diskusi, isi_diskusi FROM diskusi WHERE kode_diskusi = @kode_diskusi"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@kode_diskusi", Module_Koneksi.GetKodeDiskusi)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Dim rds As New ReportDataSource("DataSetDiskusi", dt)
        ReportViewer1.LocalReport.ReportPath = "..\..\IsiDiskusi.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.RefreshReport()
    End Sub

    Public Sub LoadDataBalasan()
        Dim conn As MySqlConnection = Module_Koneksi.GetConnection
        Dim query As String = "SELECT 
                                COALESCE(u.username, p.nama_peternakan) AS pengguna_peternakan,
                                CONCAT('@', COALESCE(u1.username, p1.nama_peternakan), ' ', b.isi_balasan) AS isi_balasan_dengan_pengguna,
                                    b.tanggal_balasan,
                                    b.kode_balasan
                                FROM balasan_diskusi b
                                LEFT JOIN user u ON b.kode_user = u.kode_user
                                LEFT JOIN peternakan p ON b.kode_peternakan = p.kode_peternakan
                                LEFT JOIN diskusi d ON b.kode_diskusi = d.kode_diskusi
                                LEFT JOIN user u1 ON d.kode_user = u1.kode_user
                                LEFT JOIN peternakan p1 ON d.kode_peternakan = p1.kode_peternakan
                                WHERE d.kode_diskusi = '" & Module_Koneksi.GetKodeDiskusi() & "'
                                ORDER BY b.tanggal_balasan ASC;"

        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            ListView1.Items.Clear()

            For Each row As DataRow In table.Rows
                Dim item As New ListViewItem(row("pengguna_peternakan").ToString())

                ' Menampilkan pengguna atau peternakan
                item.SubItems.Add(row("isi_balasan_dengan_pengguna").ToString())
                item.SubItems.Add(Convert.ToDateTime(row("tanggal_balasan")).ToString("g"))
                item.SubItems.Add(row("kode_balasan").ToString())

                ListView1.Items.Add(item)
            Next
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Dash_User_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ListView1
            .Columns.Add("Nama Pengguna", 200)
            .Columns.Add("Balasan", 670)
            .Columns.Add("Tanggal Balasan", 100)
            .Columns.Add("Kode Balasan", 0)
            .View = View.Details
        End With
        Dash_User_3.cekPengguna()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Me.Hide()
        buttonHapus.Visible = False
        Dash_User.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Me.Hide()
        buttonHapus.Visible = False
        Dash_User_3.Show()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Hide()
        buttonHapus.Visible = False
        Dash_User1.Show()
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Me.Hide()
        buttonHapus.Visible = False
        Dash_User2.Show()
    End Sub

    Private Sub buttonKembali_Click(sender As Object, e As EventArgs) Handles buttonKembali.Click
        Me.Hide()
        buttonHapus.Visible = False
        Dash_User_3.LoadDataDiskusi()
        Dash_User_3.Show()
    End Sub

    Private Sub buttonBalas_Click(sender As Object, e As EventArgs) Handles buttonBalas.Click
        balas_diskusi.SetKodePembuat()
        balas_diskusi.Show()
    End Sub

    Private Sub buttonHapus_Click(sender As Object, e As EventArgs) Handles buttonHapus.Click
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Dim query As String = "SELECT kode_user FROM diskusi WHERE kode_diskusi = @kode_diskusi"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@kode_diskusi", Module_Koneksi.GetKodeDiskusi())
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin akan menghapus Diskusi ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = DialogResult.Yes Then
                            If reader("kode_user").ToString() = Module_Koneksi.GetKodeUser() Then
                                Dash_User_3.Show()
                                reader.Close()
                                Dim deleteQuery As String = "DELETE FROM diskusi WHERE kode_diskusi = @kode_diskusi"
                                Using command1 As New MySqlCommand(deleteQuery, connection)
                                    command1.Parameters.AddWithValue("@kode_diskusi", Module_Koneksi.GetKodeDiskusi())
                                    command1.ExecuteNonQuery()
                                End Using
                                Dash_User_3.LoadDataDiskusi()
                                Me.Hide()
                                MessageBox.Show("Data Diskusi Berhasil Dihapus")
                            End If
                        ElseIf result = DialogResult.No Then
                            buttonHapus.Visible = False
                            load_diskusi()
                            load_isiDiskusi()
                            LoadDataBalasan()
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class