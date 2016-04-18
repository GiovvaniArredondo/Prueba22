Public Class ahomint
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcrt As String
 
    Private _cnrolin As String
 
    Private _nombre As String
 
    Private _cnudotr As String
 
    Private _ccodaho As String
 
    Private _nmonapr As Decimal
 
    Private _nplazo As Decimal
 
    Private _nintere As Decimal
 
    Private _dfecapr As DateTime
 
    Private _dfecven As DateTime
 
    Private _dfecprv As DateTime
 
    Private _dfecori As DateTime
 
    Private _dfecliq As DateTime
 
    Private _ndiagra As Decimal
 
    Private _ccalint As String
 
    Private _cprvint As String
 
    Private _ccodbco As String
 
    Private _cctacte As String
 
    Private _ccapita As String
 
    Private _cpignor As String
 
    Private _ccodcta As String
 
    Private _dfecmod As DateTime
 
    Private _ccodusu As String
 
    Private _cprovis As String
 
    Private _cliq As String
 
    Private _nsaldoaho As Decimal
 
    Private _nmonotr As Decimal
 
    Private _dfeccap As DateTime
 
    Private _ccodcli As String
 
    Private _cpig As String
 
    Private _producto As String
 
    Private _cestado As String
 
    Private _cflag As String
 
    Private _dfecpro As DateTime
 
    Private _dfecmod2 As DateTime
 
    Private _ntasint As Decimal
 
    Private _nnum As Decimal
 
#End Region
 
#Region " Propiedades "
    Public Property ccodcrt() As String
        Get
            Return _ccodcrt
        End Get
        Set(ByVal Value As String)
            _ccodcrt = Value
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
 
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal Value As String)
            _nombre = Value
        End Set
    End Property 
 
    Public Property cnudotr() As String
        Get
            Return _cnudotr
        End Get
        Set(ByVal Value As String)
            _cnudotr = Value
        End Set
    End Property 
 
    Public Property ccodaho() As String
        Get
            Return _ccodaho
        End Get
        Set(ByVal Value As String)
            _ccodaho = Value
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
 
    Public Property nplazo() As Decimal
        Get
            Return _nplazo
        End Get
        Set(ByVal Value As Decimal)
            _nplazo = Value
        End Set
    End Property 
 
    Public Property nintere() As Decimal
        Get
            Return _nintere
        End Get
        Set(ByVal Value As Decimal)
            _nintere = Value
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
 
    Public Property dfecprv() As DateTime
        Get
            Return _dfecprv
        End Get
        Set(ByVal Value As DateTime)
            _dfecprv = Value
        End Set
    End Property 
 
    Public Property dfecori() As DateTime
        Get
            Return _dfecori
        End Get
        Set(ByVal Value As DateTime)
            _dfecori = Value
        End Set
    End Property 
 
    Public Property dfecliq() As DateTime
        Get
            Return _dfecliq
        End Get
        Set(ByVal Value As DateTime)
            _dfecliq = Value
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
 
    Public Property ccalint() As String
        Get
            Return _ccalint
        End Get
        Set(ByVal Value As String)
            _ccalint = Value
        End Set
    End Property 
 
    Public Property cprvint() As String
        Get
            Return _cprvint
        End Get
        Set(ByVal Value As String)
            _cprvint = Value
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
 
    Public Property ccapita() As String
        Get
            Return _ccapita
        End Get
        Set(ByVal Value As String)
            _ccapita = Value
        End Set
    End Property 
 
    Public Property cpignor() As String
        Get
            Return _cpignor
        End Get
        Set(ByVal Value As String)
            _cpignor = Value
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
 
    Public Property cprovis() As String
        Get
            Return _cprovis
        End Get
        Set(ByVal Value As String)
            _cprovis = Value
        End Set
    End Property 
 
    Public Property cliq() As String
        Get
            Return _cliq
        End Get
        Set(ByVal Value As String)
            _cliq = Value
        End Set
    End Property 
 
    Public Property nsaldoaho() As Decimal
        Get
            Return _nsaldoaho
        End Get
        Set(ByVal Value As Decimal)
            _nsaldoaho = Value
        End Set
    End Property 
 
    Public Property nmonotr() As Decimal
        Get
            Return _nmonotr
        End Get
        Set(ByVal Value As Decimal)
            _nmonotr = Value
        End Set
    End Property 
 
    Public Property dfeccap() As DateTime
        Get
            Return _dfeccap
        End Get
        Set(ByVal Value As DateTime)
            _dfeccap = Value
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
 
    Public Property cpig() As String
        Get
            Return _cpig
        End Get
        Set(ByVal Value As String)
            _cpig = Value
        End Set
    End Property 
 
    Public Property producto() As String
        Get
            Return _producto
        End Get
        Set(ByVal Value As String)
            _producto = Value
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
 
    Public Property cflag() As String
        Get
            Return _cflag
        End Get
        Set(ByVal Value As String)
            _cflag = Value
        End Set
    End Property 
 
    Public Property dfecpro() As DateTime
        Get
            Return _dfecpro
        End Get
        Set(ByVal Value As DateTime)
            _dfecpro = Value
        End Set
    End Property 
 
    Public Property dfecmod2() As DateTime
        Get
            Return _dfecmod2
        End Get
        Set(ByVal Value As DateTime)
            _dfecmod2 = Value
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
 
    Public Property nnum() As Decimal
        Get
            Return _nnum
        End Get
        Set(ByVal Value As Decimal)
            _nnum = Value
        End Set
    End Property 
 
#End Region
End Class
