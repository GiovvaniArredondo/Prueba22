Public Class cntamov
    Inherits entidadBase
#Region " Privadas "
    Private _ccodsec As String
 
    Private _ffondos As String
 
    Private _cnumcom As String
 
    Private _cnumlin As Decimal
 
    Private _ccodcta As String
 
    Private _cclase As String
 
    Private _ndebe As Decimal
 
    Private _nhaber As Decimal
 
    Private _cflc As String
 
    Private _nfln As Decimal
 
    Private _cnumdoc As String

    Private _cnumrec As String
 
    Private _dfeccnt As DateTime
 
    Private _ccodpres As String
 
    Private _cconcepto As String
 
    Private _cpoliza As String
 
    Private _ccodofi As String
 
    Private _cnumpol As String
 
    Private _ccodreg As String
 
    Private _dfecmod As DateTime
 
    Private _ccodusu1 As String
 
    Private _ccodcli As String

    Private _corden As String
    'auxcaja
    Private _cnit As String
    Public Property cnit() As String
        Get
            Return _cnit
        End Get
        Set(ByVal value As String)
            _cnit = value
        End Set
    End Property

    Private _cproveedor As String
    Public Property cproveedor() As String
        Get
            Return _cproveedor
        End Get
        Set(ByVal value As String)
            _cproveedor = value
        End Set
    End Property

    Private _cdescri As String
    Public Property cdescri() As String
        Get
            Return _cdescri
        End Get
        Set(ByVal value As String)
            _cdescri = value
        End Set
    End Property

    Private _dfecha As Date
    Public Property dfecha() As Date
        Get
            Return _dfecha
        End Get
        Set(ByVal value As Date)
            _dfecha = value
        End Set
    End Property

    Private _ctipo As String
    Public Property ctipo() As String
        Get
            Return _ctipo
        End Get
        Set(ByVal value As String)
            _ctipo = value
        End Set
    End Property

    Private _cfactura As String
    Public Property cfactura() As String
        Get
            Return _cfactura
        End Get
        Set(ByVal value As String)
            _cfactura = value
        End Set
    End Property

    'Private _ndebe As Double
    Private _nsaldo As Double
    Public Property nsaldo() As Double
        Get
            Return _nsaldo
        End Get
        Set(ByVal value As Double)
            _nsaldo = value
        End Set
    End Property

    Private _cflag As String
    Public Property cflag() As String
        Get
            Return _cflag
        End Get
        Set(ByVal value As String)
            _cflag = value
        End Set
    End Property

    Private _ccodant As String
    Public Property ccodant() As String
        Get
            Return _ccodant
        End Get
        Set(ByVal value As String)
            _ccodant = value
        End Set
    End Property

    Private _laplcon As Boolean
    Public Property laplcon() As Boolean
        Get
            Return _laplcon
        End Get
        Set(ByVal value As Boolean)
            _laplcon = value
        End Set
    End Property

    Private _cctabco As String
    Public Property cctabco() As String
        Get
            Return _cctabco
        End Get
        Set(ByVal value As String)
            _cctabco = value
        End Set
    End Property

    'Private _ccodofi As String
    Private _ccodins As String
    Public Property ccodins() As String
        Get
            Return _ccodins
        End Get
        Set(ByVal value As String)
            _ccodins = value
        End Set
    End Property

    Private _ccodenc As String
    Public Property ccodenc() As String
        Get
            Return _ccodenc
        End Get
        Set(ByVal value As String)
            _ccodenc = value
        End Set
    End Property

    Private _nmonfac As Double
    Public Property nmonfac() As Double
        Get
            Return _nmonfac
        End Get
        Set(ByVal value As Double)
            _nmonfac = value
        End Set
    End Property

    Private _niva As Double
    Public Property niva() As Double
        Get
            Return _niva
        End Get
        Set(ByVal value As Double)
            _cestado = value
        End Set
    End Property

    Private _nisr As Double
    Public Property nisr() As Double
        Get
            Return _nisr
        End Get
        Set(ByVal value As Double)
            _nisr = value
        End Set
    End Property

    'Private _cnumcom As String
    Private _cfuente As String
    Public Property cfuente() As String
        Get
            Return _cfuente
        End Get
        Set(ByVal value As String)
            _cfuente = value
        End Set
    End Property

    'Private _dfecmod As Date
    Private _ccodbco As String
    Public Property ccodbco() As String
        Get
            Return _ccodbco
        End Get
        Set(ByVal value As String)
            _ccodbco = value
        End Set
    End Property

    Private _cestado As String
    Public Property cestado() As String
        Get
            Return _cestado
        End Get
        Set(ByVal value As String)
            _cestado = value
        End Set
    End Property

    Private _ctipope As String
    Public Property ctipope() As String
        Get
            Return _ctipope
        End Get
        Set(ByVal value As String)
            _ctipope = value
        End Set
    End Property

    Private _ccodres As String
    Public Property ccodres() As String
        Get
            Return _ccodres
        End Get
        Set(ByVal value As String)
            _ccodres = value
        End Set
    End Property

    Private _cauxcta As Decimal
    Public Property cauxcta() As Decimal
        Get
            Return _cauxcta
        End Get
        Set(ByVal value As Decimal)
            _cauxcta = value
        End Set
    End Property
