<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionesDelAdministrador
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Apellido_1Label As System.Windows.Forms.Label
        Dim Apellido_2Label As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim AdministradorLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim Apellido_1Label1 As System.Windows.Forms.Label
        Dim Apellido_2Label1 As System.Windows.Forms.Label
        Dim TelefonoLabel1 As System.Windows.Forms.Label
        Dim CorreoLabel1 As System.Windows.Forms.Label
        Dim FechaAltaLabel As System.Windows.Forms.Label
        Dim AltaLabel As System.Windows.Forms.Label
        Dim IdLabel2 As System.Windows.Forms.Label
        Dim NombreLabel2 As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim ProveedorLabel As System.Windows.Forms.Label
        Dim GamaLabel As System.Windows.Forms.Label
        Dim IdLabel3 As System.Windows.Forms.Label
        Dim NombreLabel3 As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PrecioLabel1 As System.Windows.Forms.Label
        Dim IdLabel4 As System.Windows.Forms.Label
        Dim NombreLabel4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionesDelAdministrador))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnGestionesEmpleado = New System.Windows.Forms.Button()
        Me.btnGestionesClientes = New System.Windows.Forms.Button()
        Me.btnGestionesProductos = New System.Windows.Forms.Button()
        Me.btnGestionesGasolinas = New System.Windows.Forms.Button()
        Me.btnGestionesProveedores = New System.Windows.Forms.Button()
        Me.panelEmpleado = New System.Windows.Forms.Panel()
        Me.btnEliminarEmpleado = New System.Windows.Forms.Button()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.btnModificarEmpleado = New System.Windows.Forms.Button()
        Me.DatagridEmpleado = New System.Windows.Forms.DataGridView()
        Me.btnDesaparecidoEnCombate = New System.Windows.Forms.Button()
        Me.btnBuscarEmpleado = New System.Windows.Forms.Button()
        Me.tbIdEmpleado = New System.Windows.Forms.TextBox()
        Me.tbNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.tbApellido1Empleado = New System.Windows.Forms.TextBox()
        Me.tbApellido2Empleado = New System.Windows.Forms.TextBox()
        Me.tbTelefonoEmpleado = New System.Windows.Forms.TextBox()
        Me.tbCorreoEmpleado = New System.Windows.Forms.TextBox()
        Me.tbContraseñaEmpleado = New System.Windows.Forms.TextBox()
        Me.tbAdministradorEmpleado = New System.Windows.Forms.TextBox()
        Me.tbCargoEmpleado = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelCliente = New System.Windows.Forms.Panel()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.ClientesDatagrid = New System.Windows.Forms.DataGridView()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.tbIdCliente = New System.Windows.Forms.TextBox()
        Me.tbNombreCliente = New System.Windows.Forms.TextBox()
        Me.tbApellido1Cliente = New System.Windows.Forms.TextBox()
        Me.tbApellido2Cliente = New System.Windows.Forms.TextBox()
        Me.tbTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.tbCorreoCliente = New System.Windows.Forms.TextBox()
        Me.FechaAltaClienteTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.tbAltaCliente = New System.Windows.Forms.TextBox()
        Me.panelProductos = New System.Windows.Forms.Panel()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.ProductosDatagrid = New System.Windows.Forms.DataGridView()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.tbIdProducto = New System.Windows.Forms.TextBox()
        Me.tbNombreProducto = New System.Windows.Forms.TextBox()
        Me.tbPrecioProducto = New System.Windows.Forms.TextBox()
        Me.tbProveedorProducto = New System.Windows.Forms.TextBox()
        Me.tbGamaProducto = New System.Windows.Forms.TextBox()
        Me.panelGasolina = New System.Windows.Forms.Panel()
        Me.btnModificarGasolina = New System.Windows.Forms.Button()
        Me.GasolinasDatagrid = New System.Windows.Forms.DataGridView()
        Me.btnBuscarGasolina = New System.Windows.Forms.Button()
        Me.tbIdGasolina = New System.Windows.Forms.TextBox()
        Me.tbNombreGasolina = New System.Windows.Forms.TextBox()
        Me.tbCantidadGasolina = New System.Windows.Forms.TextBox()
        Me.tbPrecioGasolina = New System.Windows.Forms.TextBox()
        Me.panelProveedor = New System.Windows.Forms.Panel()
        Me.btnEliminarProveedor = New System.Windows.Forms.Button()
        Me.btnModificarProveedor = New System.Windows.Forms.Button()
        Me.btnAgregarProveedor = New System.Windows.Forms.Button()
        Me.ProveedorDataGrid = New System.Windows.Forms.DataGridView()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.tbIdProveedor = New System.Windows.Forms.TextBox()
        Me.tbNombreProveedor = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Apellido_1Label = New System.Windows.Forms.Label()
        Apellido_2Label = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        AdministradorLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        IdLabel1 = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        Apellido_1Label1 = New System.Windows.Forms.Label()
        Apellido_2Label1 = New System.Windows.Forms.Label()
        TelefonoLabel1 = New System.Windows.Forms.Label()
        CorreoLabel1 = New System.Windows.Forms.Label()
        FechaAltaLabel = New System.Windows.Forms.Label()
        AltaLabel = New System.Windows.Forms.Label()
        IdLabel2 = New System.Windows.Forms.Label()
        NombreLabel2 = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        ProveedorLabel = New System.Windows.Forms.Label()
        GamaLabel = New System.Windows.Forms.Label()
        IdLabel3 = New System.Windows.Forms.Label()
        NombreLabel3 = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PrecioLabel1 = New System.Windows.Forms.Label()
        IdLabel4 = New System.Windows.Forms.Label()
        NombreLabel4 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.panelEmpleado.SuspendLayout()
        CType(Me.DatagridEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCliente.SuspendLayout()
        CType(Me.ClientesDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelProductos.SuspendLayout()
        CType(Me.ProductosDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelGasolina.SuspendLayout()
        CType(Me.GasolinasDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelProveedor.SuspendLayout()
        CType(Me.ProveedorDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(12, 31)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(12, 57)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'Apellido_1Label
        '
        Apellido_1Label.AutoSize = True
        Apellido_1Label.Location = New System.Drawing.Point(12, 83)
        Apellido_1Label.Name = "Apellido_1Label"
        Apellido_1Label.Size = New System.Drawing.Size(56, 13)
        Apellido_1Label.TabIndex = 4
        Apellido_1Label.Text = "Apellido 1:"
        '
        'Apellido_2Label
        '
        Apellido_2Label.AutoSize = True
        Apellido_2Label.Location = New System.Drawing.Point(12, 109)
        Apellido_2Label.Name = "Apellido_2Label"
        Apellido_2Label.Size = New System.Drawing.Size(56, 13)
        Apellido_2Label.TabIndex = 6
        Apellido_2Label.Text = "Apellido 2:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(12, 135)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 8
        TelefonoLabel.Text = "Telefono:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(12, 161)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(41, 13)
        CorreoLabel.TabIndex = 10
        CorreoLabel.Text = "Correo:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(12, 187)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(64, 13)
        ContraseñaLabel.TabIndex = 12
        ContraseñaLabel.Text = "Contraseña:"
        '
        'AdministradorLabel
        '
        AdministradorLabel.AutoSize = True
        AdministradorLabel.Location = New System.Drawing.Point(12, 213)
        AdministradorLabel.Name = "AdministradorLabel"
        AdministradorLabel.Size = New System.Drawing.Size(73, 13)
        AdministradorLabel.TabIndex = 14
        AdministradorLabel.Text = "Administrador:"
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Location = New System.Drawing.Point(12, 239)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(38, 13)
        CargoLabel.TabIndex = 16
        CargoLabel.Text = "Cargo:"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Location = New System.Drawing.Point(5, 15)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(19, 13)
        IdLabel1.TabIndex = 0
        IdLabel1.Text = "Id:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(5, 41)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(47, 13)
        NombreLabel1.TabIndex = 2
        NombreLabel1.Text = "Nombre:"
        '
        'Apellido_1Label1
        '
        Apellido_1Label1.AutoSize = True
        Apellido_1Label1.Location = New System.Drawing.Point(5, 67)
        Apellido_1Label1.Name = "Apellido_1Label1"
        Apellido_1Label1.Size = New System.Drawing.Size(56, 13)
        Apellido_1Label1.TabIndex = 4
        Apellido_1Label1.Text = "Apellido 1:"
        '
        'Apellido_2Label1
        '
        Apellido_2Label1.AutoSize = True
        Apellido_2Label1.Location = New System.Drawing.Point(5, 93)
        Apellido_2Label1.Name = "Apellido_2Label1"
        Apellido_2Label1.Size = New System.Drawing.Size(56, 13)
        Apellido_2Label1.TabIndex = 6
        Apellido_2Label1.Text = "Apellido 2:"
        '
        'TelefonoLabel1
        '
        TelefonoLabel1.AutoSize = True
        TelefonoLabel1.Location = New System.Drawing.Point(5, 119)
        TelefonoLabel1.Name = "TelefonoLabel1"
        TelefonoLabel1.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel1.TabIndex = 8
        TelefonoLabel1.Text = "Telefono:"
        '
        'CorreoLabel1
        '
        CorreoLabel1.AutoSize = True
        CorreoLabel1.Location = New System.Drawing.Point(5, 145)
        CorreoLabel1.Name = "CorreoLabel1"
        CorreoLabel1.Size = New System.Drawing.Size(41, 13)
        CorreoLabel1.TabIndex = 10
        CorreoLabel1.Text = "Correo:"
        '
        'FechaAltaLabel
        '
        FechaAltaLabel.AutoSize = True
        FechaAltaLabel.Location = New System.Drawing.Point(5, 172)
        FechaAltaLabel.Name = "FechaAltaLabel"
        FechaAltaLabel.Size = New System.Drawing.Size(61, 13)
        FechaAltaLabel.TabIndex = 12
        FechaAltaLabel.Text = "Fecha Alta:"
        '
        'AltaLabel
        '
        AltaLabel.AutoSize = True
        AltaLabel.Location = New System.Drawing.Point(5, 197)
        AltaLabel.Name = "AltaLabel"
        AltaLabel.Size = New System.Drawing.Size(28, 13)
        AltaLabel.TabIndex = 14
        AltaLabel.Text = "Alta:"
        '
        'IdLabel2
        '
        IdLabel2.AutoSize = True
        IdLabel2.Location = New System.Drawing.Point(8, 11)
        IdLabel2.Name = "IdLabel2"
        IdLabel2.Size = New System.Drawing.Size(19, 13)
        IdLabel2.TabIndex = 0
        IdLabel2.Text = "Id:"
        '
        'NombreLabel2
        '
        NombreLabel2.AutoSize = True
        NombreLabel2.Location = New System.Drawing.Point(8, 37)
        NombreLabel2.Name = "NombreLabel2"
        NombreLabel2.Size = New System.Drawing.Size(47, 13)
        NombreLabel2.TabIndex = 2
        NombreLabel2.Text = "Nombre:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(8, 63)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 4
        PrecioLabel.Text = "Precio:"
        '
        'ProveedorLabel
        '
        ProveedorLabel.AutoSize = True
        ProveedorLabel.Location = New System.Drawing.Point(8, 89)
        ProveedorLabel.Name = "ProveedorLabel"
        ProveedorLabel.Size = New System.Drawing.Size(59, 13)
        ProveedorLabel.TabIndex = 6
        ProveedorLabel.Text = "Proveedor:"
        '
        'GamaLabel
        '
        GamaLabel.AutoSize = True
        GamaLabel.Location = New System.Drawing.Point(8, 115)
        GamaLabel.Name = "GamaLabel"
        GamaLabel.Size = New System.Drawing.Size(38, 13)
        GamaLabel.TabIndex = 8
        GamaLabel.Text = "Gama:"
        '
        'IdLabel3
        '
        IdLabel3.AutoSize = True
        IdLabel3.Location = New System.Drawing.Point(3, 20)
        IdLabel3.Name = "IdLabel3"
        IdLabel3.Size = New System.Drawing.Size(19, 13)
        IdLabel3.TabIndex = 0
        IdLabel3.Text = "Id:"
        '
        'NombreLabel3
        '
        NombreLabel3.AutoSize = True
        NombreLabel3.Location = New System.Drawing.Point(3, 46)
        NombreLabel3.Name = "NombreLabel3"
        NombreLabel3.Size = New System.Drawing.Size(47, 13)
        NombreLabel3.TabIndex = 2
        NombreLabel3.Text = "Nombre:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(3, 72)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 4
        CantidadLabel.Text = "Cantidad:"
        '
        'PrecioLabel1
        '
        PrecioLabel1.AutoSize = True
        PrecioLabel1.Location = New System.Drawing.Point(3, 98)
        PrecioLabel1.Name = "PrecioLabel1"
        PrecioLabel1.Size = New System.Drawing.Size(40, 13)
        PrecioLabel1.TabIndex = 6
        PrecioLabel1.Text = "Precio:"
        '
        'IdLabel4
        '
        IdLabel4.AutoSize = True
        IdLabel4.Location = New System.Drawing.Point(2, 32)
        IdLabel4.Name = "IdLabel4"
        IdLabel4.Size = New System.Drawing.Size(19, 13)
        IdLabel4.TabIndex = 0
        IdLabel4.Text = "Id:"
        '
        'NombreLabel4
        '
        NombreLabel4.AutoSize = True
        NombreLabel4.Location = New System.Drawing.Point(2, 58)
        NombreLabel4.Name = "NombreLabel4"
        NombreLabel4.Size = New System.Drawing.Size(47, 13)
        NombreLabel4.TabIndex = 2
        NombreLabel4.Text = "Nombre:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1019)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1904, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionesEmpleado)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionesClientes)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionesProductos)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionesGasolinas)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionesProveedores)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 30)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(152, 158)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnGestionesEmpleado
        '
        Me.btnGestionesEmpleado.Location = New System.Drawing.Point(3, 3)
        Me.btnGestionesEmpleado.Name = "btnGestionesEmpleado"
        Me.btnGestionesEmpleado.Size = New System.Drawing.Size(149, 23)
        Me.btnGestionesEmpleado.TabIndex = 2
        Me.btnGestionesEmpleado.Text = "Gestiones Empleados"
        Me.btnGestionesEmpleado.UseVisualStyleBackColor = True
        '
        'btnGestionesClientes
        '
        Me.btnGestionesClientes.Location = New System.Drawing.Point(3, 32)
        Me.btnGestionesClientes.Name = "btnGestionesClientes"
        Me.btnGestionesClientes.Size = New System.Drawing.Size(149, 23)
        Me.btnGestionesClientes.TabIndex = 3
        Me.btnGestionesClientes.Text = "Gestiones Clientes"
        Me.btnGestionesClientes.UseVisualStyleBackColor = True
        '
        'btnGestionesProductos
        '
        Me.btnGestionesProductos.Location = New System.Drawing.Point(3, 61)
        Me.btnGestionesProductos.Name = "btnGestionesProductos"
        Me.btnGestionesProductos.Size = New System.Drawing.Size(149, 23)
        Me.btnGestionesProductos.TabIndex = 4
        Me.btnGestionesProductos.Text = "Gestiones Productos"
        Me.btnGestionesProductos.UseVisualStyleBackColor = True
        '
        'btnGestionesGasolinas
        '
        Me.btnGestionesGasolinas.Location = New System.Drawing.Point(3, 90)
        Me.btnGestionesGasolinas.Name = "btnGestionesGasolinas"
        Me.btnGestionesGasolinas.Size = New System.Drawing.Size(149, 23)
        Me.btnGestionesGasolinas.TabIndex = 5
        Me.btnGestionesGasolinas.Text = "Gestiones Gasolinas"
        Me.btnGestionesGasolinas.UseVisualStyleBackColor = True
        '
        'btnGestionesProveedores
        '
        Me.btnGestionesProveedores.Location = New System.Drawing.Point(3, 119)
        Me.btnGestionesProveedores.Name = "btnGestionesProveedores"
        Me.btnGestionesProveedores.Size = New System.Drawing.Size(149, 23)
        Me.btnGestionesProveedores.TabIndex = 6
        Me.btnGestionesProveedores.Text = "Gestiones Proveedores"
        Me.btnGestionesProveedores.UseVisualStyleBackColor = True
        '
        'panelEmpleado
        '
        Me.panelEmpleado.Controls.Add(Me.btnEliminarEmpleado)
        Me.panelEmpleado.Controls.Add(Me.btnAgregarEmpleado)
        Me.panelEmpleado.Controls.Add(Me.btnModificarEmpleado)
        Me.panelEmpleado.Controls.Add(Me.DatagridEmpleado)
        Me.panelEmpleado.Controls.Add(Me.btnDesaparecidoEnCombate)
        Me.panelEmpleado.Controls.Add(Me.btnBuscarEmpleado)
        Me.panelEmpleado.Controls.Add(IdLabel)
        Me.panelEmpleado.Controls.Add(Me.tbIdEmpleado)
        Me.panelEmpleado.Controls.Add(NombreLabel)
        Me.panelEmpleado.Controls.Add(Me.tbNombreEmpleado)
        Me.panelEmpleado.Controls.Add(Apellido_1Label)
        Me.panelEmpleado.Controls.Add(Me.tbApellido1Empleado)
        Me.panelEmpleado.Controls.Add(Apellido_2Label)
        Me.panelEmpleado.Controls.Add(Me.tbApellido2Empleado)
        Me.panelEmpleado.Controls.Add(TelefonoLabel)
        Me.panelEmpleado.Controls.Add(Me.tbTelefonoEmpleado)
        Me.panelEmpleado.Controls.Add(CorreoLabel)
        Me.panelEmpleado.Controls.Add(Me.tbCorreoEmpleado)
        Me.panelEmpleado.Controls.Add(ContraseñaLabel)
        Me.panelEmpleado.Controls.Add(Me.tbContraseñaEmpleado)
        Me.panelEmpleado.Controls.Add(AdministradorLabel)
        Me.panelEmpleado.Controls.Add(Me.tbAdministradorEmpleado)
        Me.panelEmpleado.Controls.Add(CargoLabel)
        Me.panelEmpleado.Controls.Add(Me.tbCargoEmpleado)
        Me.panelEmpleado.Location = New System.Drawing.Point(1920, 1080)
        Me.panelEmpleado.Name = "panelEmpleado"
        Me.panelEmpleado.Size = New System.Drawing.Size(1057, 349)
        Me.panelEmpleado.TabIndex = 14
        '
        'btnEliminarEmpleado
        '
        Me.btnEliminarEmpleado.Location = New System.Drawing.Point(127, 300)
        Me.btnEliminarEmpleado.Name = "btnEliminarEmpleado"
        Me.btnEliminarEmpleado.Size = New System.Drawing.Size(70, 23)
        Me.btnEliminarEmpleado.TabIndex = 23
        Me.btnEliminarEmpleado.Text = "Eliminar"
        Me.btnEliminarEmpleado.UseVisualStyleBackColor = True
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(51, 300)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(70, 23)
        Me.btnAgregarEmpleado.TabIndex = 22
        Me.btnAgregarEmpleado.Text = "Agregar"
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'btnModificarEmpleado
        '
        Me.btnModificarEmpleado.Location = New System.Drawing.Point(127, 271)
        Me.btnModificarEmpleado.Name = "btnModificarEmpleado"
        Me.btnModificarEmpleado.Size = New System.Drawing.Size(70, 23)
        Me.btnModificarEmpleado.TabIndex = 21
        Me.btnModificarEmpleado.Text = "Modificar"
        Me.btnModificarEmpleado.UseVisualStyleBackColor = True
        '
        'DatagridEmpleado
        '
        Me.DatagridEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridEmpleado.Location = New System.Drawing.Point(249, 24)
        Me.DatagridEmpleado.Name = "DatagridEmpleado"
        Me.DatagridEmpleado.Size = New System.Drawing.Size(795, 299)
        Me.DatagridEmpleado.TabIndex = 20
        '
        'btnDesaparecidoEnCombate
        '
        Me.btnDesaparecidoEnCombate.Location = New System.Drawing.Point(3000, 3000)
        Me.btnDesaparecidoEnCombate.Name = "btnDesaparecidoEnCombate"
        Me.btnDesaparecidoEnCombate.Size = New System.Drawing.Size(82, 23)
        Me.btnDesaparecidoEnCombate.TabIndex = 19
        Me.btnDesaparecidoEnCombate.Text = "Modificar"
        Me.btnDesaparecidoEnCombate.UseVisualStyleBackColor = True
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(51, 271)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(70, 23)
        Me.btnBuscarEmpleado.TabIndex = 18
        Me.btnBuscarEmpleado.Text = "Buscar"
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'tbIdEmpleado
        '
        Me.tbIdEmpleado.Location = New System.Drawing.Point(91, 28)
        Me.tbIdEmpleado.MaxLength = 3
        Me.tbIdEmpleado.Name = "tbIdEmpleado"
        Me.tbIdEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbIdEmpleado.TabIndex = 1
        '
        'tbNombreEmpleado
        '
        Me.tbNombreEmpleado.Location = New System.Drawing.Point(91, 54)
        Me.tbNombreEmpleado.MaxLength = 10
        Me.tbNombreEmpleado.Name = "tbNombreEmpleado"
        Me.tbNombreEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbNombreEmpleado.TabIndex = 3
        '
        'tbApellido1Empleado
        '
        Me.tbApellido1Empleado.Location = New System.Drawing.Point(91, 80)
        Me.tbApellido1Empleado.MaxLength = 10
        Me.tbApellido1Empleado.Name = "tbApellido1Empleado"
        Me.tbApellido1Empleado.Size = New System.Drawing.Size(100, 20)
        Me.tbApellido1Empleado.TabIndex = 5
        '
        'tbApellido2Empleado
        '
        Me.tbApellido2Empleado.Location = New System.Drawing.Point(91, 106)
        Me.tbApellido2Empleado.MaxLength = 10
        Me.tbApellido2Empleado.Name = "tbApellido2Empleado"
        Me.tbApellido2Empleado.Size = New System.Drawing.Size(100, 20)
        Me.tbApellido2Empleado.TabIndex = 7
        '
        'tbTelefonoEmpleado
        '
        Me.tbTelefonoEmpleado.Location = New System.Drawing.Point(91, 132)
        Me.tbTelefonoEmpleado.MaxLength = 12
        Me.tbTelefonoEmpleado.Name = "tbTelefonoEmpleado"
        Me.tbTelefonoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbTelefonoEmpleado.TabIndex = 9
        '
        'tbCorreoEmpleado
        '
        Me.tbCorreoEmpleado.Location = New System.Drawing.Point(91, 158)
        Me.tbCorreoEmpleado.MaxLength = 15
        Me.tbCorreoEmpleado.Name = "tbCorreoEmpleado"
        Me.tbCorreoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbCorreoEmpleado.TabIndex = 11
        '
        'tbContraseñaEmpleado
        '
        Me.tbContraseñaEmpleado.Location = New System.Drawing.Point(91, 184)
        Me.tbContraseñaEmpleado.MaxLength = 10
        Me.tbContraseñaEmpleado.Name = "tbContraseñaEmpleado"
        Me.tbContraseñaEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbContraseñaEmpleado.TabIndex = 13
        '
        'tbAdministradorEmpleado
        '
        Me.tbAdministradorEmpleado.Location = New System.Drawing.Point(91, 210)
        Me.tbAdministradorEmpleado.MaxLength = 1
        Me.tbAdministradorEmpleado.Name = "tbAdministradorEmpleado"
        Me.tbAdministradorEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbAdministradorEmpleado.TabIndex = 15
        '
        'tbCargoEmpleado
        '
        Me.tbCargoEmpleado.Location = New System.Drawing.Point(91, 236)
        Me.tbCargoEmpleado.MaxLength = 10
        Me.tbCargoEmpleado.Name = "tbCargoEmpleado"
        Me.tbCargoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbCargoEmpleado.TabIndex = 17
        '
        'Timer1
        '
        '
        'panelCliente
        '
        Me.panelCliente.Controls.Add(Me.btnEliminarCliente)
        Me.panelCliente.Controls.Add(Me.btnModificarCliente)
        Me.panelCliente.Controls.Add(Me.btnAgregarCliente)
        Me.panelCliente.Controls.Add(Me.ClientesDatagrid)
        Me.panelCliente.Controls.Add(Me.btnBuscarCliente)
        Me.panelCliente.Controls.Add(IdLabel1)
        Me.panelCliente.Controls.Add(Me.tbIdCliente)
        Me.panelCliente.Controls.Add(NombreLabel1)
        Me.panelCliente.Controls.Add(Me.tbNombreCliente)
        Me.panelCliente.Controls.Add(Apellido_1Label1)
        Me.panelCliente.Controls.Add(Me.tbApellido1Cliente)
        Me.panelCliente.Controls.Add(Apellido_2Label1)
        Me.panelCliente.Controls.Add(Me.tbApellido2Cliente)
        Me.panelCliente.Controls.Add(TelefonoLabel1)
        Me.panelCliente.Controls.Add(Me.tbTelefonoCliente)
        Me.panelCliente.Controls.Add(CorreoLabel1)
        Me.panelCliente.Controls.Add(Me.tbCorreoCliente)
        Me.panelCliente.Controls.Add(FechaAltaLabel)
        Me.panelCliente.Controls.Add(Me.FechaAltaClienteTimePicker)
        Me.panelCliente.Controls.Add(AltaLabel)
        Me.panelCliente.Controls.Add(Me.tbAltaCliente)
        Me.panelCliente.Location = New System.Drawing.Point(1920, 1080)
        Me.panelCliente.Name = "panelCliente"
        Me.panelCliente.Size = New System.Drawing.Size(982, 285)
        Me.panelCliente.TabIndex = 15
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(171, 249)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(77, 23)
        Me.btnEliminarCliente.TabIndex = 23
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Location = New System.Drawing.Point(88, 249)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(77, 23)
        Me.btnModificarCliente.TabIndex = 22
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(171, 220)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(77, 23)
        Me.btnAgregarCliente.TabIndex = 21
        Me.btnAgregarCliente.Text = "Agregar"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'ClientesDatagrid
        '
        Me.ClientesDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDatagrid.Location = New System.Drawing.Point(302, 15)
        Me.ClientesDatagrid.Name = "ClientesDatagrid"
        Me.ClientesDatagrid.Size = New System.Drawing.Size(660, 257)
        Me.ClientesDatagrid.TabIndex = 20
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(88, 220)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(77, 23)
        Me.btnBuscarCliente.TabIndex = 19
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'tbIdCliente
        '
        Me.tbIdCliente.Location = New System.Drawing.Point(72, 12)
        Me.tbIdCliente.MaxLength = 6
        Me.tbIdCliente.Name = "tbIdCliente"
        Me.tbIdCliente.Size = New System.Drawing.Size(200, 20)
        Me.tbIdCliente.TabIndex = 1
        '
        'tbNombreCliente
        '
        Me.tbNombreCliente.Location = New System.Drawing.Point(72, 38)
        Me.tbNombreCliente.MaxLength = 10
        Me.tbNombreCliente.Name = "tbNombreCliente"
        Me.tbNombreCliente.Size = New System.Drawing.Size(200, 20)
        Me.tbNombreCliente.TabIndex = 3
        '
        'tbApellido1Cliente
        '
        Me.tbApellido1Cliente.Location = New System.Drawing.Point(72, 64)
        Me.tbApellido1Cliente.MaxLength = 10
        Me.tbApellido1Cliente.Name = "tbApellido1Cliente"
        Me.tbApellido1Cliente.Size = New System.Drawing.Size(200, 20)
        Me.tbApellido1Cliente.TabIndex = 5
        '
        'tbApellido2Cliente
        '
        Me.tbApellido2Cliente.Location = New System.Drawing.Point(72, 90)
        Me.tbApellido2Cliente.MaxLength = 10
        Me.tbApellido2Cliente.Name = "tbApellido2Cliente"
        Me.tbApellido2Cliente.Size = New System.Drawing.Size(200, 20)
        Me.tbApellido2Cliente.TabIndex = 7
        '
        'tbTelefonoCliente
        '
        Me.tbTelefonoCliente.Location = New System.Drawing.Point(72, 116)
        Me.tbTelefonoCliente.MaxLength = 12
        Me.tbTelefonoCliente.Name = "tbTelefonoCliente"
        Me.tbTelefonoCliente.Size = New System.Drawing.Size(200, 20)
        Me.tbTelefonoCliente.TabIndex = 9
        '
        'tbCorreoCliente
        '
        Me.tbCorreoCliente.Location = New System.Drawing.Point(72, 142)
        Me.tbCorreoCliente.MaxLength = 15
        Me.tbCorreoCliente.Name = "tbCorreoCliente"
        Me.tbCorreoCliente.Size = New System.Drawing.Size(200, 20)
        Me.tbCorreoCliente.TabIndex = 11
        '
        'FechaAltaClienteTimePicker
        '
        Me.FechaAltaClienteTimePicker.Location = New System.Drawing.Point(72, 165)
        Me.FechaAltaClienteTimePicker.Name = "FechaAltaClienteTimePicker"
        Me.FechaAltaClienteTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaAltaClienteTimePicker.TabIndex = 13
        '
        'tbAltaCliente
        '
        Me.tbAltaCliente.Location = New System.Drawing.Point(72, 194)
        Me.tbAltaCliente.MaxLength = 1
        Me.tbAltaCliente.Name = "tbAltaCliente"
        Me.tbAltaCliente.Size = New System.Drawing.Size(200, 20)
        Me.tbAltaCliente.TabIndex = 15
        '
        'panelProductos
        '
        Me.panelProductos.Controls.Add(Me.btnEliminarProducto)
        Me.panelProductos.Controls.Add(Me.btnModificarProducto)
        Me.panelProductos.Controls.Add(Me.btnAgregarProducto)
        Me.panelProductos.Controls.Add(Me.ProductosDatagrid)
        Me.panelProductos.Controls.Add(Me.btnBuscarProducto)
        Me.panelProductos.Controls.Add(IdLabel2)
        Me.panelProductos.Controls.Add(Me.tbIdProducto)
        Me.panelProductos.Controls.Add(NombreLabel2)
        Me.panelProductos.Controls.Add(Me.tbNombreProducto)
        Me.panelProductos.Controls.Add(PrecioLabel)
        Me.panelProductos.Controls.Add(Me.tbPrecioProducto)
        Me.panelProductos.Controls.Add(ProveedorLabel)
        Me.panelProductos.Controls.Add(Me.tbProveedorProducto)
        Me.panelProductos.Controls.Add(GamaLabel)
        Me.panelProductos.Controls.Add(Me.tbGamaProducto)
        Me.panelProductos.Location = New System.Drawing.Point(1920, 1080)
        Me.panelProductos.Name = "panelProductos"
        Me.panelProductos.Size = New System.Drawing.Size(757, 245)
        Me.panelProductos.TabIndex = 16
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Location = New System.Drawing.Point(110, 167)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(63, 23)
        Me.btnEliminarProducto.TabIndex = 23
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Location = New System.Drawing.Point(41, 167)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(63, 23)
        Me.btnModificarProducto.TabIndex = 22
        Me.btnModificarProducto.Text = "Modificar"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(110, 138)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(63, 23)
        Me.btnAgregarProducto.TabIndex = 21
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'ProductosDatagrid
        '
        Me.ProductosDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDatagrid.Location = New System.Drawing.Point(192, 11)
        Me.ProductosDatagrid.Name = "ProductosDatagrid"
        Me.ProductosDatagrid.Size = New System.Drawing.Size(552, 178)
        Me.ProductosDatagrid.TabIndex = 20
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Location = New System.Drawing.Point(41, 138)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(63, 23)
        Me.btnBuscarProducto.TabIndex = 19
        Me.btnBuscarProducto.Text = "Buscar"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'tbIdProducto
        '
        Me.tbIdProducto.Location = New System.Drawing.Point(73, 8)
        Me.tbIdProducto.MaxLength = 4
        Me.tbIdProducto.Name = "tbIdProducto"
        Me.tbIdProducto.Size = New System.Drawing.Size(100, 20)
        Me.tbIdProducto.TabIndex = 1
        '
        'tbNombreProducto
        '
        Me.tbNombreProducto.Location = New System.Drawing.Point(73, 34)
        Me.tbNombreProducto.MaxLength = 10
        Me.tbNombreProducto.Name = "tbNombreProducto"
        Me.tbNombreProducto.Size = New System.Drawing.Size(100, 20)
        Me.tbNombreProducto.TabIndex = 3
        '
        'tbPrecioProducto
        '
        Me.tbPrecioProducto.Location = New System.Drawing.Point(73, 60)
        Me.tbPrecioProducto.MaxLength = 6
        Me.tbPrecioProducto.Name = "tbPrecioProducto"
        Me.tbPrecioProducto.Size = New System.Drawing.Size(100, 20)
        Me.tbPrecioProducto.TabIndex = 5
        '
        'tbProveedorProducto
        '
        Me.tbProveedorProducto.Location = New System.Drawing.Point(73, 86)
        Me.tbProveedorProducto.MaxLength = 2
        Me.tbProveedorProducto.Name = "tbProveedorProducto"
        Me.tbProveedorProducto.Size = New System.Drawing.Size(100, 20)
        Me.tbProveedorProducto.TabIndex = 7
        '
        'tbGamaProducto
        '
        Me.tbGamaProducto.Location = New System.Drawing.Point(73, 112)
        Me.tbGamaProducto.MaxLength = 1
        Me.tbGamaProducto.Name = "tbGamaProducto"
        Me.tbGamaProducto.Size = New System.Drawing.Size(100, 20)
        Me.tbGamaProducto.TabIndex = 9
        '
        'panelGasolina
        '
        Me.panelGasolina.Controls.Add(Me.btnModificarGasolina)
        Me.panelGasolina.Controls.Add(Me.GasolinasDatagrid)
        Me.panelGasolina.Controls.Add(Me.btnBuscarGasolina)
        Me.panelGasolina.Controls.Add(IdLabel3)
        Me.panelGasolina.Controls.Add(Me.tbIdGasolina)
        Me.panelGasolina.Controls.Add(NombreLabel3)
        Me.panelGasolina.Controls.Add(Me.tbNombreGasolina)
        Me.panelGasolina.Controls.Add(CantidadLabel)
        Me.panelGasolina.Controls.Add(Me.tbCantidadGasolina)
        Me.panelGasolina.Controls.Add(PrecioLabel1)
        Me.panelGasolina.Controls.Add(Me.tbPrecioGasolina)
        Me.panelGasolina.Location = New System.Drawing.Point(1920, 1080)
        Me.panelGasolina.Name = "panelGasolina"
        Me.panelGasolina.Size = New System.Drawing.Size(772, 197)
        Me.panelGasolina.TabIndex = 17
        '
        'btnModificarGasolina
        '
        Me.btnModificarGasolina.Location = New System.Drawing.Point(98, 121)
        Me.btnModificarGasolina.Name = "btnModificarGasolina"
        Me.btnModificarGasolina.Size = New System.Drawing.Size(63, 23)
        Me.btnModificarGasolina.TabIndex = 21
        Me.btnModificarGasolina.Text = "Modificar"
        Me.btnModificarGasolina.UseVisualStyleBackColor = True
        '
        'GasolinasDatagrid
        '
        Me.GasolinasDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GasolinasDatagrid.Location = New System.Drawing.Point(180, 19)
        Me.GasolinasDatagrid.Name = "GasolinasDatagrid"
        Me.GasolinasDatagrid.Size = New System.Drawing.Size(561, 150)
        Me.GasolinasDatagrid.TabIndex = 20
        '
        'btnBuscarGasolina
        '
        Me.btnBuscarGasolina.Location = New System.Drawing.Point(29, 121)
        Me.btnBuscarGasolina.Name = "btnBuscarGasolina"
        Me.btnBuscarGasolina.Size = New System.Drawing.Size(63, 23)
        Me.btnBuscarGasolina.TabIndex = 19
        Me.btnBuscarGasolina.Text = "Buscar"
        Me.btnBuscarGasolina.UseVisualStyleBackColor = True
        '
        'tbIdGasolina
        '
        Me.tbIdGasolina.Location = New System.Drawing.Point(61, 17)
        Me.tbIdGasolina.MaxLength = 1
        Me.tbIdGasolina.Name = "tbIdGasolina"
        Me.tbIdGasolina.Size = New System.Drawing.Size(100, 20)
        Me.tbIdGasolina.TabIndex = 1
        '
        'tbNombreGasolina
        '
        Me.tbNombreGasolina.Location = New System.Drawing.Point(61, 43)
        Me.tbNombreGasolina.MaxLength = 12
        Me.tbNombreGasolina.Name = "tbNombreGasolina"
        Me.tbNombreGasolina.Size = New System.Drawing.Size(100, 20)
        Me.tbNombreGasolina.TabIndex = 3
        '
        'tbCantidadGasolina
        '
        Me.tbCantidadGasolina.Location = New System.Drawing.Point(61, 69)
        Me.tbCantidadGasolina.MaxLength = 5
        Me.tbCantidadGasolina.Name = "tbCantidadGasolina"
        Me.tbCantidadGasolina.Size = New System.Drawing.Size(100, 20)
        Me.tbCantidadGasolina.TabIndex = 5
        '
        'tbPrecioGasolina
        '
        Me.tbPrecioGasolina.Location = New System.Drawing.Point(61, 95)
        Me.tbPrecioGasolina.MaxLength = 6
        Me.tbPrecioGasolina.Name = "tbPrecioGasolina"
        Me.tbPrecioGasolina.Size = New System.Drawing.Size(100, 20)
        Me.tbPrecioGasolina.TabIndex = 7
        '
        'panelProveedor
        '
        Me.panelProveedor.Controls.Add(Me.btnEliminarProveedor)
        Me.panelProveedor.Controls.Add(Me.btnModificarProveedor)
        Me.panelProveedor.Controls.Add(Me.btnAgregarProveedor)
        Me.panelProveedor.Controls.Add(Me.ProveedorDataGrid)
        Me.panelProveedor.Controls.Add(Me.btnBuscarProveedor)
        Me.panelProveedor.Controls.Add(IdLabel4)
        Me.panelProveedor.Controls.Add(Me.tbIdProveedor)
        Me.panelProveedor.Controls.Add(NombreLabel4)
        Me.panelProveedor.Controls.Add(Me.tbNombreProveedor)
        Me.panelProveedor.Location = New System.Drawing.Point(241, 33)
        Me.panelProveedor.Name = "panelProveedor"
        Me.panelProveedor.Size = New System.Drawing.Size(779, 212)
        Me.panelProveedor.TabIndex = 18
        '
        'btnEliminarProveedor
        '
        Me.btnEliminarProveedor.Location = New System.Drawing.Point(84, 110)
        Me.btnEliminarProveedor.Name = "btnEliminarProveedor"
        Me.btnEliminarProveedor.Size = New System.Drawing.Size(60, 23)
        Me.btnEliminarProveedor.TabIndex = 23
        Me.btnEliminarProveedor.Text = "Eliminar"
        Me.btnEliminarProveedor.UseVisualStyleBackColor = True
        '
        'btnModificarProveedor
        '
        Me.btnModificarProveedor.Location = New System.Drawing.Point(18, 110)
        Me.btnModificarProveedor.Name = "btnModificarProveedor"
        Me.btnModificarProveedor.Size = New System.Drawing.Size(60, 23)
        Me.btnModificarProveedor.TabIndex = 22
        Me.btnModificarProveedor.Text = "Modificar"
        Me.btnModificarProveedor.UseVisualStyleBackColor = True
        '
        'btnAgregarProveedor
        '
        Me.btnAgregarProveedor.Location = New System.Drawing.Point(84, 81)
        Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
        Me.btnAgregarProveedor.Size = New System.Drawing.Size(60, 23)
        Me.btnAgregarProveedor.TabIndex = 21
        Me.btnAgregarProveedor.Text = "Agregar"
        Me.btnAgregarProveedor.UseVisualStyleBackColor = True
        '
        'ProveedorDataGrid
        '
        Me.ProveedorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGrid.Location = New System.Drawing.Point(161, 3)
        Me.ProveedorDataGrid.Name = "ProveedorDataGrid"
        Me.ProveedorDataGrid.Size = New System.Drawing.Size(615, 201)
        Me.ProveedorDataGrid.TabIndex = 20
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(18, 81)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(60, 23)
        Me.btnBuscarProveedor.TabIndex = 19
        Me.btnBuscarProveedor.Text = "Buscar"
        Me.btnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'tbIdProveedor
        '
        Me.tbIdProveedor.Location = New System.Drawing.Point(55, 29)
        Me.tbIdProveedor.MaxLength = 2
        Me.tbIdProveedor.Name = "tbIdProveedor"
        Me.tbIdProveedor.Size = New System.Drawing.Size(100, 20)
        Me.tbIdProveedor.TabIndex = 1
        '
        'tbNombreProveedor
        '
        Me.tbNombreProveedor.Location = New System.Drawing.Point(55, 55)
        Me.tbNombreProveedor.MaxLength = 12
        Me.tbNombreProveedor.Name = "tbNombreProveedor"
        Me.tbNombreProveedor.Size = New System.Drawing.Size(100, 20)
        Me.tbNombreProveedor.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1904, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem, Me.ToolStripSeparator1, Me.CerrarSesionToolStripMenuItem, Me.CerrarProgramaToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'CerrarProgramaToolStripMenuItem
        '
        Me.CerrarProgramaToolStripMenuItem.Name = "CerrarProgramaToolStripMenuItem"
        Me.CerrarProgramaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CerrarProgramaToolStripMenuItem.Text = "Cerrar Programa"
        '
        'GestionesDelAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.panelProveedor)
        Me.Controls.Add(Me.panelGasolina)
        Me.Controls.Add(Me.panelProductos)
        Me.Controls.Add(Me.panelCliente)
        Me.Controls.Add(Me.panelEmpleado)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GestionesDelAdministrador"
        Me.Text = "GestionesDelAdministrador"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.panelEmpleado.ResumeLayout(False)
        Me.panelEmpleado.PerformLayout()
        CType(Me.DatagridEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCliente.ResumeLayout(False)
        Me.panelCliente.PerformLayout()
        CType(Me.ClientesDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelProductos.ResumeLayout(False)
        Me.panelProductos.PerformLayout()
        CType(Me.ProductosDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelGasolina.ResumeLayout(False)
        Me.panelGasolina.PerformLayout()
        CType(Me.GasolinasDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelProveedor.ResumeLayout(False)
        Me.panelProveedor.PerformLayout()
        CType(Me.ProveedorDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnGestionesEmpleado As Button
    Friend WithEvents btnGestionesClientes As Button
    Friend WithEvents btnGestionesProductos As Button
    Friend WithEvents btnGestionesGasolinas As Button
    Friend WithEvents btnGestionesProveedores As Button
    Friend WithEvents panelEmpleado As Panel
    Friend WithEvents btnDesaparecidoEnCombate As Button
    Friend WithEvents btnBuscarEmpleado As Button
    Friend WithEvents tbIdEmpleado As TextBox
    Friend WithEvents tbNombreEmpleado As TextBox
    Friend WithEvents tbApellido1Empleado As TextBox
    Friend WithEvents tbApellido2Empleado As TextBox
    Friend WithEvents tbTelefonoEmpleado As TextBox
    Friend WithEvents tbCorreoEmpleado As TextBox
    Friend WithEvents tbContraseñaEmpleado As TextBox
    Friend WithEvents tbAdministradorEmpleado As TextBox
    Friend WithEvents tbCargoEmpleado As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnAgregarEmpleado As Button
    Friend WithEvents btnModificarEmpleado As Button
    Friend WithEvents DatagridEmpleado As DataGridView
    Friend WithEvents btnEliminarEmpleado As Button
    Friend WithEvents panelCliente As Panel
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents ClientesDatagrid As DataGridView
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents tbIdCliente As TextBox
    Friend WithEvents tbNombreCliente As TextBox
    Friend WithEvents tbApellido1Cliente As TextBox
    Friend WithEvents tbApellido2Cliente As TextBox
    Friend WithEvents tbTelefonoCliente As TextBox
    Friend WithEvents tbCorreoCliente As TextBox
    Friend WithEvents FechaAltaClienteTimePicker As DateTimePicker
    Friend WithEvents tbAltaCliente As TextBox
    Friend WithEvents panelProductos As Panel
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnModificarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents ProductosDatagrid As DataGridView
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents tbIdProducto As TextBox
    Friend WithEvents tbNombreProducto As TextBox
    Friend WithEvents tbPrecioProducto As TextBox
    Friend WithEvents tbProveedorProducto As TextBox
    Friend WithEvents tbGamaProducto As TextBox
    Friend WithEvents panelGasolina As Panel
    Friend WithEvents btnModificarGasolina As Button
    Friend WithEvents GasolinasDatagrid As DataGridView
    Friend WithEvents btnBuscarGasolina As Button
    Friend WithEvents tbIdGasolina As TextBox
    Friend WithEvents tbNombreGasolina As TextBox
    Friend WithEvents tbCantidadGasolina As TextBox
    Friend WithEvents tbPrecioGasolina As TextBox
    Friend WithEvents panelProveedor As Panel
    Friend WithEvents btnBuscarProveedor As Button
    Friend WithEvents tbIdProveedor As TextBox
    Friend WithEvents tbNombreProveedor As TextBox
    Friend WithEvents btnEliminarProveedor As Button
    Friend WithEvents btnModificarProveedor As Button
    Friend WithEvents btnAgregarProveedor As Button
    Friend WithEvents ProveedorDataGrid As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarProgramaToolStripMenuItem As ToolStripMenuItem
End Class
