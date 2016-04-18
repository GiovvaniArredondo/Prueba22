Public Class cTabtprf
 
#Region " Privadas "
    Private mDb as New dbTabtprf()
    Private mEntidad as Tabtprf
#End Region
 
    Public Function ObtenerLista() As listaTabtprf
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerTabtprf(ByRef mEntidad As Tabtprf) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarTabtprf(ByVal ccodigo As String) As Integer
        Dim mEntidad As New Tabtprf
        mEntidad.ccodigo = ccodigo
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarTabtprf(ByVal aEntidad As Tabtprf) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function profesion(ByVal ccodigo) As String
        Return mDb.profesion(ccodigo)
    End Function
End Class
