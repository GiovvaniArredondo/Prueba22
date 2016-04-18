Public Class ahotlin
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
 
    Private _cnropar As String
 
    Private _nmonmin As Decimal
 
    Private _ctipdes As String
 
    Private _ndesuso As Decimal
 
    Private _ccodusu As String
 
    Private _nplainf As Decimal
 
    Private _nplasup As Decimal
 
    Private _lnegoc As Boolean
 
    Private _cflag As String
 
    Private _dfecmod As DateTime

    Private _ntasmin As Decimal

    Private _ntasmax As Decimal


#End Region
 
#Region " Propiedades "
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
 
    Public Property cnropar() As String
        Get
            Return _cnropar
        End Get
        Set(ByVal Value As String)
            _cnropar = Value
        End Set
    End Property 
 
    Public Property nmonmin() As Decimal
        Get
            Return _nmonmin
        End Get
        Set(ByVal Value As Decimal)
            _nmonmin = Value
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
 
    Public Property ccodusu() As String
        Get
            Return _ccodusu
        End Get
        Set(ByVal Value As String)
            _ccodusu = Value
        End Set
    End Property 
 
    Public Property nplainf() As Decimal
        Get
            Return _nplainf
        End Get
        Set(ByVal Value As Decimal)
            _nplainf = Value
        End Set
    End Property 
 
    Public Property nplasup() As Decimal
        Get
            Return _nplasup
        End Get
        Set(ByVal Value As Decimal)
            _nplasup = Value
        End Set
    End Property 
 
    Public Property lnegoc() As Boolean
        Get
            Return _lnegoc
        End Get
        Set(ByVal Value As Boolean)
            _lnegoc = Value
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
 
    Public Property dfecmod() As DateTime
        Get
            Return _dfecmod
        End Get
        Set(ByVal Value As DateTime)
            _dfecmod = Value
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

    Public Property ntasmax() As Decimal
        Get
            Return _ntasmax
        End Get
        Set(ByVal Value As Decimal)
            _ntasmax = Value
        End Set
    End Property
 
#End Region
End Class
