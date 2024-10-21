Imports MySql.Data.MySqlClient
Public Class Database_User_2
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
    Private Sub Database_User_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        ListView1.Items.Clear()
        cmd = New MySqlCommand("select judul, tanggal_terbit, deskripsi from artikel ", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))

            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()



    End Sub


End Class