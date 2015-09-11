Public Class Main
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn.Close()


        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Elige.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Respuestas.Show()

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs)
        conectarse()

    End Sub

    Private Sub Main_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarse()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Creado por Federico Agustín Alberti " + Chr(13) + "Estudiante Ing. en sistemas" + Chr(13) + "Teléfono: 02477-15636568" + Chr(13) + "Mail: fede.alberti@hotmail.com", MsgBoxStyle.Information, "Créditos del autor")
    End Sub
End Class