Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class GestionesAdministrador
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

        'Maximize the window
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
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
    End Sub


    Private Sub btnVerTodosProductos_Click(sender As Object, e As EventArgs) Handles btnVerTodosProductos.Click
        'TODO: This line of code loads data into the 'Repsol_dbDataSet.Productos' table. You can move, or remove it, as needed.
        Me.ProductosTableAdapter.Fill(Me.Repsol_dbDataSet.Productos)
        ProductosDataGridView.Visible = True
        ProductosDataGridView.Location = New Point(476, 81)
        invisivilizarTodosExceptoDataGridDeProductos()
    End Sub

    Private Sub btnVerTodosEmpleados_Click(sender As Object, e As EventArgs) Handles btnVerTodosEmpleados.Click
        'TODO: This line of code loads data into the 'Repsol_dbDataSet.Empleados' table. You can move, or remove it, as needed.
        Me.EmpleadosTableAdapter.Fill(Me.Repsol_dbDataSet.Empleados)
        EmpleadosDataGridView.Visible = True
        EmpleadosDataGridView.Location = New Point(476, 81)
        invisivilizarTodosExceptoDataGridDeEmpleados()
    End Sub

    Private Sub btnVerTodosClientes_Click(sender As Object, e As EventArgs) Handles btnVerTodosClientes.Click
        'TODO: This line of code loads data into the 'Repsol_dbDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.Repsol_dbDataSet.Clientes)
        ClientesDataGridView.Visible = True
        ClientesDataGridView.Location = New Point(476, 81)
        invisivilizarTodosExceptoDataGridDeClientes()
    End Sub

    Private Sub btnVerTodasGasolinas_Click(sender As Object, e As EventArgs) Handles btnVerTodasGasolinas.Click
        'TODO: This line of code loads data into the 'Repsol_dbDataSet.Gasolinas' table. You can move, or remove it, as needed.
        Me.GasolinasTableAdapter.Fill(Me.Repsol_dbDataSet.Gasolinas)
        GasolinasDataGridView.Visible = True
        GasolinasDataGridView.Location = New Point(476, 81)
        invisivilizarTodosExceptoDataGridDeGasolinas()
    End Sub

    Private Sub btnVerTodosProveedores_Click(sender As Object, e As EventArgs) Handles btnVerTodosProveedores.Click
        'TODO: This line of code loads data into the 'Repsol_dbDataSet.Proveedores' table. You can move, or remove it, as needed.
        Me.ProveedoresTableAdapter.Fill(Me.Repsol_dbDataSet.Proveedores)
        ProveedoresDataGridView.Visible = True
        ProveedoresDataGridView.Location = New Point(476, 81)
        invisivilizarTodosExceptoDataGridDeProveedores()
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

    Public Function BuscarGasolina(id As Integer) As DataRow

        ' Crear una nueva instancia de la conexión a la base de datos
        ' Ensure that the server name, database name, and other connection properties are correct
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

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

        ' Crear una nueva instancia de la conexión a la base de datos
        ' Ensure that the server name, database name, and other connection properties are correct
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

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