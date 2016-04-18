Public Class cremsol
    Inherits entidadBase
#Region " Privadas "
    Private _cCodsol As String
 
    Private _cnomgru As String
 
    Private _dfecha As DateTime
 
    Private _ccoddep As String
 
    Private _ccodmun As String
 
    Private _ccodcan As String
 
    Private _cdirdom As String
 
    Private _cdiareu As String
 
    Private _chora As String
 
    Private _ccodofi As String
 
    Private _ccodins As String
 
    Private _dfecmod As DateTime

    Private _cfrecreu As String

    Private _lactivo As Boolean

    Private _ccodzon As String

    Private _ccodcen As String

    Private _ccodcli As String
#End Region
 
#Region " Propiedades "
    Public Property cCodsol() As String
        Get
            Return _cCodsol
        End Get
        Set(ByVal Value As String)
            _cCodsol = Value
        End Set
    End Property 
 
    Public Property cnomgru() As String
        Get
            Return _cnomgru
        End Get
        Set(ByVal Value As String)
            _cnomgru = Value
        End Set
    End Property 
 
    Public Property dfecha() As DateTime
        Get
            Return _dfecha
        End Get
        Set(ByVal Value As DateTime)
            _dfecha = Value
        End Set
    End Property 
 
    Public Property ccoddep() As String
        Get
            Return _ccoddep
        End Get
        Set(ByVal Value As String)
            _ccoddep = Value
        End Set
    End Property 
 
    Public Property ccodmun() As String
        Get
            Return _ccodmun
        End Get
        Set(ByVal Value As String)
            _ccodmun = Value
        End Set
    End Property 
 
    Public Property ccodcan() As String
        Get
            Return _ccodcan
        End Get
        Set(ByVal Value As String)
            _ccodcan = Value
        End Set
    End Property 
 
    Public Property cdirdom() As String
        Get
            Return _cdirdom
        End Get
        Set(ByVal Value As String)
            _cdirdom = Value
        End Set
    End Property 
 
    Public Property cdiareu() As String
        Get
            Return _cdiareu
        End Get
        Set(ByVal Value As String)
            _cdiareu = Value
        End Set
    End Property 
 
    Public Property chora() As String
        Get
            Return _chora
        End Get
        Set(ByVal Value As String)
            _chora = Value
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
 
    Public Property ccodins() As String
        Get
            Return _ccodins
        End Get
        Set(ByVal Value As String)
            _ccodins = Value
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

    Public Property cfrecreu() As String
        Get
            Return _cfrecreu
        End Get
        Set(ByVal Value As String)
            _cfrecreu = Value
        End Set
    End Property

    Public Property lactivo() As Boolean
        Get
            Return _lactivo
        End Get
        Set(ByVal Value As Boolean)
            _lactivo = Value
        End Set
    End Property

    Public Property cCodzon() As String
        Get
            Return _ccodzon
        End Get
        Set(ByVal Value As String)
            _ccodzon = Value
        End Set
    End Property

    Public Property cCodcli() As String
        Get
            Return _ccodcli
        End Get
        Set(ByVal Value As String)
            _ccodcli = Value
        End Set
    End Property

    Public Property cCodcen() As String
        Get
            Return _ccodcen
        End Get
        Set(ByVal Value As String)
            _ccodcen = Value
        End Set
    End Property
#End Region
End Class
