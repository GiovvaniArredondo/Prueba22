Public Class cnumes
    Inherits entidadBase
#Region " Privadas "
    Private _numes As String
 
    Private _cnumcom As String
 
    Private _cierre As Boolean
 
#End Region
 
#Region " Propiedades "
    Public Property numes() As String
        Get
            Return _numes
        End Get
        Set(ByVal Value As String)
            _numes = Value
        End Set
    End Property 
 
    Public Property cnumcom() As String
        Get
            Return _cnumcom
        End Get
        Set(ByVal Value As String)
            _cnumcom = Value
        End Set
    End Property 
 
    Public Property cierre() As Boolean
        Get
            Return _cierre
        End Get
        Set(ByVal Value As Boolean)
            _cierre = Value
        End Set
    End Property 
 
#End Region
End Class
