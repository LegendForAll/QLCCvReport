﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmThemChamSoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmThemChamSoc))
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_huy = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Ud_soluongCS = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.tbx_IDChamSoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbx_vattu = New System.Windows.Forms.ComboBox()
        Me.btn_ThemCS = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_TGCham = New System.Windows.Forms.DateTimePicker()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.cbx_GhiChu = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.cbx_TenCay = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbx_tinhtrang = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel3.SuspendLayout()
        CType(Me.Ud_soluongCS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(403, 215)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(65, 25)
        Me.btn_update.TabIndex = 19
        Me.btn_update.Text = "update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_huy
        '
        Me.btn_huy.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_huy.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_huy.ForeColor = System.Drawing.Color.White
        Me.btn_huy.Location = New System.Drawing.Point(545, 215)
        Me.btn_huy.Name = "btn_huy"
        Me.btn_huy.Size = New System.Drawing.Size(65, 25)
        Me.btn_huy.TabIndex = 36
        Me.btn_huy.Text = "Cancel"
        Me.btn_huy.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Ud_soluongCS)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(16, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(245, 26)
        Me.Panel3.TabIndex = 13
        '
        'Ud_soluongCS
        '
        Me.Ud_soluongCS.Location = New System.Drawing.Point(161, 3)
        Me.Ud_soluongCS.Name = "Ud_soluongCS"
        Me.Ud_soluongCS.Size = New System.Drawing.Size(81, 20)
        Me.Ud_soluongCS.TabIndex = 4
        Me.Ud_soluongCS.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Number:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.tbx_IDChamSoc)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Location = New System.Drawing.Point(17, 19)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(245, 26)
        Me.Panel7.TabIndex = 18
        '
        'tbx_IDChamSoc
        '
        Me.tbx_IDChamSoc.Location = New System.Drawing.Point(121, 2)
        Me.tbx_IDChamSoc.Name = "tbx_IDChamSoc"
        Me.tbx_IDChamSoc.ReadOnly = True
        Me.tbx_IDChamSoc.Size = New System.Drawing.Size(121, 20)
        Me.tbx_IDChamSoc.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.cbx_vattu)
        Me.Panel8.Location = New System.Drawing.Point(16, 19)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(245, 26)
        Me.Panel8.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Supplies:"
        '
        'cbx_vattu
        '
        Me.cbx_vattu.FormattingEnabled = True
        Me.cbx_vattu.Location = New System.Drawing.Point(121, 2)
        Me.cbx_vattu.Name = "cbx_vattu"
        Me.cbx_vattu.Size = New System.Drawing.Size(121, 21)
        Me.cbx_vattu.TabIndex = 9
        '
        'btn_ThemCS
        '
        Me.btn_ThemCS.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_ThemCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ThemCS.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ThemCS.ForeColor = System.Drawing.Color.White
        Me.btn_ThemCS.Location = New System.Drawing.Point(474, 215)
        Me.btn_ThemCS.Name = "btn_ThemCS"
        Me.btn_ThemCS.Size = New System.Drawing.Size(65, 25)
        Me.btn_ThemCS.TabIndex = 18
        Me.btn_ThemCS.Text = "Insert"
        Me.btn_ThemCS.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.dtp_TGCham)
        Me.Panel9.Location = New System.Drawing.Point(353, 176)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(245, 26)
        Me.Panel9.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Time of care:"
        '
        'dtp_TGCham
        '
        Me.dtp_TGCham.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_TGCham.Location = New System.Drawing.Point(121, 3)
        Me.dtp_TGCham.Name = "dtp_TGCham"
        Me.dtp_TGCham.Size = New System.Drawing.Size(121, 20)
        Me.dtp_TGCham.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.Controls.Add(Me.cbx_GhiChu)
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Location = New System.Drawing.Point(25, 48)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(245, 26)
        Me.Panel10.TabIndex = 32
        '
        'cbx_GhiChu
        '
        Me.cbx_GhiChu.FormattingEnabled = True
        Me.cbx_GhiChu.Items.AddRange(New Object() {"Sick", "Strong", "Death"})
        Me.cbx_GhiChu.Location = New System.Drawing.Point(121, 3)
        Me.cbx_GhiChu.Name = "cbx_GhiChu"
        Me.cbx_GhiChu.Size = New System.Drawing.Size(121, 21)
        Me.cbx_GhiChu.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Note:"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Transparent
        Me.Panel12.Controls.Add(Me.cbx_TenCay)
        Me.Panel12.Controls.Add(Me.Label10)
        Me.Panel12.Location = New System.Drawing.Point(17, 48)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(245, 26)
        Me.Panel12.TabIndex = 30
        '
        'cbx_TenCay
        '
        Me.cbx_TenCay.FormattingEnabled = True
        Me.cbx_TenCay.Location = New System.Drawing.Point(121, 2)
        Me.cbx_TenCay.Name = "cbx_TenCay"
        Me.cbx_TenCay.Size = New System.Drawing.Size(121, 21)
        Me.cbx_TenCay.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(3, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Tree ID:"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.Label9)
        Me.Panel11.Controls.Add(Me.cbx_tinhtrang)
        Me.Panel11.Location = New System.Drawing.Point(25, 19)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(245, 26)
        Me.Panel11.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(3, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Quantity:"
        '
        'cbx_tinhtrang
        '
        Me.cbx_tinhtrang.FormattingEnabled = True
        Me.cbx_tinhtrang.Items.AddRange(New Object() {"Normal", "Good"})
        Me.cbx_tinhtrang.Location = New System.Drawing.Point(121, 2)
        Me.cbx_tinhtrang.Name = "cbx_tinhtrang"
        Me.cbx_tinhtrang.Size = New System.Drawing.Size(121, 21)
        Me.cbx_tinhtrang.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 30)
        Me.Panel1.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "take care of plant"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel11)
        Me.GroupBox1.Controls.Add(Me.Panel10)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Location = New System.Drawing.Point(328, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 100)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel7)
        Me.GroupBox2.Controls.Add(Me.Panel12)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Location = New System.Drawing.Point(22, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 100)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tree"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel8)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox3.Location = New System.Drawing.Point(23, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(277, 83)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Supplies"
        '
        'FrmThemChamSoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 253)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_huy)
        Me.Controls.Add(Me.btn_ThemCS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmThemChamSoc"
        Me.Text = "FrmThemChamSoc"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Ud_soluongCS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Ud_soluongCS As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents tbx_IDChamSoc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents cbx_vattu As ComboBox
    Friend WithEvents btn_ThemCS As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_TGCham As DateTimePicker
    Friend WithEvents Panel10 As Panel
    Friend WithEvents cbx_GhiChu As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents cbx_TenCay As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents cbx_tinhtrang As ComboBox
    Friend WithEvents btn_huy As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
