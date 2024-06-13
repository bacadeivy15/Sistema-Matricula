Imports System.Data.OleDb
Public Class FrmGrafica
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub FrmGrafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim prueba1 As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=D:\TRABAJO\PALMA\SISTEMA DE MATRICULA\BASE DE DATOS\MATRICULA.mdb")

        Try
            prueba1.Open()
            MsgBox("Conectado")

            Dim query = "Select * from Alumnos"
            Dim prueba2 As New OleDbDataAdapter(query, prueba1)
            Dim vs As New DataTable
            prueba2.Fill(vs)


            Chart1.Series("Series1").XValueMember = "nombre"
            Chart1.Series("Series1").YValueMembers= "edad"
            Chart1.DataSource = vs

        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)

        End Try
    End Sub
End Class