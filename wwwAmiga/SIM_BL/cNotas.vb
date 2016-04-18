Public Class cNotas
 
#Region " Privadas "
    Private mDb as New dbNotas()
    Private mEntidad as Notas
#End Region
 
    Public Function ObtenerLista(ByVal ccodcta As String) As listanotas
        Return mDb.ObtenerListaPorID(ccodcta)
    End Function
 
    Public Function ObtenerNotas(ByRef mEntidad As Notas) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarNotas(ByVal ccodcli As String) As Integer
        Dim mEntidad As New Notas
        mEntidad.ccodcli = ccodcli
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarNotas(ByVal aEntidad As Notas) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtieneNota(ByVal ccodcta As String, ByVal dfecha As String) As String
        Return mDb.ObtieneNota(ccodcta, dfecha)
    End Function
    Public Function Verficasiprocedenota(ByVal dfecha As Date, ByVal ccodcta As String) As Boolean
        Return mDb.Verficasiprocedenota(dfecha, ccodcta)
    End Function
    Public Function Agregar(ByVal aEntidad As entidadBase) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
End Class
