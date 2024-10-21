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
            "judul_artikel='" & judulArtikel.Text & "', " &
            "deskripsi_artikel='" & deskripsiArtikel.Text & "', " &
            "tanggal='" & tanggalArtikel.Text & "' " &
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
    End Sub

    Private Sub button_addArticle_Click(sender As Object, e As EventArgs) Handles button_addArticle.Click
        'Try
        '    ' Siapkan command dengan parameter
        '    Dim query As String = "INSERT INTO data_artikel (kode_artikel, judul_artikel, deskripsi_artikel, tanggal) VALUES (@kode, @judul, @deskripsi, @tanggal)"

        '    ' Membuat command dan menambahkan parameter
        '    Using cmd As New MySqlCommand(query, conn)
        '        ' Menambahkan parameter
        '        cmd.Parameters.AddWithValue("@kode", kodeArtikel.Text)
        '        cmd.Parameters.AddWithValue("@judul", judulArtikel.Text)
        '        cmd.Parameters.AddWithValue("@deskripsi", deskripsiArtikel.Text)
        '        cmd.Parameters.AddWithValue("@tanggal", tanggalArtikel.Text)

        '        ' Eksekusi perintah
        '        cmd.ExecuteNonQuery()
        '    End Using


        '    MessageBox.Show("Data berhasil ditambahkan")
        'Catch ex As Exception
        '    MessageBox.Show("Error: " & ex.Message)
        'End Try

        InsertOrder()


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
    End Sub
    Public Function GenerateKodeArtikel() As String
        Dim newKodeArtikel As String = ""
        Dim lastKodeArtikel As String = ""

        Dim query As String = "SELECT kode_artikel FROM artikel ORDER BY kode_artikel DESC LIMIT 1"
        Dim conn As MySqlConnection = GetConnection()
        Using command As New MySqlCommand(query, conn)
            Try

                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    lastKodeArtikel = reader("kode_artikel").ToString()
                End If
                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Error : " & ex.Message)
            Finally
                'Pastikan koneksi ditutup
                conn.Close()
            End Try
        End Using
        If lastKodeArtikel = "" Then
            ' If no records found, start with a base ID
            newKodeArtikel = "ART1001"

        Else
            ' Extract the numeric part and increment it
            Dim numericPart As Integer = Integer.Parse(lastKodeArtikel.Substring(3)) ' Extracts the number after "ORD"
            numericPart += 1
            newKodeArtikel = "ART" & numericPart.ToString("D4") ' Formats to ensure 4 digits, e.g., ORD1002
        End If
        Return newKodeArtikel
    End Function

    Public Sub InsertOrder()
        Dim kode_artikel As String = kodeArtikel.Text
        Dim judul_artikel As String = judulArtikel.Text
        Dim deskripsi As String = deskripsiArtikel.Text
        Dim tanggal_artikel As String = tanggalArtikel.Text

        Dim query As String = "INSERT INTO artikel (kode_artikel, judul, deskripsi, tanggal_terbit) VALUES (@kode_artikel,@judul, @deskripsi, @tanggal_terbit)"
        'Panggil koneksi dari modul modKoneksi
        Dim conn As MySqlConnection = GetConnection()
        Using command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@kode_artikel", kodeArtikel)
            command.Parameters.AddWithValue("@judul", judulArtikel)
            command.Parameters.AddWithValue("@deskripsi", deskripsiArtikel)
            command.Parameters.AddWithValue("@tanggal_terbit", tanggalArtikel)

            Try

                command.ExecuteNonQuery()
                MessageBox.Show("Order successfully added with Order ID: " & kode_artikel)
                RefreshForm()
            Catch ex As MySqlException
                MessageBox.Show("Error : " & ex.Message)
            Finally
                'Pastikan koneksi ditutup
                conn.Close()
            End Try
        End Using
    End Sub
    Private Sub RefreshForm()
        judulArtikel.Clear() ' Clear the customer name input
        judulArtikel.Focus() ' Set focus back to the customer name TextBox
        deskripsiArtikel.Clear()
        deskripsiArtikel.Focus()
        tanggalArtikel.Clear()
        tanggalArtikel.Focus()
        kodeArtikel.Text = GenerateKodeArtikel()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub
End Class