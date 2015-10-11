Public Class CargaDatos
    ' click en volver a menu principal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MenuPrincipal.Show()

    End Sub

    ' se abre la ventana para cargar paciente'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click

        If rBtnPaciente.Checked Then
            Me.Close()
            cargaPaciente.Show()

        ElseIf rBtnDoctor.Checked Then
            Me.Close()
            cargaDoctor.Show()


        End If
    End Sub

    

    Private Sub CargaDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class