Public Class cDEPMBEN
 
#Region " Privadas "
    Private mDb as New dbDEPMBEN()
    Private mEntidad as DEPMBEN
#End Region
 
    Public Function ObtenerLista(ByVal ccodcrt As String) As listaDEPMBEN
        Return mDb.ObtenerListaPorID(ccodcrt)
    End Function

    Public Function ObtenerDEPMBEN(ByRef mEntidad As DEPMBEN) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarDEPMBEN(ByVal mEntidad As DEPMBEN) As Integer
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarDEPMBEN(ByVal aEntidad As DEPMBEN) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function Agregar(ByVal aEntidad As DEPMBEN) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

End Class
