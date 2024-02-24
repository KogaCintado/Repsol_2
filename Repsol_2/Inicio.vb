Imports System.Data.OleDb
Imports Biblioteca
Public Class Inicio
    Public Shared admin As Boolean = False
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Public nombreEmp As String = "Empleado"

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximizamos la ventana
        Me.WindowState = FormWindowState.Maximized
        'Ocultamos la password
        tbPassword.PasswordChar = "*"
        admin = False
    End Sub

    'en esta funcion validaremos si se entra o no dentro de la aplicacion. en caso de intentos o de entradas queda todo puesto dentro
    'de un fichero
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim archivo As New Archivo

        If (Not (String.IsNullOrEmpty(tbUsername.Text.Trim()))) And (Not (String.IsNullOrEmpty(tbPassword.Text.Trim()))) Then

            If loggin(tbUsername.Text.Trim(), tbPassword.Text.Trim()) = True Then
                Me.Hide()
                Opciones.Show()
                ErrorProvider1.Clear()
                ErrorProvider2.Clear()
                archivo.GuardarDatosEnArchivo("config/logs.txt", "El usuario " & tbUsername.Text & " ha iniciado sesion")

            Else
                archivo.GuardarDatosEnArchivo("config/logs.txt", "INTENTO inicio de sesión. " & " Usuario: " & tbUsername.Text & ", contraseña: " & tbPassword.Text)
                tbPassword.Clear()
                tbUsername.Clear()
            End If

        Else
            MessageBox.Show("Introduce usuario y contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbPassword.Clear()
            tbUsername.Clear()

        End If
    End Sub
    'esta funcion se encarga de poder cambiar el tipo de caracteres de la contraseña entre asteriscos y caracteres normales
    Private Sub ShowPassword_Click(sender As Object, e As EventArgs) Handles showPassword.Click
        If (tbPassword.PasswordChar <> "*") Then
            tbPassword.PasswordChar = "*"
        Else
            tbPassword.PasswordChar = ""
        End If
    End Sub


    Private Sub tbUsername_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged

        Dim i As Boolean = ValidarCaracteres(tbUsername.Text)

        'Abajo controlaremos la condicion de que en caso de que debuelva falso, se muestre un mensaje de error
        If i = False Then
            ErrorProvider1.SetError(tbUsername, "No se permiten caracteres especiales")
            tbUsername.Clear()
        End If

    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
        Dim i As Boolean = ValidarCaracteres(tbPassword.Text)

        'Abajo controlaremos la condicion de que en caso de que debuelva falso, se muestre un mensaje de error

        If i = False Then
            ErrorProvider1.SetError(tbPassword, "No se permiten caracteres especiales")
            tbPassword.Clear()
        End If
    End Sub

    'Función para validar caracteres especiales
    Public Function ValidarCaracteres(ByVal input As String) As Boolean
        Dim invalidCharacters As String = "() , . - ; : _ ¨ ´ { } [ ] + ` ^ * ? ¿ ¡ ' = / & % $ · "" ! | @ # ~ ¬ º ª \"
        For Each c As Char In invalidCharacters
            If input.Contains(c) Then
                Return False
            End If
        Next
        Return True
    End Function

    'esta funcion permitira poder entrar al programa
    Private Function loggin(nombre As String, contraseña As String) As Boolean

        Try

            conn.Open()

            Using cmd As New OleDbCommand("Select Nombre, Contraseña, Administrador from Empleados where nombre = @nombre and contraseña = @contraseña", conn)


                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@contraseña", contraseña)

                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                If reader.HasRows Then 'en caso de que sea correcto se iniciara como empleado o administrador
                    While reader.Read()
                        If reader("Administrador").ToString() = 1 Or reader("Administrador").ToString() = 2 Then
                            admin = True
                            nombreEmp = tbUsername.Text
                            MessageBox.Show("Ha inciado como Administrador", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            tbUsername.Clear()
                            tbPassword.Clear()
                        ElseIf reader("Administrador").ToString() = 0 Then
                            nombreEmp = tbUsername.Text
                            MessageBox.Show("Ha inciado como Empleado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            tbUsername.Clear()
                            tbPassword.Clear()
                        End If
                    End While
                    Return True

                Else
                    MessageBox.Show("No se pudo iniciar sesion: credenciales incorrectas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    admin = False
                    Return False
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Hubo un error en el inicio de sesion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Finally
            conn.Close()
        End Try


    End Function

    'funcion necesaria para librerar recursos y deslogearnos
    Private Sub NotifyIconLogo_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIconLogo.MouseClick
        Me.Show()

        Gasolina.Close()
        GestionesDelAdministrador.Close()
        Efectivo.Close()
        Opciones.Close()
        Trabajar.Close()
        TPV.Close()

    End Sub
End Class
