Public Class Visual
    Dim corrida As Integer
    Dim tiempoAleatorio As Integer
    Dim puedoTocar As Boolean
    Dim Cronometro = New Stopwatch


    Private Sub Visual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackgroundImage = (My.Resources.azul)
        MsgBox("A continuación, comenzará la prueba")


        Me.Select()
        Timer1.Start()
        Cronometro.Reset()
        puedoTocar = False
        tiempoAleatorio = 3000
        Cronometro.Start()
        corrida = 1
        Imagen.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Elige.Show()
    End Sub

    Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs)
        Tocado(Cronometro, corrida, Imagen, tiempoAleatorio, puedoTocar, Timer1)
        Me.Select()
        If corrida = 6 Then
            Me.Close()
            Resultados.Show()
        End If
    End Sub

    Private Sub Visual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        Tocado(Cronometro, corrida, Imagen, tiempoAleatorio, puedoTocar, Timer1)
        If corrida = 6 Then
            Me.Close()
            Resultados.Show()
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If tiempoAleatorio <= Cronometro.ElapsedMilliseconds And puedoTocar = False Then
            Aparece(Cronometro, imagen, puedoTocar, corrida)
        End If

    End Sub

    Private Sub Imagen_Click(sender As Object, e As EventArgs) Handles Imagen.Click

    End Sub

    Private Sub imagen_Click_1(sender As Object, e As EventArgs) Handles imagen.Click

    End Sub
End Class