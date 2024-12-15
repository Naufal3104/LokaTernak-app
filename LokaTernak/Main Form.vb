Public Class Main_Form

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Module_Koneksi.SetKodePeternakan(Nothing)
        Module_Koneksi.SetKodeUser(Nothing)
        Sign_In.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Pilih_Register.Show()
        Me.Hide()
    End Sub

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Width = 1400
    End Sub
End Class