Public Class cCntaemp
 
#Region " Privadas "
    Private mDb as New dbCntaemp()
    Private mEntidad as Cntaemp
#End Region
 
    Public Function ObtenerLista() As listaCntaemp
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerCntaemp(ByRef mEntidad As Cntaemp) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarCntaemp(ByVal ccodemp As String) As Integer
        Dim mEntidad As New Cntaemp
        mEntidad.ccodemp = ccodemp
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarCntaemp(ByVal aEntidad As Cntaemp) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function Nuevo(ByVal ccodemp As String) As Boolean
        Return mDb.Nuevo(ccodemp)
    End Function
    Public Function Agregar(ByVal aEntidad As entidadBase) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtenerProveedores() As DataSet
        Return mDb.ObtenerProveedores()
    End Function
End Class
