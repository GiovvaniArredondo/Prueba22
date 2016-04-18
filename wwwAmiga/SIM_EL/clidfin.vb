Public Class clidfin
    Inherits entidadBase

#Region " Privadas "
    Private _ccodcli As String
 
    Private _ctiprel As String
 
    Private _ccodfue As String
 
    Private _cnomfue As String
 
    Private _ctidofu As String
 
    Private _cnudofu As String
 
    Private _dinifue As DateTime
 
    Private _nemplea As Decimal
 
    Private _cubifue As String
 
    Private _cdirfue As String
 
    Private _ctelfue As String
 
    Private _cconfue As String
 
    Private _csececo As String
 
    Private _ccodact As String
 
    Private _canoubi As Date
 
    Private _nfahope As Decimal
 
    Private _nfahote As Decimal
 
    Private _nfamupe As Decimal
 
    Private _nfamute As Decimal
 
    Private _nnfhope As Decimal
 
    Private _nnfhote As Decimal
 
    Private _nnfmupe As Decimal
 
    Private _nnfmute As Decimal
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _nsueldo As Decimal
 
    Private _ctipneg As String

    Private _cpara As String
    Private _nmetros As Decimal
    Private _nvaras As Decimal
    Private _cmedida As String
    Private _ncantidad As Decimal
    Private _cgiro As String
    Private _longitud As String
    Private _latitud As String
    'Private _nfamupe As Integer
    'Private _nfamute As Integer
    'Private _nnfmupe As Integer
    'Private _nnfmute As Integer
#End Region
 
