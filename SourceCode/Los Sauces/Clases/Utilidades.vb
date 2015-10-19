Public Class Utilidades

    Public Shared Sub SOLO_NUMEROS(e As KeyPressEventArgs, puntoDecimal As Boolean)
        If (Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Public Shared Function EjecutaConsulta(pQuery As String) As DataTable
        Dim conex As String
        conex = My.MySettings.Default.CadenaConexion
        Dim adap As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(pQuery, conex)
        Dim res As DataTable = New DataTable()
        adap.Fill(res)
        Return res
    End Function

    Public Shared Function EjecutaCmd(pQuery As String) As Boolean
        Using conex As New OleDb.OleDbConnection(My.MySettings.Default.CadenaConexion)
            Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(pQuery, conex)
            Try
                cmd.CommandType = CommandType.Text
                conex.Open()
                cmd.ExecuteNonQuery()
                conex.Close()
                Return True
            Catch ex As Exception
                conex.Close()
                Return False
            End Try
        End Using
    End Function

    Public Shared Function EjecutaCmd(pCmd As OleDb.OleDbCommand) As Boolean
        Using conex As New OleDb.OleDbConnection(My.MySettings.Default.CadenaConexion)
            Try
                pCmd.Connection = conex
                pCmd.CommandType = CommandType.Text
                conex.Open()
                pCmd.ExecuteNonQuery()
                conex.Close()
                Return True
            Catch ex As Exception
                conex.Close()
                Return False
            End Try
        End Using
    End Function



End Class
