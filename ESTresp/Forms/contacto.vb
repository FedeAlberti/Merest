Public Class contacto
    Dim corrida, basura As Integer
    Dim puedoTocar As Boolean
    Dim Cronometro = New Stopwatch

    Private Sub contacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Tocado(Cronometro, corrida, "", basura, puedoTocar, Timer1)
        Me.Select()
        If corrida = 6 Then
            Cronometro.Stop()
            Me.Close()
            Resultados.Show()
        End If
    End Sub

    Private Sub contacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("A continuación, comenzará la prueba")
        puedoTocar = False
        corrida = 1
    End Sub

    Private Sub contacto_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If puedoTocar = False Then
            Aparece(Cronometro, "", puedoTocar, corrida)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Elige.Show()

    End Sub

    Private Sub imagen_Click(sender As Object, e As EventArgs) Handles imagen.Click
        If puedoTocar = False Then
            Aparece(Cronometro, "", puedoTocar, corrida)
        End If
    End Sub
End Class
