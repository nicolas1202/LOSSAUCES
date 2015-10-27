Public Class MenuPrincipal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub DoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoctorToolStripMenuItem.Click
        FrmABMDoctor.ShowDialog()
    End Sub
End Class
