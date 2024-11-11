<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard_Admin2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard_Admin2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.kodePeternakan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.namaPeternakan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.deskripsiPeternakan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.alamatPeternakan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.button_edit = New Guna.UI2.WinForms.Guna2Button()
        Me.button_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.kode_peternakan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nama_peternakan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.deskripsi_peternakan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.alamat_peternakan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Guna2Button5)
        Me.Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Panel1.Controls.Add(Me.Guna2Button2)
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 807)
        Me.Panel1.TabIndex = 3
        '
        'Guna2Button5
        '
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.Green
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.Image = CType(resources.GetObject("Guna2Button5.Image"), System.Drawing.Image)
        Me.Guna2Button5.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button5.Location = New System.Drawing.Point(92, 665)
        Me.Guna2Button5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(136, 59)
        Me.Guna2Button5.TabIndex = 20
        Me.Guna2Button5.Text = "Keluar"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(2, 178)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(14, 81)
        Me.Guna2Panel2.TabIndex = 19
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
        Me.Guna2Button2.Location = New System.Drawing.Point(9, 287)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Padding = New System.Windows.Forms.Padding(38, 0, 0, 0)
        Me.Guna2Button2.Size = New System.Drawing.Size(310, 83)
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
        Me.Guna2Button1.Location = New System.Drawing.Point(9, 178)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Padding = New System.Windows.Forms.Padding(38, 0, 0, 0)
        Me.Guna2Button1.Size = New System.Drawing.Size(310, 81)
        Me.Guna2Button1.TabIndex = 2
        Me.Guna2Button1.Text = "      Data Peternakan"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(319, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1101, 80)
        Me.Guna2Panel1.TabIndex = 6
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(369, 206)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(206, 36)
        Me.Guna2HtmlLabel1.TabIndex = 7
        Me.Guna2HtmlLabel1.Text = "Kode Peternakan"
        '
        'kodePeternakan
        '
        Me.kodePeternakan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kodePeternakan.DefaultText = ""
        Me.kodePeternakan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.kodePeternakan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kodePeternakan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.kodePeternakan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.kodePeternakan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kodePeternakan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.kodePeternakan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kodePeternakan.Location = New System.Drawing.Point(369, 250)
        Me.kodePeternakan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.kodePeternakan.Name = "kodePeternakan"
        Me.kodePeternakan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kodePeternakan.PlaceholderText = ""
        Me.kodePeternakan.SelectedText = ""
        Me.kodePeternakan.Size = New System.Drawing.Size(206, 46)
        Me.kodePeternakan.TabIndex = 0
        '
        'namaPeternakan
        '
        Me.namaPeternakan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.namaPeternakan.DefaultText = ""
        Me.namaPeternakan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.namaPeternakan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.namaPeternakan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.namaPeternakan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.namaPeternakan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namaPeternakan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.namaPeternakan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namaPeternakan.Location = New System.Drawing.Point(644, 250)
        Me.namaPeternakan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.namaPeternakan.Name = "namaPeternakan"
        Me.namaPeternakan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.namaPeternakan.PlaceholderText = ""
        Me.namaPeternakan.SelectedText = ""
        Me.namaPeternakan.Size = New System.Drawing.Size(206, 46)
        Me.namaPeternakan.TabIndex = 1
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(644, 206)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(206, 50)
        Me.Guna2HtmlLabel2.TabIndex = 9
        Me.Guna2HtmlLabel2.Text = "Nama Peternakan"
        '
        'deskripsiPeternakan
        '
        Me.deskripsiPeternakan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.deskripsiPeternakan.DefaultText = ""
        Me.deskripsiPeternakan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.deskripsiPeternakan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.deskripsiPeternakan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.deskripsiPeternakan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.deskripsiPeternakan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.deskripsiPeternakan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.deskripsiPeternakan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.deskripsiPeternakan.Location = New System.Drawing.Point(922, 250)
        Me.deskripsiPeternakan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.deskripsiPeternakan.Name = "deskripsiPeternakan"
        Me.deskripsiPeternakan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.deskripsiPeternakan.PlaceholderText = ""
        Me.deskripsiPeternakan.SelectedText = ""
        Me.deskripsiPeternakan.Size = New System.Drawing.Size(206, 46)
        Me.deskripsiPeternakan.TabIndex = 2
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(1193, 206)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(206, 50)
        Me.Guna2HtmlLabel3.TabIndex = 11
        Me.Guna2HtmlLabel3.Text = "Alamat"
        '
        'alamatPeternakan
        '
        Me.alamatPeternakan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.alamatPeternakan.DefaultText = ""
        Me.alamatPeternakan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.alamatPeternakan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.alamatPeternakan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.alamatPeternakan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.alamatPeternakan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.alamatPeternakan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.alamatPeternakan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.alamatPeternakan.Location = New System.Drawing.Point(1193, 250)
        Me.alamatPeternakan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.alamatPeternakan.Name = "alamatPeternakan"
        Me.alamatPeternakan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.alamatPeternakan.PlaceholderText = ""
        Me.alamatPeternakan.SelectedText = ""
        Me.alamatPeternakan.Size = New System.Drawing.Size(206, 46)
        Me.alamatPeternakan.TabIndex = 3
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
        Me.button_edit.Location = New System.Drawing.Point(715, 334)
        Me.button_edit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.button_edit.Name = "button_edit"
        Me.button_edit.Size = New System.Drawing.Size(135, 36)
        Me.button_edit.TabIndex = 15
        Me.button_edit.Text = "Edit"
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
        Me.button_delete.Location = New System.Drawing.Point(922, 334)
        Me.button_delete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.button_delete.Name = "button_delete"
        Me.button_delete.Size = New System.Drawing.Size(135, 36)
        Me.button_delete.TabIndex = 16
        Me.button_delete.Text = "Delete"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(369, 406)
        Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(206, 36)
        Me.Guna2HtmlLabel5.TabIndex = 18
        Me.Guna2HtmlLabel5.Text = "List Peternakan"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(369, 99)
        Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(246, 57)
        Me.Guna2HtmlLabel6.TabIndex = 35
        Me.Guna2HtmlLabel6.Text = "Peternakan"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(922, 206)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(206, 50)
        Me.Guna2HtmlLabel4.TabIndex = 36
        Me.Guna2HtmlLabel4.Text = "Deskripsi"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.kode_peternakan, Me.nama_peternakan, Me.deskripsi_peternakan, Me.alamat_peternakan})
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(369, 447)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1044, 361)
        Me.ListView1.TabIndex = 37
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'kode_peternakan
        '
        Me.kode_peternakan.Text = "Kode Peternakan"
        Me.kode_peternakan.Width = 300
        '
        'nama_peternakan
        '
        Me.nama_peternakan.Text = "Nama Peternakan"
        Me.nama_peternakan.Width = 250
        '
        'deskripsi_peternakan
        '
        Me.deskripsi_peternakan.Text = "Deskripsi Peternakan"
        Me.deskripsi_peternakan.Width = 580
        '
        'alamat_peternakan
        '
        Me.alamat_peternakan.Text = "Alamat Peternakan"
        Me.alamat_peternakan.Width = 250
        '
        'Dashboard_Admin2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1420, 807)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.button_delete)
        Me.Controls.Add(Me.button_edit)
        Me.Controls.Add(Me.alamatPeternakan)
        Me.Controls.Add(Me.deskripsiPeternakan)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.namaPeternakan)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.kodePeternakan)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Dashboard_Admin2"
        Me.Text = "Dashboard_Admin2"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents kodePeternakan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents namaPeternakan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents deskripsiPeternakan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents alamatPeternakan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents button_edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents button_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents kode_peternakan As ColumnHeader
    Friend WithEvents nama_peternakan As ColumnHeader
    Friend WithEvents deskripsi_peternakan As ColumnHeader
    Friend WithEvents alamat_peternakan As ColumnHeader
End Class
