Public Class cargaPaciente

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    ' se cierra la ventana y se abre la ventana de carga principal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        CargaDatos.Show()


    End Sub

 
End Class