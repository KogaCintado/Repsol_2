Public Class Inicio
    Public Shared admin As Boolean = False
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximize the window
        Me.WindowState = FormWindowState.Maximized
        admin = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Programar validaciones.



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
End Class
