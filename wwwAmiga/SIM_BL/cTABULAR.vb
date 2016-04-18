Public Class cTABULAR
 
#Region " Privadas "
    Private mDb as New dbTABULAR()
    Private mEntidad as TABULAR
#End Region
 
    Public Function ObtenerLista(ByVal ccodcli As String, ByVal ccodenc As String, ByVal ccodpreg As String) As listaTABULAR
        Return mDb.ObtenerListaPorID(ccodcli, ccodenc, ccodpreg)
    End Function
 
    Public Function ObtenerTABULAR(ByRef mEntidad As TABULAR) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarTABULAR(ByVal aEntidad As entidadBase) As Integer
        '        Dim mEntidad As New TABULAR
        '       mEntidad.ccodcli = ccodcli
        Return mDb.Eliminar(aEntidad)
    End Function
 
    Public Function ActualizarTABULAR(ByVal aEntidad As TABULAR) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function Agregar(ByVal aEntidad As entidadBase) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtenerDatosTabular() As DataSet
        Return mDb.ObtenerDatosTabular()
    End Function
End Class
