Public Class ErrorAntenaForm
    Dim Contador As Integer = 3
    Private Sub tmrContador_Tick(sender As Object, e As EventArgs) Handles tmrContador.Tick
        Contador -= 1
        lblTimeOut.Text = Contador
        If Contador = 0 Then
            'LoginForm.Close()
            'Me.Close()
        End If
    End Sub
End Class