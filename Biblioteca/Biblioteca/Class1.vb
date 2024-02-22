Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Namespace validaciones

    Public Class validacionNombreyContra

        'esta funcion validara que los textbox no puedan tener los siguientes caracteres--> (){}[]!¡¿?*+-,.;:_=|@#~¬^`´¨ºª\%&$€£<>¡
        Public Function validarCaracteres(ByVal nombre As String) As Boolean
            Dim valido As Boolean = True
            Dim caracteresProhibidos As String = "(){}[]!¡¿?*+-,.;:_=|@#~¬^`´¨ºª\%&$€£<>¡"
            For i As Integer = 0 To caracteresProhibidos.Length - 1
                If nombre.Contains(caracteresProhibidos(i)) Then
                    valido = False
                    Exit For
                End If
            Next
            Return valido
        End Function

        'Esta funcion lo que hace es validar que la longitud de los campos (textbox) no sea superior a 10 caracteres
        Public Function validarLongitud(ByVal nombre As String) As Boolean
            Dim valido As Boolean = True
            If nombre.Length > 10 Then
                valido = False
            End If
            Return valido
        End Function

        ''' <summary>
        ''' Comprueba si el texto está dentro de la longitud permitida
        ''' </summary>
        ''' <param name="objetoConTexto">Objeto con parámetro TextLength, como un TextBox o un Label</param>
        ''' <param name="longitudMaxima">Máxima longitud permitida del texto</param>
        ''' <returns>Verdadero si es la longitud máxima</returns>
        Public Function IsMaxLength(ByRef objetoConTexto As Object, ByVal longitudMaxima As Integer) As Boolean
            If objetoConTexto.TextLength = longitudMaxima Then
                Return True
            End If
            Return False
        End Function
    End Class


End Namespace


