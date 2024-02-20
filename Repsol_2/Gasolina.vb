Imports System.Data.OleDb
Imports Biblioteca

Public Class Gasolina
    Dim contador As Integer = 0
    Dim listaDeImagenes As New List(Of Image)()
    Dim botones As New List(Of Button)()
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    Dim flag As Boolean = False

    Private Sub Gasolina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agrega imágenes al ImageList
        listaDeImagenes.Add(My.Resources.llegada)
        listaDeImagenes.Add(My.Resources.llegada2)
        listaDeImagenes.Add(My.Resources.gasolinas)

        'agregamos los botones a la lista
        botones.Add(btnGas95)
        botones.Add(btnGas98)
        botones.Add(btnDieselE)
        botones.Add(btnDieselE10)
        ' Asigna el ImageList al PictureBox
        PictureBox1.Image = listaDeImagenes(0)

        ' Configura el Timer
        Timer1.Interval = 1000 ' Intervalo en milisegundos (en este caso, 1 segundo)
        Timer1.Start()



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Cambia la imagen cada vez que se activa el Timer
        contador += 1

        If contador >= listaDeImagenes.Count Then
            Timer1.Stop()
            Return
        End If

        PictureBox1.Image = listaDeImagenes(contador)
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnGas95.Click, btnGas98.Click, btnDieselE.Click, btnDieselE10.Click
        If (flag) Then
            Return
        End If

        For Each boton In botones
            If boton Is sender AndAlso validarGasolinaRestante(botones.IndexOf(sender)) Then
                boton.Enabled = True
                ModificarGasolina(botones.IndexOf(sender), 100)
                ProgressBar1.Maximum = 100
                ProgressBar1.Value = 1
            Else
                boton.Enabled = False
            End If
        Next


        ProgressBar1.Value = ProgressBar1.Value + 1


    End Sub


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''TERRITORIO BDD!!!''''''''''''''''''''''''''''''
    ''''''''''''''
    Private Sub ModificarGasolina(id As Integer, cantidad As Integer)

        Try

            conn.Open()

            Using cmd As New OleDbCommand("Update Gasolinas set cantidad = (Select cantidad - ? where id = ?) where id = ?", conn)
                cmd.Parameters.Add(New OleDbParameter("cantidad", cantidad))
                cmd.Parameters.Add(New OleDbParameter("idselect", id))
                cmd.Parameters.Add(New OleDbParameter(“id”, id))
                cmd.ExecuteNonQuery()

            End Using
        Catch ex As Exception
            MsgBox("Hubo un error a la hora de acceder al depósito. ")
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "Gasolina, ModificarGasolina")
        Finally
            conn.Close()
        End Try

    End Sub

    Private Function validarGasolinaRestante(id As Integer) As Boolean

        Try
            Dim gasolinaAValidar As DataRow
            conn.Open()
            Using cmd As New OleDbCommand("Select cantidad from Gasolinas where id = @id", conn)

                Dim da As New OleDbDataAdapter(cmd)
                Dim ds As New DataSet()
                da.Fill(ds)

                If ds.Tables("Gasolinas").Rows.Count > 0 Then

                    gasolinaAValidar = ds.Tables("Gasolinas").Rows(0)

                    If gasolinaAValidar("Cantidad").ToString() < 100 Then
                        Return False
                    Else
                        Return True
                    End If

                Else

                    MsgBox("Error, no se ha encontrado una gasolina")
                    Return False

                End If

            End Using
        Catch ex As Exception

            MsgBox(id.ToString + "Hubo un error a la hora de realizar la operacion en la base de datos: " & ex.Message)
            Dim guardar As New Archivo
            guardar.GuardarError(ex, "Gasolina, ModificarGasolina")
            Return False

        Finally
            conn.Close()
        End Try

    End Function

End Class