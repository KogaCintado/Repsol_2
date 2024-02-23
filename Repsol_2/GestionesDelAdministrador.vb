Imports System.Data.OleDb
Imports Biblioteca
Public Class GestionesDelAdministrador

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    Private Sub GestionesDelAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paneles = New List(Of Panel)({panelEmpleado, panelCliente, panelGasolina, panelProductos, panelProveedor})
        'Maximize the window
        Me.WindowState = FormWindowState.Maximized

        ToolStripStatusLabel1.Text = Now.ToString("dd/MM/yy")
        invisibilizarTodos()
    End Sub
    'zona de funciones varias-----------
    '-----------------------------------

    Private Sub invisibilizarTodos()
        Dim paneles = New List(Of Panel)({panelEmpleado, panelCliente, panelGasolina, panelProductos, panelProveedor})
        For Each p As Panel In paneles
            p.Location = New Point(1920, 1080)
            p.Visible = False
        Next
    End Sub

    Private Sub invisibilizarTodosExcepto(pn As Panel)
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

    End Sub

    Private Sub falseoProgressBar()
        ToolStripProgressBar1.Value = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ToolStripProgressBar1.Value < ToolStripProgressBar1.Maximum - 1 Then
            ToolStripProgressBar1.Value += 50
        Else
            Timer1.Enabled = False
        End If

    End Sub

    'zona botones maestros---------------
    '------------------------------------
    Private Sub btnGestionesEmpleado_Click(sender As Object, e As EventArgs) Handles btnGestionesEmpleado.Click
        invisibilizarTodosExcepto(panelEmpleado)
    End Sub

    Private Sub btnGestionesClientes_Click(sender As Object, e As EventArgs) Handles btnGestionesClientes.Click
        invisibilizarTodosExcepto(panelCliente)
    End Sub

    Private Sub btnGestionesProductos_Click(sender As Object, e As EventArgs) Handles btnGestionesProductos.Click
        invisibilizarTodosExcepto(panelProductos)
    End Sub

    Private Sub btnGestionesGasolinas_Click(sender As Object, e As EventArgs) Handles btnGestionesGasolinas.Click
        invisibilizarTodosExcepto(panelGasolina)
    End Sub

    Private Sub btnGestionesProveedores_Click(sender As Object, e As EventArgs) Handles btnGestionesProveedores.Click
        invisibilizarTodosExcepto(panelProveedor)
    End Sub

    'zona busquedas-----------------------
    '-------------------------------------

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
    Private Sub MostrarTodosEmpleados()
        Try
            Dim cmd As New OleDbCommand("SELECT * FROM Empleados", conn)
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            DatagridEmpleado.DataSource = dt
            DatagridEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la muestra de los empleados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, MostrarTodosEmpleados()")
        End Try
    End Sub


    Private Sub MostrarTodosClientes()
        Try
            Dim cmd As New OleDbCommand("Select * from Clientes", conn)
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            ClientesDatagrid.DataSource = dt
            ClientesDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la muestra de los clientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, MostrarTodosClientes()")
        End Try
    End Sub

    Private Sub MostrarTodasGasolinas()
        Try
            Dim cmd As New OleDbCommand("Select * from Gasolinas", conn)
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            GasolinasDatagrid.DataSource = dt
            GasolinasDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la muestra de las gasolinas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, MostrarTodasGasolinas()")
        End Try
    End Sub


    Private Sub MostrarTodosProductos()
        Try
            Dim cmd As New OleDbCommand("Select * from Productos", conn)
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            ProductosDatagrid.DataSource = dt
            ProductosDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la muestra de los productos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, MostrarTodosProductos()")
        End Try
    End Sub

    Private Sub MostrarTodosProveedores()
        Try
            Dim cmd As New OleDbCommand("Select * from Proveedores", conn)
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            'ProveedoresDataGridView.DataSource = dt
            'ProveedoresDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la muestra de proveedores", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, MostrarTodosProveedores()")
        End Try
    End Sub


    'zona agregaciones----------------------
    '---------------------------------------
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
                If Not administrador = 2 Then
                    cmd.ExecuteNonQuery()
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
            conn.Close()
        End Try
    End Sub

    Public Sub AgregarProducto(id As Integer, nombre As String, precio As Single, proveedor As Integer, gama As Integer)

        Try

            conn.Open()
            Dim prov As DataRow = BuscarProveedor(proveedor)
            If prov Is Nothing Then
                MessageBox.Show("El proveedor del producto a agregar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
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

            Using cmd As New OleDbCommand("Insert into Proveedores([id], [Nombre]) Values(?, ?)", conn)

                cmd.Parameters.Add(New OleDbParameter("id", id))
                cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                cmd.ExecuteNonQuery()
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

    Private Sub ModificarEmpleado(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As String, correo As String, contraseña As String, cargo As String, administrador As Integer)

        Try
            Dim comprobar As Boolean = False
            conn.Open()

            Using cmd0 As New OleDbCommand("Select Administrador from Empleados where id = @id", conn)
                cmd0.Parameters.AddWithValue("@id", id)

                Dim reader As OleDbDataReader = cmd0.ExecuteReader()
                If reader.HasRows() Then
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
                    cmd.ExecuteNonQuery()
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
            If cl Is Nothing Then
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
                    cmd.ExecuteNonQuery()
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
            Dim prov As DataRow = BuscarProveedor(proveedor)
            If Not prov Is Nothing Then
                comprobar = False
            Else
                comprobar = True
            End If

            Dim comprobar2 As Boolean = False
            Using cmd1 As New OleDbCommand("Select id from Gamas where id = @id", conn)
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
            Dim prod As DataRow = BuscarProducto(id)
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
                    cmd.ExecuteNonQuery()
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
            If gas Is Nothing Then
                MessageBox.Show("La gasolina a modificar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Using cmd As New OleDbCommand("Update Gasolinas set nombre = ?, cantidad = ?, precio = ? where id = ?", conn)

                    cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                    cmd.Parameters.Add(New OleDbParameter("cantidad", cantidad))
                    cmd.Parameters.Add(New OleDbParameter("precio", precio))
                    cmd.Parameters.Add(New OleDbParameter("id", id))
                    cmd.ExecuteNonQuery()
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
            If prov Is Nothing Then
                MessageBox.Show("El proveedor a modificar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Using cmd As New OleDbCommand("Update Proveedores set nombre = ? where id = ?", conn)

                    cmd.Parameters.Add(New OleDbParameter("nombre", nombre))
                    cmd.Parameters.Add(New OleDbParameter("id", id))
                    cmd.ExecuteNonQuery()
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

    Public Sub EliminarEmpleado(id As Integer)
        Try
            conn.Open()
            Dim empleado As DataRow = BuscarEmpleado(id)
            If empleado Is Nothing Then
                MessageBox.Show("El Empleado a eliminar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim comprobar As Boolean = False
                Using cmd0 As New OleDbCommand("Select Administrador from Empleados where id = @id", conn)
                    cmd0.Parameters.AddWithValue("@id", id)

                    Dim reader As OleDbDataReader = cmd0.ExecuteReader()
                    If reader.HasRows() Then
                        While reader.Read()
                            If reader("Administrador").ToString() = 2 Then
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
                    cmd.ExecuteNonQuery()
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
            If cliente Is Nothing Then
                MessageBox.Show("El cliente a eliminar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
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
            Dim producto As DataRow = BuscarProducto(id)
            If producto Is Nothing Then
                MessageBox.Show("El producto a eliminar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
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
        Dim cmd As New OleDbCommand("DELETE FROM Productos Where gama = @id", conn)
        Dim cmd2 As New OleDbCommand("DELETE FROM Proveedores WHERE id = @id", conn)
        Try
            conn.Open()

            Dim proveedor As DataRow = BuscarProveedor(id)
            If proveedor Is Nothing Then
                MessageBox.Show("El proveedor a eliminar no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()

                cmd2.Parameters.AddWithValue("@id", id)
                cmd2.ExecuteNonQuery()
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


    'zona validaciones-------------------
    '------------------------------------
    Public Function validarIDs(tb As TextBox, str As String) As Boolean

        If str = "" Then
            MessageBox.Show("El campo id no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf Not IsNumeric(str) Then
            MessageBox.Show("El campo id solo puede contener numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validarTelefonos(tb As TextBox, str As String) As Boolean
        'en este metodo validamos que el texbox de telefono no este vacio. aparte
        'de que solo puede tener un prefijo (+) y numeros. En caso de que tenga mas de un (+)
        'o letras, mostraremos un mensaje de error. Para ello utilizaremos una lista con caracteres permitidos
        Dim permitidos As New List(Of Char) From {"+", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim contadormas As Integer = 0
        Dim comprobar As Boolean = False
        If str = "" Then
            MessageBox.Show("El campo telefono no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            For i As Integer = 0 To str.Length - 1
                If str(i) = "+" Then
                    contadormas += 1
                End If

                If (Not permitidos.Contains(str(i))) Or (contadormas > 1 Or contadormas = 0) Then
                    comprobar = True
                End If
            Next
            If comprobar = True Then
                MessageBox.Show("El campo telefono solo puede tener simbolos numericos, y el prefijo (+) una vez", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Clear()
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function validarAdministrador(tb As TextBox, num As String) As Boolean
        If num = "" Then
            MessageBox.Show("El campo administrador no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf Not IsNumeric(num) Then
            MessageBox.Show("El administrador debe de ser numerico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf num = "0" Then
            Return False
        ElseIf num = "1" Then
            Return False
        Else
            MessageBox.Show("Solo estan permitidos en el campo altas 0 y 1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        End If

    End Function

    Public Function validarCorreos(tb As TextBox, str As String) As Boolean

        Dim contadorpuntos As Integer = 0
        Dim contadorArrobas As Integer = 0

        If str.StartsWith("@") Then
            MessageBox.Show("Error, un correo electronico no puede empezar con un @", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        End If

        For i As Integer = 0 To str.Length - 1
            If str(i) = "." Then
                contadorpuntos += 1
            ElseIf str(i) = "@" Then
                contadorArrobas += 1
            End If
        Next

        If (contadorArrobas = 0 And contadorpuntos = 0) Or (contadorArrobas > 1 Or contadorpuntos > 1) Then
            MessageBox.Show("Error, compruebe el numero de arrobas y puntos del correo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validarContraseñas(tb As TextBox, str As String) As Boolean
        'en este metodo validamos que el texbox de contraseña no este vacio. aparte
        'de que solo puede tener letras y numeros. En caso de que tenga caracteres especiales
        'mostraremos un mensaje de error. Para ello utilizaremos una lista con caracteres permitidos
        Dim permitidos As New List(Of Char) From {"!", "#", "$", "%", "&", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "[", "\", "]", "^", "_", "{", "|", "}", "~"}
        Dim comprobar As Boolean = False
        If str = "" Then
            MessageBox.Show("El campo contraseña no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            For i As Integer = 0 To str.Length - 1
                If permitidos.Contains(str(i)) Then
                    comprobar = True
                End If
            Next
            If comprobar = True Then
                MessageBox.Show("El campo pruebas no puede tener caracteres especiales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Clear()
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function validarNOmbreYApellidos(tb As TextBox, str As String) As Boolean

        Dim permitidos As New List(Of Char) From {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "á", "é", "í", "ó", "ú", "Á", "É", "Í", "Ó", "Ú"}
        Dim comprobar As Boolean = False
        If str = "" Then
            MessageBox.Show("El campo no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            For i As Integer = 0 To str.Length - 1
                If Not permitidos.Contains(str(i)) Then
                    comprobar = True
                End If
            Next
            If comprobar = True Then
                MessageBox.Show("El campo solo puede tener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Clear()
                Return True
            Else
                Return False
            End If
        End If
    End Function



    Private Function validarCantidad(tb As TextBox, str As String) As Boolean
        Dim contadorComas As Integer = 0
        Dim contadorPuntos As Integer = 0

        If str = "" Then
            MessageBox.Show("El campo no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf Not IsNumeric(str) Then
            MessageBox.Show("Solo son permitidos caracteres numericos en la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        ElseIf str < 0 Then
            MessageBox.Show("La cantidad no puede ser menor que 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If

        For i As Integer = 0 To str.Length - 1
            If str(i) = "," Then
                contadorComas += 1
            ElseIf str(i) = "." Then
                contadorPuntos += 1
            End If
        Next

        If contadorComas > 0 Or contadorPuntos > 0 Or (contadorComas = 1 And contadorPuntos = 1) Then
            MessageBox.Show("No se pueden agregar ni comas ni puntos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        Else
            Return False
        End If

    End Function

    Private Function validarPrecio(tb As TextBox, str As String) As Boolean
        'en esta funcion lo que hacemos es comprobar si tiene mas de un punto o mas de una coma o si tiene letras
        'o si tiene un punto y una coma. En caso de que tenga mas de uno de estos caracteres o una combinacion de ellos
        'mostraremos un mensaje de error
        Dim contadorPuntos As Integer = 0
        Dim contadorComas As Integer = 0

        If str = "" Then
            MessageBox.Show("El campo de precio no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf Not IsNumeric(str) Then
            MessageBox.Show("El campo debe de ser numerico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True

        ElseIf str < 0 Then
            MessageBox.Show("El precio no puede ser menor que 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            For i As Integer = 0 To str.Length - 1
                If str(i) = "." Then
                    contadorPuntos += 1
                ElseIf str(i) = "," Then
                    contadorComas += 1
                End If
            Next
            If contadorPuntos > 1 Or contadorComas > 1 Then
                MessageBox.Show("Error, dentro del campo hay mas de un punto o de una coma", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Clear()
                Return True
            ElseIf contadorPuntos = 1 And contadorComas = 1 Then
                MessageBox.Show("No se puede meter dentro del campo un punto o una coma a la vez", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Clear()
                Return True
            Else
                Return False
            End If

        End If
    End Function

    Private Function validarGama(tb As TextBox, str As String) As Boolean

        'en esta funcion vamos a validar que la gama (su id) este dentro de la tabla gamas.
        'para ello vamos a hacer una consulta a la base de datos access utilizando comandos en olebd
        'y si el id no existe, mostraremos un mensaje de error
        Dim comprobar As Boolean = False
        Try
            Dim cmd As New OleDbCommand("Select id from Gamas where id = @id", conn)
            cmd.Parameters.AddWithValue("@id", str)
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.HasRows() Then
                comprobar = True
            End If
            conn.Close()
            If comprobar = False Then
                MessageBox.Show("El id de la gama no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Clear()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error de la validacion de la gama", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Finally
            conn.Close()
        End Try

    End Function
    Public Function validarNombreEmpresa(tb As TextBox, str As String) As Boolean
        'en esta funcion solamente validaremos que no este vacio el campo de nombre de la empresa
        If str = "" Then
            MessageBox.Show("El campo nombre no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validarAlta(tb As TextBox, str As String) As Boolean

        If str = "" Then
            MessageBox.Show("El campo alta no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf str = "0" Then
            Return False
        ElseIf str = "1" Then
            Return False
        Else
            MessageBox.Show("Solo estan permitidos en el campo altas 0 y 1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        End If

    End Function

    Public Function validarProveedor(tb As TextBox, prov As String)

        Dim proveedor As DataRow

        If prov = "" Then
            MessageBox.Show("El campo proveedor no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf Not IsNumeric(prov) Then
            MessageBox.Show("El campo proveedor debe de ser numerico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        End If

        proveedor = BuscarProveedor(prov)
        If proveedor Is Nothing Then
            MessageBox.Show("El proveedor no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        Else
            Return False
        End If

    End Function
    'zona botones de accion------------
    '----------------------------------

    Private Sub btnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click
        Dim validacion1 As Boolean = validarIDs(tbIdEmpleado, tbIdEmpleado.Text)
        Dim validacion2 As Boolean = validarCorreos(tbCorreoEmpleado, tbCorreoEmpleado.Text)
        Dim validacion3 As Boolean = validarTelefonos(tbTelefonoEmpleado, tbTelefonoEmpleado.Text)
        Dim validacion4 As Boolean = validarContraseñas(tbContraseñaEmpleado, tbContraseñaEmpleado.Text)
        Dim validacion5 As Boolean = validarNOmbreYApellidos(tbNombreEmpleado, tbNombreEmpleado.Text)
        Dim validacion6 As Boolean = validarNOmbreYApellidos(tbApellido1Empleado, tbApellido1Empleado.Text)
        Dim validacion7 As Boolean = validarNOmbreYApellidos(tbApellido2Empleado, tbApellido2Empleado.Text)
        Dim validacion8 As Boolean = validarAdministrador(tbAdministradorEmpleado, tbAdministradorEmpleado.Text)

        If validacion1 = False And validacion2 = False And validacion3 = False And validacion4 = False And validacion5 = False And validacion6 = False And validacion7 = False And validacion8 = False Then
            falseoProgressBar()
            AgregarEmpleado(tbIdEmpleado.Text, tbNombreEmpleado.Text, tbApellido1Empleado.Text, tbApellido2Empleado.Text,
                        tbTelefonoEmpleado.Text, tbCorreoEmpleado.Text, tbContraseñaEmpleado.Text, tbAdministradorEmpleado.Text, tbCargoEmpleado.Text)
            limpiarEmpleado()
        End If
    End Sub

    Private Sub btnModificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnModificarEmpleado.Click
        Dim validacion1 As Boolean = validarIDs(tbIdEmpleado, tbIdEmpleado.Text)
        Dim validacion2 As Boolean = validarCorreos(tbCorreoEmpleado, tbCorreoEmpleado.Text)
        Dim validacion3 As Boolean = validarTelefonos(tbTelefonoEmpleado, tbTelefonoEmpleado.Text)
        Dim validacion4 As Boolean = validarContraseñas(tbContraseñaEmpleado, tbContraseñaEmpleado.Text)
        Dim validacion5 As Boolean = validarNOmbreYApellidos(tbNombreEmpleado, tbNombreEmpleado.Text)
        Dim validacion6 As Boolean = validarNOmbreYApellidos(tbApellido1Empleado, tbApellido1Empleado.Text)
        Dim validacion7 As Boolean = validarNOmbreYApellidos(tbApellido2Empleado, tbApellido2Empleado.Text)
        Dim validacion8 As Boolean = validarAdministrador(tbAdministradorEmpleado, tbAdministradorEmpleado.Text)
        If validacion1 = False And validacion2 = False And validacion3 = False And validacion4 = False And validacion5 = False And validacion6 = False And validacion7 = False And validacion8 = False Then
            falseoProgressBar()
            ModificarEmpleado(tbIdEmpleado.Text, tbNombreEmpleado.Text, tbApellido1Empleado.Text, tbApellido2Empleado.Text, tbTelefonoEmpleado.Text, tbCorreoEmpleado.Text,
                        tbContraseñaEmpleado.Text, tbCargoEmpleado.Text, tbAdministradorEmpleado.Text)
            limpiarEmpleado()
        End If
    End Sub

    Private Sub btnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btnEliminarEmpleado.Click
        Dim validacion1 As Boolean = validarIDs(tbIdEmpleado, tbIdEmpleado.Text)
        If validacion1 = False Then
            falseoProgressBar()
            EliminarEmpleado(tbIdEmpleado.Text)
        End If
    End Sub

    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        falseoProgressBar()
        MostrarTodosEmpleados()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        falseoProgressBar()
        MostrarTodosClientes()
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim validacion1 As Boolean = validarIDs(tbIdCliente, tbIdCliente.Text)
        Dim validacion2 As Boolean = validarCorreos(tbCorreoCliente, tbCorreoCliente.Text)
        Dim validacion3 As Boolean = validarTelefonos(tbTelefonoCliente, tbTelefonoCliente.Text)
        Dim validacion5 As Boolean = validarNOmbreYApellidos(tbNombreCliente, tbNombreCliente.Text)
        Dim validacion6 As Boolean = validarNOmbreYApellidos(tbApellido1Cliente, tbApellido1Cliente.Text)
        Dim validacion7 As Boolean = validarNOmbreYApellidos(tbApellido2Cliente, tbApellido2Cliente.Text)
        Dim validacion8 As Boolean = validarAlta(tbAltaCliente, tbAltaCliente.Text)

        If validacion1 = False And validacion2 = False And validacion3 = False And validacion5 = False And validacion6 = False And validacion7 = False And validacion8 = False Then
            falseoProgressBar()
            AgregarCliente(tbIdCliente.Text, tbNombreCliente.Text, tbApellido1Cliente.Text, tbApellido2Cliente.Text, tbTelefonoCliente.Text, tbCorreoCliente.Text, FechaAltaClienteTimePicker.Value.Date, tbAltaCliente.Text)
            limpiarCliente()
        End If
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        Dim validacion1 As Boolean = validarIDs(tbIdCliente, tbIdCliente.Text)
        Dim validacion2 As Boolean = validarCorreos(tbCorreoCliente, tbCorreoCliente.Text)
        Dim validacion3 As Boolean = validarTelefonos(tbTelefonoCliente, tbTelefonoCliente.Text)
        Dim validacion5 As Boolean = validarNOmbreYApellidos(tbNombreCliente, tbNombreCliente.Text)
        Dim validacion6 As Boolean = validarNOmbreYApellidos(tbApellido1Cliente, tbApellido1Cliente.Text)
        Dim validacion7 As Boolean = validarNOmbreYApellidos(tbApellido2Cliente, tbApellido2Cliente.Text)
        Dim validacion8 As Boolean = validarAlta(tbAltaCliente, tbAltaCliente.Text)
        If validacion1 = False And validacion2 = False And validacion3 = False And validacion5 = False And validacion6 = False And validacion7 = False And validacion8 = False Then
            falseoProgressBar()
            ModificarCliente(tbIdCliente.Text, tbNombreCliente.Text, tbApellido1Cliente.Text, tbApellido2Cliente.Text, tbTelefonoCliente.Text,
            tbCorreoCliente.Text, FechaAltaClienteTimePicker.Value.Date, tbAltaCliente.Text)
            limpiarCliente()
        End If
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        Dim validacion1 As Boolean = validarIDs(tbIdCliente, tbIdCliente.Text)
        If validacion1 = False Then
            falseoProgressBar()
            EliminarCliente(tbIdCliente.Text)
        End If
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        falseoProgressBar()
        MostrarTodosProductos()
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim validacion1 As Boolean = validarIDs(tbGamaProducto, tbGamaProducto.Text)
        Dim validacion2 As Boolean = validarPrecio(tbPrecioProducto, tbPrecioProducto.Text)
        Dim validacion3 As Boolean = validarGama(tbGamaProducto, tbGamaProducto.Text)
        Dim validacion4 As Boolean = validarProveedor(tbProveedorProducto, tbProveedorProducto.Text)
        If validacion1 = False And validacion2 = False And validacion3 = False And validacion4 = False Then
            falseoProgressBar()
            AgregarProducto(tbIdProducto.Text, tbNombreProducto.Text, tbPrecioProducto.Text, tbProveedorProducto.Text, tbGamaProducto.Text)
            limpiarProducto()
        End If
    End Sub

    Private Sub btnModificarProducto_Click(sender As Object, e As EventArgs) Handles btnModificarProducto.Click
        Dim validacion1 As Boolean = validarIDs(tbIdProducto, tbIdProducto.Text)
        Dim validacion2 As Boolean = validarPrecio(tbPrecioProducto, tbPrecioProducto.Text)
        Dim validacion3 As Boolean = validarGama(tbGamaProducto, tbGamaProducto.Text)
        If validacion1 = False And validacion2 = False And validacion3 = False Then
            falseoProgressBar()
            ModificarProductos(tbIdProducto.Text, tbNombreProducto.Text, tbPrecioProducto.Text, tbProveedorProducto.Text, tbGamaProducto.Text)
            limpiarProducto()
        End If
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        Dim validacion1 As Boolean = validarIDs(tbIdProducto, tbIdProducto.Text)
        If validacion1 = False Then
            falseoProgressBar()
            EliminarProducto(tbIdProducto.Text)
        End If
    End Sub

    Private Sub btnBuscarGasolina_Click(sender As Object, e As EventArgs) Handles btnBuscarGasolina.Click
        falseoProgressBar()
        MostrarTodasGasolinas()
    End Sub

    Private Sub btnModificarGasolina_Click(sender As Object, e As EventArgs) Handles btnModificarGasolina.Click
        Dim validacion1 As Boolean = validarIDs(tbIdGasolina, tbIdGasolina.Text)
        Dim validacion2 As Boolean = validarCantidad(tbCantidadGasolina, tbCantidadGasolina.Text)
        Dim validacion3 As Boolean = validarPrecio(tbPrecioGasolina, tbPrecioGasolina.Text)
        If validacion1 = False And validacion2 = False And validacion3 = False Then
            falseoProgressBar()
            ModificarGasolina(tbIdGasolina.Text, tbNombreGasolina.Text, tbCantidadGasolina.Text, tbPrecioGasolina.Text)
            limpiarGasolina()
        End If
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        falseoProgressBar()
        MostrarTodosProveedores()
    End Sub

    Private Sub btnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
        Dim validacion1 As Boolean = validarIDs(tbIdProveedor, tbIdProveedor.Text)
        Dim validacion2 As Boolean = validarNombreEmpresa(tbNombreProveedor, tbNombreProveedor.Text)
        If validacion1 = False And validacion2 = False Then
            falseoProgressBar()
            AgregarProveedor(tbIdProveedor.Text, tbNombreProveedor.Text)
            limpiarProveedor()
        End If
    End Sub

    Private Sub btnModificarProveedor_Click(sender As Object, e As EventArgs) Handles btnModificarProveedor.Click
        Dim validacion1 As Boolean = validarIDs(tbIdProveedor, tbIdProveedor.Text)
        Dim validacion2 As Boolean = validarNombreEmpresa(tbNombreProveedor, tbNombreProveedor.Text)
        If validacion1 = False And validacion2 = False Then
            falseoProgressBar()
            ModificarProveedores(tbIdProveedor.Text, tbNombreProveedor.Text)
            limpiarProveedor()
        End If
    End Sub

    Private Sub btnEliminarProveedor_Click(sender As Object, e As EventArgs) Handles btnEliminarProveedor.Click
        Dim validacion1 As Boolean = validarIDs(tbIdProveedor, tbIdProveedor.Text)
        If validacion1 = False Then
            falseoProgressBar()
            EliminarProveedor(tbIdProveedor.Text)
        End If
    End Sub


    'zona menusStrip

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



    Private Sub limpiarEmpleado()
        tbIdEmpleado.Clear()
        tbNombreEmpleado.Clear()
        tbApellido1Empleado.Clear()
        tbApellido2Empleado.Clear()
        tbTelefonoEmpleado.Clear()
        tbCorreoEmpleado.Clear()
        tbAdministradorEmpleado.Clear()
        tbCargoEmpleado.Clear()
        tbContraseñaEmpleado.Clear()
    End Sub

    Private Sub limpiarCliente()
        tbIdCliente.Clear()
        tbNombreCliente.Clear()
        tbApellido1Cliente.Clear()
        tbApellido2Cliente.Clear()
        tbTelefonoCliente.Clear()
        tbCorreoCliente.Clear()
        tbAltaCliente.Clear()
    End Sub

    Private Sub limpiarProducto()
        tbIdProducto.Clear()
        tbNombreProducto.Clear()
        tbPrecioProducto.Clear()
        tbGamaProducto.Clear()
        tbProveedorProducto.Clear()
    End Sub

    Private Sub limpiarProveedor()
        tbIdProveedor.Clear()
        tbNombreProveedor.Clear()
    End Sub

    Private Sub limpiarGasolina()
        tbIdGasolina.Clear()
        tbNombreGasolina.Clear()
        tbPrecioGasolina.Clear()
        tbCantidadGasolina.Clear()
    End Sub

End Class