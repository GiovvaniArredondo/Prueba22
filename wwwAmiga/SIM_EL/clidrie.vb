Public Class clidrie
    Inherits entidadBase
#Region " Privadas "
    Private _ctipser As String
 
    Private _ccodcta As String
 
    Private _ctipper As String
 
    Private _cnombre As String
 
    Private _dfecnac As DateTime
 
    Private _ccodcli As String
 
    Private _ctidoci As String
 
    Private _cnudoci As String
 
    Private _ccodorg As String
 
    Private _nmondeu As Decimal
 
    Private _cmoneda As String
 
    Private _ccondic As String
 
    Private _ctiprel As String
 
    Private _cestcli As String
 
    Private _ncuoven As Decimal
 
    Private _ncuopag As Decimal
 
    Private _nnrocuo As Decimal
 
    Private _ndiaatr As Decimal
 
    Private _ccodrec As String
 
    Private _dultrep As DateTime
 
    Private _ddatos As DateTime
 
    Private _cflag As String
 
#End Region
 
#Region " Propiedades "
    Public Property ctipser() As String
        Get
            Return _ctipser
        End Get
        Set(ByVal Value As String)
            _ctipser = Value
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
 
    Public Property ctipper() As String
        Get
            Return _ctipper
        End Get
        Set(ByVal Value As String)
            _ctipper = Value
        End Set
    End Property 
 
    Public Property cnombre() As String
        Get
            Return _cnombre
        End Get
        Set(ByVal Value As String)
            _cnombre = Value
        End Set
    End Property 
 
    Public Property dfecnac() As DateTime
        Get
            Return _dfecnac
        End Get
        Set(ByVal Value As DateTime)
            _dfecnac = Value
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
 
    Public Property ctidoci() As String
        Get
            Return _ctidoci
        End Get
        Set(ByVal Value As String)
            _ctidoci = Value
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
 
    Public Property ccodorg() As String
        Get
            Return _ccodorg
        End Get
        Set(ByVal Value As String)
            _ccodorg = Value
        End Set
    End Property 
 
    Public Property nmondeu() As Decimal
        Get
            Return _nmondeu
        End Get
        Set(ByVal Value As Decimal)
            _nmondeu = Value
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
 
    Public Property ctiprel() As String
        Get
            Return _ctiprel
        End Get
        Set(ByVal Value As String)
            _ctiprel = Value
        End Set
    End Property 
 
    Public Property cestcli() As String
        Get
            Return _cestcli
        End Get
        Set(ByVal Value As String)
            _cestcli = Value
        End Set
    End Property 
 
    Public Property ncuoven() As Decimal
        Get
            Return _ncuoven
        End Get
        Set(ByVal Value As Decimal)
            _ncuoven = Value
        End Set
    End Property 
 
    Public Property ncuopag() As Decimal
        Get
            Return _ncuopag
        End Get
        Set(ByVal Value As Decimal)
            _ncuopag = Value
        End Set
    End Property 
 
    Public Property nnrocuo() As Decimal
        Get
            Return _nnrocuo
        End Get
        Set(ByVal Value As Decimal)
            _nnrocuo = Value
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
 
    Public Property ccodrec() As String
        Get
            Return _ccodrec
        End Get
        Set(ByVal Value As String)
            _ccodrec = Value
        End Set
    End Property 
 
    Public Property dultrep() As DateTime
        Get
            Return _dultrep
        End Get
        Set(ByVal Value As DateTime)
            _dultrep = Value
        End Set
    End Property 
 
    Public Property ddatos() As DateTime
        Get
            Return _ddatos
        End Get
        Set(ByVal Value As DateTime)
            _ddatos = Value
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
 
#End Region
End Class
