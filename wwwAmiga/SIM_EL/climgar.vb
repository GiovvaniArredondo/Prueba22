Public Class climgar
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcli As String
 
    Private _ccodgar As String
 
    Private _cestado As String
 
    Private _destado As DateTime
 
    Private _ctipdes As String
 
    Private _ccoduni As String
 
    Private _ctipgar As String
 
    Private _cdescri As String
 
    Private _ccodzon As String
 
    Private _cmoneda As String
 
    Private _nmongar As Decimal
 
    Private _nmontas As Decimal
 
    Private _nmongra As Decimal
 
    Private _csitgar As String
 
    Private _dfecrev As DateTime
 
    Private _ccoddep As String
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String
 
    Private _cdirec As String

    Private _dpresent As DateTime
    Private _dinscrip As DateTime
    Private _cnumins As String
    Private _cnumpres As String
    Private _cobser As String

    Private _dfecval As DateTime
    Private _cubica As String

    Private _cnotario As String
    Private _nnumeropr As String
    Private _dfechaes As Date
    Private _clugares As String

    Private _cpropietario As String

    Private _cprofinca As String

    Private _cprofolio As String

    Private _cprolibro As String

    Private _cprode As String

    Private _dprofecha As DateTime

    Private _cmunfinca As String

    Private _cmunfolio As String

    Private _cmunlibro As String

    Private _cmunde As String

    Private _dmunfecha As DateTime

    Private _cdireccion As String

    Private _ctopo As String

    Private _cespdir As String

    Private _cuso As String

    Private _cespuso As String

    Private _clocalidad As String

    Private _nniveles As Int32

    Private _cacceso As String

    Private _cservicios As String

    Private _cespser As String

    Private _cambientes As String

    Private _cespamb As String

    Private _ctecho As String

    Private _cesptecho As String

    Private _cpiso As String

    Private _cesppiso As String

    Private _cparedes As String

    Private _cesppared As String

    Private _nnmedida As Decimal

    Private _nncolin As String

    Private _nsmedida As Decimal

    Private _nscolin As String

    Private _nemedida As Decimal

    Private _necolin As String

    Private _nomedida As Decimal

    Private _nocolin As String

    Private _nlongitud As Decimal

    Private _nlatitud As Decimal

    Public Property cnotario() As String
        Get
            Return _cnotario
        End Get
        Set(ByVal value As String)
            _cnotario = value
        End Set
    End Property
    Public Property nnumeropr() As String
        Get
            Return _nnumeropr
        End Get
        Set(ByVal value As String)
            _nnumeropr = value
        End Set
    End Property
    Public Property dfechaes() As Date
        Get
            Return _dfechaes
        End Get
        Set(ByVal value As Date)
            _dfechaes = value
        End Set
    End Property
    Public Property clugares() As String
        Get
            Return _clugares
        End Get
        Set(ByVal value As String)
            _clugares = value
        End Set
    End Property
