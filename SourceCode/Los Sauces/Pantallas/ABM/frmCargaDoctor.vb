Public Class FrmCargaDoctor

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        cboxEspecialidad.DataSource = MEDICONG.ObtenerEspecialidades()
        cboxEspecialidad.DisplayMember = "nomesp"
        cboxEspecialidad.ValueMember = "nroesp"
        cboxEspecialidad.SelectedIndex = 0
    End Sub


    Private Sub btnAddTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click
        lstTelefonos.Items.Add(txtTelefono.Text)
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        Utilidades.SOLO_NUMEROS(e, False)
    End Sub

    Private Sub FrmCargaDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxGenero.SelectedIndex = 0
    End Sub

    Private Sub btnBuscaImg_Click(sender As Object, e As EventArgs) Handles btnBuscaImg.Click
        Dim openn As OpenFileDialog
        openn = New OpenFileDialog()
        If openn.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pboxPerfil.ImageLocation = openn.FileName
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminarTelefono_Click(sender As Object, e As EventArgs) Handles btnEliminarTelefono.Click
        Try
            lstTelefonos.Items.RemoveAt(lstTelefonos.SelectedIndex)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    End Sub
End Class