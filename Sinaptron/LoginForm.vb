Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.Net.NetworkInformation

Public Class LoginForm
    Dim login As Login = New Login()
    Dim FlagLogin = False
    Dim FlagNew = False


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Star Mongo server
        ServidorConexion.AbrirServidor()

        Try
            Dim col = ConexioDb.Conexion("login", False)

            Dim result = col.Find(New BsonDocument).ToList

            If result.Count > 0 Then
                Label1.Text = "Login"
                btnSignIn.Text = "Conectar"
                FlagNew = False
            Else
                Label1.Text = "Registrar"
                btnSignIn.Text = "Guardar"
                FlagNew = True
            End If

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        'devuelve la mac del ethernet 
        Return nics(0).GetPhysicalAddress.ToString
    End Function

    Public permisos As Permisos
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        Try
            Dim rol As String = ""
            'si es por primera vez y no hay usuarios creados
            If FlagNew = False Then
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

                If FlagLogin = True Then
                    permisos = New Permisos(rol)
                    SnPrincipal.Show()
                    Me.Owner = SnPrincipal
                    Me.Hide()
                Else
                    MessageBox.Show(" El usuario o la contraseña son incorrectas")
                End If
            Else
                'registra un nuevo usuario
                Login.Guardar(txtUsuario.Text, txtPassword.Text, "administrador")
                Label1.Text = "Login"
                btnSignIn.Text = "Conectar"
                FlagNew = False
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