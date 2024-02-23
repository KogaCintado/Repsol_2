
Imports System.Drawing.Printing

Public Class TarjetaRepsol

    Dim bmp As Bitmap

    Private WithEvents PrintDocument1 As New PrintDocument

    Public Sub Imprimir()
        ' Mostrar el cuadro de diálogo de impresión
        Dim PrintDocument As New PrintDocument()
        AddHandler PrintDocument.PrintPage, AddressOf PrintDocument1_PrintPage

        ' Configurar el PrintDocument
        PrintDocument1.PrinterSettings = PrintDocument.PrinterSettings
        PrintDocument1.DefaultPageSettings.Landscape = False ' Puedes ajustar la orientación según tus necesidades

        ' Iniciar la impresión
        PrintDocument1.Print()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Obtener el contenido del panel que deseas imprimir
        Dim bmp As New Bitmap(Panel1.Width, Panel1.Height)
        DibujarContenido(bmp, Panel1)
        Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, Panel1.Width, Panel1.Height))


        ' Dibujar el contenido en la página de impresión
        e.Graphics.DrawImage(bmp, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub

    Private Sub DibujarContenido(ByRef bmp As Bitmap, ByVal control As Control)
        ' Dibujar el control en el bitmap
        control.DrawToBitmap(bmp, New Rectangle(control.Location, control.Size))

        ' Llamar recursivamente a la función para los controles anidados
        For Each childControl As Control In control.Controls
            DibujarContenido(bmp, childControl)
        Next
    End Sub

    Private Sub TarjetaRepsol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class