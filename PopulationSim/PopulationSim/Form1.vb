Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim curYear As Integer
        Dim curPop As Double

        curPop = 7000
        curYear = 2012
        Do While (curPop > 6)
            curYear = curYear - 50
            curPop = curPop / 2

        Loop


        MessageBox.Show("The Year Is " & curYear, "Error")

    End Sub
End Class
