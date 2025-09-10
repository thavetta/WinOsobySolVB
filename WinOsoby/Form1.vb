Imports System.IO
Imports Exporters
Imports Osoby

Public Class Form1

    Private _zoznam As ZoznamOsob

    Private Sub Start(sender As Object, e As EventArgs) Handles MyBase.Load
        _zoznam = New ZoznamOsob()
        Me.ListBox1.DataSource = _zoznam
        Me.DataGridView1.DataSource = _zoznam
    End Sub

    Private Sub KoniecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KoniecToolStripMenuItem.Click
        Dim vysledok = MessageBox.Show("Skutočne skončiť", "Koniec", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If vysledok = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub UložCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UložCSVToolStripMenuItem.Click

        Dim subor As String
        Using sfd As New SaveFileDialog

            sfd.Filter = "CSV |*.csv | TXT |*.txt | Vsetko|*.*"
            sfd.FileName = "data.csv"

            Dim volba = sfd.ShowDialog()
            If volba = DialogResult.Cancel Then
                Return
            End If

            subor = sfd.FileName
        End Using

        Dim exporter As New CSVExporter
        exporter.ExportOsobToCsv(_zoznam, subor)

    End Sub
End Class
