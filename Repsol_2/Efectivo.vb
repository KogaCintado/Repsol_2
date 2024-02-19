Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Biblioteca

Public Class Efectivo

    'Cada vez que se aloje en memoria este formulario, este procedimiento se cargará. Resetea los datos.
    Private Sub Efectivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPrecioInicial.Text = TPV.lblResultado.Text
        lblDevolver.Text = "0,00 €"
        tbDinero.Text = "0,00"
    End Sub

    'Finaliza el formulario si el usuario ha dado el importe del pedido.
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Single.Parse(lblPrecioInicial.Text) <= Single.Parse(tbDinero.Text) Then
            'Dim caja As New Archivos.HacerCaja

            'Dim a As Single = Math.Abs(Single.Parse(lblDevolver.Text.TrimEnd("€")))
            'caja.CajaTemporal(Single.Parse(tbDinero.Text), a, TPV.lblUser.Text)


            Dim ticket As New Ticket()

            ticket.ImprimirTicketEfectivo(TPV.lblUser.Text, TPV.lblResultado.Text, TPV.lbNombreProductos, TPV.lbPrecios, lblPrecioInicial.Text, tbDinero.Text, lblDevolver.Text)


            TPV.nuevoPedido()
            TPV.Show()
            Close()
        Else
            MsgBox("Ha de pagar el pedido completo.")
        End If

    End Sub

    'Borra un dígito de la calculadora.
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If (Not tbDinero.Text = "0,00") Then
            MaxLongitudYValidar()
            tbDinero.Text = tbDinero.Text.Remove(tbDinero.Text.Length - 1)
            If tbDinero.Text = "" Then
                tbDinero.Text = "0,00"
                tbDinero.Text = "0,00"
            End If
        End If
        Calcular()
    End Sub

    'Resetea los datos introducidos por el usuario.
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblDevolver.Text = "0,00"
        tbDinero.Text = "0,00"

    End Sub

    'Procedimiento ejecutado cada vez que se le da a un botón con solo un carácter, añade un dígito a la calculadora.
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button0.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, ButtonComma.Click
        'Si presionas en un botón, comprueba si está vacío o no, y si no 
        If Not MaxLongitudYValidar() Then
            If sender.text Is "," Then
                If tbDinero.Text = "" Then
                    tbDinero.Text = "0" + sender.text
                End If
                If tbDinero.Text.Length < 4 And ContainsComa(tbDinero.Text) = -1 Then
                    tbDinero.Text += sender.text
                End If
            ElseIf ContainsComa(tbDinero.Text) = -1 Then
                tbDinero.Text += sender.text
            ElseIf ContainsComa(tbDinero.Text) + 2 >= tbDinero.TextLength Then
                tbDinero.Text += sender.text
            End If

            Calcular()
        End If
    End Sub

    'Mira si el texto introducido contiene una coma, da su posición.
    Private Function ContainsComa(texto As String) As Integer
        If texto.Contains(",") Then

            Return texto.IndexOf(",")
        End If
        Return -1
    End Function

    'Calcula la resta.
    Private Sub Calcular()
        Dim box As String = lblPrecioInicial.Text - tbDinero.Text
        lblDevolver.Text = FormatCurrency(tbDinero.Text - lblPrecioInicial.Text, 2)
    End Sub

    'Valida los datos.
    Private Function MaxLongitudYValidar() As Boolean
        Dim validarTexto As New validaciones.validacionNombreyContra
        'Comprueba si está vacío el texto y si está lleno
        If tbDinero.Text = "0,00" Then
            tbDinero.Clear()
            Return False
        ElseIf validarTexto.IsMaxLength(tbDinero, 6) Then
            Return True
        End If
        Return False
    End Function

End Class