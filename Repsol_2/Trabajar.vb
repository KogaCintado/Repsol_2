Public Class Trabajar
    Private Sub Trabajar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximizamos la ventana
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Opciones.Show()
        Me.Close()
    End Sub

    Private Sub btnTienda_Click(sender As Object, e As EventArgs) Handles btnTienda.Click
        TPV.Show()
        Me.Hide()
    End Sub
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    'Cerramos el programa.
    Private Sub CerrarElProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicaciónToolStripMenuItem.Click
        Inicio.Close()
    End Sub

    Private Sub pbManguera_Click(sender As Object, e As EventArgs) Handles pbManguera1.Click, pbManguera2.Click, pbManguera3.Click, pbManguera4.Click
        Gasolina.Show()
    End Sub
End Class