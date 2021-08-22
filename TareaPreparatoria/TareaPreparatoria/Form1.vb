Public Class Form1
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles KingBtn.CheckedChanged

    End Sub

    Private Sub CalcularBtn_Click(sender As Object, e As EventArgs) Handles CalcularBtn.Click
        Dim OMImperial As Double = 65.5
        Dim OMMatrimonial As Double = 85.99
        Dim OMQueen As Double = 99.99
        Dim OMKing As Double = 105.99
        Dim Lino As Double = 15
        Dim Algodon As Double = 23.99
        Dim Seda As Double = 30.99
        Dim Hilo As Double = 39.99
        Dim EntradaLino As Double = 0
        Dim EntradaAlgodon As Double = 0
        Dim EntradaSeda As Double = 0
        Dim EntradaHilo As Double = 0
        If LinoText.Text <> "" Then
            EntradaLino = LinoText.Text
        End If
        If AlgodonText.Text <> "" Then
            EntradaAlgodon = AlgodonText.Text
        End If
        If SedaTxt.Text <> "" Then
            EntradaSeda = SedaTxt.Text
        End If
        If HiloTxt.Text <> "" Then
            EntradaHilo = HiloTxt.Text
        End If
        Dim PrecioCosto As Double
        Dim PrecioVenta As Double
        Dim PrecioSinManoObra As Double = (EntradaLino * Lino) + (EntradaAlgodon * Algodon) + (EntradaSeda * Seda) + (EntradaHilo * Hilo)
        Dim totalYardas As Double = EntradaLino + EntradaHilo + EntradaSeda + EntradaAlgodon

        If ImperialBtn.Checked Then
            If totalYardas = 3 Then
                PrecioCosto = PrecioSinManoObra + OMImperial
                PrecioVenta = PrecioCosto * 1.65
            End If
        End If
        If MatrimonialBtn.Checked Then
            If totalYardas = 5 Then
                PrecioCosto = PrecioSinManoObra + OMMatrimonial
                PrecioVenta = PrecioCosto * 1.65
            End If
        End If
        If QueenBtn.Checked Then
            If totalYardas = 6 Then
                PrecioCosto = PrecioSinManoObra + OMQueen
                PrecioVenta = PrecioCosto * 1.65
            End If
        End If
        If KingBtn.Checked Then
            If totalYardas = 7 Then
                PrecioCosto = PrecioSinManoObra + OMKing
                PrecioVenta = PrecioCosto * 1.65
            End If
        End If
        PrecioCostoTxt.Text = PrecioCosto
        PrecioVentaTxt.Text = PrecioVenta
        LinoTxt2.Text = EntradaLino * Lino
        AlgodonTxt2.Text = EntradaAlgodon * Algodon
        SedaTxt2.Text = EntradaSeda * Seda
        HiloTxt2.Text = EntradaHilo * Hilo
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

    Private Sub LimpiarBtn_Click(sender As Object, e As EventArgs) Handles LimpiarBtn.Click
        SedaTxt.Clear()
        LinoText.Clear()
        HiloTxt.Clear()
        AlgodonText.Clear()
        PrecioCostoTxt.Clear()
        PrecioVentaTxt.Clear()
        SedaTxt2.Clear()
        LinoTxt2.Clear()
        AlgodonTxt2.Clear()
        HiloTxt2.Clear()


    End Sub

    Private Sub SalirBtn_Click(sender As Object, e As EventArgs) Handles SalirBtn.Click
        Dim formPrincipal As Form2 = New Form2
        Me.Hide()
        formPrincipal.Show()
    End Sub
End Class
