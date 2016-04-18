Public Class promociones
    Inherits entidadBase
#Region " Privadas "
    Private _codigo As Int32
 
    Private _nombre As String
 
    Private _vigencia As DateTime
 
#End Region
 
#Region " Propiedades "
    Public Property codigo() As Int32
        Get
            Return _codigo
        End Get
        Set(ByVal Value As Int32)
            _codigo = Value
        End Set
    End Property 
 
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal Value As String)
            _nombre = Value
        End Set
    End Property 
 
    Public Property vigencia() As DateTime
        Get
            Return _vigencia
        End Get
        Set(ByVal Value As DateTime)
            _vigencia = Value
        End Set
    End Property 
 
#End Region
End Class
