Public Class cTabtvar
 
#Region " Privadas "
    Private mDb as New dbTabtvar()
    Private mEntidad as Tabtvar
#End Region
 
    Public Function ObtenerLista(ByVal ccodapl As String) As listatabtvar
        Return mDb.ObtenerListaPorID(ccodapl)
    End Function

    Public Function ObtenerTabtvar(ByRef mEntidad As tabtvar) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarTabtvar(ByVal ccodapl As String) As Integer
        Dim mEntidad As New tabtvar
        mEntidad.ccodapl = ccodapl
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarTabtvar(ByVal aEntidad As tabtvar) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    'ObtenerDataSetPorID
    Public Function ObtenerDataSetPorID() As DataSet
        Dim dstmp1 As DataSet
        Dim lccodapl As String = "CRE"
        Return mDb.ObtenerDataSetPorID("CRE")
    End Function

    Public Function ValidaEstadoCierre() As Boolean
        Return mDb.ValidaEstadoCierre()
    End Function

    Public Function Genera_Tabla_Historica(ByVal pdfecini As Date) As Integer
        Return mDb.Genera_Tabla_Historica(pdfecini)
    End Function

End Class
