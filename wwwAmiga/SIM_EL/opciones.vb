Public Class opciones
    Inherits entidadBase
#Region " Privadas "
    Private _idOpcion As Int32
 
    Private _idOpcionPadre As Int32
 
    Private _opcion As String
 
    Private _url As String
 
    Private _descripcion As String
 
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
 
    Public Property idOpcionPadre() As Int32
        Get
            Return _idOpcionPadre
        End Get
        Set(ByVal Value As Int32)
            _idOpcionPadre = Value
        End Set
    End Property 
 
    Public Property opcion() As String
        Get
            Return _opcion
        End Get
        Set(ByVal Value As String)
            _opcion = Value
        End Set
    End Property 
 
    Public Property url() As String
        Get
            Return _url
        End Get
        Set(ByVal Value As String)
            _url = Value
        End Set
    End Property 
 
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal Value As String)
            _descripcion = Value
        End Set
    End Property 
 
#End Region
End Class
