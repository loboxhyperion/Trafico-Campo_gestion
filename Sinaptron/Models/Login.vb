Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Login
    Public Shared Sub Guardar(usuario As String, password As String, rol As String, cambioclave As String, pregunta1 As Integer, respuesta1 As String, pregunta2 As Integer, respuesta2 As String, pregunta3 As Integer, respuesta3 As String)
        'Conexion a la base de datos
        Dim col = ConexioDb.Conexion("login", False)

        Dim doc As New BsonDocument()

        doc.Add("usuario", usuario)
        doc.Add("contraseña", password)
        doc.Add("rol", rol)
        doc.Add("cambioClave", cambioclave)
        doc.Add("pregunta1", pregunta1)
        doc.Add("respuesta1", respuesta1)
        doc.Add("pregunta2", pregunta2)
        doc.Add("respuesta2", respuesta2)
        doc.Add("pregunta3", pregunta3)
        doc.Add("respuesta3", respuesta3)
        doc.Add("date_created", Format(Date.Now, "dd/MM/yyyy HH:mm:ss tt"))
        doc.Add("date_mantenimiento", Date.Now.Date)

        col.InsertOneAsync(doc)
    End Sub
    Public Shared Function Consultar() As List(Of BsonDocument)

        Dim col = ConexioDb.Conexion("login", False)

        Dim result = col.Find(New BsonDocument).ToList

        Return result

    End Function

    Public Shared Async Function Editar(usuario As String, password As String, cambioclave As String) As Task
        'Conexion a la base de datos
        Dim col = ConexioDb.Conexion("login", False)



        Dim updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("usuario", usuario), Builders(Of BsonDocument).Update.Set(Of String)("contraseña", password))
        updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("usuario", usuario), Builders(Of BsonDocument).Update.Set(Of Date)("date_mantenimiento", Date.Now.Date))

    End Function
End Class
