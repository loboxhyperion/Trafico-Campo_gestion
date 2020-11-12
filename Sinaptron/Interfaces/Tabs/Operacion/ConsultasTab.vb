Public Class ConsultasTab
    Public SnFormat As DeserializeFormat
    Dim TestTrama As String
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        TestTrama = "RF-848684888486FFFF00000091FFFFC0E60300000000000000000000000052."
        SnFormat = New DeserializeFormat(TestTrama)

        SnGestion.ClasificarCM(SnFormat)
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        TestTrama = "RF-848784888487FFFF00000091FFFFC0E60300000000000000000000000052."

        SnFormat = New DeserializeFormat(TestTrama)

        SnGestion.ClasificarCM(SnFormat)
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        TestTrama = "RF-848884888488FFFF00000091FFFFC0E60300000000000000000000000052."
        SnFormat = New DeserializeFormat(TestTrama)

        SnGestion.ClasificarCM(SnFormat)
    End Sub


End Class