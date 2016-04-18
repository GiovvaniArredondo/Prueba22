Public Class cretlin
    Inherits entidadBase
#Region " Privadas "
    Private _cnrolin As String
 
    Private _ccodlin As String
 
    Private _dfecvig As DateTime
 
    Private _cdeslin As String
 
    Private _ntasint As Decimal
 
    Private _ctipcal As String
 
    Private _ntasmor As Decimal

    Private _nliminf As Decimal
 
    Private _nlimsup As Decimal
 
    Private _lactiva As Boolean
 
    Private _llinusa As Boolean
 
    Private _llinpre As Boolean
 
    Private _cnropar As String
 
    Private _nmondes As Decimal
 
    Private _ctipdes As String
 
    Private _ndesuso As Decimal
 
    Private _ladmon As Boolean
 
    Private _lsegvida As Boolean
 
    Private _lsegdeu As Boolean
 
    Private _lredo As Boolean
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String
 
    Private _ccodrub As String
 
    Private _ctiplin As String
 
    Private _ctipo As String
 
    Private _ccodbco As String
 
    Private _cctacte As String

    Private _ntasintmax As Decimal
    Private _ntasintmin As Decimal

    Private _nplazomax As Integer
    Private _nplazomin As Integer
    Private _lliva As Boolean
    Private _nocuotas As Integer
    Private _nmoncuo As Decimal
#End Region
 
#Region " Propiedades "
    Public Property nplazomin() As Integer
        Get
            Return _nplazomin
        End Get
        Set(ByVal Value As Integer)
            _nplazomin = Value
        End Set
    End Property
    Public Property nplazomax() As Integer
        Get
            Return _nplazomax
        End Get
        Set(ByVal Value As Integer)
            _nplazomax = Value
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
 
    Public Property ccodlin() As String
        Get
            Return _ccodlin
        End Get
        Set(ByVal Value As String)
            _ccodlin = Value
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
 
    Public Property cdeslin() As String
        Get
            Return _cdeslin
        End Get
        Set(ByVal Value As String)
            _cdeslin = Value
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
 
    Public Property ctipcal() As String
        Get
            Return _ctipcal
        End Get
        Set(ByVal Value As String)
            _ctipcal = Value
        End Set
    End Property 
 
    Public Property ntasmor() As Decimal
        Get
            Return _ntasmor
        End Get
        Set(ByVal Value As Decimal)
            _ntasmor = Value
        End Set
    End Property 


    Public Property nocuotas() As Decimal
        Get
            Return _nocuotas
        End Get
        Set(ByVal Value As Decimal)
            _nocuotas = Value
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

    Public Property nliminf() As Decimal
        Get
            Return _nliminf
        End Get
        Set(ByVal Value As Decimal)
            _nliminf = Value
        End Set
    End Property 
 
    Public Property nlimsup() As Decimal
        Get
            Return _nlimsup
        End Get
        Set(ByVal Value As Decimal)
            _nlimsup = Value
        End Set
    End Property 
 
    Public Property lactiva() As Boolean
        Get
            Return _lactiva
        End Get
        Set(ByVal Value As Boolean)
            _lactiva = Value
        End Set
    End Property 
 
    Public Property llinusa() As Boolean
        Get
            Return _llinusa
        End Get
        Set(ByVal Value As Boolean)
            _llinusa = Value
        End Set
    End Property 
 
    Public Property llinpre() As Boolean
        Get
            Return _llinpre
        End Get
        Set(ByVal Value As Boolean)
            _llinpre = Value
        End Set
    End Property 
 
    Public Property cnropar() As String
        Get
            Return _cnropar
        End Get
        Set(ByVal Value As String)
            _cnropar = Value
        End Set
    End Property 
 
    Public Property nmondes() As Decimal
        Get
            Return _nmondes
        End Get
        Set(ByVal Value As Decimal)
            _nmondes = Value
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
 
    Public Property ndesuso() As Decimal
        Get
            Return _ndesuso
        End Get
        Set(ByVal Value As Decimal)
            _ndesuso = Value
        End Set
    End Property 
 
    Public Property ladmon() As Boolean
        Get
            Return _ladmon
        End Get
        Set(ByVal Value As Boolean)
            _ladmon = Value
        End Set
    End Property 
 
    Public Property lsegvida() As Boolean
        Get
            Return _lsegvida
        End Get
        Set(ByVal Value As Boolean)
            _lsegvida = Value
        End Set
    End Property 
 
    Public Property lsegdeu() As Boolean
        Get
            Return _lsegdeu
        End Get
        Set(ByVal Value As Boolean)
            _lsegdeu = Value
        End Set
    End Property 
 
    Public Property lredo() As Boolean
        Get
            Return _lredo
        End Get
        Set(ByVal Value As Boolean)
            _lredo = Value
        End Set
    End Property

    Public Property lliva() As Boolean
        Get
            Return _lliva
        End Get
        Set(ByVal Value As Boolean)
            _lliva = Value
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
 
    Public Property ccodrub() As String
        Get
            Return _ccodrub
        End Get
        Set(ByVal Value As String)
            _ccodrub = Value
        End Set
    End Property 
 
    Public Property ctiplin() As String
        Get
            Return _ctiplin
        End Get
        Set(ByVal Value As String)
            _ctiplin = Value
        End Set
    End Property 
 
    Public Property ctipo() As String
        Get
            Return _ctipo
        End Get
        Set(ByVal Value As String)
            _ctipo = Value
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
    Public Property ntasintmin() As Decimal
        Get
            Return _ntasintmin
        End Get
        Set(ByVal Value As Decimal)
            _ntasintmin = Value
        End Set
    End Property
    Public Property ntasintmax() As Decimal
        Get
            Return _ntasintmax
        End Get
        Set(ByVal Value As Decimal)
            _ntasintmax = Value
        End Set
    End Property

#End Region
End Class
