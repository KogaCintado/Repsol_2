Imports System.Data.OleDb

Public Class GestionesAdministrador

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    Private Sub GestionesAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'datagridviews y todo a tomar por culo de forma guarra para que no se vean
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)

        'Maximize the window
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Opciones.Show()
        Me.Hide()
    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeClientes()
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeEmpleados()
        ProductosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeGasolinas()
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeProductos()
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeProveedores()
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelBuscarEmpleado()
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelBuscarCliente()
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelBuscarProducto()
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelBuscarGasolina()
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelBuscarProveedor()
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarEmpleado()
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)

    End Sub


    Private Sub invisivilizarTodosExceptoPanelEliminarGasolina()
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)

    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarProducto()
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)

    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarProveedor()
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)

    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarCliente()
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)

    End Sub

    Private Sub invisivilizarTodosExceptoPanelAgregarUsuario()
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelAgregarCliente()
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelAgregarProducto()
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelAgregarGasolina()
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelAgregarProveedor()
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelModificarEmpleado()
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub


    Private Sub invisivilizarTodosExceptoPanelModificarCliente()
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProducto.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelModificarProductos()
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarGasolina.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelModificarGasolinas()
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
        panelModificarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelModificarProveedor()
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarGasolina.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarGasolina.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelAgregarUsuario.Location = New Point(3000, 3000)
        panelAgregarCliente.Location = New Point(3000, 3000)
        panelAgregarProducto.Location = New Point(3000, 3000)
        panelAgregarGasolina.Location = New Point(3000, 3000)
        panelAgregarProveedor.Location = New Point(3000, 3000)
        panelModificarEmpleado.Location = New Point(3000, 3000)
    End Sub


    Private Sub btnVerTodosProductos_Click(sender As Object, e As EventArgs) Handles btnVerTodosProductos.Click
        MostrarTodosProductos()
        invisivilizarTodosExceptoDataGridDeProductos()
        ProductosDataGridView.Visible = True
        ProductosDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerTodosEmpleados_Click(sender As Object, e As EventArgs) Handles btnVerTodosEmpleados.Click
        MostrarTodosEmpelados()
        invisivilizarTodosExceptoDataGridDeEmpleados()
        EmpleadosDataGridView.Visible = True
        EmpleadosDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerTodosClientes_Click(sender As Object, e As EventArgs) Handles btnVerTodosClientes.Click
        MostrarTodosClientes()
        invisivilizarTodosExceptoDataGridDeClientes()
        ClientesDataGridView.Visible = True
        ClientesDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerTodasGasolinas_Click(sender As Object, e As EventArgs) Handles btnVerTodasGasolinas.Click
        MostrarTodasGasolinas()
        invisivilizarTodosExceptoDataGridDeGasolinas()
        GasolinasDataGridView.Visible = True
        GasolinasDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerTodosProveedores_Click(sender As Object, e As EventArgs) Handles btnVerTodosProveedores.Click
        MostrarTodosProveedores()
        invisivilizarTodosExceptoDataGridDeProveedores()
        ProveedoresDataGridView.Visible = True
        ProveedoresDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnSeleccionarUnEmpleado_Click(sender As Object, e As EventArgs) Handles btnSeleccionarUnEmpleado.Click
        invisivilizarTodosExceptoPanelBuscarEmpleado()
        panelBuscarEmpleado.Location = New Point(476, 81)
    End Sub
    Private Sub btnVerCliente_Click(sender As Object, e As EventArgs) Handles btnVerCliente.Click
        invisivilizarTodosExceptoPanelBuscarCliente()
        panelBuscarCliente.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerProducto_Click(sender As Object, e As EventArgs) Handles btnVerProducto.Click
        invisivilizarTodosExceptoPanelBuscarProducto()
        panelBuscarProducto.Location = New Point(476, 81)
    End Sub
    Private Sub btnVerGasolina_Click(sender As Object, e As EventArgs) Handles btnVerGasolina.Click
        invisivilizarTodosExceptoPanelBuscarGasolina()
        panelBuscarGasolina.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerProveedor_Click(sender As Object, e As EventArgs) Handles btnVerProveedor.Click
        invisivilizarTodosExceptoPanelBuscarProveedor()
        panelBuscarProveedor.Location = New Point(476, 81)
    End Sub


    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        invisivilizarTodosExceptoPanelAgregarUsuario()
        panelAgregarUsuario.Location = New Point(476, 81)
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        invisivilizarTodosExceptoPanelAgregarCliente()
        panelAgregarCliente.Location = New Point(476, 81)
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        invisivilizarTodosExceptoPanelAgregarProducto()
        panelAgregarProducto.Location = New Point(476, 81)
    End Sub

    Private Sub btnAgregarGasolina_Click(sender As Object, e As EventArgs) Handles btnAgregarGasolina.Click
        invisivilizarTodosExceptoPanelAgregarGasolina()
        panelAgregarGasolina.Location = New Point(476, 81)
    End Sub

    Private Sub btnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
        invisivilizarTodosExceptoPanelAgregarProveedor()
        panelAgregarProveedor.Location = New Point(476, 81)
    End Sub


    Private Sub btnModificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnModificarEmpleado.Click
        invisivilizarTodosExceptoPanelModificarEmpleado()
        panelModificarEmpleado.Location = New Point(476, 81)
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        invisivilizarTodosExceptoPanelModificarCliente()
        panelModificarCliente.Location = New Point(476, 81)
    End Sub

    Private Sub btnModificarProducto_Click(sender As Object, e As EventArgs) Handles btnModificarProducto.Click
        invisivilizarTodosExceptoPanelModificarProductos()
        panelModificarProducto.Location = New Point(476, 81)
    End Sub

    Private Sub btnModificarGasolina_Click(sender As Object, e As EventArgs) Handles btnModificarGasolina.Click
        invisivilizarTodosExceptoPanelModificarGasolinas()
        panelModificarGasolina.Location = New Point(476, 81)
    End Sub

    Private Sub btnModificarProveedor_Click(sender As Object, e As EventArgs) Handles btnModificarProveedor.Click
        invisivilizarTodosExceptoPanelModificarProveedor()
        panelModificarProveedores.Location = New Point(476, 81)
    End Sub

    Private Sub btnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btnEliminarEmpleado.Click
        invisivilizarTodosExceptoPanelEliminarEmpleado()
        panelEliminarEmpleado.Location = New Point(476, 81)
    End Sub

    Private Sub btnEliminarGas_Click(sender As Object, e As EventArgs) Handles btnEliminarGas.Click
        invisivilizarTodosExceptoPanelEliminarGasolina()
        panelEliminarGasolina.Location = New Point(476, 81)
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        invisivilizarTodosExceptoPanelEliminarProducto()
        panelEliminarProducto.Location = New Point(476, 81)
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        invisivilizarTodosExceptoPanelEliminarCliente()
        panelEliminarClientes.Location = New Point(476, 81)
    End Sub

    Private Sub btnEliminarProveedor_Click(sender As Object, e As EventArgs) Handles btnEliminarProveedor.Click
        invisivilizarTodosExceptoPanelEliminarProveedor()
        panelEliminarProveedores.Location = New Point(476, 81)
    End Sub





    Private Sub btnAccionBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarEmpleado.Click

        'En este boton lo que hacemos es buscar un empleado por su id
        'Si el id no existe, mostramos un mensaje de error
        'Si el id existe, mostramos los datos del empleado
        Dim idEmpleado As Integer
        idEmpleado = tbIdEmpleado.Text
        Dim empleado As DataRow
        empleado = BuscarEmpleado(idEmpleado)
        If empleado Is Nothing Then
            MessageBox.Show("No existe un empleado con ese id")
        Else
            tbNombreEmpleado.Text = empleado("Nombre")
            tbApellido1Empleado.Text = empleado("Apellido 1")
            tbApellido2Empleado.Text = empleado("Apellido 2")
            tbTelefonoEmpleado.Text = empleado("Telefono")
            tbCorreoEmpleado.Text = empleado("Correo")
            tbContraseñaEmpleado.Text = empleado("Contraseña")
            tbCargoEmpleado.Text = empleado("Cargo")
            tbAdministradorEmpleado.Text = empleado("Administrador")
        End If
    End Sub

    Private Sub btnAccionBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarCliente.Click

        'En este boton lo que hacemos es buscar un Cliente por su id
        'Si el id no existe, mostramos un mensaje de error
        'Si el id existe, mostramos los datos del Cliente
        Dim idCliente As Integer
        idCliente = tbIdCliente.Text
        Dim cliente As DataRow
        cliente = BuscarCliente(idCliente)
        If cliente Is Nothing Then
            MessageBox.Show("No existe un cliente con ese id")
        Else
            tbNombreCliente.Text = cliente("Nombre")
            tbApellido1Cliente.Text = cliente("Apellido 1")
            tbApellido2Cliente.Text = cliente("Apellido 2")
            tbTelefonoCliente.Text = cliente("Telefono")
            tbCorreoCliente.Text = cliente("Correo")
            FechaAltaClienteTimePicker.Value = cliente("FechaAlta")
        End If


    End Sub

    Private Sub btnAccionBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarProducto.Click
        'En este boton lo que hacemos es buscar un Producto por su id
        'Si el id no existe, mostramos un mensaje de error
        'Si el id existe, mostramos los datos del Producto
        Dim idProducto As Integer
        idProducto = tbIdProducto.Text
        Dim producto As DataRow
        producto = BuscarProducto(idProducto)
        If producto Is Nothing Then
            MessageBox.Show("No existe un producto con ese id")
        Else
            tbNombreProducto.Text = producto("Nombre")
            tbPrecioProducto.Text = producto("Precio")
            tbProveedorProducto.Text = producto("Proveedor")
            tbGamaProducto.Text = producto("Gama")
        End If
    End Sub




    Private Sub btnAccionBuscarGasolina_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarGasolina.Click
        'En este boton lo que hacemos es buscar una Gasolina por su id
        'Si el id no existe, mostramos un mensaje de error
        'Si el id existe, mostramos los datos de la Gasolina
        Dim idGasolina As Integer
        idGasolina = tbIdGasolina.Text
        Dim gasolina As DataRow
        gasolina = BuscarGasolina(idGasolina)
        If gasolina Is Nothing Then
            MessageBox.Show("No existe una gasolina con ese id")
        Else
            tbNombreGasolina.Text = gasolina("Nombre")
            tbPrecioGasolina.Text = gasolina("Precio")
            tbCantidadGasolina.Text = gasolina("Cantidad")
        End If
    End Sub

    Private Sub btnAccionBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarProveedor.Click


        Dim idProveedor As Integer
        idProveedor = tbIdProveedor.Text
        Dim proveedor As DataRow
        proveedor = BuscarProveedor(idProveedor)
        If proveedor Is Nothing Then
            MessageBox.Show("No existe un proveedor con ese id")
        Else
            tbNombreProveedor.Text = proveedor("Nombre")
        End If
    End Sub


    Private Sub btnAccionAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAccionAgregarUsuario.Click
        AgregarEmpleado(tbIdEmpleadoAgregar.Text, tbNombreEmpleadoAgregar.Text, tbApellido1EmpleadoAgregar.Text, tbApellido2EmpleadoAgregar.Text,
                        tbTelefonoEmpleadoAgregar.Text, tbCorreoEmpleadoAgregar.Text, tbContraseñaEmpleadoAgregar.Text, tbAdministradorEmpleadoAgregar.Text, tbCargoEmpleadoAgregar.Text)
    End Sub

    Private Sub btnAccionAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAccionAgregarCliente.Click
        AgregarCliente(tbIdClienteAgregar.Text, tbNombreClienteAgregar.Text, tbApellido1ClienteAgregar.Text, tbApellido2ClienteAgregar.Text, tbTelefonoClienteAgregar.Text, tbCorreoClienteAgregar.Text, dtpFechaAltaClienteAgregar.Value.Date, tbAltaClienteAgregar.Text)
    End Sub

    Private Sub btnAccionAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAccionAgregarProducto.Click
        AgregarProducto(tbIdProductoAgregar.Text, tbNombreProductoAgregar.Text, tbPrecioProductoAgregar.Text, tbProveedorProductoAgregar.Text, tbGamaProductoAgregar.Text)
    End Sub

    Private Sub btnAccionAgregarGasolina_Click(sender As Object, e As EventArgs) Handles btnAccionAgregarGasolina.Click
        AgregarGasolina(tbIdGasolinaAgregar.Text, tbNombreGasolinaAgregar.Text, tbCantidadGasolinaAgregar.Text, tbPrecioGasolinaAgregar.Text)
    End Sub

    Private Sub btnAccionAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAccionAgregarProveedor.Click
        AgregarProveedor(tbIdProveedorAgregar.Text, tbNombreProveedorAgregar.Text)
    End Sub

    Private Sub btnAccionModificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAccionModificarEmpleado.Click
        ModificarUsuario(tbIdEmpleadoModificar.Text, tbNombreEmpleadoModificar.Text, tbApellido1EmpleadoModificar.Text, tbApellido2EmpleadoModificar.Text, tbTelefonoEmpleadoModificar.Text, tbCorreoEmpleadoModificar.Text,
                        tbContraseñaEmpleadoModificar.Text, tbCargoEmpleadoModificar.Text, tbAdministradorEmpleadoModificar.Text)
    End Sub

    Private Sub btnAccionModificarCliente_Click(sender As Object, e As EventArgs) Handles btnAccionModificarCliente.Click
        ModificarCliente(tbIdClienteModificar.Text, tbNombreClienteModificar.Text, tbApellido1ClienteModificar.Text, tbApellido2ClienteModificar.Text, tbTelefonoClienteModificar.Text,
            tbCorreoClienteModificar.Text, dtmFechaAltaClienteModificar.Value.Date, tbAltaClienteModificar.Text)
    End Sub

    Private Sub btnAccionModificarProducto_Click(sender As Object, e As EventArgs) Handles btnAccionModificarProducto.Click
        ModificarProductos(tbIdProductoModificar.Text, tbNombreProductoModificar.Text, tbPrecioProductoModificar.Text, tbProveedorProductoModificar.Text, tbGamaProductoModificar.Text)
    End Sub

    Private Sub btnAccionModificarGasolina_Click(sender As Object, e As EventArgs) Handles btnAccionModificarGasolina.Click
        ModificarGasolina(tbIdGasolinaModificar.Text, tbNombreGasolinaModificar.Text, tbCantidadGasolinaModificar.Text, tbPrecioGasolinaModificar.Text)
    End Sub

    Private Sub btnAccionModificarProveedor_Click(sender As Object, e As EventArgs) Handles btnAccionModificarProveedor.Click
        ModificarProveedores(tbIdModificarProveedor.Text, tbNombreProveedorModificar.Text)
    End Sub

    Private Sub btnAccionEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAccionEliminarEmpleado.Click
        EliminarEmpleado(tbIdEmpleadoEliminar.Text)
    End Sub
    Private Sub btnAccionEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnAccionEliminarProducto.Click
        EliminarProducto(tbIdProductoEliminar.Text)
    End Sub
    Private Sub btnAccionEliminarGasolina_Click(sender As Object, e As EventArgs) Handles btnAccionEliminarGasolina.Click
        EliminarGasolina(tbIdGasolinaEliminar.Text)
    End Sub
    Private Sub btnAccionEliminarProveedor_Click(sender As Object, e As EventArgs) Handles btnAccionEliminarProveedor.Click
        EliminarProveedor(tbIdProveedorEliminar.Text)
    End Sub

    Private Sub btnAccionEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnAccionEliminarCliente.Click
        EliminarCliente(tbIdClienteEliminar.Text)
    End Sub

    Public Function BuscarCliente(id As Integer) As DataRow

        ' Crear una nueva instancia del comando SQL
        Dim cmd As New OleDbCommand("SELECT * FROM Clientes WHERE id = @id", conn)

        ' Añadir el parámetro al comando SQL
        cmd.Parameters.AddWithValue("@id", id)

        ' Crear una nueva instancia del adaptador de datos
        Dim da As New OleDbDataAdapter(cmd)

        ' Crear una nueva instancia del DataSet
        Dim ds As New DataSet()

        Try
            ' Llenar el DataSet con los datos de la tabla Clientes
            da.Fill(ds, "Clientes")
        Catch ex As OleDbException
            MessageBox.Show("Hubo un error conectando con la base de datos: " & ex.Message)
            Return Nothing
        End Try

        ' Comprobar si se encontró algún registro
        If ds.Tables("Clientes").Rows.Count > 0 Then
            ' Devolver la primera fila
            Return ds.Tables("Clientes").Rows(0)
        Else
            ' Si no se encontró ningún registro, devolver Nothing
            Return Nothing
        End If
    End Function

    Public Function BuscarEmpleado(id As Integer) As DataRow

        ' Crear una nueva instancia del comando SQL
        Dim cmd As New OleDbCommand("SELECT * FROM Empleados WHERE id = @id", conn)

        ' Añadir el parámetro al comando SQL
        cmd.Parameters.AddWithValue("@id", id)

        ' Crear una nueva instancia del adaptador de datos
        Dim da As New OleDbDataAdapter(cmd)

        ' Crear una nueva instancia del DataSet
        Dim ds As New DataSet()

        Try
            ' Llenar el DataSet con los datos de la tabla Empleados
            da.Fill(ds, "Empleados")
        Catch ex As OleDbException
            MessageBox.Show("Hubo un error conectando con la base de datos: " & ex.Message)
            Return Nothing
        Catch ex As InvalidOperationException
            MessageBox.Show("Error introduzca bien los datos:" & ex.Message)
            Inicio.Close()
            Return Nothing
        End Try

        ' Comprobar si se encontró algún registro
        If ds.Tables("Empleados").Rows.Count > 0 Then
            ' Devolver la primera fila
            Return ds.Tables("Empleados").Rows(0)
        Else
            ' Si no se encontró ningún registro, devolver Nothing
            Return Nothing
        End If
    End Function

    Public Function BuscarProducto(id As Integer) As DataRow

        ' Crear una nueva instancia del comando SQL
        Dim cmd As New OleDbCommand("SELECT * FROM Productos WHERE id = @id", conn)

        ' Añadir el parámetro al comando SQL
        cmd.Parameters.AddWithValue("@id", id)

        ' Crear una nueva instancia del adaptador de datos
        Dim da As New OleDbDataAdapter(cmd)

        ' Crear una nueva instancia del DataSet
        Dim ds As New DataSet()

        Try
            ' Llenar el DataSet con los datos de la tabla Productos
            da.Fill(ds, "Productos")
        Catch ex As OleDbException
            MessageBox.Show("Hubo un error con la conexion de la base de datos: " & ex.Message)
            Return Nothing
        End Try

        ' Comprobar si se encontró algún registro
        If ds.Tables("Productos").Rows.Count > 0 Then
            ' Devolver la primera fila
            Return ds.Tables("Productos").Rows(0)
        Else
            ' Si no se encontró ningún registro, devolver Nothing
            Return Nothing
        End If
    End Function


    Public Function BuscarGasolina(id As Integer) As DataRow

        ' Crear una nueva instancia del comando SQL
        Dim cmd As New OleDbCommand("SELECT * FROM Gasolinas WHERE id = @id", conn)

        ' Añadir el parámetro al comando SQL
        cmd.Parameters.AddWithValue("@id", id)

        ' Crear una nueva instancia del adaptador de datos
        Dim da As New OleDbDataAdapter(cmd)

        ' Crear una nueva instancia del DataSet
        Dim ds As New DataSet()

        Try
            ' Llenar el DataSet con los datos de la tabla Gasolinas
            da.Fill(ds, "Gasolinas")
        Catch ex As OleDbException
            MessageBox.Show("Hubo un error con la base de datos: " & ex.Message)
            Return Nothing
        End Try

        ' Comprobar si se encontró algún registro
        If ds.Tables("Gasolinas").Rows.Count > 0 Then
            ' Devolver la primera fila
            Return ds.Tables("Gasolinas").Rows(0)
        Else
            ' Si no se encontró ningún registro, devolver Nothing
            Return Nothing
        End If
    End Function


    Public Function BuscarProveedor(id As Integer) As DataRow

        ' Crear una nueva instancia del comando SQL
        Dim cmd As New OleDbCommand("SELECT * FROM Proveedores WHERE id = @id", conn)

        ' Añadir el parámetro al comando SQL
        cmd.Parameters.AddWithValue("@id", id)

        ' Crear una nueva instancia del adaptador de datos
        Dim da As New OleDbDataAdapter(cmd)

        ' Crear una nueva instancia del DataSet
        Dim ds As New DataSet()

        Try
            ' Llenar el DataSet con los datos de la tabla Proveedores
            da.Fill(ds, "Proveedores")
        Catch ex As OleDbException
            MessageBox.Show("Hubo un error en la busqueda de la base de datos: " & ex.Message)
            Return Nothing
        End Try

        ' Comprobar si se encontró algún registro
        If ds.Tables("Proveedores").Rows.Count > 0 Then
            ' Devolver la primera fila
            Return ds.Tables("Proveedores").Rows(0)
        Else
            ' Si no se encontró ningún registro, devolver Nothing
            Return Nothing
        End If


    End Function



    Private Sub MostrarTodosEmpelados()
        Dim cmd As New OleDbCommand("SELECT * FROM Empleados", conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        EmpleadosDataGridView.DataSource = dt
        EmpleadosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub MostrarTodosClientes()
        Dim cmd As New OleDbCommand("Select * from Clientes", conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        ClientesDataGridView.DataSource = dt
        ClientesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub MostrarTodasGasolinas()
        Dim cmd As New OleDbCommand("Select * from Gasolinas", conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        GasolinasDataGridView.DataSource = dt
        GasolinasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub MostrarTodosProductos()
        Dim cmd As New OleDbCommand("Select * from Productos", conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        ProductosDataGridView.DataSource = dt
        ProductosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub MostrarTodosProveedores()
        Dim cmd As New OleDbCommand("Select * from Proveedores", conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        ProveedoresDataGridView.DataSource = dt
        ProveedoresDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Public Sub AgregarEmpleado(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As String, correo As String, contraseña As String, administrador As Integer, cargo As String)

        Try
            conn.Open()

            Using cmd As New OleDbCommand("Insert into Empleados([id], [Nombre], [Apellido 1], [Apellido 2], [Telefono], [Correo], [Contraseña], [Administrador], [Cargo]) 
            values (?, ?, ?, ?, ?, ?, ?, ?, ?)", conn)
                cmd.Parameters.Add(New OleDbParameter("id", id))
                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.Parameters.Add(New OleDbParameter("apellido1", apellido1))
                cmd.Parameters.Add(New OleDbParameter("apellido2", apellido2))
                cmd.Parameters.Add(New OleDbParameter("telefono", telefono))
                cmd.Parameters.Add(New OleDbParameter("correo", correo))
                cmd.Parameters.Add(New OleDbParameter("contraseña", contraseña))
                cmd.Parameters.Add(New OleDbParameter("administrador", administrador))
                cmd.Parameters.Add(New OleDbParameter("cargo", cargo))
                cmd.ExecuteNonQuery()
                MsgBox("El empleado: " & nombre & " se ha agregado correctamente")
            End Using
        Catch ex As Exception
            MsgBox("Hubo un error al agregar el empleado: " & ex.Message)
        Finally
            conn.Close()
        End Try




    End Sub


    Public Sub AgregarProducto(id As Integer, nombre As String, precio As Decimal, proveedor As Integer, gama As Integer)

        Try

            conn.Open()
            Using cmd As New OleDbCommand("Insert into Productos([id],[Nombre],[Precio],[Proveedor],[Gama])
                values(?,?,?,?,?)", conn)
                cmd.Parameters.Add(New OleDbParameter("id", id))
                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.Parameters.Add(New OleDbParameter("precio", precio))
                cmd.Parameters.Add(New OleDbParameter("proveedor", proveedor))
                cmd.Parameters.Add(New OleDbParameter("gama", gama))
                cmd.ExecuteNonQuery()
                MsgBox("Se agrego el producto " & nombre & " correctamente")
            End Using

        Catch ex As Exception
            MsgBox("Hubo un error con la insercion del producto" & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub AgregarCliente(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As String, correo As String, fecha As Date, alta As Integer)

        Try
            conn.Open()
            Using cmd As New OleDbCommand("Insert into Clientes([id],[Nombre],[Apellido 1],[Apellido 2],[Telefono],[Correo],[FechaAlta],[Alta])
                values(?, ?, ?, ?, ?, ?, ?, ?)", conn)
                cmd.Parameters.Add(New OleDbParameter("id", id))
                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.Parameters.Add(New OleDbParameter("apellido1", apellido1))
                cmd.Parameters.Add(New OleDbParameter("apellido2", apellido2))
                cmd.Parameters.Add(New OleDbParameter("telefono", telefono))
                cmd.Parameters.Add(New OleDbParameter("correo", correo))
                cmd.Parameters.Add(New OleDbParameter("fechaAlta", fecha))
                cmd.Parameters.Add(New OleDbParameter("alta", alta))
                cmd.ExecuteNonQuery()
                MsgBox("Se agrego el cliente: " & nombre)
            End Using
        Catch ex As Exception
            MsgBox("Hubo un error a la hora de agregar el cliente: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub AgregarGasolina(id As Integer, nombre As String, cantidad As Decimal, precio As Decimal)

        Try

            conn.Open()

            Using cmd As New OleDbCommand("Insert into Gasolinas([id],[Nombre],[Cantidad],[Precio])
                Values(?, ?, ?, ?)", conn)

                cmd.Parameters.Add(New OleDbParameter("id", id))
                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.Parameters.Add(New OleDbParameter("cantidad", cantidad))
                cmd.Parameters.Add(New OleDbParameter("precio", precio))
                cmd.ExecuteNonQuery()
                MsgBox("Se agrego correctamente la gasolina: " & nombre)
            End Using
        Catch ex As Exception
            MsgBox("Hubo un error con la inserccion de la gasolina: " & ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub AgregarProveedor(id As Integer, nombre As String)

        Try

            conn.Open()

            Using cmd As New OleDbCommand("Insert into Proveedores([id], [Nombre]) Values(?, ?)", conn)

                cmd.Parameters.Add(New OleDbParameter("id", id))
                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.ExecuteNonQuery()
                MsgBox("Se agrego el proveedor: " & nombre)
            End Using
        Catch ex As Exception
            MsgBox("Hubo un error en la agregacion del proveedor: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub






    Private Sub ModificarUsuario(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As String, correo As String, contraseña As String, cargo As String, administrador As Integer)

        Try
            conn.Open()

            Using cmd As New OleDbCommand("Update Empleados set Nombre = ?, [Apellido 1] = ?,
            [Apellido 2] = ?, Telefono = ?, Correo = ?, Contraseña = ?, Cargo = ?, Administrador = ?
            where id = ?", conn)

                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.Parameters.Add(New OleDbParameter("apellido1", apellido1))
                cmd.Parameters.Add(New OleDbParameter("apellido2", apellido2))
                cmd.Parameters.Add(New OleDbParameter("telefono", telefono))
                cmd.Parameters.Add(New OleDbParameter("correo", correo))
                cmd.Parameters.Add(New OleDbParameter("contraseña", contraseña))
                cmd.Parameters.Add(New OleDbParameter("cargo", cargo))
                cmd.Parameters.Add(New OleDbParameter("administrador", administrador))
                cmd.Parameters.Add(New OleDbParameter("id", id))

                cmd.ExecuteNonQuery()
                MsgBox("Usuario actualizado con exito")

            End Using

        Catch ex As Exception

            MsgBox("Hubo un error con la actualizacion del usuario:" & ex.Message)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub ModificarCliente(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As String, correo As String, fechaAlta As Date, alta As Integer)

        Try
            conn.Open()

            Using cmd As New OleDbCommand("Update Clientes set Nombre = ?, [Apellido 1] = ?, [Apellido 2]  = ?
                Telefono = ?, Correo = ?, FechaAlta = ?, Alta = ?", conn)
                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.Parameters.Add(New OleDbParameter("apellido1", apellido1))
                cmd.Parameters.Add(New OleDbParameter("apellido2", apellido2))
                cmd.Parameters.Add(New OleDbParameter("telefono", telefono))
                cmd.Parameters.Add(New OleDbParameter("correo", correo))
                cmd.Parameters.Add(New OleDbParameter("fechaAlta", fechaAlta))
                cmd.Parameters.Add(New OleDbParameter("alta", alta))
                cmd.Parameters.Add(New OleDbParameter("id", id))
                cmd.ExecuteNonQuery()
                MsgBox("Se ha actualizado el cliente correctamente")
            End Using


        Catch ex As Exception

            MsgBox("Hubo un problema a la hora de actualizar el cliente: " & ex.Message)

        Finally

            conn.Close()

        End Try

    End Sub


    Private Sub ModificarProductos(id As Integer, nombre As String, precio As Decimal, proveedor As Integer, gama As Integer)

        Try

            conn.Open()

            Using cmd As New OleDbCommand("Update Productos set nombre = ?, precio = ?, proveedor = ?, gama = ? where id = ?", conn)
                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.Parameters.Add(New OleDbParameter("precio", precio))
                cmd.Parameters.Add(New OleDbParameter("proveedor", proveedor))
                cmd.Parameters.Add(New OleDbParameter("gama", gama))
                cmd.Parameters.Add(New OleDbParameter("id", id))
                cmd.ExecuteNonQuery()
                MsgBox("Se ha actualizado el producto correctamente")
            End Using

        Catch ex As Exception

            MsgBox("Hubo un problema en la actualizacion del producto: " & ex.Message)

        Finally
            conn.Close()
        End Try

    End Sub




    Private Sub ModificarGasolina(id As Integer, nombre As String, cantidad As Integer, precio As Decimal)

        Try

            conn.Open()

            Using cmd As New OleDbCommand("Update Gasolinas set nombre = ?, cantidad = ?, precio = ? where id = ?", conn)

                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.Parameters.Add(New OleDbParameter("cantidad", cantidad))
                cmd.Parameters.Add(New OleDbParameter("precio", precio))
                cmd.Parameters.Add(New OleDbParameter("id", id))
                cmd.ExecuteNonQuery()
                MsgBox("La gasolina se actualizo correctamente")
            End Using
        Catch ex As Exception
            MsgBox("Hubo un error a la hora de actualizar la gasolina:" & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub ModificarProveedores(id As Integer, nombre As String)

        Try

            conn.Open()
            Using cmd As New OleDbCommand("Update Proveedores set nombre = ? where id = ?", conn)

                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.Parameters.Add(New OleDbParameter("id", id))
                cmd.ExecuteNonQuery()
                MsgBox("El proveedor se actualizo con exito")
            End Using
        Catch ex As Exception
            MsgBox("Hubo un problema al actualizar el proveedor: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Public Sub EliminarEmpleado(id As Integer)
        Dim cmd As New OleDbCommand("DELETE FROM Empleados WHERE id = @id", conn)
        cmd.Parameters.AddWithValue("@id", id)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Empleado eliminado correctamente")
        Catch ex As OleDbException
            MessageBox.Show("Hubo un error al eliminar al empleado: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub EliminarCliente(id As Integer)
        Dim cmd As New OleDbCommand("DELETE FROM Clientes WHERE id = @id", conn)
        Try
            conn.Open()
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Cliente eliminado correctamente")
        Catch ex As OleDbException
            MessageBox.Show("Hubo un al eliminar el Cliente: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Public Sub EliminarProducto(id As Integer)
        Dim cmd As New OleDbCommand("DELETE FROM Productos WHERE id = @id", conn)
        Try
            conn.Open()
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Producto eliminado correctamente")
        Catch ex As OleDbException
            MessageBox.Show("Hubo un error al eliminar el producto: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Public Sub EliminarGasolina(id As Integer)
        Dim cmd As New OleDbCommand("DELETE FROM Gasolinas WHERE id = @id", conn)
        Try
            conn.Open()
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Gasolina eliminada correctamente")
        Catch ex As OleDbException
            MessageBox.Show("Hubo un error al eliminar la gasolina: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Public Sub EliminarProveedor(id As Integer)
        Dim cmd As New OleDbCommand("DELETE FROM Productos Where gama = @id", conn)
        Dim cmd2 As New OleDbCommand("DELETE FROM Proveedores WHERE id = @id", conn)
        Try
            conn.Open()

            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()

            cmd2.Parameters.AddWithValue("@id", id)
            cmd2.ExecuteNonQuery()
            MessageBox.Show("Proveedor eliminado correctamente")
        Catch ex As OleDbException
            MessageBox.Show("Error con la eliminacion del proveedor: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub



    '---------------------------------------------------------------------------------------------------------------------------
    '--------------------------------Zona de control de visibilidad de los paneles de la izquierda------------------------------
    '---------------------------------------------------------------------------------------------------------------------------

    Private Sub btnGestionUsuarios_Click(sender As Object, e As EventArgs) Handles btnGestionUsuarios.Click
        'cada vez que demos click a este boton, mostraremos el panel
        'y ocultaremos los demas paneles
        panelOpcionesCrudUsuario.Visible = True
        panelOpcionesCrudProductos.Visible = False
        panelOpcionesCrudClientes.Visible = False
        panelOpcionesCrudGasolina.Visible = False
        panelOpcionesCrudProveedores.Visible = False
    End Sub

    Private Sub btnGestionClientes_Click(sender As Object, e As EventArgs) Handles btnGestionClientes.Click
        'tendra el mismo comportamiento que el boton de gestion de usuarios
        panelOpcionesCrudUsuario.Visible = False
        panelOpcionesCrudProductos.Visible = False
        panelOpcionesCrudClientes.Visible = True
        panelOpcionesCrudGasolina.Visible = False
        panelOpcionesCrudProveedores.Visible = False
    End Sub

    Private Sub btnGestionProductos_Click(sender As Object, e As EventArgs) Handles btnGestionProductos.Click
        'tendra el mismo comportamiento que el boton de gestion de usuarios
        panelOpcionesCrudUsuario.Visible = False
        panelOpcionesCrudProductos.Visible = True
        panelOpcionesCrudClientes.Visible = False
        panelOpcionesCrudGasolina.Visible = False
        panelOpcionesCrudProveedores.Visible = False
    End Sub

    Private Sub btnGestionGasolina_Click(sender As Object, e As EventArgs) Handles btnGestionGasolina.Click
        'tendra el mismo comportamiento que el boton de gestion de usuarios
        panelOpcionesCrudUsuario.Visible = False
        panelOpcionesCrudProductos.Visible = False
        panelOpcionesCrudClientes.Visible = False
        panelOpcionesCrudGasolina.Visible = True
        panelOpcionesCrudProveedores.Visible = False
    End Sub

    Private Sub btnGestionProveedores_Click(sender As Object, e As EventArgs) Handles btnGestionProveedores.Click
        'tendra el mismo comportamiento que el boton de gestion de usuarios
        panelOpcionesCrudUsuario.Visible = False
        panelOpcionesCrudProductos.Visible = False
        panelOpcionesCrudClientes.Visible = False
        panelOpcionesCrudGasolina.Visible = False
        panelOpcionesCrudProveedores.Visible = True
    End Sub
End Class