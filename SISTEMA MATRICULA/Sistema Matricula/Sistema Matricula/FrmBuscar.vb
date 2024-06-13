Imports System.Data.OleDb
Public Class FrmBuscar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prueba1 As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=D:\TRABAJO\PALMA\SISTEMA DE MATRICULA\BASE DE DATOS\MATRICULA.mdb")

        Try
            prueba1.Open()
            MsgBox("Conectado")

            Dim query = "Select * from Alumnos"
            Dim prueba2 As New OleDbDataAdapter(query, prueba1)
            Dim vs As New DataTable
            prueba2.Fill(vs)
            DataGridView1.DataSource = vs
        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmGrafica.Show()
    End Sub

    Private Sub FrmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class