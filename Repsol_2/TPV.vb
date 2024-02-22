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
        lblUser.Text = Inicio.tbUsername.Text

        PanelIsCliente.Visible = True
        panelCosasCliente.Visible = False
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

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

    End Sub

    'Elimina un producto de la lista de pedidos
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (lbNombreProductos.SelectedItem Is Nothing) Then
            Return
        End If
        If (lbNombreProductos.SelectedItem.ToString = "Gasolina") Then
            MsgBox("No se puede eliminar la gasolina del pedido.")
            Return
        End If


        lbNombreProductos.Items.Remove(lbNombreProductos.SelectedItem)
        lbPrecios.Items.Remove(lbPrecios.Items.Item(lbNombreProductos.SelectedItem))

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
            MsgBox("Para pedidos superiores a 5.000 euros, use la tarjeta.")
            Return
        End If
        Efectivo.ShowDialog()
        Efectivo.lblPrecioInicial.Text = lblResultado.Text
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

        'Dim caja As New Archivos.HacerCaja
        'caja.CajaTemporal(Single.Parse(lblResultado.Text), Single.Parse("0,00"), lblUser.Text)
        Dim a As New Ticket
        a.ImprimirTicketTarjeta(lblUser.Text, tarjeta, lblResultado.Text, lbNombreProductos, lbPrecios)
    End Sub

    Private Sub btnEsCliente_Click(sender As Object, e As EventArgs) Handles btnEsCliente.Click
        PanelIsCliente.Visible = False
        tbNombreCliente.Enabled = False
        tbApellido1Cliente.Enabled = False
        tbApellido2Cliente.Enabled = False
        tbTelefonoCliente.Enabled = False
        tbCorreoCliente.Enabled = False

        btnAccionBuscarCliente.Text = "Buscar"
        panelCosasCliente.Visible = True
    End Sub

    Private Sub btnCrearCliente_Click(sender As Object, e As EventArgs) Handles btnCrearCliente.Click
        PanelIsCliente.Visible = False
        tbNombreCliente.Enabled = True
        tbApellido1Cliente.Enabled = True
        tbApellido2Cliente.Enabled = True
        tbTelefonoCliente.Enabled = True
        tbCorreoCliente.Enabled = True

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
                        tbNombreCliente.Text = cliente("Nombre")
                        tbApellido1Cliente.Text = cliente("Apellido 1")
                        tbApellido2Cliente.Text = cliente("Apellido 2")
                        tbTelefonoCliente.Text = cliente("Telefono")
                        tbCorreoCliente.Text = cliente("Correo")
                        FechaAltaClienteTimePicker.Value = cliente("FechaAlta")
                    End If
                Catch ex As Exception
                    MsgBox("Hubo un error con la busqueda del cliente, trate de introducir bien los datos")
                    Dim guardar As New Archivo
                    guardar.GuardarError(ex, "TPV, btnAccionBuscarCliente_Click")
                End Try
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
            MsgBox("Hubo un error con la carga de los productos de la tienda" & ex.Message)
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
            MsgBox("Hubo un error con la carga de los productos de la tienda" & ex.Message)
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
            MsgBox("Hubo un error con la carga de los productos de la tienda" & ex.Message)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "TPV, CargarOtros")
        End Try

    End Sub


End Class