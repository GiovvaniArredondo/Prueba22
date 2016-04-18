Public Class ComCtb
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcta As String

    Private _ctipmon As String

    Private _ctipcta As String

    Private _cnivel As String

    Private _cclase As String

    Private _cdescrip As String

    Private _nsalini As Decimal

    Private _ndebeac As Decimal

    Private _nhaberac As Decimal

    Private _ccodto As String

    Private _dfecreg As DateTime

    Private _dfecmod As DateTime

    Private _cmovida As String

    Private _ccodusu As String

    Private _cflc As String

    Private _nfln As Decimal

    Private _oin As String

    Private _nfuefon As Decimal

    Private _nver As String

    Private _cauxcta As Decimal

    Private _cgu As String

    Private _cfuente As String

    Private _cctasup As String
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

    Public Property ctipmon() As String
        Get
            Return _ctipmon
        End Get
        Set(ByVal Value As String)
            _ctipmon = Value
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

    Public Property cnivel() As String
        Get
            Return _cnivel
        End Get
        Set(ByVal Value As String)
            _cnivel = Value
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

    Public Property cdescrip() As String
        Get
            Return _cdescrip
        End Get
        Set(ByVal Value As String)
            _cdescrip = Value
        End Set
    End Property

    Public Property nsalini() As Decimal
        Get
            Return _nsalini
        End Get
        Set(ByVal Value As Decimal)
            _nsalini = Value
        End Set
    End Property

    Public Property ndebeac() As Decimal
        Get
            Return _ndebeac
        End Get
        Set(ByVal Value As Decimal)
            _ndebeac = Value
        End Set
    End Property

    Public Property nhaberac() As Decimal
        Get
            Return _nhaberac
        End Get
        Set(ByVal Value As Decimal)
            _nhaberac = Value
        End Set
    End Property

    Public Property ccodto() As String
        Get
            Return _ccodto
        End Get
        Set(ByVal Value As String)
            _ccodto = Value
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

    Public Property cmovida() As String
        Get
            Return _cmovida
        End Get
        Set(ByVal Value As String)
            _cmovida = Value
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

    Public Property oin() As String
        Get
            Return _oin
        End Get
        Set(ByVal Value As String)
            _oin = Value
        End Set
    End Property

    Public Property nfuefon() As Decimal
        Get
            Return _nfuefon
        End Get
        Set(ByVal Value As Decimal)
            _nfuefon = Value
        End Set
    End Property

    Public Property nver() As String
        Get
            Return _nver
        End Get
        Set(ByVal Value As String)
            _nver = Value
        End Set
    End Property

    Public Property cauxcta() As Decimal
        Get
            Return _cauxcta
        End Get
        Set(ByVal Value As Decimal)
            _cauxcta = Value
        End Set
    End Property

    Public Property cgu() As String
        Get
            Return _cgu
        End Get
        Set(ByVal Value As String)
            _cgu = Value
        End Set
    End Property

    Public Property cfuente() As String
        Get
            Return _cfuente
        End Get
        Set(ByVal Value As String)
            _cfuente = Value
        End Set
    End Property

    Public Property cCtaSup() As String
        Get
            Return _cctasup
        End Get
        Set(ByVal Value As String)
            _cctasup = Value
        End Set
    End Property

#End Region
End Class
