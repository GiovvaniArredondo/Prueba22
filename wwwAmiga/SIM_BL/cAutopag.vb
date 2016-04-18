Public Class cAutopag
 
#Region " Privadas "
    Private mDb as New dbAutopag()
    Private mEntidad as Autopag
#End Region
 
    Public Function ObtenerLista() As listaAutopag
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerAutopag(ByRef mEntidad As Autopag) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function


    Public Function obtenerpagosfecha(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lccodofi As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String) As DataSet
        Return mDb.obtenerpagosfecha(ldfecha1, ldfecha2, lccodofi, lcanalista, lcestrato, lclineas)
    End Function

    Public Function EliminarAutopag(ByVal ccodcta As String) As Integer
        Dim mEntidad As New autopag
        mEntidad.ccodcta = ccodcta
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarAutopag(ByVal aEntidad As autopag) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function Agregar(ByVal aEntidad As autopag) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function RecibosATM(ByVal dfecha1 As Date, ByVal dfecha2 As Date) As DataSet
        Return mDb.RecibosATM(dfecha1, dfecha2)
    End Function

End Class
