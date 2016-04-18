Public Class cAhomtrs
 
#Region " Privadas "
    Private mDb as New dbAhomtrs()
    Private mEntidad as Ahomtrs
#End Region
 
    Public Function ObtenerLista() As listaAhomtrs
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerAhomtrs(ByRef mEntidad As Ahomtrs) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarAhomtrs(ByVal ccodtrs As String) As Integer
        Dim mEntidad As New Ahomtrs
        mEntidad.ccodtrs = ccodtrs
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarAhomtrs(ByVal aEntidad As Ahomtrs) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtenerCuenta(ByVal ccodtrs As String, ByVal campo As Integer) As String
        Return mDb.ObtenerCuenta(ccodtrs, campo)
    End Function
End Class
