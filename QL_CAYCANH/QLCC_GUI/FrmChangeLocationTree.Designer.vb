<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangeLocationTree
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangeLocationTree))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_huy = New System.Windows.Forms.Button()
        Me.btn_to_from = New System.Windows.Forms.Button()
        Me.btn_from_to = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_ViTri_To = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_Vitri_Form = New System.Windows.Forms.ComboBox()
        Me.dgv_to = New System.Windows.Forms.DataGridView()
        Me.dgv_from = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbx_ID_From = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tbx_ID_To = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv_to, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_from, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 30)
        Me.Panel1.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Change location"
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.btn_huy)
        Me.Panel2.Controls.Add(Me.btn_to_from)
        Me.Panel2.Controls.Add(Me.btn_from_to)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(850, 388)
        Me.Panel2.TabIndex = 38
        '
        'btn_huy
        '
        Me.btn_huy.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_huy.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_huy.ForeColor = System.Drawing.Color.White
        Me.btn_huy.Location = New System.Drawing.Point(761, 337)
        Me.btn_huy.Name = "btn_huy"
        Me.btn_huy.Size = New System.Drawing.Size(65, 25)
        Me.btn_huy.TabIndex = 39
        Me.btn_huy.Text = "Cancel"
        Me.btn_huy.UseVisualStyleBackColor = False
        '
        'btn_to_from
        '
        Me.btn_to_from.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_to_from.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_to_from.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_to_from.ForeColor = System.Drawing.Color.White
        Me.btn_to_from.Image = CType(resources.GetObject("btn_to_from.Image"), System.Drawing.Image)
        Me.btn_to_from.Location = New System.Drawing.Point(394, 143)
        Me.btn_to_from.Name = "btn_to_from"
        Me.btn_to_from.Size = New System.Drawing.Size(65, 35)
        Me.btn_to_from.TabIndex = 43
        Me.btn_to_from.UseVisualStyleBackColor = False
        '
        'btn_from_to
        '
        Me.btn_from_to.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_from_to.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_from_to.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_from_to.ForeColor = System.Drawing.Color.White
        Me.btn_from_to.Image = CType(resources.GetObject("btn_from_to.Image"), System.Drawing.Image)
        Me.btn_from_to.Location = New System.Drawing.Point(394, 102)
        Me.btn_from_to.Name = "btn_from_to"
        Me.btn_from_to.Size = New System.Drawing.Size(65, 35)
        Me.btn_from_to.TabIndex = 42
        Me.btn_from_to.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.cbx_ViTri_To)
        Me.Panel3.Location = New System.Drawing.Point(17, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(282, 26)
        Me.Panel3.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "location to:"
        '
        'cbx_ViTri_To
        '
        Me.cbx_ViTri_To.FormattingEnabled = True
        Me.cbx_ViTri_To.Location = New System.Drawing.Point(117, 3)
        Me.cbx_ViTri_To.Name = "cbx_ViTri_To"
        Me.cbx_ViTri_To.Size = New System.Drawing.Size(162, 21)
        Me.cbx_ViTri_To.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.cbx_Vitri_Form)
        Me.Panel5.Location = New System.Drawing.Point(13, 19)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(282, 26)
        Me.Panel5.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "location from:"
        '
        'cbx_Vitri_Form
        '
        Me.cbx_Vitri_Form.FormattingEnabled = True
        Me.cbx_Vitri_Form.Location = New System.Drawing.Point(117, 3)
        Me.cbx_Vitri_Form.Name = "cbx_Vitri_Form"
        Me.cbx_Vitri_Form.Size = New System.Drawing.Size(162, 21)
        Me.cbx_Vitri_Form.TabIndex = 9
        '
        'dgv_to
        '
        Me.dgv_to.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_to.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_to.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_to.Location = New System.Drawing.Point(17, 81)
        Me.dgv_to.Name = "dgv_to"
        Me.dgv_to.Size = New System.Drawing.Size(333, 204)
        Me.dgv_to.TabIndex = 1
        '
        'dgv_from
        '
        Me.dgv_from.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_from.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_from.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_from.Location = New System.Drawing.Point(13, 81)
        Me.dgv_from.Name = "dgv_from"
        Me.dgv_from.Size = New System.Drawing.Size(333, 204)
        Me.dgv_from.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.dgv_from)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 310)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Location from"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.tbx_ID_From)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(13, 49)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(212, 26)
        Me.Panel4.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "id tree:"
        '
        'tbx_ID_From
        '
        Me.tbx_ID_From.Location = New System.Drawing.Point(117, 3)
        Me.tbx_ID_From.Name = "tbx_ID_From"
        Me.tbx_ID_From.ReadOnly = True
        Me.tbx_ID_From.Size = New System.Drawing.Size(90, 20)
        Me.tbx_ID_From.TabIndex = 45
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel6)
        Me.GroupBox2.Controls.Add(Me.dgv_to)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Location = New System.Drawing.Point(476, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 310)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Location to"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.tbx_ID_To)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Location = New System.Drawing.Point(17, 49)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(212, 26)
        Me.Panel6.TabIndex = 46
        '
        'tbx_ID_To
        '
        Me.tbx_ID_To.Location = New System.Drawing.Point(117, 3)
        Me.tbx_ID_To.Name = "tbx_ID_To"
        Me.tbx_ID_To.ReadOnly = True
        Me.tbx_ID_To.Size = New System.Drawing.Size(90, 20)
        Me.tbx_ID_To.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Stencil", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "id tree:"
        '
        'FrmChangeLocationTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 418)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmChangeLocationTree"
        Me.Text = "FrmChangeLocationTree"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgv_to, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_from, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgv_to As DataGridView
    Friend WithEvents dgv_from As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_ViTri_To As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_Vitri_Form As ComboBox
    Friend WithEvents btn_to_from As Button
    Friend WithEvents btn_from_to As Button
    Friend WithEvents btn_huy As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tbx_ID_From As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents tbx_ID_To As TextBox
    Friend WithEvents Label5 As Label
End Class
