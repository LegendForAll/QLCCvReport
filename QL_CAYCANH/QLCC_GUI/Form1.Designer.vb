<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel_header = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_rule = New System.Windows.Forms.Button()
        Me.btn_about = New System.Windows.Forms.Button()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.btn_manage = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.toolbar_report = New System.Windows.Forms.Panel()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.btn_cost = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.toolbar_manage = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btn_treeMenu = New System.Windows.Forms.Button()
        Me.btn_suppliesMenu = New System.Windows.Forms.Button()
        Me.btn_Num_tree = New System.Windows.Forms.Button()
        Me.btn_Num_VT = New System.Windows.Forms.Button()
        Me.btn_Num_report = New System.Windows.Forms.Button()
        Me.Panel_home = New System.Windows.Forms.Panel()
        Me.btn_Up_System = New System.Windows.Forms.Button()
        Me.Panel_header.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.toolbar_report.SuspendLayout()
        Me.toolbar_manage.SuspendLayout()
        Me.Panel_home.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_header
        '
        Me.Panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel_header.Controls.Add(Me.Button8)
        Me.Panel_header.Controls.Add(Me.Panel3)
        Me.Panel_header.Controls.Add(Me.Label1)
        Me.Panel_header.Controls.Add(Me.PictureBox1)
        Me.Panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_header.Name = "Panel_header"
        Me.Panel_header.Size = New System.Drawing.Size(905, 92)
        Me.Panel_header.TabIndex = 2
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(870, 9)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(23, 23)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "X"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_rule)
        Me.Panel3.Controls.Add(Me.btn_about)
        Me.Panel3.Controls.Add(Me.btn_report)
        Me.Panel3.Controls.Add(Me.btn_manage)
        Me.Panel3.Controls.Add(Me.btn_home)
        Me.Panel3.Location = New System.Drawing.Point(110, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(564, 34)
        Me.Panel3.TabIndex = 8
        '
        'btn_rule
        '
        Me.btn_rule.BackColor = System.Drawing.Color.Transparent
        Me.btn_rule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_rule.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.btn_rule.ForeColor = System.Drawing.Color.DarkGray
        Me.btn_rule.Location = New System.Drawing.Point(339, 3)
        Me.btn_rule.Name = "btn_rule"
        Me.btn_rule.Size = New System.Drawing.Size(106, 28)
        Me.btn_rule.TabIndex = 11
        Me.btn_rule.Text = "rule"
        Me.btn_rule.UseVisualStyleBackColor = False
        '
        'btn_about
        '
        Me.btn_about.BackColor = System.Drawing.Color.Transparent
        Me.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_about.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.btn_about.ForeColor = System.Drawing.Color.DarkGray
        Me.btn_about.Location = New System.Drawing.Point(451, 3)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Size = New System.Drawing.Size(106, 28)
        Me.btn_about.TabIndex = 10
        Me.btn_about.Text = "About"
        Me.btn_about.UseVisualStyleBackColor = False
        '
        'btn_report
        '
        Me.btn_report.BackColor = System.Drawing.Color.Transparent
        Me.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_report.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.btn_report.ForeColor = System.Drawing.Color.DarkGray
        Me.btn_report.Location = New System.Drawing.Point(227, 3)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Size = New System.Drawing.Size(106, 28)
        Me.btn_report.TabIndex = 9
        Me.btn_report.Text = "report"
        Me.btn_report.UseVisualStyleBackColor = False
        '
        'btn_manage
        '
        Me.btn_manage.BackColor = System.Drawing.Color.Transparent
        Me.btn_manage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_manage.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.btn_manage.ForeColor = System.Drawing.Color.DarkGray
        Me.btn_manage.Location = New System.Drawing.Point(115, 3)
        Me.btn_manage.Name = "btn_manage"
        Me.btn_manage.Size = New System.Drawing.Size(106, 28)
        Me.btn_manage.TabIndex = 8
        Me.btn_manage.Text = "manage"
        Me.btn_manage.UseVisualStyleBackColor = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Transparent
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.btn_home.ForeColor = System.Drawing.Color.DarkGray
        Me.btn_home.Location = New System.Drawing.Point(3, 3)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(106, 28)
        Me.btn_home.TabIndex = 7
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = " Tree of life"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_Up_System)
        Me.Panel1.Controls.Add(Me.toolbar_report)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.toolbar_manage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 477)
        Me.Panel1.TabIndex = 3
        '
        'toolbar_report
        '
        Me.toolbar_report.Controls.Add(Me.Button14)
        Me.toolbar_report.Controls.Add(Me.btn_cost)
        Me.toolbar_report.Controls.Add(Me.Button16)
        Me.toolbar_report.Enabled = False
        Me.toolbar_report.Location = New System.Drawing.Point(3, 148)
        Me.toolbar_report.Name = "toolbar_report"
        Me.toolbar_report.Size = New System.Drawing.Size(184, 101)
        Me.toolbar_report.TabIndex = 11
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Transparent
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Button14.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button14.Location = New System.Drawing.Point(3, 3)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(178, 28)
        Me.Button14.TabIndex = 8
        Me.Button14.Text = "report"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.UseVisualStyleBackColor = False
        '
        'btn_cost
        '
        Me.btn_cost.BackColor = System.Drawing.Color.Transparent
        Me.btn_cost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cost.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.btn_cost.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_cost.Location = New System.Drawing.Point(39, 37)
        Me.btn_cost.Name = "btn_cost"
        Me.btn_cost.Size = New System.Drawing.Size(142, 28)
        Me.btn_cost.TabIndex = 10
        Me.btn_cost.Text = "cost"
        Me.btn_cost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cost.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Transparent
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Button16.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button16.Location = New System.Drawing.Point(39, 71)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(142, 28)
        Me.Button16.TabIndex = 9
        Me.Button16.Text = "tree status"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(9, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "select category"
        '
        'toolbar_manage
        '
        Me.toolbar_manage.Controls.Add(Me.Button9)
        Me.toolbar_manage.Controls.Add(Me.btn_treeMenu)
        Me.toolbar_manage.Controls.Add(Me.btn_suppliesMenu)
        Me.toolbar_manage.Enabled = False
        Me.toolbar_manage.Location = New System.Drawing.Point(3, 43)
        Me.toolbar_manage.Name = "toolbar_manage"
        Me.toolbar_manage.Size = New System.Drawing.Size(184, 102)
        Me.toolbar_manage.TabIndex = 7
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.Button9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button9.Location = New System.Drawing.Point(3, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(178, 28)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "manage"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = False
        '
        'btn_treeMenu
        '
        Me.btn_treeMenu.BackColor = System.Drawing.Color.Transparent
        Me.btn_treeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_treeMenu.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.btn_treeMenu.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_treeMenu.Location = New System.Drawing.Point(39, 37)
        Me.btn_treeMenu.Name = "btn_treeMenu"
        Me.btn_treeMenu.Size = New System.Drawing.Size(142, 28)
        Me.btn_treeMenu.TabIndex = 10
        Me.btn_treeMenu.Text = "Tree"
        Me.btn_treeMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_treeMenu.UseVisualStyleBackColor = False
        '
        'btn_suppliesMenu
        '
        Me.btn_suppliesMenu.BackColor = System.Drawing.Color.Transparent
        Me.btn_suppliesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suppliesMenu.Font = New System.Drawing.Font("Stencil", 9.75!)
        Me.btn_suppliesMenu.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_suppliesMenu.Location = New System.Drawing.Point(39, 71)
        Me.btn_suppliesMenu.Name = "btn_suppliesMenu"
        Me.btn_suppliesMenu.Size = New System.Drawing.Size(142, 28)
        Me.btn_suppliesMenu.TabIndex = 9
        Me.btn_suppliesMenu.Text = "supplies"
        Me.btn_suppliesMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suppliesMenu.UseVisualStyleBackColor = False
        '
        'btn_Num_tree
        '
        Me.btn_Num_tree.BackColor = System.Drawing.Color.Lime
        Me.btn_Num_tree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Num_tree.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Num_tree.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_Num_tree.Image = CType(resources.GetObject("btn_Num_tree.Image"), System.Drawing.Image)
        Me.btn_Num_tree.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Num_tree.Location = New System.Drawing.Point(38, 43)
        Me.btn_Num_tree.Name = "btn_Num_tree"
        Me.btn_Num_tree.Size = New System.Drawing.Size(215, 93)
        Me.btn_Num_tree.TabIndex = 4
        Me.btn_Num_tree.Text = "1999"
        Me.btn_Num_tree.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_Num_tree.UseVisualStyleBackColor = False
        '
        'btn_Num_VT
        '
        Me.btn_Num_VT.BackColor = System.Drawing.Color.Yellow
        Me.btn_Num_VT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Num_VT.Font = New System.Drawing.Font("Stencil", 20.25!)
        Me.btn_Num_VT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_Num_VT.Image = CType(resources.GetObject("btn_Num_VT.Image"), System.Drawing.Image)
        Me.btn_Num_VT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Num_VT.Location = New System.Drawing.Point(262, 43)
        Me.btn_Num_VT.Name = "btn_Num_VT"
        Me.btn_Num_VT.Size = New System.Drawing.Size(215, 93)
        Me.btn_Num_VT.TabIndex = 5
        Me.btn_Num_VT.Text = "19"
        Me.btn_Num_VT.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_Num_VT.UseVisualStyleBackColor = False
        '
        'btn_Num_report
        '
        Me.btn_Num_report.BackColor = System.Drawing.Color.Red
        Me.btn_Num_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Num_report.Font = New System.Drawing.Font("Stencil", 20.25!)
        Me.btn_Num_report.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_Num_report.Image = CType(resources.GetObject("btn_Num_report.Image"), System.Drawing.Image)
        Me.btn_Num_report.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Num_report.Location = New System.Drawing.Point(483, 43)
        Me.btn_Num_report.Name = "btn_Num_report"
        Me.btn_Num_report.Size = New System.Drawing.Size(215, 93)
        Me.btn_Num_report.TabIndex = 6
        Me.btn_Num_report.Text = "99"
        Me.btn_Num_report.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_Num_report.UseVisualStyleBackColor = False
        '
        'Panel_home
        '
        Me.Panel_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Panel_home.BackgroundImage = CType(resources.GetObject("Panel_home.BackgroundImage"), System.Drawing.Image)
        Me.Panel_home.Controls.Add(Me.btn_Num_report)
        Me.Panel_home.Controls.Add(Me.btn_Num_VT)
        Me.Panel_home.Controls.Add(Me.btn_Num_tree)
        Me.Panel_home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_home.Location = New System.Drawing.Point(190, 92)
        Me.Panel_home.Name = "Panel_home"
        Me.Panel_home.Size = New System.Drawing.Size(715, 477)
        Me.Panel_home.TabIndex = 4
        '
        'btn_Up_System
        '
        Me.btn_Up_System.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_Up_System.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Up_System.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Up_System.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btn_Up_System.Image = CType(resources.GetObject("btn_Up_System.Image"), System.Drawing.Image)
        Me.btn_Up_System.Location = New System.Drawing.Point(147, 3)
        Me.btn_Up_System.Name = "btn_Up_System"
        Me.btn_Up_System.Size = New System.Drawing.Size(37, 37)
        Me.btn_Up_System.TabIndex = 10
        Me.btn_Up_System.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_Up_System.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(905, 569)
        Me.Controls.Add(Me.Panel_home)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenu"
        Me.Panel_header.ResumeLayout(False)
        Me.Panel_header.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.toolbar_report.ResumeLayout(False)
        Me.toolbar_manage.ResumeLayout(False)
        Me.Panel_home.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_header As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Num_tree As Button
    Friend WithEvents btn_Num_VT As Button
    Friend WithEvents btn_Num_report As Button
    Friend WithEvents Panel_home As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_home As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_manage As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents toolbar_manage As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents btn_treeMenu As Button
    Friend WithEvents btn_suppliesMenu As Button
    Friend WithEvents btn_report As Button
    Friend WithEvents btn_about As Button
    Friend WithEvents toolbar_report As Panel
    Friend WithEvents Button14 As Button
    Friend WithEvents btn_cost As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents btn_Up_System As Button
    Friend WithEvents btn_rule As Button
End Class
