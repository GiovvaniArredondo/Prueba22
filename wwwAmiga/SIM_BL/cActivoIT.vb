Public Class cActivoIT
#Region " Privadas "
    Private mDb As New dbActivoIT
    Private mEntidad As ActivoIT
#End Region

    Public Function Agregar(ByVal aEntidad As ActivoIT) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

    Public Function ObtenerActivoIT(ByRef mEntidad As ActivoIT) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
    Public Function Actualizar(ByRef mEntidad As ActivoIT) As Integer
        Return mDb.Actualizar(mEntidad)
    End Function
End Class
