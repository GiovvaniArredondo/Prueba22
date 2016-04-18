Public Class clidpre
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcli As String
 
    Private _cestado As String
 
    Private _dfecape As DateTime
 
    Private _dfecvig As DateTime
 
    Private _dfecvto As DateTime
 
    Private _cmoneda As String
 
    Private _nlimmax As Decimal
 
    Private _ncuomax As Decimal
 
    Private _dfeccan As DateTime
 
    Private _ccodrec As String
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String
 
#End Region
 
#Region " Propiedades "
    Public Property ccodcli() As String
        Get
            Return _ccodcli
        End Get
        Set(ByVal Value As String)
            _ccodcli = Value
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
 
    Public Property dfecape() As DateTime
        Get
            Return _dfecape
        End Get
        Set(ByVal Value As DateTime)
            _dfecape = Value
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
 
    Public Property dfecvto() As DateTime
        Get
            Return _dfecvto
        End Get
        Set(ByVal Value As DateTime)
            _dfecvto = Value
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
 
    Public Property nlimmax() As Decimal
        Get
            Return _nlimmax
        End Get
        Set(ByVal Value As Decimal)
            _nlimmax = Value
        End Set
    End Property 
 
    Public Property ncuomax() As Decimal
        Get
            Return _ncuomax
        End Get
        Set(ByVal Value As Decimal)
            _ncuomax = Value
        End Set
    End Property 
 
    Public Property dfeccan() As DateTime
        Get
            Return _dfeccan
        End Get
        Set(ByVal Value As DateTime)
            _dfeccan = Value
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
 
#End Region
End Class
