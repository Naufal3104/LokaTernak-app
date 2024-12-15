Imports MySql.Data.MySqlClient

Public Class Dash_User1
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    'Private Sub LoadKatalog()
    '    Using connection As MySqlConnection = Module_Koneksi.GetConnection()
    '        If connection IsNot Nothing Then
    '            Try
    '                Dim query As String = "SELECT katalog.nama_produk, katalog.jenis_produk, katalog.deskripsi, peternakan.nama_peternakan FROM katalog inner join peternakan on peternakan.kode_peternakan=katalog.kode_peternakan WHERE kode_peternakan = '" & Module_Koneksi.GetKodePeternakan() & "'"
    '                Using command As New MySqlCommand(query, connection)
    '                    Using reader As MySqlDataReader = command.ExecuteReader()
    '                        ListView1.Items.Clear()
    '                        While reader.Read()

    '                            Dim item As New ListViewItem(reader("nama_produk").ToString())
    '                            item.SubItems.Add(reader("jenis_produk").ToString())
    '                            item.SubItems.Add(reader("deskripsi").ToString())
    '                            item.SubItems.Add(reader("nama_peternakan").ToString())
    '                            ListView1.Items.Add(item)
    '                        End While
    '                    End Using
    '                End Using
    '            Catch ex As MySqlException
    '                MessageBox.Show("Terjadi kesalahan: " & ex.Message)
    '            Finally
    '                connection.Close()
    '            End Try
    '        End If
    '    End Using
    'End Sub
    'Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
    '    If e.IsSelected Then
    '        Dim nama_produk As String = e.Item.SubItems(0).Text
    '        Dim jenis_produk As String = e.Item.SubItems(1).Text
    '        Dim deskripsi As String = e.Item.SubItems(2).Text
    '        Dim nama_peternakan As String = e.Item.SubItems(3).Text

    '    End If
    'End Sub
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        Dash_User.Show()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Dash_User2.Show()

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Me.Hide()
        Dash_User_3.Show()

    End Sub

    Private Sub Dash_User1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        ListView1.Items.Clear()
        cmd = New MySqlCommand("SELECT katalog.nama_produk, katalog.jenis_produk, katalog.deskripsi, peternakan.nama_peternakan FROM katalog inner join peternakan on peternakan.kode_peternakan=katalog.kode_peternakan", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()


    End Sub


    'Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
    '    LoadKatalog()

    'End Sub

    Sub koneksi()
        conn.ConnectionString = "server=localhost;user id=root;" & "password=;database=peternakan"

        Try
            conn.Open()

        Catch myerror As MySqlException
            MsgBox("Error Koneksi : " & myerror.Message)
            conn.Close()
        End Try
    End Sub



End Class