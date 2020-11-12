Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.Net.NetworkInformation

Public Class LoginForm
    Dim login As Login = New Login()
    Dim FlagLogin = False



    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Star Mongo server
        ServidorConexion.AbrirServidor()

        Try
            Dim col = ConexioDb.Conexion("login", False)

            Dim result = col.Find(New BsonDocument).ToList

            If result.Count > 0 Then
                Label1.Text = "Login"
                btnSignIn.Text = "Conectar"
                FechaLimiteCambioClave(result)

            Else
                Me.Close()
                PrimeraClave.Show()


            End If

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try


    End Sub

    Private Sub FechaLimiteCambioClave(result As List(Of BsonDocument))
        For Each item In result
            Dim resultado = Date.Now - item.Item(12).ToUniversalTime
            Console.WriteLine(resultado)
            Console.WriteLine(resultado.Days)
            Console.WriteLine(resultado.Hours)
            If resultado.Days = 5 Then

                ' Dim cambiarClave As New CambiarClave(item)
                UsuarioClave.EnviarUsuario(item)
                Me.Close()
                CambiarClave.Show()
            End If
        Next

    End Sub

    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        'devuelve la mac del ethernet 
        Return nics(0).GetPhysicalAddress.ToString
    End Function
    Private Sub PrimeraClaveS()
        'registra un nuevo usuario
        ' Login.Guardar("admin", "admin", "administrador", "false", "pregunta1", "respuesta1", "pregunta2", "respuesta2", "pregunta3", "respuesta3")
        ' MessageBox.Show("Primer usuario creado")
    End Sub

    Private Sub btnRecuperarClave_Click(sender As Object, e As EventArgs) Handles btnRecuperarClave.Click
        If txtUsuario.Text = "" Then
            MessageBox.Show("Dígite primero el usuario al que desea recuperar la clave")
        Else
            Try
                Dim col = ConexioDb.Conexion("login", False)

                Dim result = col.Find(New BsonDocument).ToList

                If result.Count > 0 Then
                    Console.WriteLine("pase por aqui")
                    For Each item In result
                        'Si encuentra al usuario lo manda a recuperar la contraseña
                        If item.Item(1).ToString = txtUsuario.Text.ToString Then

                            'Dim cambiarClave As New CambiarClave(item)
                            UsuarioClave.EnviarUsuario(item)
                            Me.Hide()
                            CambiarClave.Show()
                        End If
                    Next
                Else
                    MessageBox.Show("no hay  registros")
                End If

            Catch ex As Exception
                Console.WriteLine(ex)
            End Try
        End If


    End Sub

    Public permisos As Permisos
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        Try
            Dim rol As String = ""
            'si es por primera vez y no hay usuarios creados
            Dim CambioClave As Boolean = False

            'Consulta los registros en la base de datos por medio del modelo
            Dim result = Login.Consultar()
            If result.Count > 0 Then
                For Each item In result
                    If txtUsuario.Text = item.Item(1).ToString And txtPassword.Text = item.Item(2).ToString Then
                        FlagLogin = True
                        rol = item.Item(3)
                    End If
                Next

            End If
            If txtUsuario.Text = "ad" And txtPassword.Text = "123" Then
                PrimeraClave.Show()
                Me.Opacity = 0
            Else

                If FlagLogin = True Then
                    permisos = New Permisos(rol)
                    SnGestion.Show()
                    Me.Owner = SnGestion
                    Me.Hide()
                Else
                    MessageBox.Show(" El usuario o la contraseña son incorrectas")
                End If
            End If


        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

    End Sub


    Private Sub btnMac_Click(sender As Object, e As EventArgs) Handles btnMac.Click
        Dim Mac As String
        Mac = getMacAddress()
        MessageBox.Show(Mac)
    End Sub


End Class