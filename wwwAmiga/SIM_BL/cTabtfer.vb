Public Class cTabtfer

#Region " Privadas "
    Private mDb as New dbTabtfer()
    Private mEntidad as Tabtfer
#End Region


    Public Function ObtenerLista() As listatabtfer
        Return mDb.ObtenerListaPorID()
    End Function

    Public Function ObtenerTabtfer(ByRef mEntidad As tabtfer) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarTabtfer(ByVal dferiad As DateTime) As Integer
        Dim mEntidad As New tabtfer
        mEntidad.dferiad = dferiad
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarTabtfer(ByVal aEntidad As tabtfer) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function


    Public Function ObtenerDataSetPorID() As DataSet
        Return mDb.ObtenerDataSetPorID()
    End Function
    Public Function ValidaFeriado(ByVal dfecha As Date) As Integer
        Return mDb.ValidaFeriado(dfecha)
    End Function
    Public Function ObtenerDataSetPorIDOficina(ByVal ccodofi As String, ByVal pdfecven As Date) As DataSet
        Return mDb.ObtenerDataSetPorIDOficina(ccodofi, pdfecven)
    End Function
End Class
