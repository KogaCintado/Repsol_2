Public Class TPV
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


End Class