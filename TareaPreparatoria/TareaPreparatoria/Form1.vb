Public Class Form1
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles KingBtn.CheckedChanged

    End Sub

    Private Sub CalcularBtn_Click(sender As Object, e As EventArgs) Handles CalcularBtn.Click
        Dim OMImperial As Double
        Dim OMMatrimonial As Double
        Dim OMQueen As Double
        Dim OMKing As Double
        Dim Lino As Double
        Dim Algodon As Double
        Dim Seda As Double
        Dim Hilo As Double
        Dim PrecioCosto As Double
        Dim PrecioVenta As Double


    End Sub

    Private Sub LinoBtn_CheckedChanged(sender As Object, e As EventArgs) Handles LinoBtn.CheckedChanged
        If LinoBtn.Checked Then
            LinoText.Enabled = True
        End If
    End Sub

    Private Sub AlgodonBtn_CheckedChanged(sender As Object, e As EventArgs) Handles AlgodonBtn.CheckedChanged
        If AlgodonBtn.Checked Then
            AlgodonText.Enabled = True
        End If
    End Sub

    Private Sub SedaBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SedaBtn.CheckedChanged
        If SedaBtn.Checked Then
            SedaTxt.Enabled = True
        End If
    End Sub

    Private Sub HiloBtn_CheckedChanged(sender As Object, e As EventArgs) Handles HiloBtn.CheckedChanged
        If HiloBtn.Checked Then
            HiloTxt.Enabled = True
        End If
    End Sub
End Class
