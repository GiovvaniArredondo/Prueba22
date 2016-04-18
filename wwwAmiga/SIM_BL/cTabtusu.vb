Public Class cTabtusu
 
#Region " Privadas "
    Private mDb as New dbTabtusu()
    Private mEntidad as Tabtusu
#End Region
 
    Public Function ObtenerLista(ByVal cCatego As String, ByVal cCodofi As String) As listatabtusu
        Return mDb.ObtenerListaPorID(cCatego, cCodofi)
    End Function

    Public Function ObtenerTabtusu(ByRef mEntidad As tabtusu) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function ObtenerDataSetPorID() As DataSet
        Return mDb.ObtenerDataSetPorID()
    End Function

    Public Function EliminarTabtusu(ByVal ccodusu As String) As Integer
        Dim mEntidad As New tabtusu
        mEntidad.ccodusu = ccodusu
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarTabtusu(ByVal aEntidad As tabtusu) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerListaPorusuario(ByVal usuario As String) As listatabtusu
        Return mDb.ObtenerListaPorusuario(usuario)
    End Function
    Public Function usuario(ByVal ccodusu As String) As String
        Return mDb.usuario(ccodusu)
    End Function
    Public Function NombreUsuario(ByVal pccodusu As String) As String
        Return mDb.NombreUsuario(pccodusu)
    End Function
    Public Function ObtieneAnalistaGrupo(ByVal cCodsol As String, ByVal dfecvig As Date) As String
        Return mDb.ObtieneAnalistaGrupo(cCodsol, dfecvig)
    End Function
    Public Function ObtenerListaPorID2() As listatabtusu
        Return mDb.ObtenerListaPorID2()
    End Function
    Public Function usuariooficina(ByVal pccodusu As String) As String
        Return mDb.usuariooficina(pccodusu)
    End Function
    Public Function ObtenerResponsableCaja(ByVal ccodofi As String) As DataSet
        Return mDb.ObtenerResponsableCaja(ccodofi)
    End Function
End Class
