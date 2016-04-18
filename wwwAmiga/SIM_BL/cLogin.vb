Public Class cLogin
    Public Function ValidarUsuario(ByVal usuario As String, ByVal password As String) As Boolean
        Dim mDbUsuario As New dbUsuarios
        Return mDbUsuario.ValidarUsuario(usuario, password)
    End Function
    Public Function ObtenerRoles(ByVal idUsuario As Integer) As String()
        Dim mDbUsuarioGrupo As New dbUsuarioGrupo
        Dim mEntidad As New usuarioGrupo
        Dim mLista As New listausuarioGrupo
        mLista = mDbUsuarioGrupo.ObtenerListaPorID(idUsuario)
        Dim roles(0) As String
        ReDim roles(mLista.Count - 1)
        Dim i As Integer = 0
        For Each mEntidad In mLista
            roles(i) = (New dbGrupos).ObtenerListaPorID().BuscarPorId(mEntidad.idGrupo).codigoGrupo
        Next
        Return roles
    End Function

    Public Function ObtenerListaOpciones(ByVal idUsuario As Integer) As listaopciones
        Dim mDbOpcionesGrupo As New dbOpcionesGrupo
        Dim mLista As New listaopciones
        Return mDbOpcionesGrupo.ObtenerListaPorUsuario(idUsuario)
    End Function
    Public Function Nivel(ByVal usuario As String) As Integer
        Dim mdbusuario As New dbUsuarios
        Return mdbusuario.Nivel(usuario)
    End Function
    Public Function Oficina(ByVal usuario As String) As String
        Dim mdbusuario As New dbUsuarios
        Return mdbusuario.Oficina(usuario)
    End Function
    Public Function VenClave(ByVal usuario As String) As Date
        Dim mdbusuario As New dbUsuarios
        Return mdbusuario.VenClave(usuario)
    End Function
    Public Function IdUsuario(ByVal usuario As String) As Integer
        Dim mdbusuario As New dbUsuarios
        Return mdbusuario.IdUsuario(usuario)
    End Function

    Public Function zona(ByVal usuario As String) As String
        Dim mdbusuario As New dbUsuarios
        Return mdbusuario.zona(usuario)
    End Function

End Class
