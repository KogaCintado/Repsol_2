Public Class GestionesAdministrador
    Private Sub GestionesAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximize the window
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Opciones.Show()
        Me.Hide()
    End Sub
End Class