<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UbahStok
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ComboProduk = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.buttonBatal = New Guna.UI2.WinForms.Guna2Button()
        Me.buttonSimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.textKodeKatalog = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericTambah = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.NumericKurangi = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tanggal_riwayat = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericTambah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericKurangi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.OliveDrab
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(691, 60)
        Me.Guna2Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.OliveDrab
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(261, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ubah Stok"
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
        Me.Guna2Panel5.Controls.Add(Me.tanggal_riwayat)
        Me.Guna2Panel5.Controls.Add(Me.Label4)
        Me.Guna2Panel5.Controls.Add(Me.Label3)
        Me.Guna2Panel5.Controls.Add(Me.NumericKurangi)
        Me.Guna2Panel5.Controls.Add(Me.NumericTambah)
        Me.Guna2Panel5.Controls.Add(Me.GroupBox1)
        Me.Guna2Panel5.Controls.Add(Me.ComboProduk)
        Me.Guna2Panel5.Controls.Add(Me.buttonBatal)
        Me.Guna2Panel5.Controls.Add(Me.buttonSimpan)
        Me.Guna2Panel5.Controls.Add(Me.textKodeKatalog)
        Me.Guna2Panel5.Controls.Add(Me.Label2)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.Ivory
        Me.Guna2Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 59)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(691, 466)
        Me.Guna2Panel5.TabIndex = 5
        '
        'ComboProduk
        '
        Me.ComboProduk.BackColor = System.Drawing.Color.Transparent
        Me.ComboProduk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboProduk.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboProduk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboProduk.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboProduk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ComboProduk.ItemHeight = 30
        Me.ComboProduk.Location = New System.Drawing.Point(168, 21)
        Me.ComboProduk.Name = "ComboProduk"
        Me.ComboProduk.Size = New System.Drawing.Size(293, 36)
        Me.ComboProduk.TabIndex = 7
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
        Me.buttonBatal.Location = New System.Drawing.Point(444, 406)
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
        Me.buttonSimpan.Location = New System.Drawing.Point(571, 406)
        Me.buttonSimpan.Name = "buttonSimpan"
        Me.buttonSimpan.Size = New System.Drawing.Size(120, 42)
        Me.buttonSimpan.TabIndex = 5
        Me.buttonSimpan.Text = "Simpan"
        '
        'textKodeKatalog
        '
        Me.textKodeKatalog.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textKodeKatalog.DefaultText = ""
        Me.textKodeKatalog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textKodeKatalog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textKodeKatalog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textKodeKatalog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textKodeKatalog.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textKodeKatalog.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textKodeKatalog.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textKodeKatalog.Location = New System.Drawing.Point(478, 21)
        Me.textKodeKatalog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textKodeKatalog.Name = "textKodeKatalog"
        Me.textKodeKatalog.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textKodeKatalog.PlaceholderText = ""
        Me.textKodeKatalog.ReadOnly = True
        Me.textKodeKatalog.SelectedText = ""
        Me.textKodeKatalog.Size = New System.Drawing.Size(187, 38)
        Me.textKodeKatalog.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Ivory
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pilih Produk"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(8, 25)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(132, 24)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Tambah Stok"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(144, 25)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(129, 24)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Kurangi Stok"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(192, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 69)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubah Stok"
        '
        'NumericTambah
        '
        Me.NumericTambah.BackColor = System.Drawing.Color.Transparent
        Me.NumericTambah.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NumericTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NumericTambah.Location = New System.Drawing.Point(192, 223)
        Me.NumericTambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumericTambah.Name = "NumericTambah"
        Me.NumericTambah.Size = New System.Drawing.Size(103, 56)
        Me.NumericTambah.TabIndex = 11
        '
        'NumericKurangi
        '
        Me.NumericKurangi.BackColor = System.Drawing.Color.Transparent
        Me.NumericKurangi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NumericKurangi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NumericKurangi.Location = New System.Drawing.Point(372, 223)
        Me.NumericKurangi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumericKurangi.Name = "NumericKurangi"
        Me.NumericKurangi.Size = New System.Drawing.Size(98, 56)
        Me.NumericKurangi.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tambah Stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(368, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Kurangi Stok"
        '
        'tanggal_riwayat
        '
        Me.tanggal_riwayat.Checked = True
        Me.tanggal_riwayat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tanggal_riwayat.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tanggal_riwayat.Location = New System.Drawing.Point(192, 308)
        Me.tanggal_riwayat.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tanggal_riwayat.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tanggal_riwayat.Name = "tanggal_riwayat"
        Me.tanggal_riwayat.Size = New System.Drawing.Size(278, 55)
        Me.tanggal_riwayat.TabIndex = 15
        Me.tanggal_riwayat.Value = New Date(2024, 12, 15, 23, 55, 29, 128)
        '
        'UbahStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 506)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Name = "UbahStok"
        Me.Text = "UbahStok"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericTambah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericKurangi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents buttonBatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents buttonSimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents textKodeKatalog As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboProduk As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericKurangi As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents NumericTambah As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents tanggal_riwayat As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
