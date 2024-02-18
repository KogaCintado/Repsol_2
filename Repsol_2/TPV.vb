Imports System.Data.OleDb
Public Class TPV

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    Private Sub TPV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximizamos la ventana
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        'Limpia los listbox lbNombreProductos y lbPrecios menos el primer elemento.
        If (lbNombreProductos.GetItemText(0) = "Gasolina") Then
            Dim box As String = lbNombreProductos.GetItemText(0)
            Dim box1 As String = lbPrecios.GetItemText(0)

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
        If (sender.SelectedItem Is Nothing) Then
            Return
            'Or TypeOf (sender.SelectedItem) Is DataRowView
        End If
        'If (producto = "" Or precio = "") Then
        '    Return
        'End If

        lbNombreProductos.Items.Add(lbProductosTienda.GetItemText(lbProductosTienda.SelectedIndex))
        lbPrecios.Items.Add(lbPreciosTienda.GetItemText(lbPreciosTienda.SelectedIndex))

        actualizarPrecio()
    End Sub
    'Actualiza el precio total del pedido.
    Private Sub actualizarPrecio()
        Dim box As Decimal = 0.00
        For Each precio In lbPrecios.Items
            box += precio
        Next
        lblResultado.Text = box.ToString("F")

    End Sub

    'Elimina un producto de la lista de pedidos
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (lbNombreProductos.SelectedItem IsNot Nothing) Then
            lbNombreProductos.Items.Remove(lbNombreProductos.SelectedIndex)
            lbPrecios.Items.Remove(lbNombreProductos.SelectedIndex)
        End If

        actualizarPrecio()
    End Sub

    'Con este procedimiento, nos aseguramos de seleccionar producto y su precio a la vez en los listBox.
    Private Sub lbNombreProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbNombreProductos.SelectedIndexChanged, lbPrecios.SelectedIndexChanged
        Dim a = sender.SelectedIndex
        lbPrecios.SelectedIndex = a
        lbNombreProductos.SelectedIndex = a
    End Sub


    'REVISAR!!!!!!!!!!!!!!!!!!
    Private Sub btnEfectivo_Click_1(sender As Object, e As EventArgs) Handles btnEfectivo.Click
        Dim total As Double = Convert.ToDouble(lblResultado.Text)
        Dim pago As Double = Convert.ToDouble(InputBox("Introduce el dinero que te han dado"))

        If pago < total Then
            MsgBox("El dinero introducido es insuficiente")
        Else
            MsgBox("El cambio es de " & (pago - total) & " euros")
        End If
    End Sub

    Private Sub btnTarjeta_Click_1(sender As Object, e As EventArgs) Handles btnTarjeta.Click
        MsgBox("Pago realizado con tarjeta")
    End Sub
    'REVISAR!!!!!!!!!!!!!!!!!!





    '-----------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------Espacio para metodos de base de datos--------------------------------------------------------
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
        End Try

    End Sub

    Private Sub CargarOtros()

        Dim cmd As New OleDbCommand("Select * from Productos where Gama >= 3 order by id", conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)
        lbProductosTienda.DataSource = dt
        lbProductosTienda.DisplayMember = "Nombre"

        lbPreciosTienda.DataSource = dt
        lbPreciosTienda.DisplayMember = "Precio"

    End Sub
End Class