Public Class cCancela
 
#Region " Privadas "
    Private mDb as New dbCancela()
    Private mEntidad as Cancela
#End Region
 
    Public Function ObtenerLista() As listaCancela
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerCancela(ByRef mEntidad As Cancela) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarCancela(ByVal ccodcta As String) As Integer
        Dim mEntidad As New Cancela
        mEntidad.ccodcta = ccodcta
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarCancela(ByVal aEntidad As Cancela) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function Agregar(ByVal aEntidad As cancela) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function EliminarRef(ByVal cCodpre As String, ByVal ccodref As String) As Integer
        Dim mentidad As New cancela
        mentidad.ccodpre = cCodpre
        mentidad.ccodref = ccodref
        Return mDb.Eliminar(mentidad)
    End Function
    Public Function EliminarRefTodo(ByVal cCodpre As String) As Integer
        Dim mentidad As New cancela
        mentidad.ccodpre = cCodpre
        Return mDb.Eliminartodo(mentidad)
    End Function
    Public Function ObtenerDataSetPorID(ByVal ccodcta As String) As DataSet
        Return mDb.ObtenerDataSetPorID(ccodcta)
    End Function
    Public Function ObtenerDataSetPorCuenta(ByVal ccodcta As String) As DataSet
        Return mDb.ObtenerDataSetPorCuenta(ccodcta)
    End Function
End Class
