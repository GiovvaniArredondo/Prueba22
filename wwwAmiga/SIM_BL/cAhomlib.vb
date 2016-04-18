Public Class cAhomlib
 
#Region " Privadas "
    Private mDb as New dbAhomlib()
    Private mEntidad as Ahomlib
#End Region
 
    Public Function ObtenerLista(ByVal ccodaho As String) As listaahomlib
        Return mDb.ObtenerListaPorID(ccodaho)
    End Function
 
    Public Function ObtenerAhomlib(ByRef mEntidad As Ahomlib) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarAhomlib(ByVal ccodaho As String) As Integer
        Dim mEntidad As New Ahomlib
        mEntidad.ccodaho = ccodaho
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarAhomlib(ByVal aEntidad As Ahomlib) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerCorrelativoSugerido() As Integer
        Return mDb.ObtenerCorrelativoSugerido()
    End Function

    Public Function VerificaLibreta(ByVal nlibreta As Integer) As Boolean
        Return mDb.VerificaLibreta(nlibreta)
    End Function
    Public Function Agregar(ByVal aEntidad As entidadBase) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
End Class
