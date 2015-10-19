Public Class MAESTRONG

    Public Shared Function AgregaMaestro(rznsocial As String, fecnac As DateTime, cuit1 As Short, cuit2 As Integer, cuit3 As Short, genero As String, tipmae As Integer) As Boolean
        Dim cmd As OleDb.OleDbCommand
        cmd = New OleDb.OleDbCommand("insert into maestro (razonsocial,fecnac,cuit1,cuit2,cuit3,genero,tipmae) values(@rs,@fecnac,@cuit1,@cuit2,@cuit3,@genero,@tip)")
        cmd.Parameters.Add("@rs", OleDb.OleDbType.VarChar).Value = rznsocial
        cmd.Parameters.Add("@fecnac", OleDb.OleDbType.DBDate).Value = fecnac
        cmd.Parameters.Add("@cuit1", OleDb.OleDbType.SmallInt).Value = cuit1
        cmd.Parameters.Add("@cuit2", OleDb.OleDbType.Integer).Value = cuit2
        cmd.Parameters.Add("@cuit3", OleDb.OleDbType.SmallInt).Value = cuit3
        cmd.Parameters.Add("@genero", OleDb.OleDbType.VarChar).Value = genero
        cmd.Parameters.Add("@tip", OleDb.OleDbType.VarChar).Value = tipmae
        'cmd.Parameters.Add("@img", OleDb.OleDbType.VarChar).Value = ""
        Return Utilidades.EjecutaCmd(cmd)
    End Function

    Public Shared Function EliminaMaestro(nromae As Integer) As Boolean
        Dim cmd As String = "delete from maestro where nromae = " & nromae
        Return Utilidades.EjecutaCmd(cmd)
    End Function
End Class
