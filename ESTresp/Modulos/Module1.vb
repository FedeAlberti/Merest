Imports System.Data
Imports System.Data.OleDb

Module Module1

    Public conn As New OleDb.OleDbConnection
    Dim sql As String
    Public comm As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader

    Public Sub conectarse()
        Try
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources/dbEstimulos.accdb;Persist Security Info=False"
            conn.Open()
            comm.Connection = conn
            comm.CommandType = CommandType.Text

        Catch ex As Exception
            MsgBox("no" + ex.ToString)
        End Try

    End Sub


    ' Función que se encarga de insertar los datos del libro a la tabla
    Public Sub agregar()
        Try
            sql = "INSERT INTO Resultados (Numero,Primero,Segundo,Tercero,Cuarto,Quinto,Tipo) VALUES ('" & valores2(0) & "','" & valores2(1) & "','" & valores2(2) & "','" & valores2(3) & "','" & valores2(4) & "','" & valores2(5) & "', '" & tipoEstimulo & "')"
            comm.CommandText = sql
            comm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Estimulos")
        End Try
    End Sub

    Public Sub consultar()
        comm.Connection = conn
        comm.CommandType = CommandType.Text
        sql = "SELECT * FROM Resultados WHERE Tipo=1"

        Try
            dr = comm.ExecuteReader
            dr.Read()

        Catch ex As Exception

        End Try

    End Sub




End Module

