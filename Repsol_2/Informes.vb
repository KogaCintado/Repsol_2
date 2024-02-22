Public Class Informes
    Private Sub btnInformesEmpleados_Click(sender As Object, e As EventArgs) Handles btnInformesEmpleados.Click
        InformesEmpleados.Show()
        Me.Hide()
    End Sub

    Private Sub btnInformesClientes_Click(sender As Object, e As EventArgs) Handles btnInformesClientes.Click
        InformesClientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnInformesProductos_Click(sender As Object, e As EventArgs) Handles btnInformesProductos.Click
        InformesProductos.Show()
        Me.Hide()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub CerrarProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarProgramaToolStripMenuItem.Click
        End
    End Sub
End Class