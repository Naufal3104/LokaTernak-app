Imports MySql.Data.MySqlClient

Module Module_Koneksi
    Private _kodePeternakan As String

    Public Function GetKodePeternakan() As String
        Return _kodePeternakan
    End Function

    Public Sub SetKodePeternakan(value As String)
        _kodePeternakan = value
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