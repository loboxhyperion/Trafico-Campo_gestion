Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Login
    Public Shared Sub Guardar(usuario As String, password As String, rol As String)
        'Conexion a la base de datos
        Dim col = ConexioDb.Conexion("login", False)

        Dim doc As New BsonDocument()

        doc.Add("usuario", usuario)
        doc.Add("contraseña", password)
        doc.Add("rol", rol)

        col.InsertOneAsync(doc)
    End Sub
    Public Shared Function Consultar() As List(Of BsonDocument)

        Dim col = ConexioDb.Conexion("login", False)

        Dim result = col.Find(New BsonDocument).ToList

        Return result

    End Function
End Class
