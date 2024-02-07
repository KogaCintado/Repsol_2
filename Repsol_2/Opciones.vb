Public Class Opciones

    Private Sub Opciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se carga el formulario. Es necesario saber si es administrador o no.
        If Inicio.admin = False Then
            btnCRUD.Enabled = True
            btnInformes.Enabled = True
        Else
            btnCRUD.Enabled = False
            btnInformes.Enabled = False
        End If
    End Sub
    Private Sub BtnInformes_Click(sender As Object, e As EventArgs) Handles btnInformes.Click

    End Sub

    Private Sub BtnCRUD_Click(sender As Object, e As EventArgs) Handles btnCRUD.Click
        GestionesAdministrador.Show()
        Me.Hide()

    End Sub

    Private Sub BtnTrabajar_Click(sender As Object, e As EventArgs) Handles btnTrabajar.Click

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    'Cerramos el programa.
    Private Sub CerrarElProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarElProgramaToolStripMenuItem.Click
        Inicio.Close()
    End Sub


End Class