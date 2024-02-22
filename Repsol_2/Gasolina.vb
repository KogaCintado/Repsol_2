Imports System.Data.OleDb
Imports Biblioteca

Public Class Gasolina
    Dim contador As Integer = 0
    Dim listaDeImagenes As New List(Of Image)()
    Dim botones As New List(Of Button)()
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Dim flag As Boolean = False

    Dim precioGasolinaActual, precioGasolinaAcumulado As Single

    Private Sub Gasolina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        lblPrecioGasAcumulado.Visible = False
        lblPrecioGas.Visible = False
        lblNombreGas.Visible = False
        lblGasEchado.Visible = False

        ' Agrega imágenes al ImageList
        listaDeImagenes.Add(My.Resources.llegada)
        listaDeImagenes.Add(My.Resources.llegada2)
        listaDeImagenes.Add(My.Resources.gasolinas)

        PictureBox1.Image = listaDeImagenes(0)

        'agregamos los botones a la lista
        botones.Add(btnGas95)
        botones.Add(btnGas98)
        botones.Add(btnDieselE)
        botones.Add(btnDieselE10)

        enableBotones(False)



        ' Configura el Timer
        Timer1.Interval = 1000 ' Intervalo en milisegundos (en este caso, 1 segundo)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Cambia la imagen cada vez que se activa el Timer
        contador += 1

        If contador >= listaDeImagenes.Count Then
            enableBotones(True)
            Timer1.Stop()
            Return
        End If

        PictureBox1.Image = listaDeImagenes(contador)
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnGas95.Click, btnGas98.Click, btnDieselE.Click, btnDieselE10.Click

        'Si el botón es pulsado, se deshabilita el resto de botones y se pide 100 litros de gasolina.
        'Si la gasolina no está disponible, se muestra un mensaje de error.
        'Relaciona el botón con el id de la gasolina en la base de datos.
        'Rellena los datos de la gasolina en el formulario de repostaje.
        If Not (flag) Then
            For Each boton In botones
                If boton Is sender Then
                    boton.Enabled = True
                    flag = True

                    Dim id As Integer

                    Select Case sender.Name
                        Case "btnGas95"
                            id = 1
                        Case "btnGas98"
                            id = 2
                        Case "btnDieselE"
                            id = 3
                        Case "btnDieselE10"
                            id = 4
                    End Select

                    If (ModificarGasolina(id, 100)) Then
                        ProgressBar1.Value = 100
                        ProgressBar1.Maximum = 100
                        ProgressBar1.Visible = True
                        Dim gasolina As DataRow = BuscarGasolina(id)
                        precioGasolinaActual = gasolina("precio")
                        precioGasolinaAcumulado = precioGasolinaActual
                        lblNombreGas.Text = gasolina("nombre")
                        lblPrecioGas.Text = precioGasolinaActual & " €/L"
                        lblPrecioGasAcumulado.Text = precioGasolinaAcumulado & " €"
                        lblPrecioGasAcumulado.Visible = True
                        lblPrecioGas.Visible = True
                        lblNombreGas.Visible = True
                        lblGasEchado.Visible = True
                    Else
                        MsgBox("No hay suficiente gasolina en el depósito.")
                    End If
                Else
                    boton.Enabled = False
                End If
            Next
        End If
        If (ProgressBar1.Value = 0) Then
            MsgBox("No hay suficiente gasolina en el depósito.")
        Else
            ProgressBar1.Value -= 1
            precioGasolinaAcumulado += precioGasolinaActual * (100 - ProgressBar1.Value)
            lblPrecioGasAcumulado.Text = (precioGasolinaAcumulado) & " €"
            lblGasEchado.Text = (100 - ProgressBar1.Value) & "/100 L"
        End If

    End Sub

    Private Sub enableBotones(bool As Boolean)

        For Each boton In botones
            boton.Enabled = bool
        Next

    End Sub


    '------------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------Territorio base de datos---------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------------------------
    Private Function ModificarGasolina(id As Integer, cantidad As Integer)

        Try

            conn.Open()
            Using cmd As New OleDbCommand("select cantidad from gasolinas where id=?", conn)
                cmd.Parameters.Add(New OleDbParameter(“id”, id))

                If (Integer.Parse(cmd.ExecuteScalar().ToString()) < cantidad) Then
                    Return False
                End If

            End Using

            Using cmd As New OleDbCommand("UPDATE Gasolinas SET cantidad = cantidad - ? WHERE id = ?", conn)
                cmd.Parameters.Add(New OleDbParameter("cantidad", cantidad))
                cmd.Parameters.Add(New OleDbParameter("idselect", id))
                cmd.Parameters.Add(New OleDbParameter(“id”, id))
                cmd.ExecuteNonQuery()

            End Using
        Catch ex As Exception
            MsgBox("Hubo un error a la hora de acceder al depósito. ")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "Gasolina, ModificarGasolina")
            Return False
        Finally
            conn.Close()
        End Try
        Return True

    End Function
    Public Function BuscarGasolina(id As Integer) As DataRow

        ' Crear una nueva instancia del comando SQL
        Dim cmd As New OleDbCommand("SELECT * FROM Gasolinas WHERE id = @id", conn)

        ' Añadir el parámetro al comando SQL
        cmd.Parameters.AddWithValue("@id", id)

        ' Crear una nueva instancia del adaptador de datos
        Dim da As New OleDbDataAdapter(cmd)

        ' Crear una nueva instancia del DataSet
        Dim ds As New DataSet()

        Try
            ' Llenar el DataSet con los datos de la tabla Gasolinas
            da.Fill(ds, "Gasolinas")
        Catch ex As OleDbException
            MessageBox.Show("Hubo un error con la base de datos: " & ex.Message)
            Return Nothing
        End Try

        ' Comprobar si se encontró algún registro
        If ds.Tables("Gasolinas").Rows.Count > 0 Then
            ' Devolver la primera fila
            Return ds.Tables("Gasolinas").Rows(0)
        Else
            ' Si no se encontró ningún registro, devolver Nothing
            Return Nothing
        End If
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (ProgressBar1.Visible = False) Then
            TPV.Show()
            Trabajar.Close()
            Me.Close()
        Else
            TPV.Show()
            TPV.lbNombreProductos.Items.Add("Gasolina")
            TPV.lbPrecios.Items.Add(precioGasolinaAcumulado)
            TPV.actualizarPrecio()
            Trabajar.Close()
            Me.Close()
        End If
    End Sub
End Class