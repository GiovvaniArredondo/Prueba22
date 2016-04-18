Public Class cCnumes
 
#Region " Privadas "
    Private mDb as New dbCnumes()
    Private mEntidad as Cnumes
#End Region
 
    Public Function ObtenerLista() As listaCnumes
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerCnumes(ByRef mEntidad As Cnumes) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarCnumes(ByVal numes As String) As Integer
        Dim mEntidad As New Cnumes
        mEntidad.numes = numes
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarCnumes(ByVal aEntidad As Cnumes) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ActualizarCnumes1(ByVal aEntidad As cnumes) As Integer
        Return mDb.ActualizarCnumes(aEntidad)
    End Function
End Class
