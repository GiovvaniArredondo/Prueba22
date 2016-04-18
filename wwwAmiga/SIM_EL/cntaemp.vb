Public Class cntaemp
    Inherits entidadBase
#Region " Privadas "
    Private _ccodemp As String
 
    Private _cdescri As String
 
    Private _ccodruc As String
 
    Private _dfecreg As DateTime
 
    Private _dfecmod As DateTime
 
    Private _ccodusu As String
 
    Private _cflc As String
 
    Private _nflc As Decimal
 
    Private _nporiva As Decimal
 
    Private _nporisrs As Decimal
 
    Private _nporisrb As Decimal
 
#End Region
 
#Region " Propiedades "
    Public Property ccodemp() As String
        Get
            Return _ccodemp
        End Get
        Set(ByVal Value As String)
            _ccodemp = Value
        End Set
    End Property 
 
    Public Property cdescri() As String
        Get
            Return _cdescri
        End Get
        Set(ByVal Value As String)
            _cdescri = Value
        End Set
    End Property 
 
    Public Property ccodruc() As String
        Get
            Return _ccodruc
        End Get
        Set(ByVal Value As String)
            _ccodruc = Value
        End Set
    End Property 
 
    Public Property dfecreg() As DateTime
        Get
            Return _dfecreg
        End Get
        Set(ByVal Value As DateTime)
            _dfecreg = Value
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
 
    Public Property ccodusu() As String
        Get
            Return _ccodusu
        End Get
        Set(ByVal Value As String)
            _ccodusu = Value
        End Set
    End Property 
 
    Public Property cflc() As String
        Get
            Return _cflc
        End Get
        Set(ByVal Value As String)
            _cflc = Value
        End Set
    End Property 
 
    Public Property nflc() As Decimal
        Get
            Return _nflc
        End Get
        Set(ByVal Value As Decimal)
            _nflc = Value
        End Set
    End Property 
 
    Public Property nporiva() As Decimal
        Get
            Return _nporiva
        End Get
        Set(ByVal Value As Decimal)
            _nporiva = Value
        End Set
    End Property 
 
    Public Property nporisrs() As Decimal
        Get
            Return _nporisrs
        End Get
        Set(ByVal Value As Decimal)
            _nporisrs = Value
        End Set
    End Property 
 
    Public Property nporisrb() As Decimal
        Get
            Return _nporisrb
        End Get
        Set(ByVal Value As Decimal)
            _nporisrb = Value
        End Set
    End Property 
 
#End Region
End Class
