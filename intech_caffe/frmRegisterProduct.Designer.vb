<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterProduct))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbGrupi = New System.Windows.Forms.ComboBox()
        Me.cmbKategoria = New System.Windows.Forms.ComboBox()
        Me.txtEmri = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdb2PSh = New System.Windows.Forms.RadioButton()
        Me.rdbSh = New System.Windows.Forms.RadioButton()
        Me.rdbP = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCmimi = New System.Windows.Forms.TextBox()
        Me.txtTVSH = New System.Windows.Forms.TextBox()
        Me.btnRegjistro = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtgProduktet = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgProduktet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 50)
        Me.Panel1.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 31)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "InTech"
        '
        'cmbGrupi
        '
        Me.cmbGrupi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbGrupi.FormattingEnabled = True
        Me.cmbGrupi.Items.AddRange(New Object() {"Ushqim", "Pije"})
        Me.cmbGrupi.Location = New System.Drawing.Point(94, 69)
        Me.cmbGrupi.Name = "cmbGrupi"
        Me.cmbGrupi.Size = New System.Drawing.Size(158, 21)
        Me.cmbGrupi.TabIndex = 0
        '
        'cmbKategoria
        '
        Me.cmbKategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKategoria.FormattingEnabled = True
        Me.cmbKategoria.Items.AddRange(New Object() {"Sallat", "Pije Freskuese", "Pije Alkoholike", "Pizza", "Skar"})
        Me.cmbKategoria.Location = New System.Drawing.Point(94, 96)
        Me.cmbKategoria.Name = "cmbKategoria"
        Me.cmbKategoria.Size = New System.Drawing.Size(158, 21)
        Me.cmbKategoria.TabIndex = 1
        '
        'txtEmri
        '
        Me.txtEmri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmri.Location = New System.Drawing.Point(94, 123)
        Me.txtEmri.Name = "txtEmri"
        Me.txtEmri.Size = New System.Drawing.Size(158, 20)
        Me.txtEmri.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdb2PSh)
        Me.GroupBox1.Controls.Add(Me.rdbSh)
        Me.GroupBox1.Controls.Add(Me.rdbP)
        Me.GroupBox1.Location = New System.Drawing.Point(281, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 91)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipi"
        '
        'rdb2PSh
        '
        Me.rdb2PSh.AutoSize = True
        Me.rdb2PSh.BackColor = System.Drawing.Color.Transparent
        Me.rdb2PSh.Location = New System.Drawing.Point(42, 60)
        Me.rdb2PSh.Name = "rdb2PSh"
        Me.rdb2PSh.Size = New System.Drawing.Size(108, 17)
        Me.rdb2PSh.TabIndex = 6
        Me.rdb2PSh.TabStop = True
        Me.rdb2PSh.Text = "Perberes && Shites"
        Me.rdb2PSh.UseVisualStyleBackColor = False
        '
        'rdbSh
        '
        Me.rdbSh.AutoSize = True
        Me.rdbSh.BackColor = System.Drawing.Color.Transparent
        Me.rdbSh.Location = New System.Drawing.Point(42, 37)
        Me.rdbSh.Name = "rdbSh"
        Me.rdbSh.Size = New System.Drawing.Size(54, 17)
        Me.rdbSh.TabIndex = 5
        Me.rdbSh.TabStop = True
        Me.rdbSh.Text = "Shites"
        Me.rdbSh.UseVisualStyleBackColor = False
        '
        'rdbP
        '
        Me.rdbP.AutoSize = True
        Me.rdbP.BackColor = System.Drawing.Color.Transparent
        Me.rdbP.Location = New System.Drawing.Point(42, 14)
        Me.rdbP.Name = "rdbP"
        Me.rdbP.Size = New System.Drawing.Size(67, 17)
        Me.rdbP.TabIndex = 4
        Me.rdbP.TabStop = True
        Me.rdbP.Text = "Perberes"
        Me.rdbP.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(50, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Grupi :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(30, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Kategoria :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(55, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Emri :"
        '
        'txtCmimi
        '
        Me.txtCmimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCmimi.Location = New System.Drawing.Point(508, 69)
        Me.txtCmimi.Name = "txtCmimi"
        Me.txtCmimi.Size = New System.Drawing.Size(90, 20)
        Me.txtCmimi.TabIndex = 7
        '
        'txtTVSH
        '
        Me.txtTVSH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTVSH.Location = New System.Drawing.Point(508, 95)
        Me.txtTVSH.Name = "txtTVSH"
        Me.txtTVSH.Size = New System.Drawing.Size(90, 20)
        Me.txtTVSH.TabIndex = 8
        '
        'btnRegjistro
        '
        Me.btnRegjistro.Location = New System.Drawing.Point(523, 120)
        Me.btnRegjistro.Name = "btnRegjistro"
        Me.btnRegjistro.Size = New System.Drawing.Size(75, 23)
        Me.btnRegjistro.TabIndex = 9
        Me.btnRegjistro.Text = "Regjistro"
        Me.btnRegjistro.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(462, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cmimi :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(460, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "TVSH :"
        '
        'dtgProduktet
        '
        Me.dtgProduktet.AllowUserToAddRows = False
        Me.dtgProduktet.AllowUserToDeleteRows = False
        Me.dtgProduktet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgProduktet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgProduktet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProduktet.Location = New System.Drawing.Point(12, 153)
        Me.dtgProduktet.Name = "dtgProduktet"
        Me.dtgProduktet.Size = New System.Drawing.Size(605, 260)
        Me.dtgProduktet.TabIndex = 35
        '
        'frmRegisterProduct
        '
        Me.AcceptButton = Me.btnRegjistro
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(629, 425)
        Me.Controls.Add(Me.dtgProduktet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRegjistro)
        Me.Controls.Add(Me.txtTVSH)
        Me.Controls.Add(Me.txtCmimi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtEmri)
        Me.Controls.Add(Me.cmbKategoria)
        Me.Controls.Add(Me.cmbGrupi)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegisterProduct"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgProduktet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbGrupi As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKategoria As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmri As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb2PSh As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSh As System.Windows.Forms.RadioButton
    Friend WithEvents rdbP As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCmimi As System.Windows.Forms.TextBox
    Friend WithEvents txtTVSH As System.Windows.Forms.TextBox
    Friend WithEvents btnRegjistro As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtgProduktet As System.Windows.Forms.DataGridView
End Class
