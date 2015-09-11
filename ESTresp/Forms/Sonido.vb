Public Class Sonido
    Dim ruido As New System.Media.SoundPlayer(My.Resources.sonidos)
    Dim corrida As Integer
    Dim tiempoAleatorio As Integer
    Dim puedoTocar As Boolean
    Dim Cronometro = New Stopwatch

    Private Sub Sonido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Select()
        MsgBox("A continuación, comenzará la prueba")
        Timer1.Start()
        Cronometro.Reset()
        puedoTocar = False
        tiempoAleatorio = 3000
        Cronometro.Start()
        corrida = 1


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If tiempoAleatorio <= Cronometro.ElapsedMilliseconds And puedoTocar = False Then
            Aparece(Cronometro, ruido, puedoTocar, corrida)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs)
        Tocado(Cronometro, corrida, ruido, tiempoAleatorio, puedoTocar, Timer1)
        Me.Select()
        If corrida = 6 Then
            Timer1.Stop()
            Cronometro.Stop()
            Me.Close()
            Resultados.Show()
        End If
    End Sub
    Private Sub Visual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Tocado(Cronometro, corrida, ruido, tiempoAleatorio, puedoTocar, Timer1)
        Me.Select()
        If corrida = 6 Then
            Cronometro.Stop()
            Me.Close()
            Resultados.Show()
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
        Elige.Show()
    End Sub

    Private Sub imagen_Click(sender As Object, e As EventArgs) Handles imagen.Click

    End Sub
End Class