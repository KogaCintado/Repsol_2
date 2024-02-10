<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionesAdministrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionesAdministrador))
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Apellido_1Label As System.Windows.Forms.Label
        Dim Apellido_2Label As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim AdministradorLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnGestionUsuarios = New System.Windows.Forms.Button()
        Me.btnGestionClientes = New System.Windows.Forms.Button()
        Me.btnGestionProductos = New System.Windows.Forms.Button()
        Me.btnGestionGasolina = New System.Windows.Forms.Button()
        Me.btnGestionProveedores = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnModificarEmpleado = New System.Windows.Forms.Button()
        Me.btnVerTodosEmpleados = New System.Windows.Forms.Button()
        Me.btnSeleccionarUnEmpleado = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnVerTodosClientes = New System.Windows.Forms.Button()
        Me.btnVerCliente = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnVerTodosProductos = New System.Windows.Forms.Button()
        Me.btnVerProducto = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnEliminarGas = New System.Windows.Forms.Button()
        Me.btnModificarGasolina = New System.Windows.Forms.Button()
        Me.btnVerTodasGasolinas = New System.Windows.Forms.Button()
        Me.btnVerGasolina = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnEliminarProveedor = New System.Windows.Forms.Button()
        Me.btnModificarProveedor = New System.Windows.Forms.Button()
        Me.btnVerTodosProveedores = New System.Windows.Forms.Button()
        Me.btnVerProveedor = New System.Windows.Forms.Button()
        Me.ProductosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.GasolinasDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProveedoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.tbIdEmpleado = New System.Windows.Forms.TextBox()
        Me.tbNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.tbApellido1Empleado = New System.Windows.Forms.TextBox()
        Me.tbApellido2Empleado = New System.Windows.Forms.TextBox()
        Me.tbTelefonoEmpleado = New System.Windows.Forms.TextBox()
        Me.tbCorreoEmpleado = New System.Windows.Forms.TextBox()
        Me.tbContraseñaEmpleado = New System.Windows.Forms.TextBox()
        Me.tbAdministradorEmpleado = New System.Windows.Forms.TextBox()
        Me.tbCargoEmpleado = New System.Windows.Forms.TextBox()
        Me.btnAccionBuscarEmpleado = New System.Windows.Forms.Button()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Repsol_dbDataSet = New Repsol_2.Repsol_dbDataSet()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GasolinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Repsol_2.Repsol_dbDataSetTableAdapters.ProductosTableAdapter()
        Me.TableAdapterManager = New Repsol_2.Repsol_dbDataSetTableAdapters.TableAdapterManager()
        Me.EmpleadosTableAdapter = New Repsol_2.Repsol_dbDataSetTableAdapters.EmpleadosTableAdapter()
        Me.ClientesTableAdapter = New Repsol_2.Repsol_dbDataSetTableAdapters.ClientesTableAdapter()
        Me.GasolinasTableAdapter = New Repsol_2.Repsol_dbDataSetTableAdapters.GasolinasTableAdapter()
        Me.ProveedoresTableAdapter = New Repsol_2.Repsol_dbDataSetTableAdapters.ProveedoresTableAdapter()
        Me.panelBuscarEmpleado = New System.Windows.Forms.Panel()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Apellido_1Label = New System.Windows.Forms.Label()
        Apellido_2Label = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        AdministradorLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosBindingNavigator.SuspendLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GasolinasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repsol_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GasolinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBuscarEmpleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionUsuarios)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionClientes)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionProductos)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionGasolina)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGestionProveedores)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 78)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(165, 286)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnGestionUsuarios
        '
        Me.btnGestionUsuarios.Location = New System.Drawing.Point(3, 3)
        Me.btnGestionUsuarios.Name = "btnGestionUsuarios"
        Me.btnGestionUsuarios.Size = New System.Drawing.Size(162, 51)
        Me.btnGestionUsuarios.TabIndex = 0
        Me.btnGestionUsuarios.Text = "Gestion Usuarios"
        Me.btnGestionUsuarios.UseVisualStyleBackColor = True
        '
        'btnGestionClientes
        '
        Me.btnGestionClientes.Location = New System.Drawing.Point(3, 60)
        Me.btnGestionClientes.Name = "btnGestionClientes"
        Me.btnGestionClientes.Size = New System.Drawing.Size(162, 51)
        Me.btnGestionClientes.TabIndex = 1
        Me.btnGestionClientes.Text = "Gestion Clientes"
        Me.btnGestionClientes.UseVisualStyleBackColor = True
        '
        'btnGestionProductos
        '
        Me.btnGestionProductos.Location = New System.Drawing.Point(3, 117)
        Me.btnGestionProductos.Name = "btnGestionProductos"
        Me.btnGestionProductos.Size = New System.Drawing.Size(162, 51)
        Me.btnGestionProductos.TabIndex = 2
        Me.btnGestionProductos.Text = "Gestion Productos"
        Me.btnGestionProductos.UseVisualStyleBackColor = True
        '
        'btnGestionGasolina
        '
        Me.btnGestionGasolina.Location = New System.Drawing.Point(3, 174)
        Me.btnGestionGasolina.Name = "btnGestionGasolina"
        Me.btnGestionGasolina.Size = New System.Drawing.Size(162, 51)
        Me.btnGestionGasolina.TabIndex = 3
        Me.btnGestionGasolina.Text = "Gestion Gasolina"
        Me.btnGestionGasolina.UseVisualStyleBackColor = True
        '
        'btnGestionProveedores
        '
        Me.btnGestionProveedores.Location = New System.Drawing.Point(3, 231)
        Me.btnGestionProveedores.Name = "btnGestionProveedores"
        Me.btnGestionProveedores.Size = New System.Drawing.Size(162, 51)
        Me.btnGestionProveedores.TabIndex = 4
        Me.btnGestionProveedores.Text = "Gestion Proveedores"
        Me.btnGestionProveedores.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(3944, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnModificarEmpleado)
        Me.Panel1.Controls.Add(Me.btnVerTodosEmpleados)
        Me.Panel1.Controls.Add(Me.btnSeleccionarUnEmpleado)
        Me.Panel1.Location = New System.Drawing.Point(183, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(196, 51)
        Me.Panel1.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(98, 25)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Eliminar Emp"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnModificarEmpleado
        '
        Me.btnModificarEmpleado.Location = New System.Drawing.Point(98, 0)
        Me.btnModificarEmpleado.Name = "btnModificarEmpleado"
        Me.btnModificarEmpleado.Size = New System.Drawing.Size(94, 23)
        Me.btnModificarEmpleado.TabIndex = 2
        Me.btnModificarEmpleado.Text = "Mod. Emp"
        Me.btnModificarEmpleado.UseVisualStyleBackColor = True
        '
        'btnVerTodosEmpleados
        '
        Me.btnVerTodosEmpleados.Location = New System.Drawing.Point(3, 25)
        Me.btnVerTodosEmpleados.Name = "btnVerTodosEmpleados"
        Me.btnVerTodosEmpleados.Size = New System.Drawing.Size(89, 23)
        Me.btnVerTodosEmpleados.TabIndex = 1
        Me.btnVerTodosEmpleados.Text = "Ver Todos"
        Me.btnVerTodosEmpleados.UseVisualStyleBackColor = True
        '
        'btnSeleccionarUnEmpleado
        '
        Me.btnSeleccionarUnEmpleado.Location = New System.Drawing.Point(3, 0)
        Me.btnSeleccionarUnEmpleado.Name = "btnSeleccionarUnEmpleado"
        Me.btnSeleccionarUnEmpleado.Size = New System.Drawing.Size(89, 23)
        Me.btnSeleccionarUnEmpleado.TabIndex = 0
        Me.btnSeleccionarUnEmpleado.Text = "Ver Empleado"
        Me.btnSeleccionarUnEmpleado.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEliminarCliente)
        Me.Panel2.Controls.Add(Me.btnModificarCliente)
        Me.Panel2.Controls.Add(Me.btnVerTodosClientes)
        Me.Panel2.Controls.Add(Me.btnVerCliente)
        Me.Panel2.Location = New System.Drawing.Point(183, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(196, 51)
        Me.Panel2.TabIndex = 4
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(98, 25)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(94, 23)
        Me.btnEliminarCliente.TabIndex = 3
        Me.btnEliminarCliente.Text = "Eliminar Cli"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Location = New System.Drawing.Point(98, 0)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(94, 23)
        Me.btnModificarCliente.TabIndex = 2
        Me.btnModificarCliente.Text = "Mod. Cli"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'btnVerTodosClientes
        '
        Me.btnVerTodosClientes.Location = New System.Drawing.Point(3, 25)
        Me.btnVerTodosClientes.Name = "btnVerTodosClientes"
        Me.btnVerTodosClientes.Size = New System.Drawing.Size(89, 23)
        Me.btnVerTodosClientes.TabIndex = 1
        Me.btnVerTodosClientes.Text = "Ver Todos"
        Me.btnVerTodosClientes.UseVisualStyleBackColor = True
        '
        'btnVerCliente
        '
        Me.btnVerCliente.Location = New System.Drawing.Point(3, 0)
        Me.btnVerCliente.Name = "btnVerCliente"
        Me.btnVerCliente.Size = New System.Drawing.Size(89, 23)
        Me.btnVerCliente.TabIndex = 0
        Me.btnVerCliente.Text = "Ver Cliente"
        Me.btnVerCliente.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnEliminarProducto)
        Me.Panel3.Controls.Add(Me.btnModificarProducto)
        Me.Panel3.Controls.Add(Me.btnVerTodosProductos)
        Me.Panel3.Controls.Add(Me.btnVerProducto)
        Me.Panel3.Location = New System.Drawing.Point(183, 195)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(196, 51)
        Me.Panel3.TabIndex = 5
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Location = New System.Drawing.Point(98, 25)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(94, 23)
        Me.btnEliminarProducto.TabIndex = 3
        Me.btnEliminarProducto.Text = "Eliminar Prod"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Location = New System.Drawing.Point(98, 0)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(94, 23)
        Me.btnModificarProducto.TabIndex = 2
        Me.btnModificarProducto.Text = "Mod. Prod"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnVerTodosProductos
        '
        Me.btnVerTodosProductos.Location = New System.Drawing.Point(3, 25)
        Me.btnVerTodosProductos.Name = "btnVerTodosProductos"
        Me.btnVerTodosProductos.Size = New System.Drawing.Size(89, 23)
        Me.btnVerTodosProductos.TabIndex = 1
        Me.btnVerTodosProductos.Text = "Ver Todos"
        Me.btnVerTodosProductos.UseVisualStyleBackColor = True
        '
        'btnVerProducto
        '
        Me.btnVerProducto.Location = New System.Drawing.Point(3, 0)
        Me.btnVerProducto.Name = "btnVerProducto"
        Me.btnVerProducto.Size = New System.Drawing.Size(89, 23)
        Me.btnVerProducto.TabIndex = 0
        Me.btnVerProducto.Text = "Ver Producto"
        Me.btnVerProducto.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnEliminarGas)
        Me.Panel4.Controls.Add(Me.btnModificarGasolina)
        Me.Panel4.Controls.Add(Me.btnVerTodasGasolinas)
        Me.Panel4.Controls.Add(Me.btnVerGasolina)
        Me.Panel4.Location = New System.Drawing.Point(183, 252)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(196, 51)
        Me.Panel4.TabIndex = 6
        '
        'btnEliminarGas
        '
        Me.btnEliminarGas.Location = New System.Drawing.Point(98, 25)
        Me.btnEliminarGas.Name = "btnEliminarGas"
        Me.btnEliminarGas.Size = New System.Drawing.Size(94, 23)
        Me.btnEliminarGas.TabIndex = 3
        Me.btnEliminarGas.Text = "Eliminar Gas"
        Me.btnEliminarGas.UseVisualStyleBackColor = True
        '
        'btnModificarGasolina
        '
        Me.btnModificarGasolina.Location = New System.Drawing.Point(98, 0)
        Me.btnModificarGasolina.Name = "btnModificarGasolina"
        Me.btnModificarGasolina.Size = New System.Drawing.Size(94, 23)
        Me.btnModificarGasolina.TabIndex = 2
        Me.btnModificarGasolina.Text = "Mod. Gas"
        Me.btnModificarGasolina.UseVisualStyleBackColor = True
        '
        'btnVerTodasGasolinas
        '
        Me.btnVerTodasGasolinas.Location = New System.Drawing.Point(3, 25)
        Me.btnVerTodasGasolinas.Name = "btnVerTodasGasolinas"
        Me.btnVerTodasGasolinas.Size = New System.Drawing.Size(89, 23)
        Me.btnVerTodasGasolinas.TabIndex = 1
        Me.btnVerTodasGasolinas.Text = "Ver Todos"
        Me.btnVerTodasGasolinas.UseVisualStyleBackColor = True
        '
        'btnVerGasolina
        '
        Me.btnVerGasolina.Location = New System.Drawing.Point(3, 0)
        Me.btnVerGasolina.Name = "btnVerGasolina"
        Me.btnVerGasolina.Size = New System.Drawing.Size(89, 23)
        Me.btnVerGasolina.TabIndex = 0
        Me.btnVerGasolina.Text = "Ver Gasolina"
        Me.btnVerGasolina.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnEliminarProveedor)
        Me.Panel5.Controls.Add(Me.btnModificarProveedor)
        Me.Panel5.Controls.Add(Me.btnVerTodosProveedores)
        Me.Panel5.Controls.Add(Me.btnVerProveedor)
        Me.Panel5.Location = New System.Drawing.Point(183, 309)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(196, 51)
        Me.Panel5.TabIndex = 7
        '
        'btnEliminarProveedor
        '
        Me.btnEliminarProveedor.Location = New System.Drawing.Point(98, 25)
        Me.btnEliminarProveedor.Name = "btnEliminarProveedor"
        Me.btnEliminarProveedor.Size = New System.Drawing.Size(94, 23)
        Me.btnEliminarProveedor.TabIndex = 3
        Me.btnEliminarProveedor.Text = "Eliminar Prov"
        Me.btnEliminarProveedor.UseVisualStyleBackColor = True
        '
        'btnModificarProveedor
        '
        Me.btnModificarProveedor.Location = New System.Drawing.Point(98, 0)
        Me.btnModificarProveedor.Name = "btnModificarProveedor"
        Me.btnModificarProveedor.Size = New System.Drawing.Size(94, 23)
        Me.btnModificarProveedor.TabIndex = 2
        Me.btnModificarProveedor.Text = "Mod. Prov"
        Me.btnModificarProveedor.UseVisualStyleBackColor = True
        '
        'btnVerTodosProveedores
        '
        Me.btnVerTodosProveedores.Location = New System.Drawing.Point(3, 25)
        Me.btnVerTodosProveedores.Name = "btnVerTodosProveedores"
        Me.btnVerTodosProveedores.Size = New System.Drawing.Size(89, 23)
        Me.btnVerTodosProveedores.TabIndex = 1
        Me.btnVerTodosProveedores.Text = "Ver Todos"
        Me.btnVerTodosProveedores.UseVisualStyleBackColor = True
        '
        'btnVerProveedor
        '
        Me.btnVerProveedor.Location = New System.Drawing.Point(3, 0)
        Me.btnVerProveedor.Name = "btnVerProveedor"
        Me.btnVerProveedor.Size = New System.Drawing.Size(89, 23)
        Me.btnVerProveedor.TabIndex = 0
        Me.btnVerProveedor.Text = "Ver Proveedor"
        Me.btnVerProveedor.UseVisualStyleBackColor = True
        '
        'ProductosBindingNavigator
        '
        Me.ProductosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductosBindingNavigator.BindingSource = Me.ProductosBindingSource
        Me.ProductosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductosBindingNavigatorSaveItem})
        Me.ProductosBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.ProductosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductosBindingNavigator.Name = "ProductosBindingNavigator"
        Me.ProductosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductosBindingNavigator.Size = New System.Drawing.Size(3944, 25)
        Me.ProductosBindingNavigator.TabIndex = 8
        Me.ProductosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductosBindingNavigatorSaveItem
        '
        Me.ProductosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductosBindingNavigatorSaveItem.Name = "ProductosBindingNavigatorSaveItem"
        Me.ProductosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(3000, 3000)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.Size = New System.Drawing.Size(543, 336)
        Me.ProductosDataGridView.TabIndex = 8
        Me.ProductosDataGridView.Visible = False
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(3000, 3000)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(944, 306)
        Me.EmpleadosDataGridView.TabIndex = 9
        Me.EmpleadosDataGridView.Visible = False
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(3000, 3000)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(842, 325)
        Me.ClientesDataGridView.TabIndex = 10
        Me.ClientesDataGridView.Visible = False
        '
        'GasolinasDataGridView
        '
        Me.GasolinasDataGridView.AutoGenerateColumns = False
        Me.GasolinasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GasolinasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.GasolinasDataGridView.DataSource = Me.GasolinasBindingSource
        Me.GasolinasDataGridView.Location = New System.Drawing.Point(3000, 3000)
        Me.GasolinasDataGridView.Name = "GasolinasDataGridView"
        Me.GasolinasDataGridView.Size = New System.Drawing.Size(444, 251)
        Me.GasolinasDataGridView.TabIndex = 11
        Me.GasolinasDataGridView.Visible = False
        '
        'ProveedoresDataGridView
        '
        Me.ProveedoresDataGridView.AutoGenerateColumns = False
        Me.ProveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.ProveedoresDataGridView.DataSource = Me.ProveedoresBindingSource
        Me.ProveedoresDataGridView.Location = New System.Drawing.Point(3000, 3000)
        Me.ProveedoresDataGridView.Name = "ProveedoresDataGridView"
        Me.ProveedoresDataGridView.Size = New System.Drawing.Size(243, 243)
        Me.ProveedoresDataGridView.TabIndex = 12
        Me.ProveedoresDataGridView.Visible = False
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
        'tbIdEmpleado
        '
        Me.tbIdEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Id", True))
        Me.tbIdEmpleado.Location = New System.Drawing.Point(91, 28)
        Me.tbIdEmpleado.Name = "tbIdEmpleado"
        Me.tbIdEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbIdEmpleado.TabIndex = 1
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
        'tbNombreEmpleado
        '
        Me.tbNombreEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nombre", True))
        Me.tbNombreEmpleado.Location = New System.Drawing.Point(91, 54)
        Me.tbNombreEmpleado.Name = "tbNombreEmpleado"
        Me.tbNombreEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbNombreEmpleado.TabIndex = 3
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
        'tbApellido1Empleado
        '
        Me.tbApellido1Empleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido 1", True))
        Me.tbApellido1Empleado.Location = New System.Drawing.Point(91, 80)
        Me.tbApellido1Empleado.Name = "tbApellido1Empleado"
        Me.tbApellido1Empleado.Size = New System.Drawing.Size(100, 20)
        Me.tbApellido1Empleado.TabIndex = 5
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
        'tbApellido2Empleado
        '
        Me.tbApellido2Empleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido 2", True))
        Me.tbApellido2Empleado.Location = New System.Drawing.Point(91, 106)
        Me.tbApellido2Empleado.Name = "tbApellido2Empleado"
        Me.tbApellido2Empleado.Size = New System.Drawing.Size(100, 20)
        Me.tbApellido2Empleado.TabIndex = 7
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
        'tbTelefonoEmpleado
        '
        Me.tbTelefonoEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Telefono", True))
        Me.tbTelefonoEmpleado.Location = New System.Drawing.Point(91, 132)
        Me.tbTelefonoEmpleado.Name = "tbTelefonoEmpleado"
        Me.tbTelefonoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbTelefonoEmpleado.TabIndex = 9
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
        'tbCorreoEmpleado
        '
        Me.tbCorreoEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Correo", True))
        Me.tbCorreoEmpleado.Location = New System.Drawing.Point(91, 158)
        Me.tbCorreoEmpleado.Name = "tbCorreoEmpleado"
        Me.tbCorreoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbCorreoEmpleado.TabIndex = 11
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
        'tbContraseñaEmpleado
        '
        Me.tbContraseñaEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Contraseña", True))
        Me.tbContraseñaEmpleado.Location = New System.Drawing.Point(91, 184)
        Me.tbContraseñaEmpleado.Name = "tbContraseñaEmpleado"
        Me.tbContraseñaEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbContraseñaEmpleado.TabIndex = 13
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
        'tbAdministradorEmpleado
        '
        Me.tbAdministradorEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Administrador", True))
        Me.tbAdministradorEmpleado.Location = New System.Drawing.Point(91, 210)
        Me.tbAdministradorEmpleado.Name = "tbAdministradorEmpleado"
        Me.tbAdministradorEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbAdministradorEmpleado.TabIndex = 15
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
        'tbCargoEmpleado
        '
        Me.tbCargoEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Cargo", True))
        Me.tbCargoEmpleado.Location = New System.Drawing.Point(91, 236)
        Me.tbCargoEmpleado.Name = "tbCargoEmpleado"
        Me.tbCargoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.tbCargoEmpleado.TabIndex = 17
        '
        'btnAccionBuscarEmpleado
        '
        Me.btnAccionBuscarEmpleado.Location = New System.Drawing.Point(91, 262)
        Me.btnAccionBuscarEmpleado.Name = "btnAccionBuscarEmpleado"
        Me.btnAccionBuscarEmpleado.Size = New System.Drawing.Size(100, 23)
        Me.btnAccionBuscarEmpleado.TabIndex = 18
        Me.btnAccionBuscarEmpleado.Text = "Buscar"
        Me.btnAccionBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.Repsol_dbDataSet
        '
        'Repsol_dbDataSet
        '
        Me.Repsol_dbDataSet.DataSetName = "Repsol_dbDataSet"
        Me.Repsol_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.Repsol_dbDataSet
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'GasolinasBindingSource
        '
        Me.GasolinasBindingSource.DataMember = "Gasolinas"
        Me.GasolinasBindingSource.DataSource = Me.Repsol_dbDataSet
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Apellido 1"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Apellido 1"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Apellido 2"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Apellido 2"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Correo"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "FechaAlta"
        Me.DataGridViewTextBoxColumn21.HeaderText = "FechaAlta"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Alta"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Alta"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.Repsol_dbDataSet
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Apellido 1"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Apellido 1"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Apellido 2"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Apellido 2"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Correo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Contraseña"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Contraseña"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Administrador"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Administrador"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Cargo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Proveedor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Gama"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Gama"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.Repsol_dbDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DetallePedidosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.GamasTableAdapter = Nothing
        Me.TableAdapterManager.GasolinasTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Repsol_2.Repsol_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'GasolinasTableAdapter
        '
        Me.GasolinasTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'panelBuscarEmpleado
        '
        Me.panelBuscarEmpleado.Controls.Add(Me.btnAccionBuscarEmpleado)
        Me.panelBuscarEmpleado.Controls.Add(IdLabel)
        Me.panelBuscarEmpleado.Controls.Add(Me.tbIdEmpleado)
        Me.panelBuscarEmpleado.Controls.Add(NombreLabel)
        Me.panelBuscarEmpleado.Controls.Add(Me.tbNombreEmpleado)
        Me.panelBuscarEmpleado.Controls.Add(Apellido_1Label)
        Me.panelBuscarEmpleado.Controls.Add(Me.tbApellido1Empleado)
        Me.panelBuscarEmpleado.Controls.Add(Apellido_2Label)
        Me.panelBuscarEmpleado.Controls.Add(Me.tbApellido2Empleado)
        Me.panelBuscarEmpleado.Controls.Add(TelefonoLabel)
        Me.panelBuscarEmpleado.Controls.Add(Me.tbTelefonoEmpleado)
        Me.panelBuscarEmpleado.Controls.Add(CorreoLabel)
        Me.panelBuscarEmpleado.Controls.Add(Me.tbCorreoEmpleado)
        Me.panelBuscarEmpleado.Controls.Add(ContraseñaLabel)
        Me.panelBuscarEmpleado.Controls.Add(Me.tbContraseñaEmpleado)
        Me.panelBuscarEmpleado.Controls.Add(AdministradorLabel)
        Me.panelBuscarEmpleado.Controls.Add(Me.tbAdministradorEmpleado)
        Me.panelBuscarEmpleado.Controls.Add(CargoLabel)
        Me.panelBuscarEmpleado.Controls.Add(Me.tbCargoEmpleado)
        Me.panelBuscarEmpleado.Location = New System.Drawing.Point(595, 106)
        Me.panelBuscarEmpleado.Name = "panelBuscarEmpleado"
        Me.panelBuscarEmpleado.Size = New System.Drawing.Size(200, 301)
        Me.panelBuscarEmpleado.TabIndex = 13
        '
        'GestionesAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1924, 1061)
        Me.Controls.Add(Me.panelBuscarEmpleado)
        Me.Controls.Add(Me.ProveedoresDataGridView)
        Me.Controls.Add(Me.GasolinasDataGridView)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.EmpleadosDataGridView)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.ProductosBindingNavigator)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GestionesAdministrador"
        Me.Text = "GestionesAdministrador"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosBindingNavigator.ResumeLayout(False)
        Me.ProductosBindingNavigator.PerformLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GasolinasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repsol_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GasolinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBuscarEmpleado.ResumeLayout(False)
        Me.panelBuscarEmpleado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnGestionUsuarios As Button
    Friend WithEvents btnGestionClientes As Button
    Friend WithEvents btnGestionProductos As Button
    Friend WithEvents btnGestionGasolina As Button
    Friend WithEvents btnGestionProveedores As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnModificarEmpleado As Button
    Friend WithEvents btnVerTodosEmpleados As Button
    Friend WithEvents btnSeleccionarUnEmpleado As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents btnVerTodosClientes As Button
    Friend WithEvents btnVerCliente As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnModificarProducto As Button
    Friend WithEvents btnVerTodosProductos As Button
    Friend WithEvents btnVerProducto As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnEliminarGas As Button
    Friend WithEvents btnModificarGasolina As Button
    Friend WithEvents btnVerTodasGasolinas As Button
    Friend WithEvents btnVerGasolina As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnEliminarProveedor As Button
    Friend WithEvents btnModificarProveedor As Button
    Friend WithEvents btnVerTodosProveedores As Button
    Friend WithEvents btnVerProveedor As Button
    Friend WithEvents Repsol_dbDataSet As Repsol_dbDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As Repsol_dbDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As Repsol_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As Repsol_dbDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As Repsol_dbDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents GasolinasBindingSource As BindingSource
    Friend WithEvents GasolinasTableAdapter As Repsol_dbDataSetTableAdapters.GasolinasTableAdapter
    Friend WithEvents GasolinasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As Repsol_dbDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents ProveedoresDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents btnAccionBuscarEmpleado As Button
    Friend WithEvents tbIdEmpleado As TextBox
    Friend WithEvents tbNombreEmpleado As TextBox
    Friend WithEvents tbApellido1Empleado As TextBox
    Friend WithEvents tbApellido2Empleado As TextBox
    Friend WithEvents tbTelefonoEmpleado As TextBox
    Friend WithEvents tbCorreoEmpleado As TextBox
    Friend WithEvents tbContraseñaEmpleado As TextBox
    Friend WithEvents tbAdministradorEmpleado As TextBox
    Friend WithEvents tbCargoEmpleado As TextBox
    Friend WithEvents panelBuscarEmpleado As Panel
End Class
