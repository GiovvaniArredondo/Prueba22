Public Class usuarioGrupo
    Inherits entidadBase
#Region " Privadas "
    Private _idUsuario As Int32
 
    Private _idGrupo As Int32
 
#End Region
 
#Region " Propiedades "
    Public Property idUsuario() As Int32
        Get
            Return _idUsuario
        End Get
        Set(ByVal Value As Int32)
            _idUsuario = Value
        End Set
    End Property 
 
    Public Property idGrupo() As Int32
        Get
            Return _idGrupo
        End Get
        Set(ByVal Value As Int32)
            _idGrupo = Value
        End Set
    End Property 
 
#End Region
End Class
