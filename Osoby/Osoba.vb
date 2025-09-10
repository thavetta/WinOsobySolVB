Imports CsvHelper.Configuration.Attributes


Public Class Osoba
    Public Property Meno As String
    Public Property Priezvisko As String
    Public Property RokNarodenia As Integer

    Public Property Plat As Integer

    Public Overrides Function ToString() As String
        Return Priezvisko & ", " & Meno
    End Function
End Class
