Public Class Persona
    Public Property Nombre As String
    Public Property Edad As Integer
    Public Property Estatura As Decimal
    Public Property Peso As Decimal
    Public Property Telefono As String
    Public Property Direccion As String

    Public Sub New()

    End Sub
    Public Sub New(nombre As String)
        nombre = nombre
    End Sub
    Public Sub New(nombre As String, edad As Integer)
        edad = edad
    End Sub
End Class
