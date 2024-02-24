Public Class Opciones

    Private Sub Opciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximizamos la ventana
        Me.WindowState = FormWindowState.Maximized
        'Se carga el formulario. Es necesario saber si es administrador o no.
        If Inicio.admin = True Then
            btnCRUD.Visible = True
            btnInformes.Visible = True
        Else
            btnCRUD.Visible = False
            btnInformes.Visible = False
        End If
    End Sub
    'esta funcion llama al formulario informes
    Private Sub BtnInformes_Click(sender As Object, e As EventArgs) Handles btnInformes.Click
        Informes.Show()
        Me.Hide()
    End Sub
    'esta funcion llama al formulario trabajar
    Private Sub BtnTrabajar_Click(sender As Object, e As EventArgs) Handles btnTrabajar.Click
        Trabajar.Show()
        Me.Close()
    End Sub
    'esta funcion cierra la sesion del usuario
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    'Cerramos el programa.
    Private Sub CerrarElProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarElProgramaToolStripMenuItem.Click
        Inicio.Close()
    End Sub
    'esta funcion llama al formulario crud
    Private Sub btnCRUD_Click_1(sender As Object, e As EventArgs) Handles btnCRUD.Click
        GestionesDelAdministrador.Show()
        Me.Hide()
    End Sub
End Class