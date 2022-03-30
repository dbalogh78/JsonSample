Imports System.Linq


Module Module1

  Sub Main()

    Dim cars = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Cars)(Data.jsonString)
    Dim toyotaId = cars.results.FirstOrDefault(Function(x) x.description.Equals("Toyota")).id

  End Sub

End Module
