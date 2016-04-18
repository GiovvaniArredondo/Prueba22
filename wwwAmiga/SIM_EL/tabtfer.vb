Public Class tabtfer
    Inherits entidadBase
#Region " Privadas "
    Private _dferiad As DateTime
 
    Private _xflag1 As String
 
#End Region
 
#Region " Propiedades "
    Public Property dferiad() As DateTime
        Get
            Return _dferiad
        End Get
        Set(ByVal Value As DateTime)
            _dferiad = Value
        End Set
    End Property 
 
    Public Property xflag1() As String
        Get
            Return _xflag1
        End Get
        Set(ByVal Value As String)
            _xflag1 = Value
        End Set
    End Property 
 
#End Region
End Class
