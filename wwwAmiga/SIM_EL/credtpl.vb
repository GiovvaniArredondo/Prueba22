Public Class credtpl
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcta As String
 
    Private _dfecven As DateTime
 
    Private _lefectu As Boolean
 
    Private _ctipope As String
 
    Private _cnrocuo As String
 
    Private _ncapita As Decimal
 
    Private _nintere As Decimal

    Private _ngastos As Decimal
 
    Private _ntasint As Decimal
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String

    Private _nsegdeu As Decimal

    Private _nsegdan As Decimal

    Private _nresinc As Decimal

    Private _ntalona As Decimal

    Private _notrpag As Decimal
 
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
 
    Public Property dfecven() As DateTime
        Get
            Return _dfecven
        End Get
        Set(ByVal Value As DateTime)
            _dfecven = Value
        End Set
    End Property 
 
    Public Property lefectu() As Boolean
        Get
            Return _lefectu
        End Get
        Set(ByVal Value As Boolean)
            _lefectu = Value
        End Set
    End Property 
 
    Public Property ctipope() As String
        Get
            Return _ctipope
        End Get
        Set(ByVal Value As String)
            _ctipope = Value
        End Set
    End Property 
 
    Public Property cnrocuo() As String
        Get
            Return _cnrocuo
        End Get
        Set(ByVal Value As String)
            _cnrocuo = Value
        End Set
    End Property 
 
    Public Property ncapita() As Decimal
        Get
            Return _ncapita
        End Get
        Set(ByVal Value As Decimal)
            _ncapita = Value
        End Set
    End Property 
 
    Public Property nintere() As Decimal
        Get
            Return _nintere
        End Get
        Set(ByVal Value As Decimal)
            _nintere = Value
        End Set
    End Property 
    Public Property ngastos() As Decimal
        Get
            Return _ngastos
        End Get
        Set(ByVal Value As Decimal)
            _ngastos = Value
        End Set
    End Property
    Public Property ntasint() As Decimal
        Get
            Return _ntasint
        End Get
        Set(ByVal Value As Decimal)
            _ntasint = Value
        End Set
    End Property

    Public Property nsegdeu() As Decimal
        Get
            Return _nsegdeu
        End Get
        Set(ByVal Value As Decimal)
            _nsegdeu = Value
        End Set
    End Property

    Public Property nsegdan() As Decimal
        Get
            Return _nsegdan
        End Get
        Set(ByVal Value As Decimal)
            _nsegdan = Value
        End Set
    End Property

    Public Property nresinc() As Decimal
        Get
            Return _nresinc
        End Get
        Set(ByVal Value As Decimal)
            _nresinc = Value
        End Set
    End Property
    Public Property ntalona() As Decimal
        Get
            Return _ntalona
        End Get
        Set(ByVal Value As Decimal)
            _ntalona = Value
        End Set
    End Property

    Public Property notrpag() As Decimal
        Get
            Return _notrpag
        End Get
        Set(ByVal Value As Decimal)
            _notrpag = Value
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

#End Region
End Class
