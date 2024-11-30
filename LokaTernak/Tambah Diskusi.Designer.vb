<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tambah_Diskusi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.buttonBatal = New Guna.UI2.WinForms.Guna2Button()
        Me.buttonSimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textJudul = New Guna.UI2.WinForms.Guna2TextBox()
        Me.textIsi = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.buttonFile = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.YellowGreen
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(646, 60)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(202, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Diskusi"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.YellowGreen
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 63)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(646, 60)
        Me.Guna2Panel3.TabIndex = 2
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 62)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(646, 392)
        Me.Guna2Panel4.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(646, 392)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Controls.Add(Me.buttonFile)
        Me.Guna2Panel5.Controls.Add(Me.buttonBatal)
        Me.Guna2Panel5.Controls.Add(Me.buttonSimpan)
        Me.Guna2Panel5.Controls.Add(Me.Label4)
        Me.Guna2Panel5.Controls.Add(Me.textJudul)
        Me.Guna2Panel5.Controls.Add(Me.textIsi)
        Me.Guna2Panel5.Controls.Add(Me.Label3)
        Me.Guna2Panel5.Controls.Add(Me.Label2)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.Ivory
        Me.Guna2Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 59)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(646, 392)
        Me.Guna2Panel5.TabIndex = 3
        '
        'buttonBatal
        '
        Me.buttonBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.buttonBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.buttonBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.buttonBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.buttonBatal.FillColor = System.Drawing.Color.IndianRed
        Me.buttonBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.buttonBatal.ForeColor = System.Drawing.Color.White
        Me.buttonBatal.Location = New System.Drawing.Point(396, 347)
        Me.buttonBatal.Name = "buttonBatal"
        Me.buttonBatal.Size = New System.Drawing.Size(120, 42)
        Me.buttonBatal.TabIndex = 6
        Me.buttonBatal.Text = "Batalkan"
        '
        'buttonSimpan
        '
        Me.buttonSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.buttonSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.buttonSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.buttonSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.buttonSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.buttonSimpan.ForeColor = System.Drawing.Color.White
        Me.buttonSimpan.Location = New System.Drawing.Point(522, 347)
        Me.buttonSimpan.Name = "buttonSimpan"
        Me.buttonSimpan.Size = New System.Drawing.Size(120, 42)
        Me.buttonSimpan.TabIndex = 5
        Me.buttonSimpan.Text = "Simpan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Ivory
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(12, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Lampiran"
        '
        'textJudul
        '
        Me.textJudul.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textJudul.DefaultText = ""
        Me.textJudul.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textJudul.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textJudul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textJudul.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textJudul.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textJudul.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textJudul.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textJudul.Location = New System.Drawing.Point(147, 21)
        Me.textJudul.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textJudul.Name = "textJudul"
        Me.textJudul.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textJudul.PlaceholderText = ""
        Me.textJudul.SelectedText = ""
        Me.textJudul.Size = New System.Drawing.Size(484, 40)
        Me.textJudul.TabIndex = 3
        '
        'textIsi
        '
        Me.textIsi.Location = New System.Drawing.Point(147, 81)
        Me.textIsi.Name = "textIsi"
        Me.textIsi.Size = New System.Drawing.Size(485, 189)
        Me.textIsi.TabIndex = 2
        Me.textIsi.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Ivory
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Isi Diskusi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Ivory
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Judul Diskusi"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'buttonFile
        '
        Me.buttonFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.buttonFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.buttonFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.buttonFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.buttonFile.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.buttonFile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.buttonFile.ForeColor = System.Drawing.Color.White
        Me.buttonFile.Location = New System.Drawing.Point(147, 285)
        Me.buttonFile.Name = "buttonFile"
        Me.buttonFile.Size = New System.Drawing.Size(97, 45)
        Me.buttonFile.TabIndex = 7
        Me.buttonFile.Text = "Pilih File"
        '
        'Tambah_Diskusi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 450)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Tambah_Diskusi"
        Me.Text = "Tambah_Diskusi"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents textIsi As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonBatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents buttonSimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents textJudul As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents buttonFile As Guna.UI2.WinForms.Guna2Button
End Class
