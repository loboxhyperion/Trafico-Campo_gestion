Public Class PruebasTab

    Dim comando As New comandos()
    Dim destinoX As String
    Dim destinoY As String
    Dim D0 As String
    Private Sub Destino()
        destinoX = Hex(Val(DireccionesMenu.txtPosX2.Text)).ToString.PadLeft(2, "0")
        destinoY = Hex(Val(DireccionesMenu.txtPosY2.Text)).ToString.PadLeft(2, "0")
    End Sub

    Private Sub btnTryOut_Click(sender As Object, e As EventArgs) Handles btnTryOut.Click
        Destino()
        comando.ProbarOpticas(destinoX, destinoY)
    End Sub

    Private Sub btnTryIn_Click(sender As Object, e As EventArgs) Handles btnTryIn.Click
        Destino()
        comando.ProbarSensores(destinoX, destinoY)
    End Sub

    Private Sub btnOffTest_Click(sender As Object, e As EventArgs) Handles btnOffTest.Click
        Destino()
        comando.Apagar(destinoX, destinoY)
    End Sub
End Class