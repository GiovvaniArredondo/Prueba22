Public Class ahomcta
    Inherits entidadBase
#Region " Privadas "
    Private _ccodaho As String
 
    Private _cnrolin As String
 
    Private _ccodcta As String
 
    Private _cnudotr As String
 
    Private _nlibreta As Decimal
 
    Private _cestado As String
 
    Private _cbloqueo As String
 
    Private _dfecini As DateTime
 
    Private _dfecapr As DateTime
 
    Private _dfecult As DateTime
 
    Private _dfecmod As DateTime
 
    Private _dfecfin As DateTime
 
    Private _ccodusu As String
 
    Private _ncorrel As Decimal
 
    Private _nnum As Decimal
 
    Private _llave As String
 
    Private _nombre As String
 
    Private _apellido As String
 
    Private _nsaldoaho As Decimal
 
    Private _nmonini As Decimal
 
    Private _nmonapr As Decimal
 
    Private _nsaldnind As Decimal
 
    Private _nmonres As Decimal
 
    Private _dfeccap As DateTime
 
    Private _ccodcli As String
 
    Private _producto As String
 
    Private _cmotivo As String
 
    Private _despro As String
 
    Private _sub_pro As String
 
    Private _dultmov As DateTime
 
    Private _notas As String
 
    Private _dfechault As DateTime
 
#End Region
 
#Region " Propiedades "
    Public Property ccodaho() As String
        Get
            Return _ccodaho
        End Get
        Set(ByVal Value As String)
            _ccodaho = Value
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
 
    Public Property ccodcta() As String
        Get
            Return _ccodcta
        End Get
        Set(ByVal Value As String)
            _ccodcta = Value
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
 
    Public Property nlibreta() As Decimal
        Get
            Return _nlibreta
        End Get
        Set(ByVal Value As Decimal)
            _nlibreta = Value
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
 
    Public Property cbloqueo() As String
        Get
            Return _cbloqueo
        End Get
        Set(ByVal Value As String)
            _cbloqueo = Value
        End Set
    End Property 
 
    Public Property dfecini() As DateTime
        Get
            Return _dfecini
        End Get
        Set(ByVal Value As DateTime)
            _dfecini = Value
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
 
    Public Property dfecult() As DateTime
        Get
            Return _dfecult
        End Get
        Set(ByVal Value As DateTime)
            _dfecult = Value
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
 
    Public Property dfecfin() As DateTime
        Get
            Return _dfecfin
        End Get
        Set(ByVal Value As DateTime)
            _dfecfin = Value
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
 
    Public Property ncorrel() As Decimal
        Get
            Return _ncorrel
        End Get
        Set(ByVal Value As Decimal)
            _ncorrel = Value
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
 
    Public Property llave() As String
        Get
            Return _llave
        End Get
        Set(ByVal Value As String)
            _llave = Value
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
 
    Public Property apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal Value As String)
            _apellido = Value
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
 
    Public Property nmonini() As Decimal
        Get
            Return _nmonini
        End Get
        Set(ByVal Value As Decimal)
            _nmonini = Value
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
 
    Public Property nsaldnind() As Decimal
        Get
            Return _nsaldnind
        End Get
        Set(ByVal Value As Decimal)
            _nsaldnind = Value
        End Set
    End Property 
 
    Public Property nmonres() As Decimal
        Get
            Return _nmonres
        End Get
        Set(ByVal Value As Decimal)
            _nmonres = Value
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
 
    Public Property producto() As String
        Get
            Return _producto
        End Get
        Set(ByVal Value As String)
            _producto = Value
        End Set
    End Property 
 
    Public Property cmotivo() As String
        Get
            Return _cmotivo
        End Get
        Set(ByVal Value As String)
            _cmotivo = Value
        End Set
    End Property 
 
    Public Property despro() As String
        Get
            Return _despro
        End Get
        Set(ByVal Value As String)
            _despro = Value
        End Set
    End Property 
 
    Public Property sub_pro() As String
        Get
            Return _sub_pro
        End Get
        Set(ByVal Value As String)
            _sub_pro = Value
        End Set
    End Property 
 
    Public Property dultmov() As DateTime
        Get
            Return _dultmov
        End Get
        Set(ByVal Value As DateTime)
            _dultmov = Value
        End Set
    End Property 
 
    Public Property notas() As String
        Get
            Return _notas
        End Get
        Set(ByVal Value As String)
            _notas = Value
        End Set
    End Property 
 
    Public Property dfechault() As DateTime
        Get
            Return _dfechault
        End Get
        Set(ByVal Value As DateTime)
            _dfechault = Value
        End Set
    End Property 
 
#End Region
End Class
