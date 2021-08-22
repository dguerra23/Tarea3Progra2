Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formPrincipal As Form1 = New Form1
        Me.Hide()
        formPrincipal.Show()
    End Sub
End Class