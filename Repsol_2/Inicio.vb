﻿Imports System.Data.OleDb
Public Class Inicio
    Public Shared admin As Boolean = False
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximizamos la ventana
        Me.WindowState = FormWindowState.Maximized
        'Ocultamos la password
        tbPassword.PasswordChar = "*"
        admin = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Programar validaciones.



        If (Not (String.IsNullOrEmpty(tbUsername.Text.Trim()))) And (Not (String.IsNullOrEmpty(tbPassword.Text.Trim()))) Then


            If loggin(tbUsername.Text.Trim(), tbPassword.Text.Trim()) = True Then

                MsgBox("Bienvenido!")
                Me.Hide()
                Opciones.Show()
                ErrorProvider1.Clear()
                ErrorProvider2.Clear()

            Else
                MsgBox("Usuario o contraseña incorrectos, intentelo de nuevo")
                tbPassword.Clear()
                tbUsername.Clear()
            End If

        Else
            MsgBox("Introduce un usuario y contraseña")
            tbPassword.Clear()
            tbUsername.Clear()

        End If
    End Sub



    Private Sub ShowPassword_Click(sender As Object, e As EventArgs) Handles showPassword.Click
        'Porque esto me da error
        If (tbPassword.PasswordChar <> "*") Then
            tbPassword.PasswordChar = "*"
        Else
            tbPassword.PasswordChar = ""
        End If
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

    Private Sub BORRAR(sender As Object, e As EventArgs) Handles PictureBox2.Click
        admin = True
        ErrorProvider1.Clear()
        ErrorProvider2.Clear()

        Me.Hide()
        Opciones.Show()
    End Sub


    Private Function loggin(nombre As String, contraseña As String) As Boolean

        Try

            conn.Open()

            Using cmd As New OleDbCommand("Select Nombre, Contraseña, Administrador from Empleados where nombre = @nombre and contraseña = @contraseña", conn)


                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@contraseña", contraseña)

                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        If reader("Administrador").ToString() = 1 Or reader("Administrador").ToString() = 2 Then
                            admin = True
                            MsgBox("Ha iniciado como administrador")
                        End If
                    End While
                    Return True

                Else
                    MsgBox("No Se pudo iniciar Sesion: Credenciales Incorrectas")
                    admin = False
                    Return False
                End If

            End Using

        Catch ex As Exception
            MsgBox("Hubo un error con el inicio de sesion: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try


    End Function



End Class
