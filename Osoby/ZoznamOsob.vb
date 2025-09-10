Imports System.Collections.ObjectModel

Public Class ZoznamOsob
    Inherits ObservableCollection(Of Osoba)

    Public Sub New()
        Me.Add(New Osoba With {.Meno = "Ján", .Priezvisko = "Novák", .RokNarodenia = 1980, .Plat = 1500})
        Me.Add(New Osoba With {.Meno = "Mária", .Priezvisko = "Kováčová", .RokNarodenia = 1990, .Plat = 2000})
        Me.Add(New Osoba With {.Meno = "Peter", .Priezvisko = "Horváth", .RokNarodenia = 1975, .Plat = 2500})
        Me.Add(New Osoba With {.Meno = "Anna", .Priezvisko = "Vargová", .RokNarodenia = 1985, .Plat = 1800})
    End Sub

End Class
