<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TPV
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lbNombreCategorias = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblTexto2 = New System.Windows.Forms.Label()
        Me.lblTexto1 = New System.Windows.Forms.Label()
        Me.lbPrecios = New System.Windows.Forms.ListBox()
        Me.lbNombreProductos = New System.Windows.Forms.ListBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnTarjeta = New System.Windows.Forms.Button()
        Me.btnEfectivo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(178, 59)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(171, 25)
        Me.lblUser.TabIndex = 5
        Me.lblUser.Text = "nombreUsuario"
        '
        'lbNombreCategorias
        '
        Me.lbNombreCategorias.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lbNombreCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbNombreCategorias.ColumnWidth = 130
        Me.lbNombreCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreCategorias.FormattingEnabled = True
        Me.lbNombreCategorias.ItemHeight = 25
        Me.lbNombreCategorias.Items.AddRange(New Object() {"Consumibles", "Bebidas", "Otros"})
        Me.lbNombreCategorias.Location = New System.Drawing.Point(661, 83)
        Me.lbNombreCategorias.MultiColumn = True
        Me.lbNombreCategorias.Name = "lbNombreCategorias"
        Me.lbNombreCategorias.Size = New System.Drawing.Size(391, 25)
        Me.lbNombreCategorias.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 653)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "€"
        '
        'lblResultado
        '
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(279, 653)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblResultado.Size = New System.Drawing.Size(67, 20)
        Me.lblResultado.TabIndex = 56
        Me.lblResultado.Text = "0,00"
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTexto2
        '
        Me.lblTexto2.AutoSize = True
        Me.lblTexto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto2.Location = New System.Drawing.Point(219, 653)
        Me.lblTexto2.Name = "lblTexto2"
        Me.lblTexto2.Size = New System.Drawing.Size(54, 20)
        Me.lblTexto2.TabIndex = 55
        Me.lblTexto2.Text = "Total:"
        '
        'lblTexto1
        '
        Me.lblTexto1.AutoSize = True
        Me.lblTexto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto1.Location = New System.Drawing.Point(42, 128)
        Me.lblTexto1.Name = "lblTexto1"
        Me.lblTexto1.Size = New System.Drawing.Size(82, 24)
        Me.lblTexto1.TabIndex = 54
        Me.lblTexto1.Text = "Pedido:"
        '
        'lbPrecios
        '
        Me.lbPrecios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrecios.FormatString = "C2"
        Me.lbPrecios.FormattingEnabled = True
        Me.lbPrecios.ItemHeight = 18
        Me.lbPrecios.Location = New System.Drawing.Point(279, 166)
        Me.lbPrecios.Name = "lbPrecios"
        Me.lbPrecios.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbPrecios.Size = New System.Drawing.Size(75, 468)
        Me.lbPrecios.TabIndex = 53
        '
        'lbNombreProductos
        '
        Me.lbNombreProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbNombreProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreProductos.FormattingEnabled = True
        Me.lbNombreProductos.ItemHeight = 18
        Me.lbNombreProductos.Location = New System.Drawing.Point(46, 166)
        Me.lbNombreProductos.Name = "lbNombreProductos"
        Me.lbNombreProductos.Size = New System.Drawing.Size(237, 468)
        Me.lbNombreProductos.TabIndex = 52
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(212, 727)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(160, 105)
        Me.btnLimpiar.TabIndex = 61
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnTarjeta
        '
        Me.btnTarjeta.Location = New System.Drawing.Point(212, 869)
        Me.btnTarjeta.Name = "btnTarjeta"
        Me.btnTarjeta.Size = New System.Drawing.Size(160, 105)
        Me.btnTarjeta.TabIndex = 60
        Me.btnTarjeta.Text = "Tarjeta"
        Me.btnTarjeta.UseVisualStyleBackColor = True
        '
        'btnEfectivo
        '
        Me.btnEfectivo.Location = New System.Drawing.Point(46, 869)
        Me.btnEfectivo.Name = "btnEfectivo"
        Me.btnEfectivo.Size = New System.Drawing.Size(160, 105)
        Me.btnEfectivo.TabIndex = 59
        Me.btnEfectivo.Text = "Efectivo"
        Me.btnEfectivo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(46, 727)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(160, 105)
        Me.btnEliminar.TabIndex = 58
        Me.btnEliminar.Text = "Eliminar producto"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormatString = "C2"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(934, 166)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.Size = New System.Drawing.Size(75, 468)
        Me.ListBox1.TabIndex = 63
        '
        'ListBox2
        '
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 18
        Me.ListBox2.Location = New System.Drawing.Point(701, 166)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(237, 468)
        Me.ListBox2.TabIndex = 62
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1904, 24)
        Me.MenuStrip1.TabIndex = 64
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem1, Me.CerrarSesiónToolStripMenuItem, Me.CerrarAplicaciónToolStripMenuItem})
        Me.VolverToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.VolverToolStripMenuItem.Text = "Opciones"
        '
        'VolverToolStripMenuItem1
        '
        Me.VolverToolStripMenuItem1.Name = "VolverToolStripMenuItem1"
        Me.VolverToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.VolverToolStripMenuItem1.Text = "Volver"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'CerrarAplicaciónToolStripMenuItem
        '
        Me.CerrarAplicaciónToolStripMenuItem.Name = "CerrarAplicaciónToolStripMenuItem"
        Me.CerrarAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarAplicaciónToolStripMenuItem.Text = "Cerrar el programa"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Repsol_2.My.Resources.Resources.Repsol_logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'TPV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnTarjeta)
        Me.Controls.Add(Me.btnEfectivo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblTexto2)
        Me.Controls.Add(Me.lblTexto1)
        Me.Controls.Add(Me.lbPrecios)
        Me.Controls.Add(Me.lbNombreProductos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbNombreCategorias)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TPV"
        Me.Text = "TPV"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents lbNombreCategorias As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents lblTexto2 As Label
    Friend WithEvents lblTexto1 As Label
    Friend WithEvents lbPrecios As ListBox
    Friend WithEvents lbNombreProductos As ListBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnTarjeta As Button
    Friend WithEvents btnEfectivo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarAplicaciónToolStripMenuItem As ToolStripMenuItem
End Class
