Public Class Portada

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    'Se abre el menu principal'
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        MenuPrincipal.Show()


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Se cierra el programa'
        End
    End Sub
End Class