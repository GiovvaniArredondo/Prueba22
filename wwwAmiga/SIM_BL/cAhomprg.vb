Public Class cAhomprg
 
#Region " Privadas "
    Private mDb as New dbAhomprg()
    Private mEntidad as Ahomprg
#End Region
 
    'Public Function ObtenerLista() As listaahomprg
    '    Return mDb.ObtenerListaPorID()
    'End Function
 
    Public Function ObtenerAhomprg(ByRef mEntidad As Ahomprg) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarAhomprg(ByVal ccodcli As String) As Integer
        Dim mEntidad As New Ahomprg
        mEntidad.ccodcli = ccodcli
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarAhomprg(ByVal aEntidad As Ahomprg) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerProgramados() As DataSet
        Return mDb.ObtenerProgramados()
    End Function
    Public Function ActualizaEstadodeAplicacion(ByVal ccodcta As String) As Integer
        Return mDb.ActualizaEstadodeAplicacion(ccodcta)
    End Function
End Class
