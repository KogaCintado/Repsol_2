Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class GestionesAdministrador

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    Private Sub GestionesAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'datagridviews a tomar por culo de forma guarra para que no se vean
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

        'Maximize the window
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Opciones.Show()
        Me.Hide()
    End Sub

    'Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.ProductosBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.Repsol_dbDataSet)

    'End Sub


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
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
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
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
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
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
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
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
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
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
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
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
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
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
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
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelBuscarGasolina()
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)
        panelBuscarProducto.Location = New Point(3000, 3000)
        panelBuscarProveedor.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarEmpleado.Location = New Point(3000, 3000)
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelBuscarProveedor()
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
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarEmpleado()

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
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)

    End Sub


    Private Sub invisivilizarTodosExceptoPanelEliminarGasolina()

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
        panelEliminarProducto.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)
        panelEliminarProveedores.Location = New Point(3000, 3000)

    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarProducto()

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
        panelEliminarProveedores.Location = New Point(3000, 3000)
        panelEliminarClientes.Location = New Point(3000, 3000)

    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarProveedor()
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

    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarCliente()
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

    Private Sub btnAccionModificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAccionModificarEmpleado.Click
        modificarEmpleado(tbIdEmpleado.Text, tbNombreEmpleado.Text, tbApellido1Empleado.Text, tbApellido2Empleado.Text, tbTelefonoEmpleado.Text, tbCorreoEmpleado.Text, tbContraseñaEmpleado.Text, tbAdministradorEmpleado.Text, tbCargoEmpleado.Text)
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
            MessageBox.Show("Error connecting to the database. Please check your database connection settings.")
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
            MessageBox.Show("Error connecting to the database. Please check your database connection settings.")
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
            MessageBox.Show("Error connecting to the database. Please check your database connection settings.")
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
            MessageBox.Show("Error connecting to the database. Please check your database connection settings.")
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
            MessageBox.Show("Error connecting to the database. Please check your database connection settings.")
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


    Public Sub modificarEmpleado(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As String, correo As String, contraseña As String, administrador As Integer, cargo As String)

        Dim cmd As New OleDbCommand("UPDATE Empleados SET Nombre = @nombre, [Apellido 1] = @apellido1, [Apellido 2] = @apellido2, Telefono = @telefono, Correo = @correo, Contraseña = @contraseña, Administrador = @administrador, Cargo = @cargo WHERE id = @id", conn)

        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@nombre", nombre)
        cmd.Parameters.AddWithValue("@apellido1", apellido1)
        cmd.Parameters.AddWithValue("@apellido2", apellido2)
        cmd.Parameters.AddWithValue("@telefono", telefono)
        cmd.Parameters.AddWithValue("@correo", correo)
        cmd.Parameters.AddWithValue("@contraseña", contraseña)
        cmd.Parameters.AddWithValue("@administrador", administrador)
        cmd.Parameters.AddWithValue("@cargo", cargo)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Empleado modificado correctamente")
        Catch ex As OleDbException
            MessageBox.Show("Error connecting to the database. Please check your database connection settings.")
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
            MessageBox.Show("Error connecting to the database. Please check your database connection settings.")
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
            MessageBox.Show("Error connecting to the database. Please check your database connection settings.")
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
            MessageBox.Show("Error connecting to the database. Please check your database connection settings.")
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
            MessageBox.Show("Error connecting to the database. Please check your database connection settings.")
        Finally
            conn.Close()
        End Try
    End Sub



    Public Sub EliminarProveedor(id As Integer)
        Dim cmd As New OleDbCommand("DELETE FROM Proveedores WHERE id = @id", conn)
        Try
            conn.Open()
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Proveedor eliminado correctamente")
        Catch ex As OleDbException
            MessageBox.Show("Error connecting to the database. Please check your database connection settings.")
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