Imports Los_Sauces.DSLosSaucesTableAdapters

Public Class EMPLEADONG
    ''' <summary>
    ''' Agrega empleado y devuelve su nro de legajo.
    ''' </summary>
    ''' <param name="nrosec"></param>
    ''' <param name="nromae"></param>
    ''' <param name="sueldo"></param>
    ''' <param name="fecing"></param>
    ''' <param name="hrentrada"></param>
    ''' <param name="hrsalida"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function AgregaEmpleado(nrosec As Integer, nromae As Integer, sueldo As Decimal, fecing As Date, hrentrada As String, hrsalida As String) As Integer
        Dim hrent As TimeSpan
        Dim hrsal As TimeSpan
        Dim nroleg As Integer
        If TimeSpan.TryParse(hrentrada, hrent) And TimeSpan.TryParse(hrsalida, hrsal) Then
            Dim emp As EMPLEADOTableAdapter = New EMPLEADOTableAdapter()
            emp.Insert(nrosec, nromae, sueldo, fecing, hrentrada, hrsalida)
            nroleg = emp.ObtenerLegajo(nromae)
        Else
            Throw New Exception("Error: Horarios incorrectos!")
        End If

        Return nroleg
    End Function


End Class