#End Region
    Public Property cpropietario() As String
        Get
            Return _cpropietario
        End Get
        Set(ByVal Value As String)
            _cpropietario = Value
        End Set
    End Property

    Public Property cprofinca() As String
        Get
            Return _cprofinca
        End Get
        Set(ByVal Value As String)
            _cprofinca = Value
        End Set
    End Property

    Public Property cprofolio() As String
        Get
            Return _cprofolio
        End Get
        Set(ByVal Value As String)
            _cprofolio = Value
        End Set
    End Property

    Public Property cprolibro() As String
        Get
            Return _cprolibro
        End Get
        Set(ByVal Value As String)
            _cprolibro = Value
        End Set
    End Property

    Public Property cprode() As String
        Get
            Return _cprode
        End Get
        Set(ByVal Value As String)
            _cprode = Value
        End Set
    End Property

    Public Property dprofecha() As DateTime
        Get
            Return _dprofecha
        End Get
        Set(ByVal Value As DateTime)
            _dprofecha = Value
        End Set
    End Property

    Public Property cmunfinca() As String
        Get
            Return _cmunfinca
        End Get
        Set(ByVal Value As String)
            _cmunfinca = Value
        End Set
    End Property

    Public Property cmunfolio() As String
        Get
            Return _cmunfolio
        End Get
        Set(ByVal Value As String)
            _cmunfolio = Value
        End Set
    End Property

    Public Property cmunlibro() As String
        Get
            Return _cmunlibro
        End Get
        Set(ByVal Value As String)
            _cmunlibro = Value
        End Set
    End Property

    Public Property cmunde() As String
        Get
            Return _cmunde
        End Get
        Set(ByVal Value As String)
            _cmunde = Value
        End Set
    End Property

    Public Property dmunfecha() As DateTime
        Get
            Return _dmunfecha
        End Get
        Set(ByVal Value As DateTime)
            _dmunfecha = Value
        End Set
    End Property

    Public Property cdireccion() As String
        Get
            Return _cdireccion
        End Get
        Set(ByVal Value As String)
            _cdireccion = Value
        End Set
    End Property

    Public Property ctopo() As String
        Get
            Return _ctopo
        End Get
        Set(ByVal Value As String)
            _ctopo = Value
        End Set
    End Property

    Public Property cespdir() As String
        Get
            Return _cespdir
        End Get
        Set(ByVal Value As String)
            _cespdir = Value
        End Set
    End Property

    Public Property cuso() As String
        Get
            Return _cuso
        End Get
        Set(ByVal Value As String)
            _cuso = Value
        End Set
    End Property

    Public Property cespuso() As String
        Get
            Return _cespuso
        End Get
        Set(ByVal Value As String)
            _cespuso = Value
        End Set
    End Property

    Public Property clocalidad() As String
        Get
            Return _clocalidad
        End Get
        Set(ByVal Value As String)
            _clocalidad = Value
        End Set
    End Property

    Public Property nniveles() As Int32
        Get
            Return _nniveles
        End Get
        Set(ByVal Value As Int32)
            _nniveles = Value
        End Set
    End Property

    Public Property cacceso() As String
        Get
            Return _cacceso
        End Get
        Set(ByVal Value As String)
            _cacceso = Value
        End Set
    End Property

    Public Property cservicios() As String
        Get
            Return _cservicios
        End Get
        Set(ByVal Value As String)
            _cservicios = Value
        End Set
    End Property

    Public Property cespser() As String
        Get
            Return _cespser
        End Get
        Set(ByVal Value As String)
            _cespser = Value
        End Set
    End Property

    Public Property cambientes() As String
        Get
            Return _cambientes
        End Get
        Set(ByVal Value As String)
            _cambientes = Value
        End Set
    End Property

    Public Property cespamb() As String
        Get
            Return _cespamb
        End Get
        Set(ByVal Value As String)
            _cespamb = Value
        End Set
    End Property

    Public Property ctecho() As String
        Get
            Return _ctecho
        End Get
        Set(ByVal Value As String)
            _ctecho = Value
        End Set
    End Property

    Public Property cesptecho() As String
        Get
            Return _cesptecho
        End Get
        Set(ByVal Value As String)
            _cesptecho = Value
        End Set
    End Property

    Public Property cpiso() As String
        Get
            Return _cpiso
        End Get
        Set(ByVal Value As String)
            _cpiso = Value
        End Set
    End Property

    Public Property cesppiso() As String
        Get
            Return _cesppiso
        End Get
        Set(ByVal Value As String)
            _cesppiso = Value
        End Set
    End Property

    Public Property cparedes() As String
        Get
            Return _cparedes
        End Get
        Set(ByVal Value As String)
            _cparedes = Value
        End Set
    End Property

    Public Property cesppared() As String
        Get
            Return _cesppared
        End Get
        Set(ByVal Value As String)
            _cesppared = Value
        End Set
    End Property

    Public Property nnmedida() As Decimal
        Get
            Return _nnmedida
        End Get
        Set(ByVal Value As Decimal)
            _nnmedida = Value
        End Set
    End Property

    Public Property nncolin() As String
        Get
            Return _nncolin
        End Get
        Set(ByVal Value As String)
            _nncolin = Value
        End Set
    End Property

    Public Property nsmedida() As Decimal
        Get
            Return _nsmedida
        End Get
        Set(ByVal Value As Decimal)
            _nsmedida = Value
        End Set
    End Property

    Public Property nscolin() As String
        Get
            Return _nscolin
        End Get
        Set(ByVal Value As String)
            _nscolin = Value
        End Set
    End Property

    Public Property nemedida() As Decimal
        Get
            Return _nemedida
        End Get
        Set(ByVal Value As Decimal)
            _nemedida = Value
        End Set
    End Property

    Public Property necolin() As String
        Get
            Return _necolin
        End Get
        Set(ByVal Value As String)
            _necolin = Value
        End Set
    End Property

    Public Property nomedida() As Decimal
        Get
            Return _nomedida
        End Get
        Set(ByVal Value As Decimal)
            _nomedida = Value
        End Set
    End Property

    Public Property nocolin() As String
        Get
            Return _nocolin
        End Get
        Set(ByVal Value As String)
            _nocolin = Value
        End Set
    End Property

    Public Property nlongitud() As Decimal
        Get
            Return _nlongitud
        End Get
        Set(ByVal Value As Decimal)
            _nlongitud = Value
        End Set
    End Property

    Public Property nlatitud() As Decimal
        Get
            Return _nlatitud
        End Get
        Set(ByVal Value As Decimal)
            _nlatitud = Value
        End Set
    End Property

