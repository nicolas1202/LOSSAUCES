Public Class MEDICONG

    Public Shared Function ObtenerMedico(filtro As String) As DataTable
        Dim query As String = "select * from medico m, maestro mae where mae.nromae = m.nromae "
        If Not String.IsNullOrEmpty(filtro) Then
            query += " and " & filtro
        End If
        Return Utilidades.EjecutaConsulta(query)
    End Function

    Public Shared Function ObtenerMedico() As DataTable
        Return ObtenerMedico(String.Empty)
    End Function

    Public Shared Function ObtenerMedico(nromed As Integer) As DataTable
        Return ObtenerMedico("nromed = " & nromed.ToString())
    End Function

    Public Shared Function ObtenerEspecialidades() As DataTable
        Return Utilidades.EjecutaConsulta("select nroesp,nomesp from especialidad")
    End Function
    Public Shared Function ObtenerEspecialidades(nroesp As String) As DataTable
        Return Utilidades.EjecutaConsulta("select nroesp,nomesp from especialidad where nroesp = " & nroesp)
    End Function

    Public Shared Sub AgregaMedico(nommed As String, apemed As String, fecnac As DateTime, cuit1 As Short, cuit2 As Integer, cuit3 As Short, genero As String, calle As String, Nro As Integer, localidad As String, codpostal As String, pais As String, provincia As String)




        MAESTRONG.AgregaMaestro(apemed & " " & nommed, fecnac, 20, 38336632, 2, "Masculino", 1)

    End Sub


End Class
