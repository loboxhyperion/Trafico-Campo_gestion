

Imports Newtonsoft.Json

Module SaveData
    '/////////////////////////////////////////LAS FUNCIONES Create_Directories y CreateFiles VIENEN DEL MODULO Create_Directory_File/////////////////////////////////////

    ' FICHEROS Y GUARDADO DE DATOS
    'Var para modelado de datos json y clases
    Dim Interseccion As Interseccion1 = New Interseccion1() 'almacena todos los datos generales 
    Dim Interjson As String ' almacena el modelo de datos convertido a un formato json
    Function SaveDataInterseccion(InterCentralX, InterCentralY, InterAdr1, InterAdr0, InterDir1X, InterDir1Y, InterDest1X, InterDest1Y, InterV1, InterDest2X, InterDest2Y, InterV2,
                                   InterDir2X, InterDir2Y, InterDest3X, InterDest3Y, InterV3, InterDest4X, InterDest4Y, InterV4, InterDest5X, InterDest5Y, InterV5, InterDest6X, InterDest6Y, InterV6,
                                  InterDir3X, InterDir3Y, InterDest7X, InterDest7Y, InterV7, InterDest8X, InterDest8Y, InterV8, InterDest9X, InterDest9Y, InterV9)

        Interseccion.CetralX = InterCentralX
        Interseccion.CetralY = InterCentralY
        Interseccion.Adr1 = InterAdr1
        Interseccion.Adr0 = InterAdr0

        'INTERSECCIÓN 1
        Interseccion.Dir1X = InterDir1X
        Interseccion.Dir1Y = InterDir1Y
        Interseccion.Dest1X = InterDest1X
        Interseccion.Dest1Y = InterDest1Y
        Interseccion.V1 = InterV1
        Interseccion.Dest2X = InterDest2X
        Interseccion.Dest2Y = InterDest2Y
        Interseccion.V2 = InterV2

        'INTERSECCIÓN 2
        Interseccion.Dir2X = InterDir2X
        Interseccion.Dir2Y = InterDir2Y
        Interseccion.Dest3X = InterDest3X
        Interseccion.Dest3Y = InterDest3Y
        Interseccion.V3 = InterV3
        Interseccion.Dest4X = InterDest4X
        Interseccion.Dest4Y = InterDest4Y
        Interseccion.V4 = InterV4
        Interseccion.Dest5X = InterDest5X
        Interseccion.Dest5Y = InterDest5Y
        Interseccion.V5 = InterV5
        Interseccion.Dest6X = InterDest6X
        Interseccion.Dest6Y = InterDest6Y
        Interseccion.V6 = InterV6

        'INTERSECCIÓN 3
        Interseccion.Dir3X = InterDir3X
        Interseccion.Dir3Y = InterDir3Y
        Interseccion.Dest7X = InterDest7X
        Interseccion.Dest7Y = InterDest7Y
        Interseccion.V7 = InterV7
        Interseccion.Dest8X = InterDest8X
        Interseccion.Dest8Y = InterDest8Y
        Interseccion.V8 = InterV8
        Interseccion.Dest9X = InterDest9X
        Interseccion.Dest9Y = InterDest9Y
        Interseccion.V9 = InterV9



        'pasa Los datos almacenados en la clase o modelo Sinap a  un objeto json y se almacenan en un var string
        Interjson = JsonConvert.SerializeObject(Interseccion)

        CreateFiles("..\..\Intersecciones\Programacion.json", Interjson)

        Return True
    End Function
End Module
