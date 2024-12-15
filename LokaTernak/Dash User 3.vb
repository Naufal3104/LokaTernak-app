Imports MySql.Data.MySqlClient

Public Class Dash_User_3
    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Me.Hide()
        Dash_User.Show()

    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Hide()
        Dash_User1.Show()

    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Me.Hide()
        Dash_User2.Show()

    End Sub

    Public Sub LoadDataDiskusi()
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

    Public Sub cekPengguna()
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Dim query As String = "SELECT kode_user FROM diskusi WHERE kode_diskusi = @kode_diskusi"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@kode_diskusi", Module_Koneksi.GetKodeDiskusi())
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        If reader("kode_user").ToString() = Module_Koneksi.GetKodeUser() Then
                            Dash_User_4.buttonHapus.Visible = True
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub Dash_User_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ListView1
            .Columns.Add("Judul Diskusi", 675)
            .Columns.Add("Pembuat Diskusi", 200)
            .Columns.Add("Tanggal Dibuat", 100)
            .Columns.Add("Kode Diskusi", 0)
            .View = View.Details
        End With
        LoadDataDiskusi()
        cekPengguna()
    End Sub

    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        Dim item As ListViewItem = ListView1.GetItemAt(e.X, e.Y)
        If item IsNot Nothing Then
            Dim kodeDiskusi As String = item.SubItems(3).Text ' Mengambil dari kolom pertama (kode_diskusi)
            Module_Koneksi.SetKodeDiskusi(kodeDiskusi)
            cekPengguna()
            Me.Hide()
            Dash_User_4.Show()
            Dash_User_4.load_diskusi()
            Dash_User_4.load_isiDiskusi()
            Dash_User_4.LoadDataBalasan()
        End If
    End Sub
End Class