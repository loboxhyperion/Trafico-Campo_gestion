Public Class SetupMenu
    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        SnGestion.DistribucionSection(True, 341)
        SnGestion.openChildForm(SnGestion.PanelChildForm, New TipoConfigSubMenu())
    End Sub

End Class