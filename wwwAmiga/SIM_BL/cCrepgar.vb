Public Class cCrepgar
 
#Region " Privadas "
    Private mDb as New dbCrepgar()
    Private mEntidad as Crepgar
#End Region
 
    Public Function ObtenerLista(ByVal ccodcta As String, ByVal ccodcli As String) As listacrepgar
        Return mDb.ObtenerListaPorID(ccodcta, ccodcli)
    End Function

    Public Function ObtenerCrepgar(ByRef mEntidad As crepgar) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarCrepgar(ByVal ccodcta As String) As Integer
        Dim mEntidad As New crepgar
        mEntidad.ccodcta = ccodcta
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCrepgar(ByVal aEntidad As crepgar) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function Actualizar1(ByVal aEntidad As crepgar) As Integer
        Return mDb.Actualizar1(aEntidad)
    End Function
    'fran
    Public Function AgregarCrepgar(ByVal aEntidad As crepgar) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtenerDataSetPorID(ByVal ccodcta As String, ByVal ccodcli As String) As DataSet
        Return mDb.ObtenerDataSetPorID(ccodcta, ccodcli)
    End Function
    Public Function ObtenerGarHipo(ByVal ccodcta As String) As DataSet
        Return mDb.ObtenerGarHipo(ccodcta)
    End Function
    Public Function ObtenerDataSetPorGravamen(ByVal ccodcta As String, ByVal ccodcli As String) As DataSet
        Return mDb.ObtenerDataSetPorGravamen(ccodcta, ccodcli)
    End Function
    Public Function ObtenerGarantiaPorGravamen(ByVal ccodcta As String, ByVal ccodcli As String) As String
        Return mDb.ObtenerGarantiaPorGravamen(ccodcta, ccodcli)
    End Function
    Public Function ObtenerGarantiaFiadoresPorGravamen(ByVal ccodcta As String, ByVal ccodcli As String) As String
        Return mDb.ObtenerGarantiaFiadoresPorGravamen(ccodcta, ccodcli)
    End Function
    Public Function ObtenerGarantiasdeuntipoRegistrada(ByVal ccodcta As String, ByVal ctipgar As String) As Integer
        Return mDb.ObtenerGarantiasdeuntipoRegistrada(ccodcta, ctipgar)
    End Function
    Public Function EliminarCrepgar2(ByVal aEntidad As entidadBase) As Integer
        Return mDb.EliminarCrepgar2(aEntidad)
    End Function
    Public Function ValorGarantia(ByVal lccodcta As String) As Double
        Return mDb.ValorGarantia(lccodcta)
    End Function

    Public Function ObtenerGarantiaComprometida(ByVal cCodcta As String) As String
        Return mDb.ObtenerGarantiaComprometida(cCodcta)
    End Function
End Class
