<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_Admin_3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard_Admin_3))
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.button_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.button_edit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.deskripsiArtikel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.judulArtikel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.kodeArtikel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.button_addArticle = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.kode_artikel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.judul_artikel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.deskripsi_artikel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tanggal_artikel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tanggalArtikel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(3, 357)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(18, 101)
        Me.Guna2Panel2.TabIndex = 19
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(492, 508)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(275, 45)
        Me.Guna2HtmlLabel5.TabIndex = 32
        Me.Guna2HtmlLabel5.Text = "List Artikel"
        '
        'button_delete
        '
        Me.button_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.button_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.button_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.button_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.button_delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button_delete.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_delete.ForeColor = System.Drawing.Color.IndianRed
        Me.button_delete.Location = New System.Drawing.Point(1324, 413)
        Me.button_delete.Name = "button_delete"
        Me.button_delete.Size = New System.Drawing.Size(180, 45)
        Me.button_delete.TabIndex = 30
        Me.button_delete.Text = "Delete"
        '
        'button_edit
        '
        Me.button_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.button_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.button_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.button_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.button_edit.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button_edit.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_edit.ForeColor = System.Drawing.Color.White
        Me.button_edit.Location = New System.Drawing.Point(858, 413)
        Me.button_edit.Name = "button_edit"
        Me.button_edit.Size = New System.Drawing.Size(180, 45)
        Me.button_edit.TabIndex = 29
        Me.button_edit.Text = "Edit"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(1591, 258)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(170, 45)
        Me.Guna2HtmlLabel4.TabIndex = 27
        Me.Guna2HtmlLabel4.Text = "Tanggal"
        '
        'deskripsiArtikel
        '
        Me.deskripsiArtikel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.deskripsiArtikel.DefaultText = ""
        Me.deskripsiArtikel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.deskripsiArtikel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.deskripsiArtikel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.deskripsiArtikel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.deskripsiArtikel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.deskripsiArtikel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.deskripsiArtikel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.deskripsiArtikel.Location = New System.Drawing.Point(1229, 312)
        Me.deskripsiArtikel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.deskripsiArtikel.Name = "deskripsiArtikel"
        Me.deskripsiArtikel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.deskripsiArtikel.PlaceholderText = ""
        Me.deskripsiArtikel.SelectedText = ""
        Me.deskripsiArtikel.Size = New System.Drawing.Size(275, 58)
        Me.deskripsiArtikel.TabIndex = 2
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(1229, 258)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(275, 62)
        Me.Guna2HtmlLabel3.TabIndex = 25
        Me.Guna2HtmlLabel3.Text = "Deskripsi"
        '
        'judulArtikel
        '
        Me.judulArtikel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.judulArtikel.DefaultText = ""
        Me.judulArtikel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.judulArtikel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.judulArtikel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.judulArtikel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.judulArtikel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.judulArtikel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.judulArtikel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.judulArtikel.Location = New System.Drawing.Point(858, 312)
        Me.judulArtikel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.judulArtikel.Name = "judulArtikel"
        Me.judulArtikel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.judulArtikel.PlaceholderText = ""
        Me.judulArtikel.SelectedText = ""
        Me.judulArtikel.Size = New System.Drawing.Size(275, 58)
        Me.judulArtikel.TabIndex = 1
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(858, 258)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(275, 62)
        Me.Guna2HtmlLabel2.TabIndex = 23
        Me.Guna2HtmlLabel2.Text = "Judul"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(492, 258)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(275, 45)
        Me.Guna2HtmlLabel1.TabIndex = 21
        Me.Guna2HtmlLabel1.Text = "Kode Artikel"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(425, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1469, 100)
        Me.Guna2Panel1.TabIndex = 20
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Green
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button2.Location = New System.Drawing.Point(12, 359)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.Guna2Button2.Size = New System.Drawing.Size(414, 104)
        Me.Guna2Button2.TabIndex = 3
        Me.Guna2Button2.Text = "Data Artikel"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Green
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.LokaTernak.My.Resources.Resources.farmer
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button1.Location = New System.Drawing.Point(12, 223)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.Guna2Button1.Size = New System.Drawing.Size(414, 101)
        Me.Guna2Button1.TabIndex = 2
        Me.Guna2Button1.Text = "      Data Peternakan"
        '
        'kodeArtikel
        '
        Me.kodeArtikel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kodeArtikel.DefaultText = ""
        Me.kodeArtikel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.kodeArtikel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kodeArtikel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.kodeArtikel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.kodeArtikel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kodeArtikel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.kodeArtikel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kodeArtikel.Location = New System.Drawing.Point(492, 312)
        Me.kodeArtikel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.kodeArtikel.Name = "kodeArtikel"
        Me.kodeArtikel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kodeArtikel.PlaceholderText = ""
        Me.kodeArtikel.SelectedText = ""
        Me.kodeArtikel.Size = New System.Drawing.Size(275, 58)
        Me.kodeArtikel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Guna2Button6)
        Me.Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Panel1.Controls.Add(Me.Guna2Button2)
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 1009)
        Me.Panel1.TabIndex = 19
        '
        'Guna2Button6
        '
        Me.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button6.FillColor = System.Drawing.Color.Green
        Me.Guna2Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.Image = CType(resources.GetObject("Guna2Button6.Image"), System.Drawing.Image)
        Me.Guna2Button6.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button6.Location = New System.Drawing.Point(120, 853)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(181, 74)
        Me.Guna2Button6.TabIndex = 21
        Me.Guna2Button6.Text = "Keluar"
        '
        'button_addArticle
        '
        Me.button_addArticle.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.button_addArticle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.button_addArticle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.button_addArticle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.button_addArticle.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button_addArticle.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_addArticle.ForeColor = System.Drawing.Color.White
        Me.button_addArticle.Location = New System.Drawing.Point(1094, 413)
        Me.button_addArticle.Name = "button_addArticle"
        Me.button_addArticle.Size = New System.Drawing.Size(180, 45)
        Me.button_addArticle.TabIndex = 33
        Me.button_addArticle.Text = "Add Article"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(492, 148)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(184, 71)
        Me.Guna2HtmlLabel6.TabIndex = 34
        Me.Guna2HtmlLabel6.Text = "Artikel"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.kode_artikel, Me.judul_artikel, Me.deskripsi_artikel, Me.tanggal_artikel})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(492, 568)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1374, 420)
        Me.ListView1.TabIndex = 35
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'kode_artikel
        '
        Me.kode_artikel.Text = "Kode Artikel"
        Me.kode_artikel.Width = 200
        '
        'judul_artikel
        '
        Me.judul_artikel.Text = "Judul Artikel"
        Me.judul_artikel.Width = 400
        '
        'deskripsi_artikel
        '
        Me.deskripsi_artikel.Text = "Deskripsi"
        Me.deskripsi_artikel.Width = 600
        '
        'tanggal_artikel
        '
        Me.tanggal_artikel.Text = "Tanggal"
        Me.tanggal_artikel.Width = 200
        '
        'tanggalArtikel
        '
        Me.tanggalArtikel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tanggalArtikel.DefaultText = ""
        Me.tanggalArtikel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tanggalArtikel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tanggalArtikel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tanggalArtikel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tanggalArtikel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tanggalArtikel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tanggalArtikel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tanggalArtikel.Location = New System.Drawing.Point(1591, 312)
        Me.tanggalArtikel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tanggalArtikel.Name = "tanggalArtikel"
        Me.tanggalArtikel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tanggalArtikel.PlaceholderText = ""
        Me.tanggalArtikel.SelectedText = ""
        Me.tanggalArtikel.Size = New System.Drawing.Size(275, 58)
        Me.tanggalArtikel.TabIndex = 3
        '
        'Dashboard_Admin_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.button_addArticle)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.button_delete)
        Me.Controls.Add(Me.button_edit)
        Me.Controls.Add(Me.tanggalArtikel)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.deskripsiArtikel)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.judulArtikel)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.kodeArtikel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Dashboard_Admin_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard_Admin_3"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents button_edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents deskripsiArtikel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents judulArtikel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents kodeArtikel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents button_addArticle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents kode_artikel As ColumnHeader
    Friend WithEvents judul_artikel As ColumnHeader
    Friend WithEvents deskripsi_artikel As ColumnHeader
    Friend WithEvents tanggal_artikel As ColumnHeader
    Friend WithEvents tanggalArtikel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents button_delete As Guna.UI2.WinForms.Guna2Button
End Class
