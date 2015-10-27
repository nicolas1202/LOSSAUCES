Public Class FrmABMDoctor
    Private filaActual As DataRowView
    Private Sub FrmABMDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdConsulta.AutoGenerateColumns = False
        Dim a As DSLosSaucesTableAdapters.MEDICOTableAdapter = New DSLosSaucesTableAdapters.MEDICOTableAdapter()
        grdConsulta.DataSource = a.GetDataTable()
    End Sub

    Private Sub grdConsulta_SelectionChanged(sender As Object, e As EventArgs) Handles grdConsulta.SelectionChanged

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As FrmCargaDoctor = New FrmCargaDoctor()
        If (DialogResult.OK = frm.ShowDialog()) Then

            'MEDICONG.AgregaMedico(frm.txtNombre.Text, frm.txtApellido.Text)

        End If



    End Sub
End Class