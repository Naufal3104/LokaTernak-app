Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class Laporan_Peternak

    Public Shared selectedMonth As Integer
    Public Shared selectedYear As Integer
    Public Sub Laporan_Peternak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxBulan.SelectedIndex = DateTime.Now.Month - 1
        NumericTahun.Value = DateTime.Now.Year
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        Me.ReportViewer3.RefreshReport()
        Me.ReportViewer4.RefreshReport()
        loadLaporanPenjualan()
        loadLaporanPendapatan()
        loadLaporanStokBulanan()
        loadLaporanPendapatanBulanan()
    End Sub

    Private Sub loadLaporanPenjualan()
        selectedMonth = ComboBoxBulan.SelectedIndex + 1 ' Indeks bulan dimulai dari 0
        selectedYear = Convert.ToInt32(NumericTahun.Value)

        If ComboBoxBulan.SelectedIndex = -1 Then
            Return
        End If

        If selectedMonth < 1 Or selectedMonth > 12 Then
            MessageBox.Show("Bulan tidak valid.")
            Return
        End If

        If selectedYear < 1000 Or selectedYear > 9999 Then
            MessageBox.Show("Tahun tidak valid.")
            Return
        End If

        Dim startDate As New DateTime(selectedYear, selectedMonth, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

        Dim query As String = "SELECT k.nama_produk, t.jumlah AS Jumlah " &
                              "FROM transaksi t " &
                              "INNER JOIN katalog k ON t.kode_produk = k.kode_produk " &
                              "WHERE t.tanggal_order >= @startDate AND t.tanggal_order <= @endDate " &
                              "AND k.kode_peternakan = @kodePeternakan " &
                              "ORDER BY Jumlah DESC"

        Dim dt As New DataTable()
        Dim conn As MySqlConnection = Module_Koneksi.GetConnection()
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@startDate", startDate)
            cmd.Parameters.AddWithValue("@endDate", endDate)
            cmd.Parameters.AddWithValue("@kodePeternakan", Module_Koneksi.GetKodePeternakan)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Dim rds As New ReportDataSource("DataSetPenjualan", dt)
        ReportViewer1.LocalReport.ReportPath = "..\..\IsiLaporanPenjualan.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub loadLaporanPendapatan()
        selectedMonth = ComboBoxBulan.SelectedIndex + 1 ' Indeks bulan dimulai dari 0
        selectedYear = Convert.ToInt32(NumericTahun.Value)

        If ComboBoxBulan.SelectedIndex = -1 Then
            Return
        End If

        If selectedMonth < 1 Or selectedMonth > 12 Then
            MessageBox.Show("Bulan tidak valid.")
            Return
        End If

        If selectedYear < 1000 Or selectedYear > 9999 Then
            MessageBox.Show("Tahun tidak valid.")
            Return
        End If

        Dim startDate1 As New DateTime(selectedYear, selectedMonth, 1)
        Dim endDate1 As DateTime = startDate1.AddMonths(1).AddDays(-1)

        Dim query1 As String = "SELECT k.nama_produk, t.total_harga AS Total_Pendapatan " &
                              "FROM transaksi t " &
                              "INNER JOIN katalog k ON t.kode_produk = k.kode_produk " &
                              "WHERE t.tanggal_order >= @startDate AND t.tanggal_order <= @endDate " &
                              "AND k.kode_peternakan = @kodePeternakan " &
                              "GROUP BY k.nama_produk " &
                              "ORDER BY Total_Pendapatan DESC"

        Dim dt1 As New DataTable()
        Dim conn1 As MySqlConnection = Module_Koneksi.GetConnection()
        Using cmd1 As New MySqlCommand(query1, conn1)
            cmd1.Parameters.AddWithValue("@startDate", startDate1)
            cmd1.Parameters.AddWithValue("@endDate", endDate1)
            cmd1.Parameters.AddWithValue("@kodePeternakan", Module_Koneksi.GetKodePeternakan)
            Dim adapter As New MySqlDataAdapter(cmd1)
            adapter.Fill(dt1)
        End Using
        Dim rds1 As New ReportDataSource("DataSetPendapatan", dt1)
        ReportViewer2.LocalReport.ReportPath = "..\..\IsiLaporanPendapatan.rdlc"
        ReportViewer2.LocalReport.DataSources.Clear()
        ReportViewer2.LocalReport.DataSources.Add(rds1)
        ReportViewer2.RefreshReport()
    End Sub

    Private Sub loadLaporanStokBulanan()
        selectedYear = Convert.ToInt32(NumericTahun.Value)
        Dim query As String = "SELECT " &
                          "k.nama_produk, " &
                          "m.Bulan, " &
                          "COALESCE(SUM(r.penambahan_stok), 0) AS Total_Penambahan, " &
                          "COALESCE(SUM(r.pengurangan_stok), 0) AS Total_Pengurangan " &
                          "FROM (SELECT 1 AS Bulan UNION ALL " &
                          "SELECT 2 UNION ALL " &
                          "SELECT 3 UNION ALL " &
                          "SELECT 4 UNION ALL " &
                          "SELECT 5 UNION ALL " &
                          "SELECT 6 UNION ALL " &
                          "SELECT 7 UNION ALL " &
                          "SELECT 8 UNION ALL " &
                          "SELECT 9 UNION ALL " &
                          "SELECT 10 UNION ALL " &
                          "SELECT 11 UNION ALL " &
                          "SELECT 12) m " &
                          "LEFT JOIN riwayat_katalog r ON MONTH(r.tanggal_riwayat) = m.Bulan AND YEAR(r.tanggal_riwayat) = @tahun " &
                          "LEFT JOIN katalog k ON k.kode_produk = r.kode_produk " &
                          "GROUP BY k.nama_produk, m.Bulan " &
                          "ORDER BY m.Bulan ASC;"

        Dim dt As New DataTable()
        Dim conn As MySqlConnection = Module_Koneksi.GetConnection()
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@tahun", selectedYear)  ' Menambahkan parameter tahun
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using

        ' Proses DataTable dt untuk ditampilkan di ReportViewer atau kontrol lainnya
        Dim rds As New ReportDataSource("DataSetStokBulanan", dt)
        ReportViewer3.LocalReport.ReportPath = "..\..\IsiLaporanStokBulanan.rdlc"
        ReportViewer3.LocalReport.DataSources.Clear()
        ReportViewer3.LocalReport.DataSources.Add(rds)
        ReportViewer3.RefreshReport()
    End Sub

    Public Sub loadLaporanPendapatanBulanan()
        selectedYear = Convert.ToInt32(NumericTahun.Value)
        Dim query As String = "SELECT " &
                          "m.Bulan, " &
                          "COALESCE(SUM(p.total_harga), 0) AS Total_Pendapatan " &
                          "FROM (SELECT 1 AS Bulan UNION ALL " &
                          "SELECT 2 UNION ALL " &
                          "SELECT 3 UNION ALL " &
                          "SELECT 4 UNION ALL " &
                          "SELECT 5 UNION ALL " &
                          "SELECT 6 UNION ALL " &
                          "SELECT 7 UNION ALL " &
                          "SELECT 8 UNION ALL " &
                          "SELECT 9 UNION ALL " &
                          "SELECT 10 UNION ALL " &
                          "SELECT 11 UNION ALL " &
                          "SELECT 12) m " &
                          "LEFT JOIN transaksi p ON MONTH(p.tanggal_order) = m.Bulan AND YEAR(p.tanggal_order) = @tahun " &
                          "GROUP BY m.Bulan " &
                          "ORDER BY m.Bulan ASC;"

        Dim dt As New DataTable()
        Dim conn As MySqlConnection = Module_Koneksi.GetConnection() ' Pastikan Anda memiliki koneksi yang benar
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@tahun", selectedYear) ' Menambahkan parameter tahun
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using

        ' Proses DataTable dt untuk ditampilkan di ReportViewer atau kontrol lainnya
        Dim rds As New ReportDataSource("DataSetPendapatanBulanan", dt)
        ReportViewer4.LocalReport.ReportPath = "..\..\IsiLaporanPenjualanBulanan.rdlc"
        ReportViewer4.LocalReport.DataSources.Clear()
        ReportViewer4.LocalReport.DataSources.Add(rds)
        ReportViewer4.RefreshReport()
    End Sub

    Private Sub ComboBoxBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBulan.SelectedIndexChanged
        loadLaporanPenjualan()
        loadLaporanPendapatan()
    End Sub

    Private Sub NumericTahun_ValueChanged(sender As Object, e As EventArgs) Handles NumericTahun.ValueChanged
        loadLaporanPenjualan()
        loadLaporanPendapatan()
        loadLaporanStokBulanan()
        loadLaporanPendapatanBulanan()
    End Sub

End Class