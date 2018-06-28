<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRULE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRULE))
        Me.btn_location = New System.Windows.Forms.Button()
        Me.btn_unit = New System.Windows.Forms.Button()
        Me.btn_type = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_update_money = New System.Windows.Forms.Button()
        Me.cbx_QD_Tien = New System.Windows.Forms.ComboBox()
        Me.tbx_money = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_location
        '
        Me.btn_location.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_location.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_location.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_location.Image = CType(resources.GetObject("btn_location.Image"), System.Drawing.Image)
        Me.btn_location.Location = New System.Drawing.Point(26, 29)
        Me.btn_location.Name = "btn_location"
        Me.btn_location.Size = New System.Drawing.Size(82, 76)
        Me.btn_location.TabIndex = 10
        Me.btn_location.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_location.UseVisualStyleBackColor = False
        '
        'btn_unit
        '
        Me.btn_unit.BackColor = System.Drawing.Color.Gray
        Me.btn_unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_unit.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_unit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_unit.Image = CType(resources.GetObject("btn_unit.Image"), System.Drawing.Image)
        Me.btn_unit.Location = New System.Drawing.Point(26, 208)
        Me.btn_unit.Name = "btn_unit"
        Me.btn_unit.Size = New System.Drawing.Size(82, 76)
        Me.btn_unit.TabIndex = 11
        Me.btn_unit.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_unit.UseVisualStyleBackColor = False
        '
        'btn_type
        '
        Me.btn_type.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btn_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_type.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_type.Image = CType(resources.GetObject("btn_type.Image"), System.Drawing.Image)
        Me.btn_type.Location = New System.Drawing.Point(26, 117)
        Me.btn_type.Name = "btn_type"
        Me.btn_type.Size = New System.Drawing.Size(82, 76)
        Me.btn_type.TabIndex = 12
        Me.btn_type.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_type.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Location tree"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(13, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Type tree"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(13, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Unit supplies"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(114, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 76)
        Me.Panel1.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(114, 117)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 76)
        Me.Panel2.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(114, 208)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(176, 76)
        Me.Panel3.TabIndex = 18
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.tbx_money)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cbx_QD_Tien)
        Me.Panel4.Location = New System.Drawing.Point(114, 299)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(176, 125)
        Me.Panel4.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(13, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Money max"
        '
        'btn_update_money
        '
        Me.btn_update_money.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_update_money.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update_money.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update_money.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_update_money.Image = CType(resources.GetObject("btn_update_money.Image"), System.Drawing.Image)
        Me.btn_update_money.Location = New System.Drawing.Point(26, 299)
        Me.btn_update_money.Name = "btn_update_money"
        Me.btn_update_money.Size = New System.Drawing.Size(82, 76)
        Me.btn_update_money.TabIndex = 19
        Me.btn_update_money.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_update_money.UseVisualStyleBackColor = False
        '
        'cbx_QD_Tien
        '
        Me.cbx_QD_Tien.Enabled = False
        Me.cbx_QD_Tien.FormattingEnabled = True
        Me.cbx_QD_Tien.Location = New System.Drawing.Point(16, 30)
        Me.cbx_QD_Tien.Name = "cbx_QD_Tien"
        Me.cbx_QD_Tien.Size = New System.Drawing.Size(145, 21)
        Me.cbx_QD_Tien.TabIndex = 9
        '
        'tbx_money
        '
        Me.tbx_money.Location = New System.Drawing.Point(16, 85)
        Me.tbx_money.Name = "tbx_money"
        Me.tbx_money.Size = New System.Drawing.Size(145, 20)
        Me.tbx_money.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(13, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Money max new"
        '
        'FrmRULE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 455)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btn_update_money)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_type)
        Me.Controls.Add(Me.btn_unit)
        Me.Controls.Add(Me.btn_location)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRULE"
        Me.Opacity = 0.8R
        Me.Text = "FrmRULE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_location As Button
    Friend WithEvents btn_unit As Button
    Friend WithEvents btn_type As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_update_money As Button
    Friend WithEvents cbx_QD_Tien As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbx_money As TextBox
End Class
