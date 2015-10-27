Public Class Utilidades

    Public Shared Sub SOLO_NUMEROS(e As KeyPressEventArgs, puntoDecimal As Boolean)
        If (Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub



End Class
