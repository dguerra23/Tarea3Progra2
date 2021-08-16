Public Class Form1
    Dim SA As Double

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim Interes As Double
        Dim SP As Double
        Dim ST As Double
        Dim CB As Double
        Dim CP As Double
        Dim EF As Double
        If SaldoActualText.Text <> "" Then
            SA = SaldoActualText.Text
        End If
        If ChequePropioText.Text <> "" Then
            CP = ChequePropioText.Text
        End If
        If OtrosBancosText.Text <> "" Then
            CB = OtrosBancosText.Text
        End If
        If EfectivoText.Text <> "" Then
            EF = EfectivoText.Text
        End If



        SP = SA + CP + CB + EF


        If MonetariosPremier.Checked Then
            Select Case SP
                Case Is < 10001
                    Interes = SP * 0.025
                    InteresText.Text = "Q " + CStr(Interes)
                Case Is < 15001
                    Interes = SP * 0.03
                    InteresText.Text = "Q " + CStr(Interes)
                Case Is >= 15001
                    Interes = SP * 0.045
                    InteresText.Text = "Q " + CStr(Interes)
            End Select
        End If


        If RadioButton3.Checked Then
            Select Case SP
                Case Is < 1001
                    Interes = SP * 0.015
                    InteresText.Text = "Q " + CStr(Interes)
                Case Is < 5001
                    Interes = SP * 0.025
                    InteresText.Text = "Q " + CStr(Interes)
                Case Is < 15001
                    Interes = SP * 0.075
                    InteresText.Text = "Q " + CStr(Interes)
                Case Is >= 15001
                    Interes = SP * 0.045
                    InteresText.Text = "Q " + CStr(Interes)
            End Select
        End If

        If Monetarios.Checked Then
            Select Case SP
                Case Is < 1001
                    Interes = 0
                    InteresText.Text = "Q " + CStr(Interes)
            End Select
        End If
        ST = SP + Interes
        SaldoParcialText.Text = "Q " + CStr(SP)
        SaldoTotalText.Text = "Q " + CStr(ST)
    End Sub

    Private Sub ChequesPropios_CheckedChanged(sender As Object, e As EventArgs) Handles ChequesPropios.CheckedChanged
        If ChequesPropios.Checked = True Then
            ChequePropioText.Enabled = True
        Else
            ChequePropioText.Enabled = False
        End If
    End Sub

    Private Sub ChequeBancos_CheckedChanged(sender As Object, e As EventArgs) Handles ChequeBancos.CheckedChanged
        If ChequeBancos.Checked = True Then
            OtrosBancosText.Enabled = True
        Else
            OtrosBancosText.Enabled = False
        End If
    End Sub

    Private Sub Efectivo_CheckedChanged(sender As Object, e As EventArgs) Handles Efectivo.CheckedChanged
        If Efectivo.Checked = True Then
            EfectivoText.Enabled = True
        Else
            EfectivoText.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaldoActualText.Clear()
        SaldoParcialText.Clear()
        SaldoTotalText.Clear()
        InteresText.Clear()
        ChequePropioText.Clear()
        OtrosBancosText.Clear()
        EfectivoText.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim formSalida As Form2 = New Form2
        Me.Hide()
        formSalida.Show()

    End Sub
End Class
