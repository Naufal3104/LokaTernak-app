Imports MySql.Data.MySqlClient

Public Class Dash_User2
    Private Sub loadDataArtikel()
        Dim conn As MySqlConnection = Module_Koneksi.GetConnection
        Dim query As String = "
            SELECT judul, deskripsi, tanggal_terbit, kode_artikel
            FROM artikel
            ORDER BY tanggal_terbit DESC"

        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            ListView1.Items.Clear()

            For Each row As DataRow In table.Rows
                Dim item As New ListViewItem(row("judul").ToString())

                ' Menampilkan pengguna atau peternakan
                item.SubItems.Add(row("deskripsi").ToString())
                item.SubItems.Add(Convert.ToDateTime(row("tanggal_terbit")).ToString("g"))
                item.SubItems.Add(row("kode_artikel").ToString())

                ListView1.Items.Add(item)
            Next
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Dash_User2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataArtikel()
        With ListView1
            .Columns.Add("Judul Artikel", 675)
            .Columns.Add("Deskripsi", 200)
            .Columns.Add("Tanggal Terbit", 100)
            .Columns.Add("Kode Artikel", 0)
            .View = View.Details
        End With
    End Sub
    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        Dim item As ListViewItem = ListView1.GetItemAt(e.X, e.Y)
        If item IsNot Nothing Then
            Dim kodeArtikel As String = item.SubItems(3).Text ' Mengambil dari kolom pertama (kode_artikel)
            Module_Koneksi.SetKodeArtikel(kodeArtikel)
            Me.Hide()
            Rincian_Artikel_User.Show()
            Rincian_Artikel_User.load_isiArtikel()
        End If
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Hide()
        Dash_User1.Show()

    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Me.Hide()
        Dash_User.Show()

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Me.Hide()
        Dash_User_3.Show()

    End Sub
End Class