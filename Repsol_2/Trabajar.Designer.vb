<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Trabajar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trabajar))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbManguera1 = New System.Windows.Forms.PictureBox()
        Me.pbManguera2 = New System.Windows.Forms.PictureBox()
        Me.pbManguera3 = New System.Windows.Forms.PictureBox()
        Me.pbManguera4 = New System.Windows.Forms.PictureBox()
        Me.btnTienda = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbManguera1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbManguera2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbManguera3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbManguera4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1904, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem, Me.ToolStripSeparator1, Me.CerrarSesiónToolStripMenuItem, Me.CerrarAplicaciónToolStripMenuItem})
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.SalirToolStripMenuItem.Text = "Volver"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'CerrarAplicaciónToolStripMenuItem
        '
        Me.CerrarAplicaciónToolStripMenuItem.Name = "CerrarAplicaciónToolStripMenuItem"
        Me.CerrarAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CerrarAplicaciónToolStripMenuItem.Text = "Cerrar el programa"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(178, 50)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(171, 25)
        Me.lblUser.TabIndex = 10
        Me.lblUser.Text = "nombreUsuario"
        '
        'PictureBox2
        '
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.Repsol_2.My.Resources.Resources.Mapa
        Me.PictureBox2.Location = New System.Drawing.Point(62, 113)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(900, 900)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Repsol_2.My.Resources.Resources.Repsol_logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'pbManguera1
        '
        Me.pbManguera1.BackColor = System.Drawing.SystemColors.Control
        Me.pbManguera1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbManguera1.Location = New System.Drawing.Point(263, 522)
        Me.pbManguera1.Name = "pbManguera1"
        Me.pbManguera1.Size = New System.Drawing.Size(138, 261)
        Me.pbManguera1.TabIndex = 13
        Me.pbManguera1.TabStop = False
        '
        'pbManguera2
        '
        Me.pbManguera2.BackColor = System.Drawing.SystemColors.Control
        Me.pbManguera2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbManguera2.Location = New System.Drawing.Point(407, 509)
        Me.pbManguera2.Name = "pbManguera2"
        Me.pbManguera2.Size = New System.Drawing.Size(111, 189)
        Me.pbManguera2.TabIndex = 14
        Me.pbManguera2.TabStop = False
        '
        'pbManguera3
        '
        Me.pbManguera3.BackColor = System.Drawing.SystemColors.Control
        Me.pbManguera3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbManguera3.Location = New System.Drawing.Point(592, 583)
        Me.pbManguera3.Name = "pbManguera3"
        Me.pbManguera3.Size = New System.Drawing.Size(157, 287)
        Me.pbManguera3.TabIndex = 15
        Me.pbManguera3.TabStop = False
        '
        'pbManguera4
        '
        Me.pbManguera4.BackColor = System.Drawing.SystemColors.Control
        Me.pbManguera4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbManguera4.Location = New System.Drawing.Point(771, 556)
        Me.pbManguera4.Name = "pbManguera4"
        Me.pbManguera4.Size = New System.Drawing.Size(130, 259)
        Me.pbManguera4.TabIndex = 16
        Me.pbManguera4.TabStop = False
        '
        'btnTienda
        '
        Me.btnTienda.Location = New System.Drawing.Point(1130, 383)
        Me.btnTienda.Name = "btnTienda"
        Me.btnTienda.Size = New System.Drawing.Size(340, 246)
        Me.btnTienda.TabIndex = 17
        Me.btnTienda.Text = "Compras en tienda"
        Me.btnTienda.UseVisualStyleBackColor = True
        '
        'Trabajar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.btnTienda)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pbManguera1)
        Me.Controls.Add(Me.pbManguera2)
        Me.Controls.Add(Me.pbManguera3)
        Me.Controls.Add(Me.pbManguera4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Trabajar"
        Me.Text = "Trabajar"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbManguera1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbManguera2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbManguera3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbManguera4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbManguera1 As PictureBox
    Friend WithEvents pbManguera2 As PictureBox
    Friend WithEvents pbManguera3 As PictureBox
    Friend WithEvents pbManguera4 As PictureBox
    Friend WithEvents btnTienda As Button
End Class
