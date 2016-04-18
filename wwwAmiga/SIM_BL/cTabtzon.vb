Public Class cTabtzon
 
#Region " Privadas "
    Private mDb as New dbTabtzon()
    Private mEntidad as Tabtzon
#End Region
 
    Public Function ObtenerLista(ByVal cTipzon As String) As listatabtzon
        Return mDb.ObtenerListaPorID(cTipzon)
    End Function
    Public Function ObtenerLista1(ByVal cCodzon As String, ByVal cTipzon As String) As listatabtzon
        Return mDb.ObtenerListaPorID1(cCodzon, cTipzon)
    End Function

    Public Function ObtenerTabtzon(ByRef mEntidad As tabtzon) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarTabtzon(ByVal ccodzon As String) As Integer
        Dim mEntidad As New tabtzon
        mEntidad.ccodzon = ccodzon
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarTabtzon(ByVal aEntidad As tabtzon) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function Zona(ByVal ccodigo As String) As String
        Return mDb.Zona(ccodigo)
    End Function
    Public Function ObtieneNumerodeOrden(ByVal lccodigo As String) As String
        Return mDb.ObtieneNumerodeOrden(lccodigo)
    End Function
    Public Function ObtieneCodigoDepto(ByVal lccodigo As String) As String
        Return mDb.ObtieneCodigoDepto(lccodigo)
    End Function
    Public Function Extraer_Datos_Zona(ByVal pcCodzon As String) As ArrayList
        Return mDb.Extraer_Datos_Zona(pcCodzon)
    End Function

End Class
