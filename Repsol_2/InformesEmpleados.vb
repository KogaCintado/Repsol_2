Imports System.Data.OleDb
Public Class InformesEmpleados

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_db.accdb")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub


    Private Sub verDatos()

        conn.Open()
        Using cmd As New OleDbCommand("Select * from Empleados", conn)
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            'Dim mireporte As New myreport

        End Using
    End Sub

End Class