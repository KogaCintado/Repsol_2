Public Class Trabajar

    'Carga el formulario
    Private Sub Trabajar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximizamos la ventana
        Me.WindowState = FormWindowState.Maximized
        Me.lblUser.Text = Inicio.nombreEmp
    End Sub

    'Vuelve al formulario anterior.
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Opciones.Show()
        Me.Close()
    End Sub

    'Abre la TPV
    Private Sub btnTienda_Click(sender As Object, e As EventArgs) Handles btnTienda.Click
        TPV.Show()
        Me.Hide()
    End Sub

    'Cierra la sesión del usuario, volviendo al formulario Inicio.
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    'Cierra el programa.
    Private Sub CerrarElProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicaciónToolStripMenuItem.Click
        Inicio.Close()
    End Sub

    'Al presionar en uno de los PictureBox que se encuentran detrás de la imagen, abre el formulario Gasolina.
    Private Sub pbManguera_Click(sender As Object, e As EventArgs) Handles pbManguera1.Click, pbManguera2.Click, pbManguera3.Click, pbManguera4.Click
        Gasolina.Show()
        Me.Hide()
    End Sub
End Class