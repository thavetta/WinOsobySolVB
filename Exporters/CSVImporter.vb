Imports System.IO
Imports Osoby

Public Class CSVImporter

    Public Function ImportOsobFromCsv(subor As String) As ZoznamOsob
        If Not File.Exists(subor) Then
            Throw New FileNotFoundException("Zadany subor neexistuje")
        End If

        Dim vstup = File.OpenText(subor)

        Dim riadok = vstup.ReadLine()
        riadok = vstup.ReadLine()
        Dim zoznam As New ZoznamOsob
        While (riadok IsNot Nothing)
            Dim pole() = riadok.Split("|")
            Dim osoba As New Osoba With
            {
                .Meno = pole(0),
                .Priezvisko = pole(1),
                .Plat = pole(3),
                .RokNarodenia = pole(2)
            }
            zoznam.Add(osoba)
            riadok = vstup.ReadLine()
        End While

        vstup.Close()


        Return zoznam

    End Function


End Class
