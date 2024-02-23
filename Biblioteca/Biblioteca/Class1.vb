Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Data.OleDb

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

Public Class validacionesCrud

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")


    Public Function BuscarProveedor(id As Integer) As DataRow

        ' Crear una nueva instancia del comando SQL
        Dim cmd As New OleDbCommand("SELECT * FROM Proveedores WHERE id = @id", conn)

        ' Añadir el parámetro al comando SQL
        cmd.Parameters.AddWithValue("@id", id)

        ' Crear una nueva instancia del adaptador de datos
        Dim da As New OleDbDataAdapter(cmd)

        ' Crear una nueva instancia del DataSet
        Dim ds As New DataSet()

        Try
            ' Llenar el DataSet con los datos de la tabla Proveedores
            da.Fill(ds, "Proveedores")
        Catch ex As Exception
            MessageBox.Show("Hubo un error en la busqueda del proveedor, trate de introducir bien los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "GestionesAdministrador, BuscarProveedor()")
            Return Nothing
        End Try

        ' Comprobar si se encontró algún registro
        If ds.Tables("Proveedores").Rows.Count > 0 Then
            ' Devolver la primera fila
            Return ds.Tables("Proveedores").Rows(0)
        Else
            ' Si no se encontró ningún registro, devolver Nothing
            Return Nothing
        End If


    End Function


    Public Function validarIDs(tb As TextBox, str As String) As Boolean

        If str = "" Then
            MessageBox.Show("El campo id no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf Not IsNumeric(str) Then
            MessageBox.Show("El campo id solo puede contener numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validarTelefonos(tb As TextBox, str As String) As Boolean
        'en este metodo validamos que el texbox de telefono no este vacio. aparte
        'de que solo puede tener un prefijo (+) y numeros. En caso de que tenga mas de un (+)
        'o letras, mostraremos un mensaje de error. Para ello utilizaremos una lista con caracteres permitidos
        Dim permitidos As New List(Of Char) From {"+", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim contadormas As Integer = 0
        Dim comprobar As Boolean = False
        If str = "" Then
            MessageBox.Show("El campo telefono no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            For i As Integer = 0 To str.Length - 1
                If str(i) = "+" Then
                    contadormas += 1
                End If

                If (Not permitidos.Contains(str(i))) Or (contadormas > 1 Or contadormas = 0) Then
                    comprobar = True
                End If
            Next
            If comprobar = True Then
                MessageBox.Show("El campo telefono solo puede tener simbolos numericos, y el prefijo (+) una vez", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Clear()
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function validarAdministrador(tb As TextBox, num As String) As Boolean
        If num = "" Then
            MessageBox.Show("El campo administrador no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf Not IsNumeric(num) Then
            MessageBox.Show("El administrador debe de ser numerico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf num = "0" Then
            Return False
        ElseIf num = "1" Then
            Return False
        Else
            MessageBox.Show("Solo estan permitidos en el campo altas 0 y 1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        End If

    End Function

    Public Function validarCorreos(tb As TextBox, str As String) As Boolean

        Dim contadorpuntos As Integer = 0
        Dim contadorArrobas As Integer = 0

        If str.StartsWith("@") Then
            MessageBox.Show("Error, un correo electronico no puede empezar con un @", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        End If

        For i As Integer = 0 To str.Length - 1
            If str(i) = "." Then
                contadorpuntos += 1
            ElseIf str(i) = "@" Then
                contadorArrobas += 1
            End If
        Next

        If (contadorArrobas = 0 And contadorpuntos = 0) Or (contadorArrobas > 1 Or contadorpuntos > 1) Then
            MessageBox.Show("Error, compruebe el numero de arrobas y puntos del correo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validarContraseñas(tb As TextBox, str As String) As Boolean
        'en este metodo validamos que el texbox de contraseña no este vacio. aparte
        'de que solo puede tener letras y numeros. En caso de que tenga caracteres especiales
        'mostraremos un mensaje de error. Para ello utilizaremos una lista con caracteres permitidos
        Dim permitidos As New List(Of Char) From {"!", "#", "$", "%", "&", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "[", "\", "]", "^", "_", "{", "|", "}", "~"}
        Dim comprobar As Boolean = False
        If str = "" Then
            MessageBox.Show("El campo contraseña no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            For i As Integer = 0 To str.Length - 1
                If permitidos.Contains(str(i)) Then
                    comprobar = True
                End If
            Next
            If comprobar = True Then
                MessageBox.Show("El campo pruebas no puede tener caracteres especiales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Clear()
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function validarNOmbreYApellidos(tb As TextBox, str As String) As Boolean

        Dim permitidos As New List(Of Char) From {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "á", "é", "í", "ó", "ú", "Á", "É", "Í", "Ó", "Ú"}
        Dim comprobar As Boolean = False
        If str = "" Then
            MessageBox.Show("El campo no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            For i As Integer = 0 To str.Length - 1
                If Not permitidos.Contains(str(i)) Then
                    comprobar = True
                End If
            Next
            If comprobar = True Then
                MessageBox.Show("El campo solo puede tener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Clear()
                Return True
            Else
                Return False
            End If
        End If
    End Function



    Private Function validarCantidad(tb As TextBox, str As String) As Boolean
        Dim contadorComas As Integer = 0
        Dim contadorPuntos As Integer = 0

        If str = "" Then
            MessageBox.Show("El campo no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf Not IsNumeric(str) Then
            MessageBox.Show("Solo son permitidos caracteres numericos en la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        ElseIf str < 0 Then
            MessageBox.Show("La cantidad no puede ser menor que 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If

        For i As Integer = 0 To str.Length - 1
            If str(i) = "," Then
                contadorComas += 1
            ElseIf str(i) = "." Then
                contadorPuntos += 1
            End If
        Next

        If contadorComas > 0 Or contadorPuntos > 0 Or (contadorComas = 1 And contadorPuntos = 1) Then
            MessageBox.Show("No se pueden agregar ni comas ni puntos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        Else
            Return False
        End If

    End Function

    Private Function validarPrecio(tb As TextBox, str As String) As Boolean
        'en esta funcion lo que hacemos es comprobar si tiene mas de un punto o mas de una coma o si tiene letras
        'o si tiene un punto y una coma. En caso de que tenga mas de uno de estos caracteres o una combinacion de ellos
        'mostraremos un mensaje de error
        Dim contadorPuntos As Integer = 0
        Dim contadorComas As Integer = 0

        If str = "" Then
            MessageBox.Show("El campo de precio no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf Not IsNumeric(str) Then
            MessageBox.Show("El campo debe de ser numerico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True

        ElseIf str < 0 Then
            MessageBox.Show("El precio no puede ser menor que 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            For i As Integer = 0 To str.Length - 1
                If str(i) = "." Then
                    contadorPuntos += 1
                ElseIf str(i) = "," Then
                    contadorComas += 1
                End If
            Next
            If contadorPuntos > 1 Or contadorComas > 1 Then
                MessageBox.Show("Error, dentro del campo hay mas de un punto o de una coma", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Clear()
                Return True
            ElseIf contadorPuntos = 1 And contadorComas = 1 Then
                MessageBox.Show("No se puede meter dentro del campo un punto o una coma a la vez", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Clear()
                Return True
            Else
                Return False
            End If

        End If
    End Function

    Private Function validarGama(tb As TextBox, str As String) As Boolean

        'en esta funcion vamos a validar que la gama (su id) este dentro de la tabla gamas.
        'para ello vamos a hacer una consulta a la base de datos access utilizando comandos en olebd
        'y si el id no existe, mostraremos un mensaje de error
        Dim comprobar As Boolean = False
        Try
            Dim cmd As New OleDbCommand("Select id from Gamas where id = @id", conn)
            cmd.Parameters.AddWithValue("@id", str)
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.HasRows() Then
                comprobar = True
            End If
            conn.Close()
            If comprobar = False Then
                MessageBox.Show("El id de la gama no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tb.Clear()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error de la validacion de la gama", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Finally
            conn.Close()
        End Try

    End Function
    Public Function validarNombreEmpresa(tb As TextBox, str As String) As Boolean
        'en esta funcion solamente validaremos que no este vacio el campo de nombre de la empresa
        If str = "" Then
            MessageBox.Show("El campo nombre no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validarAlta(tb As TextBox, str As String) As Boolean

        If str = "" Then
            MessageBox.Show("El campo alta no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf str = "0" Then
            Return False
        ElseIf str = "1" Then
            Return False
        Else
            MessageBox.Show("Solo estan permitidos en el campo altas 0 y 1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        End If

    End Function

    Public Function validarProveedor(tb As TextBox, prov As String)

        Dim proveedor As DataRow

        If prov = "" Then
            MessageBox.Show("El campo proveedor no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf Not IsNumeric(prov) Then
            MessageBox.Show("El campo proveedor debe de ser numerico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        End If

        proveedor = BuscarProveedor(prov)
        If proveedor Is Nothing Then
            MessageBox.Show("El proveedor no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Clear()
            Return True
        Else
            Return False
        End If

    End Function


End Class