Public Class cTabtciu
 
#Region " Privadas "
    Private mDb as New dbTabtciu()
    Private mEntidad as Tabtciu
#End Region
 
    Public Function ObtenerLista() As listaTabtciu
        Return mDb.ObtenerListaPorID()
    End Function
    Public Function ObtenerLista2(ByVal ccodigo As String) As listatabtciu
        Return mDb.ObtenerListaPorID2(ccodigo)
    End Function
    Public Function ObtenerTabtciu(ByRef mEntidad As tabtciu) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarTabtciu(ByVal ccodigo As String) As Integer
        Dim mEntidad As New tabtciu
        mEntidad.ccodigo = ccodigo
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarTabtciu(ByVal aEntidad As tabtciu) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function CIIU(ByVal ccodigo) As String
        Return mDb.CIIU(ccodigo)
    End Function
    Public Function ObtenerDataSetPorID() As DataSet
        Return mDb.ObtenerDataSetPorID()
    End Function
End Class
