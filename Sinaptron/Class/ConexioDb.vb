Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ConexioDb
    Public Shared Function Conexion(Collecion As String, FlagRemoto As Boolean) As IMongoCollection(Of BsonDocument)
        Dim ConnectionString = If(FlagRemoto = True, "mongodb://admin:admin1@ds033559.mlab.com:33559/semaforos", "mongodb://localhost/")
        Console.WriteLine(ConnectionString)
        Dim client = New MongoClient(ConnectionString)
        Dim db = client.GetDatabase("semaforos")

        Dim col = db.GetCollection(Of BsonDocument)(Collecion)

        Return col
    End Function
End Class
