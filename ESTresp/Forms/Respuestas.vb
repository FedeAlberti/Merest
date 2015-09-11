Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Respuestas
    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet
    Dim workbook As Excel.Workbook


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Main.Show()
        Me.Close()

    End Sub



    Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal pth As String)
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strsql As String = "SELECT Numero as Voluntario,Primero,Segundo,Tercero,Cuarto,Quinto,Promedio,Tipo  FROM Resultados ORDER BY Numero"
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")

        Dim xlApp As Object = CreateObject("Excel.Application")
        'crear una nueva hoja de calculo 
        Dim xlWB As Object = xlApp.WorkBooks.add
        Dim xlWS As Object = xlWB.WorkSheets(1)

        'exportamos los caracteres de las columnas 
        For c As Integer = 0 To DataGridView1.Columns.Count - 1
            xlWS.cells(1, c + 1).value = DataGridView1.Columns(c).HeaderText
        Next
        'exportamos las cabeceras de columnas 
        For r As Integer = 0 To DataGridView1.RowCount - 1
            For c As Integer = 0 To DataGridView1.Columns.Count - 1
                xlWS.cells(r + 2, c + 1).value = DataGridView1.Item(c, r).Value
            Next
        Next
        'guardamos la hoja de calculo en la ruta especificada 
        xlWB.saveas(pth)
        xlWS = Nothing
        xlWB = Nothing
        xlApp.quit()

        xlApp = Nothing
        xlApp.close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strsql As String = "SELECT Numero as ID,Primero,Segundo,Tercero,Cuarto,Quinto,Promedio FROM Resultados WHERE Tipo='Visual' order by Numero"
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strsql As String = "SELECT Numero as ID,Primero,Segundo,Tercero,Cuarto,Quinto,Promedio FROM Resultados WHERE Tipo='Sonido' order by Numero"
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strsql As String = "SELECT Numero as ID,Primero,Segundo,Tercero,Cuarto,Quinto,Promedio FROM Resultados WHERE Tipo='Tactil' order by Numero"
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exportar_Excel(Me.DataGridView1, save.FileName)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strsql As String = "SELECT Numero as ID,Primero,Segundo,Tercero,Cuarto,Quinto,Promedio,Tipo  FROM Resultados ORDER BY Numero"
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")
    End Sub
End Class