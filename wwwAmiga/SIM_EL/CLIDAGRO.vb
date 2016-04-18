Public Class CLIDAGRO
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcli As String
 
    Private _ccodfue As String
 
    Private _devalua As DateTime
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String
 
    Private _ccodigo As String
 
    Private _ningreso As Decimal
 
    Private _ncosto As Decimal
 
    Private _nrendimiento As Decimal

    Private _ctipo As String
#End Region
 
#Region " Propiedades "
    Public Property ctipo() As String
        Get
            Return _ctipo
        End Get
        Set(ByVal Value As String)
            _ctipo = Value
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

    Public Property ccodfue() As String
        Get
            Return _ccodfue
        End Get
        Set(ByVal Value As String)
            _ccodfue = Value
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

    Public Property ccodigo() As String
        Get
            Return _ccodigo
        End Get
        Set(ByVal Value As String)
            _ccodigo = Value
        End Set
    End Property

    Public Property ningreso() As Decimal
        Get
            Return _ningreso
        End Get
        Set(ByVal Value As Decimal)
            _ningreso = Value
        End Set
    End Property

    Public Property ncosto() As Decimal
        Get
            Return _ncosto
        End Get
        Set(ByVal Value As Decimal)
            _ncosto = Value
        End Set
    End Property

    Public Property nrendimiento() As Decimal
        Get
            Return _nrendimiento
        End Get
        Set(ByVal Value As Decimal)
            _nrendimiento = Value
        End Set
    End Property

#End Region
End Class
