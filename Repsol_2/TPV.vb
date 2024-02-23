Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports Biblioteca

Public Class TPV

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    Private Sub TPV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximizamos la ventana
        Me.WindowState = FormWindowState.Maximized

        'Cargamos el nombre del usuario
        lblUser.Text = Inicio.nombreEmp

        PanelIsCliente.Visible = True
        panelCosasCliente.Visible = False
        panelSocioDesc.Visible = False

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            'Limpia los listbox lbNombreProductos y lbPrecios menos el primer elemento.
            If (lbNombreProductos.Items.Item(0) = "Gasolina") Then
                Dim box As String = lbNombreProductos.Items.Item(0)
                Dim box1 As String = lbPrecios.Items.Item(0)

                lbNombreProductos.Items.Clear()
                lbPrecios.Items.Clear()

                lbNombreProductos.Items.Add(box)
                lbPrecios.Items.Add(box1)
            Else
                lbNombreProductos.Items.Clear()
                lbPrecios.Items.Clear()
            End If
            actualizarPrecio()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub VolverToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem1.Click
        Trabajar.Show()
        Me.Close()
    End Sub
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    'Cerramos el programa.
    Private Sub CerrarElProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicaciónToolStripMenuItem.Click
        Inicio.Close()
    End Sub



    Private Sub lbNombreCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbNombreCategorias.SelectedIndexChanged

        If lbNombreCategorias.SelectedIndex = 0 Then
            CargarConsumibles()
            Return
        End If

        If lbNombreCategorias.SelectedIndex = 1 Then
            CargarBebidas()
            Return
        End If

        If lbNombreCategorias.SelectedIndex = 2 Then
            CargarOtros()
        End If

    End Sub



    'Crea un nuevo pedido.
    Public Sub nuevoPedido()
        lbPrecios.Items.Clear()
        lbNombreProductos.Items.Clear()
        lblResultado.Text = "0,00"
    End Sub

    'Elimina un producto de la lista de pedidos
    Private Sub eliminarDeLista(selectedIndex As Integer)
        lbNombreProductos.Items.RemoveAt(selectedIndex)
        lbPrecios.Items.RemoveAt(selectedIndex)
    End Sub

    'hazme un sub para que, cuando se clickee un producto ya seleccionado en una listbox, añada el producto a otra listbox
    'y que añada el precio del producto a otra listbox
    'y que sume el precio del producto a un label que muestre el precio total de la compra
    Private Sub lbProductosTienda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProductosTienda.Click, lbPreciosTienda.Click
        'sender.selectedIndex =

        If (sender.SelectedItem Is Nothing) Then
            Return
            'Or TypeOf (sender.SelectedItem) Is DataRowView
        End If
        Dim a = sender.SelectedIndex
        lbPreciosTienda.SelectedIndex = a
        lbProductosTienda.SelectedIndex = a

        lbNombreProductos.Items.Add(lbProductosTienda.GetItemText(lbProductosTienda.SelectedItem))
        lbPrecios.Items.Add(lbPreciosTienda.GetItemText(lbPreciosTienda.SelectedItem))

        actualizarPrecio()
    End Sub
    'Actualiza el precio total del pedido.
    Public Sub actualizarPrecio()
        Dim box As Decimal = 0.00
        If (lbPrecios.Items.Count = 0) Then
            lblResultado.Text = "0,00"
            Return
        End If
        For Each precio In lbPrecios.Items
            box += precio
        Next
        lblResultado.Text = box.ToString("F")
        lblDescSocio.Text = (box * 0.98).ToString("F")

    End Sub

    'Elimina un producto de la lista de pedidos
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (lbNombreProductos.SelectedItem Is Nothing) Then
                Return
            End If
            If (lbNombreProductos.SelectedItem.ToString = "Gasolina") Then
                MessageBox.Show("No se puede eliminar la gasolina del pedido.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim index As Integer = lbNombreProductos.SelectedIndex
            lbNombreProductos.Items.RemoveAt(index)
            lbPrecios.Items.RemoveAt(index)

        Catch ex As Exception

        End Try
        actualizarPrecio()
    End Sub

    'Con este procedimiento, nos aseguramos de seleccionar producto y su precio a la vez en los listBox.
    Private Sub lbNombreProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbNombreProductos.SelectedIndexChanged, lbPrecios.SelectedIndexChanged
        Dim a = sender.SelectedIndex
        lbPrecios.SelectedIndex = a
        lbNombreProductos.SelectedIndex = a
    End Sub


    'Procedimiento que te muestra el formulario Efectivo, siempre y cuando un pedido tenga datos, y no supere los 5000 euros.
    Private Sub btnEfectivo_Click(sender As Object, e As EventArgs) Handles btnEfectivo.Click
        If (lblResultado.Text = "0,00") Then
            Return
        ElseIf (CSng(lblResultado.Text) >= 5000) Then
            MessageBox.Show("No se puede eliminar la gasolina del pedido.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Efectivo.ShowDialog()
        If (panelSocioDesc.Visible = True) Then
            Efectivo.lblPrecioInicial.Text = lblDescSocio.Text
        Else
            Efectivo.lblPrecioInicial.Text = lblResultado.Text
        End If

    End Sub

    'Procedimiento asignado a un botón que, al seleccionarlo, Hace la tarea de simular conexión con un datáfono, guarda el pedido e imprime el ticket.
    Private Sub btnTarjeta_Click(sender As Object, e As EventArgs) Handles btnTarjeta.Click
        If (lblResultado.Text = "0,00") Then
            Return
        End If

        Dim tarjeta As String = InputBox("Acerque la tarjeta al datáfono", "Pago", "")
        If tarjeta.Length = 0 Then
            Return
        End If

        Dim total As String
        If (panelSocioDesc.Visible = True) Then
            total = lblDescSocio.Text
        Else
            total = lblResultado.Text
        End If
        'Dim caja As New Archivos.HacerCaja
        'caja.CajaTemporal(Single.Parse(lblResultado.Text), Single.Parse("0,00"), lblUser.Text)

        Dim a As New Ticket
        a.ImprimirTicketTarjeta(lblUser.Text, tarjeta, total, lbNombreProductos, lbPrecios)

        Me.Close()
        Trabajar.Show()
    End Sub

    Private Sub btnEsCliente_Click(sender As Object, e As EventArgs) Handles btnEsCliente.Click
        PanelIsCliente.Visible = False
        tbIdCliente.Enabled = True
        tbNombreCliente.Enabled = False
        tbApellido1Cliente.Enabled = False
        tbApellido2Cliente.Enabled = False
        tbTelefonoCliente.Enabled = False
        tbCorreoCliente.Enabled = False

        btnAccionBuscarCliente.Enabled = True
        btnAccionBuscarCliente.Text = "Buscar"
        panelCosasCliente.Visible = True
    End Sub

    Private Sub btnCrearCliente_Click(sender As Object, e As EventArgs) Handles btnCrearCliente.Click
        FechaAltaClienteTimePicker.Value = Date.Now
        PanelIsCliente.Visible = False
        tbIdCliente.Enabled = False
        tbNombreCliente.Enabled = True
        tbApellido1Cliente.Enabled = True
        tbApellido2Cliente.Enabled = True
        tbTelefonoCliente.Enabled = True
        tbCorreoCliente.Enabled = True

        btnAccionBuscarCliente.Enabled = True
        btnAccionBuscarCliente.Text = "Crear"
        panelCosasCliente.Visible = True
    End Sub

    Private Sub btnAccionBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarCliente.Click
        If (btnAccionBuscarCliente.Text = "Buscar") Then
            'En este boton lo que hacemos es buscar un Cliente por su id
            'Si el id no existe, mostramos un mensaje de error
            'Si el id existe, mostramos los datos del Cliente
            Dim validado As Boolean = GestionesAdministrador.validarIDs(tbIdCliente, tbIdCliente.Text)
            If validado = False Then
                Try

                    Dim idCliente As Integer
                    idCliente = tbIdCliente.Text
                    Dim cliente As DataRow
                    cliente = GestionesAdministrador.BuscarCliente(idCliente)
                    If cliente Is Nothing Then
                        MessageBox.Show("No existe un cliente con ese id")
                    Else
                        btnAccionBuscarCliente.Enabled = False
                        tbNombreCliente.Text = cliente("Nombre")
                        tbApellido1Cliente.Text = cliente("Apellido 1")
                        tbApellido2Cliente.Text = cliente("Apellido 2")
                        tbTelefonoCliente.Text = cliente("Telefono")
                        tbCorreoCliente.Text = cliente("Correo")
                        FechaAltaClienteTimePicker.Value = cliente("FechaAlta")
                        panelSocioDesc.Visible = True
                    End If
                Catch ex As Exception
                    MessageBox.Show("Hubo un error con la busqueda del cliente, trate de introducir bien los datos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim guardar As New Archivo
                    guardar.GuardarError(ex, "TPV, btnAccionBuscarCliente_Click")
                End Try
            End If
        ElseIf (btnAccionBuscarCliente.Text = "Crear") Then
            'En este boton lo que hacemos es crear un Cliente
            'Si el id ya existe, mostramos un mensaje de error
            'Si el id no existe, creamos el Cliente
            'Dim validacion1 As Boolean = GestionesAdministrador.validarIDs(tbIdCliente, tbIdCliente.Text)
            Dim validacion2 As Boolean = GestionesAdministrador.validarCorreos(tbCorreoCliente, tbCorreoCliente.Text)
            Dim validacion3 As Boolean = GestionesAdministrador.validarTelefonos(tbTelefonoCliente, tbTelefonoCliente.Text)
            Dim validacion5 As Boolean = GestionesAdministrador.validarNOmbreYApellidos(tbNombreCliente, tbNombreCliente.Text)
            Dim validacion6 As Boolean = GestionesAdministrador.validarNOmbreYApellidos(tbApellido1Cliente, tbApellido1Cliente.Text)
            Dim validacion7 As Boolean = GestionesAdministrador.validarNOmbreYApellidos(tbApellido2Cliente, tbApellido2Cliente.Text)
            If validacion2 = False And validacion3 = False And validacion5 = False And validacion6 = False And validacion7 = False Then
                Dim validado As Boolean = True

                If validado Then
                    Try
                        Dim idCliente As Integer

                        Dim nombre As String = tbNombreCliente.Text
                        Dim apellido1 As String = tbApellido1Cliente.Text
                        Dim apellido2 As String = tbApellido2Cliente.Text
                        Dim telefono As String = tbTelefonoCliente.Text
                        Dim correo As String = tbCorreoCliente.Text
                        Dim fechaAlta As Date = FechaAltaClienteTimePicker.Value.Date
                        idCliente = AgregarCliente(nombre, apellido1, apellido2, telefono, correo, fechaAlta)

                        panelSocioDesc.Visible = True

                        TarjetaRepsol.lblId.Text = idCliente
                        TarjetaRepsol.lblName.Text = nombre
                        TarjetaRepsol.lblApellido1.Text = apellido1
                        TarjetaRepsol.lblApellido2.Text = apellido2
                        TarjetaRepsol.lblFechaAlta.Text = fechaAlta
                        TarjetaRepsol.Imprimir()

                    Catch ex As Exception
                        MessageBox.Show("Hubo un error con la creación del cliente, trate de introducir bien los datos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim guardar As New Archivo
                        guardar.GuardarError(ex, "TPV, btnAccionBuscarCliente_Click")
                    End Try
                End If
            End If
        End If
    End Sub


    Private Sub LinkLabelRepsol_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelRepsol.LinkClicked
        Dim urlRepsol As String = "https://www.repsol.com/"
        ' Abre el navegador web predeterminado con la URL
        Process.Start(urlRepsol)
    End Sub

    Private Sub LinkLblCondiciones_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLblCondiciones.LinkClicked
        Dim urlRepsol As String = "https://www.repsol.com/es/pie-de-pagina/politica-de-privacidad/index.cshtml"
        ' Abre el navegador web predeterminado con la URL
        Process.Start(urlRepsol)
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------Espacio para métodos de base de datos--------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------



    Private Sub CargarBebidas()

        Dim cmd As New OleDbCommand("Select * from Productos where Gama = 1 order by id", conn)

        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable


        Try
            da.Fill(dt)

            lbProductosTienda.DataSource = dt
            lbProductosTienda.DisplayMember = "Nombre"

            lbPreciosTienda.DataSource = dt
            lbPreciosTienda.DisplayMember = "Precio"
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la carga de los productos de la tienda" & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "TPV, CargarBebidas")
        End Try

    End Sub

    Private Sub CargarConsumibles()

        Dim cmd As New OleDbCommand("Select * from Productos where Gama = 2 order by id", conn)

        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()

        Try
            da.Fill(dt)

            lbProductosTienda.DataSource = dt
            lbProductosTienda.DisplayMember = "Nombre"

            lbPreciosTienda.DataSource = dt
            lbPreciosTienda.DisplayMember = "Precio"
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la carga de los productos de la tienda" & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "TPV, CargarConsumibles")
        End Try

    End Sub

    Private Sub CargarOtros()

        Dim cmd As New OleDbCommand("Select * from Productos where Gama >= 3 order by id", conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        Try
            da.Fill(dt)
            lbProductosTienda.DataSource = dt
            lbProductosTienda.DisplayMember = "Nombre"

            lbPreciosTienda.DataSource = dt
            lbPreciosTienda.DisplayMember = "Precio"
        Catch ex As Exception
            MessageBox.Show("Hubo un error con la carga de los productos de la tienda" & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "TPV, CargarOtros")
        End Try

    End Sub

    Private Function AgregarCliente(nombre As String, apellido1 As String, apellido2 As String, telefono As String, correo As String, fecha As Date) As Integer
        Dim id As Integer
        Try
            conn.Open()
            Using cmd As New OleDbCommand("SELECT MAX(id) FROM clientes", conn)
                cmd.Parameters.Add(New OleDbParameter(“id”, id))

                id = Integer.Parse(cmd.ExecuteScalar().ToString())
                id += 1
            End Using
            conn.Close()
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
                cmd.Parameters.Add(New OleDbParameter("alta", 1))
                If cmd.ExecuteNonQuery() < 1 Then
                    Throw New Exception("Error en la conexión con la base de datos.")
                End If
                MessageBox.Show("Se agregó el cliente: " & nombre, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return id
            End Using
        Catch ex As Exception
            MessageBox.Show("Hubo un error a la hora de agregar el cliente: " & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "TPV, Agregar Cliente")
            Return -1
        Finally
            conn.Close()
        End Try

    End Function
End Class