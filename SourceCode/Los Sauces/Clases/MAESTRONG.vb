Imports Los_Sauces.DSLosSaucesTableAdapters
Public Class MAESTRONG

    ''' <summary>
    ''' Agrega un maestro y retorna su id (nromae)
    ''' </summary>
    ''' <param name="rznSocial">Razon Social</param>
    ''' <param name="fecnac">Fecha nacimiento</param>
    ''' <param name="cuit1">primeros 2 digitos del CUIT</param>
    ''' <param name="cuit2">Digitos luego del segundo y antes del ultimo</param>
    ''' <param name="cuit3">Ultimo digito del cuit</param>
    ''' <param name="genero">Genero</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function AgregaMaestro(rznSocial As String, fecnac As Date, cuit1 As Integer, cuit2 As Integer, cuit3 As Integer, genero As String) As Integer
        Dim nromae As Integer
        Dim mae As MAESTROTableAdapter = New MAESTROTableAdapter()
        mae.Insert(rznSocial, fecnac, cuit1, cuit2, cuit3, genero)
        nromae = mae.ObtenerMaestro(cuit1, cuit2, cuit3)
        Return nromae
    End Function
End Class
