Public Class cEncuestas
 
#Region " Privadas "
    Private mDb as New dbEncuestas()
    Private mEntidad as Encuestas
#End Region
 
    Public Function ObtenerLista(ByVal ccodenc As String) As listaEncuestas
        Return mDb.ObtenerListaPorID(ccodenc)
    End Function
 
    Public Function ObtenerEncuestas(ByRef mEntidad As Encuestas) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarEncuestas(ByVal ccodenc As String) As Integer
        Dim mEntidad As New Encuestas
        mEntidad.ccodenc = ccodenc
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarEncuestas(ByVal aEntidad As Encuestas) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtenerDataSetPorID(ByVal ccodenc As String) As DataSet
        Return mDb.ObtenerDataSetPorID(ccodenc)
    End Function
    Public Function ObtenerRespuestasPregunta(ByVal ccodenc As String, ByVal ccodpreg As String) As DataSet
        Return mDb.ObtenerRespuestasPregunta(ccodenc, ccodpreg)
    End Function
End Class
