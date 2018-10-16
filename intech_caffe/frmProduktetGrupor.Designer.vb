<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduktetGrupor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduktetGrupor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEProdukti = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbEmriZgjedhes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listProduktet = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtgProduktet = New System.Windows.Forms.DataGridView()
        Me.txtSasia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFshij = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgProduktet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblEProdukti)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 50)
        Me.Panel1.TabIndex = 3
        '
        'lblEProdukti
        '
        Me.lblEProdukti.AutoSize = True
        Me.lblEProdukti.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEProdukti.Location = New System.Drawing.Point(268, 32)
        Me.lblEProdukti.Name = "lblEProdukti"
        Me.lblEProdukti.Size = New System.Drawing.Size(0, 18)
        Me.lblEProdukti.TabIndex = 1
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
        'cmbEmriZgjedhes
        '
        Me.cmbEmriZgjedhes.FormattingEnabled = True
        Me.cmbEmriZgjedhes.Location = New System.Drawing.Point(12, 83)
        Me.cmbEmriZgjedhes.Name = "cmbEmriZgjedhes"
        Me.cmbEmriZgjedhes.Size = New System.Drawing.Size(221, 21)
        Me.cmbEmriZgjedhes.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(22, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Zgjidhe produktin shites"
        '
        'listProduktet
        '
        Me.listProduktet.FormattingEnabled = True
        Me.listProduktet.Location = New System.Drawing.Point(12, 137)
        Me.listProduktet.Name = "listProduktet"
        Me.listProduktet.Size = New System.Drawing.Size(221, 199)
        Me.listProduktet.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(22, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Zgjidh produktin perberes"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Regjistroe"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtgProduktet
        '
        Me.dtgProduktet.AllowUserToAddRows = False
        Me.dtgProduktet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgProduktet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgProduktet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProduktet.Location = New System.Drawing.Point(239, 67)
        Me.dtgProduktet.Name = "dtgProduktet"
        Me.dtgProduktet.ReadOnly = True
        Me.dtgProduktet.Size = New System.Drawing.Size(677, 324)
        Me.dtgProduktet.TabIndex = 9
        '
        'txtSasia
        '
        Me.txtSasia.Location = New System.Drawing.Point(67, 342)
        Me.txtSasia.Name = "txtSasia"
        Me.txtSasia.Size = New System.Drawing.Size(166, 20)
        Me.txtSasia.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(22, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Sasia :"
        '
        'btnFshij
        '
        Me.btnFshij.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFshij.Location = New System.Drawing.Point(841, 397)
        Me.btnFshij.Name = "btnFshij"
        Me.btnFshij.Size = New System.Drawing.Size(75, 23)
        Me.btnFshij.TabIndex = 12
        Me.btnFshij.Text = "Fshij"
        Me.btnFshij.UseVisualStyleBackColor = True
        '
        'frmProduktetGrupor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(928, 431)
        Me.Controls.Add(Me.btnFshij)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSasia)
        Me.Controls.Add(Me.dtgProduktet)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.listProduktet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbEmriZgjedhes)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProduktetGrupor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgProduktet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbEmriZgjedhes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listProduktet As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtgProduktet As System.Windows.Forms.DataGridView
    Friend WithEvents lblEProdukti As System.Windows.Forms.Label
    Friend WithEvents txtSasia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnFshij As System.Windows.Forms.Button
End Class
