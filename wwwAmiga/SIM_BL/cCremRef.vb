Public Class cCremRef
 
#Region " Privadas "
    Private mDb as New dbCremRef()
    Private mEntidad as CremRef
#End Region
 
    Public Function ObtenerLista() As listaCremRef
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerCremRef(ByRef mEntidad As CremRef) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarCremRef(ByVal ccodcta As String) As Integer
        Dim mEntidad As New CremRef
        mEntidad.ccodcta = ccodcta
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarCremRef(ByVal aEntidad As CremRef) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerDataSetEsp1(ByVal cCodigo As String) As DataSet
        Return mDb.ObtenerDataSetEsp1(cCodigo)
    End Function
    Public Function ObtenerDataSetEsp2(ByVal cCodigo As String) As DataSet
        Return mDb.ObtenerDataSetEsp2(cCodigo)
    End Function
    Public Function ObtenerDataSetEsp3(ByVal cCodigo As String) As DataSet
        Return mDb.ObtenerDataSetEsp3(cCodigo)
    End Function
    Public Function Agregar(ByRef mEntidad As CremRef) As Integer
        Return mDb.Agregar(mEntidad)
    End Function

    Public Function Extra_Detalle_Cancelaciones(ByVal pcCodcta As String, ByVal pdfecha As Date) As DataTable
        Return mDb.Extra_Detalle_Cancelaciones(pcCodcta, pdfecha)
    End Function
End Class
