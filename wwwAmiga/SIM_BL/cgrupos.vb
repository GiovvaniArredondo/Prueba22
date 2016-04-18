Public Class cgrupos
#Region " Privadas "
    Private mDb As New dbGrupos
    Private mEntidad As grupos
#End Region

    Public Function ObtenerLista() As listagrupos
        Return mDb.ObtenerListaPorID()
    End Function

    Public Function Obtenergrupos(ByRef mEntidad As grupos) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function Eliminargrupos(ByRef mEntidad As grupos) As Integer
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function Actualizargrupos(ByVal aEntidad As grupos) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function obtenerlis() As listagrupos
        Return mDb.ObtenerListaPorID()
    End Function

    Public Function ActualizarCremcreRev(ByVal aEntidad As grupos) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerListaPorID() As listagrupos
        Return mDb.ObtenerListaPorID()
    End Function
    Public Function ObtenerIDCentro(ByVal ccodsol) As String
        Return mDb.ObtenerIDCentro(ccodsol)
    End Function
End Class
