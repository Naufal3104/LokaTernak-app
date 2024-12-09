Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class Artikel_Peternak_Rincian

    Public Sub load_isiArtikel()
        Dim dt As New DataTable()
        Dim conn As MySqlConnection = Module_Koneksi.GetConnection()
        Dim query As String = "SELECT kode_artikel, deskripsi FROM artikel WHERE kode_artikel = @kode_artikel"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@kode_artikel", Module_Koneksi.GetKodeArtikel)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Dim rds As New ReportDataSource("DataSetArtikel", dt)
        ReportViewer1.LocalReport.ReportPath = "C:\Users\naufa\source\repos\LokaTernak-app\LokaTernak\IsiArtikel.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.RefreshReport()
    End Sub
    Private Sub Artikel_Peternak_Rincian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_isiArtikel()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class