Module Module2
    Public valores2(6) As Integer
    Public tipoEstimulo As String
    Public ran As New Random

    Public Sub Aparece(ByRef Cronometro As Stopwatch, ByRef objeto As Object, ByRef PuedeTocar As Boolean, ByRef corrida As Integer)
        Cronometro.Stop()
        Cronometro.Restart()
        If TypeOf objeto Is PictureBox Then
            PoneImagen(corrida)
        ElseIf TypeOf objeto Is System.Media.SoundPlayer Then
            objeto.Play()
        End If
        PuedeTocar = True
        Cronometro.Start()
    End Sub

    Public Sub Tocado(ByRef Cronometro As Stopwatch, ByRef corrida As Integer, ByRef objeto As Object, ByRef tiempoAleatorio As Integer, ByRef puedeTocar As Boolean, ByRef tiempo As Timer)
        If puedeTocar = True Then
            Cronometro.Stop()
            valores2(corrida) = Cronometro.ElapsedMilliseconds.ToString
            If TypeOf objeto Is PictureBox Then
                Visual.BackgroundImage = (My.Resources.azul)
            End If
            Cronometro.Restart()
            tiempoAleatorio = ran.Next(3000)
            puedeTocar = False
            Cronometro.Start()
            corrida = corrida + 1
        Else
            tiempo.Stop()
            Cronometro.Stop()
            Cronometro.Reset()
            MsgBox("Aguarde el estímulo")
            tiempoAleatorio = 1000 + ran.Next(3000)
            tiempo.Start()
            Cronometro.Start()
        End If

    End Sub


    Public Sub PoneImagen(ByRef numero As Integer)
        Select Case (numero)
            Case 1
                Visual.BackgroundImage = (My.Resources.amarillo)
            Case 2
                Visual.BackgroundImage = (My.Resources.rojo)
            Case 3
                Visual.BackgroundImage = (My.Resources.verde)
            Case 4
                Visual.BackgroundImage = (My.Resources.rojo)
            Case 5
                Visual.BackgroundImage = (My.Resources.amarillo)
        End Select



    End Sub

End Module