#Region " Propiedades "
    Public Property cpara() As String
        Get
            Return _cpara
        End Get
        Set(ByVal Value As String)
            _cpara = Value
        End Set
    End Property
    Public Property nmetros() As Decimal
        Get
            Return _nmetros
        End Get
        Set(ByVal Value As Decimal)
            _nmetros = Value
        End Set
    End Property
    Public Property nvaras() As Decimal
        Get
            Return _nvaras
        End Get
        Set(ByVal Value As Decimal)
            _nvaras = Value
        End Set
    End Property
    Public Property cmedida() As String
        Get
            Return _cmedida
        End Get
        Set(ByVal Value As String)
            _cmedida = Value
        End Set
    End Property
    Public Property ncantidad() As Decimal
        Get
            Return _ncantidad
        End Get
        Set(ByVal Value As Decimal)
            _ncantidad = Value
        End Set
    End Property
    'Public Property nfamupe() As Integer
    '    Get
    '        Return _nfamupe
    '    End Get
    '    Set(ByVal Value As Integer)
    '        _nfamupe = Value
    '    End Set
    'End Property
    'Public Property nfamute() As Integer
    '    Get
    '        Return _nfamute
    '    End Get
    '    Set(ByVal Value As Integer)
    '        _nfamute = Value
    '    End Set
    'End Property
    'Public Property nnfmupe() As Integer
    '    Get
    '        Return _nnfmupe
    '    End Get
    '    Set(ByVal Value As Integer)
    '        _nnfmupe = Value
    '    End Set
    'End Property
    'Public Property nnfmute() As Integer
    '    Get
    '        Return _nnfmute
    '    End Get
    '    Set(ByVal Value As Integer)
    '        _nnfmute = Value
    '    End Set
    'End Property

    Private _cmanfon As String
    Private _cpuesto As String
    Private _cjefe As String
    Private _cpuestojefe As String

    Private _dfechaA As Date
    Private _cconcpa As String
    Private _cconvta As String
    Private _cdirterreno As String

    Public Property cdirterreno() As String
        Get
            Return _cdirterreno
        End Get
        Set(ByVal Value As String)
            _cdirterreno = Value
        End Set
    End Property
    Public Property dfechaA() As Date
        Get
            Return _dfechaA
        End Get
        Set(ByVal Value As Date)
            _dfechaA = Value
        End Set
    End Property
    Public Property cconcpa() As String
        Get
            Return _cconcpa
        End Get
        Set(ByVal Value As String)
            _cconcpa = Value
        End Set
    End Property
    Public Property cconvta() As String
        Get
            Return _cconvta
        End Get
        Set(ByVal Value As String)
            _cconvta = Value
        End Set
    End Property

    Public Property cmanfon() As String
        Get
            Return _cmanfon
        End Get
        Set(ByVal Value As String)
            _cmanfon = Value
        End Set
    End Property
    Public Property cpuesto() As String
        Get
            Return _cpuesto
        End Get
        Set(ByVal Value As String)
            _cpuesto = Value
        End Set
    End Property
    Public Property cjefe() As String
        Get
            Return _cjefe
        End Get
        Set(ByVal Value As String)
            _cjefe = Value
        End Set
    End Property
    Public Property cpuestojefe() As String
        Get
            Return _cpuestojefe
        End Get
        Set(ByVal Value As String)
            _cpuestojefe = Value
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

    Public Property ctiprel() As String
        Get
            Return _ctiprel
        End Get
        Set(ByVal Value As String)
            _ctiprel = Value
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

    Public Property cnomfue() As String
        Get
            Return _cnomfue
        End Get
        Set(ByVal Value As String)
            _cnomfue = Value
        End Set
    End Property

    Public Property ctidofu() As String
        Get
            Return _ctidofu
        End Get
        Set(ByVal Value As String)
            _ctidofu = Value
        End Set
    End Property

    Public Property cnudofu() As String
        Get
            Return _cnudofu
        End Get
        Set(ByVal Value As String)
            _cnudofu = Value
        End Set
    End Property

    Public Property dinifue() As DateTime
        Get
            Return _dinifue
        End Get
        Set(ByVal Value As DateTime)
            _dinifue = Value
        End Set
    End Property

    Public Property nemplea() As Decimal
        Get
            Return _nemplea
        End Get
        Set(ByVal Value As Decimal)
            _nemplea = Value
        End Set
    End Property

    Public Property cubifue() As String
        Get
            Return _cubifue
        End Get
        Set(ByVal Value As String)
            _cubifue = Value
        End Set
    End Property

    Public Property cdirfue() As String
        Get
            Return _cdirfue
        End Get
        Set(ByVal Value As String)
            _cdirfue = Value
        End Set
    End Property

    Public Property ctelfue() As String
        Get
            Return _ctelfue
        End Get
        Set(ByVal Value As String)
            _ctelfue = Value
        End Set
    End Property

    Public Property cconfue() As String
        Get
            Return _cconfue
        End Get
        Set(ByVal Value As String)
            _cconfue = Value
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

    Public Property ccodact() As String
        Get
            Return _ccodact
        End Get
        Set(ByVal Value As String)
            _ccodact = Value
        End Set
    End Property

    Public Property canoubi() As Date
        Get
            Return _canoubi
        End Get
        Set(ByVal Value As Date)
            _canoubi = Value
        End Set
    End Property

    Public Property nfahope() As Decimal
        Get
            Return _nfahope
        End Get
        Set(ByVal Value As Decimal)
            _nfahope = Value
        End Set
    End Property

    Public Property nfahote() As Decimal
        Get
            Return _nfahote
        End Get
        Set(ByVal Value As Decimal)
            _nfahote = Value
        End Set
    End Property

    Public Property nfamupe() As Decimal
        Get
            Return _nfamupe
        End Get
        Set(ByVal Value As Decimal)
            _nfamupe = Value
        End Set
    End Property

    Public Property nfamute() As Decimal
        Get
            Return _nfamute
        End Get
        Set(ByVal Value As Decimal)
            _nfamute = Value
        End Set
    End Property

    Public Property nnfhope() As Decimal
        Get
            Return _nnfhope
        End Get
        Set(ByVal Value As Decimal)
            _nnfhope = Value
        End Set
    End Property

    Public Property nnfhote() As Decimal
        Get
            Return _nnfhote
        End Get
        Set(ByVal Value As Decimal)
            _nnfhote = Value
        End Set
    End Property

    Public Property nnfmupe() As Decimal
        Get
            Return _nnfmupe
        End Get
        Set(ByVal Value As Decimal)
            _nnfmupe = Value
        End Set
    End Property

    Public Property nnfmute() As Decimal
        Get
            Return _nnfmute
        End Get
        Set(ByVal Value As Decimal)
            _nnfmute = Value
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

    Public Property nsueldo() As Decimal
        Get
            Return _nsueldo
        End Get
        Set(ByVal Value As Decimal)
            _nsueldo = Value
        End Set
    End Property

    Public Property ctipneg() As String
        Get
            Return _ctipneg
        End Get
        Set(ByVal Value As String)
            _ctipneg = Value
        End Set
    End Property

    Public Property cgiro() As String
        Get
            Return _cgiro
        End Get
        Set(ByVal Value As String)
            _cgiro = Value
        End Set
    End Property

    Public Property latitud() As String
        Get
            Return _latitud
        End Get
        Set(ByVal Value As String)
            _latitud = Value
        End Set
    End Property

    Public Property longitud() As String
        Get
            Return _longitud
        End Get
        Set(ByVal Value As String)
            _longitud = Value
        End Set
    End Property
#End Region
End Class

