Imports System.Data.OleDb
Imports Biblioteca

Public Class GestionesAdministrador




    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    Private Sub GestionesAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
        'Maximize the window
        Me.WindowState = FormWindowState.Maximized

        ToolStripStatusLabel1.Text = Now.ToString("dd/MM/yy")
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Opciones.Show()
        Me.Hide()
    End Sub


    Private Sub invisivilizarTodosExceptoDataGridDeClientes()

        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next

    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeEmpleados()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False

        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeGasolinas()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeProductos()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoDataGridDeProveedores()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False

        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelBuscarEmpleado()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelBuscarCliente()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelBuscarProducto()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelBuscarGasolina()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelBuscarProveedor()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarEmpleado()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next

    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarGasolina()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next

    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarProducto()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next

    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarProveedor()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next

    End Sub

    Private Sub invisivilizarTodosExceptoPanelEliminarCliente()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next

    End Sub

    Private Sub invisivilizarTodosExceptoPanelAgregarUsuario()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelAgregarCliente()
        Dim paneles As New List(Of Panel) From {panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelAgregarProducto()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelAgregarGasolina()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelAgregarProveedor()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelModificarEmpleado()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub


    Private Sub invisivilizarTodosExceptoPanelModificarCliente()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelModificarProductos()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelModificarGasolinas()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarProducto, panelModificarProveedores}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub

    Private Sub invisivilizarTodosExceptoPanelModificarProveedor()
        Dim paneles As New List(Of Panel) From {panelAgregarCliente, panelAgregarProducto, panelAgregarGasolina, panelAgregarProveedor, panelAgregarUsuario, panelBuscarCliente, panelBuscarEmpleado, panelBuscarGasolina, panelBuscarProducto, panelBuscarProveedor, panelEliminarClientes, panelEliminarEmpleado, panelEliminarGasolina, panelEliminarProducto, panelEliminarProveedores, panelModificarCliente, panelModificarEmpleado, panelModificarGasolina, panelModificarProducto}
        For Each panel As Panel In paneles
            panel.Location = New Point(1920, 1080)
            panel.Visible = False
        Next
        Dim datagrids As New List(Of DataGridView) From {ClientesDataGridView, EmpleadosDataGridView, GasolinasDataGridView, ProductosDataGridView, ProveedoresDataGridView}
        For Each datagrid As DataGridView In datagrids
            datagrid.Location = New Point(1920, 1080)
            datagrid.Visible = False
        Next
    End Sub


    Private Sub btnVerTodosProductos_Click(sender As Object, e As EventArgs) Handles btnVerTodosProductos.Click
        falseoProgressBar()
        MostrarTodosProductos()
        invisivilizarTodosExceptoDataGridDeProductos()
        ProductosDataGridView.Visible = True
        ProductosDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerTodosEmpleados_Click(sender As Object, e As EventArgs) Handles btnVerTodosEmpleados.Click
        falseoProgressBar()
        MostrarTodosEmpelados()
        invisivilizarTodosExceptoDataGridDeEmpleados()
        EmpleadosDataGridView.Visible = True
        EmpleadosDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerTodosClientes_Click(sender As Object, e As EventArgs) Handles btnVerTodosClientes.Click
        falseoProgressBar()
        MostrarTodosClientes()
        invisivilizarTodosExceptoDataGridDeClientes()
        ClientesDataGridView.Visible = True
        ClientesDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerTodasGasolinas_Click(sender As Object, e As EventArgs) Handles btnVerTodasGasolinas.Click
        falseoProgressBar()
        MostrarTodasGasolinas()
        invisivilizarTodosExceptoDataGridDeGasolinas()
        GasolinasDataGridView.Visible = True
        GasolinasDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerTodosProveedores_Click(sender As Object, e As EventArgs) Handles btnVerTodosProveedores.Click
        falseoProgressBar()
        MostrarTodosProveedores()
        invisivilizarTodosExceptoDataGridDeProveedores()
        ProveedoresDataGridView.Visible = True
        ProveedoresDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnSeleccionarUnEmpleado_Click(sender As Object, e As EventArgs) Handles btnSeleccionarUnEmpleado.Click
        invisivilizarTodosExceptoPanelBuscarEmpleado()
        panelBuscarEmpleado.Visible = True
        panelBuscarEmpleado.Location = New Point(476, 81)
    End Sub
    Private Sub btnVerCliente_Click(sender As Object, e As EventArgs) Handles btnVerCliente.Click
        invisivilizarTodosExceptoPanelBuscarCliente()
        panelBuscarCliente.Visible = True
        panelBuscarCliente.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerProducto_Click(sender As Object, e As EventArgs) Handles btnVerProducto.Click
        invisivilizarTodosExceptoPanelBuscarProducto()
        panelBuscarProducto.Visible = True
        panelBuscarProducto.Location = New Point(476, 81)
    End Sub
    Private Sub btnVerGasolina_Click(sender As Object, e As EventArgs) Handles btnVerGasolina.Click
        invisivilizarTodosExceptoPanelBuscarGasolina()
        panelBuscarGasolina.Visible = True
        panelBuscarGasolina.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerProveedor_Click(sender As Object, e As EventArgs) Handles btnVerProveedor.Click
        invisivilizarTodosExceptoPanelBuscarProveedor()
        panelBuscarProveedor.Visible = True
        panelBuscarProveedor.Location = New Point(476, 81)
    End Sub


    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        invisivilizarTodosExceptoPanelAgregarUsuario()
        panelAgregarUsuario.Visible = True
        panelAgregarUsuario.Location = New Point(476, 81)
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        invisivilizarTodosExceptoPanelAgregarCliente()
        panelAgregarCliente.Visible = True
        panelAgregarCliente.Location = New Point(476, 81)
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        invisivilizarTodosExceptoPanelAgregarProducto()
        panelAgregarProducto.Visible = True
        panelAgregarProducto.Location = New Point(476, 81)
    End Sub

    Private Sub btnAgregarGasolina_Click(sender As Object, e As EventArgs) Handles btnAgregarGasolina.Click
        invisivilizarTodosExceptoPanelAgregarGasolina()
        panelAgregarGasolina.Visible = True
        panelAgregarGasolina.Location = New Point(476, 81)
    End Sub

    Private Sub btnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
        invisivilizarTodosExceptoPanelAgregarProveedor()
        panelAgregarProveedor.Visible = True
        panelAgregarProveedor.Location = New Point(476, 81)
    End Sub


    Private Sub btnModificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnModificarEmpleado.Click
        invisivilizarTodosExceptoPanelModificarEmpleado()
        panelModificarEmpleado.Visible = True
        panelModificarEmpleado.Location = New Point(476, 81)
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        invisivilizarTodosExceptoPanelModificarCliente()
        panelModificarCliente.Visible = True
        panelModificarCliente.Location = New Point(476, 81)
    End Sub

    Private Sub btnModificarProducto_Click(sender As Object, e As EventArgs) Handles btnModificarProducto.Click
        invisivilizarTodosExceptoPanelModificarProductos()
        panelModificarProducto.Visible = True
        panelModificarProducto.Location = New Point(476, 81)
    End Sub

    Private Sub btnModificarGasolina_Click(sender As Object, e As EventArgs) Handles btnModificarGasolina.Click
        invisivilizarTodosExceptoPanelModificarGasolinas()
        panelModificarGasolina.Visible = True
        panelModificarGasolina.Location = New Point(476, 81)
    End Sub

    Private Sub btnModificarProveedor_Click(sender As Object, e As EventArgs) Handles btnModificarProveedor.Click
        invisivilizarTodosExceptoPanelModificarProveedor()
        panelModificarProveedores.Visible = True
        panelModificarProveedores.Location = New Point(476, 81)
    End Sub

    Private Sub btnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btnEliminarEmpleado.Click
        invisivilizarTodosExceptoPanelEliminarEmpleado()
        panelEliminarEmpleado.Visible = True
        panelEliminarEmpleado.Location = New Point(476, 81)
    End Sub

    Private Sub btnEliminarGas_Click(sender As Object, e As EventArgs) Handles btnEliminarGas.Click
        invisivilizarTodosExceptoPanelEliminarGasolina()
        panelEliminarGasolina.Visible = True
        panelEliminarGasolina.Location = New Point(476, 81)
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        invisivilizarTodosExceptoPanelEliminarProducto()
        panelEliminarProducto.Visible = True
        panelEliminarProducto.Location = New Point(476, 81)
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        invisivilizarTodosExceptoPanelEliminarCliente()
        panelEliminarClientes.Visible = True
        panelEliminarClientes.Location = New Point(476, 81)
    End Sub

    Private Sub btnEliminarProveedor_Click(sender As Object, e As EventArgs) Handles btnEliminarProveedor.Click
        invisivilizarTodosExceptoPanelEliminarProveedor()
        panelEliminarProveedores.Visible = True
        panelEliminarProveedores.Location = New Point(476, 81)
    End Sub





    Private Sub btnAccionBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarEmpleado.Click

        'En este boton lo que hacemos es buscar un empleado por su id
        'Si el id no existe, mostramos un mensaje de error
        'Si el id existe, mostramos los datos del empleado
        Dim validado As Boolean = validarIDs(tbIdEmpleado, tbIdEmpleado.Text)

        If validado = False Then
            Try
                falseoProgressBar()
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
                    tbAdministradorEmpleado.Text = empleado("Administrador")
                    tbCargoEmpleado.Text = empleado("Cargo")
                End If
            Catch ex As Exception
                MsgBox("Hubo un error con la busqueda del empleado, trate de introducir bien los datos")
                Dim guardar As New Archivo
                guardar.GuardarError(ex, "GestionesAdministrador, btnAccionBuscarEmpleado_Click")
            End Try
        End If


    End Sub

    Private Sub btnAccionBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarCliente.Click

        'En este boton lo que hacemos es buscar un Cliente por su id
        'Si el id no existe, mostramos un mensaje de error
        'Si el id existe, mostramos los datos del Cliente
        Dim validado As Boolean = validarIDs(tbIdCliente, tbIdCliente.Text)
        If validado = False Then
            Try
                falseoProgressBar()
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
                MsgBox("Hubo un error con la busqueda del cliente, trate de introducir bien los datos")
                Dim guardar As New Archivo
                guardar.GuardarError(ex, "GestionesAdministrador, btnAccionBuscarCliente_Click")
            End Try
        End If


    End Sub

    Private Sub btnAccionBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarProducto.Click
        'En este boton lo que hacemos es buscar un Producto por su id
        'Si el id no existe, mostramos un mensaje de error
        'Si el id existe, mostramos los datos del Producto
        Dim validado As Boolean = validarIDs(tbIdProducto, tbIdProducto.Text)
        If validado = False Then
            Try
                falseoProgressBar()
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
                MsgBox("Hubo un error con la busqueda del producto, trate de introducir bien los datos")
                Dim guardar As New Archivo
                guardar.GuardarError(ex, "GestionesAdministrador, btnAccionBuscarProducto_Click")
            End Try
        End If
    End Sub




    Private Sub btnAccionBuscarGasolina_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarGasolina.Click
        'En este boton lo que hacemos es buscar una Gasolina por su id
        'Si el id no existe, mostramos un mensaje de error
        'Si el id existe, mostramos los datos de la Gasolina
        Dim validado As Boolean = validarIDs(tbIdGasolina, tbIdGasolina.Text)
        If validado = False Then
            Try
                falseoProgressBar()
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
                MsgBox("Hubo un error con la busqueda de la gasolina, trate de introducir bien los datos")
                Dim guardar As New Archivo
                guardar.GuardarError(ex, "GestionesAdministrador, btnAccionBuscarGasolina_Click")
            End Try
        End If
    End Sub

    Private Sub btnAccionBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnAccionBuscarProveedor.Click


        Dim validado As Boolean = validarIDs(tbIdProveedor, tbIdProveedor.Text)
        If validado = True Then
            MessageBox.Show("El id introducido no es valido")
        Else
            Try
                falseoProgressBar()
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
                MsgBox("Hubo un error con la busqueda del proveedor, trate de introducir bien los datos")
                Dim guardar As New Archivo
                guardar.GuardarError(ex, "GestionesAdministrador, btnAccionBuscarProveedor_Click")
            End Try
        End If
    End Sub


    Private Sub btnAccionAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAccionAgregarUsuario.Click

        Dim validacion1 As Boolean = validarIDs(tbIdEmpleadoAgregar, tbIdEmpleadoAgregar.Text)
        Dim validacion2 As Boolean = validarCorreos(tbCorreoEmpleadoAgregar, tbCorreoEmpleadoAgregar.Text)
        Dim validacion3 As Boolean = validarTelefonos(tbTelefonoEmpleadoAgregar, tbTelefonoEmpleadoAgregar.Text)
        Dim validacion4 As Boolean = validarContraseñas(tbContraseñaEmpleadoAgregar, tbContraseñaEmpleadoAgregar.Text)
        Dim validacion5 As Boolean = validarNOmbreYApellidos(tbNombreEmpleadoAgregar, tbNombreEmpleadoAgregar.Text)
        Dim validacion6 As Boolean = validarNOmbreYApellidos(tbApellido1EmpleadoAgregar, tbApellido1EmpleadoAgregar.Text)
        Dim validacion7 As Boolean = validarNOmbreYApellidos(tbApellido2EmpleadoAgregar, tbApellido2EmpleadoAgregar.Text)

        If validacion1 = False And validacion2 = False And validacion3 = False And validacion4 = False And validacion5 = False And validacion6 = False And validacion7 = False Then
            falseoProgressBar()
            AgregarEmpleado(tbIdEmpleadoAgregar.Text, tbNombreEmpleadoAgregar.Text, tbApellido1EmpleadoAgregar.Text, tbApellido2EmpleadoAgregar.Text,
                        tbTelefonoEmpleadoAgregar.Text, tbCorreoEmpleadoAgregar.Text, tbContraseñaEmpleadoAgregar.Text, tbAdministradorEmpleadoAgregar.Text, tbCargoEmpleadoAgregar.Text)
        End If

    End Sub

    Private Sub btnAccionAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAccionAgregarCliente.Click
        Dim validacion1 As Boolean = validarIDs(tbIdEmpleadoAgregar, tbIdEmpleadoAgregar.Text)
        Dim validacion2 As Boolean = validarCorreos(tbCorreoEmpleadoAgregar, tbCorreoEmpleadoAgregar.Text)
        Dim validacion3 As Boolean = validarTelefonos(tbTelefonoEmpleadoAgregar, tbTelefonoEmpleadoAgregar.Text)
        Dim validacion5 As Boolean = validarNOmbreYApellidos(tbNombreEmpleadoAgregar, tbNombreEmpleadoAgregar.Text)
        Dim validacion6 As Boolean = validarNOmbreYApellidos(tbApellido1EmpleadoAgregar, tbApellido1EmpleadoAgregar.Text)
        Dim validacion7 As Boolean = validarNOmbreYApellidos(tbApellido2EmpleadoAgregar, tbApellido2EmpleadoAgregar.Text)
        Dim validacion8 As Boolean = validarAlta(tbAltaClienteAgregar, tbAltaClienteAgregar.Text)

        If validacion1 = False And validacion2 = False And validacion3 = False And validacion5 = False And validacion6 = False And validacion7 = False And validacion8 = False Then
            falseoProgressBar()
            AgregarCliente(tbIdClienteAgregar.Text, tbNombreClienteAgregar.Text, tbApellido1ClienteAgregar.Text, tbApellido2ClienteAgregar.Text, tbTelefonoClienteAgregar.Text, tbCorreoClienteAgregar.Text, dtpFechaAltaClienteAgregar.Value.Date, tbAltaClienteAgregar.Text)
        End If
    End Sub

    Private Sub btnAccionAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAccionAgregarProducto.Click
        Dim validacion1 As Boolean = validarIDs(tbGamaProductoAgregar, tbGamaProductoAgregar.Text)
        Dim validacion2 As Boolean = validarPrecio(tbPrecioProductoAgregar, tbPrecioProductoAgregar.Text)
        Dim validacion3 As Boolean = validarGama(tbGamaProductoAgregar, tbGamaProductoAgregar.Text)

        If validacion1 = False And validacion2 = False And validacion3 = False Then
            falseoProgressBar()
            AgregarProducto(tbIdProductoAgregar.Text, tbNombreProductoAgregar.Text, tbPrecioProductoAgregar.Text, tbProveedorProductoAgregar.Text, tbGamaProductoAgregar.Text)
        End If
    End Sub

    Private Sub btnAccionAgregarGasolina_Click(sender As Object, e As EventArgs) Handles btnAccionAgregarGasolina.Click
        Dim validacion1 As Boolean = validarIDs(tbIdGasolinaAgregar, tbIdGasolinaAgregar.Text)
        Dim validacion2 As Boolean = validarPrecio(tbPrecioGasolinaAgregar, tbPrecioGasolinaAgregar.Text)
        Dim validacion3 As Boolean = validarCantidad(tbCantidadGasolinaAgregar, tbCantidadGasolinaAgregar.Text)
        If validacion1 = False And validacion2 = False And validacion3 = False Then
            falseoProgressBar()
            AgregarGasolina(tbIdGasolinaAgregar.Text, tbNombreGasolinaAgregar.Text, tbCantidadGasolinaAgregar.Text, tbPrecioGasolinaAgregar.Text)
        End If
    End Sub

    Private Sub btnAccionAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAccionAgregarProveedor.Click
        Dim validacion1 As Boolean = validarIDs(tbIdProveedorAgregar, tbIdProveedorAgregar.Text)
        Dim validacion2 As Boolean = validarNombreEmpresa(tbNombreProveedorAgregar, tbNombreProveedorAgregar.Text)
        If validacion1 = False And validacion2 = False Then
            falseoProgressBar()
            AgregarProveedor(tbIdProveedorAgregar.Text, tbNombreProveedorAgregar.Text)
        End If
    End Sub

    Private Sub btnAccionModificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAccionModificarEmpleado.Click

        Dim validacion1 As Boolean = validarIDs(tbIdEmpleadoModificar, tbIdEmpleadoModificar.Text)
        Dim validacion2 As Boolean = validarCorreos(tbCorreoEmpleadoModificar, tbCorreoEmpleadoModificar.Text)
        Dim validacion3 As Boolean = validarTelefonos(tbTelefonoEmpleadoModificar, tbTelefonoEmpleadoModificar.Text)
        Dim validacion4 As Boolean = validarContraseñas(tbContraseñaEmpleadoModificar, tbContraseñaEmpleadoModificar.Text)
        Dim validacion5 As Boolean = validarNOmbreYApellidos(tbNombreEmpleadoModificar, tbNombreEmpleadoModificar.Text)
        Dim validacion6 As Boolean = validarNOmbreYApellidos(tbApellido1EmpleadoModificar, tbApellido1EmpleadoModificar.Text)
        Dim validacion7 As Boolean = validarNOmbreYApellidos(tbApellido2EmpleadoModificar, tbApellido2EmpleadoModificar.Text)
        If validacion1 = False And validacion2 = False And validacion3 = False And validacion4 = False And validacion5 = False And validacion6 = False And validacion7 = False Then
            falseoProgressBar()
            ModificarUsuario(tbIdEmpleadoModificar.Text, tbNombreEmpleadoModificar.Text, tbApellido1EmpleadoModificar.Text, tbApellido2EmpleadoModificar.Text, tbTelefonoEmpleadoModificar.Text, tbCorreoEmpleadoModificar.Text,
                        tbContraseñaEmpleadoModificar.Text, tbCargoEmpleadoModificar.Text, tbAdministradorEmpleadoModificar.Text)
        End If
    End Sub

    Private Sub btnAccionModificarCliente_Click(sender As Object, e As EventArgs) Handles btnAccionModificarCliente.Click

        Dim validacion1 As Boolean = validarIDs(tbIdClienteModificar, tbIdClienteModificar.Text)
        Dim validacion2 As Boolean = validarCorreos(tbCorreoClienteModificar, tbCorreoClienteModificar.Text)
        Dim validacion3 As Boolean = validarTelefonos(tbTelefonoClienteModificar, tbTelefonoClienteModificar.Text)
        Dim validacion5 As Boolean = validarNOmbreYApellidos(tbNombreClienteModificar, tbNombreClienteModificar.Text)
        Dim validacion6 As Boolean = validarNOmbreYApellidos(tbApellido1ClienteModificar, tbApellido1ClienteModificar.Text)
        Dim validacion7 As Boolean = validarNOmbreYApellidos(tbApellido2ClienteModificar, tbApellido2ClienteModificar.Text)
        Dim validacion8 As Boolean = validarAlta(tbAltaClienteModificar, tbAltaClienteModificar.Text)
        If validacion1 = False And validacion2 = False And validacion3 = False And validacion5 = False And validacion6 = False And validacion7 = False Then
            falseoProgressBar()
            ModificarCliente(tbIdClienteModificar.Text, tbNombreClienteModificar.Text, tbApellido1ClienteModificar.Text, tbApellido2ClienteModificar.Text, tbTelefonoClienteModificar.Text,
            tbCorreoClienteModificar.Text, dtmFechaAltaClienteModificar.Value.Date, tbAltaClienteModificar.Text)
        End If
    End Sub

    Private Sub btnAccionModificarProducto_Click(sender As Object, e As EventArgs) Handles btnAccionModificarProducto.Click

        Dim validacion1 As Boolean = validarIDs(tbIdProductoModificar, tbIdProductoModificar.Text)
        Dim validacion2 As Boolean = validarPrecio(tbPrecioProductoModificar, tbPrecioProductoModificar.Text)
        Dim validacion3 As Boolean = validarGama(tbGamaProductoModificar, tbGamaProductoModificar.Text)
        If validacion1 = False And validacion2 = False And validacion3 = False Then
            falseoProgressBar()
            ModificarProductos(tbIdProductoModificar.Text, tbNombreProductoModificar.Text, tbPrecioProductoModificar.Text, tbProveedorProductoModificar.Text, tbGamaProductoModificar.Text)
        End If
    End Sub

    Private Sub btnAccionModificarGasolina_Click(sender As Object, e As EventArgs) Handles btnAccionModificarGasolina.Click

        Dim validacion1 As Boolean = validarIDs(tbIdGasolinaModificar, tbIdGasolinaModificar.Text)
        Dim validacion2 As Boolean = validarCantidad(tbCantidadGasolinaModificar, tbCantidadGasolinaModificar.Text)
        Dim validacion3 As Boolean = validarPrecio(tbPrecioGasolinaModificar, tbPrecioGasolinaModificar.Text)
        If validacion1 = False And validacion2 = False And validacion3 = False Then
            falseoProgressBar()
            ModificarGasolina(tbIdGasolinaModificar.Text, tbNombreGasolinaModificar.Text, tbCantidadGasolinaModificar.Text, tbPrecioGasolinaModificar.Text)
        End If
    End Sub

    Private Sub btnAccionModificarProveedor_Click(sender As Object, e As EventArgs) Handles btnAccionModificarProveedor.Click
        Dim validacion1 As Boolean = validarIDs(tbIdModificarProveedor, tbIdModificarProveedor.Text)
        Dim validacion2 As Boolean = validarNombreEmpresa(tbNombreProveedorModificar, tbNombreProveedorModificar.Text)
        If validacion1 = False And validacion2 = False Then
            falseoProgressBar()
            ModificarProveedores(tbIdModificarProveedor.Text, tbNombreProveedorModificar.Text)
        End If
    End Sub

    Private Sub btnAccionEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAccionEliminarEmpleado.Click
        Dim validacion1 As Boolean = validarIDs(tbIdEmpleadoEliminar, tbIdEmpleadoEliminar.Text)
        If validacion1 = False Then
            falseoProgressBar()
            EliminarEmpleado(tbIdEmpleadoEliminar.Text)
        End If
    End Sub
    Private Sub btnAccionEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnAccionEliminarProducto.Click
        Dim validacion1 As Boolean = validarIDs(tbIdProductoEliminar, tbIdProductoEliminar.Text)
        If validacion1 = False Then
            falseoProgressBar()
            EliminarProducto(tbIdProductoEliminar.Text)
        End If
    End Sub
    Private Sub btnAccionEliminarGasolina_Click(sender As Object, e As EventArgs) Handles btnAccionEliminarGasolina.Click
        Dim validacion1 As Boolean = validarIDs(tbIdGasolinaEliminar, tbIdGasolinaEliminar.Text)
        If validacion1 = False Then
            falseoProgressBar()
            EliminarGasolina(tbIdGasolinaEliminar.Text)
        End If
    End Sub
    Private Sub btnAccionEliminarProveedor_Click(sender As Object, e As EventArgs) Handles btnAccionEliminarProveedor.Click
        Dim validacion1 As Boolean = validarIDs(tbIdProveedorEliminar, tbIdProveedorEliminar.Text)
        If validacion1 = False Then
            falseoProgressBar()
            EliminarProveedor(tbIdProveedorEliminar.Text)
        End If
    End Sub

    Private Sub btnAccionEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnAccionEliminarCliente.Click
        Dim validacion1 As Boolean = validarIDs(tbIdClienteEliminar, tbIdClienteEliminar.Text)
        If validacion1 = False Then
            falseoProgressBar()
            EliminarCliente(tbIdClienteEliminar.Text)
        End If
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
            MsgBox("Hubo un error con la busqueda del Cliente, trate de introducir bien los datos")
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
            MsgBox("Hubo un error con la busqueda del Empleado, trate de introducir bien los datos")
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
            MsgBox("Hubo un error con la busqueda del producto, trate de introducir bien los datos")
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
            MsgBox("Hubo un error con la busqueda de la gasolina, trate de introducir bien los datos")
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
            MsgBox("Hubo un error con la busqueda del proveedor, trate de introducir bien los datos")
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



    Private Sub MostrarTodosEmpelados()
        Try
            Dim cmd As New OleDbCommand("SELECT * FROM Empleados", conn)
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            EmpleadosDataGridView.DataSource = dt
            EmpleadosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox("Hubo un error con la muestra de todos los usuarios")
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
            ClientesDataGridView.DataSource = dt
            ClientesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MsgBox("Hubo un error con la muestra de los clientes")
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
            GasolinasDataGridView.DataSource = dt
            GasolinasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox("Hubo un error con la muestra de las gasolinas")
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
            ProductosDataGridView.DataSource = dt
            ProductosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox("Hubo un error con la muestra de los productos")
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
            ProveedoresDataGridView.DataSource = dt
            ProveedoresDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox("Hubo un error con la muestra de los proveedores")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, MostrarTodosProveedores()")
        End Try
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
                If Not administrador = 2 Then
                    cmd.ExecuteNonQuery()
                    MsgBox("El empleado: " & nombre & " se ha agregado correctamente")
                Else
                    MsgBox("No se permiten crear jefes, solo administradores y trabajadores")
                End If

            End Using
        Catch ex As Exception
            MsgBox("Hubo un error con la agregacion del empleado, trate de introducir bien los datos")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, AgregarEmpleado()")
        Finally
            conn.Close()
        End Try




    End Sub


    Public Sub AgregarProducto(id As Integer, nombre As String, precio As Single, proveedor As Integer, gama As Integer)

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
            MsgBox("Hubo un error con la agregacion del producto, trate de introducir bien los datos")
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
            MsgBox("Hubo un error con la agregacion del Cliente, trate de introducir bien los datos")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, AgregarCliente()")
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub AgregarGasolina(id As Integer, nombre As String, cantidad As Integer, precio As Single)

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
            MsgBox("Hubo un error con la agregacion de la gasolina, trate de introducir bien los datos")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, AgregarGasolina()")
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
            MsgBox("Hubo un error con la agregacion del proveedor, trate de introducir bien los datos")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, AgregarProveedor()")
        Finally
            conn.Close()
        End Try

    End Sub






    Private Sub ModificarUsuario(id As Integer, nombre As String, apellido1 As String, apellido2 As String, telefono As String, correo As String, contraseña As String, cargo As String, administrador As Integer)

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
                    MsgBox("No se pudo hacer la Modificacion ya que el Jefe no se puede modificar")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Usuario actualizado con exito")
                End If

            End Using

        Catch ex As Exception

            MsgBox("Hubo un error con la Modificacion del usuario, trate de introducir bien los datos")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, ModificarUsuario()")

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

            MsgBox("Hubo un error con la Modificacion del cliente, trate de introducir bien los datos")
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
            Using cmd0 As New OleDbCommand("Select id from Proveedores where id = @id", conn)
                cmd0.Parameters.AddWithValue("@id", proveedor)

                Dim reader As OleDbDataReader = cmd0.ExecuteReader()
                If reader.HasRows() Then
                    While reader.Read()
                        If reader("id").ToString() = proveedor Then
                            comprobar = True
                        End If
                    End While
                End If

            End Using

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
                End If

            End Using

            Using cmd As New OleDbCommand("Update Productos set nombre = @nombre, precio = @precio, proveedor = @proveedor, gama = @gama where id = @id", conn)
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@precio", precio)
                cmd.Parameters.AddWithValue("@proveedor", proveedor)
                cmd.Parameters.AddWithValue("@gama", gama)
                cmd.Parameters.AddWithValue("@id", id)
                If comprobar = True And comprobar2 = True Then
                    cmd.ExecuteNonQuery()
                    MsgBox("Se ha actualizado el producto correctamente")
                Else
                    MsgBox("No se pudo hacer la modificacion, no existe o la gama o el proveedor")
                End If
            End Using

        Catch ex As Exception

            MsgBox("Hubo un error con la Modificacion del producto, trate de introducir bien los datos")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, ModificarProducto()")

        Finally
            conn.Close()
        End Try

    End Sub




    Private Sub ModificarGasolina(id As Integer, nombre As String, cantidad As Integer, precio As Single)

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
            MsgBox("Hubo un error con la Modificacion de la gasolina, trate de introducir bien los datos")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, ModificarGasolina()")
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
            MsgBox("Hubo un error con la Modificacion del proveedor, trate de introducir bien los datos")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, ModificarProveedor()")
        Finally
            conn.Close()
        End Try
    End Sub


    Public Sub EliminarEmpleado(id As Integer)
        Try
            conn.Open()
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
        Catch ex As Exception
            MsgBox("Hubo un error con la Eliminacion del empleado, trate de introducir bien los datos")
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
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Cliente eliminado correctamente")
        Catch ex As Exception
            MsgBox("Hubo un error con la Eliminacion del Cliente, trate de introducir bien los datos")
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
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Producto eliminado correctamente")
        Catch ex As OleDbException
            MsgBox("Hubo un error con la Eliminacion del producto, trate de introducir bien los datos")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, EliminarProducto()")
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
            MsgBox("Hubo un error con la Eliminacion de la gasolina, trate de introducir bien los datos")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, EliminarGasolina()")
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
            MsgBox("Hubo un error con la Eliminacion del empleado, trate de introducir bien los datos")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, EliminarProveedor()")
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

    Private Sub VolverToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Hide()
        Opciones.Show()
    End Sub


    '------------------------------------------------------------------------------------------------------------------------
    '--------------------------------Zona de validaciones de los textbox-----------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------

    Public Function validarIDs(tb As TextBox, str As String) As Boolean

        If str = "" Then
            MsgBox("El campo de ID no puede estar vacio")
            Return True
        ElseIf Not IsNumeric(str) Then
            MsgBox("El campo de ID solo puede contener numeros")
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
        Dim comprobar As Boolean = False
        If str = "" Then
            MsgBox("El campo de telefono no puede estar vacio")
            Return True
        Else
            For i As Integer = 0 To str.Length - 1
                If Not permitidos.Contains(str(i)) Then
                    comprobar = True
                End If
            Next
            If comprobar = True Then
                MsgBox("El campo de telefono solo puede contener numeros y el prefijo (+)")
                tb.Clear()
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function validarCorreos(tb As TextBox, str As String) As Boolean
        'en este metodo validamos que el texbox de correo no este vacio. aparte
        'de que solo puede tener un @ y un punto. En caso de que tenga mas de un @
        'o mas de un punto, mostraremos un mensaje de error. Para ello utilizaremos una lista con caracteres permitidos
        Dim permitidos As New List(Of Char) From {"@", "."}
        Dim comprobar As Boolean = False
        If str = "" Then
            MsgBox("El campo de correo no puede estar vacio")
            Return True
        Else
            For i As Integer = 0 To str.Length - 1
                If Not permitidos.Contains(str(i)) Then
                    comprobar = True
                End If
            Next
            If comprobar = True Then
                MsgBox("El campo de correo solo puede contener un @ y un punto")
                tb.Clear()
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function validarContraseñas(tb As TextBox, str As String) As Boolean
        'en este metodo validamos que el texbox de contraseña no este vacio. aparte
        'de que solo puede tener letras y numeros. En caso de que tenga caracteres especiales
        'mostraremos un mensaje de error. Para ello utilizaremos una lista con caracteres permitidos
        Dim permitidos As New List(Of Char) From {"!", "#", "$", "%", "&", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "[", "\", "]", "^", "_", "{", "|", "}", "~"}
        Dim comprobar As Boolean = False
        If str = "" Then
            MsgBox("El campo de contraseña no puede estar vacio")
            Return True
        Else
            For i As Integer = 0 To str.Length - 1
                If permitidos.Contains(str(i)) Then
                    comprobar = True
                End If
            Next
            If comprobar = True Then
                MsgBox("El campo de contraseña no puede contener caracteres especiales")
                tb.Clear()
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function validarNOmbreYApellidos(tb As TextBox, str As String) As Boolean

        Dim permitidos As New List(Of Char) From {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim comprobar As Boolean = False
        If str = "" Then
            MsgBox("El campo no puede estar vacio")
            Return True
        Else
            For i As Integer = 0 To str.Length - 1
                If Not permitidos.Contains(str(i)) Then
                    comprobar = True
                End If
            Next
            If comprobar = True Then
                MsgBox("El campo solo puede contener letras")
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
            MsgBox("El campo no puede estar vacio")
            Return True
        ElseIf Not IsNumeric(str) Then
            MsgBox("Solo son permitidos caracteres Numericos en la cantidad")
            tb.Clear()
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
            MsgBox("No se pueden agregar ni comas ni puntos")
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
            MsgBox("El campo de precio no puede estar vacio")
            Return True
        ElseIf Not IsNumeric(str) Then
            MsgBox("El campo precio debe de ser numerico")
            tb.Clear()
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
                MsgBox("Error, dentro del campo hay mas de un punto o una coma")
                tb.Clear()
                Return True
            ElseIf contadorPuntos = 1 And contadorComas = 1 Then
                MsgBox("No se puede meter dentro del campo un punto y una coma a la vez")
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
                MsgBox("El id de la gama no existe")
                tb.Clear()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Hubo un error con la validacion de la gama: " & ex.Message)
            Return True
        Finally
            conn.Close()
        End Try

    End Function
    Public Function validarNombreEmpresa(tb As TextBox, str As String) As Boolean
        'en esta funcion solamente validaremos que no este vacio el campo de nombre de la empresa
        If str = "" Then
            MsgBox("El campo de nombre no puede estar vacio")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validarAlta(tb As TextBox, str As String) As Boolean

        If str = "" Then
            MsgBox("El campo de altas no puede estar vacio")
            Return True
        ElseIf ((Not str = 1) Or (Not str = 0)) Then
            MsgBox("Los valores del alta deben ser o 1 o 0")
            Return True
        ElseIf (Not IsNumeric(str)) Then
            MsgBox("Debe de ser numerico el valor del alta.")
            Return True
        Else
            Return False
        End If

    End Function


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

End Class