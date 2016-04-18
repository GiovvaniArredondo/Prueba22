Public Class cCLIDAGRO
 
#Region " Privadas "
    Private mDb as New dbCLIDAGRO()
    Private mEntidad as CLIDAGRO
#End Region
 
    Public Function ObtenerLista(ByVal ccodcli As String, ByVal ccodfue As String, ByVal devalua As String) As listaCLIDAGRO
        Return mDb.ObtenerListaPorID(ccodcli, ccodfue, devalua)
    End Function
 
    Public Function ObtenerCLIDAGRO(ByRef mEntidad As CLIDAGRO) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarCLIDAGRO(ByVal mEntidad As CLIDAGRO) As Integer
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarCLIDAGRO(ByVal aEntidad As CLIDAGRO) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function Agregar(ByVal aEntidad As entidadBase) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtenerDataSetPorID(ByVal ccodcli As String, ByVal ccodfue As String, ByVal devalua As DateTime, ByRef ds As DataSet) As Integer
        Return mDb.ObtenerDataSetPorID(ccodcli, ccodfue, devalua, ds)
    End Function
    Public Function ObtenerDataSet(ByVal ccodcli As String, ByVal ccodfue As String, ByRef ds As DataSet) As Integer
        Return mDb.ObtenerDataSet(ccodcli, ccodfue, ds)
    End Function
    Public Function ObtenerTotal(ByVal ccodcli As String, ByVal ccodfue As String, ByVal dfecha As Date) As DataSet
        Return mDb.ObtenerTotal(ccodcli, ccodfue, dfecha)
    End Function
    
End Class
