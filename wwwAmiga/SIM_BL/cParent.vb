Public Class cParent
 
#Region " Privadas "
    Private mDb as New dbParent()
    Private mEntidad as Parent
#End Region
 
    Public Function ObtenerLista() As listaParent
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerParent(ByRef mEntidad As Parent) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarParent(ByVal cparent As String) As Integer
        Dim mEntidad As New Parent
        mEntidad.cparent = cparent
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarParent(ByVal aEntidad As Parent) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
 
End Class
