Public Class FuncionalidadTab
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

    Dim FlagAlert As Boolean = True
    Dim FlagAmarillo As Boolean = True
    ' Dim FlagFase0 As Boolean = True
    ' Dim FlagFase1 As Boolean = False
    ' Dim FlagFase2 As Boolean = False
    'Dim FlagFase3 As Boolean = False

    Private Sub tmrSemafo_Tick(sender As Object, e As EventArgs) Handles tmrSemafo.Tick
        '   If FlagFase0 Then
        'PictureBox1.Image = Image.FromFile("..\..\img\TrafficOff.png")
        'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        'FlagFase0 = False
        'FlagFase1 = True
        ' ElseIf FlagFase1 Then
        ' PictureBox1.Image = Image.FromFile("..\..\img\Red.png")
        'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        'FlagFase1 = False
        'FlagFase2 = True
        'ElseIf FlagFase2 Then
        'PictureBox1.Image = Image.FromFile("..\..\img\Yellow.png")
        'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        'FlagFase2 = False
        'FlagFase3 = True
        ' ElseIf FlagFase3 Then
        ' PictureBox1.Image = Image.FromFile("..\..\img\Green.png")
        'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        'FlagFase3 = False
        'FlagFase0 = True
        'End If

    End Sub
    Private Sub tmrInterRoja_Tick(sender As Object, e As EventArgs) Handles tmrInterRoja.Tick
        If FlagAlert Then
            btnIntermitenciaRoja.Iconimage = My.Resources.interroja
            FlagAlert = False
        Else
            btnIntermitenciaRoja.Iconimage = My.Resources.interrojaoff
            FlagAlert = True
        End If
    End Sub

    Private Sub tmrInterAmarilla_Tick(sender As Object, e As EventArgs) Handles tmrInterAmarilla.Tick
        If FlagAmarillo Then
            btnIntermitenciaAmarilla.Iconimage = My.Resources.interamarilla
            FlagAmarillo = False
        Else
            btnIntermitenciaAmarilla.Iconimage = My.Resources.interamarillaoff
            FlagAmarillo = True
        End If
    End Sub


End Class