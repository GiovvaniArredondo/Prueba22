Public Class credpro
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcta As String
 
    Private _nprovis As Decimal
 
    Private _nprovan As Decimal
 
    Private _nprovpas As Decimal
 
    Private _dfecpro As DateTime
 
    Private _cflag As String
 
    Private _nprovmor As Decimal
 
#End Region
 
#Region " Propiedades "
    Public Property ccodcta() As String
        Get
            Return _ccodcta
        End Get
        Set(ByVal Value As String)
            _ccodcta = Value
        End Set
    End Property 
 
    Public Property nprovis() As Decimal
        Get
            Return _nprovis
        End Get
        Set(ByVal Value As Decimal)
            _nprovis = Value
        End Set
    End Property 
 
    Public Property nprovan() As Decimal
        Get
            Return _nprovan
        End Get
        Set(ByVal Value As Decimal)
            _nprovan = Value
        End Set
    End Property 
 
    Public Property nprovpas() As Decimal
        Get
            Return _nprovpas
        End Get
        Set(ByVal Value As Decimal)
            _nprovpas = Value
        End Set
    End Property 
 
    Public Property dfecpro() As DateTime
        Get
            Return _dfecpro
        End Get
        Set(ByVal Value As DateTime)
            _dfecpro = Value
        End Set
    End Property 
 
    Public Property cflag() As String
        Get
            Return _cflag
        End Get
        Set(ByVal Value As String)
            _cflag = Value
        End Set
    End Property 
 
    Public Property nprovmor() As Decimal
        Get
            Return _nprovmor
        End Get
        Set(ByVal Value As Decimal)
            _nprovmor = Value
        End Set
    End Property 
 
#End Region
End Class
