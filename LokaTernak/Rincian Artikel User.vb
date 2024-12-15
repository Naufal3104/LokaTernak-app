Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class Rincian_Artikel_User
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
        ReportViewer1.LocalReport.ReportPath = "..\..\IsiArtikel.rdlc"
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
    Private Sub Rincian_Artikel_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_isiArtikel()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Me.Hide()
        Dash_User.Show()

    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Hide()
        Dash_User1.Show()

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Me.Hide()
        Dash_User_3.Show()

    End Sub
End Class