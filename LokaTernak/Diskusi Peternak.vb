Imports MySql.Data.MySqlClient

Public Class Diskusi_Peternak
    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Me.Hide()
        Artikel_Peternak.Show()
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

    Private Sub Diskusi_Peternak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ListView1
            .Columns.Add("Judul Diskusi", 675)
            .Columns.Add("Pembuat Diskusi", 200)
            .Columns.Add("Tanggal Dibuat", 100)
            .Columns.Add("Kode Diskusi", 0)
            .View = View.Details
        End With
        LoadDataDiskusi()
    End Sub

    Private Sub LoadDataDiskusi()
        Dim conn As MySqlConnection = Module_Koneksi.GetConnection
        Dim query As String = "
            SELECT d.judul_diskusi,
                   COALESCE(u.username, p.nama_peternakan) AS pengguna_peternakan,
                   d.tanggal_dibuat,
                   d.kode_diskusi
            FROM diskusi d
            LEFT JOIN user u ON d.kode_user = u.kode_user
            LEFT JOIN peternakan p ON d.kode_peternakan = p.kode_peternakan
            ORDER BY d.tanggal_dibuat DESC"

        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            ListView1.Items.Clear()

            For Each row As DataRow In table.Rows
                Dim item As New ListViewItem(row("judul_diskusi").ToString())

                ' Menampilkan pengguna atau peternakan
                item.SubItems.Add(row("pengguna_peternakan").ToString())
                item.SubItems.Add(Convert.ToDateTime(row("tanggal_dibuat")).ToString("g"))
                item.SubItems.Add(row("kode_diskusi").ToString())

                ListView1.Items.Add(item)
            Next
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class