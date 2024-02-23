
Imports System.Drawing.Printing

Public Class TarjetaRepsol
    Private Sub TarjetaRepsol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private WithEvents PrintDocument1 As New PrintDocument

    Public Sub Imprimir()
        ' Mostrar el cuadro de diálogo de impresión
        Dim printDialog As New PrintDialog()
        If printDialog.ShowDialog() = DialogResult.OK Then
            ' Configurar el PrintDocument
            PrintDocument1.PrinterSettings = printDialog.PrinterSettings
            PrintDocument1.DefaultPageSettings.Landscape = False ' Puedes ajustar la orientación según tus necesidades

            ' Iniciar la impresión
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Obtener el contenido del panel que deseas imprimir
        Dim bmp As New Bitmap(Panel1.Width, Panel1.Height)
        Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, Panel1.Width, Panel1.Height))

        ' Dibujar el contenido en la página de impresión
        e.Graphics.DrawImage(bmp, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub
End Class