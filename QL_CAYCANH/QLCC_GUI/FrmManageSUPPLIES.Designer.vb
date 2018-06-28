<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManageSUPPLIES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManageSUPPLIES))
        Me.btn_offers = New System.Windows.Forms.Button()
        Me.btn_Supplies = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_offers
        '
        Me.btn_offers.BackColor = System.Drawing.Color.GreenYellow
        Me.btn_offers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_offers.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_offers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_offers.Image = CType(resources.GetObject("btn_offers.Image"), System.Drawing.Image)
        Me.btn_offers.Location = New System.Drawing.Point(100, 12)
        Me.btn_offers.Name = "btn_offers"
        Me.btn_offers.Size = New System.Drawing.Size(82, 76)
        Me.btn_offers.TabIndex = 10
        Me.btn_offers.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_offers.UseVisualStyleBackColor = False
        '
        'btn_Supplies
        '
        Me.btn_Supplies.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_Supplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Supplies.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Supplies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_Supplies.Image = CType(resources.GetObject("btn_Supplies.Image"), System.Drawing.Image)
        Me.btn_Supplies.Location = New System.Drawing.Point(12, 12)
        Me.btn_Supplies.Name = "btn_Supplies"
        Me.btn_Supplies.Size = New System.Drawing.Size(82, 76)
        Me.btn_Supplies.TabIndex = 9
        Me.btn_Supplies.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_Supplies.UseVisualStyleBackColor = False
        '
        'FrmManageSUPPLIES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(196, 99)
        Me.Controls.Add(Me.btn_offers)
        Me.Controls.Add(Me.btn_Supplies)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmManageSUPPLIES"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmManageSUPPLIES"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_offers As Button
    Friend WithEvents btn_Supplies As Button
End Class
