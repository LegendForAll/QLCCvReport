<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmManageTREE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManageTREE))
        Me.btn_tree = New System.Windows.Forms.Button()
        Me.btn_care = New System.Windows.Forms.Button()
        Me.btn_calender = New System.Windows.Forms.Button()
        Me.btn_location = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_tree
        '
        Me.btn_tree.BackColor = System.Drawing.Color.Lime
        Me.btn_tree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tree.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tree.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_tree.Image = CType(resources.GetObject("btn_tree.Image"), System.Drawing.Image)
        Me.btn_tree.Location = New System.Drawing.Point(12, 12)
        Me.btn_tree.Name = "btn_tree"
        Me.btn_tree.Size = New System.Drawing.Size(82, 76)
        Me.btn_tree.TabIndex = 5
        Me.btn_tree.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_tree.UseVisualStyleBackColor = False
        '
        'btn_care
        '
        Me.btn_care.BackColor = System.Drawing.Color.Gray
        Me.btn_care.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_care.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_care.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_care.Image = CType(resources.GetObject("btn_care.Image"), System.Drawing.Image)
        Me.btn_care.Location = New System.Drawing.Point(276, 12)
        Me.btn_care.Name = "btn_care"
        Me.btn_care.Size = New System.Drawing.Size(82, 76)
        Me.btn_care.TabIndex = 6
        Me.btn_care.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_care.UseVisualStyleBackColor = False
        '
        'btn_calender
        '
        Me.btn_calender.BackColor = System.Drawing.Color.Teal
        Me.btn_calender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calender.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_calender.Image = CType(resources.GetObject("btn_calender.Image"), System.Drawing.Image)
        Me.btn_calender.Location = New System.Drawing.Point(188, 12)
        Me.btn_calender.Name = "btn_calender"
        Me.btn_calender.Size = New System.Drawing.Size(82, 76)
        Me.btn_calender.TabIndex = 7
        Me.btn_calender.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_calender.UseVisualStyleBackColor = False
        '
        'btn_location
        '
        Me.btn_location.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_location.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_location.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_location.Image = CType(resources.GetObject("btn_location.Image"), System.Drawing.Image)
        Me.btn_location.Location = New System.Drawing.Point(100, 12)
        Me.btn_location.Name = "btn_location"
        Me.btn_location.Size = New System.Drawing.Size(82, 76)
        Me.btn_location.TabIndex = 8
        Me.btn_location.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_location.UseVisualStyleBackColor = False
        '
        'FrmManageTREE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 99)
        Me.Controls.Add(Me.btn_location)
        Me.Controls.Add(Me.btn_calender)
        Me.Controls.Add(Me.btn_care)
        Me.Controls.Add(Me.btn_tree)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmManageTREE"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmManageTREE"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_tree As Button
    Friend WithEvents btn_care As Button
    Friend WithEvents btn_calender As Button
    Friend WithEvents btn_location As Button
End Class
