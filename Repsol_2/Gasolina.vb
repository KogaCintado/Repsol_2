Public Class Gasolina
    Dim contador As Integer = 0
    Dim imageList As New ImageList()


    Private Sub Gasolina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agrega imágenes al ImageList
        imageList.Images.Add(My.Resources.Imagen1)
        imageList.Images.Add(My.Resources.Imagen2)
        imageList.Images.Add(My.Resources.Imagen3)

        ' Asigna el ImageList al PictureBox
        PictureBox1.Image = imageList.Images(0)

        ' Configura el Timer
        Timer1.Interval = 1000 ' Intervalo en milisegundos (en este caso, 1 segundo)
        Timer1.Start()
    End Sub


    Private Sub lblPrecioGas_Click(sender As Object, e As EventArgs) Handles lblPrecioGas.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Cambia la imagen cada vez que se activa el Timer
        contador += 1

        If contador >= imageList.Images.Count Then
            contador = 0
        End If

        PictureBox1.Image = imageList.Images(contador)
    End Sub
End Class