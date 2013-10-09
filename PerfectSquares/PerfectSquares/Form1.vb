Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        Dim x As Integer
        lstResult.Items.Clear()

        Do While (x < 10 ^ 2)
            x = (x) ^ 0.5 + 1
            x = x ^ 2
            lstResult.Items.Add(x)
        Loop

    End Sub
End Class
