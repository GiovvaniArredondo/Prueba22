Public Class diario
    Inherits entidadBase
#Region " Privadas "
    Private _cnumcom As String
 
    Private _ccodofi As String
 
    Private _ctipasi As String
 
    Private _ctipmon As String
 
    Private _cglosa As String
 
    Private _cnumdoc As String
 
    Private _ccodruc As String
 
    Private _ccodemp As String
 
    Private _dfecdoc As DateTime
 
    Private _dfeccnt As DateTime
 
    Private _dfecmod As DateTime
 
    Private _ccodusu As String
 
    Private _nccompra As Decimal
 
    Private _ncventa As Decimal
 
    Private _ntcfijo As Decimal
 
    Private _cfv As String
 
    Private _cestado As String
 
    Private _nfln As Decimal
 
    Private _cnrodoc As String
 
    Private _ffondos As String
 
    Private _ccodrev As String
 
    Private _ccodreg As String
 
#End Region
 
#Region " Propiedades "
    Public Property cnumcom() As String
        Get
            Return _cnumcom
        End Get
        Set(ByVal Value As String)
            _cnumcom = Value
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
 
    Public Property ctipasi() As String
        Get
            Return _ctipasi
        End Get
        Set(ByVal Value As String)
            _ctipasi = Value
        End Set
    End Property 
 
    Public Property ctipmon() As String
        Get
            Return _ctipmon
        End Get
        Set(ByVal Value As String)
            _ctipmon = Value
        End Set
    End Property 
 
    Public Property cglosa() As String
        Get
            Return _cglosa
        End Get
        Set(ByVal Value As String)
            _cglosa = Value
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
 
    Public Property ccodruc() As String
        Get
            Return _ccodruc
        End Get
        Set(ByVal Value As String)
            _ccodruc = Value
        End Set
    End Property 
 
    Public Property ccodemp() As String
        Get
            Return _ccodemp
        End Get
        Set(ByVal Value As String)
            _ccodemp = Value
        End Set
    End Property 
 
    Public Property dfecdoc() As DateTime
        Get
            Return _dfecdoc
        End Get
        Set(ByVal Value As DateTime)
            _dfecdoc = Value
        End Set
    End Property 
 
    Public Property dfeccnt() As DateTime
        Get
            Return _dfeccnt
        End Get
        Set(ByVal Value As DateTime)
            _dfeccnt = Value
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
 
    Public Property nccompra() As Decimal
        Get
            Return _nccompra
        End Get
        Set(ByVal Value As Decimal)
            _nccompra = Value
        End Set
    End Property 
 
    Public Property ncventa() As Decimal
        Get
            Return _ncventa
        End Get
        Set(ByVal Value As Decimal)
            _ncventa = Value
        End Set
    End Property 
 
    Public Property ntcfijo() As Decimal
        Get
            Return _ntcfijo
        End Get
        Set(ByVal Value As Decimal)
            _ntcfijo = Value
        End Set
    End Property 
 
    Public Property cfv() As String
        Get
            Return _cfv
        End Get
        Set(ByVal Value As String)
            _cfv = Value
        End Set
    End Property 
 
    Public Property cestado() As String
        Get
            Return _cestado
        End Get
        Set(ByVal Value As String)
            _cestado = Value
        End Set
    End Property 
 
    Public Property nfln() As Decimal
        Get
            Return _nfln
        End Get
        Set(ByVal Value As Decimal)
            _nfln = Value
        End Set
    End Property 
 
    Public Property cnrodoc() As String
        Get
            Return _cnrodoc
        End Get
        Set(ByVal Value As String)
            _cnrodoc = Value
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
 
    Public Property ccodrev() As String
        Get
            Return _ccodrev
        End Get
        Set(ByVal Value As String)
            _ccodrev = Value
        End Set
    End Property 
 
    Public Property ccodreg() As String
        Get
            Return _ccodreg
        End Get
        Set(ByVal Value As String)
            _ccodreg = Value
        End Set
    End Property 
 
#End Region
End Class
