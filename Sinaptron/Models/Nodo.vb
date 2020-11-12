Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Nodo
    Public Shared Sub Guardar(SnX As String, Sny As String, Latitude As Double, Longitude As Double, Dir As String, Calle As String, Carr As String)
        MapaTab.GMapControl1.Enabled = True

        'Conexion a la base de datos
        Dim col = ConexioDb.Conexion("sinaptron", True)

        Dim doc As New BsonDocument()

        Dim ref = SnX & Sny

        doc.Add("Ref", ref)
        doc.Add("SnX", SnX)
        doc.Add("SnY", Sny)
        doc.Add("Lat", Latitude)
        doc.Add("Long", Longitude)
        doc.Add("Direccion", Dir)
        doc.Add("Calle", Calle)
        doc.Add("Carrera", Carr)
        doc.Add("date_created", Format(Date.Now, "dd/MM/yyyy HH:mm:ss tt"))
        doc.Add("date_mantenimiento", Date.Now)

        col.InsertOneAsync(doc)

    End Sub
    Public Shared Function Consultar(ref As String) As List(Of BsonDocument)
        Dim col = ConexioDb.Conexion("sinaptron", True)

        Dim filter = New BsonDocument("Ref", ref)

        'Consulta todo
        Dim result = col.Find(filter).ToList


        Return result
    End Function

    Public Shared Function ConsultarTodo() As List(Of BsonDocument)

        Dim col = ConexioDb.Conexion("sinaptron", True)

        Dim result = col.Find(New BsonDocument).ToList

        Return result

    End Function
    Public Shared Async Function Editar(prevRef As String, SnX1 As String, SnY As String, Dir As String, Calle As String, Carr As String) As Task
        'Conexion a la base de datos
        Dim col = ConexioDb.Conexion("sinaptron", True)

        'below code will update one record of the data
        Dim ref = SnX1 & SnY



        Dim updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", prevRef), Builders(Of BsonDocument).Update.Set(Of String)("SnX", SnX1))
        updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", prevRef), Builders(Of BsonDocument).Update.Set(Of String)("SnY", SnY))
        updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", prevRef), Builders(Of BsonDocument).Update.Set(Of String)("Direccion", Dir))
        updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", prevRef), Builders(Of BsonDocument).Update.Set(Of String)("Calle", Calle))
        updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", prevRef), Builders(Of BsonDocument).Update.Set(Of String)("Carrera", Carr))
        updoneresult = Await col.UpdateOneAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", prevRef), Builders(Of BsonDocument).Update.Set(Of String)("Ref", ref))

    End Function
    Public Shared Async Function Eliminar(ref As String) As Task
        Dim col = ConexioDb.Conexion("sinaptron", True)

        Dim result = Await col.FindOneAndDeleteAsync(Builders(Of BsonDocument).Filter.Eq(Of String)("Ref", ref), New FindOneAndDeleteOptions(Of BsonDocument))
    End Function
    'Verfica que no se cree un sinaptron con las mismas coordenadas X / Y
    Public Shared Function VerificacionSn(SnX As String, SnY As String) As Boolean
        'Dim filter = New BsonDocument("FirstName", "Peter")
        Dim col = ConexioDb.Conexion("sinaptron", True)
        'Consulta todo
        Dim result = col.Find(New BsonDocument).ToList
        For Each item In result
            Console.WriteLine("pase")
            If SnX = item.Item(2).ToString And SnY = item.Item(3).ToString Then
                Return False
                'termina el ciclos
                Exit For
            End If

        Next

        Return True
    End Function
End Class
