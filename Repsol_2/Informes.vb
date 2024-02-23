Imports System.Data.OleDb
Public Class Informes

    Private Sub Informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximizamos la ventana
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")


    Private Sub verDatosEmpleados()
        Try
            conn.Open()

            Using cmd As New OleDbCommand("Select * from Empleados", conn)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                Dim reporte As New reportesEmpleados
                reporte.Database.Tables("Empleados").SetDataSource(dt)
                CrystalReportViewer1.ReportSource = Nothing
                CrystalReportViewer1.ReportSource = reporte
            End Using
        Catch ex As Exception
            MsgBox("Hubo un error cargando el informe: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub verDatosClientes()
        Try
            conn.Open()

            Using cmd As New OleDbCommand("Select * from Clientes", conn)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                Dim reporte As New reportesClientes
                reporte.Database.Tables("Clientes").SetDataSource(dt)
                CrystalReportViewer1.ReportSource = Nothing
                CrystalReportViewer1.ReportSource = reporte
            End Using
        Catch ex As Exception
            MsgBox("Hubo un error cargando el informe: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub verDatosProductos()
        Try
            conn.Open()

            Using cmd As New OleDbCommand("Select * from Productos", conn)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                Dim reporte As New reportesProductos
                reporte.Database.Tables("Productos").SetDataSource(dt)
                CrystalReportViewer1.ReportSource = Nothing
                CrystalReportViewer1.ReportSource = reporte
            End Using
        Catch ex As Exception
            MsgBox("Hubo un error cargando el informe: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub verDatosGasolinas()
        Try
            conn.Open()

            Using cmd As New OleDbCommand("Select * from Gasolinas", conn)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                Dim reporte As New reportesGasolina
                reporte.Database.Tables("Gasolinas").SetDataSource(dt)
                CrystalReportViewer1.ReportSource = Nothing
                CrystalReportViewer1.ReportSource = reporte
            End Using
        Catch ex As Exception
            MsgBox("Hubo un error cargando el informe: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnInformesEmpleados_Click(sender As Object, e As EventArgs) Handles btnInformesEmpleados.Click
        verDatosEmpleados()
    End Sub

    Private Sub btnInformesClientes_Click(sender As Object, e As EventArgs) Handles btnInformesClientes.Click
        verDatosClientes()
    End Sub

    Private Sub btnInformesProductos_Click(sender As Object, e As EventArgs) Handles btnInformesProductos.Click
        verDatosProductos()
    End Sub

    Private Sub btnInformesGasolinas_Click(sender As Object, e As EventArgs) Handles btnInformesGasolinas.Click
        verDatosGasolinas()
    End Sub

    Private Sub VolevrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolevrToolStripMenuItem.Click
        Opciones.Show()
        Me.Close()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub CerrarProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarProgramaToolStripMenuItem.Click
        End
    End Sub
End Class