Public Class MenuPrincipal
    'Cuando se carga el menu principal se cierra la portada'
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Portada.Hide()
    End Sub
    'Cuando hacemos click en volver portada se sierra el menu principal y nos redirecciona a la portada'
    Private Sub btnVolverPortada_Click(sender As Object, e As EventArgs) Handles btnVolverPortada.Click
        Me.Close()
        Portada.Show()
    End Sub
    'cuando hacemos click en cargar datos se abre la ventana de cargar datos ' 
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Me.Close()
        CargaDatos.Show()
    End Sub
    ' click salir, sale del programa'
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmABMDoctor.Show()
    End Sub
End Class
