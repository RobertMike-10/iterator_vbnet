Imports System

Module Program
    Sub Main(args As String())

        Dim objects() As Object = {"Zabdiel", 50, 34.6, Date.Now}
        Console.WriteLine("Valores del Array de Objeto")
        For Each item In objects
            Console.WriteLine(item.ToString)
        Next


        Console.WriteLine()

        Dim object2 = New Object() {1, True, "Miguel", DateTime.Now}
        Console.WriteLine("Valores del segundo Array de Objeto")
        For Each item In object2
            Console.WriteLine(item.ToString)
        Next

        Console.WriteLine()

        Dim objects3 As Object() = {"Beatriz", 34, 67.9, True}
        Console.WriteLine("Valores del tercer Array de Objeto")
        For Each item In objects3
            Console.WriteLine(item.ToString)
        Next
        Console.WriteLine()

        Dim theGalaxies As New Galaxies
        For Each theGalaxy In theGalaxies.NextGalaxy
            With theGalaxy
                Console.WriteLine(.Nombre & " a " & .DistanciaMillAnniosLuz)
            End With
        Next

        Console.ReadKey()
        Console.WriteLine()

        For Each item In DataShared.EsParImparData
            Console.WriteLine("Valor:" + item(0).ToString + " resultado:" + item(1).ToString)
        Next

        Console.WriteLine()

        For Each value As Integer In ComputePower(2, 10)
            Console.WriteLine(value)
        Next

    End Sub


    Public Class Galaxies
        Public ReadOnly Iterator Property NextGalaxy _
        As System.Collections.Generic.IEnumerable(Of Galaxy)
            Get
                Yield New Galaxy With {.Nombre = "Enana Elíptica de Sagitario", .DistanciaMillAnniosLuz = 0.081}
                Yield New Galaxy With {.Nombre = "Enana del Can Mayor", .DistanciaMillAnniosLuz = 0.025}
                Yield New Galaxy With {.Nombre = "Vía Láctea", .DistanciaMillAnniosLuz = 0}
                Yield New Galaxy With {.Nombre = "Andrómeda", .DistanciaMillAnniosLuz = 2.13}
                Yield New Galaxy With {.Nombre = "Gran Nube de Magallanes", .DistanciaMillAnniosLuz = 0.163}
                Yield New Galaxy With {.Nombre = "Enana de la Osa Menor", .DistanciaMillAnniosLuz = 0.206}
                Yield New Galaxy With {.Nombre = "Enana de la Osa Mayor ", .DistanciaMillAnniosLuz = 0.33}
            End Get
        End Property
    End Class

    Public Class Galaxy
        Public Property Nombre As String
        Public Property DistanciaMillAnniosLuz As Double
    End Class


    Public Class DataShared
        Public Shared ReadOnly Iterator Property EsParImparData As IEnumerable(Of Object())
            Get
                Yield New Object() {1, True}
                Yield New Object() {2, False}
                Yield New Object() {3, True}
            End Get
        End Property
    End Class


    Public Iterator Function ComputePower(ByVal number As Integer,
        ByVal exponent As Integer) As IEnumerable(Of Integer)
        Dim exponentNum As Integer = 0
        Dim numberResult As Integer = 1
        While exponentNum < exponent
            numberResult *= number
            exponentNum += 1
            Yield numberResult
        End While
    End Function

End Module
