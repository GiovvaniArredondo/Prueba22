Public Class Encuestas
    Inherits entidadBase
#Region " Privadas "
    Private _ccodenc As String
 
    Private _ccodpreg As String
 
    Private _cpregunta As String
 
#End Region
 
#Region " Propiedades "
    Public Property ccodenc() As String
        Get
            Return _ccodenc
        End Get
        Set(ByVal Value As String)
            _ccodenc = Value
        End Set
    End Property 
 
    Public Property ccodpreg() As String
        Get
            Return _ccodpreg
        End Get
        Set(ByVal Value As String)
            _ccodpreg = Value
        End Set
    End Property 
 
    Public Property cpregunta() As String
        Get
            Return _cpregunta
        End Get
        Set(ByVal Value As String)
            _cpregunta = Value
        End Set
    End Property 
 
#End Region
End Class
