Public Class cPagadurias
 
#Region " Privadas "
    Private mDb as New dbPagadurias()
    Private mEntidad as Pagadurias
#End Region
 
    Public Function ObtenerLista() As listaPagadurias
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerPagadurias(ByRef mEntidad As Pagadurias) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarPagadurias(ByVal nombre As String) As Integer
        Dim mEntidad As New Pagadurias
        mEntidad.nombre = nombre
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarPagadurias(ByVal aEntidad As Pagadurias) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function Agregar(ByVal aEntidad As pagadurias) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function AgregaporPagaduria(ByVal ccodcta As String, ByVal ccodcli As String, ByVal cnomcli As String, _
                                       ByVal ncuota As Double) As Integer
        Return mDb.AgregaporPagaduria(ccodcta, ccodcli, cnomcli, ncuota)
    End Function
    Public Function EliminaporPagaduria(ByVal cCodcta As String) As Integer
        Return mDb.EliminaporPagaduria(cCodcta)
    End Function
    Public Function ObtenerPagaduria() As DataSet
        Return mDb.ObtenerPagaduria()
    End Function
End Class
