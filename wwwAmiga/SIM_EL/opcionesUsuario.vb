Public Class opcionesUsuario
    Inherits entidadBase
#Region " Privadas "
    Private _idOpcion As Int32
 
    Private _idUsuario As Int32
 
#End Region
 
#Region " Propiedades "
    Public Property idOpcion() As Int32
        Get
            Return _idOpcion
        End Get
        Set(ByVal Value As Int32)
            _idOpcion = Value
        End Set
    End Property 
 
    Public Property idUsuario() As Int32
        Get
            Return _idUsuario
        End Get
        Set(ByVal Value As Int32)
            _idUsuario = Value
        End Set
    End Property 
 
#End Region
End Class
