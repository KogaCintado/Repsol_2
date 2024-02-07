Public Class Inicio
    Public Shared admin As Boolean = False
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximize the window
        Me.WindowState = FormWindowState.Maximized
        admin = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Programar validaciones.

        ErrorProvider1.Clear()
        ErrorProvider2.Clear()

        Me.Hide()
        Opciones.Show()

    End Sub

    Private Sub ShowPassword_Click(sender As Object, e As EventArgs) Handles showPassword.Click

        If (tbPassword.PasswordChar = "") Then
            tbPassword.PasswordChar = "*"
        Else
            tbPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click


    End Sub

    Private Sub tbUsername_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged

        Dim i As Boolean = ValidarCaracteres(tbUsername.Text)

        'abajo controlaremos la condicion de que en caso de que debuelva falso, se muestre un mensaje de error
        If i = False Then
            ErrorProvider1.SetError(tbUsername, "No se permiten caracteres especiales")
            tbUsername.Clear()
        End If

    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
        Dim i As Boolean = ValidarCaracteres(tbPassword.Text)

        'abajo controlaremos la condicion de que en caso de que debuelva falso, se muestre un mensaje de error

        If i = False Then
            ErrorProvider1.SetError(tbPassword, "No se permiten caracteres especiales")
            tbPassword.Clear()
        End If
    End Sub

    'Funcion para validar caracteres especiales
    Public Function ValidarCaracteres(ByVal input As String) As Boolean
        Dim invalidCharacters As String = "() , . - ; : _ ¨ ´ { } [ ] + ` ^ * ? ¿ ¡ ' = / & % $ · "" ! | @ # ~ ¬ º ª \"
        For Each c As Char In invalidCharacters
            If input.Contains(c) Then
                Return False
            End If
        Next
        Return True
    End Function




End Class
