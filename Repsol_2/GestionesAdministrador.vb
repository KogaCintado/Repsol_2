Public Class GestionesAdministrador
    Private Sub GestionesAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'datagridviews a tomar por culo de forma guarra para que no se vean
        ProductosDataGridView.Location = New Point(3000, 3000)
        EmpleadosDataGridView.Location = New Point(3000, 3000)
        ClientesDataGridView.Location = New Point(3000, 3000)

        'Maximize the window
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Opciones.Show()
        Me.Hide()
    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Repsol_dbDataSet)

    End Sub

    Private Sub btnVerTodosProductos_Click(sender As Object, e As EventArgs) Handles btnVerTodosProductos.Click
        'TODO: This line of code loads data into the 'Repsol_dbDataSet.Productos' table. You can move, or remove it, as needed.
        Me.ProductosTableAdapter.Fill(Me.Repsol_dbDataSet.Productos)
        ProductosDataGridView.Visible = True
        ProductosDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerTodosEmpleados_Click(sender As Object, e As EventArgs) Handles btnVerTodosEmpleados.Click
        'TODO: This line of code loads data into the 'Repsol_dbDataSet.Empleados' table. You can move, or remove it, as needed.
        Me.EmpleadosTableAdapter.Fill(Me.Repsol_dbDataSet.Empleados)
        EmpleadosDataGridView.Visible = True
        EmpleadosDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerTodosClientes_Click(sender As Object, e As EventArgs) Handles btnVerTodosClientes.Click
        'TODO: This line of code loads data into the 'Repsol_dbDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.Repsol_dbDataSet.Clientes)
        ClientesDataGridView.Visible = True
        ClientesDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerTodasGasolinas_Click(sender As Object, e As EventArgs) Handles btnVerTodasGasolinas.Click
        'TODO: This line of code loads data into the 'Repsol_dbDataSet.Gasolinas' table. You can move, or remove it, as needed.
        Me.GasolinasTableAdapter.Fill(Me.Repsol_dbDataSet.Gasolinas)
        GasolinasDataGridView.Visible = True
        GasolinasDataGridView.Location = New Point(476, 81)
    End Sub

    Private Sub btnVerTodosProveedores_Click(sender As Object, e As EventArgs) Handles btnVerTodosProveedores.Click
        'TODO: This line of code loads data into the 'Repsol_dbDataSet.Proveedores' table. You can move, or remove it, as needed.
        Me.ProveedoresTableAdapter.Fill(Me.Repsol_dbDataSet.Proveedores)
        ProveedoresDataGridView.Visible = True
        ProveedoresDataGridView.Location = New Point(476, 81)
    End Sub
End Class