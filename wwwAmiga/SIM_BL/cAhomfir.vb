Public Class cAhomfir
 
#Region " Privadas "
    Private mDb as New dbAhomfir()
    Private mEntidad as Ahomfir
#End Region
 
    Public Function ObtenerLista() As listaAhomfir
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerAhomfir(ByRef mEntidad As Ahomfir) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarAhomfir(ByVal ccodaho As String) As Integer
        Dim mEntidad As New Ahomfir
        mEntidad.ccodaho = ccodaho
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarAhomfir(ByVal aEntidad As Ahomfir) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function Agregar(ByVal aEntidad As entidadBase) As Integer
        Return mDb.Agregar(aEntidad)
    End Function


    Public Function Buscar_Firmas_Autorizadas(ByVal pcCodaho As String) As DataSet
        Return mDb.Buscar_Firmas_Autorizadas(pcCodaho)
    End Function

    Public Function Mantenimiento_Firmas_Autorizadas(ByVal Detalle_Cta As ArrayList, ByVal dt_fir As DataTable) As Integer
        Return mDb.Mantenimiento_Firmas_Autorizadas(Detalle_Cta, dt_fir)
    End Function
    Public Function CargaFirmas_() As DataSet
        Return mDb.CargaFirmas_()
    End Function

    Public Function CargaFirmas() As DataSet
        Return mDb.CargaFirmas()
    End Function

    Public Function Carga_Afiliacion() As DataSet
        Return mDb.Carga_Afiliacion()
    End Function
End Class
