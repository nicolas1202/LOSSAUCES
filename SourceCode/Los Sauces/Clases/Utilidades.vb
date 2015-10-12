Public Class Utilidades

    Public Shared Sub SOLO_NUMEROS(e As KeyPressEventArgs, puntoDecimal As Boolean)
        If (Char.IsDigit(e.KeyChar)) Then
            If (puntoDecimal And e.KeyChar = ".") Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If
    End Sub


End Class
