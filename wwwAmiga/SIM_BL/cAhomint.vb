Public Class cAhomint
 
#Region " Privadas "
    Private mDb as New dbAhomint()
    Private mEntidad as Ahomint
#End Region
 
    Public Function ObtenerLista(ByVal ccodcrt As String, ByVal dfecpro As Date) As listaahomint
        Return mDb.ObtenerListaPorID(ccodcrt, dfecpro)
    End Function

    Public Function ObtenerAhomint(ByRef mEntidad As ahomint) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarAhomint(ByVal ccodcrt As String) As Integer
        Dim mEntidad As New ahomint
        mEntidad.ccodcrt = ccodcrt
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarAhomint(ByVal aEntidad As ahomint) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function


    Public Function agregar(ByVal aEntidad As ahomint) As Integer
        Return mDb.Agregar(aEntidad)
    End Function


    Public Function ObtenerDataSetPorfecha(ByVal dfecha As Date) As DataSet
        Return mDb.ObtenerDataSetPorfecha(dfecha)
    End Function

End Class
