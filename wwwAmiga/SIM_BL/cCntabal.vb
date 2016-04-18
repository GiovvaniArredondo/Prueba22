Public Class cCntabal
 
#Region " Privadas "
    Private mDb as New dbCntabal()
    Private mEntidad as Cntabal
#End Region
 
    Public Function ObtenerLista() As listaCntabal
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerCntabal(ByRef mEntidad As Cntabal) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarCntabal() As Integer
        Dim mEntidad As New cntabal
        'mEntidad.cfecmes = cfecmes
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCntabal(ByVal aEntidad As cntabal) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function Agregar(ByVal aEntidad) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function Actualizar1(ByVal aEntidad) As Integer
        Return mDb.Actualizar1(aEntidad)
    End Function
    Public Function ObtenerDataSetPorIDH(ByVal pcCodCta) As DataSet
        Return mDb.ObtenerDataSetPorIDH(pcCodCta)
    End Function
    Public Function ObtenerListaPorIDRes() As listacntabal
        Return mDb.ObtenerListaPorIDRes()
    End Function
End Class
