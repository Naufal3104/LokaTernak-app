Imports MySql.Data.MySqlClient

Module Module_Koneksi
    Private _kodePeternakan As String
    Private _kodeDiskusi As String
    Public Function GetKodePeternakan() As String
        Return _kodePeternakan
    End Function

    Public Sub SetKodePeternakan(value As String)
        _kodePeternakan = value
    End Sub

    Public Function GetKodeDiskusi() As String
        Return _kodeDiskusi
    End Function

    Public Sub SetKodeDiskusi(value As String)
        _kodeDiskusi = value
    End Sub

    Private connectionString As String = "server=localhost;user id=root;" & "password=;database=peternakan;"
    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)
        Try
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return conn
    End Function
End Module