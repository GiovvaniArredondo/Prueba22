Public Class cCategoria
 
#Region " Privadas "
    Private mDb as New dbCategoria()
    Private mEntidad as Categoria
#End Region
 
    Public Function ObtenerLista() As listaCategoria
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerCategoria(ByRef mEntidad As Categoria) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarCategoria(ByVal cCatego As String) As Integer
        Dim mEntidad As New Categoria
        mEntidad.cCatego = cCatego
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarCategoria(ByVal aEntidad As Categoria) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtenerDataSet() As DataSet
        Return mDb.ObtenerDataSetPorID()
    End Function
End Class
