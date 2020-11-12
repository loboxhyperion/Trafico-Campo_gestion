Public Class EstadoBateriaSinaptronTab
    Dim VarCalVolt As Integer
    Private Sub EstadoBateriaSinaptronTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VarCalVolt = 151

        ProcesarModulos(SnGestion.SnFormat, SnGestion.SemaforoEstado)
    End Sub
    Public Sub ProcesarModulos(snFormat As DeserializeFormat, Semaforo As String)
        Dim nombre As String = "X:" + CInt("&H" & snFormat.X0).ToString + " Y:" + CInt("&H" & snFormat.Y0).ToString()
        'Dim nombre As String = ""
        'MessageBox.Show(snFormat.D0)

        'Energia.Guardar(nombre, Format((snFormat.D0 * 10) / VarCalVolt, "0.00"), Format((snFormat.D1 * 10) / VarCalVolt, "0.00"))
        Select Case Semaforo
            Case "Sinaptron1"

                lblEstado.Text = "ACTIVO"
                lblEstado.ForeColor = Color.Lime
                'Actualiza X y Y
                txtSnX.Text = CInt("&H" & snFormat.X0)
                txtSnY.Text = CInt("&H" & snFormat.Y0)

                'Actualiza fecha hora
                lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
                lblHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

                'Actualiza Batería, Panel, Energía
                txtNVBatt.Text = Format((snFormat.D0 * 10) / VarCalVolt, "0.00")
                txtNVPanel.Text = Format((snFormat.D1 * 10) / VarCalVolt, "0.00")
                txtStatus.Text = snFormat.D2

                btnHistorial.Tag = nombre

                ' If Format((snFormat.D0 * 10) / VarCalVolt, "0.00") <= 10 Then
                'TLed = True
                'PlayLoopingBackgroundSoundFile()
               ' End If
                '-------------------------------------------------------------------
            Case "Sinaptron2"
                lblEstado2.Text = "ACTIVO"
                lblEstado2.ForeColor = Color.Lime
                'Actualiza X y Y
                txtSnX2.Text = CInt("&H" & snFormat.X0)
                txtSnY2.Text = CInt("&H" & snFormat.Y0)

                'Actualiza fecha hora
                Label45.Text = DateTime.Now.ToString("dd/MM/yyyy")
                Label40.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

                'Actualiza Batería, Panel, Energía
                txtNVBatt2.Text = Format((snFormat.D0 * 10) / VarCalVolt, "0.00")
                txtNVPanel2.Text = Format((snFormat.D1 * 10) / VarCalVolt, "0.00")
                txtStatus2.Text = snFormat.D2

                btnHistorial2.Tag = nombre
                'Alerta dado el caso que la bateria este en menos de 10
                ' If Format((snFormat.D0 * 10) / VarCalVolt, "0.00") <= 10 Then
                'TLed = True
                'PlayLoopingBackgroundSoundFile()
                'End If
                 '-------------------------------------------------------------------
            Case "Sinaptron3"
                lblEstado3.Text = "ACTIVO"
                lblEstado3.ForeColor = Color.Lime
                'Actualiza X y Y
                txtSnX3.Text = CInt("&H" & snFormat.X0)
                txtSnY3.Text = CInt("&H" & snFormat.Y0)

                'Actualiza fecha hora
                Label67.Text = DateTime.Now.ToString("dd/MM/yyyy")
                Label62.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

                'Actualiza Batería, Panel, Energía
                txtNVBatt3.Text = Format((snFormat.D0 * 10) / VarCalVolt, "0.00")
                txtNVPanel3.Text = Format((snFormat.D1 * 10) / VarCalVolt, "0.00")
                txtStatus3.Text = snFormat.D2

                btnHistorial3.Tag = nombre
                '-------------------------------------------------------------------
            Case "Sinaptron4"
                'lblEstado.Text = "ACTIVO"
                ' lblEstado.ForeColor = Color.Lime
                'Actualiza X y Y
                ' txtSnX4.Text = CInt("&H" & snFormat.X0)
                ' txtSnY4.Text = CInt("&H" & snFormat.Y0)

                'Actualiza fecha hora
                Label38.Text = DateTime.Now.ToString("dd/MM/yyyy")
                Label8.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

                'Actualiza Batería, Panel, Energía
                ' txtNVBatt.Text = Format((snFormat.D0 * 10) / VarCalVolt, "0.00")
                'txtNVPanel.Text = Format((snFormat.D1 * 10) / VarCalVolt, "0.00")
                txtStatus.Text = snFormat.D2

                btnHistorial4.Tag = nombre
                '-------------------------------------------------------------------
            Case "Sinaptron5"
                ' lblEstado5.Text = "ACTIVO"
                ' lblEstado5.ForeColor = Color.Lime
                'Actualiza X y Y
                'txtSnX5.Text = CInt("&H" & snFormat.X0)
                'txtSnY5.Text = CInt("&H" & snFormat.Y0)

                'Actualiza fecha hora
                lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
                lblHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

                'Actualiza Batería, Panel, Energía
                ' txtNVBatt.Text = Format((snFormat.D0 * 10) / VarCalVolt, "0.00")
                'txtNVPanel.Text = Format((snFormat.D1 * 10) / VarCalVolt, "0.00")
                txtStatus.Text = snFormat.D2

                btnHistorial5.Tag = nombre
                '-------------------------------------------------------------------
            Case Else
                ' lblEstado6.Text = "ACTIVO"
                ' lblEstado6.ForeColor = Color.Lime
                'Actualiza X y Y
                ' txtSnX6.Text = CInt("&H" & snFormat.X0)
                'txtSnY6.Text = CInt("&H" & snFormat.Y0)

                'Actualiza fecha hora
                lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
                lblHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

                'Actualiza Batería, Panel, Energía
                txtNVBatt.Text = Format((snFormat.D0 * 10) / VarCalVolt, "0.00")
                txtNVPanel.Text = Format((snFormat.D1 * 10) / VarCalVolt, "0.00")
                txtStatus.Text = snFormat.D2

                btnHistorial6.Tag = nombre
                '-------------------------------------------------------------------
        End Select

    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click, btnHistorial6.Click, btnHistorial5.Click, btnHistorial4.Click, btnHistorial3.Click, btnHistorial2.Click
        Dim nombreSinap As Button = sender
        'Dim EnergiaSinaptron As New EstadoBateriaSinaptronTab(nombreSinap.Tag)
        'EnergiaSinaptron.Show()
    End Sub
End Class