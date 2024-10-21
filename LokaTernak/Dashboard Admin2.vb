Imports System.Net
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Bcpg
Imports Org.BouncyCastle.Crypto.Prng

Public Class Dashboard_Admin2
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Dashboard_Admin_3.Show()
    End Sub


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
    Private Sub Dashboard_Admin2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        ListView1.Items.Clear()
        cmd = New MySqlCommand("select * from peternakan", conn)
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
        cmd = New MySqlCommand("UPDATE peternakan SET " &
            "nama_peternakan='" & namaPeternakan.Text & "', " &
            "deskripsi='" & deskripsiPeternakan.Text & "', " &
            "alamat='" & alamatPeternakan.Text & "' " &
            "WHERE kode_peternakan='" & kodePeternakan.Text & "'", conn)
        cmd.ExecuteNonQuery()

        ListView1.Items.Clear()
        cmd = New MySqlCommand("select * from peternakan", conn)
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

    Private Sub button_delete_Click(sender As Object, e As EventArgs) Handles button_delete.Click
        cmd = New MySqlCommand("DELETE FROM peternakan WHERE kode_peternakan=@kode_peternakan", conn)
        cmd.Parameters.AddWithValue("@kode_peternakan", kodePeternakan.Text)
        cmd.ExecuteNonQuery()



        ListView1.Items.Clear()
        cmd = New MySqlCommand("SELECT * from peternakan", conn)
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