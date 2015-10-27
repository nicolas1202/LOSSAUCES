Imports Los_Sauces.DSLosSaucesTableAdapters
Public Class MEDICONG

    Public Sub AgregaMedico(legajo As Integer, nombre As String, apellido As String, genero As String, matricula As Integer, especialidad As Integer, fecnac As DateTime, cuit1 As Integer, cuit2 As Integer, cuit3 As Integer, nrosec As Integer, sueldo As Decimal, fecing As DateTime, hrentrada As Date, hrsalida As Date)
        Dim nromae As Integer = MAESTRONG.AgregaMaestro(apellido & " " & nombre, fecnac, cuit1, cuit2, cuit3, genero)
        Dim emp As EMPLEADOTableAdapter = New EMPLEADOTableAdapter()
        Dim med As MEDICOTableAdapter = New MEDICOTableAdapter()
        emp.Insert(nrosec, nromae, sueldo, fecing, hrentrada, hrsalida)
        med.Insert(nombre, apellido, legajo, especialidad, matricula, nromae)
    End Sub


End Class
