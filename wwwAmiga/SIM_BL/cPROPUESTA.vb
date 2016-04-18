Public Class cPROPUESTA
 
#Region " Privadas "
    Private mDb as New dbPROPUESTA()
    Private mEntidad as PROPUESTA
#End Region
 
    Public Function ObtenerLista(ByVal ccodcta As String) As listaPROPUESTA
        Return mDb.ObtenerListaPorID(ccodcta)
    End Function
 
    Public Function ObtenerPROPUESTA(ByRef mEntidad As PROPUESTA) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarPROPUESTA(ByVal mEntidad As PROPUESTA) As Integer
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarPROPUESTA(ByVal aEntidad As PROPUESTA) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function Agregar(ByVal aEntidad As entidadBase) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtienePropuestas(ByVal cCodcta As String) As DataSet
        Return mDb.ObtienePropuestas(cCodcta)
    End Function
    Public Function ObtieneResolucion(ByVal cCodcta As String) As DataSet
        Return mDb.ObtieneResolucion(cCodcta)
    End Function

    Public Function Extrae_Resolucion_Usuario(ByVal Idusuario As Integer, ByVal cCodcta As String) As DataSet
        Return mDb.Extrae_Resolucion_Usuario(Idusuario, cCodcta)
    End Function
End Class
