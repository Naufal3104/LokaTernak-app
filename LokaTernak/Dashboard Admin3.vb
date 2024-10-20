Imports System.Net
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Bcpg
Imports Org.BouncyCastle.Crypto.Prng

Public Class Dashboard_Admin_3
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Sub koneksi()
        conn.ConnectionString = "server=localhost;user id=root;" & "password=;database=peternakan"

        Try
            conn.Open()
            MsgBox("Koneksi Berhasil")
        Catch myerror As MySqlException
            MsgBox("Error Koneksi : " & myerror.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Dashboard_Admin2.Show()
    End Sub

    Private Sub Dashboard_Admin_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        ListView1.Items.Clear()
        cmd = New MySqlCommand("select * from data_artikel", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub button_edit_Click(sender As Object, e As EventArgs) Handles button_edit.Click
        cmd = New MySqlCommand("UPDATE data_artikel SET " &
            "judul_artikel='" & judulArtikel.Text & "', " &
            "deskripsi_artikel='" & deskripsiArtikel.Text & "', " &
            "tanggal='" & tanggalArtikel.Text & "' " &
            "WHERE kode_artikel='" & kodeArtikel.Text & "'", conn)
        cmd.ExecuteNonQuery()

        ListView1.Items.Clear()
        cmd = New MySqlCommand("select * from data_artikel", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub button_addArticle_Click(sender As Object, e As EventArgs) Handles button_addArticle.Click
        Try
            ' Siapkan command dengan parameter
            Dim query As String = "INSERT INTO data_artikel (kode_artikel, judul_artikel, deskripsi_artikel, tanggal) VALUES (@kode, @judul, @deskripsi, @tanggal)"

            ' Membuat command dan menambahkan parameter
            Using cmd As New MySqlCommand(query, conn)
                ' Menambahkan parameter
                cmd.Parameters.AddWithValue("@kode", kodeArtikel.Text)
                cmd.Parameters.AddWithValue("@judul", judulArtikel.Text)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsiArtikel.Text)
                cmd.Parameters.AddWithValue("@tanggal", tanggalArtikel.Text)

                ' Eksekusi perintah
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil ditambahkan")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        ListView1.Items.Clear()
        cmd = New MySqlCommand("select * from data_artikel", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub button_delete_Click(sender As Object, e As EventArgs) Handles button_delete.Click
        cmd = New MySqlCommand("DELETE FROM data_artikel WHERE kode_artikel=@kode_artikel", conn)
        cmd.Parameters.AddWithValue("@kode_artikel", kodeArtikel.Text)
        cmd.ExecuteNonQuery()


        ListView1.Items.Clear()
        cmd = New MySqlCommand("SELECT * from data_artikel", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub
End Class