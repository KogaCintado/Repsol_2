Imports System.Data.OleDb
Imports System.Data.SqlClient

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
        panelBuscarEmpleado.Location = New Point(3000, 3000)
        panelBuscarCliente.Location = New Point(3000, 3000)


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
    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeEmpleados()
        ProductosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeGasolinas()
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeProductos()
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ProveedoresDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeProveedores()
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        GasolinasDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)
        panelBuscarEmpleado.Location = New Point(3000, 3000)
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
        invisivilizarTodosExceptoDataGridDeProveedores()
    End Sub

    Private Sub btnSeleccionarUnEmpleado_Click(sender As Object, e As EventArgs) Handles btnSeleccionarUnEmpleado.Click
        panelBuscarEmpleado.Visible = True
        panelBuscarEmpleado.Location = New Point(476, 81)
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
        Dim GamaProducto As Integer
        idProducto = tbIdProducto.Text
        Dim producto As DataRow
        producto = BuscarProducto(idProducto)
        If producto Is Nothing Then
            MessageBox.Show("No existe un producto con ese id")
        Else
            tbNombreProducto.Text = producto("Nombre")
            tbPrecioProducto.Text = producto("Precio")
            tbProveedorProducto.Text = producto("Proveedor")
            GamaProducto = tbGamaProducto.Text
            GamaProducto = producto("Gama")
        End If
    End Sub



    Public Function BuscarEmpleado(id As Integer) As DataRow
        ' Crear una nueva instancia de la conexión a la base de datos
        ' Ensure that the server name, database name, and other connection properties are correct
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

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
        Try
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
        Catch ex As Exception
            MsgBox("Hubo un error con la busqueda del empleado, trate de introducir bien los datos : " & ex.Message)
        End Try
    End Sub

    Private Sub btnAccionBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarCliente.Click

        'En este boton lo que hacemos es buscar un Cliente por su id
        'Si el id no existe, mostramos un mensaje de error
        'Si el id existe, mostramos los datos del Cliente
        Try
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
        Catch ex As Exception
            MsgBox("Hubo un error con la busqueda del cliente, trate de introducir bien los datos : " & ex.Message)
        End Try


    End Sub

    Private Sub btnAccionBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarProducto.Click
        'En este boton lo que hacemos es buscar un Producto por su id
        'Si el id no existe, mostramos un mensaje de error
        'Si el id existe, mostramos los datos del Producto
        Try
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
        Catch ex As Exception
            MsgBox("Hubo un error con la busqueda del producto, trate de introducir bien los datos : " & ex.Message)
        End Try
    End Sub




    Private Sub btnAccionBuscarGasolina_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarGasolina.Click
        'En este boton lo que hacemos es buscar una Gasolina por su id
        'Si el id no existe, mostramos un mensaje de error
        'Si el id existe, mostramos los datos de la Gasolina
        Try
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
        Catch ex As Exception
            MsgBox("Hubo un error en la busqueda de la gasolina, trate de introducir bien los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAccionBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarProveedor.Click


        Try
            Dim idProveedor As Integer
            idProveedor = tbIdProveedor.Text
            Dim proveedor As DataRow
            proveedor = BuscarProveedor(idProveedor)
            If proveedor Is Nothing Then
                MessageBox.Show("No existe un proveedor con ese id")
            Else
                tbNombreProveedor.Text = proveedor("Nombre")
            End If
        Catch ex As Exception
            MsgBox("Hubo un error en la busqueda del proveedor, trate de introducir bien los datos: " & ex.Message)
        End Try
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

    Public Function BuscarCliente(id As Integer) As DataRow
        ' Crear una nueva instancia de la conexión a la base de datos
        ' Ensure that the server name, database name, and other connection properties are correct
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

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

    Public Function BuscarProducto(id As Integer) As DataRow
        ' Crear una nueva instancia de la conexión a la base de datos
        ' Ensure that the server name, database name, and other connection properties are correct
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

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

    Private Sub VolverToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Hide()
        Opciones.Show()
    End Sub


    '------------------------------------------------------------------------------------------------------------------------
    '--------------------------------Zona de validaciones de los textbox-----------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------

    Private Sub validarIDs(tb As TextBox)

        If tb.Text = "" Then
            MsgBox("El campo de ID no puede estar vacio")
        ElseIf Not IsNumeric(tb.Text) Then
            MsgBox("El campo de ID solo puede contener numeros")
            tb.Clear()
        End If
    End Sub

    Private Sub validarTelefonos(tb As TextBox)
        'en este metodo validamos que el texbox de telefono no este vacio. aparte
        'de que solo puede tener un prefijo (+) y numeros. En caso de que tenga mas de un (+)
        'o letras, mostraremos un mensaje de error. Para ello utilizaremos una lista con caracteres permitidos
        Dim permitidos As New List(Of Char) From {"+", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim comprobar As Boolean = False
        If tb.Text = "" Then
            MsgBox("El campo de telefono no puede estar vacio")
        Else
            For i As Integer = 0 To tb.Text.Length - 1
                If Not permitidos.Contains(tb.Text(i)) Then
                    comprobar = True
                End If
            Next
            If comprobar = True Then
                MsgBox("El campo de telefono solo puede contener numeros y el prefijo (+)")
                tb.Clear()
            End If
        End If
    End Sub

    Private Sub validarCorreos(tb As TextBox)
        'en este metodo validamos que el texbox de correo no este vacio. aparte
        'de que solo puede tener un @ y un punto. En caso de que tenga mas de un @
        'o mas de un punto, mostraremos un mensaje de error. Para ello utilizaremos una lista con caracteres permitidos
        Dim permitidos As New List(Of Char) From {"@", "."}
        Dim comprobar As Boolean = False
        If tb.Text = "" Then
            MsgBox("El campo de correo no puede estar vacio")
        Else
            For i As Integer = 0 To tb.Text.Length - 1
                If Not permitidos.Contains(tb.Text(i)) Then
                    comprobar = True
                End If
            Next
            If comprobar = True Then
                MsgBox("El campo de correo solo puede contener un @ y un punto")
                tb.Clear()
            End If
        End If
    End Sub

    End Sub

    Private Sub btnVerCliente_Click(sender As Object, e As EventArgs) Handles btnVerCliente.Click
        panelBuscarCliente.Location = New Point(476, 81)
    End Sub

End Class