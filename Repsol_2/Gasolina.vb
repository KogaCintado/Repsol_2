Imports System.Data.OleDb
Imports Biblioteca

Public Class Gasolina
    'Zona de variables.
    Dim contador As Integer = 0
    Dim listaDeImagenes As New List(Of Image)()
    Dim botones As New List(Of Button)()
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")
    Dim flag As Boolean = True

    Dim precioGasolinaActual, precioGasolinaAcumulado As Single
    Private selectedGas As Integer

    'Carga el formulario
    Private Sub Gasolina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximizamos la ventana
        Me.WindowState = FormWindowState.Maximized

        HelpProvider1.HelpNamespace = "config/Documento de ayuda TPV Repsol.chm"
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.Topic)
        HelpProvider1.SetHelpKeyword(Me, "Gasolina.htm")

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

    'Cada tick(1 segudno), ejecuta este procedimiento, cambiando las imágenes y, al final, habilitando los botones.
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

    'Si el botón es pulsado, se deshabilita el resto de botones y se pide 100 litros de gasolina.
    'Si la gasolina no está disponible, se muestra un mensaje de error.
    'Relaciona el botón con el id de la gasolina en la base de datos.
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnGas95.Click, btnGas98.Click, btnDieselE.Click, btnDieselE10.Click

        If (flag) Then
            For Each boton In botones
                If boton Is sender Then
                    boton.Enabled = True
                    flag = False

                    Select Case sender.Name
                        Case "btnGas95"
                            selectedGas = 1
                        Case "btnGas98"
                            selectedGas = 2
                        Case "btnDieselE"
                            selectedGas = 3
                        Case "btnDieselE10"
                            selectedGas = 4
                    End Select

                    If (ModificarGasolina(selectedGas, 100)) Then
                        ProgressBar1.Value = 100
                        ProgressBar1.Maximum = 100
                        ProgressBar1.Visible = True
                        Dim gasolina As DataRow = BuscarGasolina(selectedGas)
                        precioGasolinaActual = gasolina("precio")
                        precioGasolinaAcumulado = 0
                        lblNombreGas.Text = gasolina("nombre")
                        lblPrecioGas.Text = precioGasolinaActual & " €/L"
                        lblPrecioGasAcumulado.Text = precioGasolinaActual & " €"
                        lblPrecioGasAcumulado.Visible = True
                        lblPrecioGas.Visible = True
                        lblNombreGas.Visible = True
                        lblGasEchado.Visible = True
                    End If
                Else
                    boton.Enabled = False
                End If
            Next
        End If

        If (ProgressBar1.Value = 0) Then
            MessageBox.Show("No hay suficiente gasolina en el depósito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ProgressBar1.Value -= 1
            precioGasolinaAcumulado += precioGasolinaActual
            lblPrecioGasAcumulado.Text = (precioGasolinaAcumulado) & " €"
            lblGasEchado.Text = (100 - ProgressBar1.Value) & "/100 L"
        End If

    End Sub

    'Habilita/deshabilita los botones
    Private Sub enableBotones(bool As Boolean)

        For Each boton In botones
            boton.Enabled = bool
        Next

    End Sub

    'Aceptar la cantidad de gasolina apuntada.
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (ProgressBar1.Visible = False) Then
            TPV.Show()
            Trabajar.Close()
            Me.Close()
        Else
            TPV.Show()
            TPV.lbNombreProductos.Items.Add("Gasolina")
            TPV.lbPrecios.Items.Add("€ " + precioGasolinaAcumulado.ToString("F"))
            TPV.actualizarPrecio()
            ModificarGasolina(selectedGas, ProgressBar1.Value * -1)
            Trabajar.Close()
            Me.Close()
        End If
    End Sub


    '------------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------Territorio base de datos---------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------------------------
    'Comprueba que hay suficiente gasolina, y la extrae para el cliente(o la vuelve a introducir).
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
            MessageBox.Show("Hubo un error a la hora de acceder al depósito. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "Gasolina, ModificarGasolina")
            Return False
        Finally
            conn.Close()
        End Try
        Return True

    End Function

    'Busca el tipo de gasolina en la base de datos.
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
            MessageBox.Show("Hubo un error con la base de datos: " & ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "Gasolina, BuscarGasolina")
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
End Class