#End Region
 
#Region " Propiedades "
    Public Property corden() As String
        Get
            Return _corden
        End Get
        Set(ByVal Value As String)
            _corden = Value
        End Set
    End Property

    Public Property ccodsec() As String
        Get
            Return _ccodsec
        End Get
        Set(ByVal Value As String)
            _ccodsec = Value
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

    Public Property cnumcom() As String
        Get
            Return _cnumcom
        End Get
        Set(ByVal Value As String)
            _cnumcom = Value
        End Set
    End Property

    Public Property cnumlin() As Decimal
        Get
            Return _cnumlin
        End Get
        Set(ByVal Value As Decimal)
            _cnumlin = Value
        End Set
    End Property

    Public Property ccodcta() As String
        Get
            Return _ccodcta
        End Get
        Set(ByVal Value As String)
            _ccodcta = Value
        End Set
    End Property

    Public Property cclase() As String
        Get
            Return _cclase
        End Get
        Set(ByVal Value As String)
            _cclase = Value
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

    Public Property cflc() As String
        Get
            Return _cflc
        End Get
        Set(ByVal Value As String)
            _cflc = Value
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

    Public Property cnumdoc() As String
        Get
            Return _cnumdoc
        End Get
        Set(ByVal Value As String)
            _cnumdoc = Value
        End Set
    End Property

    Public Property cnumrec() As String
        Get
            Return _cnumrec
        End Get
        Set(ByVal Value As String)
            _cnumrec = Value
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

    Public Property ccodpres() As String
        Get
            Return _ccodpres
        End Get
        Set(ByVal Value As String)
            _ccodpres = Value
        End Set
    End Property

    Public Property cconcepto() As String
        Get
            Return _cconcepto
        End Get
        Set(ByVal Value As String)
            _cconcepto = Value
        End Set
    End Property

    Public Property cpoliza() As String
        Get
            Return _cpoliza
        End Get
        Set(ByVal Value As String)
            _cpoliza = Value
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

    Public Property cnumpol() As String
        Get
            Return _cnumpol
        End Get
        Set(ByVal Value As String)
            _cnumpol = Value
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

    Public Property dfecmod() As DateTime
        Get
            Return _dfecmod
        End Get
        Set(ByVal Value As DateTime)
            _dfecmod = Value
        End Set
    End Property

    Public Property ccodusu1() As String
        Get
            Return _ccodusu1
        End Get
        Set(ByVal Value As String)
            _ccodusu1 = Value
        End Set
    End Property

    Public Property ccodcli() As String
        Get
            Return _ccodcli
        End Get
        Set(ByVal Value As String)
            _ccodcli = Value
        End Set
    End Property

#End Region
End Class
