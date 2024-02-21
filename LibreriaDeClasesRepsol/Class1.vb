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
    End Class


End Namespace

Namespace Archivo

    'Clase encargada de guardar los errores en un fichero, de modo que sea más fácil de solucionar los problemas para el técnico.
    Public Class Errores
        ''' <summary>
        ''' Guarda la excepción en un fichero de texto, con la fecha de cuando ha sido efectuado.
        ''' </summary>
        ''' <param name="excepcionAGuardar">Excepción controlada(Suele llamarse ex).</param>
        ''' <param name="lugarDelError">Nombre del método donde ocurre el error.</param>
        Public Sub Guardar(excepcionAGuardar As Exception, lugarDelError As String)
            Dim n As String = Now.ToString + " " + " Error localizado en " + lugarDelError + ", contacte con el administrador." + vbCrLf + excepcionAGuardar.ToString
            GuardarDatosEnArchivo("config\errores.txt", n + vbCrLf)
        End Sub
    End Class


    'Guarda los datos en un fichero.
    Private Function GuardarDatosEnArchivo(ruta As String, texto As String) As Boolean
        My.Computer.FileSystem.WriteAllText(ruta, texto + vbCrLf, True)
        Return False
    End Function
End Namespace

'Guarda los datos en un fichero.
Private Function GuardarDatos(ruta As String, texto As String) As Boolean
    My.Computer.FileSystem.WriteAllText(ruta, texto + vbCrLf, True)
    Return False
End Function


