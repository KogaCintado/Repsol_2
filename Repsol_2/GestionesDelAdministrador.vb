Imports System.Data.OleDb
Imports Biblioteca
Public Class GestionesDelAdministrador

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Dim validaciones As New Biblioteca.validacionesCrud
    Private Sub GestionesDelAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paneles = New List(Of Panel)({panelEmpleado, panelCliente, panelGasolina, panelProductos, panelProveedor})
        'Maximize the window
        Me.WindowState = FormWindowState.Maximized

        HelpProvider1.HelpNamespace = "config/Documento de ayuda TPV Repsol.chm"
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.Topic)
        HelpProvider1.SetHelpKeyword(Me, "CRUD.htm")

        ToolStripStatusLabel1.Text = Now.ToString("dd/MM/yy")
        invisibilizarTodos()
    End Sub
    'zona de funciones varias-----------
    '-----------------------------------


    'esta funcion se encarga de invisibilizar todos los paneles del formulario
    Private Sub invisibilizarTodos()
        Try
            'lo que hacemos es meter todos los paneles en un array e ir iterando invisibilizandolos a todos
            Dim paneles = New List(Of Panel)({panelEmpleado, panelCliente, panelGasolina, panelProductos, panelProveedor})
            For Each p As Panel In paneles
                p.Location = New Point(1920, 1080)
                p.Visible = False
            Next
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    'esta funcion invisibiliza todos los paneles excepto aquel que entra por argumento
    Private Sub invisibilizarTodosExcepto(pn As Panel)
        Try
            Dim paneles = New List(Of Panel)({panelEmpleado, panelCliente, panelGasolina, panelProductos, panelProveedor})
            For Each pan As Panel In paneles
                If Not pan Is pn Then
                    pan.Location = New Point(1920, 1080)
                    pan.Visible = False
                Else
                    pan.Location = New Point(250, 30)
                    pan.Visible = True
                End If
            Next
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try

    End Sub

    'esta funcion lo que se encarga sera en llamar al timer, habilitandolo para que falsee el progreso de la progress bar
    Private Sub falseoProgressBar()
        Try
            ToolStripProgressBar1.Value = 0
            Timer1.Enabled = True
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    'en esta funcion se falsea todo, para cada tiempo de reloj se rellena la mitad de la barra (hay que hacerlo rapido por que los ordenadores cargan rapido
    'y de otra forma no colaria)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try
            If ToolStripProgressBar1.Value < ToolStripProgressBar1.Maximum - 1 Then
                ToolStripProgressBar1.Value += 50
            Else
                Timer1.Enabled = False
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try

    End Sub

    'zona botones maestros---------------
    '------------------------------------
    'En esta seccion los botones llaman a su panel relacionado y ocultan el resto(todos y cada uno de los botones de esta seccion hacen los mismo)
    Private Sub btnGestionesEmpleado_Click(sender As Object, e As EventArgs) Handles btnGestionesEmpleado.Click
        Try
            invisibilizarTodosExcepto(panelEmpleado)
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnGestionesClientes_Click(sender As Object, e As EventArgs) Handles btnGestionesClientes.Click
        Try
            invisibilizarTodosExcepto(panelCliente)
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnGestionesProductos_Click(sender As Object, e As EventArgs) Handles btnGestionesProductos.Click
        Try
            invisibilizarTodosExcepto(panelProductos)
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnGestionesGasolinas_Click(sender As Object, e As EventArgs) Handles btnGestionesGasolinas.Click
        Try
            invisibilizarTodosExcepto(panelGasolina)
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnGestionesProveedores_Click(sender As Object, e As EventArgs) Handles btnGestionesProveedores.Click
        Try
            invisibilizarTodosExcepto(panelProveedor)
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    'zona busquedas-----------------------
    '-------------------------------------

    'esta funcion devuelve un datarow, esto nos sirve  a la hora de validaciones como puede
    'buscar la id o algo por el estilo, el  resto de funciones de este apartado tienen el mismo proposito
    'Buscar si es null o no lo devuelto y que ha devuelto
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
            MessageBox.Show("Hubo un error en la busqueda del cliente, trate de introducir bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, BuscarCliente()")
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
            MsgBox("Hubo un error con la conexion a la base de datos")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, BuscarEmpleado()")
            Return Nothing
        Catch ex As InvalidOperationException
            MessageBox.Show("Hubo un error en la busqueda del empleado, trate de introducir bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, BuscarEmpleado()")
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
        Catch ex As Exception
            MessageBox.Show("Hubo un error en la busqueda de los productos, trate de introducir bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, BuscarProducto()")
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
        Catch ex As Exception
            MessageBox.Show("Hubo un error en la busqueda de las gasolinas , introduzca correctamente los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, BuscarGasolina()")
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
        Catch ex As Exception
            MessageBox.Show("Hubo un error en la busqueda del proveedor, trate de introducir bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, BuscarProveedor()")
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

    'Zona datagrids-----------------------
    '-------------------------------------

    'el proposito de esta seccion es basicamente que cuando se de al boton de buscar se rellene el
    'DataGridView relacionado con este, permitiendo que se vea de manera rapida todo

    Private Sub MostrarTodosEmpleados()
        Try
            Dim cmd As New OleDbCommand("SELECT * FROM Empleados", conn) 'Sentencia sql para la busqueda
            Dim da As New OleDbDataAdapter(cmd) 'adaptador que permitira ejecutar la sentencia
            Dim dt As New DataTable() 'tabla que sera rellenada con los datos del adaptador por la sentencia
            da.Fill(dt)
            DatagridEmpleado.DataSource = dt 'aqui es donde se rellena
            DatagridEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la muestra de los empleados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, MostrarTodosEmpleados()")
        End Try
    End Sub


    Private Sub MostrarTodosClientes()
        Try
            Dim cmd As New OleDbCommand("Select * from Clientes", conn) 'Sentencia sql para la busqueda
            Dim da As New OleDbDataAdapter(cmd) 'adaptador que permitira ejecutar la sentencia
            Dim dt As New DataTable() 'tabla que sera rellenada con los datos del adaptador por la sentencia
            da.Fill(dt)
            ClientesDatagrid.DataSource = dt 'aqui es donde se rellena
            ClientesDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la muestra de los clientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, MostrarTodosClientes()")
        End Try
    End Sub

    Private Sub MostrarTodasGasolinas()
        Try
            Dim cmd As New OleDbCommand("Select * from Gasolinas", conn) 'Sentencia sql para la busqueda
            Dim da As New OleDbDataAdapter(cmd) 'adaptador que permitira ejecutar la sentencia
            Dim dt As New DataTable() 'tabla que sera rellenada con los datos del adaptador por la sentencia
            da.Fill(dt)
            GasolinasDatagrid.DataSource = dt 'aqui es donde se rellena
            GasolinasDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la muestra de las gasolinas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, MostrarTodasGasolinas()")
        End Try
    End Sub

    Private Sub MostrarTodosProductos()
        Try
            Dim cmd As New OleDbCommand("Select * from Productos", conn) 'Sentencia sql para la busqueda
            Dim da As New OleDbDataAdapter(cmd) 'adaptador que permitira ejecutar la sentencia
            Dim dt As New DataTable() 'tabla que sera rellenada con los datos del adaptador por la sentencia
            da.Fill(dt)
            ProductosDatagrid.DataSource = dt 'aqui es donde se rellena
            ProductosDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la muestra de los productos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, MostrarTodosProductos()")
        End Try
    End Sub

    Private Sub MostrarTodosProveedores()
        Try
            Dim cmd As New OleDbCommand("Select * from Proveedores", conn) 'Sentencia sql para la busqueda
            Dim da As New OleDbDataAdapter(cmd) 'adaptador que permitira ejecutar la sentencia
            Dim dt As New DataTable() 'tabla que sera rellenada con los datos del adaptador por la sentencia
            da.Fill(dt)
            ProveedorDataGrid.DataSource = dt 'aqui es donde se rellena
            ProveedorDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la muestra de proveedores", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, MostrarTodosProveedores()")
        End Try
    End Sub

    'zona agregaciones----------------------
    '---------------------------------------
    'Dentro de esta zona nos dedicaremos a agregar filas dentro de la tabla determinada

    Public Sub AgregarEmpleado(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As String, correo As String, contraseña As String, administrador As Integer, cargo As String)
        Try
            conn.Open() 'se abre la conexion
            Using cmd As New OleDbCommand("Insert into Empleados([id], [Nombre], [Apellido 1], [Apellido 2], [Telefono], [Correo], [Contraseña], [Administrador], [Cargo]) 
            values (?, ?, ?, ?, ?, ?, ?, ?, ?)", conn) 'la consulta sql se hace con una busqueda parametrizada para evitar sql injections (y por que es mas facil)
                cmd.Parameters.Add(New OleDbParameter("id", id)) 'a partir de aqui se van agregando uno a uno los parametros de las ? en orden con su clave para reconocerse
                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.Parameters.Add(New OleDbParameter("apellido1", apellido1))
                cmd.Parameters.Add(New OleDbParameter("apellido2", apellido2))
                cmd.Parameters.Add(New OleDbParameter("telefono", telefono))
                cmd.Parameters.Add(New OleDbParameter("correo", correo))
                cmd.Parameters.Add(New OleDbParameter("contraseña", contraseña))
                cmd.Parameters.Add(New OleDbParameter("administrador", administrador))
                cmd.Parameters.Add(New OleDbParameter("cargo", cargo))
                If Not administrador = 2 Then
                    cmd.ExecuteNonQuery() 'se ejecuta la sentencia en caso de que no sea administrador el que estamos apunto de crear
                    MessageBox.Show("El empleado se a creado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("No se permiten crear jefes, solamente administradores y trabajadores", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la agregacion del empleado, trate de introducir los datos correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, AgregarEmpleado()")
        Finally
            conn.Close() 'se cierra la conexion
        End Try
    End Sub

    Public Sub AgregarProducto(id As Integer, nombre As String, precio As Single, proveedor As Integer, gama As Integer)
        Try
            conn.Open()
            Dim prov As DataRow = BuscarProveedor(proveedor)
            If prov Is Nothing Then 'se verifica que el proveedor exista
                MessageBox.Show("El proveedor del producto a agregar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Using cmd As New OleDbCommand("Insert into Productos([id],[Nombre],[Precio],[Proveedor],[Gama])
                values(?,?,?,?,?)", conn) 'la consulta sql se hace con una busqueda parametrizada para evitar sql injections (y por que es mas facil)
                    cmd.Parameters.Add(New OleDbParameter("id", id)) 'a partir de aqui se van agregando uno a uno los parametros de las ? en orden con su clave para reconocerse
                    cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                    cmd.Parameters.Add(New OleDbParameter("precio", precio))
                    cmd.Parameters.Add(New OleDbParameter("proveedor", proveedor))
                    cmd.Parameters.Add(New OleDbParameter("gama", gama))
                    cmd.ExecuteNonQuery() 'se ejecuta la sentencia
                    MsgBox("Se agrego el producto " & nombre & " correctamente")
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la agregacion del producto, trate de introducir los datos correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, AgregarProducto()")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub AgregarCliente(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As String, correo As String, fecha As Date, alta As Integer)
        Try
            conn.Open()
            Using cmd As New OleDbCommand("Insert into Clientes([id],[Nombre],[Apellido 1],[Apellido 2],[Telefono],[Correo],[FechaAlta],[Alta])
                values(?, ?, ?, ?, ?, ?, ?, ?)", conn) 'la consulta sql se hace con una busqueda parametrizada para evitar sql injections (y por que es mas facil)
                cmd.Parameters.Add(New OleDbParameter("id", id)) 'a partir de aqui se van agregando uno a uno los parametros de las ? en orden con su clave para reconocerse
                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.Parameters.Add(New OleDbParameter("apellido1", apellido1))
                cmd.Parameters.Add(New OleDbParameter("apellido2", apellido2))
                cmd.Parameters.Add(New OleDbParameter("telefono", telefono))
                cmd.Parameters.Add(New OleDbParameter("correo", correo))
                cmd.Parameters.Add(New OleDbParameter("fechaAlta", fecha))
                cmd.Parameters.Add(New OleDbParameter("alta", alta))
                cmd.ExecuteNonQuery() 'se ejecuta la consulta
                MsgBox("Se agrego el cliente: " & nombre)
            End Using
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la agregacion del cliente, trate de introducir los datos correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, AgregarCliente()")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub AgregarProveedor(id As Integer, nombre As String)
        Try
            conn.Open()
            Using cmd As New OleDbCommand("Insert into Proveedores([id], [Nombre]) Values(?, ?)", conn) 'la consulta sql se hace con una busqueda parametrizada para evitar sql injections (y por que es mas facil)
                cmd.Parameters.Add(New OleDbParameter("id", id)) 'a partir de aqui se van agregando uno a uno los parametros de las ? en orden con su clave para reconocerse
                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.ExecuteNonQuery() 'se ejecuta la consulta
                MsgBox("Se agrego el proveedor: " & nombre)
            End Using
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la agregacion del proveedor, trate de introduir bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, AgregarProveedor()")
        Finally
            conn.Close()
        End Try
    End Sub

    'zona Modificaciones------------------------------
    '-------------------------------------------------

    'en esta zona se realizan consultas de modificacion, para que se puedan actualizar los valores de cada uno de los
    'campos de las tablas (altas, precios, cantidad, etc.)

    Private Sub ModificarEmpleado(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As String, correo As String, contraseña As String, cargo As String, administrador As Integer)
        Try
            Dim comprobar As Boolean = False
            conn.Open()
            Using cmd0 As New OleDbCommand("Select Administrador from Empleados where id = @id", conn)
                cmd0.Parameters.AddWithValue("@id", id)
                Dim reader As OleDbDataReader = cmd0.ExecuteReader()
                If reader.HasRows() Then 'se ejecuta una validacion dentro del metodo para verificar si es jefe o no
                    While reader.Read()
                        If reader("Administrador").ToString() = 2 Then
                            comprobar = True
                        End If
                    End While
                End If
            End Using
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
                If comprobar = True Then
                    MessageBox.Show("No se pudo hacer la modificacion ya que el jefe no se puede modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    cmd.ExecuteNonQuery() 'en caso de que todo este correcto se hara la actualizacion
                    MsgBox("Usuario actualizado con exito")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la modificacion del Empleado, trate de introducir bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, ModificarEmpleado()")
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub ModificarCliente(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As String, correo As String, fechaAlta As Date, alta As Integer)
        Try
            conn.Open()
            Dim cl As DataRow = BuscarCliente(id)
            If cl Is Nothing Then 'se hace una validacion para verificar que el cliente realmente exista, y no modifiquemos al aire
                MessageBox.Show("El cliente a actualizar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Using cmd As New OleDbCommand("Update Clientes set Nombre = ?, [Apellido 1] = ?, [Apellido 2]  = ?,
                Telefono = ?, Correo = ?, FechaAlta = ?, Alta = ? where id = ?", conn)
                    cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                    cmd.Parameters.Add(New OleDbParameter("apellido1", apellido1))
                    cmd.Parameters.Add(New OleDbParameter("apellido2", apellido2))
                    cmd.Parameters.Add(New OleDbParameter("telefono", telefono))
                    cmd.Parameters.Add(New OleDbParameter("correo", correo))
                    cmd.Parameters.Add(New OleDbParameter("fechaAlta", fechaAlta))
                    cmd.Parameters.Add(New OleDbParameter("alta", alta))
                    cmd.Parameters.Add(New OleDbParameter("id", id))
                    cmd.ExecuteNonQuery() 'si todo sale correcto se modifica el cliente
                    MessageBox.Show("El cliente se actualizo correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la actualizacion del cliente, trate de introducir bien los datos" & ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, ModificarCliente()")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ModificarProductos(id As Integer, nombre As String, precio As Single, proveedor As Integer, gama As Integer)
        Try
            conn.Open()
            Dim comprobar As Boolean = False
            Dim prov As DataRow = BuscarProveedor(proveedor) 'se valida que el proveedor exista a la hora de modificarlo
            If Not prov Is Nothing Then
                comprobar = True
            Else
                comprobar = False
            End If

            Dim comprobar2 As Boolean = False
            Using cmd1 As New OleDbCommand("Select id from Gamas where id = @id", conn) 'se comprueba que exista la gama
                cmd1.Parameters.AddWithValue("@id", gama)

                Dim reader As OleDbDataReader = cmd1.ExecuteReader()
                If reader.HasRows() Then
                    While reader.Read()
                        If reader("id").ToString() = gama Then
                            comprobar2 = True
                        End If
                    End While
                Else
                    comprobar2 = False
                End If

            End Using

            Dim comprobar3 As Boolean = False
            Dim prod As DataRow = BuscarProducto(id) 'se comprueba que exista el producto
            If prod Is Nothing Then
                comprobar3 = False
            Else
                comprobar3 = True
            End If

            Using cmd As New OleDbCommand("Update Productos set nombre = @nombre, precio = @precio, proveedor = @proveedor, gama = @gama where id = @id", conn)
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@precio", precio)
                cmd.Parameters.AddWithValue("@proveedor", proveedor)
                cmd.Parameters.AddWithValue("@gama", gama)
                cmd.Parameters.AddWithValue("@id", id)
                If comprobar = True And comprobar2 = True And comprobar3 = True Then
                    cmd.ExecuteNonQuery() 'en caso de que todo este correcto se actualizara
                    MessageBox.Show("El producto se actualizo correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("No se pudo hacer la actualizacion del producto, verifique los datos introducidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

        Catch ex As Exception

            MessageBox.Show("Hubo un error con la modificacion del producto, introduzca bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, ModificarProducto()")

        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub ModificarGasolina(id As Integer, nombre As String, cantidad As Integer, precio As Single)
        Try
            conn.Open()

            Dim gas As DataRow = BuscarGasolina(id)
            If gas Is Nothing Then 'se valida que existe la gasolina
                MessageBox.Show("La gasolina a modificar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Using cmd As New OleDbCommand("Update Gasolinas set nombre = ?, cantidad = ?, precio = ? where id = ?", conn)

                    cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                    cmd.Parameters.Add(New OleDbParameter("cantidad", cantidad))
                    cmd.Parameters.Add(New OleDbParameter("precio", precio))
                    cmd.Parameters.Add(New OleDbParameter("id", id))
                    cmd.ExecuteNonQuery() ' en caso de que todo este bien se actualiza
                    MessageBox.Show("La gasolina se actualizo correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Hubo un error con la modificacion de la gasolina, introduzca bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, ModificarGasolina()")
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub ModificarProveedores(id As Integer, nombre As String)

        Try

            conn.Open()
            Dim prov As DataRow = BuscarProveedor(id)
            If prov Is Nothing Then 'se verifica que el proveedor existe
                MessageBox.Show("El proveedor a modificar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Using cmd As New OleDbCommand("Update Proveedores set nombre = ? where id = ?", conn)

                    cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                    cmd.Parameters.Add(New OleDbParameter("id", id))
                    cmd.ExecuteNonQuery() 'en caso de que todo este bien se modifica
                    MessageBox.Show("El proveedor se actualizo con exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error a la hora modificar el proveedor, introduzca bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, ModificarProveedor()")
        Finally
            conn.Close()
        End Try
    End Sub

    'zona eliminaciones--------------
    '--------------------------------
    'en esta zona se hacen eliminaciones basadas en su identificado, es simple
    'si no existe no se eliminara nada, haciendolo asi nos aseguramos de que no se
    'borren mas de uno ya que el id es unico, inmutable e induplicable

    Public Sub EliminarEmpleado(id As Integer)
        Try
            conn.Open()
            Dim empleado As DataRow = BuscarEmpleado(id) 'verificamos que existe lo que vamos a eliminar
            If empleado Is Nothing Then
                MessageBox.Show("El Empleado a eliminar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim comprobar As Boolean = False
                Using cmd0 As New OleDbCommand("Select Administrador from Empleados where id = @id", conn)
                    cmd0.Parameters.AddWithValue("@id", id)

                    Dim reader As OleDbDataReader = cmd0.ExecuteReader()
                    If reader.HasRows() Then
                        While reader.Read()
                            If reader("Administrador").ToString() = 2 Then 'verificamos que no sea el jefe ya que es inmutable
                                comprobar = True
                            End If
                        End While
                    End If

                End Using

                Dim cmd As New OleDbCommand("DELETE FROM Empleados WHERE id = @id", conn)
                cmd.Parameters.AddWithValue("@id", id)

                If comprobar = True Then
                    MsgBox("No se puede hacer la eliminacion ya que se trata del jefe")
                Else
                    cmd.ExecuteNonQuery() 'se ejecuta en caso de que todo sea correcto
                    MessageBox.Show("Empleado eliminado correctamente")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error a la hora de eliminar empleado, introduzca bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, EliminarEmpleado()")
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub EliminarCliente(id As Integer)
        Dim cmd As New OleDbCommand("DELETE FROM Clientes WHERE id = @id", conn)
        Try
            conn.Open()
            Dim cliente As DataRow = BuscarCliente(id)
            If cliente Is Nothing Then 'verificamos que el cliente exista
                MessageBox.Show("El cliente a eliminar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery() 'en caso de que todo este correcto se ejectuta la sentencia
                MessageBox.Show("Cliente eliminado correctamente")
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la eliminacion del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, ElminarCliente()")
        Finally
            conn.Close()
        End Try

    End Sub

    Public Sub EliminarProducto(id As Integer)
        Dim cmd As New OleDbCommand("DELETE FROM Productos WHERE id = @id", conn)
        Try
            conn.Open()
            Dim producto As DataRow = BuscarProducto(id) 'se verifica que el producto exista
            If producto Is Nothing Then
                MessageBox.Show("El producto a eliminar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery() 'se la sentencia
                MessageBox.Show("Producto eliminado correctamente")
            End If
        Catch ex As OleDbException
            MessageBox.Show("Hubo un error con la eliminacion del producto, introduzca bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, EliminarProducto()")
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub EliminarProveedor(id As Integer)
        Dim cmd As New OleDbCommand("DELETE FROM Productos Where proveedor = @id", conn)
        Dim cmd2 As New OleDbCommand("DELETE FROM Proveedores WHERE id = @id", conn)
        Try
            conn.Open()

            Dim proveedor As DataRow = BuscarProveedor(id) 'se verifica que exista el proveedor
            If proveedor Is Nothing Then
                MessageBox.Show("El proveedor a eliminar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery() 'se ejecuta la sentencia de eliminacion de los productos relacionados con ese proveedor(el id de este)

                cmd2.Parameters.AddWithValue("@id", id)
                cmd2.ExecuteNonQuery() 'se ejecuta la sentencia de eliminacion del proveedor
                MessageBox.Show("Proveedor eliminado correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Hubo un error con la eliminacion del proveedor, introduzca bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, EliminarProveedor()")
        Finally
            conn.Close()
        End Try

    End Sub



    'zona botones de accion------------
    '----------------------------------

    'esta es la zona donde se hacen todas y las operaciones (cuando pulsamos un boton)
    'en funcion del tipo de boton que sea (busqueda, agregacion, etc) se ejecuta una funcion u otra
    'de las vistas anteriormente. Todos y cada uno de los botones tienen validaciones para que en caso de que los 
    'datos introducidos sean incorrectos se impida la operacion. Dichas validaciones vienen de la libreria de clases
    ' "Biblioteca"

    Private Sub btnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbIdEmpleado, tbIdEmpleado.Text)
            Dim validacion2 As Boolean = validaciones.validarCorreos(tbCorreoEmpleado, tbCorreoEmpleado.Text)
            Dim validacion3 As Boolean = validaciones.validarTelefonos(tbTelefonoEmpleado, tbTelefonoEmpleado.Text)
            Dim validacion4 As Boolean = validaciones.validarContraseñas(tbContraseñaEmpleado, tbContraseñaEmpleado.Text)
            Dim validacion5 As Boolean = validaciones.validarNOmbreYApellidos(tbNombreEmpleado, tbNombreEmpleado.Text)
            Dim validacion6 As Boolean = validaciones.validarNOmbreYApellidos(tbApellido1Empleado, tbApellido1Empleado.Text)
            Dim validacion7 As Boolean = validaciones.validarNOmbreYApellidos(tbApellido2Empleado, tbApellido2Empleado.Text)
            Dim validacion8 As Boolean = validaciones.validarAdministrador(tbAdministradorEmpleado, tbAdministradorEmpleado.Text)

            If validacion1 = False And validacion2 = False And validacion3 = False And validacion4 = False And validacion5 = False And validacion6 = False And validacion7 = False And validacion8 = False Then
                falseoProgressBar()
                AgregarEmpleado(tbIdEmpleado.Text, tbNombreEmpleado.Text, tbApellido1Empleado.Text, tbApellido2Empleado.Text,
                            tbTelefonoEmpleado.Text, tbCorreoEmpleado.Text, tbContraseñaEmpleado.Text, tbAdministradorEmpleado.Text, tbCargoEmpleado.Text)
                limpiarEmpleado()
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnModificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnModificarEmpleado.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbIdEmpleado, tbIdEmpleado.Text)
            Dim validacion2 As Boolean = validaciones.validarCorreos(tbCorreoEmpleado, tbCorreoEmpleado.Text)
            Dim validacion3 As Boolean = validaciones.validarTelefonos(tbTelefonoEmpleado, tbTelefonoEmpleado.Text)
            Dim validacion4 As Boolean = validaciones.validarContraseñas(tbContraseñaEmpleado, tbContraseñaEmpleado.Text)
            Dim validacion5 As Boolean = validaciones.validarNOmbreYApellidos(tbNombreEmpleado, tbNombreEmpleado.Text)
            Dim validacion6 As Boolean = validaciones.validarNOmbreYApellidos(tbApellido1Empleado, tbApellido1Empleado.Text)
            Dim validacion7 As Boolean = validaciones.validarNOmbreYApellidos(tbApellido2Empleado, tbApellido2Empleado.Text)
            Dim validacion8 As Boolean = validaciones.validarAdministrador(tbAdministradorEmpleado, tbAdministradorEmpleado.Text)
            If validacion1 = False And validacion2 = False And validacion3 = False And validacion4 = False And validacion5 = False And validacion6 = False And validacion7 = False And validacion8 = False Then
                falseoProgressBar()
                ModificarEmpleado(tbIdEmpleado.Text, tbNombreEmpleado.Text, tbApellido1Empleado.Text, tbApellido2Empleado.Text, tbTelefonoEmpleado.Text, tbCorreoEmpleado.Text,
                            tbContraseñaEmpleado.Text, tbCargoEmpleado.Text, tbAdministradorEmpleado.Text)
                limpiarEmpleado()
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btnEliminarEmpleado.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbIdEmpleado, tbIdEmpleado.Text)
            If validacion1 = False Then
                falseoProgressBar()
                EliminarEmpleado(tbIdEmpleado.Text)
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        Try
            falseoProgressBar()
            MostrarTodosEmpleados()
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Try
            falseoProgressBar()
            MostrarTodosClientes()
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbIdCliente, tbIdCliente.Text)
            Dim validacion2 As Boolean = validaciones.validarCorreos(tbCorreoCliente, tbCorreoCliente.Text)
            Dim validacion3 As Boolean = validaciones.validarTelefonos(tbTelefonoCliente, tbTelefonoCliente.Text)
            Dim validacion5 As Boolean = validaciones.validarNOmbreYApellidos(tbNombreCliente, tbNombreCliente.Text)
            Dim validacion6 As Boolean = validaciones.validarNOmbreYApellidos(tbApellido1Cliente, tbApellido1Cliente.Text)
            Dim validacion7 As Boolean = validaciones.validarNOmbreYApellidos(tbApellido2Cliente, tbApellido2Cliente.Text)
            Dim validacion8 As Boolean = validaciones.validarAlta(tbAltaCliente, tbAltaCliente.Text)

            If validacion1 = False And validacion2 = False And validacion3 = False And validacion5 = False And validacion6 = False And validacion7 = False And validacion8 = False Then
                falseoProgressBar()
                AgregarCliente(tbIdCliente.Text, tbNombreCliente.Text, tbApellido1Cliente.Text, tbApellido2Cliente.Text, tbTelefonoCliente.Text, tbCorreoCliente.Text, FechaAltaClienteTimePicker.Value.Date, tbAltaCliente.Text)
                limpiarCliente()
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbIdCliente, tbIdCliente.Text)
            Dim validacion2 As Boolean = validaciones.validarCorreos(tbCorreoCliente, tbCorreoCliente.Text)
            Dim validacion3 As Boolean = validaciones.validarTelefonos(tbTelefonoCliente, tbTelefonoCliente.Text)
            Dim validacion5 As Boolean = validaciones.validarNOmbreYApellidos(tbNombreCliente, tbNombreCliente.Text)
            Dim validacion6 As Boolean = validaciones.validarNOmbreYApellidos(tbApellido1Cliente, tbApellido1Cliente.Text)
            Dim validacion7 As Boolean = validaciones.validarNOmbreYApellidos(tbApellido2Cliente, tbApellido2Cliente.Text)
            Dim validacion8 As Boolean = validaciones.validarAlta(tbAltaCliente, tbAltaCliente.Text)
            If validacion1 = False And validacion2 = False And validacion3 = False And validacion5 = False And validacion6 = False And validacion7 = False And validacion8 = False Then
                falseoProgressBar()
                ModificarCliente(tbIdCliente.Text, tbNombreCliente.Text, tbApellido1Cliente.Text, tbApellido2Cliente.Text, tbTelefonoCliente.Text,
                tbCorreoCliente.Text, FechaAltaClienteTimePicker.Value.Date, tbAltaCliente.Text)
                limpiarCliente()
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbIdCliente, tbIdCliente.Text)
            If validacion1 = False Then
                falseoProgressBar()
                EliminarCliente(tbIdCliente.Text)
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Try
            falseoProgressBar()
            MostrarTodosProductos()
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbGamaProducto, tbGamaProducto.Text)
            Dim validacion2 As Boolean = validaciones.validarPrecio(tbPrecioProducto, tbPrecioProducto.Text)
            Dim validacion3 As Boolean = validaciones.validarGama(tbGamaProducto, tbGamaProducto.Text)
            Dim validacion4 As Boolean = validaciones.validarProveedor(tbProveedorProducto, tbProveedorProducto.Text)
            If validacion1 = False And validacion2 = False And validacion3 = False And validacion4 = False Then
                falseoProgressBar()
                AgregarProducto(tbIdProducto.Text, tbNombreProducto.Text, tbPrecioProducto.Text, tbProveedorProducto.Text, tbGamaProducto.Text)
                limpiarProducto()
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnModificarProducto_Click(sender As Object, e As EventArgs) Handles btnModificarProducto.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbIdProducto, tbIdProducto.Text)
            Dim validacion2 As Boolean = validaciones.validarPrecio(tbPrecioProducto, tbPrecioProducto.Text)
            Dim validacion3 As Boolean = validaciones.validarGama(tbGamaProducto, tbGamaProducto.Text)
            If validacion1 = False And validacion2 = False And validacion3 = False Then
                falseoProgressBar()
                ModificarProductos(tbIdProducto.Text, tbNombreProducto.Text, tbPrecioProducto.Text, tbProveedorProducto.Text, tbGamaProducto.Text)
                limpiarProducto()
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbIdProducto, tbIdProducto.Text)
            If validacion1 = False Then
                falseoProgressBar()
                EliminarProducto(tbIdProducto.Text)
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnBuscarGasolina_Click(sender As Object, e As EventArgs) Handles btnBuscarGasolina.Click
        Try
            falseoProgressBar()
            MostrarTodasGasolinas()
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnModificarGasolina_Click(sender As Object, e As EventArgs) Handles btnModificarGasolina.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbIdGasolina, tbIdGasolina.Text)
            Dim validacion2 As Boolean = validaciones.validarCantidad(tbCantidadGasolina, tbCantidadGasolina.Text)
            Dim validacion3 As Boolean = validaciones.validarPrecio(tbPrecioGasolina, tbPrecioGasolina.Text)
            If validacion1 = False And validacion2 = False And validacion3 = False Then
                falseoProgressBar()
                ModificarGasolina(tbIdGasolina.Text, tbNombreGasolina.Text, tbCantidadGasolina.Text, tbPrecioGasolina.Text)
                limpiarGasolina()
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        Try
            falseoProgressBar()
            MostrarTodosProveedores()
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbIdProveedor, tbIdProveedor.Text)
            Dim validacion2 As Boolean = validaciones.validarNombreEmpresa(tbNombreProveedor, tbNombreProveedor.Text)
            If validacion1 = False And validacion2 = False Then
                falseoProgressBar()
                AgregarProveedor(tbIdProveedor.Text, tbNombreProveedor.Text)
                limpiarProveedor()
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnModificarProveedor_Click(sender As Object, e As EventArgs) Handles btnModificarProveedor.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbIdProveedor, tbIdProveedor.Text)
            Dim validacion2 As Boolean = validaciones.validarNombreEmpresa(tbNombreProveedor, tbNombreProveedor.Text)
            If validacion1 = False And validacion2 = False Then
                falseoProgressBar()
                ModificarProveedores(tbIdProveedor.Text, tbNombreProveedor.Text)
                limpiarProveedor()
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub btnEliminarProveedor_Click(sender As Object, e As EventArgs) Handles btnEliminarProveedor.Click
        Try
            Dim validacion1 As Boolean = validaciones.validarIDs(tbIdProveedor, tbIdProveedor.Text)
            If validacion1 = False Then
                falseoProgressBar()
                EliminarProveedor(tbIdProveedor.Text)
            End If
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    'zona menusStrip-------------
    '----------------------------
    'aqui controlamos el salir del formulario, deslogearnos y cerrar el programa.
    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub CerrarProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarProgramaToolStripMenuItem.Click
        End
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Opciones.Show()
        Me.Close()
    End Sub
    'zona funciones de limpieza--------------
    '----------------------------------------


    'estas funciones se dedican a limpiar los campos de cada uno de las gestiones
    '(productos, clientes, etc.) cada vez que se haga una agregacion o una eliminacion

    Private Sub limpiarEmpleado()
        Try
            tbIdEmpleado.Clear()
            tbNombreEmpleado.Clear()
            tbApellido1Empleado.Clear()
            tbApellido2Empleado.Clear()
            tbTelefonoEmpleado.Clear()
            tbCorreoEmpleado.Clear()
            tbAdministradorEmpleado.Clear()
            tbCargoEmpleado.Clear()
            tbContraseñaEmpleado.Clear()
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub limpiarCliente()
        Try
            tbIdCliente.Clear()
            tbNombreCliente.Clear()
            tbApellido1Cliente.Clear()
            tbApellido2Cliente.Clear()
            tbTelefonoCliente.Clear()
            tbCorreoCliente.Clear()
            tbAltaCliente.Clear()
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub limpiarProducto()
        Try
            tbIdProducto.Clear()
            tbNombreProducto.Clear()
            tbPrecioProducto.Clear()
            tbGamaProducto.Clear()
            tbProveedorProducto.Clear()
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub limpiarProveedor()
        Try
            tbIdProveedor.Clear()
            tbNombreProveedor.Clear()
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub

    Private Sub limpiarGasolina()
        Try
            tbIdGasolina.Clear()
            tbNombreGasolina.Clear()
            tbPrecioGasolina.Clear()
            tbCantidadGasolina.Clear()
        Catch ex As Exception
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "CRUD")
        End Try
    End Sub
End Class