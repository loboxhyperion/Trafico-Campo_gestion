Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System
Imports System.Text.RegularExpressions

Imports MongoDB.Driver.GridFS
Imports MongoDB.Driver.Linq
Public Class Registrar


    Private Sub Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ejecuta el servidor
        ServidorConexion.AbrirServidor()
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        InsertaDatos()
        ' Dim ConnectionString = "mongodb://localhost/"
        'Dim client = New MongoClient(ConnectionString)
        'Dim db = client.GetDatabase("sinaptron")

        'Dim col = db.GetCollection(Of BsonDocument)("login")
        'Dim doc = New BsonDocument
        'doc.Add("USER", txtUsuario.Text)
        ' doc.Add("PASSWORD", txtContraseña.Text)
        'doc.Add("ROL", cmboxRol.SelectedItem.ToString)

        'col.InsertOneAsync(doc)
        ' Console.WriteLine(cmboxRol.SelectedItem)
    End Sub
    Private Async Sub InsertaDatos()
        Dim ConnectionString = "mongodb://localhost/"
        Dim client = New MongoClient(ConnectionString)
        Dim db = client.GetDatabase("sinaptron")

        Dim col = db.GetCollection(Of BsonDocument)("login")

        Dim doc = New BsonDocument
        doc.Add("USER", txtUsuario.Text)
        doc.Add("PASSWORD", txtContraseña.Text)
        doc.Add("ROL", cmboxRol.SelectedItem.ToString)

        Console.WriteLine(cmboxRol.SelectedItem.ToString)
        Await col.InsertOneAsync(doc)

        Await BuscarTodo()

    End Sub

    Private Async Function BuscarTodo() As Task

        Dim ConnectionString = "mongodb://localhost/"
        Dim client = New MongoClient(ConnectionString)
        Dim db = client.GetDatabase("agenda")

        Dim col = db.GetCollection(Of BsonDocument)("datospersonales")

        Dim dtCliente As New DataTable("Cliente")
        dtCliente.Columns.Add("ID")
        dtCliente.Columns.Add("NOMBRE")
        dtCliente.Columns.Add("TELEFONO")
        dtCliente.Columns.Add("FECHA_NACIMIENTO")


        Dim dr As DataRow

        Using cursor = Await col.Find(New BsonDocument).ToCursorAsync
            While (Await cursor.MoveNextAsync())
                For Each doc In cursor.Current
                    dr = dtCliente.NewRow()
                    dr("ID") = doc("_id")
                    dr("NOMBRE") = doc("NOMBRE")
                    dr("TELEFONO") = doc("TELEFONO")
                    dr("FECHA_NACIMIENTO") = doc("FECHA_NACIMIENTO")
                    dtCliente.Rows.Add(dr)
                Next
            End While
        End Using

        Dim bs As New BindingSource
        bs.DataSource = dtCliente

    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginForm.Show()
    End Sub
End Class