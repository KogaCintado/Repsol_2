Public Class TPV
    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub TPV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Limpia los listbox lbNombreProductos y lbPrecios menos el primer elemento.
        Dim box As String = lbNombreCategorias.GetItemText(0)
        lbNombreProductos.Items.Clear()
        Dim box1 As String = lbPrecios.GetItemText(0)
        lbPrecios.Items.Clear()
        lbNombreCategorias.Items.Add(box)
        lbPrecios.Items.Add(box1)

    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click

    End Sub
End Class