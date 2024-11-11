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

    Private Function GenerateKodeArtikel() As String
        Dim kodeTerakhir As String = ""
        Dim query As String = "SELECT kode_artikel FROM artikel ORDER BY kode_artikel DESC LIMIT 1"

        Using connection As MySqlConnection = Module_Koneksi.GetConnection()
            Using command As New MySqlCommand(query, connection)
                Try
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        kodeTerakhir = result.ToString()
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                End Try
            End Using
        End Using

        If String.IsNullOrEmpty(kodeTerakhir) Then
            Return "ART001"
        End If

        Dim nomor As Integer = Integer.Parse(kodeTerakhir.Substring(3))
        nomor += 1

        Return "ART" & nomor.ToString("D3")
    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Dashboard_Admin2.Show()
    End Sub

    Private Sub Dashboard_Admin_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        kodeArtikel.Text = GenerateKodeArtikel()

        ListView1.Items.Clear()
        cmd = New MySqlCommand("select * from artikel", conn)
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
        cmd = New MySqlCommand("UPDATE artikel SET " &
            "judul='" & judulArtikel.Text & "', " &
            "deskripsi='" & deskripsiArtikel.Text & "', " &
            "tanggal_terbit='" & tanggalArtikel.Text & "' " &
            "WHERE kode_artikel='" & kodeArtikel.Text & "'", conn)
        cmd.ExecuteNonQuery()

        ListView1.Items.Clear()
        cmd = New MySqlCommand("select * from artikel", conn)
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
        kodeArtikel.Text = GenerateKodeArtikel()
    End Sub

    Private Sub button_addArticle_Click(sender As Object, e As EventArgs) Handles button_addArticle.Click
        Try
            ' Siapkan command dengan parameter
            Dim query As String = "INSERT INTO artikel (kode_artikel, judul, deskripsi, tanggal_terbit) VALUES (@kode, @judul, @deskripsi, @tanggal)"

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
        cmd = New MySqlCommand("select * from artikel", conn)
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
        kodeArtikel.Text = GenerateKodeArtikel()
    End Sub

    Private Sub button_delete_Click(sender As Object, e As EventArgs) Handles button_delete.Click
        cmd = New MySqlCommand("DELETE FROM artikel WHERE kode_artikel=@kode_artikel", conn)
        cmd.Parameters.AddWithValue("@kode_artikel", kodeArtikel.Text)
        cmd.ExecuteNonQuery()


        ListView1.Items.Clear()
        cmd = New MySqlCommand("SELECT * from artikel", conn)
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
        kodeArtikel.Text = GenerateKodeArtikel()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Me.Hide()
        Sign_In.Show()
    End Sub
End Class