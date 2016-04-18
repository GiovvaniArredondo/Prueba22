Public Class ctbdchq
    Inherits entidadBase
#Region " Privadas "
    Private _cnumrec As String

    Private _cnumcom As String
 
    Private _ccodbco As String
 
    Private _cctacte As String
 
    Private _cnrochq As String
 
    Private _cnomchq As String
 
    Private _cmonchq As Decimal
 
    Private _cflc As String
 
    Private _cnomcta As String
 
    Private _ccodhab As String
 
    Private _ccoddeb As String
 
    Private _dfeccnt2 As DateTime
 
    Private _lprint As Boolean

    Private _cmonlet As String

    Private _ccodsol As String

    Private _cnumdoc As String

    Private _ccodcta As String

    Private _ndebe As Decimal

    Private _nhaber As Decimal

    Private _dfeccnt As DateTime

    Private _ctipcta As String

    Private _ctipapl As String

    Private _cnomcli As String

    Private _cconcep As String

    Private _ccodofi As String

    Private _ffondos As String

 
#End Region
 
#Region " Propiedades "
    Public Property cnumrec() As String
        Get
            Return _cnumrec
        End Get
        Set(ByVal Value As String)
            _cnumrec = Value
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
 
    Public Property ccodbco() As String
        Get
            Return _ccodbco
        End Get
        Set(ByVal Value As String)
            _ccodbco = Value
        End Set
    End Property 
 
    Public Property cctacte() As String
        Get
            Return _cctacte
        End Get
        Set(ByVal Value As String)
            _cctacte = Value
        End Set
    End Property 
 
    Public Property cnrochq() As String
        Get
            Return _cnrochq
        End Get
        Set(ByVal Value As String)
            _cnrochq = Value
        End Set
    End Property 
 
    Public Property cnomchq() As String
        Get
            Return _cnomchq
        End Get
        Set(ByVal Value As String)
            _cnomchq = Value
        End Set
    End Property 
 
    Public Property cmonchq() As Decimal
        Get
            Return _cmonchq
        End Get
        Set(ByVal Value As Decimal)
            _cmonchq = Value
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
 
    Public Property cnomcta() As String
        Get
            Return _cnomcta
        End Get
        Set(ByVal Value As String)
            _cnomcta = Value
        End Set
    End Property 
 
    Public Property ccodhab() As String
        Get
            Return _ccodhab
        End Get
        Set(ByVal Value As String)
            _ccodhab = Value
        End Set
    End Property 
 
    Public Property ccoddeb() As String
        Get
            Return _ccoddeb
        End Get
        Set(ByVal Value As String)
            _ccoddeb = Value
        End Set
    End Property 
 
    Public Property dfeccnt2() As DateTime
        Get
            Return _dfeccnt2
        End Get
        Set(ByVal Value As DateTime)
            _dfeccnt2 = Value
        End Set
    End Property 
 
    Public Property lprint() As Boolean
        Get
            Return _lprint
        End Get
        Set(ByVal Value As Boolean)
            _lprint = Value
        End Set
    End Property

    Public Property cmonlet() As String
        Get
            Return _cmonlet
        End Get
        Set(ByVal Value As String)
            _cmonlet = Value
        End Set
    End Property

    Public Property ccodsol() As String
        Get
            Return _ccodsol
        End Get
        Set(ByVal Value As String)
            _ccodsol = Value
        End Set
    End Property

    Public Property cnumdoc() As String
        Get
            Return _cnumdoc
        End Get
        Set(ByVal Value As String)
            _cnumdoc = Value
        End Set
    End Property

    Public Property cCodcta() As String
        Get
            Return _ccodcta
        End Get
        Set(ByVal Value As String)
            _ccodcta = Value
        End Set
    End Property

    Public Property ndebe() As Decimal
        Get
            Return _ndebe
        End Get
        Set(ByVal Value As Decimal)
            _ndebe = Value
        End Set
    End Property

    Public Property nhaber() As Decimal
        Get
            Return _nhaber
        End Get
        Set(ByVal Value As Decimal)
            _nhaber = Value
        End Set
    End Property

    Public Property dfeccnt() As  DateTime
        Get
            Return _dfeccnt
        End Get
        Set(ByVal Value As DateTime)
            _dfeccnt = Value
        End Set
    End Property

    Public Property ctipcta() As String
        Get
            Return _ctipcta
        End Get
        Set(ByVal Value As String)
            _ctipcta = Value
        End Set
    End Property

    Public Property ctipapl() As String
        Get
            Return _ctipapl
        End Get
        Set(ByVal Value As String)
            _ctipapl = Value
        End Set
    End Property

    Public Property cnomcli() As String
        Get
            Return _cnomcli
        End Get
        Set(ByVal Value As String)
            _cnomcli = Value
        End Set
    End Property

    Public Property cconcep() As String
        Get
            Return _cconcep
        End Get
        Set(ByVal Value As String)
            _cconcep = Value
        End Set
    End Property

    Public Property ccodofi() As String
        Get
            Return _ccodofi
        End Get
        Set(ByVal Value As String)
            _ccodofi = Value
        End Set
    End Property

    Public Property ffondos() As String
        Get
            Return _ffondos
        End Get
        Set(ByVal Value As String)
            _ffondos = Value
        End Set
    End Property



#End Region
End Class
