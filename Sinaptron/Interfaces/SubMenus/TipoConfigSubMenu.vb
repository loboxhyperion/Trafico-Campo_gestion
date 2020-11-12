Public Class TipoConfigSubMenu
    Private Sub btnPareSiga_Click(sender As Object, e As EventArgs) Handles btnPareSiga.Click
        SnGestion.DistribucionSection(True, 341)
        SnGestion.openChildForm(SnGestion.PanelChildForm, New DispositivoConfigTab())
    End Sub

    Private Sub btnSemaforo_Click(sender As Object, e As EventArgs) Handles btnSemaforo.Click
        SnGestion.DistribucionSection(True, 341)
        SnGestion.openChildForm(SnGestion.PanelChildForm, New InterseccionConfigTab())
    End Sub

    Dim EsColapzado As Boolean = True

    Private Sub ColapzarTipos_Tick(sender As Object, e As EventArgs) Handles ColapzarTipos.Tick
        If EsColapzado Then
            btnTipos.Iconimage_right = My.Resources.ARROW_DASHBOARD_CONTRAER
            FlowLayoutPanel1.Height += 10

            If FlowLayoutPanel1.Size = FlowLayoutPanel1.MaximumSize Then
                ColapzarTipos.Stop()
                EsColapzado = False
            End If
        Else

            btnTipos.Iconimage_right = My.Resources.ARROW_DASHBOARD_EXPANDIR
            FlowLayoutPanel1.Height -= 10

            If FlowLayoutPanel1.Size = FlowLayoutPanel1.MinimumSize Then
                FlowLayoutPanel1.Height += 10
                ColapzarTipos.Stop()
                EsColapzado = True
            End If
        End If
    End Sub

    Private Sub btnTipos_Click(sender As Object, e As EventArgs) Handles btnTipos.Click
        ColapzarTipos.Start()
    End Sub
End Class