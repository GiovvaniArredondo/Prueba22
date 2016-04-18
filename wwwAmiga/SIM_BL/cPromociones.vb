Public Class cPromociones
 
#Region " Privadas "
    Private mDb as New dbPromociones()
    Private mEntidad as Promociones
#End Region
 
    Public Function ObtenerLista() As listaPromociones
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerPromociones(ByRef mEntidad As Promociones) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarPromociones(ByVal codigo As Int32) As Integer
        Dim mEntidad As New Promociones
        mEntidad.codigo = codigo
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarPromociones(ByVal aEntidad As Promociones) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
 
End Class
