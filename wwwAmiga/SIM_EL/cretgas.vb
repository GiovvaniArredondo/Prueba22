Public Class cretgas
    Inherits entidadBase
#Region " Privadas "
    Private _cnrolin As String
 
    Private _ctipgas As String
 
    Private _ccodope As String
 
    Private _nmonpor As Decimal
 
    Private _cgasobl As String
 
    Private _nincost As Decimal
 
    Private _lafeiva As Boolean
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String
 
    Private _cedad As String
 
#End Region
 
#Region " Propiedades "
    Public Property cnrolin() As String
        Get
            Return _cnrolin
        End Get
        Set(ByVal Value As String)
            _cnrolin = Value
        End Set
    End Property 
 
    Public Property ctipgas() As String
        Get
            Return _ctipgas
        End Get
        Set(ByVal Value As String)
            _ctipgas = Value
        End Set
    End Property 
 
    Public Property ccodope() As String
        Get
            Return _ccodope
        End Get
        Set(ByVal Value As String)
            _ccodope = Value
        End Set
    End Property 
 
    Public Property nmonpor() As Decimal
        Get
            Return _nmonpor
        End Get
        Set(ByVal Value As Decimal)
            _nmonpor = Value
        End Set
    End Property 
 
    Public Property cgasobl() As String
        Get
            Return _cgasobl
        End Get
        Set(ByVal Value As String)
            _cgasobl = Value
        End Set
    End Property 
 
    Public Property nincost() As Decimal
        Get
            Return _nincost
        End Get
        Set(ByVal Value As Decimal)
            _nincost = Value
        End Set
    End Property 
 
    Public Property lafeiva() As Boolean
        Get
            Return _lafeiva
        End Get
        Set(ByVal Value As Boolean)
            _lafeiva = Value
        End Set
    End Property 
 
    Public Property ccodusu() As String
        Get
            Return _ccodusu
        End Get
        Set(ByVal Value As String)
            _ccodusu = Value
        End Set
    End Property 
 
    Public Property dfecmod() As DateTime
        Get
            Return _dfecmod
        End Get
        Set(ByVal Value As DateTime)
            _dfecmod = Value
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
 
    Public Property cedad() As String
        Get
            Return _cedad
        End Get
        Set(ByVal Value As String)
            _cedad = Value
        End Set
    End Property 
 
#End Region
End Class
