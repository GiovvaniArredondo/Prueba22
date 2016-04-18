Public Class cAhompro2
 
#Region " Privadas "
    Private mDb as New dbAhompro2()
    Private mEntidad as Ahompro2
#End Region
 
    Public Function ObtenerLista() As listaAhompro2
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerAhompro2(ByRef mEntidad As Ahompro2) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarAhompro2(ByVal dultpro As DateTime) As Integer
        Dim mEntidad As New Ahompro2
        mEntidad.dultpro = dultpro
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarAhompro2(ByVal aEntidad As Ahompro2) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function Agregar(ByVal aEntidad As ahompro2) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

End Class
