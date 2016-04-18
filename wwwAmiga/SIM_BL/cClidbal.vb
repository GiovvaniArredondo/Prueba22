Public Class cClidbal
 
#Region " Privadas "
    Private mDb as New dbClidbal()
    Private mEntidad as Clidbal
#End Region
 
    'Public Function ObtenerLista(ByVal ccodcli As String, ByVal ccodfue As String) As listaclidbal
    '    Return mDb.ObtenerListaPorID(ccodcli, ccodfue)
    'End Function
    Public Function ObtenerLista(ByVal ccodcli As String, ByVal ccodfue As String, ByVal devalua As Date) As listaclidbal
        Return mDb.ObtenerListaPorID(ccodcli, ccodfue, devalua)
    End Function

    Public Function ObtenerClidbal(ByRef mEntidad As clidbal) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function ActualizarClidbal(ByVal aEntidad As clidbal) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenercCodFue(ByVal ccodcli As String) As String
        Return mDb.ObtenercCodFue(ccodcli)
    End Function

    Public Function Agrega(ByVal aEntidad As clidbal) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    

    Public Function EliminarClidbal(ByVal aEntidad As clidbal) As Integer
        Return mDb.Eliminar(aEntidad)
    End Function
    Public Function ObtenerDataSetPorcliente(ByVal ccodcli, ByVal ccodfue) As DataSet
        Return mDb.ObtenerDataSetPorcliente(ccodcli, ccodfue)
    End Function

    '
    Public Function ObtenerDataSetPorID(ByVal ccodcli As String, ByVal ccodfue As String, ByVal devalua As Date, ByRef ds As DataSet) As Integer
        Return mDb.ObtenerDataSetPorID(ccodcli, ccodfue, devalua, ds)
    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodcli As String, ByVal ccodfue As String, ByVal lningfam As Double, ByVal lngasfam As Double, ByVal devalua As Date) As DataSet
        Return mDb.ObtenerDataSetPorID(ccodcli, ccodfue, lningfam, lngasfam, devalua)
    End Function
    Public Function ObtenerDataSetPorIDMultiple(ByVal ccodcli As String, ByVal ccodfue As String, ByVal lningfam As Double, ByVal lngasfam As Double, ByVal devalua As Date) As DataSet
        Return mDb.ObtenerDataSetPorIDMultiple(ccodcli, ccodfue, lningfam, lngasfam, devalua)
    End Function
End Class
