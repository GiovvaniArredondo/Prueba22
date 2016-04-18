Public Class cBOLETAS
 
#Region " Privadas "
    Private mDb as New dbBOLETAS()
    Private mEntidad as BOLETAS
#End Region

    Public Function Agregar(ByVal aEntidad As BOLETAS) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtenerLista(ByVal cbanco As String, ByVal cnuming As String) As listaBOLETAS
        Return mDb.ObtenerListaPorID(cbanco, cnuming)
    End Function
 
    Public Function ObtenerBOLETAS(ByRef mEntidad As BOLETAS) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarBOLETAS(ByVal cbanco As String) As Integer
        Dim mEntidad As New BOLETAS
        mEntidad.cbanco = cbanco
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarBOLETAS(ByVal aEntidad As BOLETAS) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ValidaBoleta(ByVal cnuming As String) As Boolean
        Return mDb.ValidaBoleta(cnuming)
    End Function
End Class
