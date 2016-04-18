Public Class cCretgas
 
#Region " Privadas "
    Private mDb as New dbCretgas()
    Private mEntidad as Cretgas
#End Region
 
    Public Function ObtenerLista(ByVal cnrolin As String) As listacretgas
        Return mDb.ObtenerListaPorID(cnrolin)
    End Function

    Public Function ObtenerCretgas(ByRef mEntidad As cretgas) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarCretgas(ByRef mEntidad As cretgas) As Integer
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCretgas(ByVal aEntidad As cretgas) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    'Fran Eric
    Public Function ObtenerDataSetPorID(ByVal cNrolin As String) As DataSet
        Return mDb.ObtenerDataSetPorID(cNrolin)
    End Function

    'fuciona los gastos con la tabttab
    Public Function Obtenerdatasetgastos(ByVal cNrolin As String) As DataSet
        Return mDb.Obtenerdatasetgastos(cNrolin)
    End Function

    Public Function agregar(ByVal aEntidad As cretgas) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtienevalordeGasto(ByVal cnrolin As String, ByVal ctipgas As String, ByVal ccodope As String) As Decimal
        Return mDb.ObtienevalordeGasto(cnrolin, ctipgas, ccodope)
    End Function
End Class
