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