'Clase encargada de guardar los errores en un fichero, de modo que sea más fácil de solucionar los problemas para el técnico.
Public Class Archivo

    ''' <summary>
    ''' Guarda la excepción en un fichero de texto, con la fecha de cuando ha sido efectuado.
    ''' </summary>
    ''' <param name="excepcionAGuardar">Excepción controlada(Suele llamarse ex).</param>
    ''' <param name="lugarDelError">Nombre del método donde ocurre el error.</param>
    Public Sub GuardarError(excepcionAGuardar As Exception, lugarDelError As String)
        Dim n As String = " Error localizado en " + lugarDelError + ", contacte con el administrador." + vbCrLf + excepcionAGuardar.ToString
        GuardarDatosEnArchivo("config\errores.txt", n + vbCrLf)
    End Sub



    'Guarda los datos en un fichero.
    Public Function GuardarDatosEnArchivo(ruta As String, texto As String) As Boolean
        Try
            My.Computer.FileSystem.WriteAllText(ruta, Now.ToString + " " + texto + vbCrLf, True)
            Return True
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al guardar los datos en el archivo. Vuelva a intentarlo más tarde.", 16, "Error al guardar los datos")
            'GuardarError(ex, "GuardarDatosEnArchivo")
        End Try

        Return False
    End Function
End Class

'Clase para imprimir ticket, tiene dos procedimientos, uno por método de pago.
Public Class Ticket
    Private printDocument As New PrintDocument()

    Dim user, tarjeta As String
    Dim nombreProductos, precioProductos As ListBox

    Dim resultado, dinero, devolver As String


    Public Sub ImprimirTicketEfectivo(user As String, resultado As String, nombreProductos As ListBox, precioProductos As ListBox, dinero As String, devolver As String)
        printDocument = New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf TicketEfectivo
        Me.user = user
        Me.resultado = resultado
        Me.nombreProductos = nombreProductos
        Me.precioProductos = precioProductos
        Me.dinero = dinero
        Me.devolver = devolver

        ' Puedes personalizar las configuraciones de impresión aquí
        Dim printerSettings As New PrinterSettings()
        printDocument.PrinterSettings = printerSettings

        ' Inicia la impresión
        printDocument.Print()
    End Sub

    Public Sub ImprimirTicketTarjeta(user As String, tarjeta As String, resultado As String, nombreProductos As ListBox, precioProductos As ListBox)
        Me.user = user
        Me.resultado = resultado
        Me.tarjeta = tarjeta
        Me.nombreProductos = nombreProductos
        Me.precioProductos = precioProductos

        Try
            For i As Integer = 1 To 2
                printDocument = New PrintDocument()
                AddHandler printDocument.PrintPage, AddressOf TicketTarjeta
                ' Puedes personalizar las configuraciones de impresión aquí
                Dim printerSettings As New PrinterSettings()
                printDocument.PrinterSettings = printerSettings
                ' Inicia la impresión
                printDocument.Print()
            Next

        Catch ex As Exception
            MsgBox("Ha ocurrido un error al imprimir el ticket. Vuelva a intentarlo más tarde.", 16, "Error al imprimir el ticket")
            Dim archivo As New Archivo
            archivo.GuardarError(ex, "Print ticket tarjeta")
        End Try
    End Sub
    Private Sub TicketTarjeta(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Try
            Dim x, y, w As Integer
            Dim precioSinIva, dif As Single
            precioSinIva = CSng(resultado).ToString("N2") * 0.79
            dif = CSng(resultado).ToString("N2") - precioSinIva
            x = 160
            w = 220
            y = 240
            ev.Graphics.DrawImage(My.Resources.Repsol_logo, x + 40, 120, 230, 100)
            ev.Graphics.DrawString("A-6, P.K. 7,800", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 55, y)
            y = y + 20
            ev.Graphics.DrawString("28040 Madrid", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 60, y)
            y = y + 20
            ev.Graphics.DrawString("Repsol SA", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 50, y)
            y = y + 20
            ev.Graphics.DrawString("CIF:A79707345", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 55, y)
            y = y + 20
            ev.Graphics.DrawString("FACTURA SIMPLIFICADA", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 240, y)
            y = y + 20
            ev.Graphics.DrawString("----------------------------------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 20
            ev.Graphics.DrawString(Now, New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 50, y)
            y = y + 20
            ev.Graphics.DrawString("----------------------------------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 20
            For a = 0 To nombreProductos.Items.Count - 1
                'ev.Graphics.DrawString("ñ", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w - 40, y)
                ev.Graphics.DrawString(nombreProductos.Items.Item(a), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w, y)
                ev.Graphics.DrawString(precioProductos.Items.Item(a), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 160, y)
                ev.Graphics.DrawString(CSng(precioProductos.Items.Item(a) * 1).ToString("N2"), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 200, y)
                y = y + 20
            Next
            ev.Graphics.DrawString("----------------------------------------------------", New Font("Arial", 13, FontStyle.Regular), Brushes.Black, x, y)
            y = y + 20

            ev.Graphics.DrawString("TOTAL: " + CSng(resultado).ToString("N2") + " €", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, w + 80, y)
            y = y + 25
            ev.Graphics.DrawString("IVA INCLUIDO", New Font("Arial", 6, FontStyle.Regular), Brushes.Black, w + 170, y)
            y = y + 20
            ev.Graphics.DrawString("----------------------------------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 20
            ev.Graphics.DrawString("Base imp", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w, y)
            ev.Graphics.DrawString("%IVA", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 80, y)
            ev.Graphics.DrawString("IVA", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 160, y)
            y = y + 20
            ev.Graphics.DrawString(precioSinIva, New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w, y)
            ev.Graphics.DrawString("21%", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 80, y)
            ev.Graphics.DrawString(CSng(dif).ToString("N2"), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 160, y)
            y = y + 20
            ev.Graphics.DrawString("Forma de pago:", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 60, y)
            y = y + 20
            ev.Graphics.DrawString("TARJETA:", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, w, y)
            y = y + 20
            ev.Graphics.DrawString(tarjeta, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, w, y)
            y = y + 20
            ev.Graphics.DrawString("ENTREGA: ", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, w, y)
            ev.Graphics.DrawString(CSng(resultado).ToString("N2"), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 380, y)
            y = y + 20
            ev.Graphics.DrawString("Le atendió: " & user, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, w + 40, y)
            y = y + 20
            ev.Graphics.DrawString("----------------------------------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 20
            ev.Graphics.DrawString("----------------------------------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 20
            ev.Graphics.DrawString("CONSERVE SU TICKET", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, w + 20, y)
            y = y + 20
            ev.Graphics.DrawString("HASTA RETIRAR SU PRODUCTO", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, w - 20, y)
            y = y + 20
            ev.Graphics.DrawString("GRACIAS POR SU VISITA", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, w + 15, y)
            y = y + 20
            ev.Graphics.DrawString("-----------------------------------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 20
            ev.Graphics.DrawString("------------------------FIRMA------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 20
            ev.Graphics.DrawString("-----------------------------------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 100
            ev.HasMorePages = False
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al imprimir el ticket. Vuelva a intentarlo más tarde.", 16, "Error al imprimir el ticket")
            Dim archivo As New Archivo
            archivo.GuardarError(ex, "Print ticket tarjeta")
        End Try
    End Sub
    Private Sub TicketEfectivo(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Try
            Dim x, y, w As Integer
            Dim precioSinIva, dif As Single
            precioSinIva = CSng(resultado).ToString("N2") * 0.79
            dif = CSng(resultado).ToString("N2") - precioSinIva
            x = 160
            w = 220
            y = 240
            ev.Graphics.DrawImage(My.Resources.Repsol_logo, x + 40, 120, 230, 100)
            ev.Graphics.DrawString("A-6, P.K. 7,800", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 55, y)
            y = y + 20
            ev.Graphics.DrawString("28040 Madrid", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 60, y)
            y = y + 20
            ev.Graphics.DrawString("Repsol SA", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 50, y)
            y = y + 20
            ev.Graphics.DrawString("CIF:A79707345", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 55, y)
            y = y + 20
            ev.Graphics.DrawString("FACTURA SIMPLIFICADA", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 240, y)
            y = y + 20
            ev.Graphics.DrawString("----------------------------------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 20
            ev.Graphics.DrawString(Now, New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 50, y)
            y = y + 20
            ev.Graphics.DrawString("----------------------------------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 20
            For a = 0 To nombreProductos.Items.Count - 1
                'ev.Graphics.DrawString("ñ", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w - 40, y)
                ev.Graphics.DrawString(nombreProductos.Items.Item(a), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w, y)
                ev.Graphics.DrawString(precioProductos.Items.Item(a), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 160, y)
                ev.Graphics.DrawString(CSng(precioProductos.Items.Item(a) * 1).ToString("N2"), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 200, y)
                y = y + 20
            Next
            ev.Graphics.DrawString("----------------------------------------------------", New Font("Arial", 13, FontStyle.Regular), Brushes.Black, x, y)
            y = y + 20

            ev.Graphics.DrawString("TOTAL: " + CSng(resultado).ToString("N2") + " €", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, w + 80, y)
            y = y + 25
            ev.Graphics.DrawString("IVA INCLUIDO", New Font("Arial", 6, FontStyle.Regular), Brushes.Black, w + 170, y)
            y = y + 20
            ev.Graphics.DrawString("----------------------------------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 20
            ev.Graphics.DrawString("Base imp", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w, y)
            ev.Graphics.DrawString("%IVA", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 80, y)
            ev.Graphics.DrawString("IVA", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 160, y)
            y = y + 20
            ev.Graphics.DrawString(precioSinIva, New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w, y)
            ev.Graphics.DrawString("21%", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 80, y)
            ev.Graphics.DrawString(CSng(dif).ToString("N2"), New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 160, y)
            y = y + 20
            ev.Graphics.DrawString("Forma de pago:", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, w + 60, y)
            y = y + 20
            ev.Graphics.DrawString("EFECTIVO", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, w, y)
            ev.Graphics.DrawString(resultado, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 380, y)
            y = y + 20
            ev.Graphics.DrawString("ENTREGA:", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, w, y)
            ev.Graphics.DrawString(CSng(dinero).ToString("N2"), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 380, y)
            y = y + 20
            ev.Graphics.DrawString("DEVOLUCIÓN:", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, w, y)
            ev.Graphics.DrawString(CSng(devolver).ToString("N2"), New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 380, y)
            y = y + 40
            ev.Graphics.DrawString("Le atendió: " & user, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, w + 40, y)
            y = y + 20
            ev.Graphics.DrawString("----------------------------------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 20
            ev.Graphics.DrawString("----------------------------------------------------", New Font("Arial", 13, FontStyle.Italic), Brushes.Black, x, y)
            y = y + 20
            ev.Graphics.DrawString("CONSERVE SU TICKET", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, w + 20, y)
            y = y + 20
            ev.Graphics.DrawString("HASTA RETIRAR SU PRODUCTO", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, w - 20, y)
            y = y + 20
            ev.Graphics.DrawString("GRACIAS POR SU VISITA", New Font("Arial", 10, FontStyle.Bold), Brushes.Black, w + 15, y)

            ev.HasMorePages = False
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al imprimir el ticket. Vuelva a intentarlo más tarde.", 16, "Error al imprimir el ticket")
            Dim archivo As New Archivo
            archivo.GuardarError(ex, "Print ticket efectivo")
        End Try
    End Sub
End Class