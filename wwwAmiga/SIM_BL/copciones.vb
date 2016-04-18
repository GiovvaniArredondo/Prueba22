Public Class copciones
#Region " Privadas "
    Private mDb As New dbOpciones
    Private mEntidad As opciones
#End Region

    Public Function ObtenerListaOpcionesGrupo(ByVal idgrupo) As listaopciones
        Return mDb.ObtenerListaOpcionesGrupo(idgrupo)
    End Function

    Public Function Obtenergrupos(ByRef mEntidad As grupos) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function Eliminaropciones(ByRef mEntidad As grupos) As Integer
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function Actualizaropciones(ByVal aEntidad As grupos) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    

End Class
