Public Class cUsuarioGrupo
 
#Region " Privadas "
    Private mDb as New dbUsuarioGrupo()
    Private mEntidad as UsuarioGrupo
#End Region
 
    Public Function ObtenerLista(ByVal idusuario As Integer) As listausuarioGrupo
        Return mDb.ObtenerListaPorID(idusuario)
    End Function

    Public Function ObtenerUsuarioGrupo(ByRef mEntidad As usuarioGrupo) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function agregar(ByRef mEntidad As usuarioGrupo) As Integer
        Return mDb.Agregar(mEntidad)
    End Function


    Public Function EliminarUsuarioGrupo(ByVal idUsuario As Int32) As Integer
        Dim mEntidad As New usuarioGrupo
        mEntidad.idUsuario = idUsuario
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarUsuarioGrupo(ByVal aEntidad As usuarioGrupo) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    'obtiene dataset por codigo y grupo
    Public Function ObtenerDataSetPorID2(ByVal idusuario, ByVal idgrupo) As DataSet
        Return mDb.ObtenerDataSetPorID2(idusuario, idgrupo)
    End Function
    Public Function RetornaGrupo(ByVal usuario As String) As Integer
        Return mDb.RetornaGrupo(usuario)
    End Function
    Public Function DataSetReportes(ByVal idgrupo As Integer) As DataSet
        Return mDb.DataSetReportes(idgrupo)
    End Function
End Class
