Public Class FrmCargaDoctor

    Private Sub btnAddTelefono_Click(sender As Object, e As EventArgs) Handles btnAddTelefono.Click
        Utilidades.SOLO_NUMEROS(e, False)
        lstTelefonos.Items.Add(txtTelefono.Text)
    End Sub
End Class