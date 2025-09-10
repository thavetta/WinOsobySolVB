Imports System.IO
Imports Osoby

Public Class CSVExporter

    Public Sub ExportOsobToCsv(zoznam As IEnumerable(Of Osoba), Optional subor As String = "data.csv")
        Dim komplet As New List(Of String)
        komplet.Add("Meno;Priezvisko;RokNarodenia;Plat")
        For Each osoba In zoznam
            Dim text(3) As String
            text(0) = osoba.Meno
            text(1) = osoba.Priezvisko
            text(2) = osoba.RokNarodenia
            text(3) = osoba.Plat
            Dim riadok As String = String.Join(";", text)
            komplet.Add(riadok)
        Next
        File.WriteAllLines(subor, komplet)
    End Sub
End Class
