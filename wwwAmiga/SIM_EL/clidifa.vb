Public Class clidifa
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcli As String
 
    Private _devalua As DateTime
 
    Private _ningfam As Decimal
 
    Private _ngasfam As Decimal
 
    Private _ningdep As Decimal
 
    Private _ningind As Decimal
 
    Private _negrind As Decimal
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
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
 
    Public Property devalua() As DateTime
        Get
            Return _devalua
        End Get
        Set(ByVal Value As DateTime)
            _devalua = Value
        End Set
    End Property 
 
    Public Property ningfam() As Decimal
        Get
            Return _ningfam
        End Get
        Set(ByVal Value As Decimal)
            _ningfam = Value
        End Set
    End Property 
 
    Public Property ngasfam() As Decimal
        Get
            Return _ngasfam
        End Get
        Set(ByVal Value As Decimal)
            _ngasfam = Value
        End Set
    End Property 
 
    Public Property ningdep() As Decimal
        Get
            Return _ningdep
        End Get
        Set(ByVal Value As Decimal)
            _ningdep = Value
        End Set
    End Property 
 
    Public Property ningind() As Decimal
        Get
            Return _ningind
        End Get
        Set(ByVal Value As Decimal)
            _ningind = Value
        End Set
    End Property 
 
    Public Property negrind() As Decimal
        Get
            Return _negrind
        End Get
        Set(ByVal Value As Decimal)
            _negrind = Value
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
 
#End Region
End Class
