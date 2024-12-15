Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class Invoice
    Private dataSet As DataSet
    Private dataAdapter As MySqlDataAdapter
    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim order_id As Integer

        If Not Integer.TryParse(text_order.Text, order_id) Then
            MessageBox.Show("Please enter a valid Order ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dt As New DataTable
        Dim conn As MySqlConnection = GetConnection()
        Dim query As String = "
        select 
        transaksi.order_id,
transaksi.pelanggan,
katalog.nama_produk,
transaksi.jumlah,
transaksi.total_harga,
transaksi.tanggal_order,
katalog.deskripsi
from transaksi inner join katalog on transaksi.kode_produk = katalog.kode_produk
where
transaksi.order_id = @order_id
"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@order_id", order_id)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using

        If dt.Rows.Count = 0 Then
            MessageBox.Show("No data found for the given order id", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim rds As New ReportDataSource("DataSet1", dt)
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(rds)

        ReportViewer1.RefreshReport()

    End Sub
End Class