Public Class Elige

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Try
            valores2(0) = TextBox1.Text
            tipoEstimulo = "Visual"
            Me.Close()
            Visual.Select()
            Visual.Show()
        Catch ex As Exception
            MsgBox("Ingrese su numero")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            valores2(0) = TextBox1.Text
            tipoEstimulo = "Sonido"
            Me.Close()
            Sonido.Update()
            Sonido.Select()
            Sonido.Show()
        Catch ex As Exception
            MsgBox("Ingrese su numero")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            valores2(0) = TextBox1.Text
            tipoEstimulo = "Tactil"
            Me.Close()
            contacto.Update()
            contacto.Show()
        Catch ex As Exception
            MsgBox("Ingrese su numero")
        End Try

    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Main.Show()

    End Sub
End Class