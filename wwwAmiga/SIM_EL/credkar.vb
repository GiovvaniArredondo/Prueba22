Public Class credkar
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcta As String
 
    Private _dfecpro As DateTime
 
    Private _dfecsis As DateTime
 
    Private _cnrocuo As String
 
    Private _nmonto As Decimal
 
    Private _ccodins As String
 
    Private _ccodofi As String
 
    Private _ctippag As String
 
    Private _cestado As String
 
    Private _ctermid As String
 
    Private _cnrodoc As String
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cmoneda As String
 
    Private _ccondic As String
 
    Private _cconcep As String
 
    Private _cdescob As String
 
    Private _cnuming As String

    Private _cnuming0 As String
 
    Private _cbanco As String
 
    Private _ccodctb As String
 
    Private _ctrasctb As Boolean
 
    Private _cflag As String
 
    Private _cclipag As String
 
    Private _mancomunad As Decimal
 
    Private _cnomcta As String
 
    Private _cnumcta As String
 
    Private _crotativa As String
 
    Private _ndiaatr As Decimal

    Private _ncorrela As Decimal

    Private _lsolidario As Boolean
 
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
 
    Public Property dfecpro() As DateTime
        Get
            Return _dfecpro
        End Get
        Set(ByVal Value As DateTime)
            _dfecpro = Value
        End Set
    End Property 
 
    Public Property dfecsis() As DateTime
        Get
            Return _dfecsis
        End Get
        Set(ByVal Value As DateTime)
            _dfecsis = Value
        End Set
    End Property 
 
    Public Property cnrocuo() As String
        Get
            Return _cnrocuo
        End Get
        Set(ByVal Value As String)
            _cnrocuo = Value
        End Set
    End Property 
 
    Public Property nmonto() As Decimal
        Get
            Return _nmonto
        End Get
        Set(ByVal Value As Decimal)
            _nmonto = Value
        End Set
    End Property 
 
    Public Property ccodins() As String
        Get
            Return _ccodins
        End Get
        Set(ByVal Value As String)
            _ccodins = Value
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
 
    Public Property ctippag() As String
        Get
            Return _ctippag
        End Get
        Set(ByVal Value As String)
            _ctippag = Value
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
 
    Public Property ctermid() As String
        Get
            Return _ctermid
        End Get
        Set(ByVal Value As String)
            _ctermid = Value
        End Set
    End Property 
 
    Public Property cnrodoc() As String
        Get
            Return _cnrodoc
        End Get
        Set(ByVal Value As String)
            _cnrodoc = Value
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
 
    Public Property cmoneda() As String
        Get
            Return _cmoneda
        End Get
        Set(ByVal Value As String)
            _cmoneda = Value
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
 
    Public Property cconcep() As String
        Get
            Return _cconcep
        End Get
        Set(ByVal Value As String)
            _cconcep = Value
        End Set
    End Property 
 
    Public Property cdescob() As String
        Get
            Return _cdescob
        End Get
        Set(ByVal Value As String)
            _cdescob = Value
        End Set
    End Property 
 
    Public Property cnuming() As String
        Get
            Return _cnuming
        End Get
        Set(ByVal Value As String)
            _cnuming = Value
        End Set
    End Property 
    Public Property cnuming0() As String
        Get
            Return _cnuming0
        End Get
        Set(ByVal Value As String)
            _cnuming0 = Value
        End Set
    End Property


    Public Property cbanco() As String
        Get
            Return _cbanco
        End Get
        Set(ByVal Value As String)
            _cbanco = Value
        End Set
    End Property 
 
    Public Property ccodctb() As String
        Get
            Return _ccodctb
        End Get
        Set(ByVal Value As String)
            _ccodctb = Value
        End Set
    End Property 
 
    Public Property ctrasctb() As Boolean
        Get
            Return _ctrasctb
        End Get
        Set(ByVal Value As Boolean)
            _ctrasctb = Value
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
 
    Public Property cclipag() As String
        Get
            Return _cclipag
        End Get
        Set(ByVal Value As String)
            _cclipag = Value
        End Set
    End Property 
 
    Public Property mancomunad() As Decimal
        Get
            Return _mancomunad
        End Get
        Set(ByVal Value As Decimal)
            _mancomunad = Value
        End Set
    End Property 
 
    Public Property cnomcta() As String
        Get
            Return _cnomcta
        End Get
        Set(ByVal Value As String)
            _cnomcta = Value
        End Set
    End Property 
 
    Public Property cnumcta() As String
        Get
            Return _cnumcta
        End Get
        Set(ByVal Value As String)
            _cnumcta = Value
        End Set
    End Property 
 
    Public Property crotativa() As String
        Get
            Return _crotativa
        End Get
        Set(ByVal Value As String)
            _crotativa = Value
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

    Public Property ncorrela() As Decimal
        Get
            Return _ncorrela
        End Get
        Set(ByVal Value As Decimal)
            _ncorrela = Value
        End Set
    End Property

    Public Property lsolidario() As Boolean
        Get
            Return _lsolidario
        End Get
        Set(ByVal Value As Boolean)
            _lsolidario = Value
        End Set
    End Property
#End Region
End Class
