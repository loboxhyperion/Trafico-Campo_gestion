Public Class BasicoTab
    Dim comando As New comandos()
    Dim destinoX As String
    Dim destinoY As String
    Dim D0 As String
    Private Sub Destino()
        destinoX = Hex(Val(DireccionesMenu.txtPosX2.Text)).ToString.PadLeft(2, "0")
        destinoY = Hex(Val(DireccionesMenu.txtPosY2.Text)).ToString.PadLeft(2, "0")
    End Sub
    Private Sub DatoD0(dato As String)
        D0 = Hex(Val(dato)).ToString.PadLeft(2, "0")
    End Sub
    Private Sub btnPrender_Click(sender As Object, e As EventArgs) Handles btnPrender.Click
        Destino()
        comando.Prender(destinoX, destinoY)
    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click
        Destino()
        comando.Apagar(destinoX, destinoY)
    End Sub
    Private Sub btnIntermitenciaRoja_Click(sender As Object, e As EventArgs) Handles btnIntermitenciaRoja.Click
        Destino()
        comando.PrecaucionRoja(destinoX, destinoY)
    End Sub

    Private Sub btnIntermitenciaAmarilla_Click(sender As Object, e As EventArgs) Handles btnIntermitenciaAmarilla.Click
        Destino()
        comando.PrecaucionAmarilla(destinoX, destinoY)
    End Sub

    Private Sub btnDimerizacion_Click(sender As Object, e As EventArgs) Handles btnDimerizacion.Click
        Destino()
        DatoD0(txtLuz.Text)
        comando.Luz(destinoX, destinoY, D0)
    End Sub
End Class