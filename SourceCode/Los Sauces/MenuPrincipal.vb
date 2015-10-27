Public Class MenuPrincipal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub MedicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicoToolStripMenuItem.Click
        FrmABMDoctor.ShowDialog()
    End Sub
End Class
