Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class Laporan_Peternak

    Public Shared selectedMonth As Integer
    Public Shared selectedYear As Integer
    Public Sub Laporan_Peternak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxBulan.SelectedIndex = DateTime.Now.Month - 1
        NumericTahun.Value = DateTime.Now.Year
        Me.ReportViewer1.RefreshReport()
        loadLaporanPenjualan()
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

        Dim query As String = "SELECT k.nama_produk, SUM(t.jumlah) AS Jumlah " &
                              "FROM transaksi t " &
                              "INNER JOIN katalog k ON t.kode_produk = k.kode_produk " &
                              "WHERE t.tanggal_order >= @startDate AND t.tanggal_order <= @endDate " &
                              "AND k.kode_peternakan = @kodePeternakan " &
                              "GROUP BY k.nama_produk " &
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

    Private Sub ComboBoxBulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBulan.SelectedIndexChanged
        loadLaporanPenjualan()
    End Sub

    Private Sub NumericTahun_ValueChanged(sender As Object, e As EventArgs) Handles NumericTahun.ValueChanged
        loadLaporanPenjualan()
    End Sub
End Class