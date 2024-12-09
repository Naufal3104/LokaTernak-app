<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class balas_diskusi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textKodeDiskusi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.textIsiBalasan = New System.Windows.Forms.RichTextBox()
        Me.buttonSimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.buttonBatal = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Balas Diskusi"
        '
        'textKodeDiskusi
        '
        Me.textKodeDiskusi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textKodeDiskusi.DefaultText = ""
        Me.textKodeDiskusi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textKodeDiskusi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textKodeDiskusi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textKodeDiskusi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textKodeDiskusi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textKodeDiskusi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textKodeDiskusi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textKodeDiskusi.Location = New System.Drawing.Point(135, 71)
        Me.textKodeDiskusi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textKodeDiskusi.Name = "textKodeDiskusi"
        Me.textKodeDiskusi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textKodeDiskusi.PlaceholderText = ""
        Me.textKodeDiskusi.SelectedText = ""
        Me.textKodeDiskusi.Size = New System.Drawing.Size(305, 41)
        Me.textKodeDiskusi.TabIndex = 1
        '
        'textIsiBalasan
        '
        Me.textIsiBalasan.Location = New System.Drawing.Point(135, 136)
        Me.textIsiBalasan.Name = "textIsiBalasan"
        Me.textIsiBalasan.Size = New System.Drawing.Size(653, 217)
        Me.textIsiBalasan.TabIndex = 2
        Me.textIsiBalasan.Text = ""
        '
        'buttonSimpan
        '
        Me.buttonSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.buttonSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.buttonSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.buttonSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.buttonSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.buttonSimpan.ForeColor = System.Drawing.Color.White
        Me.buttonSimpan.Location = New System.Drawing.Point(608, 393)
        Me.buttonSimpan.Name = "buttonSimpan"
        Me.buttonSimpan.Size = New System.Drawing.Size(180, 45)
        Me.buttonSimpan.TabIndex = 3
        Me.buttonSimpan.Text = "Balas"
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
        Me.buttonBatal.Location = New System.Drawing.Point(422, 393)
        Me.buttonBatal.Name = "buttonBatal"
        Me.buttonBatal.Size = New System.Drawing.Size(180, 45)
        Me.buttonBatal.TabIndex = 4
        Me.buttonBatal.Text = "Batal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Balas Ke"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pesan Balasan"
        '
        'balas_diskusi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buttonBatal)
        Me.Controls.Add(Me.buttonSimpan)
        Me.Controls.Add(Me.textIsiBalasan)
        Me.Controls.Add(Me.textKodeDiskusi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "balas_diskusi"
        Me.Text = "balas_diskusi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textKodeDiskusi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents textIsiBalasan As RichTextBox
    Friend WithEvents buttonSimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents buttonBatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
