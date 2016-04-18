Public Class cTabtmak
 
#Region " Privadas "
    Private mDb as New dbTabtmak()
    Private mEntidad as Tabtmak
#End Region
 
    Public Function ObtenerLista() As listaTabtmak
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerTabtmak(ByRef mEntidad As Tabtmak) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarTabtmak(ByVal ccodapl As String) As Integer
        Dim mEntidad As New Tabtmak
        mEntidad.ccodapl = ccodapl
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarTabtmak(ByVal aEntidad As Tabtmak) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
 
End Class
