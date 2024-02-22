<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TPV
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
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim Apellido_1Label1 As System.Windows.Forms.Label
        Dim Apellido_2Label1 As System.Windows.Forms.Label
        Dim TelefonoLabel1 As System.Windows.Forms.Label
        Dim CorreoLabel1 As System.Windows.Forms.Label
        Dim FechaAltaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TPV))
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
        Me.lbPreciosTienda = New System.Windows.Forms.ListBox()
        Me.lbProductosTienda = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelCosasCliente = New System.Windows.Forms.Panel()
        Me.btnAccionBuscarCliente = New System.Windows.Forms.Button()
        Me.tbIdCliente = New System.Windows.Forms.TextBox()
        Me.tbNombreCliente = New System.Windows.Forms.TextBox()
        Me.tbApellido1Cliente = New System.Windows.Forms.TextBox()
        Me.tbApellido2Cliente = New System.Windows.Forms.TextBox()
        Me.tbTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.tbCorreoCliente = New System.Windows.Forms.TextBox()
        Me.FechaAltaClienteTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PanelIsCliente = New System.Windows.Forms.Panel()
        Me.btnCrearCliente = New System.Windows.Forms.Button()
        Me.btnEsCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabelRepsol = New System.Windows.Forms.LinkLabel()
        Me.LinkLblCondiciones = New System.Windows.Forms.LinkLabel()
        IdLabel1 = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        Apellido_1Label1 = New System.Windows.Forms.Label()
        Apellido_2Label1 = New System.Windows.Forms.Label()
        TelefonoLabel1 = New System.Windows.Forms.Label()
        CorreoLabel1 = New System.Windows.Forms.Label()
        FechaAltaLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCosasCliente.SuspendLayout()
        Me.PanelIsCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Location = New System.Drawing.Point(5, 34)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(19, 13)
        IdLabel1.TabIndex = 0
        IdLabel1.Text = "Id:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(5, 60)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(47, 13)
        NombreLabel1.TabIndex = 2
        NombreLabel1.Text = "Nombre:"
        '
        'Apellido_1Label1
        '
        Apellido_1Label1.AutoSize = True
        Apellido_1Label1.Location = New System.Drawing.Point(5, 86)
        Apellido_1Label1.Name = "Apellido_1Label1"
        Apellido_1Label1.Size = New System.Drawing.Size(56, 13)
        Apellido_1Label1.TabIndex = 4
        Apellido_1Label1.Text = "Apellido 1:"
        '
        'Apellido_2Label1
        '
        Apellido_2Label1.AutoSize = True
        Apellido_2Label1.Location = New System.Drawing.Point(5, 112)
        Apellido_2Label1.Name = "Apellido_2Label1"
        Apellido_2Label1.Size = New System.Drawing.Size(56, 13)
        Apellido_2Label1.TabIndex = 6
        Apellido_2Label1.Text = "Apellido 2:"
        '
        'TelefonoLabel1
        '
        TelefonoLabel1.AutoSize = True
        TelefonoLabel1.Location = New System.Drawing.Point(5, 138)
        TelefonoLabel1.Name = "TelefonoLabel1"
        TelefonoLabel1.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel1.TabIndex = 8
        TelefonoLabel1.Text = "Telefono:"
        '
        'CorreoLabel1
        '
        CorreoLabel1.AutoSize = True
        CorreoLabel1.Location = New System.Drawing.Point(5, 164)
        CorreoLabel1.Name = "CorreoLabel1"
        CorreoLabel1.Size = New System.Drawing.Size(41, 13)
        CorreoLabel1.TabIndex = 10
        CorreoLabel1.Text = "Correo:"
        '
        'FechaAltaLabel
        '
        FechaAltaLabel.AutoSize = True
        FechaAltaLabel.Location = New System.Drawing.Point(5, 191)
        FechaAltaLabel.Name = "FechaAltaLabel"
        FechaAltaLabel.Size = New System.Drawing.Size(61, 13)
        FechaAltaLabel.TabIndex = 12
        FechaAltaLabel.Text = "Fecha Alta:"
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
        'lbPreciosTienda
        '
        Me.lbPreciosTienda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbPreciosTienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPreciosTienda.FormatString = "C2"
        Me.lbPreciosTienda.FormattingEnabled = True
        Me.lbPreciosTienda.ItemHeight = 18
        Me.lbPreciosTienda.Location = New System.Drawing.Point(934, 166)
        Me.lbPreciosTienda.Name = "lbPreciosTienda"
        Me.lbPreciosTienda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbPreciosTienda.Size = New System.Drawing.Size(75, 468)
        Me.lbPreciosTienda.TabIndex = 63
        '
        'lbProductosTienda
        '
        Me.lbProductosTienda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbProductosTienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProductosTienda.FormattingEnabled = True
        Me.lbProductosTienda.ItemHeight = 18
        Me.lbProductosTienda.Location = New System.Drawing.Point(701, 166)
        Me.lbProductosTienda.Name = "lbProductosTienda"
        Me.lbProductosTienda.Size = New System.Drawing.Size(237, 468)
        Me.lbProductosTienda.TabIndex = 62
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
        Me.VolverToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.VolverToolStripMenuItem1.Text = "Volver"
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
        'panelCosasCliente
        '
        Me.panelCosasCliente.Controls.Add(Me.btnAccionBuscarCliente)
        Me.panelCosasCliente.Controls.Add(IdLabel1)
        Me.panelCosasCliente.Controls.Add(Me.tbIdCliente)
        Me.panelCosasCliente.Controls.Add(NombreLabel1)
        Me.panelCosasCliente.Controls.Add(Me.tbNombreCliente)
        Me.panelCosasCliente.Controls.Add(Apellido_1Label1)
        Me.panelCosasCliente.Controls.Add(Me.tbApellido1Cliente)
        Me.panelCosasCliente.Controls.Add(Apellido_2Label1)
        Me.panelCosasCliente.Controls.Add(Me.tbApellido2Cliente)
        Me.panelCosasCliente.Controls.Add(TelefonoLabel1)
        Me.panelCosasCliente.Controls.Add(Me.tbTelefonoCliente)
        Me.panelCosasCliente.Controls.Add(CorreoLabel1)
        Me.panelCosasCliente.Controls.Add(Me.tbCorreoCliente)
        Me.panelCosasCliente.Controls.Add(FechaAltaLabel)
        Me.panelCosasCliente.Controls.Add(Me.FechaAltaClienteTimePicker)
        Me.panelCosasCliente.Location = New System.Drawing.Point(1317, 358)
        Me.panelCosasCliente.Name = "panelCosasCliente"
        Me.panelCosasCliente.Size = New System.Drawing.Size(292, 301)
        Me.panelCosasCliente.TabIndex = 65
        '
        'btnAccionBuscarCliente
        '
        Me.btnAccionBuscarCliente.Location = New System.Drawing.Point(97, 251)
        Me.btnAccionBuscarCliente.Name = "btnAccionBuscarCliente"
        Me.btnAccionBuscarCliente.Size = New System.Drawing.Size(100, 23)
        Me.btnAccionBuscarCliente.TabIndex = 19
        Me.btnAccionBuscarCliente.Text = "Buscar"
        Me.btnAccionBuscarCliente.UseVisualStyleBackColor = True
        '
        'tbIdCliente
        '
        Me.tbIdCliente.Location = New System.Drawing.Point(72, 31)
        Me.tbIdCliente.MaxLength = 6
        Me.tbIdCliente.Name = "tbIdCliente"
        Me.tbIdCliente.Size = New System.Drawing.Size(200, 20)
        Me.tbIdCliente.TabIndex = 1
        '
        'tbNombreCliente
        '
        Me.tbNombreCliente.Location = New System.Drawing.Point(72, 57)
        Me.tbNombreCliente.MaxLength = 10
        Me.tbNombreCliente.Name = "tbNombreCliente"
        Me.tbNombreCliente.Size = New System.Drawing.Size(200, 20)
        Me.tbNombreCliente.TabIndex = 3
        '
        'tbApellido1Cliente
        '
        Me.tbApellido1Cliente.Location = New System.Drawing.Point(72, 83)
        Me.tbApellido1Cliente.MaxLength = 10
        Me.tbApellido1Cliente.Name = "tbApellido1Cliente"
        Me.tbApellido1Cliente.Size = New System.Drawing.Size(200, 20)
        Me.tbApellido1Cliente.TabIndex = 5
        '
        'tbApellido2Cliente
        '
        Me.tbApellido2Cliente.Location = New System.Drawing.Point(72, 109)
        Me.tbApellido2Cliente.MaxLength = 10
        Me.tbApellido2Cliente.Name = "tbApellido2Cliente"
        Me.tbApellido2Cliente.Size = New System.Drawing.Size(200, 20)
        Me.tbApellido2Cliente.TabIndex = 7
        '
        'tbTelefonoCliente
        '
        Me.tbTelefonoCliente.Location = New System.Drawing.Point(72, 135)
        Me.tbTelefonoCliente.MaxLength = 12
        Me.tbTelefonoCliente.Name = "tbTelefonoCliente"
        Me.tbTelefonoCliente.Size = New System.Drawing.Size(200, 20)
        Me.tbTelefonoCliente.TabIndex = 9
        '
        'tbCorreoCliente
        '
        Me.tbCorreoCliente.Location = New System.Drawing.Point(72, 161)
        Me.tbCorreoCliente.MaxLength = 30
        Me.tbCorreoCliente.Name = "tbCorreoCliente"
        Me.tbCorreoCliente.Size = New System.Drawing.Size(200, 20)
        Me.tbCorreoCliente.TabIndex = 11
        '
        'FechaAltaClienteTimePicker
        '
        Me.FechaAltaClienteTimePicker.Enabled = False
        Me.FechaAltaClienteTimePicker.Location = New System.Drawing.Point(72, 187)
        Me.FechaAltaClienteTimePicker.Name = "FechaAltaClienteTimePicker"
        Me.FechaAltaClienteTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaAltaClienteTimePicker.TabIndex = 13
        '
        'PanelIsCliente
        '
        Me.PanelIsCliente.Controls.Add(Me.btnCrearCliente)
        Me.PanelIsCliente.Controls.Add(Me.btnEsCliente)
        Me.PanelIsCliente.Controls.Add(Me.Label1)
        Me.PanelIsCliente.Location = New System.Drawing.Point(1335, 137)
        Me.PanelIsCliente.Name = "PanelIsCliente"
        Me.PanelIsCliente.Size = New System.Drawing.Size(250, 138)
        Me.PanelIsCliente.TabIndex = 66
        '
        'btnCrearCliente
        '
        Me.btnCrearCliente.Location = New System.Drawing.Point(120, 62)
        Me.btnCrearCliente.Name = "btnCrearCliente"
        Me.btnCrearCliente.Size = New System.Drawing.Size(110, 46)
        Me.btnCrearCliente.TabIndex = 2
        Me.btnCrearCliente.Text = "No, deseo crearla."
        Me.btnCrearCliente.UseVisualStyleBackColor = True
        '
        'btnEsCliente
        '
        Me.btnEsCliente.Location = New System.Drawing.Point(22, 62)
        Me.btnEsCliente.Name = "btnEsCliente"
        Me.btnEsCliente.Size = New System.Drawing.Size(75, 46)
        Me.btnEsCliente.TabIndex = 1
        Me.btnEsCliente.Text = "Sí"
        Me.btnEsCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Tiene Tarjeta Repsol?"
        '
        'LinkLabelRepsol
        '
        Me.LinkLabelRepsol.AutoSize = True
        Me.LinkLabelRepsol.Location = New System.Drawing.Point(1623, 148)
        Me.LinkLabelRepsol.Name = "LinkLabelRepsol"
        Me.LinkLabelRepsol.Size = New System.Drawing.Size(40, 13)
        Me.LinkLabelRepsol.TabIndex = 67
        Me.LinkLabelRepsol.TabStop = True
        Me.LinkLabelRepsol.Text = "Repsol"
        '
        'LinkLblCondiciones
        '
        Me.LinkLblCondiciones.AutoSize = True
        Me.LinkLblCondiciones.Location = New System.Drawing.Point(1623, 185)
        Me.LinkLblCondiciones.Name = "LinkLblCondiciones"
        Me.LinkLblCondiciones.Size = New System.Drawing.Size(118, 13)
        Me.LinkLblCondiciones.TabIndex = 68
        Me.LinkLblCondiciones.TabStop = True
        Me.LinkLblCondiciones.Text = "Términos y condiciones"
        '
        'TPV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.LinkLblCondiciones)
        Me.Controls.Add(Me.LinkLabelRepsol)
        Me.Controls.Add(Me.PanelIsCliente)
        Me.Controls.Add(Me.panelCosasCliente)
        Me.Controls.Add(Me.lbPreciosTienda)
        Me.Controls.Add(Me.lbProductosTienda)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TPV"
        Me.Text = "TPV"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCosasCliente.ResumeLayout(False)
        Me.panelCosasCliente.PerformLayout()
        Me.PanelIsCliente.ResumeLayout(False)
        Me.PanelIsCliente.PerformLayout()
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
    Friend WithEvents lbPreciosTienda As ListBox
    Friend WithEvents lbProductosTienda As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelCosasCliente As Panel
    Friend WithEvents btnAccionBuscarCliente As Button
    Friend WithEvents tbIdCliente As TextBox
    Friend WithEvents tbNombreCliente As TextBox
    Friend WithEvents tbApellido1Cliente As TextBox
    Friend WithEvents tbApellido2Cliente As TextBox
    Friend WithEvents tbTelefonoCliente As TextBox
    Friend WithEvents tbCorreoCliente As TextBox
    Friend WithEvents FechaAltaClienteTimePicker As DateTimePicker
    Friend WithEvents PanelIsCliente As Panel
    Friend WithEvents btnCrearCliente As Button
    Friend WithEvents btnEsCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabelRepsol As LinkLabel
    Friend WithEvents LinkLblCondiciones As LinkLabel
End Class
