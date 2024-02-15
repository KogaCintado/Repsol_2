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

    Private Sub lbNombreProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbNombreProductos.SelectedIndexChanged

    End Sub

    Private Sub lbPrecios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPrecios.SelectedIndexChanged

    End Sub

    Private Sub lbProductosTienda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProductosTienda.SelectedIndexChanged

    End Sub

    Private Sub lbPreciosTienda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPreciosTienda.SelectedIndexChanged

    End Sub

    Private Sub lbNombreCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbNombreCategorias.SelectedIndexChanged

        If lbNombreCategorias.SelectedIndex = 0 Then
            lbNombreProductos.Items.Clear()
            lbPrecios.Items.Clear()
            CargarConsumibles()
        End If

        If lbNombreCategorias.SelectedIndex = 1 Then
            lbNombreProductos.Items.Clear()
            lbPrecios.Items.Clear()
            CargarBebidas()
        End If

        If lbNombreCategorias.SelectedIndex = 2 Then
            lbNombreProductos.Items.Clear()
            lbPrecios.Items.Clear()
            CargarOtros()
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub btnTarjeta_Click(sender As Object, e As EventArgs) Handles btnTarjeta.Click

    End Sub

    Private Sub btnEfectivo_Click(sender As Object, e As EventArgs) Handles btnEfectivo.Click

    End Sub

    Private Sub lblResultado_Click(sender As Object, e As EventArgs) Handles lblResultado.Click

    End Sub




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