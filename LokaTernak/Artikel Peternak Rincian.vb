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

        Dim query1 As String = "SELECT judul FROM artikel WHERE kode_artikel = @kode_artikel"

        Using cmd1 As New MySqlCommand(query1, conn)
            cmd1.Parameters.AddWithValue("@kode_artikel", Module_Koneksi.GetKodeArtikel)
            Using reader As MySqlDataReader = cmd1.ExecuteReader()
                If reader.Read() Then
                    label_judul.Text = reader("judul").ToString()
                End If
            End Using
        End Using
    End Sub
    Private Sub Artikel_Peternak_Rincian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_isiArtikel()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Hide()
        Order_Peternak.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Dashboard_Peternak.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Data_Katalog.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        Ubah_Peternakan.Show()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Me.Hide()
        Diskusi_Peternak.Show()
    End Sub
End Class