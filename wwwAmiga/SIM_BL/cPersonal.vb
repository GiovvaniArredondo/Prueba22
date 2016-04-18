Public Class cPersonal
 
#Region " Privadas "
    Private mDb as New dbPersonal()
    Private mEntidad as Personal
#End Region
 
    'Public Function ObtenerLista() As listaPersonal
    '    Return mDb.ObtenerListaPorID()
    'End Function
 
    Public Function ObtenerPersonal(ByRef mEntidad As Personal) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarPersonal(ByVal idempleado As Int32) As Integer
        Dim mEntidad As New Personal
        mEntidad.idempleado = idempleado
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarPersonal(ByVal aEntidad As Personal) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
 
End Class
