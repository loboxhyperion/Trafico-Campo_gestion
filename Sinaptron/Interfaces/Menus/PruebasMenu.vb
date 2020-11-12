Public Class PruebasMenu

    '
    Private Sub btnBasico_Click(sender As Object, e As EventArgs) Handles btnBasico.Click
        SnGestion.DistribucionSection(True, 341)
        SnGestion.openChildForm(SnGestion.PanelChildForm, New BasicoTab())
    End Sub
    Private Sub btnFuncionalidad_Click(sender As Object, e As EventArgs) Handles btnFuncionalidad.Click
        SnGestion.DistribucionSection(True, 341)
        SnGestion.openChildForm(SnGestion.PanelChildForm2, New PruebasTab())
    End Sub


End Class