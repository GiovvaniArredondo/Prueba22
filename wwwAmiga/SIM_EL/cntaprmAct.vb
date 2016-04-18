Public Class cntaprmAct
    Inherits entidadBase
#Region " Privadas "
    Private _cmesvig As String
    Private _año As String

    Private _nbasdia As Decimal

    Private _ntasmin As Decimal

    Private _ntasame As Decimal

    Private _ntasama As Decimal

    Private _ccierre As String

    Private _dfecimes As DateTime

    Private _dfecfmes As DateTime

    Private _dfecmod As DateTime

    Private _ccodusu As String

    Private _cflc As String

    Private _nfln As Decimal

#End Region

#Region " Propiedades "
    Public Property cmesvig() As String
        Get
            Return _cmesvig
        End Get
        Set(ByVal Value As String)
            _cmesvig = Value
        End Set
    End Property
    Public Property año() As String
        Get
            Return _año
        End Get
        Set(ByVal Value As String)
            _año = Value
        End Set
    End Property

    Public Property nbasdia() As Decimal
        Get
            Return _nbasdia
        End Get
        Set(ByVal Value As Decimal)
            _nbasdia = Value
        End Set
    End Property

    Public Property ntasmin() As Decimal
        Get
            Return _ntasmin
        End Get
        Set(ByVal Value As Decimal)
            _ntasmin = Value
        End Set
    End Property

    Public Property ntasame() As Decimal
        Get
            Return _ntasame
        End Get
        Set(ByVal Value As Decimal)
            _ntasame = Value
        End Set
    End Property

    Public Property ntasama() As Decimal
        Get
            Return _ntasama
        End Get
        Set(ByVal Value As Decimal)
            _ntasama = Value
        End Set
    End Property

    Public Property ccierre() As String
        Get
            Return _ccierre
        End Get
        Set(ByVal Value As String)
            _ccierre = Value
        End Set
    End Property

    Public Property dfecimes() As DateTime
        Get
            Return _dfecimes
        End Get
        Set(ByVal Value As DateTime)
            _dfecimes = Value
        End Set
    End Property

    Public Property dfecfmes() As DateTime
        Get
            Return _dfecfmes
        End Get
        Set(ByVal Value As DateTime)
            _dfecfmes = Value
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

    Public Property nfln() As Decimal
        Get
            Return _nfln
        End Get
        Set(ByVal Value As Decimal)
            _nfln = Value
        End Set
    End Property

#End Region

End Class
