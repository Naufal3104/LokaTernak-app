Imports MySql.Data.MySqlClient

Public Class Dashboard_Peternak
    Private Sub LoadKatalog()
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            If connection IsNot Nothing Then
                Try
                    Dim query As String = "SELECT kode_produk, nama_produk, jenis_produk, deskripsi FROM katalog WHERE kode_peternakan = '" & Module_Koneksi.GetKodePeternakan() & "'"
                    Using command As New MySqlCommand(query, connection)
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            ListView1.Items.Clear()
                            While reader.Read()
                                Dim item As New ListViewItem(reader("kode_produk").ToString())
                                item.SubItems.Add(reader("nama_produk").ToString())
                                item.SubItems.Add(reader("jenis_produk").ToString())
                                item.SubItems.Add(reader("deskripsi").ToString())
                                ListView1.Items.Add(item)
                            End While
                        End Using
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End If
        End Using
    End Sub

    Private Sub loadPeternakan()
        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Dim query As String = "SELECT nama_peternakan, deskripsi FROM peternakan WHERE kode_peternakan = @kode_peternakan"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@kode_peternakan", Module_Koneksi.GetKodePeternakan())
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        label_namaPeternakan.Text = reader("nama_peternakan").ToString()
                        label_deskripsi.Text = reader("deskripsi").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Sub Dashboard_Peternak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKatalog()
        loadPeternakan()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        Ubah_Peternakan.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Data_Katalog.Show()
    End Sub

    Private Sub Dashboard_Peternak_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        loadPeternakan()
        LoadKatalog()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        Sign_In.Show()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Me.Hide()
        Diskusi_Peternak.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Me.Hide()
        Artikel_Peternak.Show()
    End Sub
End Class