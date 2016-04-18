Public Class cActivoF
 
#Region " Privadas "
    Private mDb as New dbActivoF()
    Private mEntidad As ActivoF
#End Region
 
    Public Function ObtenerLista() As listaActivoF
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerActivoF(ByRef mEntidad As ActivoF) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarActivoF(ByVal ccodinv As String) As Integer
        Dim mEntidad As New ActivoF
        mEntidad.ccodinv = ccodinv
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarActivoF(ByVal aEntidad As ActivoF) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function Agregar(ByVal aEntidad As ActivoF) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

    Public Function BuscaCodigo() As String
        Return mDb.BuscaCodigo()
    End Function

    Public Function DatasetActivoFijo(ByVal ccodofi As String, ByVal ffondos As String, ByVal ndepre As Integer, ByVal ccodadq As String, ByVal ccodact As String, ByVal dfecha As DateTime) As DataSet
        Return mDb.DatasetActivoFijo(ccodofi, ffondos, ndepre, ccodadq, ccodact, dfecha)
    End Function

    Public Function BuscaInventario(ByVal cvariable As String, ByVal cvalor As Integer, ByVal dfecha As Date) As DataSet
        Return mDb.BuscaInventario(cvariable, cvalor, dfecha)
    End Function

    Public Function DetalleActivo(ByVal ccodinv As String) As DataSet
        Return mDb.DetalleActivo(ccodinv)
    End Function

    Public Function AsignarEmpleado(ByVal ccodinv As String, ByVal ccodusu As String, ByVal unidad As String, ByVal ubicacion As String) As String
        mDb.AsignarEmpleado(ccodinv, ccodusu, unidad, ubicacion)
    End Function
    Public Function DatasetActivoFijoPartida() As DataSet
        Return mDb.DatasetActivoFijoPartida()
    End Function
    Public Function DescargaActivoFijo(ByVal ccodofi As String, ByVal ccodusu As String, ByVal ccodinv As String) As String
        Return mDb.DescargaActivoFijo(ccodofi, ccodusu, ccodinv)
    End Function
    Public Function TrasladaActivoFijo(ByVal ccodofi As String, ByVal ccodusu As String, ByVal ccodinv As String) As String
        Return mDb.TrasladaActivoFijo(ccodofi, ccodusu, ccodinv)
    End Function

End Class

