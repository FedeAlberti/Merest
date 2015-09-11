Public Class Resultados
    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nro.Text = valores2(0).ToString
        uno.Text = valores2(1).ToString
        dos.Text = valores2(2).ToString
        tres.Text = valores2(3).ToString
        cuatro.Text = valores2(4).ToString
        cinco.Text = valores2(5).ToString

        prome.Text = ((valores2(1) + valores2(2) + valores2(3) + valores2(4) + valores2(5)) / 5).ToString



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Elige.Select()
        Elige.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Me.Close()

        Select Case tipoEstimulo
            Case 1
                Visual.Select()
                Visual.Show()
            Case 2
                Sonido.Select()
                Sonido.Show()
            Case 3
                contacto.Select()
                contacto.Show()

        End Select
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        agregar()
        MsgBox("Agregado Exitosamente")
        Elige.Select()
        Elige.Show()
        Me.Close()

    End Sub

    Private Sub cinco_Click(sender As Object, e As EventArgs) Handles cinco.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub cuatro_Click(sender As Object, e As EventArgs) Handles cuatro.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub tres_Click(sender As Object, e As EventArgs) Handles tres.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub dos_Click(sender As Object, e As EventArgs) Handles dos.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class