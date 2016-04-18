Public Class RepGraf
    Inherits entidadBase
#Region " Privadas "

    Private _ccodcta As String

    Private _cCodofi As String

    Private _ccodprd As String

    Private _cmoneda As String

    Private _cestado As String

    Private _ccodcli As String

    Private _ccatego As String

    Private _ccodfue As String

    Private _ccodact As String

    Private _ctipcre As String

    Private _cdescre As String

    Private _ctipcuo As String

    Private _ctipper As String

    Private _ntipperc As Decimal

    Private _cctapre As String

    Private _cnorref As String

    Private _ccodana As String

    Private _dfecasi As DateTime

    Private _dfecsol As DateTime

    Private _nmonsol As Decimal

    Private _nmonsug As Decimal

    Private _ncuosug As Decimal

    Private _ndessug As Decimal

    Private _ndiasug As Decimal

    Private _ndiagra As Decimal

    Private _dfecapr As DateTime

    Private _dfecven As DateTime

    Private _nmonapr As Decimal

    Private _nmoncuo As Decimal

    Private _nintapr As Decimal

    Private _ncuoapr As Decimal

    Private _ndiaapr As Decimal

    Private _ndesapr As Decimal

    Private _cnrolin As String

    Private _ntasint As Decimal

    Private _ctipcon As String

    Private _ccodapo As String

    Private _dfecvig As DateTime

    Private _ndeseje As Decimal

    Private _ngastos As Decimal

    Private _ncappag As Decimal

    Private _nintpen As Decimal

    Private _nintcal As Decimal

    Private _nintpag As Decimal

    Private _nintmor As Decimal

    Private _nmorpag As Decimal

    Private _npagcta As Decimal

    Private _ncapdes As Decimal

    Private _ncapcal As Decimal

    Private _ngaspag As Decimal

    Private _ndiaatr As Decimal

    Private _ndiaant As Decimal

    Private _natracu As Decimal

    Private _natrmax As Decimal

    Private _ccondic As String

    Private _dultpag As DateTime

    Private _dfecter As DateTime

    Private _ccodrec As String

    Private _nnota1 As Decimal

    Private _nnota2 As Decimal

    Private _cmarjud As String

    Private _ntipcam As Decimal

    Private _lctaret As Boolean

    Private _cclacre As String

    Private _ccalif As String

    Private _nsegvid As Decimal

    Private _cnumexp As String

    Private _ccodrub As String

    Private _cregist As String

    Private _dfecadm As DateTime

    Private _nintadm As Decimal

    Private _nmeses As Decimal

    Private _csececo As String

    Private _nciclo As Decimal

    Private _ccodsol As String

    Private _nmorak As Decimal

    Private _nahoprg As Decimal

    Private _cliquid As String

    Private _clineac As String

    Private _ncapoto As Decimal

    Private _ccontra As String

    Private _dfectra As DateTime

    Private _ccodusu As String

    Private _dfecmod As DateTime

    Private _cflag As String

    Private _cflat As String

    Private _nnumfal As Decimal

    Private _ctipgar As String

    Private _cnomcli As String

    Private _cnudoci As String

    Private _ccodlin As String

    Private _cNomUsu As String

    Private _nsalint As Decimal

    Private _nsalmor As Decimal

    Private _nsalcap As Decimal
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

    Public Property cCodofi() As String
        Get
            Return _cCodofi
        End Get
        Set(ByVal Value As String)
            _cCodofi = Value
        End Set
    End Property

    Public Property ccodprd() As String
        Get
            Return _ccodprd
        End Get
        Set(ByVal Value As String)
            _ccodprd = Value
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

    Public Property cestado() As String
        Get
            Return _cestado
        End Get
        Set(ByVal Value As String)
            _cestado = Value
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

    Public Property ccatego() As String
        Get
            Return _ccatego
        End Get
        Set(ByVal Value As String)
            _ccatego = Value
        End Set
    End Property

    Public Property ccodfue() As String
        Get
            Return _ccodfue
        End Get
        Set(ByVal Value As String)
            _ccodfue = Value
        End Set
    End Property

    Public Property ccodact() As String
        Get
            Return _ccodact
        End Get
        Set(ByVal Value As String)
            _ccodact = Value
        End Set
    End Property

    Public Property ctipcre() As String
        Get
            Return _ctipcre
        End Get
        Set(ByVal Value As String)
            _ctipcre = Value
        End Set
    End Property

    Public Property cdescre() As String
        Get
            Return _cdescre
        End Get
        Set(ByVal Value As String)
            _cdescre = Value
        End Set
    End Property

    Public Property ctipcuo() As String
        Get
            Return _ctipcuo
        End Get
        Set(ByVal Value As String)
            _ctipcuo = Value
        End Set
    End Property

    Public Property ctipper() As String
        Get
            Return _ctipper
        End Get
        Set(ByVal Value As String)
            _ctipper = Value
        End Set
    End Property

    Public Property ntipperc() As Decimal
        Get
            Return _ntipperc
        End Get
        Set(ByVal Value As Decimal)
            _ntipperc = Value
        End Set
    End Property

    Public Property cctapre() As String
        Get
            Return _cctapre
        End Get
        Set(ByVal Value As String)
            _cctapre = Value
        End Set
    End Property

    Public Property cnorref() As String
        Get
            Return _cnorref
        End Get
        Set(ByVal Value As String)
            _cnorref = Value
        End Set
    End Property

    Public Property ccodana() As String
        Get
            Return _ccodana
        End Get
        Set(ByVal Value As String)
            _ccodana = Value
        End Set
    End Property

    Public Property dfecasi() As DateTime
        Get
            Return _dfecasi
        End Get
        Set(ByVal Value As DateTime)
            _dfecasi = Value
        End Set
    End Property

    Public Property dfecsol() As DateTime
        Get
            Return _dfecsol
        End Get
        Set(ByVal Value As DateTime)
            _dfecsol = Value
        End Set
    End Property

    Public Property nmonsol() As Decimal
        Get
            Return _nmonsol
        End Get
        Set(ByVal Value As Decimal)
            _nmonsol = Value
        End Set
    End Property

    Public Property nmonsug() As Decimal
        Get
            Return _nmonsug
        End Get
        Set(ByVal Value As Decimal)
            _nmonsug = Value
        End Set
    End Property

    Public Property ncuosug() As Decimal
        Get
            Return _ncuosug
        End Get
        Set(ByVal Value As Decimal)
            _ncuosug = Value
        End Set
    End Property

    Public Property ndessug() As Decimal
        Get
            Return _ndessug
        End Get
        Set(ByVal Value As Decimal)
            _ndessug = Value
        End Set
    End Property

    Public Property ndiasug() As Decimal
        Get
            Return _ndiasug
        End Get
        Set(ByVal Value As Decimal)
            _ndiasug = Value
        End Set
    End Property

    Public Property ndiagra() As Decimal
        Get
            Return _ndiagra
        End Get
        Set(ByVal Value As Decimal)
            _ndiagra = Value
        End Set
    End Property

    Public Property dfecapr() As DateTime
        Get
            Return _dfecapr
        End Get
        Set(ByVal Value As DateTime)
            _dfecapr = Value
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

    Public Property nmonapr() As Decimal
        Get
            Return _nmonapr
        End Get
        Set(ByVal Value As Decimal)
            _nmonapr = Value
        End Set
    End Property

    Public Property nmoncuo() As Decimal
        Get
            Return _nmoncuo
        End Get
        Set(ByVal Value As Decimal)
            _nmoncuo = Value
        End Set
    End Property

    Public Property nintapr() As Decimal
        Get
            Return _nintapr
        End Get
        Set(ByVal Value As Decimal)
            _nintapr = Value
        End Set
    End Property

    Public Property ncuoapr() As Decimal
        Get
            Return _ncuoapr
        End Get
        Set(ByVal Value As Decimal)
            _ncuoapr = Value
        End Set
    End Property

    Public Property ndiaapr() As Decimal
        Get
            Return _ndiaapr
        End Get
        Set(ByVal Value As Decimal)
            _ndiaapr = Value
        End Set
    End Property

    Public Property ndesapr() As Decimal
        Get
            Return _ndesapr
        End Get
        Set(ByVal Value As Decimal)
            _ndesapr = Value
        End Set
    End Property

    Public Property cnrolin() As String
        Get
            Return _cnrolin
        End Get
        Set(ByVal Value As String)
            _cnrolin = Value
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

    Public Property ctipcon() As String
        Get
            Return _ctipcon
        End Get
        Set(ByVal Value As String)
            _ctipcon = Value
        End Set
    End Property

    Public Property ccodapo() As String
        Get
            Return _ccodapo
        End Get
        Set(ByVal Value As String)
            _ccodapo = Value
        End Set
    End Property

    Public Property dfecvig() As DateTime
        Get
            Return _dfecvig
        End Get
        Set(ByVal Value As DateTime)
            _dfecvig = Value
        End Set
    End Property

    Public Property ndeseje() As Decimal
        Get
            Return _ndeseje
        End Get
        Set(ByVal Value As Decimal)
            _ndeseje = Value
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

    Public Property ncappag() As Decimal
        Get
            Return _ncappag
        End Get
        Set(ByVal Value As Decimal)
            _ncappag = Value
        End Set
    End Property

    Public Property nintpen() As Decimal
        Get
            Return _nintpen
        End Get
        Set(ByVal Value As Decimal)
            _nintpen = Value
        End Set
    End Property

    Public Property nintcal() As Decimal
        Get
            Return _nintcal
        End Get
        Set(ByVal Value As Decimal)
            _nintcal = Value
        End Set
    End Property

    Public Property nintpag() As Decimal
        Get
            Return _nintpag
        End Get
        Set(ByVal Value As Decimal)
            _nintpag = Value
        End Set
    End Property

    Public Property nintmor() As Decimal
        Get
            Return _nintmor
        End Get
        Set(ByVal Value As Decimal)
            _nintmor = Value
        End Set
    End Property

    Public Property nmorpag() As Decimal
        Get
            Return _nmorpag
        End Get
        Set(ByVal Value As Decimal)
            _nmorpag = Value
        End Set
    End Property

    Public Property npagcta() As Decimal
        Get
            Return _npagcta
        End Get
        Set(ByVal Value As Decimal)
            _npagcta = Value
        End Set
    End Property

    Public Property ncapdes() As Decimal
        Get
            Return _ncapdes
        End Get
        Set(ByVal Value As Decimal)
            _ncapdes = Value
        End Set
    End Property

    Public Property ncapcal() As Decimal
        Get
            Return _ncapcal
        End Get
        Set(ByVal Value As Decimal)
            _ncapcal = Value
        End Set
    End Property

    Public Property ngaspag() As Decimal
        Get
            Return _ngaspag
        End Get
        Set(ByVal Value As Decimal)
            _ngaspag = Value
        End Set
    End Property

    Public Property ndiaatr() As Decimal
        Get
            Return _ndiaatr
        End Get
        Set(ByVal Value As Decimal)
            _ndiaatr = Value
        End Set
    End Property

    Public Property ndiaant() As Decimal
        Get
            Return _ndiaant
        End Get
        Set(ByVal Value As Decimal)
            _ndiaant = Value
        End Set
    End Property

    Public Property natracu() As Decimal
        Get
            Return _natracu
        End Get
        Set(ByVal Value As Decimal)
            _natracu = Value
        End Set
    End Property

    Public Property natrmax() As Decimal
        Get
            Return _natrmax
        End Get
        Set(ByVal Value As Decimal)
            _natrmax = Value
        End Set
    End Property

    Public Property ccondic() As String
        Get
            Return _ccondic
        End Get
        Set(ByVal Value As String)
            _ccondic = Value
        End Set
    End Property

    Public Property dultpag() As DateTime
        Get
            Return _dultpag
        End Get
        Set(ByVal Value As DateTime)
            _dultpag = Value
        End Set
    End Property

    Public Property dfecter() As DateTime
        Get
            Return _dfecter
        End Get
        Set(ByVal Value As DateTime)
            _dfecter = Value
        End Set
    End Property

    Public Property ccodrec() As String
        Get
            Return _ccodrec
        End Get
        Set(ByVal Value As String)
            _ccodrec = Value
        End Set
    End Property

    Public Property nnota1() As Decimal
        Get
            Return _nnota1
        End Get
        Set(ByVal Value As Decimal)
            _nnota1 = Value
        End Set
    End Property

    Public Property nnota2() As Decimal
        Get
            Return _nnota2
        End Get
        Set(ByVal Value As Decimal)
            _nnota2 = Value
        End Set
    End Property

    Public Property cmarjud() As String
        Get
            Return _cmarjud
        End Get
        Set(ByVal Value As String)
            _cmarjud = Value
        End Set
    End Property

    Public Property ntipcam() As Decimal
        Get
            Return _ntipcam
        End Get
        Set(ByVal Value As Decimal)
            _ntipcam = Value
        End Set
    End Property

    Public Property lctaret() As Boolean
        Get
            Return _lctaret
        End Get
        Set(ByVal Value As Boolean)
            _lctaret = Value
        End Set
    End Property

    Public Property cclacre() As String
        Get
            Return _cclacre
        End Get
        Set(ByVal Value As String)
            _cclacre = Value
        End Set
    End Property

    Public Property ccalif() As String
        Get
            Return _ccalif
        End Get
        Set(ByVal Value As String)
            _ccalif = Value
        End Set
    End Property

    Public Property nsegvid() As Decimal
        Get
            Return _nsegvid
        End Get
        Set(ByVal Value As Decimal)
            _nsegvid = Value
        End Set
    End Property

    Public Property cnumexp() As String
        Get
            Return _cnumexp
        End Get
        Set(ByVal Value As String)
            _cnumexp = Value
        End Set
    End Property

    Public Property ccodrub() As String
        Get
            Return _ccodrub
        End Get
        Set(ByVal Value As String)
            _ccodrub = Value
        End Set
    End Property

    Public Property cregist() As String
        Get
            Return _cregist
        End Get
        Set(ByVal Value As String)
            _cregist = Value
        End Set
    End Property

    Public Property dfecadm() As DateTime
        Get
            Return _dfecadm
        End Get
        Set(ByVal Value As DateTime)
            _dfecadm = Value
        End Set
    End Property

    Public Property nintadm() As Decimal
        Get
            Return _nintadm
        End Get
        Set(ByVal Value As Decimal)
            _nintadm = Value
        End Set
    End Property

    Public Property nmeses() As Decimal
        Get
            Return _nmeses
        End Get
        Set(ByVal Value As Decimal)
            _nmeses = Value
        End Set
    End Property

    Public Property csececo() As String
        Get
            Return _csececo
        End Get
        Set(ByVal Value As String)
            _csececo = Value
        End Set
    End Property

    Public Property nciclo() As Decimal
        Get
            Return _nciclo
        End Get
        Set(ByVal Value As Decimal)
            _nciclo = Value
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

    Public Property nmorak() As Decimal
        Get
            Return _nmorak
        End Get
        Set(ByVal Value As Decimal)
            _nmorak = Value
        End Set
    End Property

    Public Property nahoprg() As Decimal
        Get
            Return _nahoprg
        End Get
        Set(ByVal Value As Decimal)
            _nahoprg = Value
        End Set
    End Property

    Public Property cliquid() As String
        Get
            Return _cliquid
        End Get
        Set(ByVal Value As String)
            _cliquid = Value
        End Set
    End Property

    Public Property clineac() As String
        Get
            Return _clineac
        End Get
        Set(ByVal Value As String)
            _clineac = Value
        End Set
    End Property

    Public Property ncapoto() As Decimal
        Get
            Return _ncapoto
        End Get
        Set(ByVal Value As Decimal)
            _ncapoto = Value
        End Set
    End Property

    Public Property ccontra() As String
        Get
            Return _ccontra
        End Get
        Set(ByVal Value As String)
            _ccontra = Value
        End Set
    End Property

    Public Property dfectra() As DateTime
        Get
            Return _dfectra
        End Get
        Set(ByVal Value As DateTime)
            _dfectra = Value
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

    Public Property cflat() As String
        Get
            Return _cflat
        End Get
        Set(ByVal Value As String)
            _cflat = Value
        End Set
    End Property

    Public Property nnumfal() As Decimal
        Get
            Return _nnumfal
        End Get
        Set(ByVal Value As Decimal)
            _nnumfal = Value
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

    Public Property cnomcli() As String
        Get
            Return _cnomcli
        End Get
        Set(ByVal Value As String)
            _cnomcli = Value
        End Set
    End Property

    Public Property cnudoci() As String
        Get
            Return _cnudoci
        End Get
        Set(ByVal Value As String)
            _cnudoci = Value
        End Set
    End Property

    Public Property ccodlin() As String
        Get
            Return _ccodlin
        End Get
        Set(ByVal Value As String)
            _ccodlin = Value
        End Set
    End Property

    Public Property cNomUsu() As String
        Get
            Return _cNomUsu
        End Get
        Set(ByVal Value As String)
            _cNomUsu = Value
        End Set
    End Property


    Public Property nsalcap() As Decimal
        Get
            Return _nsalcap
        End Get
        Set(ByVal Value As Decimal)
            _nsalcap = Value
        End Set
    End Property

    Public Property nsalint() As Decimal
        Get
            Return _nsalint
        End Get
        Set(ByVal Value As Decimal)
            _nsalint = Value
        End Set
    End Property


    Public Property nsalmor() As Decimal
        Get
            Return _nsalmor
        End Get
        Set(ByVal Value As Decimal)
            _nsalmor = Value
        End Set
    End Property

#End Region
End Class