#Region " Propiedades "
    Public Property ccodcli() As String
        Get
            Return _ccodcli
        End Get
        Set(ByVal Value As String)
            _ccodcli = Value
        End Set
    End Property 
 
    Public Property ccodgar() As String
        Get
            Return _ccodgar
        End Get
        Set(ByVal Value As String)
            _ccodgar = Value
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
 
    Public Property destado() As DateTime
        Get
            Return _destado
        End Get
        Set(ByVal Value As DateTime)
            _destado = Value
        End Set
    End Property 
 
    Public Property ctipdes() As String
        Get
            Return _ctipdes
        End Get
        Set(ByVal Value As String)
            _ctipdes = Value
        End Set
    End Property 
 
    Public Property ccoduni() As String
        Get
            Return _ccoduni
        End Get
        Set(ByVal Value As String)
            _ccoduni = Value
        End Set
    End Property 
 
    Public Property ctipgar() As String
        Get
            Return _ctipgar
        End Get
        Set(ByVal Value As String)
            _ctipgar = Value
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
 
    Public Property ccodzon() As String
        Get
            Return _ccodzon
        End Get
        Set(ByVal Value As String)
            _ccodzon = Value
        End Set
    End Property 
 
    Public Property cmoneda() As String
        Get
            Return _cmoneda
        End Get
        Set(ByVal Value As String)
            _cmoneda = Value
        End Set
    End Property 
 
    Public Property nmongar() As Decimal
        Get
            Return _nmongar
        End Get
        Set(ByVal Value As Decimal)
            _nmongar = Value
        End Set
    End Property 
 
    Public Property nmontas() As Decimal
        Get
            Return _nmontas
        End Get
        Set(ByVal Value As Decimal)
            _nmontas = Value
        End Set
    End Property 
 
    Public Property nmongra() As Decimal
        Get
            Return _nmongra
        End Get
        Set(ByVal Value As Decimal)
            _nmongra = Value
        End Set
    End Property 
 
    Public Property csitgar() As String
        Get
            Return _csitgar
        End Get
        Set(ByVal Value As String)
            _csitgar = Value
        End Set
    End Property 
 
    Public Property dfecrev() As DateTime
        Get
            Return _dfecrev
        End Get
        Set(ByVal Value As DateTime)
            _dfecrev = Value
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
 
    Public Property cdirec() As String
        Get
            Return _cdirec
        End Get
        Set(ByVal Value As String)
            _cdirec = Value
        End Set
    End Property 
    Public Property dpresent() As DateTime
        Get
            Return _dpresent
        End Get
        Set(ByVal Value As DateTime)
            _dpresent = Value
        End Set
    End Property
    Public Property dinscrip() As DateTime
        Get
            Return _dinscrip
        End Get
        Set(ByVal Value As DateTime)
            _dinscrip = Value
        End Set
    End Property
    Public Property cnumins() As String
        Get
            Return _cnumins
        End Get
        Set(ByVal Value As String)
            _cnumins = Value
        End Set
    End Property
    Public Property cnumpres() As String
        Get
            Return _cnumpres
        End Get
        Set(ByVal Value As String)
            _cnumpres = Value
        End Set
    End Property
    Public Property cobser() As String
        Get
            Return _cobser
        End Get
        Set(ByVal Value As String)
            _cobser = Value
        End Set
    End Property

    Public Property dfecval() As DateTime
        Get
            Return _dfecval
        End Get
        Set(ByVal Value As DateTime)
            _dfecval = Value
        End Set
    End Property

    Public Property cubica() As String
        Get
            Return _cubica
        End Get
        Set(ByVal Value As String)
            _cubica = Value
        End Set
    End Property
#End Region
End Class
