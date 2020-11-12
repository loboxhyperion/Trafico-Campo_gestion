Public Class PrimeraClave
    Private Sub PrimeraClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function Validar() As Boolean
        Dim Validador As Boolean = True

        If (selectPregunta1.selectedValue.ToString = "Seleccionar uno") Then
            Validador = False
        End If
        If (selectPregunta2.selectedValue.ToString = "Seleccionar uno") Then
            Validador = False
        End If
        If (selectPregunta3.selectedValue.ToString = "Seleccionar uno") Then
            Validador = False
        End If

        If (txtRespuesta1.Text.ToString = "") Then
            Validador = False
        End If
        If (txtRespuesta2.Text.ToString = "") Then
            Validador = False
        End If
        If (txtRespuesta3.Text.ToString = "") Then
            Validador = False
        End If

        If (txtUsuario.Text.ToString = "") Then
            Validador = False
        End If

        If (txtPassword.Text.ToString <> txtRepeatPassword.Text.ToString) Then
            Validador = False
            MessageBox.Show("Contraseñas incorrectas")
        End If

        Return Validador

    End Function
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If Validar() Then
            Login.Guardar(txtUsuario.Text.ToString, txtPassword.Text.ToString, "administrador", "true", selectPregunta1.selectedIndex, txtRespuesta1.Text.ToString, selectPregunta2.selectedIndex, txtRespuesta2.Text.ToString, selectPregunta3.selectedIndex, txtRespuesta3.Text.ToString)
            MessageBox.Show("Primer usuario creado")
            Me.Hide()
            LoginForm.Show()
        Else
            MessageBox.Show("Todos los campos deben ser llenados")
        End If
    End Sub


End Class