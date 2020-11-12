Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class CambiarClave
    Dim DatosUsuario As BsonDocument
    ' Sub New(result As BsonDocument)

    ' Esta llamada es exigida por el diseñador.
    '  InitializeComponent()
    ' selectPregunta1.selectedIndex = result.Item(5).ToString
    ' selectPregunta2.selectedIndex = result.Item(7).ToString
    ' selectPregunta3.selectedIndex = result.Item(9).ToString


    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    'End Sub

    Private Sub CambiarClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosUsuario = UsuarioClave.ObtenerUsuario
        selectPregunta1.selectedIndex = DatosUsuario.Item(5).ToString
        selectPregunta2.selectedIndex = DatosUsuario.Item(7).ToString
        selectPregunta3.selectedIndex = DatosUsuario.Item(9).ToString
    End Sub

    Function ValidarRespuestas() As Boolean
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

        If (txtPassword.Text.ToString <> txtRepeatPassword.Text.ToString) Then
            Validador = False
            MessageBox.Show("Contraseñas incorrectas")
        End If

        Return Validador

    End Function

    Function Validar() As Boolean
        Dim Validador As Boolean = True

        If (txtRespuesta1.Text.ToString = "") Then
            Validador = False
        End If
        If (txtRespuesta2.Text.ToString = "") Then
            Validador = False
        End If
        If (txtRespuesta3.Text.ToString = "") Then
            Validador = False
        End If

        If (txtPassword.Text.ToString <> txtRepeatPassword.Text.ToString) Then
            Validador = False
            MessageBox.Show("Contraseñas incorrectas")
        End If

        Return Validador

    End Function

    Private Sub btnValidarRespuestas_Click(sender As Object, e As EventArgs) Handles btnValidarRespuestas.Click
        If Validar() Then
            MessageBox.Show("Correcto,ya puede habilitar el cambio de contraseña")
            btnSignIn.Enabled = True
        Else
            MessageBox.Show("Todas las respuestas deben ser contestadas correctamente.")
        End If
    End Sub
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If Validar() Then
            Login.Editar("admin", txtPassword.Text.ToString, "true")
            MessageBox.Show("Consetraseña modificada")
            'Me.Close()
            Me.Hide()
            LoginForm.Show()
        Else
            MessageBox.Show("Todos los campos deben ser llenados")
        End If

    End Sub


End Class